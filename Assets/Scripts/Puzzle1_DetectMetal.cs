using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Puzzle1_DetectMetal : MonoBehaviour
{
    // Gameobject of the particles, used later to access the particle component
    public GameObject particles;

    // Set the default flame colour, assigned on script start (RGB, default of A is 1)
    public Color defaultFlameColour = new Color(0.5188679f, 0.3203758f, 0.1270914f);

    // default colour for Teal
    public Color red, purple, white, blue, green;


    // Start is called before the first frame update
    void Start()
    {
        // Access the particle system on the supplied game object
        ParticleSystem.MainModule main = particles.GetComponent<ParticleSystem>().main;

        // Set the start colour of the flame
        main.startColor = defaultFlameColour;

        // set the shader tint colour to the flame colour to match
        particles.GetComponent<Renderer>().material.SetColor("_TintColor", defaultFlameColour);

        //temporary bypass bc public setting default to blk and wnt update
        red = new Color(0.7f, 0f, 0f);
        
    }

    void OnTriggerEnter(Collider other)
    {
        //Check for a match with the specified name on collision
        if (other.gameObject.name == "Red")
        {
            // sets the material shader tint to the colour defined for the metal
            particles.GetComponent<Renderer>().material.SetColor("_TintColor", red );
        }

        //Check for a match with the specified name on collision
        if (other.gameObject.name == "Purple")
        {
            // sets the material shader tint to the colour defined for the metal
            particles.GetComponent<Renderer>().material.SetColor("_TintColor", purple);
        }

        //Check for a match with the specified name on collision
        if (other.gameObject.name == "Blue")
        {
            // sets the material shader tint to the colour defined for the metal
            particles.GetComponent<Renderer>().material.SetColor("_TintColor", blue);
        }

        //Check for a match with the specified name on collision
        if (other.gameObject.name == "White")
        {
            // sets the material shader tint to the colour defined for the metal
            particles.GetComponent<Renderer>().material.SetColor("_TintColor", white);
        }

        //Check for a match with the specified name on collision
        if (other.gameObject.name == "Green")
        {
            // sets the material shader tint to the colour defined for the metal
            particles.GetComponent<Renderer>().material.SetColor("_TintColor", green);
        }

    }

    private void OnTriggerExit(Collider other)
    {
        ParticleSystem.MainModule main = particles.GetComponent<ParticleSystem>().main;
        main.startColor = defaultFlameColour;
        particles.GetComponent<Renderer>().material.SetColor("_TintColor", defaultFlameColour);

    }
}
