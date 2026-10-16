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
}
