using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MusicPlayer : MonoBehaviour
{
    AudioSource audioSource;

    void Start()
    {
        DontDestroyOnLoad(this);
        audioSource = GetComponent<AudioSource>();
        audioSource.volume = PlayerPrefsManager.GetSound();
    }

    public void SetSound(float musicVolume)
    {
        audioSource.volume = musicVolume;
    }
}
