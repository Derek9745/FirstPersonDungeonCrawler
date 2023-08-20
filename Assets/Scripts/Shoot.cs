using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Pool;
using static GameManagerScript;

public class Shoot : MonoBehaviour
{
    
    public Transform spawnPoint;
    public bool canShoot = true;
    public GameObject weapon;
    public GameObject bulletPrefab;
    public float bulletForce = 40f;
   

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            if (InventoryManagerScript.instance.currentAmmo != 0)
            {
                if (canShoot == true)
                {
                    
                    spawnBullet();
                    StartCoroutine(ReloadBullet());
                }
            }
        }
    }

    void spawnBullet()
    {
        GameObject bullet = Instantiate(bulletPrefab, spawnPoint.transform.position, spawnPoint.transform.rotation);
        Rigidbody wb = bullet.GetComponent<Rigidbody>();
        wb.AddForce(spawnPoint.forward * bulletForce, ForceMode.Impulse);
        InventoryManagerScript.instance.RemoveAmmo(1);
        
    }

    IEnumerator ReloadBullet()
    {
        canShoot = false;
        yield return new WaitForSeconds(1);
        canShoot = true;
    }
 

}
