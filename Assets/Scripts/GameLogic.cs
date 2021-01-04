using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameLogic : MonoBehaviour
{
    // a float to track time played
    private float playerTime;
    private bool gameRunning = false;
    // Material which has the video texture (render texture) asigned to base map.
    [SerializeField] private Material Clue1, Clue2, Clue3, Clue4, VideoSuccessMaterial;
    // The first clue video to play
    [SerializeField] private GameObject Video1, Video2, Video3, Video4, VideoSuccess, MainDoor;
    // Puzzle 4 Logic Script
    public Puzzle4_Controller puzzle4; 

    // on game start 
    private void Start()
    {
        // Play the introductory video on the screen
        // Switch out the material on the screen to Clue1 and activate the Clue video
        GetComponent<Renderer>().material = Clue1;
        // Set the video to active
        Video1.SetActive(true);

        // set game running to true
        gameRunning = true;
    }

    private void Update()
    {
        // Record time since the user started playing the game
        playerTime = Time.realtimeSinceStartup;
        
    }

    // activates the second puzzle to play
    public void activateSecondPuzzle()
    {
        // Turn off the first clue video
        Video1.SetActive(false);

        // Switch out the material on the screen to Clue2 and activate the Clue video
        GetComponent<Renderer>().material = Clue2;

        // Set the video to active
        Video2.SetActive(true);
    }

    // activates the third puzzle to play
    public void activateThirdPuzzle()
    {
        // Turn off the second clue video
        Video2.SetActive(false);

        // Switch out the material on the screen to Clue3 and activate the Clue video
        GetComponent<Renderer>().material = Clue3;

        // Set the video to active
        Video3.SetActive(true);
    }

    // activates the fourth puzzle to play
    public void activateFourthPuzzle()
    {
        // Turn off the third clue video
        Video3.SetActive(false);

        // Switch out the material on the screen to Clue4 and activate the Clue video
        GetComponent<Renderer>().material = Clue4;

        // Set the video to active
        Video4.SetActive(true);

        // spawn a red button next to the door, this button will aloow the user to open the door to the balcony
        puzzle4.spawnRedButton();
    }

    // activate game complete
    public void gameComplete()
    {
        // turn off the fourth video
        Video4.SetActive(false);

        // Switch out the material on the screen to the success video
        GetComponent<Renderer>().material = VideoSuccessMaterial;

        // set the success video active
        VideoSuccess.SetActive(true);

        // open the door
        Animator mainDoorAnimation = MainDoor.GetComponent<Animator>();
        mainDoorAnimation.PlayInFixedTime("LiftDoorOpen");
    }
}
