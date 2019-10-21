using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MusicPlayer : MonoBehaviour
{
    private AudioSource audioSource;

    void Start()
    {
        // Keep playing music after switching between scenes
        DontDestroyOnLoad(this);
        audioSource = GetComponent<AudioSource>();
        audioSource.volume = PlayerPrefsManager.GetMusicVolume();
    }

    // Set music volume to relevant value (according to options)
    public void SetMusicVolume(float musicVolume)
    {
        audioSource.volume = musicVolume;
    }
}
