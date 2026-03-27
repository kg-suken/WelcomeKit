# for文

この章では繰り返し処理を行うのに必要なfor文とwhile文を学びます。

まずはfor文からです。基本的な構文は次の通りです。
```python
for i in range(繰り返す回数):
  (処理)
```
変数`i`には何回目のループかを表すint型の整数が入ります。ただし、Pythonは0から数えるので注意してください。具体的な例は実行結果を参照してください。

例
```python
for i in range(10):
  if i % 2 == 0:
    print(str(i) + " is even!")
  else:
    print(str(i) + " is odd!")
```
ちなみに、str(value)で、valueをstring型と解釈したものになります。

実行結果
```python
0 is even!
1 is odd!
2 is even!
3 is odd!
4 is even!
5 is odd!
6 is even!
7 is odd!
8 is even!
9 is odd!
```

次のように書くと数え始めの数と数え終わりの数と公差(一つのループでiがいくつ増えるか)を決めることができます。公差は何も入れないと1になります。数え終わりの数自体は含まれないことに注意してください。
```python
for i in range(値の下限, 値の上限(に1を足した数), 公差(デフォルトは1)):
  (処理)
```

例
```python
for i in range(-2, 8, 3):
  if i % 2 == 0:
    print(str(i) + " is even!")
  else:
    print(str(i) + " is odd!")
```

実行結果
```python
-2 is even!
1 is odd!
4 is even!
7 is odd!
```

# while文
while文は条件式がTrueの間処理を繰り返す構文です。
```python
while (条件式):
  (処理)
```

例
```
x = ""
while x != "Yes":
  x = input("Do you love me?")
print("Thank you! But I don't like you so much, sorry.")
```
RPGとかでよくある承諾するまで次に進めないみたいな処理も実装できます。

次の二つはほぼ同じ処理です。
```python
for i in range(10):
  print(i)
```
```python
i = 0
while i < 10:
  print(i)
  i += 1
```

条件式がずっとTrueのままだと、**無限ループ**となります。
```python
while True:
  print("Suken")
```

実行結果
```python
Suken
Suken
Suken
....
```
(コードを止めない限り無限につづきます)

コードを途中で止めるにはCTRLキーとCキーを同時に押します。

## 演習課題
