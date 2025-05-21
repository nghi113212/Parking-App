# import cv2
# import os
# import sys

# owner = sys.argv[1]
# save_path = f"FaceRecognition/dataset/{owner}"
# os.makedirs(save_path, exist_ok=True)

# cam = cv2.VideoCapture(0)
# # cv2.namedWindow("Capture Face")

# count = 0
# while count < 1:
#     ret, frame = cam.read()
#     if not ret:
#         print("Failed")
#         break
#     cv2.imshow("Capture Face", frame)
#     k = cv2.waitKey(1)
#     if k % 256 == 32:  # SPACE pressed
#         img_name = f"{save_path}/face.jpg"
#         cv2.imwrite(img_name, frame)
#         print(owner)
#         count += 1

# cam.release()
# # cv2.destroyAllWindows()

import cv2
import os
import sys

owner = sys.argv[1]

#  Tự động lấy đường dẫn thư mục chứa file capture_face.py
base_path = os.path.dirname(os.path.abspath(__file__))
save_path = os.path.join(base_path, "dataset", owner)

os.makedirs(save_path, exist_ok=True)

cam = cv2.VideoCapture(0)

count = 0
while count < 1:
    ret, frame = cam.read()
    if not ret:
        print("Failed")
        break
    cv2.imshow("Capture Face", frame)
    k = cv2.waitKey(1)
    if k % 256 == 32:  # SPACE pressed
        img_name = os.path.join(save_path, "face.jpg")
        cv2.imwrite(img_name, frame)
        print(owner)
        count += 1

cam.release()
cv2.destroyAllWindows()
