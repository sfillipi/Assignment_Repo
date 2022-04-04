/*
 * (Sydney Fillipi)
 * (Assignment 6)
 * (Damage enemies when shot at.)
 */

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Target : MonoBehaviour, IDamageable
{
    protected float boxHealth;
    protected float coinHealth;

    protected virtual void Awake()
    {
        boxHealth = 50f;
        coinHealth = 70f;
    }

    public void TakeDamage(float amount)
    {
        boxHealth -= amount;

        if (boxHealth <= 0)
        {
            Die();
        }

    }


    void Die()
    {
        Destroy(gameObject);
    }


}
