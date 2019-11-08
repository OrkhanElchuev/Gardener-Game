using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthPoints : MonoBehaviour
{
    [SerializeField] float healthPoints = 100f;  
    [SerializeField] GameObject deathParticleEffect;
    private float explosionPeriod = 1f;

    private void DeathParticleEffect()
    {
        // Handle NullReferenceException
        if (!deathParticleEffect) { return; }
        // Create effect considering the position of object it is assigned to 
        GameObject deathParticleObj = Instantiate(deathParticleEffect,
         transform.position, Quaternion.identity);
        // Stop running death particle after time period
        Destroy(deathParticleObj, explosionPeriod);
    }

    public void DealDamage(float damage)
    {
        healthPoints -= damage;
        if (healthPoints <= 0)
        {
            // Run explosion effect
            DeathParticleEffect();
            Destroy(gameObject);
        }
    }
}
