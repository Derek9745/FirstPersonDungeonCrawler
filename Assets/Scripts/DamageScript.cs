using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class DamageScript : MonoBehaviour
{
    public GameObject Player;
    public int Damage = 1;

    private void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.tag == "Player")
        {

            
            //healthBarscript.TakeDamage();
        }
       
      
    }
}
