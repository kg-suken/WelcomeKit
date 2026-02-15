#include <iostream>

using namespace std;

int main(){
    int n , i = 0;
    cin >> n; //最初2行で変数の宣言と入力
    while(true){ // 無限ループ
        if(i == n){
            break; //whileのループを抜ける
        }else{
            i++;
            if(i % 2 == 0){
                continue; // 偶数だったら次のループへ
            }else{
                cout << i << endl; // 奇数だったら数字を出す
            }
        }
    }
    return 0;
}