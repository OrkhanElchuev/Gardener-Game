using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DifficultySettings : MonoBehaviour
{
    private float lives = 100f;
    private float enemySpawnMinPeriod = 1f;
    private float enemySpawnMaxPeriod = 5f;

    [SerializeField] int starsEasyDifficulty = 1000;
    [SerializeField] int starsMediumDifficulty = 1000;
    [SerializeField] int starsHardDifficulty = 1000;

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
                enemySpawnMinPeriod = 6f;
                enemySpawnMaxPeriod = 20f;
                break;
            case 1:
                lives = 80f;
                enemySpawnMinPeriod = 5.5f;
                enemySpawnMaxPeriod = 13.5f;
                break;
            case 2:
                lives = 50f;
                enemySpawnMinPeriod = 4.5f;
                enemySpawnMaxPeriod = 11f;
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
        // 1000 is a default value
        int starsAmount = 1000;
        // Return value according to the level difficulty
        switch (PlayerPrefsManager.GetGameDifficulty())
        {
            case 0:
                starsAmount = starsEasyDifficulty;
                break;
            case 1:
                starsAmount = starsMediumDifficulty;
                break;
            case 2:
                starsAmount = starsHardDifficulty;
                break;
        }
        return starsAmount;
    }

    public float UpdateLivesAmount()
    {
        return lives;
    }
}
