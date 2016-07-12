using UnityEngine;
using System.Collections;

public class SumMusicButton : MonoBehaviour {

    SumMusic obj;

    /// <summary>Public accessor to toggle music from buttons</summary>
    public void ToggleMusic() {
        if (obj != null) {
            obj.ToggleMusic();
        }
        else {
            obj = GameObject.Find("sumMusicController").GetComponent<SumMusic>();
            if (obj != null) {
                obj.ToggleMusic();
            }
            else {
                Debug.LogError("Required game object 'sumMusicController' is missing");
            }
        }
    }
}
