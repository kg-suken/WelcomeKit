# Unixコマンドの基本

## `ls`
世界でもっとも使われているコマンドの一つ。ディレクトリ内のファイルやディレクトリを表示する。通常の場合、ディレクトリ名は青色で表示されファイルは白色で表示される。
![](../src/ls.png)
## `cd`
階層移動(ディレクトリへ移動)するために用いる。`cd .`でホームディレクトリに戻れる。また`cd ..`は一つ前のディレクトリに戻る。
## `pwd`
現在が自分いる場所のフルパスを表示する。現在ほとんどのUnixシステムではプロンプトに自分がいるパスが表示されるため、確認する目的ではほとんど用いられない。
```
$ ls
Desktop Picures Downloads
$ cd Pictures
$ pwd
/home/user/Pictures
```

## `mv`
ファイルをディレクトリ間で移動、またはファイル/ディレクトリ名を変更するのに用いる。
```
$ ls
hoge.png
$ mv hoge.png ~/Pictures/hoge.png
$ ls
$ cd ~/Pictures/ && ls
hoge.png
```

```
$ mv hoge.png moge.png
$ ls
moge.png

```

## `cp`
ファイルをディレクトリ間でコピーするのに用いる。`mv`と使い方は変らない。
フォルダをコピーする場合は`-r`オプションが必要になる
## `cat`
ファイルの中身を表示。エディタで開けるものなら拡張子はなんでも良い。
```
$ ls
help.txt
$ cat help.txt
Wanna help?
```
## `grep`
簡易的なテキストの摘出。オプションなしで使用すると任意のテキストをハイライトして全文を表示してくれる。
```
$ cat help.txt
aeiojeghelpauoreakf
$ cat help.txt | grep "help"
aeiojeg<help>auoreakf
```
※<>の中の文字がハイライトされて表示される。  
オプションが豊富で、正規表現なども使えるので、他のコマンドの出力結果から特定の値を含む場合~をするといった動作もできる。
(例)
```
$ mycommand
Working = True
Has_Error = False
Auto_modify = True
```
`Has_Error = True`を含む場合挨拶する:
```
$ my command | grep -q "Has_Error = True" && echo hello
hello
```
`-q`オプションは標準出力をせずに含む場合`exit0`(正常終了)→次のコマンドも実行される  
含まない場合：`exit1`(失敗)→次のコマンドは実行されない

## `fzf`
Unixコマンドではない外部の全文検索ツール。ログやリストをパイプで受け取り、TUIを操作して検索&選択できる(選択したものは標準出力される)   
例
```
$ ls -1 | fzf
```


debian系でのインストール
```
sudo apt install fzf

```
Arch系
```
sudo pacman -S fzf
```
