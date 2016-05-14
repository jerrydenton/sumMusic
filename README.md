# sumMusic v1.0

## OVERVIEW
Simple Unity3d prefabs for playing background music. Includes option to save status to PlayerPrefs.

## USAGE
- Create a Canvas if there is not one in your scene already. [Create > UI > Canvas] in Hierarchy
- Copy one of the sumMusic prefabs into your Canvas.
- (Optional) Adjust position on screen in the RectTransform component
- (Optional) Select a different AudioClip from the 'Audio' folder and attach it to the AudioSource on the prefabs
- During play the music will now turn on and off when the button is pressed

**Check 'SampleScene' for example of proper setup**

## OPTIONS
The sumMusic component has 2 options you may need to change.
- Start On : Determine default state [bool, def: true]
- Save Settings : Save state to PlayerPrefs [bool, def: true]

## EXAMPLE
'SampleScene' contains an example with both prefabs.

## PROJECT LICENSE
- The MIT License (MIT) - https://opensource.org/licenses/MIT
- Copyright (c) 2016 Jerry Denton

## OTHER ASSETS
- Icons and Audio assets are from the awesome CCO asset creator Kenney - https://kenney.itch.io/
- License (Creative Commons Zero, CC0) - http://creativecommons.org/publicdomain/zero/1.0/

## CREATED BY
- Jerry Denton
- http://www.cyberlogical.com

----------------------------------------------------------
CHANGE NOTES
v 1.0
- Initial version
----------------------------------------------------------
