[CmdletBinding()]
param(
    [Parameter(Mandatory)][string] $squirrelSearchPath,
    [Parameter(Mandatory)][string] $nugetSearchPath,
    [Parameter(Mandatory)][string] $releaseDir
)

# Find squirrel.exe
$squirrel = Get-ChildItem $squirrelSearchPath -Recurse -Filter *.exe | Where-Object{ !$_.PSIsContainer -and [System.IO.Path]::GetFileNameWithoutExtension($_.Name) -eq "Squirrel"} | ForEach-Object { $_.FullName }
if(!$squirrel)
{
    Write-Error "Unable to find Squirrel.exe"
    exit 1
}

Write-Output "Found Squirrel Installation. Using $squirrel"

# Find nupkg
$nupkgs = Get-ChildItem $nugetSearchPath -Recurse -Filter *.nupkg | Where-Object{ !$_.PSIsContainer } | ForEach-Object { $_.FullName }
if(!$nupkgs)
{
    Write-Warning "Unable to find nupkg(s)"
    exit 1
}

Write-Output  "Found $($nupkgs.count) nupkg(s)"
foreach ($nupkg in $nupkgs) {
    Write-Output  $nupkg

    # Crete squirrel package from nupkg
    &$squirrel --releasify $nupkg --releaseDir $releaseDir | Write-Output
}