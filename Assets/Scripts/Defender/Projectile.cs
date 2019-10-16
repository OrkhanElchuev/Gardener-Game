using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Projectile : MonoBehaviour
{
    [SerializeField] float speed = 1.0f;
    [SerializeField] int damageAmount = 50;

    // Update is called once per frame
    void Update()
    {
        MoveProjectile();
    }

    // Move projectile (independent from the FPS of device)
    private void MoveProjectile()
    {
        transform.Translate(Vector2.right * speed * Time.deltaTime);
    }

    private void OnTriggerEnter2D(Collider2D otherObject)
    {
        var healthDecrease = otherObject.GetComponent<HealthPoints>();
        var enemy = otherObject.GetComponent<Enemy>();
        // If projectile collides with enemy then deal damage
        if (enemy && healthDecrease)
        {
            healthDecrease.DealDamage(damageAmount);
            // Destroy projectile if collided with enemy
            Destroy(gameObject);
        }
    }
}
