using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class MainMenuController : MonoBehaviour
{
    // Start is called before the first frame update
    public void StartGame()
    {
        SceneManager.LoadScene("Puzzle1");
    }
  

    public void Puzzle1()
    {
        SceneManager.LoadScene("Puzzle1");
    }
    public void Menu()
    {
        SceneManager.LoadScene("MainMenu");
    }
    public void Quit()
    {
        Debug.Log("Quit Game");
        if (Application.platform == RuntimePlatform.WebGLPlayer || Application.platform == RuntimePlatform.WindowsEditor)
        {
            SceneManager.LoadScene("EndGame");
        }
        else
        {
            Application.Quit();
        }
    }
}
