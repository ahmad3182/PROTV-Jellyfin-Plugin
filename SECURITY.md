# Security

## Reporting a problem

If you find a security problem (for example a way to reach someone's streams, or a way to read the
saved PROTV login), please **do not open a public issue**. Use GitHub's private reporting instead:
**Security > Report a vulnerability** on this repository.

## Please never post

- your PROTV username or password,
- the file `PROTV.Plugin.xml` (it stores the login in plain text and the secret that signs stream links),
- full Jellyfin logs without checking them first.

The **Diagnostics > Create diagnostic report** button on the PROTV dashboard page makes a report that
leaves passwords and secrets out and shortens IP addresses. Use that in bug reports.

## Notes

- Stream links in the VOD library are signed. The signing secret is created on first use and stored
  in `PROTV.Plugin.xml`. If it leaked, clear `VodStreamSecret` there, restart Jellyfin and run the VOD
  sync again to write new links.
- The plugin is an early-development community project made with the help of AI. Review it before
  you run it on a server you care about.
