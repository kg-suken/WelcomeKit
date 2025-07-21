# CSS
 HTMLで書かれた要素の見た目を制御します。`style.css`というファイルに以下の構文で記述します。
```css
タグ名 {
    いじりたい見た目(色や大きさ):その値;
}
```
例(`<h1>`タグの色を青にする)
```css
h1 {
    color:blue;
}
```
`:`と`;`をつけ忘れないように注意  
CSSをHTMLに反映させるには、以下のコードをHTMLファイルの`<head>`タグの中に追加してあげます。
```html
<head>
  <link rel="stylesheet" href="style.css">
</head>
```


なお、`index.html`と`style.css`は同じフォルダに入れてください。
## idとclass
CSSでいじりたい要素はタグ名で指定できますが、同じタグの中でも特定のタグを指定したい場合、タグにidかclassを指定してあげることができます。
### id
```html
<p id="helpme">たすけて</p>
```
`helpme`がidになります。
これをCSS側で
```css
#helpme {
    color:red;
}
```
と`#`をつけることで指定できます。
### class
```html
<p class="helpme">たすけて</p>
```
```css
.helpme{
    color:red;
}

```
`.`を前につけることで指定できます
## 見た目を変えてみよう
### 色を変える
`color`を使います。設定できる値は色コード(hex)、RGB、あるいは単に英語で色の名前を指定できます。
```
black   黒
white   白
red     赤
blue    青
green   緑
yellow  黄色
orange  オレンジ
purple  紫
pink    ピング
gray    灰色
brown   茶色
cyan    シアン
magenta マゼンタ
lime    ライム
silver  シルバー
などなど...
```
