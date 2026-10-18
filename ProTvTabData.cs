using System.Text.Json.Serialization;
using Microsoft.Extensions.Logging.Abstractions;

namespace PROTV.Plugin;

// One channel as the Jellyfin home page tab shows it: the same number, name and logo the
// PROTV tuner hands to Jellyfin, including the dashboard renames / hidden flags / ordering.
public sealed class ProTvTabChannel
{
    [JsonPropertyName("id")]
    public int Id { get; set; }

    [JsonPropertyName("number")]
    public string Number { get; set; } = string.Empty;

    [JsonPropertyName("name")]
    public string Name { get; set; } = string.Empty;

    [JsonPropertyName("logoUrl")]
    public string? LogoUrl { get; set; }

    // The Jellyfin Live TV channel item this PROTV channel became. The tab plays it, so the
    // channel opens in the same player Live TV uses (and in every Jellyfin app).
    [JsonPropertyName("itemId")]
    public string ItemId { get; set; } = string.Empty;

    // False while Jellyfin has not stored the channel item yet (no guide refresh since the
    // channel appeared), which is when playback cannot work either.
    [JsonPropertyName("inLiveTv")]
    public bool InLiveTv { get; set; }
}

public sealed class ProTvTabChannels
{
    [JsonPropertyName("title")]
    public string Title { get; set; } = "PROTV";

    [JsonPropertyName("total")]
    public int Total { get; set; }

    [JsonPropertyName("channels")]
    public IReadOnlyList<ProTvTabChannel> Channels { get; set; } = Array.Empty<ProTvTabChannel>();
}

public sealed class ProTvTabRequirement
{
    [JsonPropertyName("name")]
    public string Name { get; set; } = string.Empty;

    [JsonPropertyName("installed")]
    public bool Installed { get; set; }

    [JsonPropertyName("loaded")]
    public bool Loaded { get; set; }
}

public sealed class ProTvTabStatus
{
    [JsonPropertyName("requirements")]
    public IReadOnlyList<ProTvTabRequirement> Requirements { get; set; } = Array.Empty<ProTvTabRequirement>();

    [JsonPropertyName("requireCompanionPlugins")]
    public bool RequireCompanionPlugins { get; set; } = true;

    [JsonPropertyName("frontpageTabEnabled")]
    public bool FrontpageTabEnabled { get; set; } = true;

    [JsonPropertyName("frontpageTabTitle")]
    public string FrontpageTabTitle { get; set; } = "PROTV";

    [JsonPropertyName("tabRegistered")]
    public bool TabRegistered { get; set; }

    [JsonPropertyName("channelCount")]
    public int ChannelCount { get; set; }
}

internal static class ProTvTabData
{
    // The saved channel list (kept fresh by the tuner / guide refresh) is used by default so the
    // tab is instant and does not depend on the PROTV service being reachable. refresh=true asks
    // PROTV again, the same way a guide refresh would.
    public static async Task<ProTvTabChannels> GetChannelsAsync(bool refresh, CancellationToken cancellationToken)
    {
        var configuration = Plugin.Instance?.Configuration;
        IReadOnlyList<ProTvChannel>? channels = null;
        if (refresh)
        {
            channels = await TryFetchLiveAsync(configuration, cancellationToken);
        }

        channels ??= FromSnapshot(configuration);
        return Build(channels, Title(configuration));
    }

    public static ProTvTabStatus GetStatus()
    {
        var configuration = Plugin.Instance?.Configuration;
        return new ProTvTabStatus
        {
            Requirements = ProTvRequirements.Check().Requirements
                .Select(item => new ProTvTabRequirement
                {
                    Name = item.DisplayName,
                    Installed = item.Installed,
                    Loaded = item.Loaded
                })
                .ToList(),
            RequireCompanionPlugins = configuration?.RequireCompanionPlugins ?? true,
            FrontpageTabEnabled = configuration?.FrontpageTabEnabled ?? true,
            FrontpageTabTitle = Title(configuration),
            TabRegistered = ProTvCustomTabs.IsRegistered(),
            ChannelCount = configuration?.KnownChannels?.Length ?? 0
        };
    }

    private static string Title(PluginConfiguration? configuration)
        => string.IsNullOrWhiteSpace(configuration?.FrontpageTabTitle) ? "PROTV" : configuration!.FrontpageTabTitle.Trim();

    // Rebuilds PROTV channels from the saved snapshot so the shared ordering / rename / hide /
    // logo logic (ProTvChannelOrdering) produces exactly what the tuner serves.
    private static List<ProTvChannel> FromSnapshot(PluginConfiguration? configuration)
        => ProTvChannelOrdering.FromSnapshot(configuration);

    private static ProTvTabChannels Build(IReadOnlyList<ProTvChannel> channels, string title)
    {
        var ordered = ProTvChannelOrdering.Sort(channels);
        var items = new List<ProTvTabChannel>(ordered.Count);
        for (var index = 0; index < ordered.Count; index++)
        {
            var channel = ordered[index];
            var item = ProTvLiveTvItems.Resolve(channel.Id);
            items.Add(new ProTvTabChannel
            {
                Id = channel.Id,
                Number = (index + 1).ToString(),
                Name = ProTvChannelOrdering.DisplayName(channel),
                LogoUrl = ProTvChannelOrdering.LogoUrl(channel),
                ItemId = item.Id.ToString("N"),
                InLiveTv = item.InLiveTv
            });
        }

        return new ProTvTabChannels
        {
            Title = title,
            Total = items.Count,
            Channels = items
        };
    }

    private static async Task<IReadOnlyList<ProTvChannel>?> TryFetchLiveAsync(
        PluginConfiguration? configuration,
        CancellationToken cancellationToken)
    {
        if (configuration is null
            || string.IsNullOrWhiteSpace(configuration.ApiBaseUrl)
            || string.IsNullOrWhiteSpace(configuration.Username)
            || string.IsNullOrEmpty(configuration.Password))
        {
            return null;
        }

        try
        {
            return await ProTvSharedClient.Get().GetChannelsAsync(cancellationToken);
        }
        catch (Exception)
        {
            // Fall back to the saved list instead of showing an error in the middle of the home page.
            return null;
        }
    }
}
