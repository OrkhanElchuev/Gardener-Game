using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerPrefsManager : MonoBehaviour
{
    const string VOLUME_KEY = "sound";
    const string DIFFICULTY_KEY = "difficulty";
    const float MIN_SOUND = 0f;
    const float MAX_SOUND = 1f;
    const float MIN_DIFFICULTY = 0f;
    const float MAX_DIFFICULTY = 2f;

    public static void SetMusicVolume(float musicVolume)
    {
        // Check for the correct value of volume in a range from 0 to 1
        if (musicVolume >= MIN_SOUND && musicVolume <= MAX_SOUND)
        {
            // Set volume value in player preferences
            PlayerPrefs.SetFloat(VOLUME_KEY, musicVolume);
        }
        else
        {
            Debug.LogError("Sound is out of range");
        }
    }

    public static float GetMusicVolume()
    {
        return PlayerPrefs.GetFloat(VOLUME_KEY);
    }

    public static void SetGameDifficulty(float gameDifficulty)
    {
        // Check if game difficulty value is in a range from 0 to 2() 
        if (gameDifficulty >= MIN_DIFFICULTY && gameDifficulty <= MAX_DIFFICULTY)
        {
            // Set game difficulty value in player preferences
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
