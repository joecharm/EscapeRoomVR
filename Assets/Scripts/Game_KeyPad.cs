using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Game_KeyPad : MonoBehaviour
{
    // The current required key input, defaults to 3
    private int requiredKey = 3;
    // a boolean to control if the player can hit the button
    private bool canHit = true;
    // reference to the main game logic file, used to trigger the next puzzles in the changeKey method
    public GameLogic gameLogic;


    // checkKey will see if the key input number matches what is required
    public string checkKey(int passedKey)
    {
        if(passedKey == requiredKey)
        {
            // if the inputted key matches required then run the changeKey method and return success
            changeKey();
            return "success";
        }
        else
        {
            // incorrect key input returns erorr - flashed button red
            return "error";
        }
    }

    // this method (method not a function as this is OOP, extending a monobehaviour class) controls the next required input
    private void changeKey()
    {
        // this switch statement contains case's which control what to do when a player enters the correct key
        switch(requiredKey)
        {
            case 3:
                // player entered first correct key.
                // play the second clue video and set the next required key to 2.
                requiredKey = 2;
                gameLogic.activateSecondPuzzle();
                break;
            case 2:
                // player enters the correct key
                // play the third clue video and set the next required key to 8
                requiredKey = 8;
                gameLogic.activateThirdPuzzle();
                break;
            case 8:
                // player enters the correct key
                // play the fourth clue video and set the next required key to 7.
                requiredKey = 7;
                gameLogic.activateFourthPuzzle();
                break;
            case 7:
                // success run the game complete method
                gameLogic.gameComplete();
                break;
        }

    }

}
