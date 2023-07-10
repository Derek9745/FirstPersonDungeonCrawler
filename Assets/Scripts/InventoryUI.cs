using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InventoryUI : MonoBehaviour
{
    InventoryManagerScript inventory;
    public Transform itemsParent;

    InventorySlot[] slots;
    
    private void Start()
    {
        inventory = InventoryManagerScript.instance;
        inventory.onItemChangedCallback += UpdateUI;

        slots = itemsParent.GetComponentsInChildren<InventorySlot>();
    }

    private void Update()
    {
        
    }

    void UpdateUI()
    {
        for(int i = 0; i< slots.Length; i++)
        {
            if (i < inventory.items.Count) {

                slots[i].AddItem(inventory.items[i]);
            }
            else
            {
                slots[i].ClearSlot();
            }
        }
    }
}
