using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shooter : MonoBehaviour
{
    const string PROJECTILE_PARENT_NAME = "Projectiles";
    [SerializeField] GameObject shooting;
    [SerializeField] GameObject weapon;
    private EnemySpawner myLaneSpawner;
    private Animator animator;
    private GameObject projectileParent;

    private void Start()
    {
        animator = GetComponent<Animator>();
        SetLaneSpawner();
        CreateProjectileParent();
    }

    private void Update()
    {
        DefenderState();
    }

    // For organizing tree, put all projectiles under Projectiles game object
    private void CreateProjectileParent()
    {
        projectileParent = GameObject.Find(PROJECTILE_PARENT_NAME);
        if (!projectileParent)
        {
            projectileParent = new GameObject(PROJECTILE_PARENT_NAME);
        }
    }

    // Switch between idle and shooting states
    private void DefenderState()
    {
        // If enemy spotted in the lane, run shooting animation
        if (IsEnemyInLane())
        {
            animator.SetBool("isAttacking", true);
        }
        // If the lane is empty, run idle animation
        else
        {
            animator.SetBool("isAttacking", false);
        }
    }

    public void Shoot()
    {
        GameObject newProjectile = 
        Instantiate(shooting, weapon.transform.position, Quaternion.identity)
        as GameObject;
        newProjectile.transform.parent = projectileParent.transform;
    }

    // Check if there is an enemy in the same lane with current defender
    private bool IsEnemyInLane()
    {
        // Get the number of elements under spawning lanes
        if (myLaneSpawner.transform.childCount <= 0)
        {
            return false;
        }
        return true;
    }

    private void SetLaneSpawner()
    {
        EnemySpawner[] spawners = FindObjectsOfType<EnemySpawner>();
        // Iterate through an array of EnemySpawner objects
        foreach (EnemySpawner spawner in spawners)
        {
            /*Check if y coordinate of spawner is almost identical
             with y coordinate of defender 
             Mathf.Epsilon is used to compare two floating numbers 
             considering truncation */
            bool isCloseEnough = (Mathf.Abs(spawner.transform.position.y -
            transform.position.y) <= Mathf.Epsilon);
            if (isCloseEnough)
            {
                myLaneSpawner = spawner;
            }
        }
    }
}
