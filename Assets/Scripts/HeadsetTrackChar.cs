using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HeadsetTrackChar : MonoBehaviour
{
    public Camera mainVRCamera;
    public CharacterController controller;
    public float x, z;
    public float CharHeight;

  

    // Update is called once per frame
    void Update()
    {
        x = mainVRCamera.transform.localPosition.x;
        z = mainVRCamera.transform.localPosition.z;
        controller = GetComponent<CharacterController>();
        controller.center = new Vector3(x, CharHeight, z);
        
    }
}
