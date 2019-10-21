﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerPrefsManager : MonoBehaviour
{
    const string VOLUME_KEY = "sound";
    const string DIFFICULTY_KEY = "difficulty";
    const float MIN_SOUND = 0.0f;
    const float MAX_SOUND = 1.0f;
    const float MIN_DIFFICULTY = 0.0f;
    const float MAX_DIFFICULTY = 2.0f;

    public static void SetSound(float volume)
    {
        // Check for the correct value of volume in a range from 0 to 1
        if (volume >= MIN_SOUND && volume <= MAX_SOUND)
        {
            Debug.Log("Sound set to " + volume);
            PlayerPrefs.SetFloat(VOLUME_KEY, volume);
        }
        else
        {
            Debug.LogError("Sound is out of range");
        }
    }

    public static float GetSound()
    {
        return PlayerPrefs.GetFloat(VOLUME_KEY);
    }

    public static void SetGameDifficulty(float gameDifficulty)
    {
        if (gameDifficulty >= MIN_DIFFICULTY && gameDifficulty <= MAX_DIFFICULTY)
        {
            PlayerPrefs.SetFloat(DIFFICULTY_KEY, gameDifficulty);
        }
        else
        {
            Debug.LogError("Difficulty settings out of range");
        }
    }

    public static float GetGameDifficulty()
    {
        return PlayerPrefs.GetFloat(DIFFICULTY_KEY);
    }
}