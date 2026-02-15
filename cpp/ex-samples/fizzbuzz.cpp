#include <iostream>

using namespace std;

int main(){
    for(int i = 1; i <= 100; i++){ // 1から100まで繰り返し
        if(i % 3 == 0 && i % 5 == 0){ //3でも5でも割れるなら
            cout << "FizzBuzz" << endl; 
        }else if(i % 3 == 0){ //3でのみ割れるなら
            cout << "Fizz" << endl;
        }else if(i % 5 == 0){ //5でのみ割れるなら
            cout << "Buzz" << endl;
        }else{ //3でも5でも割れないなら
            cout << i << endl;
        }
    }
    return 0;
}