# Apollo

Apollo es un proyecto hecho en C# para la materia PAV1 de la carrera Ing en Sistemas.

## Como instalar

### Desde el codigo fuente

1. Descargar el master haciendo click [acá](https://github.com/gaticafederico/LibreriaApollo/archive/master.zip) o clonar el proyecto usando ```git clone https://github.com/gaticafederico/LibreriaApollo```
2. Crear una carpeta llamada ```LibreriaApollo``` en ```C:\Users\NOMBREDEMIPC\source\repos```
3. Extraer el master en la carpeta ```LibreriaApollo``` de forma que quede ```LibreriaApollo\LibreriaApollo``` y ```LibreriaApollo\packages```
4. Crear una base de datos llamada apollo2
5. Importar los datos de ```SCRIPT.sql```
6. Modificar la string cadena_conexion ubicada en ```BD/Conexion.cs``` si fuera necesario

### Desde el archivo ejecutable

1. Descargar la release haciendo click [acá](https://github.com/gaticafederico/LibreriaApollo/releases)
2. Crear una base de datos llamada apollo2
3. Importar los datos de ```SCRIPT.sql```

## Posibles errores

Error: **No se puede procesar el archivo .... porque está en Internet o en una zona restriginda, o bien tiene la marca de la Web. Quite esta marca is desea procesar los archivos.**

Explicacion: Por defecto C# no confia en los archivos descargados de Internet y al compilar el proyecto, no se va a poder

Solucion: Ejecutar PowerShell en Windows y navegar hasta el directorio ```C:\Users\NOMBREDEMIPC\source\repos\LibreriaApollo``` y ejecutar ```Unblock-File *.resx```

## Gracias a

- Arriaga, Martin
- Aimar, Pablo
- Cordero, Valentina
- Gatica, Federico
- Olivera, Nehuen
- Pacciaroni, Sergio Ariel
