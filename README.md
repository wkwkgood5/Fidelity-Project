# Fidelity-Project
## Update-version5-3.6 <br><br>
**Do not use Fidelity. Using Fidelity_v5** <br><br>
Unity version: Unity 2017.3.0f3 (64-bit) <br><br>
Note: You have to use Unity 2017.3.0f3 (64-bit) instead of Unity 2017.3.0f3 (64-bit) <br><br>
**What to test today** <br><br>
I fixed the leapmotion function bug. It should work well now. You can use leapmotion to grab the cube in the scene <br><br>
**The steps to test** <br>
* Download Fidelity_v5 folder and use unity 2017.3.0f3 (64-bit) to open this project
* Go to Edit->project settings->input to see if the size of `Axes` is `20`. If yes, check the last two whether they are `RightVRTriggerAxis` and `LeftVRTriggerAxis`. If not, revise `Axes` to `20` and revise the name of last two to `RightVRTriggerAxis` and `LeftVRTriggerAxis`, meanwhile, change their `Axis` to `10th axis` and `9th axis` respectively.
* Drag `main` scene and `leap` scene to `Hierarchy` window.
* run it and test each platform especially leapmotion<br><br>
**What is my next step** <br><br>
Separate to different scenes so that researchers could control the button on computer<br><br>
**The bugs may meet**<br><br>
When jump to the leap scene, the menu may disappear. But this time we only need to test whether leap can grab the cube. So practise at practise stage where there are three cubes.
