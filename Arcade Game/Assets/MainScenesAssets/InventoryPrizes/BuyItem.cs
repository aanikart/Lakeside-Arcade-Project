using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BuyItem : MonoBehaviour
{
    public Item Item;
    public static InventoryManager Instance;
    public List<Item> Items = new List<Item>();
    public Transform ItemContent;
    public GameObject InventoryItem;
    public Text ticketText;
    public Image ticketImage;
    void Pickup()
    {
        InventoryManager.Instance.Add(Item);
        Destroy(gameObject);
        
    }
    private void OnMouseDown()
    {
        
        if (TicketingSystem.numTickets >= Item.value)
        {
            Pickup();
            InventoryManager.Instance.ListItems();
            TicketingSystem.numTickets -= Item.value;
            
        }  
            TicketingSystem.numTickets -= Item.value;
            Destroy(ticketText);
            Destroy(ticketImage);
        }
        
    }
}
