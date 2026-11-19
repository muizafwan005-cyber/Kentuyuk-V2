# KENTUYUK — Decompiled Source Reconstruction

This repository contains the C# source exported from the supplied `KENTUYUK.zip`, plus an initial GitHub Actions build configuration.

## Project target

- Windows Forms
- .NET Framework 4.8 (`net48`)
- x64
- C# language version 14.0
- Build runner: GitHub Actions `windows-latest`
- SDK: .NET 10

## Build with GitHub Actions

1. Create a GitHub repository.
2. Upload the contents of this folder to the repository root (not the containing folder).
3. Open **Actions**.
4. Run **Build KENTUYUK**, or push a commit to `main`/`master`.
5. When the workflow completes, download the artifact named `KENTUYUK-Release-net48-x64`.

## Dependency references added

The original project referenced DLLs without NuGet package versions and included a machine-specific `System.Core.dll` path. The prepared project replaces those entries with package references:

- `Newtonsoft.Json` 13.0.3
- `BouncyCastle` 1.8.9 (legacy package exposing `Org.BouncyCastle.*`)
- `System.Management` 8.0.0
- `Microsoft.NETFramework.ReferenceAssemblies.net48` 1.0.3

The package versions are initial compatibility choices based on namespaces referenced by the source. They still need to be confirmed by a successful build and runtime testing.

## Important reconstruction notes

This is a decompiled source export, not a verified original source tree. A successful compile does not prove that the rebuilt executable behaves identically to the original.

The first GitHub build may expose decompiler-related compile errors, missing metadata, resource naming issues, or dependency/API mismatches. Fix those based on the actual compiler output rather than changing application logic speculatively.

Do not remove or rename the `.resx` files, resource classes, namespaces, or source files until their use has been checked. The resource names are important to runtime image loading.

## Known caveats from the supplied archive

- The archive did not include the original executable for binary comparison.
- The archive did not include the original dependency DLLs or exact dependency versions.
- `Login.cs` and `GClass4.cs` should be reviewed for the original login/authentication flow and any external service dependency.
- `Memory.cs` and `MemoryAPI.cs` contain process-memory read/write functionality. Test only against software and processes you own or are authorized to inspect.
- The original `_BUILDING.txt` says the export may require fixes and that source export alone is not a compilation or behavior check.

## Suggested next step

Push this prepared project to a private GitHub repository first, run the workflow, and share the complete first build log. Resolve compiler errors in small batches while preserving the decompiled behavior.


## Security review before publishing

The decompiled `GClass0.cs` contains hard-coded service URLs using plain HTTP, token-like constants, and embedded RSA/cryptographic key material. These values should be treated as sensitive until their ownership and purpose are confirmed. Do not publish this repository publicly or reuse those credentials/keys without authorization. The build workflow does not contact those endpoints; it only compiles the source.
