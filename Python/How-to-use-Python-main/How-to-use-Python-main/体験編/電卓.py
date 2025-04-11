import tkinter as tk

class Calculator(tk.Tk):
    def __init__(self):
        super().__init__()
        self.title("電卓")
        self.geometry("300x400")
        self.result_var = tk.StringVar()

        self.create_widgets()

    def create_widgets(self):
        # 結果表示エリア
        result_entry = tk.Entry(self, textvariable=self.result_var, font=("Arial", 24), bd=10, relief="ridge")
        result_entry.grid(row=0, column=0, columnspan=4)

        # ボタン配置
        buttons = [
            ('7', 1, 0), ('8', 1, 1), ('9', 1, 2), ('/', 1, 3),
            ('4', 2, 0), ('5', 2, 1), ('6', 2, 2), ('*', 2, 3),
            ('1', 3, 0), ('2', 3, 1), ('3', 3, 2), ('-', 3, 3),
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

