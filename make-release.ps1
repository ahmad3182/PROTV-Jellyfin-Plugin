# Builds the release zip for the PROTV plugin and fills in the manifest.
# Run from the project folder in PowerShell:
#   .\make-release.ps1 -GitHubUser "yourname" -Repo "protv-jellyfin"
param(
    [Parameter(Mandatory = $true)][string]$GitHubUser,
    [Parameter(Mandatory = $true)][string]$Repo,
    [string]$Version = "0.8.0",
    [string]$DllPath = ".\bin\Release\net10.0\PROTV.Plugin.dll",
    [string]$ManifestPath = ".\manifest.json"
)

if (-not (Test-Path $DllPath)) {
    Write-Error "DLL not found at $DllPath. Run: dotnet build -c Release"
    exit 1
}
if (-not (Test-Path $ManifestPath)) {
    Write-Error "manifest.json not found at $ManifestPath. Copy it next to this script."
    exit 1
}

$zip = "PROTV_$Version.zip"
if (Test-Path $zip) { Remove-Item $zip }
Compress-Archive -Path $DllPath -DestinationPath $zip

$md5 = (Get-FileHash $zip -Algorithm MD5).Hash
Write-Host "Created $zip"
Write-Host "MD5: $md5"

# Fill the manifest placeholders (first release only; for later versions add an entry by hand).
$text = Get-Content $ManifestPath -Raw
$text = $text -replace 'REPLACE_WITH_MD5_OF_THE_ZIP', $md5
$text = $text -replace 'YOUR_GITHUB_USERNAME', $GitHubUser
$text = $text -replace 'YOUR_REPO', $Repo
Set-Content -Path $ManifestPath -Value $text -Encoding UTF8
Write-Host "Updated $ManifestPath"
Write-Host ""
Write-Host "Next: upload $zip to the GitHub release tagged v$Version, then commit manifest.json."
Write-Host "Users add this URL under Dashboard > Plugins > Repositories:"
Write-Host "https://raw.githubusercontent.com/$GitHubUser/$Repo/main/manifest.json"
