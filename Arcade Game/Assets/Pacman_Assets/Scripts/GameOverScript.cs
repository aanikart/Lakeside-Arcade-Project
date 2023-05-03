using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameOverScript : MonoBehaviour
{
    public Text scoreText;
    
    public void setUp()
    {
        gameObject.SetActive(true);
        scoreText.text = GameManagerScript.score.ToString() + " POINTS";
    }

    public void restartButton()
    {
        SceneManager.LoadScene("aanika-pacmangame");
    }

    public void exitButton()
    {

    }
}
