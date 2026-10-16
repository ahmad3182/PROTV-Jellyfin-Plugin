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

    public Plugin(IApplicationPaths applicationPaths, IXmlSerializer xmlSerializer)
        : base(applicationPaths, xmlSerializer)
    {
        Instance = this;
    }

    public IEnumerable<PluginPageInfo> GetPages()
    {
        return new[]
        {
            new PluginPageInfo
            {
                Name = "protvconfigurationpage",
                EmbeddedResourcePath = "PROTV.Plugin.Configuration.config.html"
            }
        };
    }
}
