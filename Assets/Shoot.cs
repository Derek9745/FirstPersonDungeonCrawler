using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shoot : MonoBehaviour
{

    public Transform spawnPoint;
    public GameObject projectile;
    public bool canShoot = true;

    public float bulletForce = 20f;


    void Update()
    {
        if (Input.GetKeyDown(KeyCode.R))
        {
            if (canShoot == true) { 
            spawnBullet();
            StartCoroutine(ReloadBullet());
            
        }
        }
    }



    void spawnBullet()
    {
        GameObject bullet = Instantiate(projectile, spawnPoint.transform.position, spawnPoint.transform.rotation);
        Rigidbody wb = bullet.GetComponent<Rigidbody>();
        wb.AddForce(spawnPoint.forward * bulletForce, ForceMode.Impulse);
       // GameManagerScript.instance.AddToBulletQueue(bullet);
      
       
        
    }

    IEnumerator ReloadBullet()
    {

        canShoot = false;
        yield return new WaitForSeconds(1);
        canShoot = true;
    }
    
}
