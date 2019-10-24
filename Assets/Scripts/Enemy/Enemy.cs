using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    private float currentEnemySpeed = 1f;
    GameObject currentTarget;

    // Happens before anything else is executed
    private void Awake()
    {
        // Increment the number of enemies
        FindObjectOfType<LevelManager>().EnemySpawned();
    }

    // On destroy of enemy object
    private void OnDestroy()
    {
        LevelManager levelManager = FindObjectOfType<LevelManager>();
        // Avoid null reference exception
        if (levelManager != null)
        {
            // Decrement the number of enemies
            FindObjectOfType<LevelManager>().EnemyDestroyed();
        }
    }

    // Update is called once per frame
    void Update()
    {
        MoveEnemy();
        UpdateAnimationState();
    }

    // Switch from attacking state animation to walking
    private void UpdateAnimationState()
    {
        // If there is no target, move on 
        if (!currentTarget)
        {
            GetComponent<Animator>().SetBool("isAttacking", false);
        }
    }

    // Switch enemy to attacking state animation
    public void Attack(GameObject target)
    {
        GetComponent<Animator>().SetBool("isAttacking", true);
        // Set current target of enemy
        currentTarget = target;
    }

    public void AttackCurrentTarget(float damage)
    {
        // Check if there is target
        if (!currentTarget) { return; }
        HealthPoints health = currentTarget.GetComponent<HealthPoints>();
        // If current target has a health points then deal damage
        if (health)
        {
            health.DealDamage(damage);
        }
    }

    // Move enemy (independent from the FPS of device)
    private void MoveEnemy()
    {
        transform.Translate(Vector2.left * currentEnemySpeed * Time.deltaTime);
    }

    public void SetMovementSpeed(float speed)
    {
        currentEnemySpeed = speed;
    }
}
