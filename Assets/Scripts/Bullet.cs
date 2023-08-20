using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Bullet : MonoBehaviour
{
    
    [SerializeField] private float timeToSelfDestruct = 5f;
   
  

    private void Start()
    {
       
    }

    void Update()
    {
        
    }

    private void OnEnable()
    {
        StartCoroutine(SelfDestruct());
    }

   IEnumerator SelfDestruct()
    {
        yield return new WaitForSeconds(timeToSelfDestruct);
       
    }


    private void OnCollisionEnter(Collision collision)
    {
        
        if (collision.gameObject.tag == "Target")
        {
            Destroy(collision.gameObject);
        }

        if (collision.gameObject.tag == "Enemy")
        {
            Destroy(collision.gameObject);
        }

        Destroy(gameObject);

     

    }

   

}
