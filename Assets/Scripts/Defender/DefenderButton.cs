using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DefenderButton : MonoBehaviour
{
    // On click of mouse
    private void OnMouseDown()
    {
        // Array of button objects in defender selector menu
        DefenderButton[] buttons = FindObjectsOfType<DefenderButton>();
        // Make the other items dark
        foreach (DefenderButton button in buttons)
        {
            button.GetComponent<SpriteRenderer>().color = new Color32(34, 34, 34, 255);
        }
        // When clicked show the original color of clicked item
        GetComponent<SpriteRenderer>().color = Color.white;
    }
}
