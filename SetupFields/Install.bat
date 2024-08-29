@echo off
REM Cambia estas variables a las rutas y nombres correctos
SET SERVICE_NAME=SRVIntegracionDocumentos
SET SERVICE_PATH=C:\EXXIS\⁬imarcoc\SRVIntegracionDocumentos\bin\Debug\SRVIntegracionDocumentos.exe

REM Instalar el servicio
sc create "%SERVICE_NAME%" binPath= "%SERVICE_PATH%"

REM Configurar el servicio para que inicie automáticamente
sc config "%SERVICE_NAME%" start= auto

REM Iniciar el servicio
net start "%SERVICE_NAME%"

REM Verificar el estado del servicio
sc query "%SERVICE_NAME%"

echo Servicio %SERVICE_NAME% instalado y iniciado correctamente.
pause