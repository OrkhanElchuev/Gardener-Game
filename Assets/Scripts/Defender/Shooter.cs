using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shooter : MonoBehaviour
{
    [SerializeField] GameObject tomatoShooting;
    [SerializeField] GameObject weapon;
    EnemySpawner myLaneSpawner;

    private void Start()
    {
        SetLaneSpawner();
    }

    private void Update()
    {   
        if (IsEnemyInLane())
        {
            // TODO switch to shooting
            Debug.Log("Shoot");
        }
        else
        {
            // TODO switch to idle
            Debug.Log("Wait");
        }
    }

    public void Shoot()
    {
        Instantiate(tomatoShooting, weapon.transform.position, Quaternion.identity);
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
