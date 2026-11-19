# KENTUYUK source audit (based on supplied ZIP)

## Archive inventory
26 entries were present in the supplied archive:
- 16 C# source files
- 4 resource files (`.resx` / generated resource support)
- project file, manifest, icon, build note, and assembly metadata

## Confirmed source structure
- `Program.cs`: starts the WinForms application by constructing `App`.
- `App.cs`: main application form and feature orchestration.
- `Login.cs`: login form and background-worker flow.
- `Synchro.cs`: synchronization form.
- `GClass0.cs` through `GClass6.cs`: supporting/decompiled classes.
- `RFSNCS.Memory/Memory.cs`, `MemoryAPI.cs`, `Addr.cs`: process-memory helper code.
- `RFSNCS.Properties/Resources.cs` and `Settings.cs`: generated resource/settings accessors.
- `Class10.cs`: image/resource wrapper.
- `Class18.cs`: version constants.

## Project issues found
1. Original project uses SDK-style `net48`, x64, WinForms, and C# 14.
2. Original project has unversioned assembly references for Newtonsoft.Json, BouncyCastle.Crypto, and System.Management.
3. Original project has a hard-coded `System.Core.dll` HintPath pointing into the decompiler machine's .NET 10 installation. This is not portable and was removed; the framework reference should be supplied by the target framework.
4. Original `_BUILDING.txt` explicitly warns that the export may need fixes and that build/runtime behavior has not been verified.
5. No `.github/workflows` workflow was included.
6. No original EXE or original dependency DLLs were present in the archive, so binary equivalence and exact dependency versions cannot be confirmed.

## Prepared changes
- Replaced the local/unversioned references with NuGet package references.
- Added the .NET Framework 4.8 reference-assemblies package.
- Added a Windows GitHub Actions workflow using .NET SDK 10.
- Added build and reconstruction notes in `README.md`.

## Not yet verified
- No actual Windows build has been run in this environment.
- C# compilation may still fail due to decompiler output or dependency compatibility.
- Resource manifest names and runtime image loading need verification in the built application.
- Login/network/authentication behavior has not been tested.
- Runtime behavior has not been compared with an original executable.


## Additional security observations
- `GClass0.cs` contains hard-coded HTTP service endpoints (`/users/account` and `/users/secret`), token-like values, and embedded RSA key material. Ownership and validity are unknown from the archive alone. Keep the repository private until reviewed; do not assume these are safe to publish.
- `Login.cs` obtains a date from `http://www.google.com` as a time fallback/check.
- `App.cs` launches a shortened external URL through `explorer.exe`. The destination was not followed or contacted during this audit.
- No external endpoint was contacted during this audit.
