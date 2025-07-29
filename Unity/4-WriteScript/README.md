# スクリプトを書いてみよう!
タイトルは「いかにもプログラミングをしそう」って感じですが、申し訳ございません。  
プログラミング要素はほぼありません。
## 1.早速スクリプトを見てみよう
Projectタブにある、「Player」と書かれたスクリプトファイルを開いてみてください。  
![スクリーンショット 2025-04-12 181834](https://github.com/user-attachments/assets/6fbad123-3090-40d3-8031-58578f99d5b7)
ダブルクリックで開くことができます。  
開くことができたら、こんな感じの画面が出てくるはずです。  
![スクリーンショット 2025-04-12 182001](https://github.com/user-attachments/assets/51da70fe-e6d7-4f97-8b17-031f6a32d87c)
ここで書かれているのが、プレイヤーを動かすスクリプトです。
## 2.簡単にスクリプトについて解説
このスクリプトについて簡単に解説します。
```cs
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player : MonoBehaviour
{
    public Transform transform;
    private Rigidbody rigid;
    public bool zimenn;
    // Start is called before the first frame update
    void Start()
    {
        transform.position = new Vector3(0,4f,0);
        rigid = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKey(KeyCode.D)){
            transform.Translate(0.03f,0,0);
        }
        if(Input.GetKey(KeyCode.A)){
            transform.Translate(-0.03f,0,0);
        }
        if(Input.GetKey(KeyCode.W)){
            transform.Translate(0f,0,0.03f);
        }
        if(Input.GetKey(KeyCode.S)){
            transform.Translate(-0,0,-0.03f);
        }
        if(Input.GetKey(KeyCode.Space)){
            if(zimenn){
            rigid.AddForce(transform.up * 500);
            zimenn = false;
            }
        }
    }
    void OnCollisionEnter(Collision col){
        if(col.gameObject.tag == "zimenn"){
            zimenn = true;
        }
    }
}
```
このスクリプトは、C#というプログラミング言語で書かれています。  
最初の3行では、デフォルトで入っています。  
これはC#をUnityで使うために必要な行です。  
そこから少し飛んで、publicとかprivateが3行並んでいるところは、重力をつかさどる「Rigidbody」や、移動にかかわる「transform」をプログラムで使えるようにしています。
その後にある「void Start」では、ゲームが始まる際の動作を決めています。  
rigidbodyとスクリプトを連携したり、初期位置を決めたりしています。  
その後の「void Update」では、ゲームが実行している間ずっと動かす内容を決めています。  
例えば「if(Input.GetKey(KeyCode.Space))」では、スペースキーが押されたときに実行する内容が載っています。  
今回のプログラムでは、WASDでキャラクターが動き、スペースキーでジャンプするようになっています。  
transform.TranslateやAddForceの中身をいじると、移動速度が変わっていることを実感できるはずです。  
自由にいじって試してみてください!  
## 2.最後に
正直作成者の私も、こんな感じのものを作ったのは初めてなので悩みどころがたくさんでした。  
説明が不十分だったり、わかりづらかったりする個所もあります。  
結局のところ、最低限の知識だけ身に着けChatGPTなどに任せたほうがいいと思います。  
3Dオブジェクトや画像の準備などは必要なものの、それさえすればプログラムを書くのはGPTの仕事です。  
ただ、GPTに聞いてもわからないことがあればぜひ部員に聞いてみてください!  
最後まで読んでいただき、ありがとうございました!
## 作成
### Pencil
