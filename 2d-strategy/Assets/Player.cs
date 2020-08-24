using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public float damage = 0;
    public float maxHealth= 100;
    public float currentHealth;

    public HealthBar healthBar;
    
    // Start is called before the first frame update
    void Start()
    {
        currentHealth = maxHealth;
        healthBar.SetMaxHealth(maxHealth);
    }

    // Update is called once per frame
    void Update()
    {
        if (currentHealth <= 50){
            currentHealth -= Time.deltaTime * 5;
        } else{
            currentHealth -= Time.deltaTime * 2;
        }

        healthBar.SetHealth(currentHealth);

    }

    // Decrease the health
    public void TakeDamage(float damage)
    {
        currentHealth -= damage;
        if (currentHealth < 0){
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
        }
        healthBar.SetHealth(currentHealth);
    }

}
