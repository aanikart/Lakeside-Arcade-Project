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
    public static bool isplayerdead;

    // Start is called before the first frame update
    void Start()
    {
        isplayerdead = false;

    }

    // Update is called once per frame
    void Update()
    {
        if (fightscript.health <= 0)
        {
            isplayerdead = true;
            gameOver.SetActive(true);
            //Debug.Log("gameover");

            scoretext.text = "YOU HAVE " + (fightscript.score / 100).ToString() + " TICKETS";
            // add tickets to overall number of tickets
            TicketingSystem.addTickets((fightscript.score / 100));
        }

        if (greenfightscript.health <= 0)
        {
            isplayerdead = true;
            gameOver.SetActive(true);
            //Debug.Log("gameover");

            scoretext.text = "YOU HAVE " + (fightscript.score / 100).ToString() + " TICKETS";
            // add tickets to overall number of tickets
            TicketingSystem.addTickets(fightscript.score / 100);
        }
    }
}

