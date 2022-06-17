using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TimelineManager : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }
    void OnEnable()
    {
        if(SceneManager.GetActiveScene().name == "OpeningCutscene")
        {
            SceneManager.LoadScene("VillageOpening");
        }
        // Only specifying the sceneName or sceneBuildIndex will load the Scene with the Single mode
        
    }

}
