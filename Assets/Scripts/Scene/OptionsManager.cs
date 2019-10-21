using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class OptionsManager : MonoBehaviour
{
    [SerializeField] Slider soundSlider;
    [SerializeField] float defaultSound = 0.7f;
    [SerializeField] Slider gameDifficultySlider;
    [SerializeField] float defaultDifficulty = 0f;

    void Start()
    {
        soundSlider.value = PlayerPrefsManager.GetMusicVolume();
        gameDifficultySlider.value = PlayerPrefsManager.GetGameDifficulty();
    }

    void Update()
    {
        var musicPlayer = FindObjectOfType<MusicPlayer>();
        if (musicPlayer)
        {
            musicPlayer.SetMusicVolume(soundSlider.value);
        }
        else
        {
            Debug.LogWarning("No music player found");
        }
    }

    public void SaveAndExit()
    {
        PlayerPrefsManager.SetMusicVolume(soundSlider.value);
        PlayerPrefsManager.SetGameDifficulty(gameDifficultySlider.value);
        FindObjectOfType<SceneLoader>().LoadStartScene();
    }

    public void SetDefaults()
    {
        soundSlider.value = defaultSound;
        gameDifficultySlider.value = defaultDifficulty;
    }
}
