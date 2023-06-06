using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.Linq;

public class InventoryManager : MonoBehaviour
{
    public static InventoryManager Instance;
    public List<Item> Items = new List<Item>();
    public List<Item> AllItems = new List<Item>();
    public Transform ItemContent;
    public GameObject InventoryItem;
    public int[] ids = new int[21];
    public int[] diffids = new int[21];
    public int i = 0;
    public Item Pencil;
    public Item Balloon;
    public Item Candy;
    public Item Trap;
    public Item Whistle;
    public Item Kazoo;
    public Item Ring;
    public Item Hand;
    public Item Duck;
    public Item Car;
    public Item Bear;
    public Item Rocket;
    public Item Minion;
    public Item Chicken;
    public Item Yoda;
    public Item Succulent;
    public Item Trophy;
    public Item Bracelet;
    public Item Football;
    public Item Pizza;
    public Item Lamp;
    public Item Switch;
    private void Awake()
    {
        Instance = this;
        //AddAll();
    }
    
    //public void AddAll()
    //{
    //    AllItems.Add(Pencil);
    //    AllItems.Add(Balloon);
    //    AllItems.Add(Candy);
    //    AllItems.Add(Trap);
    //    AllItems.Add(Whistle);
    //    AllItems.Add(Kazoo);
    //    AllItems.Add(Ring);
    //    AllItems.Add(Hand);
    //    AllItems.Add(Duck);
    //    AllItems.Add(Car);
    //    AllItems.Add(Bear);
    //    AllItems.Add(Rocket);
    //    AllItems.Add(Minion);
    //    AllItems.Add(Chicken);
    //    AllItems.Add(Yoda);
    //    AllItems.Add(Succulent);
    //    AllItems.Add(Trophy);
    //    AllItems.Add(Bracelet);
    //    AllItems.Add(Football);
    //    AllItems.Add(Pizza);
    //    AllItems.Add(Lamp);
    //    AllItems.Add(Switch);
    //}
    public void Add(Item item)
    {
        Items.Add(item);
    }
    public void ListItems()
    {
        foreach (Transform item in ItemContent)
        {
            Destroy(item.gameObject);
        }
        foreach (var item in Items)
        {
            GameObject obj = Instantiate(InventoryItem, ItemContent);
            var itemName = obj.transform.Find("ItemName").GetComponent<Text>();
            var itemIcon = obj.transform.Find("ItemIcon").GetComponent<Image>();
            itemName.text = item.itemName;
            itemIcon.sprite = item.icon;
            System.Array.Resize(ref ids, ids.Length + 1);
            ids[i] = item.id;
            i++;
            diffids = ids.Distinct().ToArray();
        }
    }


}
