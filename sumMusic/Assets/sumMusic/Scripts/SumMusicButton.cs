using UnityEngine;
using System.Collections;

public class SumMusicButton : MonoBehaviour {

    SumMusic controller; // Link to controller

    /// <summary>Public accessor to toggle music from buttons</summary>
    public void ToggleMusic() {
        // Link object if we don't have it already
        if (controller == null) {
            controller = GameObject.Find("sumMusicController").GetComponent<SumMusic>();
            // Log error and exit if the controller is still missing
            if (controller == null) {
                Debug.LogError("Required game object 'sumMusicController' is missing");
                return;
            }
        }
        controller.ToggleMusic(); // Call the ToggleMusic method on the controller
    }
}
