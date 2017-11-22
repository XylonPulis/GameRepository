using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelManager : MonoBehaviour {

    public void LoadNewScene(string sceneName)
    {
        Brick.breakableCount = 0;
        SceneManager.LoadScene(sceneName);
    }

    public void QuitUnity()
    {
        UnityEditor.EditorApplication.isPlaying = false;
    }

    public void LoadNextScene()
    {   
        Brick.breakableCount = 0;
        int currentScene = SceneManager.GetActiveScene().buildIndex;
        currentScene++;
        SceneManager.LoadScene(currentScene);
    }
}
