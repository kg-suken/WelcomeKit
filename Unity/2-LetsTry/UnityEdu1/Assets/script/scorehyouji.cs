using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class scorehyouji : MonoBehaviour
{
    public Text scoretext;
    // Start is called before the first frame update
    void Start()
    {
        int score = PlayerPrefs.GetInt("Score", 0); // デフォルト値は0
        scoretext.text = "今回のスコア:" + score;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
