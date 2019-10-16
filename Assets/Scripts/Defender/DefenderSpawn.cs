using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DefenderSpawn : MonoBehaviour
{
    [SerializeField] GameObject defender;

    // On mouse click 
    private void OnMouseDown()
    {
        SpawnDefender(GetFieldClicked());
    }

    // Instantiate defender object according to the mouse position
    private void SpawnDefender(Vector2 roundedWorldPos)
    {
        GameObject newDefender = Instantiate(defender,
        roundedWorldPos, Quaternion.identity) as GameObject;
    }

    private Vector2 SnapPlayAreaToGrid(Vector2 worldPosition)
    {
        float modifiedX = Mathf.RoundToInt(worldPosition.x);
        float modifiedY = Mathf.RoundToInt(worldPosition.y);
        return new Vector2(modifiedX, modifiedY);
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
