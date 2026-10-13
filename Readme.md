[![NuGet](https://img.shields.io/nuget/v/Digi21.CoordinateSystems?style=flat)](https://www.nuget.org/packages/Digi21.CoordinateSystems/)

# Digi21.CoordinateSystems

This repository contains the source code of the [reference assembly](https://learn.microsoft.com/dotnet/standard/assembly/reference-assemblies) `Digi21.CoordinateSystems`, distributed in the NuGet package of the same name, for transforming coordinates between coordinate reference systems with Digi3D.AI.

The methods of the reference assembly have no implementation (`throw null`). Digi3D.AI installs the implementation in `<installation folder>\Digi21.CoordinateSystems\26.0.0\`, and the resolver added by the `Digi21.DigiNG` package loads it at run time.

The API documentation is in the [Digi3D.AI help](https://ayuda.digi21.net/digi3d-ai/programacion/.net/digi21.coordinatesystems).

## Publishing

1. Update `<version>` in `NuGet/Digi21.CoordinateSystems.nuspec` and, if the assembly version changes, `Version`, `AssemblyVersion` and `FileVersion` in the `.csproj`.
2. Push a tag `v<version>` that matches the version in the `.nuspec`.

The *Release* workflow builds the reference assembly, packs it and publishes it to nuget.org with trusted publishing (repository secret `NUGET_USER`, the nuget.org profile name, not the email address). The packages are not author-signed; the reference assembly is public-signed with `Digi21.PublicKey.snk`, which contains only the public key.
