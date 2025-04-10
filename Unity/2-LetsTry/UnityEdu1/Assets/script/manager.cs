using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class manager : MonoBehaviour
{
    public Text scoretext;
    public Text nenryotext;
    public player player;
    // Start is called before the first frame update
    void Start()
    {
        Sound.LoadSe("gameover","gameover");
        Sound.LoadBgm("bgm","bgm"); 
        Sound.PlayBgm("bgm");
    }

    // Update is called once per frame
    void Update()
    {
        scoretext.text = "スコア:" + player.score;
        nenryotext.text = "燃料:" + player.nenryo;
        if(player.nenryo < 0){
            Sound.PlaySe("gameover",0);
            Sound.StopBgm();            
            SceneManager.LoadScene("gameover");
            PlayerPrefs.SetInt("Score", player.score);
            PlayerPrefs.Save();
        }
    }
}
