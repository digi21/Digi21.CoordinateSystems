[![NuGet](https://img.shields.io/nuget/v/Digi21.CoordinateSystems?style=flat)](https://www.nuget.org/packages/Digi21.CoordinateSystems/)

# Digi21.CoordinateSystems

Este repositorio contiene el código fuente del [ensamblado de referencia](https://learn.microsoft.com/dotnet/standard/assembly/reference-assemblies) `Digi21.CoordinateSystems`, que se distribuye en el paquete NuGet del mismo nombre para transformar coordenadas entre sistemas de referencia de coordenadas con Digi3D.AI.

Los métodos del ensamblado de referencia no tienen implementación (`throw null`). Digi3D.AI instala la implementación en `<carpeta de instalación>\Digi21.CoordinateSystems\26.0.0\`, y el resolvedor que añade el paquete `Digi21.DigiNG` la carga en tiempo de ejecución.

La documentación de la API está en la [ayuda de Digi3D.AI](https://ayuda.digi21.net/digi3d-ai/programacion/.net/digi21.coordinatesystems).

## Publicación

1. Actualiza la versión en `<version>` del archivo `NuGet/Digi21.CoordinateSystems.nuspec` y, si cambia la versión del ensamblado, en `Version`, `AssemblyVersion` y `FileVersion` del `.csproj`.
2. Crea una etiqueta `v<versión>` igual a la versión del `.nuspec` y envíala a GitHub.

El flujo de trabajo *Release* compila el ensamblado de referencia, crea el paquete y lo publica en nuget.org con *trusted publishing* (el secreto del repositorio `NUGET_USER` contiene el nombre del perfil de nuget.org, no la dirección de correo). Los paquetes no llevan firma de autor; el ensamblado de referencia lleva firma pública (*public signing*) con `Digi21.PublicKey.snk`, que solo contiene la clave pública.
