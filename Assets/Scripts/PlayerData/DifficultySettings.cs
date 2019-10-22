using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DifficultySettings : MonoBehaviour
{
    private float lives = 100f;
    private float enemyDamage = 20f;
    private float enemySpeed = 1f;
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
                break;
            case 1:
                lives = 60f;
                amountOfInitialStars = 700;
                break;
            case 2:
                lives = 40f;
                amountOfInitialStars = 500;
                break;
        }
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
