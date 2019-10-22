using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    [SerializeField] Enemy[] enemyPrefabArray;
    private float minSpawnPeriod;
    private float maxSpawnPeriod;
    private bool spawn = true;

    private void Awake()
    {
        // Initialize relevant values according to the difficulty configs
        minSpawnPeriod = FindObjectOfType<DifficultySettings>().UpdateMinSpawnPeriod();
        maxSpawnPeriod = FindObjectOfType<DifficultySettings>().UpdateMaxSpawnPeriod();
    }

    // Spawn enemies applying random delay in between each spawn
    IEnumerator Start()
    {
        while (spawn)
        {
            yield return new WaitForSeconds(Random.Range(minSpawnPeriod, maxSpawnPeriod));
            SpawnEnemy();
        }
    }

    private void CreateEnemy(Enemy myEnemy)
    {
        Enemy newEnemy = Instantiate
          (myEnemy, transform.position, Quaternion.identity) as Enemy;
        // Instantiate enemies as a child of spawner object 
        newEnemy.transform.parent = transform;
    }

    public void StopSpawningEnemies()
    {
        spawn = false;
    }

    private void SpawnEnemy()
    {
        // Spawn random enemies in array
        int enemyIndex = Random.Range(0, enemyPrefabArray.Length);
        CreateEnemy(enemyPrefabArray[enemyIndex]);
    }
}
