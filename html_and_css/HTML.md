# HTMLの基本

## HTMLの基本の形

HTMLを書くときは、まずこのような「基本の形」を使います：

```html
<!DOCTYPE html>
<html>
  <head>
    <title>はじめてのページ()</title>
  </head>
  <body>
    <!-- これはコメントです。ブラウザでは表示されません -->
    <!-- ここに表示される内容を書きます -->
  </body>
</html>
```
## タグの書き方
要素を指定するために「タグ」を用います。
```
<タグの名前></タグの名前>
```
タグの名前は表示させたいものに合せて使い分けます
`</タグの名前>`で区切りをつけるのを忘れないように

## 見出し（タイトル）

見出しは `<h1>` ～ `<h3>`タグを使って書きます：
```
<h1>一番大きな見出し</h1>
<h2>少し小さい見出し</h2>
<h3>さらに小さい見出し</h3>
```
こんな感じ：
# 一番大きな見出し
## 少し小さい見出し
### さらに小さい見出し

## 文章を書く
文章を書く

文章は `<p>`タグで書きます：
```
<p>こんにちは！これは文章です。</p>
```
## リスト
`<li>`タグでリストの項目、さらに`<ul>`タグで囲む。
```
<ul>
    <li>バナナ</li>
    <li>リンゴ</li>
    <li>パイナップル</li>
</ul>
```
こんな感じ: 
- バナナ
- リンゴ
- パイナップル

## 画像を表示する
`<img>`タグを使います。`</img>`は必要ありません。
```
<img src="neko.jpg">
```
`src=`の中にファイル名を「ダブルクォート」`"`で囲みます
```
"画像のファイル名"
```
こんな感じ  
  

![neko](neko.jpg)

他にもいろいろなタグがありますが、とりあえずこれだけ覚えておけばオーケーです。
