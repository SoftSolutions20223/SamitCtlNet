@echo off
setlocal

echo Introduce la ruta de la carpeta:
set /p folder="Ruta: "
if not defined folder (
    echo No se ha introducido ninguna ruta. Saliendo.
    pause
    exit /b
)

if not exist "%folder%" (
    echo La ruta "%folder%" no existe. Saliendo.
    pause
    exit /b
)

echo Desbloqueando todos los archivos en: %folder%
powershell -NoProfile -Command "Get-ChildItem -Path '%folder%' -Recurse | Unblock-File"
echo Todos los archivos han sido desbloqueados.
pause
