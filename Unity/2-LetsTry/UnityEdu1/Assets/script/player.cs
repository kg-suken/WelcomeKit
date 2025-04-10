using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player : MonoBehaviour
{
    private Rigidbody2D rigid;
    public float speed;
    private SpriteRenderer sprite;
    public int nenryo;
    public int score;
    public float scoretimer;
    public float nenryotimer;
    // Start is called before the first frame update
    void Start()
    {
        transform.position = new Vector2(0,0);
        rigid = GetComponent<Rigidbody2D>();
        sprite = GetComponent<SpriteRenderer>();
        nenryo = 100;
        score = 0;
        Sound.LoadSe("tank","tank");
        Sound.LoadSe("bird","bird");
        Sound.LoadSe("tank2","tank2");
    }
    // Update is called once per frame
    void Update()
    {
        float x = Input.GetAxisRaw ("Horizontal");
        rigid.AddForce(transform.right * speed * x);
        float y = Input.GetAxisRaw ("Vertical");
        rigid.AddForce(transform.up * speed * y);
        float vx = rigid.velocity.x;
        float vy = rigid.velocity.y;
        if(Mathf.Abs(vx) > 3){
            if(vx > 3){
            rigid.velocity = new Vector2(3 , vy);
            }
            if(vx < -3){
            rigid.velocity = new Vector2(-3 , vy);
            }
        }
        if(Mathf.Abs(vy) > 3){
            if(vy > 3){
            rigid.velocity = new Vector2(vx , 3);
            }
            if(vy < -3){
            rigid.velocity = new Vector2(vx , -3);
            }
        }
        if(vx > 0.1f){
        sprite.flipX = true;
        }
        if(vx < -0.1f){
        sprite.flipX = false;
        }
        nenryotimer += Time.deltaTime;
        scoretimer += Time.deltaTime;
        if(nenryotimer > 1f){
            nenryo -= 1;
            nenryotimer = 0f;
        }
        if(nenryo > 100){
            nenryo = 100;
        }
        if(scoretimer > 1.5f){
            score += 1;
            scoretimer = 0f;
        }
    }
    void OnTriggerEnter2D(Collider2D col){
        if(col.gameObject.tag == "tank1"){
            nenryo += Random.Range(3,7);
            Sound.PlaySe("tank");
        }
        if(col.gameObject.tag == "tank2"){
            nenryo += Random.Range(10,14);
            Sound.PlaySe("tank2");
        }
        if(col.gameObject.tag == "bird"){
            nenryo -= Random.Range(4,8);
            Sound.PlaySe("bird");

        }
    }
}
