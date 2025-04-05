# Pdf2JpgProject

## Description
Pdf2JpgProject is a simple utility that converts PDF files to JPG images. It provides both a GUI application built with C# and a command-line tool using Python. This project also includes a batch script to automate the conversion process, as well as an easy-to-use graphical interface.

## Project structure

The project is primarily organized into the following directories:

- `/bat`: Contains batch scripts to run the Python script.
- `/csharp`: Contains the source code for the C# GUI application (`Pdf2JpgGui.exe`).
- `/python`: Contains the Python script that handles the PDF-to-JPG conversion (`pdf2jpg.py`).
- `/poppler`: A dependency required for handling PDF rendering (**gitignored**).
- `/release`: Contains the packaged release files for users.

## Requirements to manage this project

Before running the script, you need to install the following dependencies:

- **pdf2image**: A Python library used to convert PDFs to images.
- **tqdm**: A Python library that displays a progress bar visually.
- **Poppler**: A tool required by `pdf2image` for PDF rendering.
  
For Poppler, please download and extract Poppler into a folder named `/poppler` at the root of the project. This folder will be referenced by the Python script.

## Release Directory

The `/release` directory contains the latest files from the `/bat`, `/csharp`, and `/python` directories. It will include the following files and folders:

/release
├ /poppler           # Poppler dependency (**gitignored**) 
├ config.json        # Configuration file for app settings 
├ pdf2jpg.py         # Latest Python script 
├ run_pdf2jpg.bat    # Batch file for running the Python script 
├ Pdf2JpgGui.exe     # Latest C# GUI executable 
├ other files related to the C# project
└ readme.txt         # Additional instructions and usage details

Apart from manually adding the `/poppler` directory, this release directory is sufficient to launch the application. You will need to manually update it if there are any changes in the `/bat`, `/python`, or `/csharp` directories.

For detailed usage instructions, please refer to the readme.txt file located in the `/release` directory.

## License
This project is licensed under the MIT License - see the LICENSE file for details.


