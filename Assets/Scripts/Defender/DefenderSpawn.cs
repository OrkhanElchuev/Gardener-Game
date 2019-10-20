using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DefenderSpawn : MonoBehaviour
{
    Defender defender;

    // On mouse click 
    private void OnMouseDown()
    {
        AttemptToPlaceDefender(GetFieldClicked());
    }

    // Instantiate defender object according to the mouse position
    private void SpawnDefender(Vector2 roundedWorldPos)
    {
        Defender newDefender = Instantiate(defender,
        roundedWorldPos, Quaternion.identity) as Defender;
    }

    private Vector2 SnapPlayAreaToGrid(Vector2 worldPosition)
    {
        // Round the value to get relevant coordinates for placing objects
        float modifiedX = Mathf.RoundToInt(worldPosition.x);
        float modifiedY = Mathf.RoundToInt(worldPosition.y);
        return new Vector2(modifiedX, modifiedY);
    }

    // Checking current star balance
    private void AttemptToPlaceDefender(Vector2 gridPosition)
    {
        if (defender == null) { return; } // Avoid NullReferenceException
        ShowStars showStars = FindObjectOfType<ShowStars>();
        int defenderPrice = defender.GetStarPrice();
        // Spawn selected item only if have enough stars to buy it
        if (showStars.HaveEnoughStars(defenderPrice))
        {
            SpawnDefender(gridPosition);
            // Decrease the amount of current stars after purchase
            showStars.SpendStars(defenderPrice);
        }
    }

    public void SetSelectedDefender(Defender defenderToSelect)
    {
        defender = defenderToSelect;
    }

    // Get the coordinates of mouse click within Game Play field
    private Vector2 GetFieldClicked()
    {
        // Get the mouse click position
        Vector2 clickPosition = new Vector2(Input.mousePosition.x,
        Input.mousePosition.y);
        // Adjust it according to the current Camera view
        Vector2 worldPosition = Camera.main.ScreenToWorldPoint(clickPosition);
        Vector2 gridPosition = SnapPlayAreaToGrid(worldPosition);
        return gridPosition;
    }
}
