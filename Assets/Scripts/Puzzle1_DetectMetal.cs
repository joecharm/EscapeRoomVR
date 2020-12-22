using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Puzzle1_DetectMetal : MonoBehaviour
{
    // Gameobject of the particles, used later to access the particle component
    public GameObject particles;
    // Set the default flame colour, assigned on script start
    private Color flameColour = Color.yellow;

    // Start is called before the first frame update
    void Start()
    {
        // Access the particle system on the supplied game object
        ParticleSystem.MainModule main = particles.GetComponent<ParticleSystem>().main;
        // Set the start colour of the flame
        main.startColor = flameColour;
    }

    // Update is called once per frame
    void Update()
    {


    }

    //Detect collisions between the GameObjects with Colliders attached
    void OnCollisionEnter(Collision collision)
    {
        //Check for a match with the specified name on collision
        if (collision.gameObject.name == "Zinc")
        {
            // Access the particle system on the supplied game object
            ParticleSystem.MainModule main = particles.GetComponent<ParticleSystem>().main;
            // Set the particle colour to green
            main.startColor = Color.green;
        }
    }

    void OnCollisionExit(Collision collision)
    {
            // Access the particle system on the supplied game object
            ParticleSystem.MainModule main = particles.GetComponent<ParticleSystem>().main;
            // Set the particles back to the default flame colour set as a variable
            main.startColor = flameColour;
    }
}
