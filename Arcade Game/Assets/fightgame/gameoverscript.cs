using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class gameoverscript : MonoBehaviour
{
    public fightscript fightscript;
    public greenfightscript greenfightscript;
    public GameObject gameOver;
    public Text scoretext;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (fightscript.health <= 0)
        {
            gameOver.SetActive(true);
            scoretext.text = "You have " + fightscript.score.ToString() + " tickets";
        }

        if (greenfightscript.health <= 0)
        {
            gameOver.SetActive(true);
            scoretext.text = "You have " + greenfightscript.score.ToString() + " tickets";
        }
    }
}
