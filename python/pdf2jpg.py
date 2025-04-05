import os
import sys
from pdf2image import convert_from_path
from tqdm import tqdm

if len(sys.argv) < 2:
    print("Usage: python pdf2jpg.py <input_pdf_file> [output_folder]")
    sys.exit(1)

pdf_path = sys.argv[1]
output_folder = sys.argv[2] if len(sys.argv) > 2 else "output"  # Default to "output"

script_dir = os.getcwd()
poppler_bin_path = os.path.join(script_dir, '..', 'poppler', 'Library', 'bin')

#check output folder 
os.makedirs(output_folder, exist_ok=True)

images = convert_from_path(pdf_path, poppler_path=poppler_bin_path)

print(f"Converting {pdf_path} to JPG...")
#save
for i, image in tqdm(enumerate(images), total=len(images), desc="Processing pages", ncols=100):
    output_path = os.path.join(output_folder, f"page_{i+1}.jpg")
    image.save(output_path, "JPEG")

print(f"Conversion complete. Images are saved in: {os.path.abspath(output_folder)}")
