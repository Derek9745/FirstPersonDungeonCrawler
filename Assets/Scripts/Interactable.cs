
using UnityEngine;

public class Interactable : MonoBehaviour
{
    public float radius = 3;
    public Transform player;

    private void OnDrawGizmosSelected()
    {
        Gizmos.color = Color.yellow;
        Gizmos.DrawWireSphere(transform.position, radius);
    }

    public virtual void Interact()
    {
        Debug.Log("interacting with " + transform.name);
    }

    private void Update()
    {
        float distance = Vector3.Distance(player.position, transform.position);
        if(distance <= radius)
        {
            Interact();
        }
    }





}
