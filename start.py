import time
import pymcprotocol
from keras.models import load_model
from PIL import Image, ImageOps
import numpy as np

np.set_printoptions(suppress=True)

model = load_model("C:\\Users\\user\\Downloads\\keras_Model.h5", compile=False)

class_names = open("C:\\Users\\user\\Downloads\\labels.txt", "r").readlines()

data = np.ndarray(shape=(1, 224, 224, 3), dtype=np.float32)

pymc3e = pymcprotocol.Type3E()
pymc3e.setaccessopt(commtype="binary")
pymc3e.connect("192.168.3.39", 3898)

class_1_address = "M5"
class_2_address = "M6"

class_1_value = 0
class_2_value = 0

while True:
    try:
        m11_values = pymc3e.batchread_wordunits(headdevice="M11", readsize=1)
        print(m11_values)
        m11_value = m11_values[0]
        print(m11_value)

        if m11_value == 1:
            d10_values = pymc3e.batchread_wordunits(headdevice="D10", readsize=1)
            image = Image.open("\\\\192.168.0.10\\pi\\04-05_"+str(d10_values[0])+".jpg").convert("RGB")

            size = (224, 224)
            image = ImageOps.fit(image, size, Image.LANCZOS)

            image_array = np.asarray(image)

            normalized_image_array = (image_array.astype(np.float32) / 127.5) - 1

            data[0] = normalized_image_array

            prediction = model.predict(data)
            index = np.argmax(prediction)
            class_name = class_names[index]
            confidence_score = prediction[0][index]

            if "Class 1" in class_name:
                class_1_value = 1
                pymc3e.batchwrite_wordunits(headdevice="M20", values=[1])
                pymc3e.batchwrite_wordunits(headdevice="M21", values=[0])
                pymc3e.batchwrite_wordunits(headdevice="M22", values=[1])
                pymc3e.batchwrite_wordunits(headdevice="D11", values=[1])
                pymc3e.batchwrite_wordunits(headdevice="D112", values=[1])
                time.sleep(1.5)
                pymc3e.batchwrite_wordunits(headdevice="M20", values=[0])
            elif "Class 2" in class_name:
                class_2_value = 1
                pymc3e.batchwrite_wordunits(headdevice="M20", values=[0])
                pymc3e.batchwrite_wordunits(headdevice="M21", values=[1])
                pymc3e.batchwrite_wordunits(headdevice="M22", values=[1])
                pymc3e.batchwrite_wordunits(headdevice="D11", values=[2])
                pymc3e.batchwrite_wordunits(headdevice="D112", values=[2])
                time.sleep(1.5)
                pymc3e.batchwrite_wordunits(headdevice="M21", values=[0])
            else:
                pymc3e.batchwrite_wordunits(headdevice="D11", values=[0])
            print("Class:", class_name[2:])
            print("Confidence Score:", confidence_score)

            print(class_1_value, class_2_value)
            print("Class name:", class_name)

            # m11 값을 0으로 초기화
            pymc3e.batchwrite_wordunits(headdevice="M11", values=[0])
    except Exception as e:
            print("Error:", e)
            continue