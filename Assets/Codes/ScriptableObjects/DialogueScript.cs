using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DialogueScript : MonoBehaviour
{
    void EndNarration()
    {
        SceneManager.LoadScene("OpeningCutscene");
    }
}
