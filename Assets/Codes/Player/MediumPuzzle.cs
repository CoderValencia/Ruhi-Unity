using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MediumPuzzle : MonoBehaviour
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
    public GameObject floorTwo;
    public GameObject floorThree;
    public GameObject floorFourP1;
    public GameObject floorFourP2;
    public GameObject floorFive;
    public GameObject door;


    public GameObject player;
    public GameObject exit;

    public GameObject platformGap1;
    public GameObject platformGap2;
    public GameObject platformGap3;
    public GameObject platformGap4P1;
    public GameObject platformGap4P2;
    public GameObject platformGap5;

    


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
        floorTwo.SetActive(false);
        floorThree.SetActive(false);
        floorFourP1.SetActive(false);
        floorFourP2.SetActive(false);
        floorFive.SetActive(false);
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
                floorTwo.SetActive(true);
                platformGap2.SetActive(false);
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
                floorFourP1.SetActive(true);
                floorFourP2.SetActive(true);
                platformGap4P1.SetActive(false);
                platformGap4P2.SetActive(false);
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
                door.SetActive(false);
                exit.SetActive(true);

            }
        }

    }
}
