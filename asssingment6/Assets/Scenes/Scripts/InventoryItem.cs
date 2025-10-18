using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class InventoryItem : MonoBehaviour
{
    public ItemData itemData;
    public int stackSize;

    public InventoryItem(ItemData item)
    {
        itemData = item;
        AddToStack();
    }

    public void AddToStack()
    {
        stackSize++;
    }    
}
