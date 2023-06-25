using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InventoryManagerScript : MonoBehaviour
{
    public static InventoryManagerScript instance;
    public delegate void OnItemChanged();
    public OnItemChanged onItemChangedCallback;

    public int space = 20;

    private void Awake()
    {

        if (instance != null)
        {
            Debug.LogWarning("More than one instance of Inventory found!");
            return;
        }
        instance = this;
    }

    public List<Item> items = new List<Item>();

    public void Add (Item item)
    {
        if (!item.isDefaultItem)
        {
            items.Add(item);
        }
    }


    public void Remove(Item item)
    {
        items.Remove(item);
    }
}

