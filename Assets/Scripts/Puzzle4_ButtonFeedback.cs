using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Puzzle4_ButtonFeedback : MonoBehaviour
{
    // Door to open
    public GameObject puzzle4Door;
    // tracking if the door has been opened
   // private bool doorTriggered = false;

    // on trigger enter of button
    private void OnTriggerEnter(Collider other)
    {
        // play animation of button press
        Animator anim = GetComponent<Animator>();
        // play the button animation
        anim.PlayInFixedTime("Puzzle4_Button");


        //if (doorTriggered == false)
       // {
            // Open the door
            Animator doorAnim = puzzle4Door.GetComponent<Animator>();
            // play the door animation
            doorAnim.PlayInFixedTime("Puzzle4_Door");

            // set door triggered to true
            //doorTriggered = true;
       // }

       

    }
}
