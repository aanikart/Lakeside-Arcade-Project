using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuScript : MonoBehaviour
{
    public void playGame()
    {
        SceneManager.LoadScene("aanika-pacmangame");

    }

    public void infoscreen()
    {
        SceneManager.LoadScene("pacmangame-info");
    }

    public void exitToGameHome()
    {
        SceneManager.LoadScene("Homescene");
    }

    // backbutton in infoscreen
    public void backtoHome()
    {
        SceneManager.LoadScene("pacmangame-home");
    }
}
