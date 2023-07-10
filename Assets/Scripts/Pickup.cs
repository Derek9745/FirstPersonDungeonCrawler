
using UnityEngine;
using UnityEngine.UI;

public class Pickup : Interactable
{
    public Item item;
 


    public void Start()
    {
    

    }

    public override void Interact()
    {
        base.Interact();
         
        PickUp();
        
    }


void PickUp()
{ 
    Debug.Log("Picking up " + item);
    InventoryManagerScript.instance.Add(item); 
    Destroy(gameObject);
}







}
