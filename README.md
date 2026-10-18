# PROTV for Jellyfin

Watch your PROTV channels, films and series inside Jellyfin, with a program guide, a management
dashboard and a PROTV tab on the Jellyfin home page.

> [!WARNING]
> **Early development. Not a final version.** The plugin changes parts of your Jellyfin
> configuration (see [What the plugin modifies](#what-the-plugin-modifies)) and can misbehave.
> **Back up your Jellyfin configuration and data before installing it.** Use it at your own risk.
>
> **Made with AI.** This plugin was developed with the help of AI (Claude, by Anthropic). AI-written
> code can contain mistakes, and it has only had limited testing on real servers.

<!-- Add your screenshots to docs/images/ (see the notes there), then remove these comment markers.

![Dashboard](docs/images/dashboard.png)
![Home page tab](docs/images/home-tab.png)

-->

## Requirements

| | |
|---|---|
| **Subscription** | A valid, active PROTV account. The plugin includes no channels, accounts or content. |
| **Location** | **Works in Syria only.** The PROTV service is only available there. |
| **Network** | The server must reach the PROTV service (default `http://10.1.0.8:82`) and receive its multicast streams (UDP `225.2.0.x`, port `1234`). |
| **Jellyfin** | **12.x** (built against the Jellyfin 12.0.0 plugin packages, .NET 10). It does not load on 10.x or 11.x. |
| **Companion plugins** | Plugin Pages, File Transformation and Custom Tabs (see below). |

## Required companion plugins

PROTV draws its dashboard entry and its home page tab through three plugins by **IAmParadox27**. By
default **PROTV switches itself off (no tuner, no guide, no pages) when one of them is missing.**

| Plugin | Author | Repository | Used for |
|---|---|---|---|
| File Transformation | IAmParadox27 | [jellyfin-plugin-file-transformation](https://github.com/IAmParadox27/jellyfin-plugin-file-transformation) | Web client patches the other two need |
| Plugin Pages | IAmParadox27 | [jellyfin-plugin-pages](https://github.com/IAmParadox27/jellyfin-plugin-pages) | The PROTV entry in the sidebar |
| Custom Tabs | IAmParadox27 | [jellyfin-plugin-custom-tabs](https://github.com/IAmParadox27/jellyfin-plugin-custom-tabs) | The PROTV tab on the home page |

Install them first: **Dashboard > Plugins > Repositories > Add**
`https://www.iamparadox.dev/jellyfin/plugins/manifest.json`, then install File Transformation, Plugin
Pages and Custom Tabs from the **Catalog**, in that order, and restart Jellyfin. If one is not in the
catalog, follow the install instructions in its repository.

## Installation

### From the plugin catalog

1. **Dashboard > Plugins > Repositories > Add** and enter:
   `https://raw.githubusercontent.com/YOUR_GITHUB_USERNAME/YOUR_REPO/main/manifest.json`
2. Open the **Catalog**, install **PROTV**, and restart Jellyfin.

### By hand

1. Download `PROTV_<version>.zip` from the [releases](../../releases) and extract `PROTV.Plugin.dll`.
2. Put it in `<config>/plugins/PROTV/` (Docker image: `/config/plugins/PROTV/`; Windows:
   `%ProgramData%\Jellyfin\Server\plugins\PROTV\`). Make sure the Jellyfin user can read it.
3. Restart Jellyfin.

### Docker

PROTV streams use multicast, which does not cross Docker's default bridge network. Use host networking:

```yaml
services:
  jellyfin:
    image: jellyfin/jellyfin:12.0   # a pinned 12.x tag
    network_mode: host              # required for multicast
```

Wired connections are strongly recommended: multicast over Wi-Fi is unreliable. With several network
cards, set the **Multicast network interface** on the dashboard.

## Getting started

1. Open **PROTV** in the Jellyfin sidebar (or **Dashboard > PROTV**).
2. Enter your PROTV **username and password**, press **Test connection**, then **Save**.
3. **Dashboard > Live TV > Tuner Devices**: add the **PROTV** tuner. Under **TV Guide Data Providers**
   add **PROTV EPG** if you want program data.
4. Press **Refresh guide now** on the PROTV page. Your channels appear in Live TV.
5. Watch from **Live TV**, or open the **PROTV** tab on the home page and tap a channel.

## Features

**Live TV**
- PROTV tuner with channel logos and a built-in channel-to-stream table.
- Program guide through the **PROTV EPG** provider.
- Alphabetical channels; **channel IDs never change**.
- Several viewers can watch the same channel at once.
- A clear "channel not working" error when a channel has no stream address.

**Films and series (VOD)**
- Two libraries the plugin creates and keeps up to date: **PROTV VOD** (films) and **PROTV VOD Series**.
- Every title is a small `.strm` file plus `.nfo` metadata, poster and subtitles, so it plays like any
  other library on web, mobile and TV apps.
- The scheduled task **Sync PROTV VOD library** (category PROTV) runs on an interval, or press **Sync now**.
- A disk budget for posters and subtitles, and the sync steps aside while somebody is watching.
- Titles PROTV no longer lists are removed after a complete sync (can be switched off).

**Dashboard**
- Account, service address and device name, with a **Test connection** button.
- **Channels:** rename, hide, reorder or change the logo of any channel.
- **Appearance:** page heading, welcome message, menu label and icon.
- **Device and streaming:** device IP / MAC, router MAC, multicast network interface, stream analysis time.
- **Home page tab** and **VOD** settings.
- **Diagnostics:** one button creates a report to paste into a bug report. Passwords and secrets are
  never included and IP addresses are shortened.

## Films and series: how it works

The sync reads the PROTV catalogue and writes it under the plugin's data folder (`protv-vod`). Every
`.strm` file points back at **your Jellyfin server**, and the server looks up the real stream when you
press play. Those links are **signed** so that nobody can guess a link for another title.

- **After updating from a version before 0.6.2, run the sync once.** It rewrites the `.strm` files with
  signed links. Old unsigned links are refused until then.
- The signing secret is created automatically and saved in `PROTV.Plugin.xml` as `VodStreamSecret`.
  If you think it leaked, clear it, restart Jellyfin and run the sync again.

## Settings that are not on the dashboard

Edit `<config>/plugins/configurations/PROTV.Plugin.xml` while Jellyfin is stopped.

| Setting | Default | Meaning |
|---|---|---|
| `RequireCompanionPlugins` | `true` | Switch PROTV off when a companion plugin is missing. |
| `VodRemoveDeletedTitles` | `true` | Remove titles PROTV no longer lists after a complete sync. |
| `VodStreamSecret` | (generated) | Secret that signs the VOD links. |
| `StreamAnalyzeDurationMs` | `1500` | Lower starts playback faster; too low can miss audio tracks. `0` = Jellyfin default. |

## What the plugin modifies

- Its own settings file `plugins/configurations/PROTV.Plugin.xml`. **Your PROTV login is stored there in
  plain text. Never share that file.**
- The Custom Tabs configuration (it adds, updates and removes its own tab) and the Plugin Pages entry.
- Live TV: it adds a tuner and a guide provider. Uninstalling from the dashboard removes them from your
  Live TV settings and queues a guide refresh, which can remove the PROTV channels from your library.
- The VOD libraries and the `protv-vod` folder (it creates and, for titles PROTV removed, deletes files there).

## Troubleshooting

1. Open the PROTV page, press **Create diagnostic report** and read it. It lists versions, companion
   plugin status, settings (without secrets), the VOD state and recent warnings.
2. **Test connection** tells you whether the login and the network path work.
3. Nothing happens after installing: look for `PROTV companion plugins` in the Jellyfin log.
4. PROTV disabled itself and the page is gone: install the missing plugins and restart, or stop Jellyfin
   and set `RequireCompanionPlugins` to `false`.
5. Channels listed but no picture: check that multicast reaches the server
   (`tcpdump -i <interface> udp port 1234`) and that Docker uses host networking.
6. Old VOD items stop playing after an update: run **Sync PROTV VOD library** once.

Found a bug? [Open an issue](../../issues/new/choose) and attach the diagnostic report.
**Never post your password or `PROTV.Plugin.xml`.** For security problems see [SECURITY.md](SECURITY.md).

## Known limitations

- Early development: expect bugs and changes between versions.
- Works in Syria only and only with a valid PROTV subscription.
- Multicast does not work over Docker's bridge network and is unreliable over Wi-Fi.
- Changes to the home page tab settings or the sidebar label need a Jellyfin restart.
- Deleting the plugin folder by hand does not run the uninstall cleanup: remove the PROTV tuner under
  Live TV and run **Refresh Guide** yourself.
- Only tested on Jellyfin 12.x.

## Building from source

```
dotnet build -c Release
```

The output is `bin/Release/net10.0/PROTV.Plugin.dll`. The project targets .NET 10 and the Jellyfin
12.0.0 packages. `make-release.ps1` builds the release zip and fills in `manifest.json`.

## Credits

- **IAmParadox27** for Plugin Pages, File Transformation and Custom Tabs.
- The **Jellyfin** project.

## Disclaimer

An independent community project, written with the help of AI. It is **not affiliated with, endorsed by
or supported by PROTV, Jellyfin or the authors of the companion plugins.** It does not provide, unlock
or redistribute content and does not replace a PROTV subscription. The software is provided "as is",
without warranty of any kind. You are responsible for backing up your server and for using it within
the terms of your PROTV subscription.
