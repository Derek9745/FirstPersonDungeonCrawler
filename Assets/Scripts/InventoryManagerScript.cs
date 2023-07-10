using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InventoryManagerScript : MonoBehaviour
{
    public static InventoryManagerScript instance;
    public delegate void OnItemChanged();
    public OnItemChanged onItemChangedCallback;
    public Slider ammoSlider;
    public int space = 20;
    public int defaultAmmo = 0;
    public int currentAmmo;

    private void Awake()
    {

        if (instance != null)
        {
            Debug.LogWarning("More than one instance of Inventory found!");
            return;
        }
        instance = this;
    }


    private void Start()
    {
        currentAmmo = defaultAmmo;
    }

    public List<Item> items = new List<Item>();

    public void Add (Item item)
    {
        if (!item.isDefaultItem)
        {
            items.Add(item);
            SetAmmo(5);
        }
    }


    public void Remove(Item item)
    {
        items.Remove(item);
    }


    public void SetMaxAmmo(int ammo)
    {
        ammoSlider.maxValue = ammo;
        ammoSlider.value = ammo;
    }

    public void SetAmmo(int ammo)
    {
        ammoSlider.value += ammo;
        currentAmmo += ammo;
    }

    public void RemoveAmmo(int ammo)
    {
        currentAmmo -= ammo;
        ammoSlider.value -= ammo;
        
    }

}

