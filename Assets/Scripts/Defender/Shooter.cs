using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shooter : MonoBehaviour
{
    [SerializeField] GameObject tomatoShooting;
    [SerializeField] GameObject weapon;

    public void Shoot()
    {
        Instantiate(tomatoShooting, weapon.transform.position, Quaternion.identity);
    }
}
