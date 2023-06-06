using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class TicketingSystem 
{
    public static int numTickets = 0;
    public static int getTickets()
    {
        return numTickets;
    }
    public static void addTickets(int newTickets)
    {
        numTickets += newTickets;
    }


}
