
#Invoke-WebRequest "https://dist.nuget.org/win-x86-commandline/latest/nuget.exe" -OutFile "nuget.exe"

&.\nuget.exe pack bin\Release\Hemligheter.nuspec -Version 2.0.3 -OutputDirectory releases\nuget

.\SquirrelReleasify.ps1 -nugetSearchPath releases\nuget -releaseDir releases -squirrelSearchPath packages