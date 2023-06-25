using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Unity.UI;
using UnityEngine.Pool;




public class GameManagerScript : MonoBehaviour
{
    public static GameManagerScript instance;
    public GameObject textBox;
   
    public int bulletCount;

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



    private void Update()
    {

    }

   





        



}


public class ObjectPool: MonoBehaviour
{
    public int maxPoolSize = 20;
    public int stackDefaultCapacity = 20;
    public IObjectPool<Bullet> Pool { get; set; }


   // public IObjectPool<Bullet> Pool
    //{
        
           






      //  }




    }










