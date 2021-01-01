using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Puzzle3_Controller : MonoBehaviour
{
    // create a range property of 0-5 which is the blur intensity
    [Range(0,6)]
    [SerializeField] public int currentBlurLevel = 4;
    // access the sprite renderer from the game object in Unity containing the sprite
    public SpriteRenderer spriteRender;
    // declare publicly so we can assign sprites at different blur levels to the script
    public Sprite blur6, blur5, blur4, blur3, blur2, blur1, blur0;

    // initiate text_display as a TMP object
    public TMPro.TMP_Text text_display;

    private void Start()
    {
        changeBlur();
    }


    public void changeBlur()
    {
        switch (currentBlurLevel)
        {
            case 6:
                spriteRender.sprite = blur6;
                text_display.text = "6";
                break;
            case 5:
                spriteRender.sprite = blur5;
                text_display.text = "5";
                break;
            case 4:
                spriteRender.sprite = blur4;
                text_display.text = "4";
                break;
            case 3:
                spriteRender.sprite = blur3;
                text_display.text = "3";
                break;
            case 2:
                spriteRender.sprite = blur2;
                text_display.text = "2";
                break;
            case 1:
                spriteRender.sprite = blur1;
                text_display.text = "1";
                break;
            case 0:
                spriteRender.sprite = blur0;
                text_display.text = "0";
                break;
        }
    }

}
