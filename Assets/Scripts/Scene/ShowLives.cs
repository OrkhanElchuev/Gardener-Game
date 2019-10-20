using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class ShowLives : MonoBehaviour
{
    [SerializeField] int lives = 100;
    TextMeshProUGUI livesText;
    private int damage = 20;

    void Start()
    {
        livesText = GetComponent<TextMeshProUGUI>();
        UpdateDisplay();
    }

    public void DecrementLife()
    {
        lives -= damage;
        UpdateDisplay();
        // Load loosing scene if base is destroyed
        if(lives <= 0)
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
