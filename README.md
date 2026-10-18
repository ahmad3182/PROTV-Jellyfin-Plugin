# PROTV for Jellyfin: v0.6.1 (Pre-release)

Watch your PROTV channels inside Jellyfin Live TV, with a program guide, channel logos, a management dashboard and a PROTV tab on the Jellyfin home page.

> [!WARNING]
> **This is an early-development pre-release. It is not a final version.**
> It changes parts of your Jellyfin configuration (see [What this plugin modifies](#what-this-plugin-modifies)) and it can misbehave or break things. **Back up your Jellyfin configuration and data directories before installing it.** Do not install it on a server you cannot afford to repair. Use it entirely at your own risk.
>
> **Made with AI.** This plugin was developed with the help of AI (Claude by Anthropic, DeepSeek By High-Flyer, ChatGPT by OpenAi). AI-written code can contain mistakes, and this release has had only limited testing on real servers.

---

## Requirements

| Requirement | Details |
|---|---|
| **PROTV subscription** | A valid, active PROTV account (username and password). The plugin does not include any channels, accounts or content. |
| **Location** | **Works in Syria only.** PROTV's service is only available there, so the plugin cannot connect from anywhere else. |
| **Network access** | The Jellyfin server must be able to reach the PROTV service (default `http://10.1.0.8:82`) and receive its multicast streams (UDP, `225.2.0.x`, port `1234`). |
| **Jellyfin** | Jellyfin **12.x** (built against the Jellyfin 12.0.0 plugin packages on .NET 10). It will not load on 10.x or 11.x. |
| **Companion plugins** | **Plugin Pages, File Transformation and Custom Tabs** (all three are required, see below). |

---

## Required companion plugins

PROTV does not draw its own dashboard entry or home page tab. It relies on three plugins by **IAmParadox27**. By default, **PROTV disables itself (no tuner, no guide, no pages) if any of them is missing.**

| Plugin | Author | Repository | What PROTV uses it for |
|---|---|---|---|
| **File Transformation** | IAmParadox27 | [jellyfin-plugin-file-transformation](https://github.com/IAmParadox27/jellyfin-plugin-file-transformation) | Applies the web client patches that Plugin Pages and Custom Tabs need |
| **Plugin Pages** | IAmParadox27 | [jellyfin-plugin-pages](https://github.com/IAmParadox27/jellyfin-plugin-pages) | Adds the PROTV entry to the Jellyfin sidebar |
| **Custom Tabs** | IAmParadox27 | [jellyfin-plugin-custom-tabs](https://github.com/IAmParadox27/jellyfin-plugin-custom-tabs) | Draws the PROTV tab on the Jellyfin home page |

PROTV was built and used with Plugin Pages 3.0.2.0, File Transformation 3.0.2.0 and Custom Tabs 0.3.2.0. Many thanks to IAmParadox27 for these plugins.

### How to install them

1. In Jellyfin, open **Dashboard → Plugins → Repositories → Add** and enter:
   ```
   https://www.iamparadox.dev/jellyfin/plugins/manifest.json
   ```
2. Open **Dashboard → Plugins → Catalog** and install, in this order:
   1. **File Transformation**
   2. **Plugin Pages**
   3. **Custom Tabs**
3. **Restart Jellyfin.**
4. Check that all three show as **Active** under **Dashboard → Plugins**.

If one of them is missing from the catalog, follow the install instructions in its GitHub repository linked above.

---

## Installing PROTV

1. Install the three companion plugins above first.
2. Download the PROTV release file from the **Assets** section of this release.
3. Place `PROTV.Plugin.dll` in a folder named `PROTV` inside your Jellyfin plugins directory:
   - Linux / Docker: `<config>/plugins/PROTV/PROTV.Plugin.dll` (for the official Docker image this is `/config/plugins/PROTV/`)
   - Windows: `%ProgramData%\Jellyfin\Server\plugins\PROTV\PROTV.Plugin.dll`
4. Make sure the Jellyfin user can read the folder (for Docker: `chown -R <uid>:<gid> plugins/PROTV`).
5. **Restart Jellyfin.**

### Running Jellyfin in Docker

PROTV streams use multicast, which does not pass through Docker's default bridge network. Use host networking:

```yaml
services:
  jellyfin:
    image: jellyfin/jellyfin:12.0   # use a pinned 12.x tag
    network_mode: host              # required for multicast
```

Your network must also deliver the multicast traffic to the server. Multicast over Wi-Fi is unreliable, so a wired connection is strongly recommended. If the server has several network cards, set the **Multicast network interface** in the PROTV dashboard.

---

## Getting started

1. Open the **PROTV** page from the Jellyfin sidebar (or from **Dashboard → PROTV**).
2. Enter your PROTV **username and password** under **Account**, then press **Save**.
3. Go to **Dashboard → Live TV → Tuner Devices**, add the **PROTV** tuner and save.
4. For program guide data, add **PROTV EPG** under **TV Guide Data Providers**.
5. Run **Refresh Guide** (there is a button for it on the PROTV page). Your channels appear in Live TV.
6. Watch from **Live TV**, or open the **PROTV tab** on the home page and tap a channel.

---

## Features

**Live TV**
- PROTV tuner for Jellyfin Live TV, with channel logos.
- Program guide through a built-in **PROTV EPG** provider.
- Channels are listed alphabetically; **channel IDs never change**.
- Built-in channel-to-stream table (120 channels in this release), with a clear "channel not working" error when a channel has no stream address.
- Several viewers can watch the same channel at the same time.
- Faster playback start: stream lookups and device information are cached, and the stream analysis time is adjustable.
- Works on Linux, Windows and Docker.

**PROTV dashboard**
- **Account / Service:** username, password, API address, App ID and device name.
- **Channels:** rename, hide, reorder (priority) or change the logo of any channel, with search and a one-click *Refresh guide*.
- **Device and streaming:** device IP, device MAC, router MAC, multicast network interface and stream analysis time.
- **Appearance:** page heading, welcome message, sidebar label and icon.
- **Home page tab:** switch the PROTV tab on or off, rename it, and choose whether the companion plugins are required.
- Clear error messages when saving fails.

**Jellyfin home page tab**
- A PROTV tab next to Favorites that lists every channel with its logo and number.
- Search box and refresh button.
- Tap a channel to play it through Jellyfin's normal Live TV player (web and other Jellyfin apps).

**Housekeeping**
- The settings file `PROTV.Plugin.xml` is recreated automatically if it was deleted.
- Uninstalling from the Jellyfin dashboard removes the PROTV tuner, guide provider, sidebar entry and home page tab, and starts a guide refresh.

---

## What this plugin modifies

Because it integrates with other plugins and with Live TV, PROTV touches more than its own files:

- **Its own settings file** `plugins/configurations/PROTV.Plugin.xml`. Your PROTV username and password are stored there **in plain text**. Never share this file or post it publicly.
- **The Custom Tabs configuration:** PROTV adds, updates and removes its own tab entry there.
- **The Plugin Pages registration:** PROTV registers its sidebar entry at startup.
- **Live TV settings:** it adds a tuner and a guide provider, and when it is uninstalled from the dashboard it **edits your Live TV configuration** to remove them and queues a guide refresh, which can remove the PROTV channels from your library.
- **Startup behavior:** with *Require companion plugins* on (the default), PROTV does not register its tuner or pages unless all three companion plugins are installed.

---

## Known limitations

- Early development: expect bugs, rough edges and changes between versions.
- Built with AI assistance and only lightly tested, so some code paths may never have run on a real server.
- Works only in Syria and only with a valid PROTV subscription.
- Playback depends on multicast reaching your server. It will not work over a default Docker bridge network and is unreliable over Wi-Fi.
- After changing the home page tab settings or the sidebar label, **restart Jellyfin**.
- A channel not yet in Live TV needs a **Refresh Guide** before it can be played from the home page tab.
- Deleting the plugin folder by hand (or from Docker) does not run the uninstall cleanup. Remove the PROTV tuner under **Live TV** and run **Refresh Guide** yourself.
- Not tested on Jellyfin versions other than 12.x.

---

## Troubleshooting

- **PROTV does nothing after install:** check the Jellyfin log for `PROTV companion plugins` lines. They state which companion plugins are missing or not loaded.
- **PROTV disabled itself and the dashboard page is gone:** install the missing plugins and restart. To run without them, stop Jellyfin and set `<RequireCompanionPlugins>false</RequireCompanionPlugins>` in `plugins/configurations/PROTV.Plugin.xml`.
- **Login not saving:** the error message shown on the page includes the HTTP status. Check that the Jellyfin config folder is writable by the Jellyfin user.
- **Channels listed but no picture:** check that the server can receive multicast (`tcpdump -i <interface> udp port 1234`) and that you are using host networking in Docker.

To report a problem, open a GitHub issue and include your Jellyfin version, how you run it (Docker, Linux, Windows) and the relevant lines from the Jellyfin log. **Remove your username and password from anything you post.**

---

## Disclaimer

This is an independent, community project, written with the help of AI. It is **not affiliated with, endorsed by or supported by PROTV, Jellyfin or the authors of the companion plugins.** It does not provide, unlock or redistribute any content and does not replace a PROTV subscription. The software is provided "as is", without warranty of any kind. You are responsible for backing up your server and for using it in line with your PROTV subscription terms.
