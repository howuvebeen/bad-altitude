using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public float damage = 0;
    public float maxHealth= 100;
    public float currentHealth;

    public HealthBar healthBar;
    public EndScript endScript;

    // Start is called before the first frame update
    void Start()
    {
        currentHealth = maxHealth;
        healthBar.SetMaxHealth(maxHealth);
        endScript.Start();
    }

    // Update is called once per frame
    void Update()
    {
        if (currentHealth <= 50){
            currentHealth -= Time.deltaTime * 4;
        } if (currentHealth > 50){
            currentHealth -= Time.deltaTime * 2;
        } if (currentHealth <= 0){
            healthBar.SetHealth(0);
            endScript.FailLevel();
        }

        healthBar.SetHealth(currentHealth);
    }

    // Decrease the health
    public void TakeDamage(float damage)
    {
        currentHealth -= damage;
        if (currentHealth <= 0){
            currentHealth = 0;
        }
        healthBar.SetHealth(currentHealth);
    }

    // Increase the health
    public void TakeBenefit(float benefit)
    {
        currentHealth += benefit;
        if (currentHealth > 100){
            currentHealth = 100;
            // endScript.SuccessLevel();
        }
        healthBar.SetHealth(currentHealth);
    }

}
