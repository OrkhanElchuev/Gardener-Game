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
        currentSceneIndex = SceneManager.GetActiveScene().buildIndex;
        // Wait till the background sound is finished(5 seconds)
        if (currentSceneIndex == 0)
        {
            StartCoroutine(DelayLoadScene());
        }
    }

    // Update is called once per frame
    void Update()
    {

    }

    // Delay
    IEnumerator DelayLoadScene()
    {
        yield return new WaitForSeconds(loadSceneDelayTime);
        LoadNextScene();
    }

    public void LoadNextScene()
    {
        SceneManager.LoadScene(currentSceneIndex + 1);
    }
}
