using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TalkToNPCDialogueBox : MonoBehaviour
{
    GameObject prompt;
    GameObject dBox;
    // Start is called before the first frame update
    void Start()
    {
        prompt = GameObject.Find("DialoguePrompt");
        dBox = GameObject.Find("DialogueBoxImg");
        dBox.SetActive(false);
        prompt.SetActive(false);
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && prompt.activeInHierarchy == true) 
        {
            dBox.SetActive(true);
        }
    }
    private void OnCollisionStay2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "NPC")
        {

            prompt.SetActive(true);
        }
    }

    private void OnCollisionExit2D(Collision2D collision)
    {
        prompt.SetActive(false);
    }
}
