using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Pool;

public class Bullet : MonoBehaviour
{
    
    [SerializeField] private float timeToSelfDestruct = 5f;
    public IObjectPool<Bullet> Pool { get; set;}
    
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
        ReturnToPool();
    }

    private void ReturnToPool()
    {
        Pool.Release(this);
    }


    private void OnCollisionEnter(Collision collision)
    {
        
        if (collision.gameObject.tag == "Target")
        {
            Destroy(collision.gameObject);
          
        }

        ReturnToPool();

    }
}
