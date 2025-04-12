# 3Dにチャレンジ!
さっきは2Dだったけど、今度は3Dに挑戦してみよう!  
最終的にはこうするのが目標です。  
https://github.com/user-attachments/assets/c48d9609-8f92-4515-8314-95e74bd1dd70  
## 1.プロジェクトを準備しよう
以下のリンクから「UnityEdu2.zip」をダウンロードして開いてください。  
https://github.com/kg-suken/WelcomeKit/raw/refs/heads/main/Unity/3-challenge3D/UnityEdu2.zip  
開き方は先ほどの内容を参考に　[2.2Dでやってみよう](https://github.com/kg-suken/WelcomeKit/tree/main/Unity/2-LetsTry)  
開き終わったら、Scenesフォルダの中にあるSampleSceneというシーンを開いてください。  
開き終わったら、下の画面になってると思います。  
![スクリーンショット 2025-04-12 174130](https://github.com/user-attachments/assets/eebd7604-ef05-447d-9bb7-508c55b95f68)
## 2.地面の調節 
すでに用意してある「player」では、プレイヤーが動いたり、ジャンプできるようにしています。  
しかし、上の画像を見てもらうとわかるとおり、地面が小さすぎてこれでは満足にそれを体験できません。  
なので、大きさを調節しましょう!  
Hierarchyタブから、「zimenn」を選択し、Inspectorタブの「Transform」の欄を見てください。
![スクリーンショット 2025-04-12 174847](https://github.com/user-attachments/assets/5a1ba3d3-20f5-4ec2-ad0e-8200e5aa76c2)
ここをいじることで、地面の大きさや角度、大きさを調節できます。  
今回は大きさを変えたいので、「Scale」を大きくしましょう!  
とにかくいじってみることが大切です。ある程度大きく出来たら大丈夫です。  
## 3.プログラムを動かす準備
さて、地面を大きくしていざ動かす...っていっても、この状態ではまだ動かすことができません。(一応この状態でも、wasdで動かすことはできます)  
とはいえ、設定はたった1つだけなので安心してください!  
![スクリーンショット 2025-04-12 175704](https://github.com/user-attachments/assets/8a2c5b26-18f5-45a9-9ea7-3cedb3e01b1d)
枠で囲んだ部分を見てください。ここでは「Tag」を設定することができます。  
このタグを設定することで、オブジェクト同紙に区別をつけたり、当たり判定の区別ができます。  
今回はあらかじめ用意していますので、「zimenn」というタグを設定してください。  
これでジャンプができると思います。  
これでPart3はおしまいです。お疲れさまでした!
