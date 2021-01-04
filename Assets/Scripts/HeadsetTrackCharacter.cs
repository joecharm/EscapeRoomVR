using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HeadsetTrackCharacter : MonoBehaviour
{
    // the VR camera in the XR rig
    public Camera mainVRCamera;
    // A character controller component attached to the XR rig
    public CharacterController controller;
    // private X & Y properties used to store the position of the camera X & Y
    private float x, z;
    // a public variable defining the height of the player, can be set by the dev in unity
    public float characterHeight;

  

    // Update is called once per frame
    void Update()
    {
        // assign the X and Y values from the camera to the declared variables
        x = mainVRCamera.transform.localPosition.x;
        z = mainVRCamera.transform.localPosition.z;
        // get the character controller from the specified input above
        controller = GetComponent<CharacterController>();
        // update the centre of the character controller to the main camera so the controller follows the VR camera
        controller.center = new Vector3(x, characterHeight, z);
        
    }
}
