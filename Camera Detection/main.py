import cv2
from tensorflow.keras.models import load_model
import numpy as np

# Load pre-trained face detection model
face_cascade = cv2.CascadeClassifier(cv2.data.haarcascades + 'haarcascade_frontalface_default.xml')

# Load pre-trained emotion detection model
emotion_model = load_model('FER_model.h5')

# Define emotions
emotion_labels = {0: 'Angry', 1: 'Disgust', 2: 'Fear', 3: 'Happy', 4: 'Sad', 5: 'Surprise', 6: 'Neutral'}


# Function to apply color overlay based on emotion
def apply_color_overlay(frame, emotion_label):
    overlay = frame.copy()
    if emotion_label == 'Happy':
        # Apply green color overlay
        overlay[:, :, 1] = 255  # Set green channel to 255
    elif emotion_label == 'Angry':
        # Apply red color overlay
        overlay[:, :, 2] = 255  # Set red channel to 255
    # Add transparency
    alpha = 0.5
    frame = cv2.addWeighted(overlay, alpha, frame, 1 - alpha, 0)
    return frame

# Function to detect face and emotions
def detect_face_emotion(frame):
    gray = cv2.cvtColor(frame, cv2.COLOR_BGR2GRAY)
    faces = face_cascade.detectMultiScale(gray, scaleFactor=1.1, minNeighbors=5, minSize=(30, 30))

    for (x, y, w, h) in faces:
        face_roi = gray[y:y + h, x:x + w]
        resized_face_roi = cv2.resize(face_roi, (48, 48))
        normalized_face_roi = resized_face_roi / 255.0
        reshaped_face_roi = np.reshape(normalized_face_roi, (1, 48, 48, 1))

        # Predict emotion
        emotion_prediction = emotion_model.predict(reshaped_face_roi)
        max_index = np.argmax(emotion_prediction[0])
        emotion_label = emotion_labels[max_index]

        cv2.rectangle(frame, (x, y), (x + w, y + h), (255, 0, 0), 2)
        cv2.putText(frame, emotion_label, (x, y), cv2.FONT_HERSHEY_SIMPLEX, 1, (0, 255, 0), 2, cv2.LINE_AA)

        # Apply color overlay based on emotion
        frame = apply_color_overlay(frame, emotion_label)

        # Take screenshot when emotion is Angry or Happy
        if emotion_label in ['Angry', 'Happy']:
            # Save the frame as an image
            cv2.imwrite('emotion_screenshot_{0}.png'.format(emotion_label), frame)

    return frame


# Start capturing video from the default camera
video_capture = cv2.VideoCapture(0)

# Set camera properties for better quality
video_capture.set(cv2.CAP_PROP_FRAME_WIDTH, 1920)
video_capture.set(cv2.CAP_PROP_FRAME_HEIGHT, 1080)
# video_capture.set(cv2.CAP_PROP_FPS, 30)

# Set camera brightness
video_capture.set(cv2.CAP_PROP_BRIGHTNESS, 0.6)  # Adjust this value as needed

# Set camera contrast
video_capture.set(cv2.CAP_PROP_CONTRAST, 0.5)  # Adjust this value as needed

# Set camera saturation
video_capture.set(cv2.CAP_PROP_SATURATION, 0.4)  # Adjust this value as needed

# Set camera white balance (only available on some cameras)
video_capture.set(cv2.CAP_PROP_AUTO_WB, 0)  # Disable auto white balance
video_capture.set(cv2.CAP_PROP_WB_TEMPERATURE, 6000)  # Adjust this value as needed

while True:
    # Capture frame-by-frame
    ret, frame = video_capture.read()

    # Perform face and emotion detection
    processed_frame = detect_face_emotion(frame)

    # Display the resulting frame
    cv2.imshow('Face Emotion Detection', processed_frame)

    # Break the loop when 'q' is pressed
    if cv2.waitKey(1) & 0xFF == ord('q'):
        break

# Release the capture
video_capture.release()
cv2.destroyAllWindows()
