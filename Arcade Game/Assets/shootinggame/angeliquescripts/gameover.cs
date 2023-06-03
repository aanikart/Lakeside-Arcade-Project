using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class gameover : MonoBehaviour
{

    public Text pointstext;
    public Text tickettext;


    public void Setup(int score, int ticket)
    {
        gameObject.SetActive(true);
        pointstext.text = score.ToString() + " POINTS";
        tickettext.text = ticket.ToString() + "  TICKETS";
        // add tickets earned to user's total number of tickets
        TicketingSystem.addTickets(ticket);
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
