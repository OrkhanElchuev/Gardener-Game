using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Defender : MonoBehaviour
{
    [SerializeField] int startPrice = 100;

    public void AddStars(int amountOfStars)
    {
      FindObjectOfType<ShowStars>().AddStars(amountOfStars);
    }
    
}
