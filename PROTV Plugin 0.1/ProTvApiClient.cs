using System.Diagnostics;
using System.Net;
using System.Net.Http.Headers;
using System.Net.Http.Json;
using System.Net.NetworkInformation;
using System.Net.Sockets;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using Microsoft.Extensions.Logging;

namespace PROTV.Plugin;

public sealed class ProTvApiClient
{
    private const string ChannelImageBaseUrl = "http://10.1.0.9:80/";
    private readonly HttpClient _httpClient;
    private readonly ILogger<ProTvApiClient> _logger;
    private readonly Func<PluginConfiguration> _configurationFactory;
    private string? _accessToken;
    private string? _refreshToken;
    private string? _tokenCredentialKey;
    private readonly SemaphoreSlim _authLock = new(1, 1);

    public ProTvApiClient(HttpClient httpClient, ILogger<ProTvApiClient> logger, Func<PluginConfiguration> configurationFactory)
    {
        _httpClient = httpClient;
        _logger = logger;
        _configurationFactory = configurationFactory;
    }

    private PluginConfiguration Configuration => _configurationFactory();

    public async Task<IReadOnlyList<ProTvChannel>> GetChannelsAsync(CancellationToken cancellationToken)
    {
        var response = await SendAsync<ProTvListResponse<ProTvChannel>>(
            HttpMethod.Get,
            "api/Channels?Page=1&Count=1000&Order=Desc",
            cancellationToken);
        var channels = (response.Data?.Result ?? Array.Empty<ProTvChannel>())
            .Select(channel =>
            {
                channel.Logo = NormalizeImageUrl(channel.Logo);
                return channel;
            })
            .OrderBy(channel => channel.TitleEn ?? channel.TitleAr ?? string.Empty, StringComparer.OrdinalIgnoreCase)
            .ToList();
        _logger.LogInformation("PROTV returned {ChannelCount} channels.", channels.Count);
        return channels;
    }

    private string? NormalizeImageUrl(string? imagePath)
    {
        if (string.IsNullOrWhiteSpace(imagePath))
        {
            return null;
        }

        var image = imagePath.Trim();
        if (Uri.TryCreate(image, UriKind.Absolute, out var absoluteUri)
            && absoluteUri.Scheme is "http" or "https")
        {
            return absoluteUri.ToString();
        }

        if (!Uri.TryCreate(ChannelImageBaseUrl, UriKind.Absolute, out var baseUri)
            || !Uri.TryCreate(baseUri, image, out var relativeUri))
        {
            _logger.LogWarning("PROTV returned an invalid channel logo path.");
            return null;
        }

        return relativeUri.ToString();
    }

    public async Task<string> WatchChannelAsync(int channelId, CancellationToken cancellationToken)
    {
        try
        {
            var response = await SendAsync<ProTvResponse<string>>(
                HttpMethod.Post,
                $"api/Channels/Watch?Id={channelId}",
                cancellationToken);
            if (!string.IsNullOrWhiteSpace(response.Data))
            {
                return response.Data;
            }
        }
        catch (HttpRequestException exception) when (
            exception.Message.Contains("405", StringComparison.OrdinalIgnoreCase)
            || exception.Message.Contains("404", StringComparison.OrdinalIgnoreCase))
        {
            try
            {
                var response = await SendAsync<ProTvResponse<string>>(
                    HttpMethod.Get,
                    $"api/Channels/Watch?Id={channelId}",
                    cancellationToken);
                if (!string.IsNullOrWhiteSpace(response.Data))
                {
                    return response.Data;
                }
            }
            catch (HttpRequestException retryException) when (
                retryException.Message.Contains("405", StringComparison.OrdinalIgnoreCase)
                || retryException.Message.Contains("404", StringComparison.OrdinalIgnoreCase))
            {
                _logger.LogInformation("PROTV watch endpoint is unavailable for channel {ChannelId}; using multicast fallback.", channelId);
            }
        }

        return GetConfiguredMulticastUrl(channelId);
    }

    private string GetConfiguredMulticastUrl()
    {
        var configuration = Configuration;
        var multicastAddress = string.IsNullOrWhiteSpace(configuration.MulticastAddress)
            ? "225.2.0.105"
            : configuration.MulticastAddress;
        var multicastPort = configuration.MulticastPort is >= 1 and <= 65535
            ? configuration.MulticastPort
            : 1234;
        if (IPAddress.TryParse(multicastAddress, out var address)
            && address.AddressFamily == AddressFamily.InterNetwork
            && address.GetAddressBytes()[0] is >= 224 and <= 239
            && multicastPort is >= 1 and <= 65535)
        {
            return $"udp://@{address}:{multicastPort}";
        }

        throw new InvalidOperationException("PROTV returned no stream URL and no valid multicast fallback is configured.");
    }

    private string GetConfiguredMulticastUrl(int channelId)
    {
        var channelMappings = new Dictionary<int, string>
        {
            [75] = "225.2.0.105",
            [78] = "225.2.0.109",
            [77] = "225.2.0.110",
            [76] = "225.2.0.76",
            [62] = "225.2.0.52",
            [128] = "225.2.0.111",
            [60] = "225.2.0.70",
            [201] = "225.2.0.93",
            [207] = "225.2.0.226",
            [11] = "225.2.0.173",
            [180] = "225.2.0.174",
            [63] = "225.2.0.107",
            [20] = "225.2.0.129",
            [64] = "225.2.0.117",
            [191] = "225.2.0.172",
            [21] = "225.2.0.130",
            [38] = "225.2.0.150",
            [6] = "225.2.0.175",
            [5] = "225.2.0.132",
            [4] = "225.2.0.133",
            [3] = "225.2.0.134",
            [2] = "225.2.0.135",
            [9] = "225.2.0.136",
            [19] = "225.2.0.137",
            [148] = "225.2.0.225",
            [136] = "225.2.0.229",
            [80] = "225.2.0.113",
            [42] = "225.2.0.114",
            [116] = "225.2.0.115",
            [13] = "225.2.0.116",
            [12] = "225.2.0.118",
            [39] = "225.2.0.119",
            [34] = "225.2.0.40",
            [33] = "225.2.0.215",
            [32] = "225.2.0.43",
            [23] = "225.2.0.89",
            [26] = "225.2.0.205",
            [27] = "225.2.0.204",
            [25] = "225.2.0.207",
            [24] = "225.2.0.206",
            [65] = "225.2.0.220",
            [66] = "225.2.0.223",
            [143] = "225.2.0.125",
            [213] = "225.2.0.212",
            [36] = "225.2.0.13",
            [35] = "225.2.0.15",
            [37] = "225.2.0.14",
            [83] = "225.2.0.201",
            [194] = "225.2.0.202",
            [150] = "225.2.0.224",
            [129] = "225.2.0.230",
            [139] = "225.2.0.203",
            [225] = "225.2.0.102",
            [217] = "225.2.0.22",
            [226] = "225.2.0.217",
            [227] = "225.2.0.239",
            [212] = "225.2.0.126",
            [198] = "225.2.0.131",
            [118] = "225.2.0.30",
            [117] = "225.2.0.50",
            [115] = "225.2.0.74",
            [112] = "225.2.0.34"
        };

        if (channelMappings.TryGetValue(channelId, out var multicastAddress))
        {
            return $"udp://@{multicastAddress}:1234";
        }

        return GetConfiguredMulticastUrl();
    }

    public async Task<IReadOnlyList<ProTvEpgChannel>> GetEpgAsync(CancellationToken cancellationToken)
    {
        var response = await SendAsync<ProTvResponse<IReadOnlyList<ProTvEpgChannel>>>(
            HttpMethod.Get,
            "api/Channels/EPGs",
            cancellationToken);
        return response.Data ?? Array.Empty<ProTvEpgChannel>();
    }

    private async Task<T> SendAsync<T>(HttpMethod method, string path, CancellationToken cancellationToken)
    {
        await EnsureAuthenticatedAsync(cancellationToken);
        using var response = await SendAuthorizedAsync(method, path, cancellationToken);
        if (response.StatusCode == System.Net.HttpStatusCode.Unauthorized)
        {
            _accessToken = null;
            _refreshToken = null;
            _tokenCredentialKey = null;
            await EnsureAuthenticatedAsync(cancellationToken);
            using var retry = await SendAuthorizedAsync(method, path, cancellationToken);
            retry.EnsureSuccessStatusCode();
            return await retry.Content.ReadFromJsonAsync<T>(cancellationToken: cancellationToken)
                ?? throw new InvalidOperationException("PROTV returned an empty response.");
        }

        response.EnsureSuccessStatusCode();
        return await response.Content.ReadFromJsonAsync<T>(cancellationToken: cancellationToken)
            ?? throw new InvalidOperationException("PROTV returned an empty response.");
    }

    private Task<HttpResponseMessage> SendAuthorizedAsync(
        HttpMethod method,
        string path,
        CancellationToken cancellationToken)
    {
        var request = new HttpRequestMessage(method, BuildUri(path));
        request.Headers.Authorization = new AuthenticationHeaderValue("Bearer", _accessToken);
        return SendAndDisposeRequestAsync(request, cancellationToken);
    }

    private async Task<HttpResponseMessage> SendAndDisposeRequestAsync(
        HttpRequestMessage request,
        CancellationToken cancellationToken)
    {
        try
        {
            return await _httpClient.SendAsync(request, cancellationToken);
        }
        finally
        {
            request.Dispose();
        }
    }

    private static string BuildCredentialKey(PluginConfiguration configuration)
    {
        return string.Join("\n", configuration.ApiBaseUrl?.Trim() ?? string.Empty, configuration.Username?.Trim() ?? string.Empty, configuration.Password ?? string.Empty);
    }

    private async Task EnsureAuthenticatedAsync(CancellationToken cancellationToken)
    {
        var configuration = Configuration;
        var credentialKey = BuildCredentialKey(configuration);

        await _authLock.WaitAsync(cancellationToken);
        try
        {
            // Saved credentials or URL changed since the cached tokens were issued: throw the tokens away.
            if (_tokenCredentialKey is not null && !string.Equals(_tokenCredentialKey, credentialKey, StringComparison.Ordinal))
            {
                _logger.LogInformation("PROTV settings changed; discarding cached tokens.");
                _accessToken = null;
                _refreshToken = null;
            }

            if (!string.IsNullOrWhiteSpace(_accessToken))
            {
                return;
            }

            if (!string.IsNullOrWhiteSpace(_refreshToken))
            {
                try
                {
                    await RefreshAsync(cancellationToken);
                    _tokenCredentialKey = credentialKey;
                    return;
                }
                catch (HttpRequestException exception)
                {
                    _logger.LogInformation(exception, "PROTV token refresh failed; logging in with the saved credentials.");
                    _accessToken = null;
                    _refreshToken = null;
                }
            }

            var username = configuration.Username?.Trim();
            var password = configuration.Password;
            if (string.IsNullOrWhiteSpace(username) || string.IsNullOrEmpty(password))
            {
                throw new InvalidOperationException("PROTV username and password are not saved. Enter them in Dashboard > Plugins > PROTV and press Save.");
            }

            var device = ProTvDeviceInfo.Detect(configuration);
            var payload = new ProTvLoginRequest(username, password, device.IpAddress);
            var json = JsonSerializer.Serialize(payload);
            _logger.LogInformation(
                "PROTV logging in with saved credentials. UserName={UserName}, PasswordLength={PasswordLength}",
                username,
                password.Length);
            using var request = new HttpRequestMessage(HttpMethod.Post, BuildUri("api/Account/Login"))
            {
                Content = new StringContent(json, Encoding.UTF8, "application/json")
            };
            AddDeviceHeaders(request);
            using var response = await _httpClient.SendAsync(request, cancellationToken);
            response.EnsureSuccessStatusCode();
            var login = await response.Content.ReadFromJsonAsync<ProTvResponse<ProTvLoginData>>(cancellationToken: cancellationToken)
                ?? throw new InvalidOperationException("PROTV returned an empty login response.");
            SetTokens(login.Data);
            _tokenCredentialKey = credentialKey;
        }
        finally
        {
            _authLock.Release();
        }
    }

    private async Task RefreshAsync(CancellationToken cancellationToken)
    {
        using var request = new HttpRequestMessage(HttpMethod.Post, BuildUri("api/Account/RefreshToken"));
        request.Headers.Add("refresh-token", _refreshToken);
        AddDeviceHeaders(request);
        using var response = await _httpClient.SendAsync(request, cancellationToken);
        response.EnsureSuccessStatusCode();
        var login = await response.Content.ReadFromJsonAsync<ProTvResponse<ProTvLoginData>>(cancellationToken: cancellationToken)
            ?? throw new InvalidOperationException("PROTV returned an empty refresh response.");
        SetTokens(login.Data);
    }

    private void SetTokens(ProTvLoginData? data)
    {
        _accessToken = NormalizeToken(data?.Profile?.Token ?? data?.Token ?? data?.AccessToken);
        _refreshToken = NormalizeToken(data?.Client?.RefreshToken ?? data?.RefreshToken);
        if (string.IsNullOrWhiteSpace(_accessToken))
        {
            throw new InvalidOperationException("PROTV did not return an access token.");
        }
    }

    private static string? NormalizeToken(string? token)
    {
        if (string.IsNullOrWhiteSpace(token))
        {
            return null;
        }

        return token.StartsWith("Bearer ", StringComparison.OrdinalIgnoreCase)
            ? token["Bearer ".Length..].Trim()
            : token.Trim();
    }

    private void AddDeviceHeaders(HttpRequestMessage request)
    {
        var device = ProTvDeviceInfo.Detect(Configuration);
        request.Headers.Add("Accept-Language", "en-US");
        request.Headers.Add("device-type", "Desktop");
        request.Headers.Add("device-os", "Windows10");
        request.Headers.Add("app-version", Configuration.AppVersion);
        request.Headers.Add(
            "app-id",
            string.IsNullOrWhiteSpace(Configuration.AppId)
                ? "ca88f40a-3056-4c52-9614-8d75a3b0b178"
                : Configuration.AppId);
        request.Headers.Add("device-ip", device.IpAddress);
        request.Headers.Add("device-mac-address", device.MacAddress);
        request.Headers.Add("router-mac-address", device.RouterMacAddress);
        request.Headers.Add("device-model", device.Model);
        request.Headers.Add("push-token", string.Empty);
        request.Headers.Add("notification-token", string.Empty);
    }

    private Uri BuildUri(string path)
    {
        return new Uri(new Uri(Configuration.ApiBaseUrl.TrimEnd('/') + "/"), path);
    }
}

internal sealed record ProTvDeviceInfo(string IpAddress, string MacAddress, string RouterMacAddress, string Model)
{
    public static ProTvDeviceInfo Detect(PluginConfiguration configuration)
    {
        var ipAddress = DetectIpAddress(configuration.ApiBaseUrl, configuration.DeviceIpAddress);
        var macAddress = DetectMacAddress(configuration.DeviceMacAddress);
        var gateway = DetectGateway();
        var routerMacAddress = string.IsNullOrWhiteSpace(configuration.RouterMacAddress)
            ? DetectGatewayMac(gateway)
            : configuration.RouterMacAddress;
        var model = string.IsNullOrWhiteSpace(configuration.DeviceModel)
            || configuration.DeviceModel.Equals("Jellyfin Server", StringComparison.OrdinalIgnoreCase)
            ? Environment.MachineName
            : configuration.DeviceModel;

        return new ProTvDeviceInfo(ipAddress, macAddress, routerMacAddress, model);
    }

    private static readonly object IpCacheLock = new();
    private static string? _cachedIp;
    private static DateTime _cachedIpUtc = DateTime.MinValue;
    private static readonly TimeSpan IpCacheLifetime = TimeSpan.FromMinutes(10);

    private static string DetectIpAddress(string apiBaseUrl, string fallback)
    {
        // An explicitly configured address always wins and needs no network calls.
        if (!string.IsNullOrWhiteSpace(fallback))
        {
            return fallback.Trim();
        }

        lock (IpCacheLock)
        {
            if (_cachedIp is not null && DateTime.UtcNow - _cachedIpUtc < IpCacheLifetime)
            {
                return _cachedIp;
            }
        }

        var detected = DetectIpAddressUncached(apiBaseUrl);
        lock (IpCacheLock)
        {
            _cachedIp = detected;
            _cachedIpUtc = DateTime.UtcNow;
        }

        return detected;
    }

    private static string DetectIpAddressUncached(string apiBaseUrl)
    {
        try
        {
            using var publicIpClient = new HttpClient { Timeout = TimeSpan.FromSeconds(3) };
            var publicIp = publicIpClient.GetStringAsync("https://api.ipify.org").GetAwaiter().GetResult().Trim();
            if (IPAddress.TryParse(publicIp, out var parsedPublicIp) && parsedPublicIp.AddressFamily == AddressFamily.InterNetwork)
            {
                return parsedPublicIp.ToString();
            }
        }
        catch
        {
        }

        try
        {
            using var socket = new Socket(AddressFamily.InterNetwork, SocketType.Dgram, ProtocolType.Udp);
            socket.Connect(new Uri(apiBaseUrl).Host, 82);
            return ((IPEndPoint)socket.LocalEndPoint!).Address.ToString();
        }
        catch
        {
            return string.Empty;
        }
    }

    private static string DetectMacAddress(string fallback)
    {
        var adapter = NetworkInterface.GetAllNetworkInterfaces()
            .Where(item => item.OperationalStatus == OperationalStatus.Up)
            .Where(item => item.NetworkInterfaceType is NetworkInterfaceType.Ethernet or NetworkInterfaceType.Wireless80211)
            .OrderBy(item => item.Id)
            .FirstOrDefault();
        var address = adapter?.GetPhysicalAddress().GetAddressBytes();
        return address is { Length: > 0 }
            ? string.Join(":", address.Select(value => value.ToString("X2")))
            : fallback ?? string.Empty;
    }

    private static string DetectGateway()
    {
        return NetworkInterface.GetAllNetworkInterfaces()
            .Where(item => item.OperationalStatus == OperationalStatus.Up)
            .SelectMany(item => item.GetIPProperties().GatewayAddresses)
            .Select(item => item.Address)
            .FirstOrDefault(item => item.AddressFamily == AddressFamily.InterNetwork)?.ToString() ?? string.Empty;
    }

    private static string DetectGatewayMacLinux(string gateway)
    {
        try
        {
            // /proc/net/arp columns: IP address, HW type, Flags, HW address, Mask, Device
            foreach (var line in File.ReadLines("/proc/net/arp").Skip(1))
            {
                var parts = line.Split(' ', StringSplitOptions.RemoveEmptyEntries);
                if (parts.Length >= 4
                    && parts[0] == gateway
                    && parts[3] != "00:00:00:00:00:00")
                {
                    return parts[3].ToUpperInvariant();
                }
            }
        }
        catch
        {
        }

        return string.Empty;
    }

    private static string DetectGatewayMac(string gateway)
    {
        if (string.IsNullOrWhiteSpace(gateway))
        {
            return string.Empty;
        }

        if (OperatingSystem.IsLinux())
        {
            return DetectGatewayMacLinux(gateway);
        }

        if (!OperatingSystem.IsWindows())
        {
            return string.Empty;
        }

        try
        {
            using var process = Process.Start(new ProcessStartInfo
            {
                FileName = "arp.exe",
                Arguments = $"-a {gateway}",
                RedirectStandardOutput = true,
                UseShellExecute = false,
                CreateNoWindow = true
            });
            var output = process?.StandardOutput.ReadToEnd() ?? string.Empty;
            process?.WaitForExit(2000);
            var match = System.Text.RegularExpressions.Regex.Match(output, @"([0-9a-f]{2}(?:-[0-9a-f]{2}){5})", System.Text.RegularExpressions.RegexOptions.IgnoreCase);
            return match.Success ? match.Value.Replace('-', ':').ToUpperInvariant() : string.Empty;
        }
        catch
        {
            return string.Empty;
        }
    }
}

public sealed record ProTvLoginRequest(
    [property: JsonPropertyName("UserName")] string UserName,
    [property: JsonPropertyName("Password")] string Password,
    [property: JsonPropertyName("IpAddress")] string IpAddress);

public class ProTvResponse<T>
{
    public T? Data { get; set; }
    public bool Status { get; set; }
    public string? Message { get; set; }
}

public sealed class ProTvListResponse<T> : ProTvResponse<ProTvDataList<T>>;

public sealed class ProTvDataList<T>
{
    public IReadOnlyList<T>? Result { get; set; }
    public int PageCount { get; set; }
    public int PageSize { get; set; }
    public int CurrentPage { get; set; }
    public int Total { get; set; }
}

public sealed class ProTvLoginData
{
    public ProTvProfile? Profile { get; set; }
    public ProTvClient? Client { get; set; }
    public string? Token { get; set; }
    public string? AccessToken { get; set; }
    public string? RefreshToken { get; set; }
}

public sealed class ProTvProfile
{
    public string? Token { get; set; }
}

public sealed class ProTvClient
{
    public string? RefreshToken { get; set; }
}

public sealed class ProTvChannel
{
    public int Id { get; set; }
    public int FixedNumber { get; set; }
    public string? TitleEn { get; set; }
    public string? TitleAr { get; set; }
    public string? Logo { get; set; }
    public string? LauncherURL { get; set; }
    public string? WebURL { get; set; }
}

public sealed class ProTvEpgChannel
{
    public int ChannelId { get; set; }
    public string? ChannelName { get; set; }
    public IReadOnlyList<ProTvEpgItem>? Programs { get; set; }
}

public sealed class ProTvEpgItem
{
    public string? Title { get; set; }
    public string? Description { get; set; }
    public DateTime StartTime { get; set; }
    public DateTime EndTime { get; set; }
}
