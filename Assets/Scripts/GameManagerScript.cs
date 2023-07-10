using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Pool;





public class GameManagerScript : MonoBehaviour
{
    public static GameManagerScript instance;
    public GameObject textBox;
    public static Shoot shootInstance;
    public Transform spawnPoint;
    public Bullet bulletPrefab;

    private void Awake()
    {
        textBox.SetActive(false);
        if (instance == null)
        {
            instance = this;
            DontDestroyOnLoad(instance);
        }
        else
        {
            Destroy(instance);
            Debug.Log("Warning: there is alread and instance of this object!");
        }  
    }

   


    public class BulletObjectPool : GameManagerScript
    {
        IObjectPool<Bullet> m_Pool;
        public int maxPoolSize = 20;



        public IObjectPool<Bullet> Pool
        {
            get
            {
                if (m_Pool == null)
                {
                    m_Pool = new ObjectPool<Bullet>(CreatedPooledItem, OnTakeFromPool, OnReturnedToPool, OnDestroyPoolObject, true, maxPoolSize);
                }
                return m_Pool;
            }
        }
        Bullet CreatedPooledItem()
        {
            var go = GameObject.CreatePrimitive(PrimitiveType.Cube);
            Bullet bullet = go.AddComponent<Bullet>();
            //instance.GetComponent<Shoot>().
            //bullet.gameObject.SetActive(false);
            return bullet;
        }

        private void OnReturnedToPool(Bullet bullet)
        {
            bullet.gameObject.SetActive(false);
            Debug.Log("bullet added to Pool");
        }

        private void OnTakeFromPool(Bullet bullet)
        {
            bullet.gameObject.SetActive(true);
           // spawn();
        }

        private void OnDestroyPoolObject(Bullet bullet)
        {
            Destroy(bullet.gameObject);

            Debug.Log("bullet destroyed");
        }

        public void spawn()
        {
            
            Pool.Get();
            Debug.Log("Pool Size is " + m_Pool.CountInactive + "/" + maxPoolSize);
            Debug.Log("Bullet has been Spawned");
        }

       
    }

}













