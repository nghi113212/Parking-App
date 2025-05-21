# import cv2
# import os
# import sys

# owner = sys.argv[1]
# base_dir = os.path.dirname(os.path.abspath(__file__))
# dataset_path = os.path.join(base_dir, "dataset", owner, "face.jpg")

# if not os.path.exists(dataset_path):
#     print("NO_IMAGE")
#     exit()

# # Load face detector
# face_cascade = cv2.CascadeClassifier(cv2.data.haarcascades + 'haarcascade_frontalface_default.xml')

# # Read and process known image
# known_img = cv2.imread(dataset_path, cv2.IMREAD_GRAYSCALE)
# faces = face_cascade.detectMultiScale(known_img, scaleFactor=1.1, minNeighbors=5)
# if len(faces) == 0:
#     print("NO_FACE_IN_IMAGE")
#     exit()

# (x, y, w, h) = faces[0]
# known_face = known_img[y:y+h, x:x+w]

# # Train recognizer
# recognizer = cv2.face.LBPHFaceRecognizer_create()
# recognizer.train([known_face], [1])

# # Capture from webcam
# cam = cv2.VideoCapture(0)
# ret, frame = cam.read()
# cam.release()

# if not ret:
#     print("FAILED")
#     exit()

# gray = cv2.cvtColor(frame, cv2.COLOR_BGR2GRAY)
# faces = face_cascade.detectMultiScale(gray, scaleFactor=1.1, minNeighbors=5)
# if len(faces) == 0:
#     print("NO_FACE")
#     exit()

# (x, y, w, h) = faces[0]
# test_face = gray[y:y+h, x:x+w]

# # Predict
# label, confidence = recognizer.predict(test_face)
# if label == 1 and confidence < 70:  # confidence càng thấp càng tốt
#     print("MATCH")
# else:
#     print("NO_MATCH")
################################################################################################################################################################



# import cv2
# import os
# import sys
# import numpy as np  # thêm import này

# owner = sys.argv[1]
# base_dir = os.path.dirname(os.path.abspath(__file__))
# dataset_path = os.path.join(base_dir, "dataset", owner, "face.jpg")

# if not os.path.exists(dataset_path):
#     print("NO_IMAGE")
#     exit()

# face_cascade = cv2.CascadeClassifier(cv2.data.haarcascades + 'haarcascade_frontalface_default.xml')

# known_img = cv2.imread(dataset_path, cv2.IMREAD_GRAYSCALE)
# faces = face_cascade.detectMultiScale(known_img, scaleFactor=1.1, minNeighbors=5)
# if len(faces) == 0:
#     print("NO_FACE_IN_IMAGE")
#     exit()

# (x, y, w, h) = faces[0]
# known_face = known_img[y:y+h, x:x+w]

# recognizer = cv2.face.LBPHFaceRecognizer_create()
# recognizer.train([known_face], np.array([1], dtype=np.int32))  # sửa ở đây

# cam = cv2.VideoCapture(0)
# ret, frame = cam.read()
# cam.release()

# if not ret:
#     print("FAILED")
#     exit()

# gray = cv2.cvtColor(frame, cv2.COLOR_BGR2GRAY)
# faces = face_cascade.detectMultiScale(gray, scaleFactor=1.1, minNeighbors=5)
# if len(faces) == 0:
#     print("NO_FACE")
#     exit()

# (x, y, w, h) = faces[0]
# test_face = gray[y:y+h, x:x+w]

# label, confidence = recognizer.predict(test_face)
# if label == 1 and confidence < 70:
#     print("MATCH")
# else:
#     print("NO_MATCH")







import cv2
import os
import sys
import numpy as np

owner = sys.argv[1]
base_dir = os.path.dirname(os.path.abspath(__file__))
dataset_path = os.path.join(base_dir, "dataset", owner, "face.jpg")

if not os.path.exists(dataset_path):
    print("NO_IMAGE")
    exit()

face_cascade = cv2.CascadeClassifier(cv2.data.haarcascades + 'haarcascade_frontalface_default.xml')

known_img = cv2.imread(dataset_path, cv2.IMREAD_GRAYSCALE)
faces = face_cascade.detectMultiScale(known_img, scaleFactor=1.1, minNeighbors=5)
if len(faces) == 0:
    print("NO_FACE_IN_IMAGE")
    exit()

(x, y, w, h) = faces[0]
known_face = known_img[y:y+h, x:x+w]

recognizer = cv2.face.LBPHFaceRecognizer_create()
recognizer.train([known_face], np.array([1], dtype=np.int32))

cam = cv2.VideoCapture(0)

while True:
    ret, frame = cam.read()
    if not ret:
        print("FAILED")
        break

    gray = cv2.cvtColor(frame, cv2.COLOR_BGR2GRAY)
    faces = face_cascade.detectMultiScale(gray, scaleFactor=1.1, minNeighbors=5)
    for (x, y, w, h) in faces:
        test_face = gray[y:y+h, x:x+w]
        label, confidence = recognizer.predict(test_face)
        # if label == 1 and confidence < 70:
        #     cv2.putText(frame, "MATCH", (x, y-10), cv2.FONT_HERSHEY_SIMPLEX, 0.9, (0, 255, 0), 2)
        #     cv2.rectangle(frame, (x, y), (x+w, y+h), (0, 255, 0), 2)
        # else:
        #     cv2.putText(frame, "NO MATCH", (x, y-10), cv2.FONT_HERSHEY_SIMPLEX, 0.9, (0, 0, 255), 2)
        #     cv2.rectangle(frame, (x, y), (x+w, y+h), (0, 0, 255), 2)
        if label == 1 and confidence < 90:
            print("MATCH")
            cv2.putText(frame, "MATCH", (x, y-10), cv2.FONT_HERSHEY_SIMPLEX, 0.9, (0, 255, 0), 2)
            cv2.rectangle(frame, (x, y), (x+w, y+h), (0, 255, 0), 2)
            cv2.imshow("Face Recognition", frame)
            cv2.waitKey(3000)  # Hiển thị 2 giây
            cam.release()
            cv2.destroyAllWindows()
            exit()

            cv2.imshow("Face Recognition", frame)

        k = cv2.waitKey(1) & 0xFF
        if k == 27:  # Nhấn ESC để thoát
            break

cam.release()
cv2.destroyAllWindows()
