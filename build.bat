@echo off
cd /d "%~dp0"
echo Building RimTalk - Foreign Initiator Control...
dotnet build -c Release
if errorlevel 1 (echo Build failed.&pause&exit /b 1)
echo Build succeeded.
pause
