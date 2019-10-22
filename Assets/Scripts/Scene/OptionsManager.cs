using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class OptionsManager : MonoBehaviour
{
    [SerializeField] Slider musicVolumeSlider;
    [SerializeField] float defaultSound = 0.5f;
    [SerializeField] Slider gameDifficultySlider;
    [SerializeField] float defaultDifficulty = 0f;

    void Start()
    {
        SetCurrentValuesOfSliders();
    }

    void Update()
    {
        MusicPlayer musicPlayer = FindObjectOfType<MusicPlayer>();
        if (musicPlayer)
        {
            musicPlayer.SetMusicVolume(musicVolumeSlider.value);
        }
        else
        {
            Debug.LogWarning("No music player found");
        }
    }

    private void SetCurrentValuesOfSliders()
    {
        musicVolumeSlider.value = PlayerPrefsManager.GetMusicVolume();
        gameDifficultySlider.value = PlayerPrefsManager.GetGameDifficulty();
    }

    private void SetDefaults()
    {
        musicVolumeSlider.value = defaultSound;
        gameDifficultySlider.value = defaultDifficulty;
    }

    // Store relevant values in player preferences
    public void SaveAndExit()
    {
        PlayerPrefsManager.SetMusicVolume(musicVolumeSlider.value);
        PlayerPrefsManager.SetGameDifficulty(gameDifficultySlider.value);
        FindObjectOfType<SceneLoader>().LoadStartScene();
    }
}
