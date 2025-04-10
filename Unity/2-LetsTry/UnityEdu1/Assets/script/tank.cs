using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class tank : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        transform.position = new Vector2(Random.Range(-17f,18f),7f);
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(0f,0f,0.3f);
        if(this.gameObject.tag == "tank1"){
        transform.Translate(Vector2.up * -0.02f,Space.World);
        }
        if(this.gameObject.tag == "tank2"){
        transform.Translate(Vector2.up * -0.05f,Space.World);
        }
        if(transform.position.y < -7f){
            Destroy(this.gameObject);
        }
    }
    void OnTriggerEnter2D(Collider2D col){
        if(col.gameObject.tag == "Player"){
            Destroy(this.gameObject);
        }
    }
}
