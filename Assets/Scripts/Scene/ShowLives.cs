using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class ShowLives : MonoBehaviour
{
    // private float lives = 100f;
    private int damage = 20;
    private float livesAmount;
    TextMeshProUGUI livesText;

    private void Start()
    {
        livesAmount = FindObjectOfType<DifficultySettings>().UpdateLivesAmount();
        livesText = GetComponent<TextMeshProUGUI>();
        UpdateDisplay();
    }

    public void DecrementLife()
    {
        livesAmount -= damage;
        UpdateDisplay();
        // Load loosing scene if base is destroyed
        if (livesAmount <= 0)
        {
            FindObjectOfType<LevelManager>().ExecuteLoseCondition();
        }
    }

    // Update lives field in game
    private void UpdateDisplay()
    {
        livesText.text = livesAmount.ToString();
    }
}
