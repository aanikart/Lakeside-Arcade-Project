using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class gameover : MonoBehaviour
{

    public Text pointstext;


    public void Setup(int score)
    {
        gameObject.SetActive(true);
        pointstext.text = score.ToString() + " POINTS";
    }

    public void restartbutton()
    {
        SceneManager.LoadScene("angelique-alienshootinggame");
    }

    public void exitbutton()
    {
        SceneManager.LoadScene("alienhome");
    }
}
