using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inventory : MonoBehaviour
{
  public static Inventory instance;
  public List<Item> items = new List<Item>();

    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }
       
    }
    
    public void AddItem(Item itemToAdd)
    {
        bool itemExists = false;

        foreach (Item item in items)
        {
            if (item.itemname == itemToAdd.itemname)
            {
                item.count += itemToAdd.count;
                itemExists = true;
                break;
            }
        }
        if (!itemExists)
        {
            items.Add(itemToAdd);
        }
        Debug.Log(itemToAdd.count + " " + itemToAdd.itemname + " addded to Inventory!"); // Prints Item Count + Name
      
    }
    public void RemoveItem(Item itemToRemove)
    {
        foreach (var item in items)
        {
            if (item.itemname == itemToRemove.itemname)
            {
                item.count -= itemToRemove.count;
                if(item.count <= 0 )
                {
                    items.Remove(itemToRemove);
                }
                break;
            }
        }
        Debug.Log(itemToRemove.count + " " + itemToRemove.itemname + "removed from inventory!");
    }
}
