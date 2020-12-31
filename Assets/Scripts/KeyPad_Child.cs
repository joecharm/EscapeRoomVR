using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeyPad_Child : MonoBehaviour
{
    // KeyPad Reference ID 0-9.
    public int keyPadRef;
    // The master script on the keypad object
    public Game_KeyPad masterKeyPad;
    // Two materials for error and success, to be flash on the buttons
    public Material errorMaterial, successMaterial;
    // the default material which has been assigned on the button
    private Material defaultMaterial;
   
    // on trigger of the key
    private void OnTriggerEnter(Collider other)
    {
            //get default material on the button
            defaultMaterial = GetComponent<MeshRenderer>().material;

            // play the animation of the button press
            Animator anim = GetComponent<Animator>();
            anim.PlayInFixedTime("Key");

            // create a string of returned state, evauating to 'Success' or 'Failure' if this number is correct
            string returnedState = masterKeyPad.checkKey(keyPadRef);

            // Run the returnedState variable through the Material Change coroutine
            StartCoroutine(materialChange(returnedState));

    }

    // a coroutine to run depending if the button press was a Success or Failure (the correct number in sequence)
    IEnumerator materialChange(string state)
    {
        // if success run this
        if(state == "success")
        {
            // change the current material to green and return null for the coroutine
            GetComponent<MeshRenderer>().material = successMaterial;
            yield return null;
        }
        // if state is error and the current material is not already success
        else if(state == "error" && GetComponent<MeshRenderer>().material.name != "Key_Success")
        {
            // change the material to error
            GetComponent<MeshRenderer>().material = errorMaterial;
            // wait for 1 second (holding the red colour)
            yield return new WaitForSeconds(1.0f);
            // Set the colour back to the original material
            GetComponent<MeshRenderer>().material = defaultMaterial;
        }
        else
        {
            // if no state button is read then print an error to the console and return null for the coroutine
            Debug.LogError("Incorrect Button State");
            yield return null;
        }

    }





}
