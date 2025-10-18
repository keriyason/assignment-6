using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InventoryManager : MonoBehaviour
{
    public GameObject slotprefab; // Refers to Slot Prefab
    public List<InventorySlot> inventorySlots = new List<InventorySlot>(6);
}
