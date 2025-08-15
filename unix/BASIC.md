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
## mkdir
ディレクトリの作成
```
$ ls
Pictures
$ mkdir Desktop
$ ls
Desktop Pictures
```
## rm
ファイル、ディレクトリの削除
```
$ ls
help.txt hoge.txt
$ rm help.txt
$ ls
hoge.txt
```
ディレクトリを削除する場合は`-rf`オプションを用いる
```
$ ls
Desktop Pictures
$ rm -rf Pictures
$ ls
Desktop
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
前に実行したコマンドの実行結果を調べるには
```
$ echo $?
```
が使える。
これの表示が
`0`である場合は前回のコマンドが無事に実行された、それ以外はなんらかのエラーで失敗したことを意味する。

# root権限
ユーザーログイン時に`root`でログインしなかった場合、そのままだとコマンドは全て通常のユーザーの限られた権限で実行される。管理者権限で実行したい場合は実行したいコマンドの前に`sudo`をつける。(ユーザーがsudoグループになっていることが前提)
```
sudo loadkeys jp106
```
loadkeysはコンソールのキーボード配置を変更する。   
sudoが実行される際にはユーザーパスワードの入力が求められる。
ちなみにルートディレクトリ`/`に入り、
```
cd root
```
を行なおうとすると、`cd : permission denied: root`とエラーが吐かれる。権限がないと出ているので`sudo`を使用とすると
```
$ sudo cd root
sudo: cd: command not found
sudo: "cd" is a shell built-in command, it cannot be run directly.
sudo: the -s option may be used to run a privileged shell.
sudo: the -D option may be used to run a command in a specific directory.
```
とエラーがでる。これは`cd`というコマンドがシェルに依存しているため、そのままでは実行できないと出ている。よって、`-s`オプションを用いればシェルスクリプトを管理者で実行できる
```
$ sudo -s cd root

```
で入ることができる。ただ、`/root`は結局`/`にリダイレクトされるだけなので、特になにも変らない。
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
