# PROTV Jellyfin Plugin

Initial Jellyfin 12.0.0 plugin core for an authorized PROTV service.

## Current scope

- Targets Jellyfin 12.0.0 packages.
- Implements the PROTV login, token refresh, channel, playback, and EPG API client.
- Uses `http://10.1.0.8:82` as the initial API URL from the captured app traffic.

The API URL must be reachable from the Jellyfin server. The Live TV tuner/listings adapters are the next integration layer after confirming the exact Jellyfin 12 Live TV interfaces and the EPG JSON field names from a sanitized response.

## Build

```powershell
dotnet restore
dotnet build -c Release
```

Do not commit credentials or access/refresh tokens. Configure them in Jellyfin after installing the plugin.
