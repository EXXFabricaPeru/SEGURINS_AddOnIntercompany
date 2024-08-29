@echo off
REM Nombre del servicio que quieres desinstalar
SET ServiceName=SRVIntegracionDocumentos

REM Detener el servicio si está en ejecución
net stop %ServiceName%

REM Desinstalar el servicio
sc delete %ServiceName%

REM Confirmación de desinstalación
echo El servicio %ServiceName% ha sido desinstalado.
pause