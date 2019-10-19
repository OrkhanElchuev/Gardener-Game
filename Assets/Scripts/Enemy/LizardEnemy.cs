using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LizardEnemy : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D otherCollider)
    {
        GameObject otherObject = otherCollider.gameObject;
        // Check if the colliding object is a defender, if yes then attack 
        if (otherObject.GetComponent<Defender>())
        {
            GetComponent<Enemy>().Attack(otherObject);
        }
    }
}
