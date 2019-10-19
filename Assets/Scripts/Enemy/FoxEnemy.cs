using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FoxEnemy : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D otherCollider)
    {
        GameObject otherObject = otherCollider.gameObject;
        // If there is a gravestone on a lane, jump over it
        if (otherObject.GetComponent<Gravestone>())
        {
            // Setting jump trigger animation
            GetComponent<Animator>().SetTrigger("jumpTrigger");
        }
        // Check if the colliding object is a defender, if yes then attack 
        else if (otherObject.GetComponent<Defender>())
        {
            GetComponent<Enemy>().Attack(otherObject);
        }
    }
}
