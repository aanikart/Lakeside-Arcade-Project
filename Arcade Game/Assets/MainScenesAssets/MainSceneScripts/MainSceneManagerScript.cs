using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MainSceneManagerScript : MonoBehaviour

{
    public Text ticketsText;
    public void shooting()
    {
        SceneManager.LoadScene("alienhome");

    }

    public void fighting()
    {
        SceneManager.LoadScene("puncherhome");
    }

    public void pacman()
    {
        SceneManager.LoadScene("pacmangame-home");
    }

    public void setNumTickets(int numTickets)
    {
        ticketsText.text = numTickets.ToString() + "  TICKETS";
    }
    
}

