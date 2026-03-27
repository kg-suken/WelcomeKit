# bool ～電卓を作ろう2～

この章ではデータ型の一種であるbool型と、プログラミングで非常に重要な構文であるif構文を扱います。

Pythonのbool型には二種類あり、それぞれ**True**、**False**です。一文字目が共に大文字なので注意してください。  
英語の意味通り、Trueは正しい(真)、Falseは正しくない(偽)という意味です。

bool型を返すメジャーな演算子(比較演算子)をいくつか紹介します。

| 記号 | 戻り値 |
----|---- 
| **==** | **二つの値が等しいか** |
| **<** | **左の要素が右の要素より真に小さいか** | ☆
| **>** | **左の要素が右の要素より真に大きいか** | ☆
| **<=** | **左の要素が右の要素以下か** | ☆
| **>=** | **左の要素が右の要素以上か** | ☆
| **!=** | **二つの要素が異なるか** |

☆をつけたものは二つの要素が数値型(int, floatなど)の場合のみ使えます。==はイコールが二つなので注意してください。

例
```python
print(2 == 2)
print(3 == 5)
print("A" == "A")
print(True == False)

print("###############") # 区切って見やすくする用

print(3 < 5)
print(2 < -1)

print("###############") # 区切って見やすくする用

print(11 > 3)
print(2 > 100)

print("###############") # 区切って見やすくする用

print(2*3 >= 5/2)
print(2 * 4 >= 8) # 両者の値が等しい
print(3 >= 2**9)

print("###############") # 区切って見やすくする用

print(2//6 <= 0) # 両者の値が等しい
print(2 ** (1/2) <= 3) # 左辺はルート2
print(5 <= -3)

print("###############") # 区切って見やすくする用

print("A" != "B")
print(True != False)
```

実行結果
```python
True
False
True
False
###############
True
False
###############
True
False
###############
True
True
False
###############
True
True
False
###############
True
True
```

# not, and, or

bool型のデータに対して使える演算処理として次のようなものがあります。これまでの演算子とは少し違う書き方をするので注意してください。これもbool型を返します。

A,Bはともにbool型のデータが代入されている変数です。

| 記号 | 戻り値 | 書き方 |
----|----|---- 
| **not** | **Aの否定(AがTrueならFalse、AがFalseならTrue)** | not A |
| **and** | **A, Bが共にTrueならTrue、そうでなければFalse** | A and B |
| **or** | **A, Bのうちどちらか少なくとも一方がTrueならTrue、そうでなければFalse** | A or B |

例

```python
print(not True)
print(not False)

print("###############") # 区切って見やすくする用

print(True and True)
print(True and False)
print(False and True)
print(False and False)

print("###############") # 区切って見やすくする用

print(True or True)
print(True or False)
print(False or True)
print(False or False)
```

実行結果
```python
False
True
###############
True
False
False
False
###############
True
True
True
False
```

# if文

さて、いよいよif文です。これは渡されたboolの値によって実行する処理を変えることができます。

```python
if (bool型を返す条件式):
  (Trueの時の処理)
```

上記のコードは条件式がTrueを返す場合はその下の処理を実行し、Falseの場合は何もしないという感じです。

例1
```python
if 4 % 2 == 0:
  print("4 is even!)
```

実行結果
```python
4 is even!
```

例2
```python
if 5 % 2 == 0:
  print("5 is even!)
```

実行結果
```python

```
(なにも実行されない)

