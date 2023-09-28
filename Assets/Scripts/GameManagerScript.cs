using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class GameManagerScript : MonoBehaviour
{
    public static GameManagerScript instance;
    public GameObject textBox;
    public static Shoot shootInstance;
    public Transform spawnPoint;
    public Bullet bulletPrefab;
    public List<GameObject> enemyList = new List<GameObject>();

    public TextMeshProUGUI enemyCountText;
    public int enemyCount;



    private void Awake()
    {
        //textBox.SetActive(false);
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

    public void Start()
    {
        

        enemyList.AddRange(GameObject.FindGameObjectsWithTag("Enemy"));
        enemyCount = enemyList.Count;

    }

    private void Update()
    {
        enemyCountText.text = enemyCount.ToString();
    }

    

   

}















