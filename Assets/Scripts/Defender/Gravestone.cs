using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gravestone : MonoBehaviour
{
    private void OnTriggerStay2D(Collider2D otherCollider)
    {
        Enemy enemy = otherCollider.GetComponent<Enemy>();
    }
}
