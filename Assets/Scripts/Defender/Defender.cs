using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Defender : MonoBehaviour
{
    [SerializeField] int starPrice = 100;

    public void AddStars(int amountOfStars)
    {
        FindObjectOfType<ShowStars>().AddStars(amountOfStars);
    }

    public int GetStarPrice()
    {
      return starPrice;
    }

}
