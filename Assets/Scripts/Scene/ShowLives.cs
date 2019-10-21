using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class ShowLives : MonoBehaviour
{
    private float lives = 100f;
    TextMeshProUGUI livesText;
    private int damage = 20;

    void Start()
    {
        DifficultySettings();
        livesText = GetComponent<TextMeshProUGUI>();
        UpdateDisplay();
    }

    // Temporary method, will be modified later
    // CREATED FOR TESTING PURPOSES
    private void DifficultySettings()
    {
        if (PlayerPrefsManager.GetGameDifficulty() == 1)
        {
            lives = 50;
        }
        else if (PlayerPrefsManager.GetGameDifficulty() == 2)
        {
            lives = 20;
        }
    }

    public void DecrementLife()
    {
        lives -= damage;
        UpdateDisplay();
        // Load loosing scene if base is destroyed
        if (lives <= 0)
        {
            FindObjectOfType<LevelManager>().ExecuteLoseCondition();
        }
    }

    // Update lives field in game
    private void UpdateDisplay()
    {
        livesText.text = lives.ToString();
    }
}
