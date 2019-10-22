using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class ShowStars : MonoBehaviour
{
    private int difficultyStars;
    TextMeshProUGUI starText;

    void Start()
    {
        difficultyStars = FindObjectOfType<DifficultySettings>().UpdateInitialStarsAmount();
        starText = GetComponent<TextMeshProUGUI>();
        UpdateDisplay();
    }

    public bool HaveEnoughStars(int amountOfStars)
    {
        return difficultyStars >= amountOfStars;
    }

    public void AddStars(int amountOfStars)
    {
        difficultyStars += amountOfStars;
        UpdateDisplay();
    }

    public void SpendStars(int amountOfStars)
    {
        // Check if have enough stars to spend
        if (difficultyStars >= amountOfStars)
        {
            difficultyStars -= amountOfStars;
            UpdateDisplay();
        }
    }

    // Update star field in game
    private void UpdateDisplay()
    {
        starText.text = difficultyStars.ToString();
    }

}
