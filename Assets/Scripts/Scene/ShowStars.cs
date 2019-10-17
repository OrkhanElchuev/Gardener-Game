using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class ShowStars : MonoBehaviour
{
    [SerializeField] int stars = 100;
    TextMeshProUGUI starText;

    void Start()
    {
        starText = GetComponent<TextMeshProUGUI>();
        UpdateDisplay();
    }

    public void AddStars(int amountOfStars)
    {
        stars += amountOfStars;
        UpdateDisplay();
    }

    public void SpendStars(int amountOfStars)
    {
        if (stars >= amountOfStars)
        {
            stars -= amountOfStars;
            UpdateDisplay();
        }
    }

    private void UpdateDisplay()
    {
        starText.text = stars.ToString();
    }

}
