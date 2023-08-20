using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

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

   
    }















