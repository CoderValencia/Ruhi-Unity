using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;


public class Objective : MonoBehaviour
{
    public TextMeshProUGUI objectiveTextWater;
    public TextMeshProUGUI objectiveTextHerb;
    public bool gotWater;
    public bool gotHerbs;
    public bool canCollectWater;
    public bool canCollectHerbs;


    public GameObject player;
    public GameObject water;
    public GameObject herb;
    // Start is called before the first frame update
    void Start()
    {
        objectiveTextWater.text = "Water: 0/1";
        objectiveTextHerb.text = "Herb: 0/1";

    }

    // Update is called once per frame
    void Update()
    {
   
   if (Input.GetKeyDown(KeyCode.F) && canCollectWater == true)
            {

                gotWater = true;
                objectiveTextWater.text = "Water: 1/1";
            }
 if (Input.GetKeyDown(KeyCode.F) && canCollectHerbs == true)
            {

                gotHerbs = true;
                objectiveTextHerb.text = "Herb: 1/1";
            }
        if (gotWater == true && gotHerbs == true)
        {
            objectiveTextWater.text = "Go back to your hut";
            objectiveTextHerb.text = null;
        }
    }
    void CheckCollected()
    {
        if (canCollectWater == true)
        {
            if (Input.GetKeyDown(KeyCode.F))
            {
    
                gotWater = true;
            }

                
        }
        if (canCollectHerbs == true)
        {

            gotHerbs = true;
        }
    }
    private void OnTriggerStay2D(Collider2D collision)
    {
        if(collision.name == "Exit")
        {
            if (gotWater == true && gotHerbs == true)
            {
                SceneManager.LoadScene("ReturnToHut");
            }
        }
    }
    private void OnCollisionStay2D(Collision2D collision)
    {
        if(collision.gameObject.tag == "water")
        {
            Debug.Log("Can Collect water");
             canCollectWater = true;

        }
        if (collision.gameObject.tag == "herb")
        {
            canCollectHerbs = true;

        }
    }
}

