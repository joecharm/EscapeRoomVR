using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Puzzle3_iPadBlurIncrease : MonoBehaviour
{
    // Import the controller script for the puzzle
    public Puzzle3_Controller controller;

    // on trigger of button collider
    public void OnTriggerEnter(Collider other)
    {
        // VR hand has a collider tagged 'Hand', this will run if the hand hits the button
        if (other.CompareTag("Hand"))
        {
            if(controller.currentBlurLevel <= 6)
            {
                // decrement the currentBlurLevel property by 1 on the controller script
                controller.currentBlurLevel++;
                // run the changeBlur method which will update the blur to current intensity
                controller.changeBlur();
            }

        }
    }

}
