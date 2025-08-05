@echo off
:loop
taskkill /im supertuxkart.exe /F /T > null2>&1
taskkill /im Minecraft.exe /F /T > null 2>&1
taskkill /im EpicGamesLauncher.exe /F /T > null 2>&1
timeout /t 1 >nul
goto loop

