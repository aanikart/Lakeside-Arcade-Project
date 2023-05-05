using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameOverScript : MonoBehaviour
{
    public Text scoreText;
    public Text ticketsText;
    
    public void setUp(int score, int tickets)
    {
        gameObject.SetActive(true);
        scoreText.text = "SCORE: " + score.ToString() + " POINTS";
        ticketsText.text = "YOU EARNED:  " + tickets.ToString() + "  TICKETS";
    }

    public void restartButton()
    {
        SceneManager.LoadScene("aanika-pacmangame");
        gameObject.SetActive(false);
    }

    public void exitButton()
    {
        SceneManager.LoadScene("pacmangame-home");
    }
}
