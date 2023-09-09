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
        Destroy(gameObject, timeToSelfDestruct);
       
    }


    private void OnCollisionEnter(Collision collision)
    {
        Destroy(gameObject);
      
    }

   

}
