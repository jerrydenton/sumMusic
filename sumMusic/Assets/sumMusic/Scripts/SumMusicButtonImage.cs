using UnityEngine;
using System.Collections;
using UnityEngine.UI;

/// <remarks>
/// Since the controller may have been loaded in another scene this 
/// script will link this image component to the sumMusicController 
/// object and ensure the the proper image sprite is set.
/// </remarks>
[RequireComponent(typeof(Image))]
public class SumMusicButtonImage : MonoBehaviour {

    SumMusic obj;
    Image img;

    public void OnEnable() {
        // Link controller if we don't have it already
        if (obj == null) {
            obj = GameObject.Find("sumMusicController").GetComponent<SumMusic>();
            // Log error and exit if the controller is still missing
            if (obj == null) {
                Debug.LogError("Required game object 'sumMusicController' is missing");
                return;
            }
        }
        img = GetComponent<Image>(); // Link this game object's image to the controller
        obj.image = img;
        // Set appropriate sprite
        img.sprite = obj.MusicOn ? obj.musicOnSprite : obj.musicOffSprite;
    }

}
