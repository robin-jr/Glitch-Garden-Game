using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Level : MonoBehaviour
{
    public void LoadStartScreen()
    {
        SceneManager.LoadScene(1);
    }
    public void LoadSplashScreen()
    {
        SceneManager.LoadScene(0);
    }
    public void LoadGameOverScreen()
    {
        SceneManager.LoadScene("Game Over Screen");
    }
    public void LoadGame()
    {
        SceneManager.LoadScene(2);
    }
    public void LoadOptionsScreen()
    {
        SceneManager.LoadScene("Options Screen");
    }
    public void QuitGame()
    {
        Application.Quit();
    }
}
