import easyocr
import sys

reader = easyocr.Reader(['en'])

if len(sys.argv) > 1:
    image_path = sys.argv[1]
    results = reader.readtext(image_path)
    for (_, text, _) in results:
        if len(text) >= 4:
            print(text)
            break
    else:
        print("Không nhận diện được biển số.")
else:
    print("Không có ảnh.")