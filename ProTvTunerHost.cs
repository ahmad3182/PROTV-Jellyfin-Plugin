using MediaBrowser.Controller.Library;
using MediaBrowser.Controller.LiveTv;
using MediaBrowser.Model.Dto;
using MediaBrowser.Model.LiveTv;
using MediaBrowser.Model.MediaInfo;
using Microsoft.Extensions.Logging;
using System.Net;
using System.Net.Sockets;

namespace PROTV.Plugin;

public sealed class ProTvTunerHost : ITunerHost, IConfigurableTunerHost
{
    private const string TunerType = "PROTV";
    private readonly ProTvApiClient _api;
    private readonly ILogger<ProTvTunerHost> _logger;

    public ProTvTunerHost(ProTvApiClient api, ILogger<ProTvTunerHost> logger)
    {
        _api = api;
        _logger = logger;
    }

    public string Name => "PROTV";

    public string Type => TunerType;

    public bool IsSupported => true;

    public async Task<List<ChannelInfo>> GetChannels(bool enableCache, CancellationToken cancellationToken)
    {
        IReadOnlyList<ProTvChannel> channels;
        try
        {
            channels = await _api.GetChannelsAsync(cancellationToken);
        }
        catch (Exception exception) when (exception is not OperationCanceledException)
        {
            // Jellyfin treats an empty channel list as "this tuner has no channels" and deletes the
            // channel items (and their guide data) it created earlier. A PROTV outage that lasts a
            // single guide refresh would then wipe Live TV on every client, so answer with the last
            // list PROTV gave us until it is reachable again.
            var known = ProTvChannelOrdering.FromSnapshot(Plugin.Instance?.Configuration);
            if (known.Count == 0)
            {
                throw;
            }

            _logger.LogWarning(
                exception,
                "PROTV did not answer; keeping the last {ChannelCount} channels so Live TV is not emptied.",
                known.Count);
            channels = known;
        }

        return ProTvChannelOrdering.Sort(channels).Select((channel, index) => new ChannelInfo
        {
            // Id / TunerChannelId stay the PROTV channel id; only the displayed number (which
            // Jellyfin sorts by) follows the alphabetical position.
            Id = channel.Id.ToString(),
            TunerChannelId = channel.Id.ToString(),
            Name = ProTvChannelOrdering.DisplayName(channel),
            Number = (index + 1).ToString(),
            CallSign = channel.TitleEn ?? channel.TitleAr,
            ImageUrl = ProTvChannelOrdering.LogoUrl(channel),
            HasImage = !string.IsNullOrWhiteSpace(ProTvChannelOrdering.LogoUrl(channel)),
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
        // Several viewers of the same channel share one live stream (the way Jellyfin's built-in
        // tuner hosts do) instead of opening a second one, which Jellyfin would reject.
        var uniqueId = ProTvLiveStream.BuildUniqueId(channelId);
        var existing = currentLiveStreams.FirstOrDefault(item =>
            item.EnableStreamSharing
            && string.Equals(item.UniqueId, uniqueId, StringComparison.Ordinal));
        if (existing is not null)
        {
            existing.ConsumerCount++;
            return existing;
        }

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
                RequiresLooping = false,
                AnalyzeDurationMs = ProTvChannelOrdering.AnalyzeDurationMs()
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
                TunerCount = 0
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

internal static class ProTvChannelOrdering
{
    // Shorter ffprobe analysis window = faster playback start. Null leaves Jellyfin's default.
    public static int? AnalyzeDurationMs()
    {
        var value = Plugin.Instance?.Configuration.StreamAnalyzeDurationMs ?? 0;
        return value > 0 ? value : null;
    }

    private static IReadOnlyDictionary<int, ProTvChannelOverride> LoadOverrides()
    {
        var items = Plugin.Instance?.Configuration.ChannelOverrides ?? Array.Empty<ProTvChannelOverride>();
        return items.GroupBy(item => item.ChannelId).ToDictionary(group => group.Key, group => group.Last());
    }

    // Rebuilds PROTV channels from the snapshot ProTvApiClient keeps of the last channel list it
    // fetched, so the tuner (and the home page tab) can keep working while PROTV is unreachable.
    public static List<ProTvChannel> FromSnapshot(PluginConfiguration? configuration)
    {
        return (configuration?.KnownChannels ?? Array.Empty<ProTvKnownChannel>())
            .Select(item => new ProTvChannel
            {
                Id = item.Id,
                TitleEn = item.Name,
                Logo = item.LogoUrl
            })
            .ToList();
    }

    // Logo from the dashboard override when set, otherwise the one PROTV provides.
    public static string? LogoUrl(ProTvChannel channel)
    {
        var overrides = LoadOverrides();
        if (overrides.TryGetValue(channel.Id, out var item) && !string.IsNullOrWhiteSpace(item.LogoUrl))
        {
            return item.LogoUrl.Trim();
        }

        return channel.Logo;
    }

    public static string DisplayName(ProTvChannel channel)
    {
        if (LoadOverrides().TryGetValue(channel.Id, out var item) && !string.IsNullOrWhiteSpace(item.CustomName))
        {
            return item.CustomName.Trim();
        }

        if (!string.IsNullOrWhiteSpace(channel.TitleEn))
        {
            return channel.TitleEn;
        }

        if (!string.IsNullOrWhiteSpace(channel.TitleAr))
        {
            return channel.TitleAr;
        }

        return $"Channel {channel.Id}";
    }

    // Drops channels hidden on the dashboard, then orders by dashboard priority (default 0),
    // then alphabetically by display name; ties broken by channel id so the order is stable.
    public static List<ProTvChannel> Sort(IEnumerable<ProTvChannel> channels)
    {
        var overrides = LoadOverrides();
        return channels
            .Where(channel => !(overrides.TryGetValue(channel.Id, out var item) && item.Hidden))
            .OrderBy(channel => overrides.TryGetValue(channel.Id, out var item) ? item.Priority : 0)
            .ThenBy(DisplayName, StringComparer.OrdinalIgnoreCase)
            .ThenBy(channel => channel.Id)
            .ToList();
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
        UniqueId = BuildUniqueId(channelId);
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
            Container = "ts",
            AnalyzeDurationMs = ProTvChannelOrdering.AnalyzeDurationMs()
        };
    }

    public static string BuildUniqueId(string channelId) => $"PROTV-{channelId}";

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
