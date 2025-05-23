# さあ、プログラミングを始めよう!
環境構築、お疲れさまでした!  
いよいよプログラミングの時間です!
## 1.さっそくやってみよう!
まあとにかく、プログラムを書いてみましょう。
Ctrl+Shift+@同時押しで「ターミナル」を開いて、```code helloworld.cpp```と打ってenterを押すと、helloworld.cppというファイルができます。  
C++で文字を出力するためには、「cout」というものを使います。構文はこんな感じです。  
```cout << (出力したい文字列);```
C++では、文字列を扱うときに""(ダブルクォーテーション)で囲う必要があります。これをしないとエラーになるので注意してください。
まあとりあえず、「Hello,World!」を出力するプログラムを見てみましょう。
```cpp
#include <iostream>

using namespace std;

int main(){
    cout << "Hello,World!" << endl;
    return 0;
}
```  
動かすときは、F5キーを押して、上に出てくる「g++ アクティブなファイルのビルド」を選択してください。その後、ターミナルを見るとちゃんと出力されているのが確認できると思います。  
## 2.プログラムについて簡単に説明
この、cout << "Hello,World!" << endl;の行で、「Hello,World!」を出力しています。これを見ると、ちゃんと""で囲われていますね。  
また、endlというのは「改行」の意味です。1行ずつしっかり表示させたい場合は、忘れずに...  
> [!TIP]
> "\n"でも代替できます。また、endlは""で囲む必要はないです。

また、```#include <iostream>```や```using namespace std;```は、今は知らなくていいです。また個別に教えます。  
そして、```int main()```は、この中のプログラムを自動で実行するという意味です。  
また、```return 0;```を最後に打つことで、「このプログラムは正常に終了しました」というシグナルを出します。  
ということで雑ですが、解説は終了です!  
## 3.練習問題を解いてみよう
[練習問題](https://github.com/kg-suken/WelcomeKit/tree/main/cpp/5-PracticeProblem#12helloworld%E3%81%AE%E5%87%BA%E5%8A%9B%E9%96%A2%E9%80%A3)に飛んで、解いてみてください。
