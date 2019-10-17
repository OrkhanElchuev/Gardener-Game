using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class ShowStars : MonoBehaviour
{
    [SerializeField] int currentStars = 100;
    TextMeshProUGUI starText;

    void Start()
    {
        starText = GetComponent<TextMeshProUGUI>();
        UpdateDisplay();
    }

    public bool HaveEnoughStars(int amountOfStars)
    {
        return currentStars >= amountOfStars;
    }

    public void AddStars(int amountOfStars)
    {
        currentStars += amountOfStars;
        UpdateDisplay();
    }

    public void SpendStars(int amountOfStars)
    {
        if (currentStars >= amountOfStars)
        {
            currentStars -= amountOfStars;
            UpdateDisplay();
        }
    }

    // Update star field in game
    private void UpdateDisplay()
    {
        starText.text = currentStars.ToString();
    }

}
