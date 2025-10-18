using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InventoryManager : MonoBehaviour
{
    public GameObject slotprefab; // Refers to Slot Prefab
    public List<InventorySlot> inventorySlots = new List<InventorySlot>(6);

    //private void Start()
    //{
    //    DrawInventory
    //}



    public void UpdateSlots(List<Item> items)
    {
        int count = Mathf.Min(inventorySlots.Count, items.Count);

        for (int i = 0; i < count; i++)
        {
            print(inventorySlots[i]);
            print(items[i]);
            print(items.Count);

            inventorySlots[i].DisplayItem(items[i]);
        }
    }
   

    void CreateInventorySlot()
        {
            GameObject newSlot = Instantiate(slotprefab);
            newSlot.transform.SetParent(transform, false);

            InventorySlot newSlotComponent = newSlot.GetComponent<InventorySlot>();
            newSlotComponent.ClearSlot();

            inventorySlots.Add(newSlotComponent);

        }
    }

