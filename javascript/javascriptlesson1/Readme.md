# Javascript講座1
## javascriptとは
簡単に言うとブラウザ上で動く
プログラミング言語です。
## javascriptはどこに使われているの？
javascriptはwebサイトにアニメーションをつけたり
webアプリのフロントエンド（画面）　バックエンド（仕組みロジック）に使われています。
要するにJavascriptは初心者でも玄人でもおすすめな言語です。
## javascriptで作られたもの
Netflix ![netflix](https://github.com/user-attachments/assets/658b2f0c-840f-4c9f-9e18-8a8297e7a56b)
vscode ![vscode](https://github.com/user-attachments/assets/4d476693-ac0d-4a77-9897-2d416311e9e2)
## javascriptの最初の一歩
じゃあjavascriptのコードを書いてみよう。＜br>
vscode（IDE）をインストールする<br>
https://code.visualstudio.com/<br>
上のURLからvscodeをダウンロードしてください。<br>
また日本語かしたい場合はvscodeのサイドバーの上から五番目の拡張機能からJapanese Language Pack for Visual Studio Codeをダウンロードしてください。<br>
まずワークフォルダーを作成してください。名前はjavascript-projectなどがいいでしょう<br>
その中にこのチュートリアル用のフォルダーをを作ってください。<br>
その中にまずindex.htmlとapp.jsを作成してください。<br>
ファイル構成は以下のようになります。<br>
javascript-project/このチュートリアル用のフォルダー<br>
             　　　 ├── index.html<br>
　　　　　　　　　　　  ├── app.js<br>
index.htmlの中身はこのjavascriptフォルダーのルートにおいておくのでコピーアンドペーストしてください。<br>
そしてapp.jsの中に以下のようなコードを追加してください。  
console.log("helloworld");<br>
またブラウザ（多くの場合はChrome）を開いてindex.htmlをドラックアンドドロップしてください。<br>
そしたらブラウザ開発者ツールを開いてconsoleタブを参照してください。<br>
ブラウザ開発者ツールはwindowsの場合ctrl+alt+i Macの場合cmd+option+iで開けます。  
![スクリーンショット 2025-04-12 14 05 57](https://github.com/user-attachments/assets/c82ccb2d-21bc-48f0-a50f-6518ffb7d9bf)  
編集の様子<br>
すると以下の写真のようになるのではないでしょうか？<br>
![スクリーンショット 2025-04-12 14 09 21](https://github.com/user-attachments/assets/f45bd3cf-d356-40cd-8a7f-21ccf5e7e468)
console.log()とはログに表示するメソッドです。  
メソッドとは簡単に説明すると何かを受け取った時に何らかの値を返すものです。  
console.log()で言うと()の中に文字列のhelloworldという値を入れてログにhelloworldという文字列を表示するという結果を返しているのです。  
もしここまででうまく動作しなかった場合は以下のようなことを確認してください。  
console.logの綴りは合っているか？  
helloworldをシングルクオーテーション('')またはダブルクォーテーション("")で囲っているか？  
またもしうまくいかなかった場合は  
赤色の文字が出るのではないでしょうか？  
これはエラーといいどこが間違えているのかを具体的に教えてくれるヒントのようなものです。  
![スクリーンショット 2025-04-12 14 18 29](https://github.com/user-attachments/assets/49fa4eaf-8b77-4427-a59b-193cc55ea485)
エラーの写真  
このエラーメッセージを読んだり、調べたり、AIに聞いたりして  
問題解決を行なったりします。


