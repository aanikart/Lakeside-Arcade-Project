using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DataTranslate : MonoBehaviour
{
    
    //public Transform ItemContent;
    //public GameObject InventoryItem;
    //public List<Item> SavedItems = new List<Item>();
    //void Start()
    //{
    //    Load();
    //}
    //private void OnApplicationQuit()
    //{
    //    Save();
    //}
    //public void Save()
    //{
    //    SaveScript.Save();
    //}
    //public void Load()
    //{
    //    SaveData data = SaveScript.Load();
    //    if (data == null)
    //    {
    //        TicketingSystem.numTickets = 0;
    //        InventoryManager.Instance.diffids = new int[21];
    //    }
    //    else {
    //        TicketingSystem.numTickets = data.tickets;
    //        for (int i = 0; i < data.itemids.Length; i++)
    //        {
    //            foreach (var item in InventoryManager.Instance.AllItems)
    //            {
    //                if (item.id == data.itemids[i])
    //                {
    //                    SavedItems.Add(item);
    //                    Debug.Log(item.id);
    //                }
    //            }
                
    //        }
    //        InventoryManager.Instance.diffids = data.itemids;
    //    } 
              
    //    foreach (var item in SavedItems)
    //    {
    //        GameObject obj = Instantiate(InventoryItem, ItemContent);
    //        var itemName = obj.transform.Find("ItemName").GetComponent<Text>();
    //        var itemIcon = obj.transform.Find("ItemIcon").GetComponent<Image>();
    //        itemName.text = item.itemName;
    //        itemIcon.sprite = item.icon;
    //    }

        
    //}
    
}
