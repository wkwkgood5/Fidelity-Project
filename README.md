# Fidelity-Project
## Update-version5-3.6 <br><br>
Unity version: Unity 2017.3.0f3 (64-bit) <br><br>
Note: You have to use Unity 2017.3.0f3 (64-bit) instead of Unity 2017.1.0p5 (64-bit) <br><br>
**What to test today** <br><br>
I fixed the leapmotion function bug. It should work well now. You can use leapmotion to grab the cube in the scene <br><br>
**The steps to test** <br>
* Download Fidelity_v5 folder and use unity 2017.3.0f3 (64-bit) to open this project
* Go to Edit->project settings->input to see if the size of `Axes` is `20`. If yes, check the last two whether they are `RightVRTriggerAxis` and `LeftVRTriggerAxis`. If not, revise `Axes` to `20` and revise the name of last two to `RightVRTriggerAxis` and `LeftVRTriggerAxis`, meanwhile, change their `Axis` to `10th axis` and `9th axis` respectively.
* Drag `main` scene and `leap` scene to `Hierarchy` window.
* run it and test each platform especially leapmotion

**What is my next step**<br><br>
Separate to different scenes so that researchers could control the button on computer<br><br>
**The bugs may meet**<br><br>
When jump to the leap scene, the menu may disappear. But this time we only need to test whether leap can grab the cube. So practise at practise stage where there are three cubes.
## Update-version5-3.9 <br><br>
I separate into three scenes and each of them was named by its controller.<br><br>
**What is my next step**<br><br>
Create a loader to load different scenes
## Update-version5-3.10 <br><br>
Created the loader, it will now load each scene. - Andrew<br><br>
Just added instruction scenes, if you load MainMenu, you will be able to play through all instruction screens and go back to the main menu with the back button, it will also load the 3 seperate scenes.<br><br>
**What is my next step**<br><br>
Transport the second set of instructions in between the split practice and testing stages, and prep ending messages. For Kang, split the practice and main testing stages into two.
## Update-version5-3.12 <br><br>
Test the gaze function.<br><br>
I created a extra white cube (just for test) in `xbox_practice` scene for testing the gaze and put it on the green table. So repeatedly look at the cube and moveaway to check if there is a log in the console window as "GazeOn"， "GazeOff".
