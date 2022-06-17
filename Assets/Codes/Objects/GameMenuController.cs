using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameMenuController : MonoBehaviour
{
   public GameObject pMenu;
    // Start is called before the first frame update
    void Start()
    {
        pMenu = GameObject.Find("PausedMenu");
     
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.P))
        {
            Time.timeScale = 0;
            pMenu.SetActive(true);

        }
    }

    public void Resume()
    {
        Time.timeScale = 1;
        pMenu.SetActive(false);
    }

    
}
