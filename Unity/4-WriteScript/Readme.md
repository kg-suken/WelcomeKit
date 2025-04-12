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
その後の「void Update」では、
