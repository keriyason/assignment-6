using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New Item", menuName = "ScriptableObjects/Item")]
[System.Serializable]
public class Item : ScriptableObject
{
    public string itemname;
    public int count;
    public Sprite icon;

    public Item(string itemName, int itemCount)
    {
        this.itemname = itemName;
        this.count = itemCount;
    }
}
