using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class OptionsManager : MonoBehaviour
{
    [SerializeField] Slider soundSlider;
    [SerializeField] float defaultSound = 0.7f;

    void Start()
    {
        soundSlider.value = PlayerPrefsManager.GetSound();
    }

    void Update()
    {
        var musicPlayer = FindObjectOfType<MusicPlayer>();
        if (musicPlayer)
        {
            musicPlayer.SetSound(soundSlider.value);
        }
        else
        {
            Debug.LogWarning("No music player found");
        }
    }

    public void SaveAndExit()
    {
        PlayerPrefsManager.SetSound(soundSlider.value);
        FindObjectOfType<SceneLoader>().LoadStartScene();
    }
}
