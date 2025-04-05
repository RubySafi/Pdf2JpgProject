@echo off
if "%1"=="" (
    echo Usage: Drag and drop a PDF file onto this batch file.
    pause
    exit /b
)

if "%2"=="" (
    set OUTPUT_FOLDER=output
) else (
    set OUTPUT_FOLDER=%2
)

python pdf2jpg.py "%1" "%OUTPUT_FOLDER%"

if %errorlevel% == 0 (
    echo Conversion successful.
    start explorer "%OUTPUT_FOLDER%"
) else (
    echo Conversion failed.
)

pause
