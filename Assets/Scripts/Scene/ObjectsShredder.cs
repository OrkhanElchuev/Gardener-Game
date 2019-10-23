using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectsShredder : MonoBehaviour
{
    // Shredder for projectiles leaving the screen 
    private void OnTriggerEnter2D(Collider2D otherCollider)
    {
        // Destroy object entering the collider
        Destroy(otherCollider.gameObject);
    }
}
