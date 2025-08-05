@echo off
:loop
taskkill /im supertuxkart.exe /F /T
taskkill /im Minecraft.exe /F /T
taskkill /im EpicGamesLauncher.exe /F /T
timeout /t 1 >nul
goto loop

