using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PauseMenu : MonoBehaviour
{
    public static bool GameIsPaused = false;
    [SerializeField] GameObject pauseMenuCanvas;
    [SerializeField] SceneLoader sceneLoader;

    private void Start()
    {
        pauseMenuCanvas.SetActive(false);
    }

    public void ResumeGame()
    {
        // Make pause canvas inactive
        pauseMenuCanvas.SetActive(false);
        // Resume the game flow
        Time.timeScale = 1.0f;
        GameIsPaused = false;
    }

    public void PauseGame()
    {
        pauseMenuCanvas.SetActive(true);
        // Freeze the game flow
        Time.timeScale = 0f;
        GameIsPaused = true;
    }
}

