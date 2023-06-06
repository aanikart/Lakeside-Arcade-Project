using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class gameoverscript : MonoBehaviour
{
    public fightscript fightscript;
    public greenfightscript greenfightscript;

    public GameObject gameOver;
    public Text scoretext;
    public Text tickettext;
    public static bool isplayerdead;


    void Start()
    {
        isplayerdead = false;
        if (fightscript.health <= 0 || greenfightscript.health <= 0)
        {
            isplayerdead = true;
            gameOver.SetActive(true);
        }
    }

    public void setUp(int numTickets, int score)
    {
        gameOver.SetActive(true);
        //Debug.Log("gameover");
        scoretext.text = "SCORE: " + score.ToString();
        tickettext.text = "YOU HAVE " + numTickets.ToString() + " TICKETS";
        // add tickets to overall number of tickets
        TicketingSystem.addTickets((numTickets));
        print(TicketingSystem.numTickets);
    }

    public void restartButton()
    {
        SceneManager.LoadScene("teiseat-fightinggame");
        // turn off game over screen
        gameObject.SetActive(false);
    }

    public void exitButton()
    {
        SceneManager.LoadScene("puncherhome");
    }
}

