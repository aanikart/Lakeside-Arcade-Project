using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class scorescript : MonoBehaviour
{
    public Text score;
    public static int scoreValue;

    public gameover gameover;

    // Start is called before the first frame update
    void Start()
    {
        score.GetComponent<Text>();
        scoreValue = 0;

    }

    public void GameOver()
    {
        gameover.Setup(scoreValue);
    }

    // Update is called once per frame

    void Update()
    {
        

        score.text = "Score: " + scoreValue;

        
    }

    public void addscore(int scoretoadd)
    {
        scoreValue += scoretoadd;
        Debug.Log(scoreValue);
    }

}
