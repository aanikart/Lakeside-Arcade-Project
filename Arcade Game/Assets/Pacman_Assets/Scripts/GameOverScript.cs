using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameOverScript : MonoBehaviour
{
    public Text scoreText;
    
    public void setUp(int score)
    {
        gameObject.SetActive(true);
        scoreText.text = "SCORE: " + score.ToString() + " POINTS";
    }

    public void restartButton()
    {
        SceneManager.LoadScene("aanika-pacmangame");
    }

    public void exitButton()
    {
        SceneManager.LoadScene("pacmangame-home");
    }
}
