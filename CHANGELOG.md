# Changelog

## 0.6.2 (next release)

### Security
- VOD stream links are now signed. The stream endpoint refuses links without a valid signature, so a
  link cannot be guessed for another title. **Run "Sync PROTV VOD library" once after updating.**

### Added
- **Test connection** button on the dashboard: tries a login with the values on screen.
- **Diagnostics** section: creates a report (versions, companion plugins, settings without secrets,
  VOD state, network, recent warnings) that is safe to paste into a bug report.
- Setting `VodRemoveDeletedTitles`: titles PROTV no longer lists are removed after a complete sync.
- Repository files: `README.md`, `.gitignore`, issue templates, `SECURITY.md`.

### Improved
- One shared PROTV API client (tuner, guide, home tab, VOD) instead of a new client and login per call.
- The library scan after a VOD sync only runs when something changed.
- Series are prepared four at a time under one shared request limit; missing posters are not retried
  for a week; the state file is written safely; stream lookups are shared and cached; series seasons
  load in parallel; browse pages are cached briefly; the companion-plugin check is cached.
