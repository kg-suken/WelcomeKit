#include <iostream>

using namespace std;

int main(){
    int point;
    cin >> point;
    if(point == 80 || point > 80){ //点数が80店ちょうど、または80点より大きいなら
        cout << "合格\n";
    }else{ //そうでないなら
        cout << "不合格\n";
    }
}