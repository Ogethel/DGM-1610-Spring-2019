using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Debug = System.Diagnostics.Debug;
using UnityEngine.SceneManagement;

public class UpdateBar : MonoBehaviour
{
    //Health Value Information
    public float startHealth = 1f;
    public float currentHealthValue;
    public float damageValue = .15f;
    public float healthPack = .25f;
    public GameObject Heart;
   

    //Slider Information
    public Slider healthBar;

    private void Start()
    {
       
        currentHealthValue = startHealth;
    }

    public void OnTriggerEnter(Collider other)
    {
        switch(other.name)
        {
            case "BadyDamage":
                currentHealthValue -= damageValue;
                healthBar.value = currentHealthValue;
                if (currentHealthValue <= 0)
                {
                    playerDeath();
                }
                break;
            case "Health":
                currentHealthValue= currentHealthValue += healthPack;
                healthBar.value = currentHealthValue;
                if (currentHealthValue >= 1)
                {
                    currentHealthValue = 1;
                }

                Destroy(Heart);
                break;
        }
    }

    private void HealthPickUp()
    {
        
    }

    private void playerDeath()
    {
        print("Death");
        Invoke("ResetLevel", 1);
    }

    private void ResetLevel()
    {
        SceneManager.LoadScene(0);
    }
}
