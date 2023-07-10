using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerHealth : MonoBehaviour
{
    public int defaultHealth = 10;
    public int currentHealth;
    public HealthBarScript healthBar;

    public void Start()
    {
        currentHealth = defaultHealth;
        healthBar.SetMaxHealth(defaultHealth);
    }

    public void Update()
    {
        if (currentHealth == 0)
        {
            if (SceneManager.GetActiveScene().buildIndex == 1) { 
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 1);
            }
        }
    }

    public void TakeDamage(int damage)
    {
        currentHealth -= damage;
        healthBar.SetHealth(currentHealth);
    }



    public void GainHealth()
    {


    }

    private void OnCollisionEnter(Collision col)
    {
        if(col.gameObject.tag == "Enemy")
        {
            TakeDamage(1);
        }
    }
}
