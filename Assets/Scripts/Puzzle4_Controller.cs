using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Puzzle4_Controller : MonoBehaviour
{
    public GameObject puzzle4RedButton;
    public GameObject puzzle4Answer;
    public void spawnRedButton()
    {
        puzzle4RedButton.SetActive(true);
        puzzle4Answer.SetActive(true);
    }

    
}
