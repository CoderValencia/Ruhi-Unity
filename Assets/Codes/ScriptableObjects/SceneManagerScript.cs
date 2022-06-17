using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneManagerScript : MonoBehaviour
{
    public void OpeningNarration()
    {
        SceneManager.LoadScene("OpeningNarration");
    }
    public void Opening()
    {
        SceneManager.LoadScene("OpeningCutscene");
    }
    public void Opening2()
    {
        SceneManager.LoadScene("Opening2");
    }
    public void Village()
    {
        SceneManager.LoadScene("VillageOpening");
    }
   public void ReturnToHut()
    {
        SceneManager.LoadScene("ReturnToHut");
    }
    public void AwakenScene()
    {
        SceneManager.LoadScene("Awaken2");
    }
    public void BlackScreen1()
    {
        SceneManager.LoadScene("BlackScreen1");
    }
    public void Puzzles()
    {
        SceneManager.LoadScene("Piuzzle 3");
    }
    public void diamondRoom()
    {
        SceneManager.LoadScene("DiamonRoom");
    }
    public void BlackScreen2()
    {
        SceneManager.LoadScene("BlackScreen2");
    }
    public void  EndGame()
    {
        SceneManager.LoadScene("EndGame");
    }
}
