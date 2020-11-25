using System;
using UnityEngine;
using UnityEngine.Events;

public class HealthBehaviour : MonoBehaviour
{
    public UnityEvent<int> OnChanged;

    [SerializeField] private int maxHealth;

    private int currentHealth;

    private void Start()
    {
        currentHealth = maxHealth;
        HealthChanged(currentHealth);
    }

    public void DoDamage(int damageAmount)
    {
        if (currentHealth > 0)
        {
            currentHealth = Math.Max(currentHealth - damageAmount, 0);

            HealthChanged(currentHealth);
        }
    }

    public void DoHealing(int healingAmount)
    {
        if (currentHealth < maxHealth)
        {
            currentHealth = Math.Min(currentHealth + healingAmount, maxHealth);

            HealthChanged(currentHealth);
        }
    }

    private void HealthChanged(int health)
    {
        OnChanged.Invoke(health);
    }
}
