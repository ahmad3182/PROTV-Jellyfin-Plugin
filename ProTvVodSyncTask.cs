using MediaBrowser.Model.Tasks;

namespace PROTV.Plugin;

// The background job that fills the "PROTV VOD" library. Jellyfin discovers plugin scheduled tasks
// on its own, so this shows up in Dashboard > Scheduled Tasks and can be run from there, from the
// PROTV dashboard page, or automatically on the trigger below.
public sealed class ProTvVodSyncTask : IScheduledTask
{
    public string Name => "Sync PROTV VOD library";

    public string Key => "ProTvVodSync";

    public string Description =>
        "Downloads the PROTV film and series catalogue into the PROTV VOD library so it plays " +
        "through Jellyfin. Titles already downloaded are left alone, so it only picks up changes.";

    public string Category => "PROTV";

    public IEnumerable<TaskTriggerInfo> GetDefaultTriggers() => new[]
    {
        new TaskTriggerInfo
        {
            Type = TaskTriggerInfoType.IntervalTrigger,
            IntervalTicks = TimeSpan.FromHours(12).Ticks
        }
    };

    public Task ExecuteAsync(IProgress<double> progress, CancellationToken cancellationToken)
        => ProTvVodLibrary.SyncAsync(progress, cancellationToken);
}
