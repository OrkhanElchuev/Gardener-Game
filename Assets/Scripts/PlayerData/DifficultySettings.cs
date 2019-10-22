using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DifficultySettings : MonoBehaviour
{
    private float lives = 100f;
    private float enemySpawnMinPeriod = 1f;
    private float enemySpawnMaxPeriod = 5f;

    private int amountOfInitialStars = 1000;

    private void Awake()
    {

        DifficultyConfigurations();
    }

    // Set the difficulty configurations
    private void DifficultyConfigurations()
    {
        // GetGameDifficulty values = {0,1,2}
        switch (PlayerPrefsManager.GetGameDifficulty())
        {
            case 0:
                lives = 100f;
                amountOfInitialStars = 1000;
                enemySpawnMinPeriod = 2f;
                enemySpawnMaxPeriod = 8f;
                break;
            case 1:
                lives = 60f;
                amountOfInitialStars = 700;
                enemySpawnMinPeriod = 1.5f;
                enemySpawnMaxPeriod = 6f;
                break;
            case 2:
                lives = 40f;
                amountOfInitialStars = 500;
                enemySpawnMinPeriod = 1f;
                enemySpawnMaxPeriod = 4f;
                break;
        }
    }

    public float UpdateMaxSpawnPeriod()
    {
        return enemySpawnMaxPeriod;
    }
    public float UpdateMinSpawnPeriod()
    {
        return enemySpawnMinPeriod;
    }

    public int UpdateInitialStarsAmount()
    {
        return amountOfInitialStars;
    }

    public float UpdateLivesAmount()
    {
        return lives;
    }
}
