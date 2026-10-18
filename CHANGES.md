# PROTV 0.6.1 — optimization and hardening changes

Drop these files over the 0.6.1 project (one new file: `ProTvSharedClient.cs`), rebuild, replace the DLL, restart Jellyfin.

## After updating (important)
1. **Run the PROTV VOD sync once** (Dashboard > Scheduled Tasks). Stream links in the `.strm` files are now signed; old unsigned links are refused until the sync rewrites them. Only the `.strm` files are rewritten, nothing is re-downloaded.
2. The signing secret is created automatically and saved in `PROTV.Plugin.xml` as `VodStreamSecret`. Do not publish that file.

## Changes
| # | Change | Files |
|---|---|---|
| 1 | VOD stream endpoint now needs a per-item HMAC signature in the link (`/PROTV/Vod/Stream/{kind}/{id}/{signature}.m3u8`); unsigned requests get 404 | ProTvVodData.cs, ProTvTabController.Vod.cs, PluginConfiguration.cs |
| 2 | One shared PROTV API client (tuner, guide, tab, VOD) instead of a new client and login per call | ProTvSharedClient.cs (new), ProTvServiceRegistrator.cs, ProTvVodData.cs, ProTvTabData.cs |
| 3 | Library scan only runs when the sync actually wrote or removed something | ProTvVodLibrary.cs |
| 4 | Series are prepared 4 at a time; all episode work shares one cap of 8 in flight | ProTvVodLibrary.cs |
| 5 | Missing posters are not requested again for 7 days | ProTvVodLibrary.cs |
| 6 | Subtitle check looks at the in-memory set before reading the folder | ProTvVodLibrary.cs |
| 7 | State file written compact and atomically (temp file + move) | ProTvVodLibrary.cs |
| 8 | Companion-plugin check cached for 45 s | ProTvRequirements.cs |
| 9 | Series detail loads seasons in parallel; browse pages cached 60 s, series detail 5 min | ProTvVodData.cs |
| 10 | Titles PROTV no longer lists are removed after a complete sync (setting `VodRemoveDeletedTitles`, default on) | ProTvVodLibrary.cs, PluginConfiguration.cs |
| 11 | Stream URL cache: one lookup shared by simultaneous requests, expired entries purged | ProTvVodData.cs |
| 12 | Live tab channel lookup no longer queries the database while holding a lock | ProTvChannelItems.cs |
| 13 | Live streams share one HttpClient; downloader has a 30 s timeout; crypto key derived once | ProTvTunerHost.cs, ProTvVodLibrary.cs, ProTvCrypto.cs |

### Safety rules of the removal step (10)
Only folders with the plugin's own ` [protv-<id>]` marker are touched. Nothing is removed unless the paging reached the last page PROTV reported, and the run listed at least half of what the previous complete run did. Disable with `<VodRemoveDeletedTitles>false</VodRemoveDeletedTitles>` in `PROTV.Plugin.xml`.

## Not changed (needs testing or Jellyfin APIs I could not check)
- Refreshing only the two PROTV libraries instead of a whole-server scan.
- Live channel lookup by external id can collide with other tuners' channel ids.
- The plugin's own multicast socket probably duplicates ffmpeg's join; test skipping it for UDP.
- Per-packet allocation in the multicast receive loop; full file walk in the asset size measurement; unequal page sizes (movies 250, series 100).

## Not compiled
Written without access to the Jellyfin packages. All files pass a C# syntax check, but please build and test: play a film after the sync, play a live channel, open a series in the tab, run the sync twice (second run should log "nothing changed").
