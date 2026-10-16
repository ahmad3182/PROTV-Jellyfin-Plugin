using MediaBrowser.Controller.Library;
using MediaBrowser.Controller.LiveTv;
using MediaBrowser.Model.Dto;
using MediaBrowser.Model.LiveTv;
using MediaBrowser.Model.MediaInfo;
using System.Net;
using System.Net.Sockets;

namespace PROTV.Plugin;

public sealed class ProTvTunerHost : ITunerHost, IConfigurableTunerHost
{
    private const string TunerType = "PROTV";
    private readonly ProTvApiClient _api;

    public ProTvTunerHost(ProTvApiClient api)
    {
        _api = api;
    }

    public string Name => "PROTV";

    public string Type => TunerType;

    public bool IsSupported => true;

    public async Task<List<ChannelInfo>> GetChannels(bool enableCache, CancellationToken cancellationToken)
    {
        var channels = await _api.GetChannelsAsync(cancellationToken);
        return channels.Select(channel => new ChannelInfo
        {
            Id = channel.Id.ToString(),
            TunerChannelId = channel.Id.ToString(),
            Name = FirstNonEmpty(channel.TitleEn, channel.TitleAr, $"Channel {channel.Id}"),
            Number = channel.Id.ToString(),
            CallSign = channel.TitleEn ?? channel.TitleAr,
            ImageUrl = channel.Logo,
            HasImage = !string.IsNullOrWhiteSpace(channel.Logo),
            ChannelType = ChannelType.TV,
            TunerHostId = TunerType
        }).ToList();
    }

    public async Task<ILiveStream> GetChannelStream(
        string channelId,
        string streamId,
        IList<ILiveStream> currentLiveStreams,
        CancellationToken cancellationToken)
    {
        var streamUrl = await _api.WatchChannelAsync(int.Parse(channelId), cancellationToken);
        return new ProTvLiveStream(streamUrl, channelId, TunerType);
    }

    public async Task<List<MediaSourceInfo>> GetChannelStreamMediaSources(string channelId, CancellationToken cancellationToken)
    {
        var streamUrl = await _api.WatchChannelAsync(int.Parse(channelId), cancellationToken);
        var isUdp = streamUrl.StartsWith("udp://", StringComparison.OrdinalIgnoreCase)
            || streamUrl.StartsWith("rtp://", StringComparison.OrdinalIgnoreCase);
        return new List<MediaSourceInfo>
        {
            new()
            {
                Id = channelId,
                Path = streamUrl,
                Protocol = isUdp ? MediaProtocol.Udp : MediaProtocol.Http,
                Type = MediaSourceType.Default,
                IsRemote = true,
                IsInfiniteStream = true,
                SupportsDirectPlay = true,
                SupportsDirectStream = true,
                SupportsTranscoding = true,
                RequiresOpening = true,
                Container = "ts",
                RequiresLooping = false
            }
        };
    }

    public Task<List<TunerHostInfo>> DiscoverDevices(int discoveryDurationMs, CancellationToken cancellationToken)
    {
        return Task.FromResult(new List<TunerHostInfo>
        {
            new()
            {
                Id = TunerType,
                Type = TunerType,
                FriendlyName = Name,
                Url = Plugin.Instance?.Configuration.ApiBaseUrl,
                DeviceId = TunerType,
                TunerCount = 1
            }
        });
    }

    public async Task Validate(TunerHostInfo info)
    {
        if (!Uri.TryCreate(Plugin.Instance?.Configuration.ApiBaseUrl, UriKind.Absolute, out _))
        {
            throw new ArgumentException("The PROTV API URL is invalid.", nameof(info));
        }

        await _api.GetChannelsAsync(CancellationToken.None);
    }

    private static string FirstNonEmpty(params string?[] values)
    {
        return values.FirstOrDefault(value => !string.IsNullOrWhiteSpace(value)) ?? "PROTV";
    }
}

internal sealed class ProTvLiveStream : ILiveStream
{
    private readonly HttpClient _httpClient = new();
    private readonly bool _isUdp;
    private readonly string _url;
    private Stream? _stream;

    public ProTvLiveStream(string url, string channelId, string tunerHostId)
    {
        _url = url;
        _isUdp = url.StartsWith("udp://", StringComparison.OrdinalIgnoreCase)
            || url.StartsWith("rtp://", StringComparison.OrdinalIgnoreCase);
        OriginalStreamId = channelId;
        TunerHostId = tunerHostId;
        UniqueId = $"PROTV-{channelId}";
        MediaSource = new MediaSourceInfo
        {
            Id = channelId,
            Path = url,
            Protocol = _isUdp ? MediaProtocol.Udp : MediaProtocol.Http,
            Type = MediaSourceType.Default,
            IsRemote = true,
            IsInfiniteStream = true,
            SupportsDirectPlay = true,
            SupportsDirectStream = true,
            SupportsTranscoding = true,
            Container = "ts"
        };
    }

    public int ConsumerCount { get; set; }
    public string OriginalStreamId { get; set; }
    public string TunerHostId { get; }
    public bool EnableStreamSharing => true;
    public MediaSourceInfo MediaSource { get; set; }
    public string UniqueId { get; }

    public async Task Open(CancellationToken openCancellationToken)
    {
        _stream = _isUdp
            ? await MulticastStream.OpenAsync(_url, openCancellationToken)
            : await _httpClient.GetStreamAsync(_url, openCancellationToken);
    }

    public Task Close()
    {
        _stream?.Dispose();
        _stream = null;
        return Task.CompletedTask;
    }

    public Stream GetStream()
    {
        return _stream ?? throw new InvalidOperationException("The PROTV stream is not open.");
    }

    public void Dispose()
    {
        _stream?.Dispose();
        _httpClient.Dispose();
    }
}

internal sealed class MulticastStream : Stream
{
    private readonly UdpClient _client;
    private byte[]? _pending;
    private int _pendingOffset;
    private bool _disposed;

    private MulticastStream(UdpClient client)
    {
        _client = client;
    }

    public static Task<MulticastStream> OpenAsync(string url, CancellationToken cancellationToken)
    {
        if (!Uri.TryCreate(url, UriKind.Absolute, out var uri)
            || !IPAddress.TryParse(uri.Host, out var multicastAddress)
            || multicastAddress.AddressFamily != AddressFamily.InterNetwork
            || !multicastAddress.GetAddressBytes()[0].IsInRange(224, 239)
            || uri.Port is < 1 or > 65535)
        {
            throw new InvalidOperationException($"The PROTV multicast URL is invalid: {url}");
        }

        var client = new UdpClient(AddressFamily.InterNetwork);
        try
        {
            client.Client.SetSocketOption(SocketOptionLevel.Socket, SocketOptionName.ReuseAddress, true);

            var localInterface = ResolveLocalInterface();

            // On Linux a socket bound to 0.0.0.0:port receives datagrams for EVERY multicast group
            // joined on that port by any socket on the host (IP_MULTICAST_ALL), which mixes channels
            // together because all PROTV channels use port 1234. Binding to the group address itself
            // restricts delivery to this group. Windows cannot bind to a multicast address, so keep
            // IPAddress.Any there (Windows already filters by group membership).
            var bindAddress = OperatingSystem.IsWindows() ? IPAddress.Any : multicastAddress;
            client.Client.Bind(new IPEndPoint(bindAddress, uri.Port));

            if (localInterface is not null)
            {
                client.JoinMulticastGroup(multicastAddress, localInterface);
            }
            else
            {
                client.JoinMulticastGroup(multicastAddress);
            }

            return Task.FromResult(new MulticastStream(client));
        }
        catch
        {
            client.Dispose();
            throw;
        }
    }

    private static IPAddress? ResolveLocalInterface()
    {
        // 1. Explicit override from the plugin configuration.
        var configured = Plugin.Instance?.Configuration.MulticastInterfaceAddress;
        if (!string.IsNullOrWhiteSpace(configured)
            && IPAddress.TryParse(configured.Trim(), out var configuredAddress)
            && configuredAddress.AddressFamily == AddressFamily.InterNetwork)
        {
            return configuredAddress;
        }

        // 2. Prefer the interface that routes to the PROTV API host.
        try
        {
            var apiUrl = Plugin.Instance?.Configuration.ApiBaseUrl;
            if (Uri.TryCreate(apiUrl, UriKind.Absolute, out var apiUri))
            {
                var apiHost = Dns.GetHostAddresses(apiUri.Host)
                    .FirstOrDefault(item => item.AddressFamily == AddressFamily.InterNetwork);
                if (apiHost is not null)
                {
                    using var probe = new Socket(AddressFamily.InterNetwork, SocketType.Dgram, ProtocolType.Udp);
                    probe.Connect(apiHost, 9);
                    if (probe.LocalEndPoint is IPEndPoint local && !IPAddress.IsLoopback(local.Address))
                    {
                        return local.Address;
                    }
                }
            }
        }
        catch
        {
            // fall through
        }

        // 3. First usable multicast-capable IPv4 interface.
        try
        {
            return System.Net.NetworkInformation.NetworkInterface.GetAllNetworkInterfaces()
                .Where(item => item.OperationalStatus == System.Net.NetworkInformation.OperationalStatus.Up
                    && item.SupportsMulticast
                    && item.NetworkInterfaceType != System.Net.NetworkInformation.NetworkInterfaceType.Loopback)
                .SelectMany(item => item.GetIPProperties().UnicastAddresses)
                .Select(item => item.Address)
                .FirstOrDefault(item => item.AddressFamily == AddressFamily.InterNetwork);
        }
        catch
        {
            return null;
        }
    }

    public override async ValueTask<int> ReadAsync(
        Memory<byte> buffer,
        CancellationToken cancellationToken = default)
    {
        ObjectDisposedException.ThrowIf(_disposed, this);
        if (buffer.Length == 0)
        {
            return 0;
        }

        while (true)
        {
            if (_pending is not null)
            {
                var available = _pending.Length - _pendingOffset;
                var count = Math.Min(available, buffer.Length);
                _pending.AsMemory(_pendingOffset, count).CopyTo(buffer);
                _pendingOffset += count;
                if (_pendingOffset == _pending.Length)
                {
                    _pending = null;
                    _pendingOffset = 0;
                }

                return count;
            }

            var datagram = await _client.ReceiveAsync(cancellationToken);
            if (datagram.Buffer.Length > 0)
            {
                _pending = datagram.Buffer;
            }
        }
    }

    public override int Read(byte[] buffer, int offset, int count)
    {
        return ReadAsync(buffer.AsMemory(offset, count)).AsTask().GetAwaiter().GetResult();
    }

    protected override void Dispose(bool disposing)
    {
        if (disposing && !_disposed)
        {
            _disposed = true;
            _client.Dispose();
        }

        base.Dispose(disposing);
    }

    public override bool CanRead => !_disposed;
    public override bool CanSeek => false;
    public override bool CanWrite => false;
    public override long Length => throw new NotSupportedException();
    public override long Position
    {
        get => throw new NotSupportedException();
        set => throw new NotSupportedException();
    }

    public override void Flush() => throw new NotSupportedException();
    public override long Seek(long offset, SeekOrigin origin) => throw new NotSupportedException();
    public override void SetLength(long value) => throw new NotSupportedException();
    public override void Write(byte[] buffer, int offset, int count) => throw new NotSupportedException();
}

internal static class IpAddressExtensions
{
    public static bool IsInRange(this byte value, byte minimum, byte maximum)
    {
        return value >= minimum && value <= maximum;
    }
}
