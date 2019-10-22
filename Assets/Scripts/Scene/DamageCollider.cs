using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DamageCollider : MonoBehaviour
{
    // Collider for garden 
    private void OnTriggerEnter2D(Collider2D otherCollider)
    {
        // Decrement player's overall health points
        FindObjectOfType<ShowLives>().DecrementLife();
        // Destroy object entering the collider
        Destroy(otherCollider.gameObject);
    }
}
