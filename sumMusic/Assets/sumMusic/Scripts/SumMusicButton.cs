using UnityEngine;
using System.Collections;

public class SumMusicButton : MonoBehaviour {

    SumMusic obj;

    /// <summary>Public accessor to toggle music from buttons</summary>
    public void ToggleMusic() {
        // Link object if we don't have it already
        if (obj == null) {
            obj = GameObject.Find("sumMusicController").GetComponent<SumMusic>();
            // Log error and exit if the controller is still missing
            if (obj == null) {
                Debug.LogError("Required game object 'sumMusicController' is missing");
                return;
            }
        }
        obj.ToggleMusic(); // Call the ToggleMusic method on the controller
    }
}
