using UnityEngine;

public class CloseLift_EndGame : MonoBehaviour
{
    public GameObject MainDoor, finishText;
    private void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("Hand"))
        {
            // close the door behind the player - get the animator on the door
            Animator doorAnimation = MainDoor.GetComponent<Animator>();
            // play the close animation
            doorAnimation.PlayInFixedTime("LiftDoorClose");

            // Display end of game text
            finishText.SetActive(true);
        }
    }
}
