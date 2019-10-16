using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthPoints : MonoBehaviour
{
    [SerializeField] float healthPoints = 100.0f;
    [SerializeField] GameObject deathParticleEffect;
    private float explosionPeriod = 1.0f;

    private void DeathParticleEffect()
    {
        if (!deathParticleEffect) { return; }
        // Create effect considering the position of object it is assigned to 
        GameObject deathPArticleObj = Instantiate(deathParticleEffect,
         transform.position, Quaternion.identity);
        Destroy(deathPArticleObj, explosionPeriod);
    }

    public void DealDamage(float damage)
    {
        healthPoints -= damage;
        if (healthPoints <= 0)
        {
            DeathParticleEffect();
            Destroy(gameObject);
        }
    }
}
