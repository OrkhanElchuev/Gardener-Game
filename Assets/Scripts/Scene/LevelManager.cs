using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelManager : MonoBehaviour
{
    [SerializeField] GameObject winLabel;
    [SerializeField] float delayForLoading = 2.0f;
    private int numberOfEnemies = 0;
    private bool levelTimerFinished = false;

    private void Start()
    {
        winLabel.SetActive(false);
    }

    public void LevelTimerFinished()
    {
        levelTimerFinished = true;
        StopSpawners();
    }

    // Stop spawning enemies
    private void StopSpawners()
    {
        EnemySpawner[] spawnerArray = FindObjectsOfType<EnemySpawner>();
        // For each enemy apply stop spawning function
        foreach (EnemySpawner spawner in spawnerArray)
        {
            spawner.StopSpawningEnemies();
        }
    }

    // Increment the number of enemies
    public void EnemySpawned()
    {
        numberOfEnemies++;
    }

    public void EnemyDestroyed()
    {
        numberOfEnemies--;
        // If enemies are killed and level time is over, finish level
        if (numberOfEnemies <= 0 && levelTimerFinished)
        {
            StartCoroutine(ExecuteWinCondition());
        }
    }

    IEnumerator ExecuteWinCondition()
    {
        // Make winning canvas visible
        winLabel.SetActive(true);
        // Play winning sound
        GetComponent<AudioSource>().Play();
        yield return new WaitForSeconds(delayForLoading);
        // After delay load next scene
        FindObjectOfType<SceneLoader>().LoadNextScene();
    }
}
