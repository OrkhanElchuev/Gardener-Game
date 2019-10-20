using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Lives : MonoBehaviour
{
    [SerializeField] int lives = 5;
    TextMeshProUGUI livesText;
    private int damage = 1;

    void Start()
    {
        livesText = GetComponent<TextMeshProUGUI>();
        UpdateDisplay();
    }

    public void DecrementLife()
    {
        lives -= damage;
        UpdateDisplay();
    }

    // Update lives field in game
    private void UpdateDisplay()
    {
        livesText.text = lives.ToString();
    }
}
