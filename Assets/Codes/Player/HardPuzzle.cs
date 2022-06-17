using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HardPuzzle : MonoBehaviour
{
    public GameObject activeButtonOne;
    public GameObject inactiveButtonOne;
    public GameObject activeButtonTwo;
    public GameObject inactiveButtonTwo;
    public GameObject inactiveButtonThree;
    public GameObject activeButtonThree;
    public GameObject inactiveButtonFour;
    public GameObject activeButtonFour;
    public GameObject inactiveButtonFive;
    public GameObject activeButtonFive;
    public GameObject inactiveButtonDoor;
    public GameObject activeButtonDoor;

    public GameObject floorOne;
    public GameObject floorTwoP1;
    public GameObject floorTwoP2;
    public GameObject floorTwoP3;
    public GameObject floorThree;
    public GameObject floorFour;
    public GameObject floorFive;
    public GameObject floorSix;
    public GameObject door;


    public GameObject player;
    public GameObject exit;

    public GameObject platformGap1;
    public GameObject platformGap2;
    public GameObject platformGap2P1;
    public GameObject platformGap2P2;
    public GameObject platformGap3;
    public GameObject platformGap4;
    public GameObject platformGap5;
    public GameObject platformGap6;

    // Start is called before the first frame update
    void Start()
    {


        activeButtonOne.SetActive(false);
        activeButtonTwo.SetActive(false);
        activeButtonThree.SetActive(false);
        activeButtonFour.SetActive(false);
        activeButtonFour.SetActive(false);
        activeButtonFive.SetActive(false);
        activeButtonDoor.SetActive(false);
        floorOne.SetActive(false);
        floorTwoP1.SetActive(false);
        floorTwoP2.SetActive(false);
        floorTwoP3.SetActive(false);
        floorThree.SetActive(false);
        floorFour.SetActive(false);
        floorFive.SetActive(false);
        floorSix.SetActive(false);

        exit.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        CheckButtonActivation();
    }

    void CheckButtonActivation()
    {
        if (Input.GetKeyDown(KeyCode.F))
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
                floorTwoP1.SetActive(true);
                floorTwoP2.SetActive(true);
                floorTwoP3.SetActive(true);
                platformGap2.SetActive(false);
                platformGap2P1.SetActive(false);
                platformGap2P2.SetActive(false);
            }
            if ((player.transform.position - inactiveButtonThree.transform.position).sqrMagnitude < 2 * 2)
            {

                inactiveButtonThree.SetActive(false);
                activeButtonThree.SetActive(true);
                floorThree.SetActive(true);
                platformGap3.SetActive(false);
            }
            if ((player.transform.position - inactiveButtonFour.transform.position).sqrMagnitude < 2 * 2)
            {

                inactiveButtonFour.SetActive(false);
                activeButtonFour.SetActive(true);
                floorFour.SetActive(true);
                platformGap4.SetActive(false);
            }
            if ((player.transform.position - inactiveButtonFive.transform.position).sqrMagnitude < 2 * 2)
            {

                inactiveButtonFive.SetActive(false);
                activeButtonFive.SetActive(true);
                floorFive.SetActive(true);
                platformGap5.SetActive(false);
            }
           
            if ((player.transform.position - inactiveButtonDoor.transform.position).sqrMagnitude < 2 * 2)
            {
                inactiveButtonDoor.SetActive(false);
                activeButtonDoor.SetActive(true);
                floorSix.SetActive(true);
                platformGap6.SetActive(false);
                door.SetActive(false);
                exit.SetActive(true);
}
        }

    }
}
