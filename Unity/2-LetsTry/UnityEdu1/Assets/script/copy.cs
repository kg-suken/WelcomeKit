using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class copy : MonoBehaviour
{
    public float birdtimer;
    public float tank1timer;
    public float tank2timer;
    public GameObject bird;
    public GameObject tank1;
    public GameObject tank2;
    // Start is called before the first frame update
    void Start()
    {
        birdtimer = 0f;
        tank1timer = 0f;
        tank2timer = 0f;
    }

    // Update is called once per frame
    void Update()
    {
        birdtimer += Time.deltaTime;
        tank1timer += Time.deltaTime;
        tank2timer += Time.deltaTime;
        if(birdtimer > 1f){
            Instantiate(bird);
            birdtimer = 0f;
        }
        if(tank2timer > 12f){
            Instantiate(tank2);
            tank2timer = 0f;
        }
        if(tank1timer > 5f){
            Instantiate(tank1);
            tank1timer = 0f;
        }
    }
}
