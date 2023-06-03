using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TicketManagerScript : MonoBehaviour
{

    public MainSceneManagerScript mainscenemanager;

    private void Start()
    {
        displayTickets();
    }

    private void displayTickets()
    {
        mainscenemanager.setNumTickets(TicketingSystem.numTickets);
    }

}