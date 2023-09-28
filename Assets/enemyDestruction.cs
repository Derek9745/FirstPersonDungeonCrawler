using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemyDestruction : MonoBehaviour
{
    public ParticleSystem deathParticles;
   

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Bullet")
        {
           RemoveObject();
        }
    }

    void RemoveObject()
    {
 
     Instantiate(deathParticles, transform.position, Quaternion.identity);
     Destroy(gameObject);
     GameManagerScript.instance.enemyCount -= 1;
        
    }

}
