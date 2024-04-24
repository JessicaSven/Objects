using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Health
{
    public int currentHealth;
    public UnityEvent<int> OnHealthChanged;
    
    public void DecreaseLife(int damage)
    { 
        currentHealth -= damage;
        OnHealthChanged.Invoke(currentHealth);
    }

    public void DecreaseLife()
    {
        Debug.Log("Lost Health. Current Health: " + currentHealth);
        currentHealth -= 1;
        OnHealthChanged.Invoke(currentHealth);
    }

    public void IncreaseLife(int damage, float timer)
    {
        
    }
    public Health(int maxHealth)
    {
        currentHealth = maxHealth;
        OnHealthChanged = new UnityEvent<int>();
    }
}
