using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BuyItem : MonoBehaviour
{
    public Item Item;
    public static InventoryManager Instance;
    public List<Item> Items = new List<Item>();
    public Transform ItemContent;
    public GameObject InventoryItem;
    //just for test delete later
    public int tickets = 3000;
    void Pickup()
    {
        InventoryManager.Instance.Add(Item);
        Destroy(gameObject);
        
    }
    private void OnMouseDown()
    {
        //remember to change
        if (tickets /*TicketingSystem.numTickets*/ >= Item.value)
        {
            Pickup();
            InventoryManager.Instance.ListItems();
            /*TicketingSystem.numTickets*/ tickets -= Item.value;
            
        }  
    }
}
