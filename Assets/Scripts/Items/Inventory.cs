using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inventory : MonoBehaviour
{
    public List<ItemSlot> slots;
    public int scraps;
    private void Start()
    {
        // TODO copy slot types and base items
        // init slots
        for (int i = 0; i < slots.Count; i++)
        {
            InventoryDisplayer.Instance.slotDisplayers[i].Link(slots[i]);
        }
    }
}
