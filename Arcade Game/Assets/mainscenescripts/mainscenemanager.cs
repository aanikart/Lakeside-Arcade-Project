using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class mainscenemanager : MonoBehaviour

{
    public Text ticketsText;
    public void shooting()
    {
        SceneManager.LoadScene("alienhome");

    }

    public void fighting()
    {
        SceneManager.LoadScene("teiseat-fightinggame");
    }

    public void pacman()
    {
        SceneManager.LoadScene("pacmangame-home");
    }

    public void setNumTickets()
    {
        int tickets = TicketingSystem.numTickets;
        ticketsText.text = "YOU HAVE:  " + tickets.ToString() + "  TICKETS";
    }
    
}

