using MediaBrowser.Controller.LiveTv;
using MediaBrowser.Controller.Plugins;
using MediaBrowser.Controller;
using MediaBrowser.Common.Plugins;
using MediaBrowser.Common.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using System.Xml.Serialization;

namespace PROTV.Plugin;

public sealed class ProTvServiceRegistrator : IPluginServiceRegistrator
{
    public void RegisterServices(IServiceCollection serviceCollection, IServerApplicationHost applicationHost)
    {
        serviceCollection.AddSingleton<ProTvApiClient>(services => new ProTvApiClient(
            new HttpClient(),
            services.GetRequiredService<ILogger<ProTvApiClient>>(),
            () => ResolveConfiguration(services)));
        serviceCollection.AddSingleton<ITunerHost, ProTvTunerHost>();
        serviceCollection.AddSingleton<IListingsProvider, ProTvListingsProvider>();
    }

    private static PluginConfiguration ResolveConfiguration(IServiceProvider services)
    {
        var pluginConfiguration = Plugin.Instance?.Configuration;
        if (HasCredentials(pluginConfiguration))
        {
            return pluginConfiguration!;
        }

        var registeredPlugin = services.GetRequiredService<IPluginManager>()
            .GetPlugin(Guid.Parse("4a0a66d7-04ae-4c4d-b9af-8cb6a1c44f86"))
            ?.Instance as Plugin;
        if (HasCredentials(registeredPlugin?.Configuration))
        {
            return registeredPlugin!.Configuration;
        }

        var applicationPaths = services.GetRequiredService<IApplicationPaths>();
        var configurationPath = Path.Combine(
            applicationPaths.ConfigurationDirectoryPath,
            "plugins",
            "PROTV.Plugin.xml");
        if (File.Exists(configurationPath))
        {
            using var stream = File.OpenRead(configurationPath);
            var configuration = new XmlSerializer(typeof(PluginConfiguration))
                .Deserialize(stream) as PluginConfiguration;
            if (configuration is not null)
            {
                return configuration;
            }
        }

        return pluginConfiguration ?? new PluginConfiguration();
    }

    private static bool HasCredentials(PluginConfiguration? configuration)
    {
        return configuration is not null
            && !string.IsNullOrWhiteSpace(configuration.Username)
            && !string.IsNullOrEmpty(configuration.Password);
    }
}
