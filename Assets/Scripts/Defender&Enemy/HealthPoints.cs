using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthPoints : MonoBehaviour
{
    [SerializeField] float healthPoints = 100.0f;

    public void DealDamage(float damage)
    {
        healthPoints -= damage;
        if(healthPoints <= 0)
        {
            Destroy(gameObject);
        }
    }
}
