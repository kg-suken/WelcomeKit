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
    cout << "Suken clubmember are using Personal Computer." << endl;
    return 0;
}
```
ちなみに1行でまとめて出力することもできます。  
```cpp
#include <iostream>

using namespace std;

int main(){
    cout << "Suken does not study math." << endl << "Suken clubmember are using Personal Computer." << endl;
    return 0;
}
```
現在、問題を作成中です。
