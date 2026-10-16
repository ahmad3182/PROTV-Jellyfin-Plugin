using System.Reflection;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace PROTV.Plugin;

// Serves the PROTV Jellyfin home page tab.
//   /PROTV/tab.js   - the renderer. Anonymous on purpose: it is loaded with a plain
//                     <script src>, and browsers do not attach Jellyfin's token to those.
//   /PROTV/Channels - the channel list it draws. Any signed-in Jellyfin user may read it.
//   /PROTV/Status   - the companion plugin report used by the PROTV dashboard page.
[ApiController]
[Route("PROTV")]
public sealed class ProTvTabController : ControllerBase
{
    private const string TabScriptResource = "PROTV.Plugin.Tab.config.js";

    [HttpGet("tab.js")]
    [AllowAnonymous]
    public ActionResult GetTabScript()
    {
        var stream = Assembly.GetExecutingAssembly().GetManifestResourceStream(TabScriptResource);
        // No caching so a plugin update is picked up without clearing the browser cache.
        Response.Headers.CacheControl = "no-store";
        return stream is null
            ? NotFound()
            : File(stream, "application/javascript");
    }

    [HttpGet("Channels")]
    [Authorize]
    public async Task<ActionResult<ProTvTabChannels>> GetChannels(
        [FromQuery] bool refresh = false,
        CancellationToken cancellationToken = default)
        => await ProTvTabData.GetChannelsAsync(refresh, cancellationToken);

    [HttpGet("Status")]
    [Authorize]
    public ActionResult<ProTvTabStatus> GetStatus() => ProTvTabData.GetStatus();
}
