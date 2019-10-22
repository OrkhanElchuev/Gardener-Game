using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class ShowStars : MonoBehaviour
{
    private int starsAmount;
    TextMeshProUGUI starText;

    void Start()
    {
        starsAmount = FindObjectOfType<DifficultySettings>().UpdateInitialStarsAmount();
        starText = GetComponent<TextMeshProUGUI>();
        UpdateDisplay();
    }

    public bool HaveEnoughStars(int amountOfStars)
    {
        return starsAmount >= amountOfStars;
    }

    public void AddStars(int amountOfStars)
    {
        starsAmount += amountOfStars;
        UpdateDisplay();
    }

    public void SpendStars(int amountOfStars)
    {
        // Check if have enough stars to spend
        if (starsAmount >= amountOfStars)
        {
            starsAmount -= amountOfStars;
            UpdateDisplay();
        }
    }

    // Update star field in game
    private void UpdateDisplay()
    {
        starText.text = starsAmount.ToString();
    }

}
