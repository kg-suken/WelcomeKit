# 練習問題の解説
## 1.「2.Hello,World!の出力」関連
1-1  
coutの使い方がわかっていれば問題ないでしょう。サンプルプログラムの「Hello,World!」の部分を、「Welcode to Suken!」に変えればいいです。  
```cpp
#include <iostream>

using namespace std;

int main(){
    cout << "Welcome to Suken!" << endl;
    return 0;
}
```
1-2  
endlを用いると、改行することができます。2行分coutを用意しましょう。  
```cpp
#include <iostream>

using namespace std;

int main(){
    cout << "Suken does not study math." << endl;
    cout << "Suken clubmembers are using Personal Computer." << endl;
    return 0;
}
```
ちなみに1行でまとめて出力することもできます。  
```cpp
#include <iostream>

using namespace std;

int main(){
    cout << "Suken does not study math." << endl << "Suken clubmembers are using Personal Computer." << endl;
    return 0;
}
```
## 2.「3.入力と演算」関連
2-1  
※この答え方は一例です。  
変数の型は、正しく使い分けできるようにしましょう。元のコードを崩さないなら、  
```cpp
int i = 55; //intは整数
double d = 3.1111; //doubleは小数
string s = "sss"; //string(正確にはstd::string)は文字列
bool b = true; //boolは真偽(trueかfalse)
```
ですね。intの行だけ正しく、ほかの部分は間違っています。  
2-2
最後に見せたサンプルプログラムとほとんど変わりません。+を*にしただけです。
```cpp
#include <iostream>
using namespace std;

int main(){
    int a , b;
    cin >> a >> b; //数字を2つ入力
    cout << a * b << endl; //2つの入力した数字を掛け算して出力
    return 0;
}
```
