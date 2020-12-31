using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameStartLogic : MonoBehaviour
{
    // a float to track time played
    private float playerTime;
    private bool gameRunning = false;
    // Material which has the video texture (render texture) asigned to base map.
    [SerializeField] private Material Clue1;
    // The first clue video to play
    [SerializeField] private GameObject Video1;

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
}
