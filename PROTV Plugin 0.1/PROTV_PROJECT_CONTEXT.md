# PROTV Jellyfin Plugin - Project Context

## Purpose

This project is a Jellyfin 12.0.0 plugin for the PROTV IPTV service. It provides:

- Live TV channel discovery
- PROTV authentication
- EPG/listings support
- Multicast IPTV fallback streams
- Channel logos
- A Jellyfin plugin configuration page

A separate PROTV VOD library is not currently implemented.

## Environment

- Operating system: Windows
- Project directory: `C:\Users\ahmad\Downloads\PROTV Plugin`
- Jellyfin installation: `C:\Program Files\Jellyfin\Server`
- Jellyfin data directory: `C:\ProgramData\Jellyfin\Server`
- Target framework: `.NET 10`
- Jellyfin package version: `12.0.0`
- Plugin name: `PROTV`
- Plugin ID: `4a0a66d7-04ae-4c4d-b9af-8cb6a1c44f86`

## Important Security Rules

Never expose, print, log, commit, or embed:

- PROTV username
- PROTV password
- JWT access tokens
- Refresh tokens
- Full configuration XML

The bearer token previously shared in conversation should be considered compromised and rotated or revoked.

The active configuration contains local credentials at:

`C:\ProgramData\Jellyfin\Server\config\plugins\PROTV.Plugin.xml`

Do not display the contents of that file.

## Main Source Files

### `ProTvApiClient.cs`

Location:

`C:\Users\ahmad\Downloads\PROTV Plugin\ProTvApiClient.cs`

Responsibilities:

- PROTV login and token caching
- Token refresh
- Authenticated API requests
- Channel retrieval
- EPG retrieval
- Channel watch requests
- Multicast fallback mappings
- Device-header generation
- Channel-logo URL normalization

### `ProTvTunerHost.cs`

Responsibilities:

- Jellyfin Live TV tuner integration
- Conversion of PROTV channels to Jellyfin `ChannelInfo`
- Live stream creation
- HTTP stream opening
- UDP/RTP multicast stream opening

The custom multicast stream implementation must be used for `udp://` and `rtp://` URLs. Do not use `HttpClient.GetStreamAsync()` for UDP URLs.

### `ProTvListingsProvider.cs`

Provides:

- EPG listings
- Channel metadata for the listings provider
- Channel logos for listings

### `Plugin.cs`

Defines:

- Plugin name
- Plugin ID
- Configuration type
- Embedded configuration page

### `PluginConfiguration.cs`

Defines configuration values:

- API base URL
- Username
- Password
- App ID
- Device model
- Device IP address
- Device MAC address
- Router MAC address
- App version
- Default multicast address
- Default multicast port

### `ProTvServiceRegistrator.cs`

Registers:

- `ProTvApiClient`
- `ITunerHost`
- `IListingsProvider`

It also resolves the active plugin configuration. This was added because the plugin instance previously received an empty configuration even though Jellyfin had saved credentials.

### `Configuration.config.html`

Embedded Jellyfin configuration page.

It currently contains:

- A styled PROTV header
- Connection settings card
- Responsive form layout
- Username and password fields
- API URL, App ID, and device model fields
- Scrollable multicast mapping table
- Sticky table headers
- Save button

Preserve these existing IDs and save/load behavior:

```text
protvConfigurationForm
protvApiBaseUrl
protvUsername
protvPassword
protvAppId
protvDeviceModel
```

The page uses:

```javascript
ApiClient.getPluginConfiguration(pluginId)
ApiClient.updatePluginConfiguration(pluginId, config)
Dashboard.processPluginConfigurationUpdateResult(result)
```

### `PROTV.Plugin.csproj`

- Targets `net10.0`
- References Jellyfin Common, Controller, and Model version `12.0.0`
- Excludes generated/decompiled source trees from compilation

Do not remove the exclusions for:

```text
_decompiled_wpf
_decompiled_abs
```

## PROTV API

Base URL:

```text
http://10.1.0.8:82
```

Known endpoints:

```text
POST /api/Account/Login
POST /api/Account/RefreshToken
GET  /api/Channels?Page=1&Count=1000&Order=Desc
GET  /api/Channels/EPGs
POST /api/Channels/Watch?Id={channelId}
GET  /api/Channels/Watch?Id={channelId}
```

The watch endpoint frequently returns HTTP 404 or 405. The plugin therefore uses multicast fallback mappings.

## Authentication

Login JSON body:

```json
{
  "UserName": "...",
  "Password": "...",
  "IpAddress": "..."
}
```

Important request headers:

```text
Accept-Language: en-US
device-type: Desktop
device-os: Windows10
app-version: 2.1.9
app-id: ca88f40a-3056-4c52-9614-8d75a3b0b178
device-ip: ...
device-mac-address: ...
router-mac-address: ...
device-model: ...
push-token:
notification-token:
```

The access token is returned in:

```text
data.profile.token
```

The returned token may already include `Bearer `. The plugin normalizes it before sending:

```http
Authorization: Bearer <token>
```

The API client caches tokens and uses a semaphore to prevent simultaneous login attempts.

## Live TV Flow

The normal flow is:

1. Jellyfin asks the tuner for channels.
2. The plugin requests `/api/Channels`.
3. Each PROTV channel becomes a Jellyfin `ChannelInfo`.
4. Channel ID is used as the Jellyfin channel ID and number.
5. English or Arabic title becomes the channel name.
6. The `Logo` value becomes `ImageUrl`.
7. Jellyfin asks for a stream.
8. The plugin requests the PROTV watch endpoint.
9. If the watch endpoint is unavailable, the plugin returns a known multicast URL.
10. The multicast stream joins the group and reads UDP datagrams.

## Multicast URLs

All known mappings use port `1234`.

Examples:

```text
Channel 75  -> udp://@225.2.0.105:1234
Channel 78  -> udp://@225.2.0.109:1234
Channel 77  -> udp://@225.2.0.110:1234
Channel 21  -> udp://@225.2.0.130:1234
Channel 20  -> udp://@225.2.0.129:1234
Channel 62  -> udp://@225.2.0.52:1234
```

The complete mapping table is inside `ProTvApiClient.cs`.

The custom UDP stream:

- Creates a `UdpClient`
- Enables socket address reuse
- Binds to the multicast port
- Joins the multicast group
- Reads datagrams asynchronously
- Buffers datagrams when Jellyfin requests smaller reads

## Channel Logos

The API returns relative paths such as:

```text
/DataContent/Channels/TV/2f1a6fd199244d1d90da43b1b032c5c6.jpg
```

The original PROTV application revealed the internal image host:

```text
http://10.1.0.9:80/
```

The plugin converts the path to:

```text
http://10.1.0.9:80/DataContent/Channels/TV/2f1a6fd199244d1d90da43b1b032c5c6.jpg
```

This internal image URL was verified to return HTTP 200 and an image response.

The original app also contained this external image host:

```text
http://newprotvcms.protv.sy/
```

## Configuration History

The active Jellyfin plugin configuration is:

```text
C:\ProgramData\Jellyfin\Server\config\plugins\PROTV.Plugin.xml
```

An additional empty file existed at:

```text
C:\ProgramData\Jellyfin\Server\config\plugins\configurations\PROTV.Plugin.xml
```

The empty secondary file caused earlier configuration confusion.

The current service resolver attempts to:

1. Use `Plugin.Instance.Configuration` when it contains credentials.
2. Use the registered plugin instance from `IPluginManager`.
3. Read the active XML configuration from Jellyfin's configuration directory.
4. Fall back to an empty configuration only if necessary.

A direct test using the active saved configuration successfully authenticated and retrieved 123 channels.

## Build and Install

Build:

```powershell
dotnet build --configuration Release
```

Build output:

```text
C:\Users\ahmad\Downloads\PROTV Plugin\bin\Release\net10.0\PROTV.Plugin.dll
```

Installed plugin directory:

```text
C:\ProgramData\Jellyfin\Server\plugins\PROTV
```

Installed files:

```text
C:\ProgramData\Jellyfin\Server\plugins\PROTV\PROTV.Plugin.dll
C:\ProgramData\Jellyfin\Server\plugins\PROTV\PROTV.Plugin.pdb
```

Jellyfin executable:

```text
C:\Program Files\Jellyfin\Server\jellyfin.exe
```

Start command:

```powershell
& 'C:\Program Files\Jellyfin\Server\jellyfin.exe' --datadir 'C:\ProgramData\Jellyfin\Server'
```

The Jellyfin process must be stopped before replacing the DLL because the assembly is locked. Stop it by process ID, then copy the new DLL and restart Jellyfin.

Jellyfin logs:

```text
C:\ProgramData\Jellyfin\Server\log
```

## Performance Improvements to Consider

The user wants Live TV startup to be faster.

Potential improvements:

1. Skip the watch endpoint for channels with known multicast mappings.
2. Immediately return the multicast URL for known channels.
3. Keep access tokens cached.
4. Cache channel data briefly.
5. Cache EPG data briefly.
6. Avoid repeated public-IP and MAC-address detection.
7. Join the multicast group as early as possible.
8. Avoid retry delays after known HTTP 404/405 responses.
9. Reuse HTTP clients.
10. Add clear cancellation and timeout handling.

The most important likely optimization is changing `WatchChannelAsync` so a known multicast channel does not first wait for the unavailable watch endpoint.

## VOD and RTSP History

VOD is not currently implemented in the plugin.

Known VOD endpoints from the original application:

```text
GET  /api/Movies
GET  /api/Movies/{id}
GET  /api/Movies/{id}/Related
GET  /api/Series
GET  /api/Episodes
POST /api/Movies/Rent/{id}
POST /api/Episodes/Rent/{id}
```

The original app used encrypted `pathRTSP` values.

Known decryption details:

- AES-CBC
- PKCS7 padding
- PBKDF2/Rfc2898DeriveBytes
- 64 iterations
- IV: `Ivan Medvedevdevdev`
- Recovered constants:
  - `MAKV2SPBNI99212`
  - `MAKV2SPBNI99212_makv2spbni99212`

The runtime `AllPASSWORD` value has not been fully resolved.

Captured RTSP evidence is in:

```text
C:\Users\ahmad\Documents\3.pcapng
```

Confirmed RTSP URL from the capture:

```text
rtsp://10.1.0.117:1936/mov02/_definst_/mov02/Animals_2026_720.mp4
```

The capture showed:

```text
OPTIONS
DESCRIBE
SETUP track 1
SETUP track 2
PLAY
```

Media details:

- H.264 video
- AAC audio
- 1280x544 resolution
- 24 FPS
- Approximately 6491 seconds duration

## Current Known Issues

1. Live TV startup may wait for the unavailable watch endpoint.
2. Actual Jellyfin end-to-end playback should be tested with a known active multicast channel.
3. The multicast network must allow traffic from the PROTV multicast source.
4. The configuration resolver is intentionally defensive because Jellyfin previously supplied an empty plugin configuration.
5. A separate VOD library has not been implemented.
6. The exact VOD RTSP decryption password remains unresolved.

## Recommended Workflow for Future Changes

1. Inspect the relevant source files before editing.
2. Preserve existing saved credentials and configuration behavior.
3. Never display credential values.
4. Build with:

   ```powershell
   dotnet build --configuration Release
   ```

5. Stop Jellyfin by its specific process ID before replacing the plugin DLL.
6. Copy the Release DLL and PDB to the Jellyfin plugin directory.
7. Restart Jellyfin.
8. Inspect the newest Jellyfin log for plugin loading and runtime errors.
9. Test the exact requested behavior from the Jellyfin UI.

