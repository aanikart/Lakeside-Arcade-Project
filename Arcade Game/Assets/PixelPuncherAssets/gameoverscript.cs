using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class gameoverscript : MonoBehaviour
{
    public fightscript fightscript;
    public greenfightscript greenfightscript;
    public GameObject gameOver;
    public Text scoretext;
    public Text ticketstext;

    public void setUp(int score)
    {
        gameOver.SetActive(true);
        scoretext.text = "SCORE: " + score.ToString() + " POINTS";
        ticketstext.text = "YOU EARNED:  " + (score/100).ToString() + "  TICKETS";
        TicketingSystem.addTickets(score / 100);
    }

    public void restartbutton()
    {
        SceneManager.LoadScene("teiseat-fightinggame");
    }

    public void exitbutton()
    {
        SceneManager.LoadScene("Homescene");
    }
}
