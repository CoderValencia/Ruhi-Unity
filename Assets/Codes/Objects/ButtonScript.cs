using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ButtonScript : MonoBehaviour
{
    // Start is called before the first frame update

    GameObject greenButton;
    GameObject redButton;
    bool btnChecked;
    GameObject interactText;

    void Start()
    {
        greenButton = GameObject.Find("Green");
        redButton = GameObject.Find("Red");
        greenButton.SetActive(false);
        btnChecked = false;
        interactText = GameObject.Find("InteractText");
        interactText.SetActive(false);
        
    }
    private void Update()
    {
        if (Input.GetKey(KeyCode.F) && redButton.activeInHierarchy == true && interactText.activeInHierarchy == true)
        {
            redButton.SetActive(false);
            greenButton.SetActive(true);
            btnChecked = true;
        }
    }
    private void OnCollisionStay2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "button")
        {
            interactText.SetActive(true);
        }
    }
    private void OnCollisionExit2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "button")
        {
            interactText.SetActive(false);
        }
    }

}



