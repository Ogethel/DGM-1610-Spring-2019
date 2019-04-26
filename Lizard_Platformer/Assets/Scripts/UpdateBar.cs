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
        }
    }

    private void playerDeath()
    {
        print("Death");
        Invoke("ResetLevel", 2);
    }

    private void ResetLevel()
    {
        SceneManager.LoadScene(0);
    }
}
