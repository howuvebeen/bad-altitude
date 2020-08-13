using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public int maxHealth= 100;
    public int currentHealth;

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
        TakeDamage(Mathf.RoundToInt(Time.deltaTime));
    }

    // Decrease the health
    public void TakeDamage(int damage)
    {
        currentHealth -= damage;
        healthBar.SetHealth(currentHealth);
    }

    // Increase the health
    public void TakeBenefit(int benefit)
    {
        currentHealth += benefit;
        healthBar.SetHealth(currentHealth);
    }

}
