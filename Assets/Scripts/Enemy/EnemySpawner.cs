using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    [SerializeField] float minSpawnPeriod = 1.0f;
    [SerializeField] float maxSpawnPeriod = 5.0f;
    [SerializeField] Enemy enemyPrefab;
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

    private void SpawnEnemy()
    {
        Instantiate(enemyPrefab, transform.position, Quaternion.identity);
    }
}
