using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;
public class InventorySlot : MonoBehaviour
{
    public Image icon;
    public Item myItem;

    public void ClearSlot()
    {
        icon.enabled = false;
    }    

    public void DisplayItem(Item myitem)
    {
        this.myItem = myitem;
        icon.sprite = myitem.icon;
    }
}
