using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    [SerializeField] float minSpawnPeriod = 1.0f;
    [SerializeField] float maxSpawnPeriod = 5.0f;
    [SerializeField] Enemy[] enemyPrefabArray;
    private bool spawn = true;

    // Spawn enemies applying random delay in between each spawn
    IEnumerator Start()
    {
        while (spawn)
        {
            yield return new WaitForSeconds(Random.Range(minSpawnPeriod, maxSpawnPeriod));
            SpawnEnemy();
        }
    }

    private void Spawn(Enemy myEnemy)
    {
        Enemy newEnemy = Instantiate
          (myEnemy, transform.position, Quaternion.identity) as Enemy;
        // Instantiate enemies as a child of spawner object
        newEnemy.transform.parent = transform;
    }

    private void SpawnEnemy()
    {
        int enemyIndex = Random.Range(0, enemyPrefabArray.Length);
        Spawn(enemyPrefabArray[enemyIndex]);
    }
}
