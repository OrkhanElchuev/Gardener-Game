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
    private void SpawnDefender(Vector2 worldPosition)
    {
        GameObject newDefender = Instantiate(defender,
        worldPosition, Quaternion.identity) as GameObject;
    }

    // Get the coordinates of mouse click within Game Play field
    private Vector2 GetFieldClicked()
    {
        // Get the mouse click position
        Vector2 clickPosition = new Vector2(Input.mousePosition.x, 
        Input.mousePosition.y);
        // Adjust it according to the current Camera view
        Vector2 worldPosition = Camera.main.ScreenToWorldPoint(clickPosition);
        return worldPosition;
    }
}
