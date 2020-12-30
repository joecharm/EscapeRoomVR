using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeyPad_Child : MonoBehaviour
{
    public int keyPadRef;
    public Game_KeyPad masterKeyPad;
    public Material errorMaterial, successMaterial;

    private Material defaultMaterial;
   

    private void OnTriggerEnter(Collider other)
    {
            //get default
            defaultMaterial = GetComponent<MeshRenderer>().material;

            Animator anim = GetComponent<Animator>();
            anim.PlayInFixedTime("Key");

            string returnedState = masterKeyPad.checkKey(keyPadRef);

            StartCoroutine(materialChange(returnedState));

    }


    IEnumerator materialChange(string state)
    {
        
        if(state == "success")
        {
            GetComponent<MeshRenderer>().material = successMaterial;
            yield return null;
        }
        else if(state == "error" && GetComponent<MeshRenderer>().material.name != "Key_Success")
        {
            GetComponent<MeshRenderer>().material = errorMaterial;
            yield return new WaitForSeconds(1.0f);
            GetComponent<MeshRenderer>().material = defaultMaterial;
        }
        else
        {
            Debug.LogError("Incorrect Button State");
            yield return null;
        }

    }





}
