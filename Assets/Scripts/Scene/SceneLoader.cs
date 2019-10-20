using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneLoader : MonoBehaviour
{
    int currentSceneIndex;
    private int loadSceneDelayTime = 5;

    // Start is called before the first frame update
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
        SceneManager.LoadScene("StartScene");
    }

    // Load current scene again
    public void RestartScene()
    {
        SceneManager.LoadScene(currentSceneIndex);
    }

    // Load next coming scene in the order 
    public void LoadNextScene()
    {
        SceneManager.LoadScene(currentSceneIndex + 1);
    }

    // Load level 1 (for testing purposes)
    public void LoadGamePlay()
    {
        SceneManager.LoadScene("Level1");
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
