using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameTimer : MonoBehaviour
{
    [SerializeField] float levelTimeInSec = 10f;
    bool levelFinishedTriggered = false;

    private void Update()
    {
        // To not loop through Update method after level is finished
        if (levelFinishedTriggered) { return; }
        // Set the slider time with respect to level time
        GetComponent<Slider>().value = Time.timeSinceLevelLoad / levelTimeInSec;
        // Check if level is finished considering time passed
        bool timerFinished = (Time.timeSinceLevelLoad >= levelTimeInSec);
        if (timerFinished)
        {
            FindObjectOfType<LevelManager>().LevelTimerFinished();
            // Stop the looping of Update
            levelFinishedTriggered = true;
        }
    }
}
