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

```css
h1 {
    color:色の名前;
}
```
### 文字の大きさを変える

文字の大きさを変えたいときは `font-size` を使います。

```css
p {
    font-size: 24px;
}
```
px（ピクセル）という単位を使い、数字が大きいほど文字も大きくなります。
例：`font-size: 16px;`（ふつうの大きさ）、`font-size: 32px;`（大きめ）

### フォントを変更する
文字のスタイルを変えることができます。  
`font-family`を使います。
```css
p {
    font-family: "Arial";
}
```
"Arial" は代表的なフォントの1つです。PCにインストールされているフォントは(Windows11の場合)`設定>個人用設定>フォント`から使用可能なフォントを見つけられます。  
`"`（ダブルクォーテーション）でフォント名を囲むようにしましょう。  
例
```css
p {
    font-family:"BIZ UDPゴシック";
}
```
値を`BIZ UDP明朝`に変更してみてください。

