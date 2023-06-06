using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class StoreTicketManager : MonoBehaviour

{
    public Text ticketsText;
    void Start()
    {
        displayTickets();
    }

    public void displayTickets()
    {
        ticketsText.text = TicketingSystem.numTickets.ToString();
    }
}
