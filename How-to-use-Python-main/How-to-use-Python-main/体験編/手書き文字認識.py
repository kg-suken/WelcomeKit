import numpy as np
import tensorflow as tf
from tensorflow import keras
from keras import layers
import cv2
import tkinter as tk
from PIL import Image, ImageDraw, ImageOps

# モデルの構築と学習 (MNISTを使用)
def create_and_train_model():
    (x_train, y_train), (x_test, y_test) = keras.datasets.mnist.load_data()
    x_train = x_train / 255.0
    x_test = x_test / 255.0

    model = keras.Sequential([
        layers.Flatten(input_shape=(28, 28)),
        layers.Dense(128, activation='relu'),
        layers.Dense(10, activation='softmax')
    ])

    model.compile(optimizer='adam', loss='sparse_categorical_crossentropy', metrics=['accuracy'])
    model.fit(x_train, y_train, epochs=5, validation_data=(x_test, y_test))

    model.save("handwriting_model.h5")
    print("モデルを保存しました。")
    return model

# 手書きキャンバスの設定
class HandwritingApp(tk.Tk):
    def __init__(self, model):
        super().__init__()
        self.model = model
        self.title("手書き認識")
        self.geometry("300x350")
        self.canvas = tk.Canvas(self, width=280, height=280, bg="white")
        self.canvas.pack(pady=10)

        self.button_clear = tk.Button(self, text="クリア", command=self.clear_canvas)
        self.button_clear.pack(side=tk.LEFT, padx=20)

        self.button_predict = tk.Button(self, text="判定", command=self.predict_digit)
        self.button_predict.pack(side=tk.RIGHT, padx=20)

        self.result_label = tk.Label(self, text="結果: ", font=("Helvetica", 18))
        self.result_label.pack()

        self.image = Image.new("L", (280, 280), 255)
        self.draw = ImageDraw.Draw(self.image)

        self.canvas.bind("<B1-Motion>", self.paint)

    def paint(self, event):
        x, y = event.x, event.y
        self.canvas.create_oval(x-10, y-10, x+10, y+10, fill="black")
        self.draw.ellipse([x-10, y-10, x+10, y+10], fill=0)

    def clear_canvas(self):
        self.canvas.delete("all")
        self.draw.rectangle([0, 0, 280, 280], fill=255)

    def predict_digit(self):
        img = self.image.copy().resize((28, 28))
        img = ImageOps.invert(img)
        img = np.array(img) / 255.0
        img = img.reshape(1, 28, 28)
        prediction = self.model.predict(img)
        digit = np.argmax(prediction)
        self.result_label.config(text=f"結果: {digit}")

# モデル読み込みまたは学習
def main():
    try:
        model = keras.models.load_model("handwriting_model.h5")
        print("保存されたモデルをロードしました。")
    except Exception as e:
        print(f"モデルが見つかりません。再学習します: {e}")
        model = create_and_train_model()

    app = HandwritingApp(model)
    app.mainloop()

if __name__ == "__main__":
    main()
