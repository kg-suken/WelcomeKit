using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bird : MonoBehaviour
{
    public float x;
    // Start is called before the first frame update
    void Start()
    {
        x = Random.Range(1,3);
        if(x == 1){
            transform.position = new Vector2(-18,Random.Range(-7f,7f));
            transform.rotation = Quaternion.Euler(0, 180 ,0);
        }
        if(x == 2){
            transform.position = new Vector2(18,Random.Range(-7f,7f));
            transform.rotation = Quaternion.Euler(0, 0 ,0);
        }
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(-0.1f,0f,0f);
        if(x == 1){
            if(transform.position.x > 17f){
                Destroy(this.gameObject);
            }
        }
        if(x == 2){
            if(transform.position.x < -17f){
                Destroy(this.gameObject);
            }
        }
    }
    void OnTriggerEnter2D(Collider2D col){
        if(col.gameObject.tag == "Player"){
            Destroy(this.gameObject);
        }
}
}