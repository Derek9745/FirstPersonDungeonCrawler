using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public GameObject bulletPrefab;
    void Update()
    {
        Destroy(bulletPrefab, 5);
    }

    private void OnCollisionEnter(Collision collision)
    {
        Destroy(bulletPrefab);
    }
}
