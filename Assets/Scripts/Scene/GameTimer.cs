using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameTimer : MonoBehaviour
{
    [SerializeField] float levelTimeInSec = 10;

    private void Update()
    {
        GetComponent<Slider>().value = Time.timeSinceLevelLoad / levelTimeInSec;

        bool timerFinished = (Time.timeSinceLevelLoad >= levelTimeInSec);
        if(timerFinished)
        {
            Debug.Log("level timer expired");
        }
    }
}
