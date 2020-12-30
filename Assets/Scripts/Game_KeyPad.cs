using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Game_KeyPad : MonoBehaviour
{
    private int requiredKey = 3;
    private bool canHit = true;

    public string checkKey(int passedKey)
    {
        if(passedKey == requiredKey)
        {
            changeKey();
            return "success";
        }
        else
        {
            return "error";
        }
    }

    private void changeKey()
    {
        switch(requiredKey)
        {
            case 3:
                requiredKey = 2;
                break;
            case 2:
                requiredKey = 8;
                break;
            case 8:
                requiredKey = 7;
                break;
            case 7:
                // success door open
                break;
        }

    }

}
