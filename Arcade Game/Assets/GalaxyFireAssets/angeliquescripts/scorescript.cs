using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class scorescript : MonoBehaviour
{
    public Text score;
    public static int scoreValue;
    public static int ticketnumber;
    public Text tickets;

    public gameover gameover;

    
    void Start()
    {
        score.GetComponent<Text>();
        scoreValue = 0;

    }

    public void GameOver()
    {
        gameover.Setup(scoreValue,ticketnumber);
    }

    

    void Update()
    {
        score.text = "Score: " + scoreValue;
        ticketnumber = scoreValue / 20;
    }

    public void addscore(int scoretoadd)
    {
        scoreValue += scoretoadd;
    }

}
