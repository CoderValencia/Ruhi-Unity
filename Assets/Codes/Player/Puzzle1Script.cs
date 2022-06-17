using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Puzzle1Script : MonoBehaviour
{
    public GameObject activeButtonOne;
    public GameObject inactiveButtonOne;
    public GameObject activeButtonTwo;
    public GameObject inactiveButtonTwo;
    
    public GameObject floorOne;
    public GameObject floorTwo;

    public GameObject player;


    public GameObject platformGap1;
    public GameObject platformGap2;

    // Start is called before the first frame update
    void Start()
    {


        activeButtonOne.SetActive(false);
        activeButtonTwo.SetActive(false);
        floorOne.SetActive(false);
        floorTwo.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        CheckButtonActivation();
    }

    void CheckButtonActivation()
    {
        if (Input.GetKeyDown(KeyCode.F) )
        {
            if ((player.transform.position - inactiveButtonOne.transform.position).sqrMagnitude < 2 * 2)
            {

                inactiveButtonOne.SetActive(false);
                activeButtonOne.SetActive(true);
                floorOne.SetActive(true);
                platformGap1.SetActive(false);

            }
            if ((player.transform.position - inactiveButtonTwo.transform.position).sqrMagnitude < 2 * 2)
            {

                inactiveButtonTwo.SetActive(false);
                activeButtonTwo.SetActive(true);
                floorTwo.SetActive(true);
                platformGap2.SetActive(false);
            }
        }
      
    }
  
}
