#include <iostream>

using namespace std;

//このプログラムは実行しようとするとコンパイラによって事前にエラーが出るので、実際には何も出力されません
int main(){
    string test = "Hello,World!"; //string型の変数を定義し、その中に「Hello,World!」を入れた
    string a = "a" ,  b = "b"; //複数の変数を定義できる
    cout << test << endl; //testの中身である、「Hello,World!」を出力する
    test = "bbbb"; //testに「bbbb」を代入
    cout << test << endl; //中身が変わり、「bbbb」が出力される
    int x = "cccc"; //整数型の変数xに、文字列「cccc」を入れているので、型不一致でエラーが発生する
}