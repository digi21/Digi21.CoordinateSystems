# Digi21.CoordinateSystems

Este paquete contiene un ensamblado de referencia con los tipos para transformar coordenadas entre sistemas de referencia de coordenadas de la base de datos de EPSG con [Digi3D.AI](https://www.digi21.net/Digi3D).

Digi3D.AI instala los ensamblados de ejecución. El paquete Digi21.DigiNG, del que depende este paquete, añade al proyecto de C# un archivo de código que los localiza en la carpeta de instalación de Digi3D.AI, así que la aplicación de consola o la extensión se puede instalar en cualquier carpeta. No hace falta añadir ningún otro paquete ni escribir código.

```csharp
using Digi21.CoordinateSystems;
using Digi21.Math;

var wgs84 = CoordinateSystem.FromEpsg(4979);     // X = latitud, Y = longitud, Z = altura elipsoidal
var utm30 = CoordinateSystem.FromEpsg(25830);
using var transformacion = CoordinateTransformation.Create(wgs84, utm30);
Point3D punto = transformacion.Transform(new Point3D(40.416775, -3.703790, 650.0));
```

Para ejecutar las aplicaciones que usan los ensamblados de este paquete hace falta una licencia de Digi3D.AI. [Alquile](https://www.digi21.net/Tienda/Alquiler) o [compre](https://www.digi21.net/Tienda/Compra) una licencia.
