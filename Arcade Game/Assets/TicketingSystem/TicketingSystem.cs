using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class TicketingSystem 
{
    public static int numTickets = 1000000000;
    public static int getTickets()
    {
        return numTickets;
    }
    public static void addTickets(int newTickets)
    {
        numTickets += newTickets;
    }


}
