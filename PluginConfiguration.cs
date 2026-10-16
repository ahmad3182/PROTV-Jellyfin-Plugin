using MediaBrowser.Model.Plugins;

namespace PROTV.Plugin;

public sealed class PluginConfiguration : BasePluginConfiguration
{
    public string ApiBaseUrl { get; set; } = "http://10.1.0.8:82";

    public string Username { get; set; } = string.Empty;

    public string Password { get; set; } = string.Empty;

    public string AppId { get; set; } = "ca88f40a-3056-4c52-9614-8d75a3b0b178";

    public string DeviceModel { get; set; } = "Jellyfin Server";

    public string DeviceIpAddress { get; set; } = string.Empty;

    public string DeviceMacAddress { get; set; } = string.Empty;

    public string RouterMacAddress { get; set; } = string.Empty;

    public string AppVersion { get; set; } = "2.1.9";

    public string MulticastAddress { get; set; } = "225.2.0.105";

    public int MulticastPort { get; set; } = 1234;

    // Optional: local IPv4 address of the NIC that receives the PROTV multicast traffic.
    // Leave empty to auto-detect. Set it on hosts with several network interfaces.
    public string MulticastInterfaceAddress { get; set; } = string.Empty;

    // How long ffprobe analyses a stream before Jellyfin starts playback, in milliseconds.
    // Lower = faster start, but too low can miss audio/subtitle tracks. 0 = Jellyfin default.
    public int StreamAnalyzeDurationMs { get; set; } = 1500;

    // ---- Dashboard page customisation ----

    // Heading shown at the top of the PROTV dashboard page.
    public string DashboardTitle { get; set; } = "PROTV";

    // Optional message shown under the heading (for example notes for other admins).
    public string WelcomeMessage { get; set; } = string.Empty;

    // Menu entry text and Material icon name for the dashboard menu / Plugin Pages sidebar.
    // Sidebar changes apply after Jellyfin restarts.
    public string SidebarLabel { get; set; } = "PROTV";

    public string SidebarIcon { get; set; } = "live_tv";

    // ---- Jellyfin home page tab ----

    // Draws a PROTV tab on the Jellyfin home page (next to Favorites) listing every tuner
    // channel. The tab is drawn by the Custom Tabs plugin, so it needs Plugin Pages,
    // File Transformation and Custom Tabs to be installed and loaded.
    public bool FrontpageTabEnabled { get; set; } = true;

    // Text shown on the home page tab and its header.
    public string FrontpageTabTitle { get; set; } = "PROTV";

    // When true PROTV refuses to start (no tuner, no guide, no pages) unless Plugin Pages,
    // File Transformation and Custom Tabs are all installed, instead of running half-working.
    // Turn this off to keep PROTV running without the tab.
    public bool RequireCompanionPlugins { get; set; } = true;

    // Per-channel customisation (rename, hide, order, logo). Keyed by the PROTV channel id.
    public ProTvChannelOverride[] ChannelOverrides { get; set; } = Array.Empty<ProTvChannelOverride>();

    // Snapshot of the channels PROTV returned last time, so the dashboard can list them.
    public ProTvKnownChannel[] KnownChannels { get; set; } = Array.Empty<ProTvKnownChannel>();
}

public sealed class ProTvChannelOverride
{
    public int ChannelId { get; set; }

    public string CustomName { get; set; } = string.Empty;

    public bool Hidden { get; set; }

    // Lower numbers come first; channels with the same priority are sorted by name.
    public int Priority { get; set; }

    public string LogoUrl { get; set; } = string.Empty;
}

public sealed class ProTvKnownChannel
{
    public int Id { get; set; }

    public string Name { get; set; } = string.Empty;

    public string LogoUrl { get; set; } = string.Empty;
}
