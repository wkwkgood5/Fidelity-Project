# Fidelity-Project
## Update-version5-3.6 <br><br>
Do not use Fidelity. Using Fidelity_v5 <br><br>
Unity version: Unity 2017.3.0f3 (64-bit) <br><br>
Note: You have to use Unity 2017.3.0f3 (64-bit) instead of Unity 2017.3.0f3 (64-bit) <br><br>
What to test today <br><br>
I fixed the leapmotion function bug. It should work well now. You can use leapmotion to grab the cube in the scene <br><br>
The steps to test <br>
1. Download Fidelity_v5 folder and use unity 2017.3.0f3 (64-bit) to open this project
2. Go to Edit->project settings->input to see if the size of `Axes` is `20`. If yes, check the last two whether they are `RightVRTriggerAxis` and `LeftVRTriggerAxis`. If not, revise `Axes` to `20` and revise the name of last two to `RightVRTriggerAxis` and `LeftVRTriggerAxis`, meanwhile, change their `Axis` to `10th axis` and `9th axis` respectively.
3. Drag 'main' scene and 'leap' scene to 'Hierarchy' window.
4. run it and test each platform especially leapmotion
What is my next step <br><br>
