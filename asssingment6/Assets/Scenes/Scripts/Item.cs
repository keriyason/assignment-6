using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class Item
{
    public string itemname;
    public int count;

    public Item(string itemName, int itemCount)
    {
        itemname = itemName;
        count = itemCount;
    }
}
