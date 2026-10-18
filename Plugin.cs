using MediaBrowser.Common.Plugins;
using MediaBrowser.Common.Configuration;
using MediaBrowser.Model.Plugins;
using MediaBrowser.Model.Serialization;

namespace PROTV.Plugin;

public sealed class Plugin : BasePlugin<PluginConfiguration>, IHasWebPages
{
    public static Plugin? Instance { get; private set; }

    public override string Name => "PROTV";

    public override Guid Id => Guid.Parse("4a0a66d7-04ae-4c4d-b9af-8cb6a1c44f86");

    public override string Description => "Connects Jellyfin to an authorized PROTV service.";

    // BasePlugin keeps ApplicationPaths protected; the companion plugin helpers need to look at
    // the plugin folder to see what is installed, so it is exposed here.
    public IApplicationPaths PluginPaths => ApplicationPaths;

    public Plugin(IApplicationPaths applicationPaths, IXmlSerializer xmlSerializer)
        : base(applicationPaths, xmlSerializer)
    {
        Instance = this;
        EnsureConfigurationFile();
    }

    // Lets other classes save the settings file without relying on SaveConfiguration's visibility.
    public void PersistConfiguration()
    {
        SaveConfiguration();
    }

    // Jellyfin only writes <config>/plugins/configurations/PROTV.Plugin.xml after the first save.
    // If the file (or its folder) was deleted, create it again with default values on startup.
    private void EnsureConfigurationFile()
    {
        try
        {
            var path = ConfigurationFilePath;
            var directory = Path.GetDirectoryName(path);
            if (!string.IsNullOrEmpty(directory))
            {
                Directory.CreateDirectory(directory);
            }

            if (!File.Exists(path))
            {
                SaveConfiguration();
            }
        }
        catch
        {
            // Never block plugin start-up because the settings file could not be created.
        }
    }

    // Runs when the plugin is uninstalled from the dashboard: remove the PROTV tuner and guide
    // entries from Live TV and refresh the guide so the PROTV channels disappear.
    public override void OnUninstalling()
    {
        try
        {
            ProTvLifecycleService.CleanUpAfterUninstall();
        }
        catch
        {
        }

        base.OnUninstalling();
    }

    public IEnumerable<PluginPageInfo> GetPages()
    {
        // With RequireCompanionPlugins on, a half-working PROTV (no sidebar entry, no home page
        // tab) is worse than no PROTV at all, so the pages are only published when the companion
        // plugins that draw them are actually installed.
        if (!ProTvRequirements.PagesAllowed(Configuration))
        {
            return Array.Empty<PluginPageInfo>();
        }

        return new[]
        {
            new PluginPageInfo
            {
                Name = "protvconfigurationpage",
                EmbeddedResourcePath = "PROTV.Plugin.Configuration.config.html"
            },
            new PluginPageInfo
            {
                Name = "protvdashboard",
                EmbeddedResourcePath = "PROTV.Plugin.Dashboard.config.html",
                DisplayName = string.IsNullOrWhiteSpace(Configuration.SidebarLabel) ? "PROTV" : Configuration.SidebarLabel.Trim(),
                EnableInMainMenu = true,
                MenuSection = "server",
                MenuIcon = string.IsNullOrWhiteSpace(Configuration.SidebarIcon) ? "live_tv" : Configuration.SidebarIcon.Trim()
            }
        };
    }
}
