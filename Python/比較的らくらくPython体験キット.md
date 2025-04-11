# Python体験編

## 1. はじめに

これはPythonに触れたいけど難しそうなことはやりたくない！という人向けです。2つの作品と少しの課題で楽しく学べると思います。

これを読む前にPythonのすゝめの2.インストールまで読んでインストールを完了させることを強く勧めます。

完成形は体験編フォルダにあるので課題ができたらぜひ同じように動作するか自身の環境に移して試してみてください。

## 2. 電卓を作ろう

早速見ていきましょう。以下のコードは電卓ですが、何かがおかしいです。実行して確かめてみてください。

```python
import tkinter as tk # Tkinterモジュール(アプリの見た目を司るやつ)を読み込む

class Calculator(tk.Tk):
    def __init__(self): # 初期化(おまじない)
        super().__init__()
        self.title("電卓") # アプリの名前を決める
        self.geometry("300x400") # スクリーンのサイズ
        self.result_var = tk.StringVar() # 計算式、結果表示

        self.create_widgets()

    def create_widgets(self):
        # 結果表示エリア
        result_entry = tk.Entry(self, textvariable=self.result_var, font=("Arial", 24), bd=10, relief="ridge")
        result_entry.grid(row=0, column=0, columnspan=4)

        # ボタン配置(''で囲まれている文字が入力される)
        buttons = [
            ('7', 1, 0), ('5', 1, 1), ('9', 1, 2), ('+', 1, 3),
            ('8', 2, 0), ('3', 2, 1), ('6', 2, 2), ('+', 2, 3),
            ('1', 3, 0), ('2', 3, 1), ('4', 3, 2), ('+', 3, 3),
            ('0', 4, 0), ('.', 4, 1), ('=', 4, 2), ('+', 4, 3),
            ('C', 5, 0, 4)
        ]

        for btn in buttons:
            text, row, col = btn[:3]
            colspan = btn[3] if len(btn) == 4 else 1
            button = tk.Button(self, text=text, font=("Arial", 18), padx=20, pady=20, command=lambda t=text: self.on_button_click(t))
            button.grid(row=row, column=col, columnspan=colspan, sticky="news")

        for i in range(4):
            self.grid_columnconfigure(i, weight=1)
        for i in range(6):
            self.grid_rowconfigure(i, weight=1)

    def on_button_click(self, char):
        if char == 'C':
            self.result_var.set('')
        elif char == '=':
            try:
                result = str(eval(self.result_var.get()))
                self.result_var.set(result)
            except Exception as e:
                self.result_var.set("エラー")
        else:
            self.result_var.set(self.result_var.get() + char)

if __name__ == "__main__":
    app = Calculator()
    app.mainloop()
```

わかりましたか？記号(+, -, *(×), /(÷))が全部+になっていてしかも数字がぐちゃぐちゃです。このままでは使い物にならないので直していきましょう。

まず、33~39行目が表示されるボタンに書かれる文字の一覧です。()の中にいくつか書かれていますが、これらは

```
(書かれる文字, 表示される位置(縦), 表示される位置(横))
```

または

```
(書かれる文字, 表示される位置(縦), 表示される位置(横), 横の長さ(デフォルトは1))
```

となっています。4つ目の要素は計算リセットのボタンにだけありますがこれは横に長くするためです。

さて、何をいじればいいかわかりましたか？

今回は書かれている文字がおかしいので1つ目の要素だけを順番に変えてあげればよさそうです。だから、、、

```python
buttons = [
            ('7', 1, 0), ('5', 1, 1), ('9', 1, 2), ('+', 1, 3),
            ('8', 2, 0), ('3', 2, 1), ('6', 2, 2), ('+', 2, 3),
            ('1', 3, 0), ('2', 3, 1), ('4', 3, 2), ('+', 3, 3),
            ('0', 4, 0), ('.', 4, 1), ('=', 4, 2), ('+', 4, 3),
            ('C', 5, 0, 4)
        ]
```

これを、、、

```python
buttons = [
            ('7', 1, 0), ('8', 1, 1), ('9', 1, 2), ('/', 1, 3),
            ('4', 2, 0), ('5', 2, 1), ('6', 2, 2), ('*', 2, 3),
            ('1', 3, 0), ('2', 3, 1), ('3', 3, 2), ('-', 3, 3),
            ('0', 4, 0), ('.', 4, 1), ('=', 4, 2), ('+', 4, 3),
            ('C', 5, 0, 4)
        ]
```
こう！

これでボタンが正しく表示されましたね。

## 3. 手書き文字認識AIを作ろう

やっぱりPythonといえばAIですよね。今回はテストの採点とかで使われている手書き文字の認識をやるAIを作っていきましょう。

以下がコードですが、やっぱり未完成なので直してあげましょう。まず、コマンドプロンプトで次を実行してください。

```cmd
pip install tensorflow

```

以下がコードです。移して実行してみてください。

```python
# いろいろインポート
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
        #モ
        #デ
        #ル
        'lol'
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

```

さて、今回はAIのモデルがまともに定義されていませんね。

ここで少しAIの話をしましょう。

今回やるのは深層学習というものなのですがこれは人間の脳をまねたニューラルネットワークというものを用いて作られています。具体的な話は全て省きますが、学習にはこれを搭載した学習する本体(モデル)が必要になります。今回はこれの定義があまりにも不十分だということです。

今回変えるのは

```python
model = keras.Sequential([
        #モ
        #デ
        #ル
        'lol'
    ])

```

ここです。舐めてますね。今回はシンプルなモデルを実装します。

```python
model = keras.Sequential([
        layers.Flatten(input_shape=(28, 28)),
        layers.Dense(128, activation='relu'),
        layers.Dense(10, activation='softmax')
    ])
```

こうしましょう。Flatten関数はその名の通りデータを平坦にしてくれます。これはどういうことかというと、たとえば画像データは(R,G,B)の3次元から構成されていますが、これを1次元にするのです。つまり、データをまとめてくれるということですね。
Dense関数は先ほどのニューラルネットワークの核となる人工ニューロンを作成する関数です。

実行すると学習が開始し、完了するとパソコンに保存されます。その後ウィンドウが起動し、そこに自由にお絵描きできます。数字を書いた後に判定ボタンを押すとAIがなんの数字を書いたか判定してくれます。精度は正直微妙です。ゆるして。



