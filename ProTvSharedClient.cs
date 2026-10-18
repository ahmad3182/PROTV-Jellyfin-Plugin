using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Logging.Abstractions;

namespace PROTV.Plugin;

// One PROTV API client for the whole plugin (tuner, guide, home page tab and VOD). The login
// tokens live inside the client, so a client per call meant a login per call; sharing one means
// one login, then token reuse and refresh. It reads the saved settings live and drops its tokens
// when they change.
internal static class ProTvSharedClient
{
    private static readonly object Gate = new();
    private static readonly HttpClient SharedHttp = new();
    private static ProTvApiClient? _client;

    // The first caller creates the client; everyone after gets the same one.
    public static ProTvApiClient GetOrCreate(
        HttpClient? httpClient,
        ILogger<ProTvApiClient>? logger,
        Func<PluginConfiguration>? configurationFactory)
    {
        lock (Gate)
        {
            _client ??= new ProTvApiClient(
                httpClient ?? SharedHttp,
                logger ?? NullLogger<ProTvApiClient>.Instance,
                configurationFactory ?? (() => Plugin.Instance?.Configuration ?? new PluginConfiguration()));
            return _client;
        }
    }

    public static ProTvApiClient Get() => GetOrCreate(null, null, null);
}
