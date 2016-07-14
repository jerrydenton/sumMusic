# sumMusic v1.1

## OVERVIEW
sumMusic is a simple, lightweight, and open-source, Unity Asset for adding background music to your 
game. Drag-and-drop prefabs into your scene and instantly have background music, with a button for 
players to toggle it on and off. Includes option to save status to PlayerPrefs. Uses the native Unity UI so you 
can easily change the look and feel of everything right in the editor. Licensed under MIT and CC0 so there 
are no worries on usage rights.

For an advanced music player with tons of options you will want to look elsewhere. This is for a project that 
just needs... some music. (ba-dum-tss)

- Project Homepage: http://www.cyberlogical.com/summusic/
- Unity Asset Store: http://u3d.as/tJj
- Repository: https://github.com/jerrydenton/sumMusic


## USAGE
- Create a Canvas if there is not one in your scene already. [Create > UI > Canvas] in Hierarchy
- Copy the preferred sumMusic prefab(s) into your Canvas. (See notes below to select the best option)
- Your game now has music and a simple way to mute it! Try it out.
- (Optional) Adjust position on screen in the RectTransform component
- (Optional) Select a different song from the 'Audio' folder and attach it to the AudioSource on the prefabs

### Simple prefab notes
This is the best choice for single scene games or simple mobile games. Just copy the 'sumMusicSimple' 
prefab into the gameplay scene and adjust to your preferences.

### Advanced prefabs notes
This option works best if you will have multiple scenes and/or an options menu. Copy the 
'sumMusicController' prefab into the root of your introduction scene's hierarchy. Next, copy the 
'sumMusicMenuButton' prefab into your menu's UI element. You can reuse the button in multiple scenes 
if needed. Note that choosing to use more than one of these buttons per scene will require customization 
on your part.

**Check 'SampleScene' for usage examples**

## OPTIONS
The following options are available on the 'sumMusic' component on each prefab
- *Start On* : Determine default state [bool, def: true]
- *Save Settings* : Save state to PlayerPrefs [bool, def: true]
- *Keep Alive* : Keeps game object alive between scenes [bool, def: varies]
- *Music On Sprite* : Sprite to display when music is on (Additional sprites included in 'Icons' folder)
- *Music Off Sprite* : Sprite to display when music is off (Additional sprites included in 'Icons' folder)
- *Image* : Just a link. No need to change this one.

## EXAMPLE
'SampleScene' contains an example of the prefabs in action.

## PROJECT LICENSE
- The MIT License (MIT) - https://opensource.org/licenses/MIT
- Copyright (c) 2016 Jerry Denton

## OTHER ASSETS
- Icons and Audio assets are from the awesome CC0 collection by asset creator Kenney - https://kenney.itch.io/
- License (Creative Commons Zero, CC0) - http://creativecommons.org/publicdomain/zero/1.0/

## CREATED BY
- Jerry Denton
- http://www.cyberlogical.com

### CHANGE NOTES
----------------------------------------------------------

- v 1.1
- Added 'Keep Alive' feature to keep object active between scenes
- Removed 'sumMusicMenu' prefab
- Added 'Advanced' prefab folder containing new prefabs
- Revamped sample scene

----------------------------------------------------------

- v 1.0.1
- Minor code refactoring
- Simple prefab Button setting changed to *Navigation:None*

----------------------------------------------------------

- v 1.0
- Initial version

----------------------------------------------------------
