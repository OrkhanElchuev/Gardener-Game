using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneLoader : MonoBehaviour
{
    private int currentSceneIndex;
    private int loadSceneDelayTime = 5;

    void Start()
    {
        // Set the current scene index to active scene index
        currentSceneIndex = SceneManager.GetActiveScene().buildIndex;
        // Wait till the background sound is finished(5 seconds)
        if (currentSceneIndex == 0)
        {
            StartCoroutine(DelayLoadScene());
        }
    }

    // Delay Scene loading
    IEnumerator DelayLoadScene()
    {
        yield return new WaitForSeconds(loadSceneDelayTime);
        LoadNextScene();
    }

    // Load start scene
    public void LoadStartScene()
    {
        // Resume game play
        Time.timeScale = 1;
        SceneManager.LoadScene("StartScene");
    }

    // Load current scene again
    public void RestartScene()
    {
        Time.timeScale = 1;
        SceneManager.LoadScene(currentSceneIndex);
    }

    // Load next coming scene in the order 
    public void LoadNextScene()
    {
        // Resume game process
        Time.timeScale = 1;
        SceneManager.LoadScene(currentSceneIndex + 1);
    }

    // Load Options Scene
    public void LoadOptionsScene()
    {
        SceneManager.LoadScene("OptionsScene");
    }

    // Load level lose screen
    public void LoadLoseScene()
    {
        SceneManager.LoadScene("LoseScene");
    }

    // Quit the application
    public void QuitApplication()
    {
        Application.Quit();
    }
}
