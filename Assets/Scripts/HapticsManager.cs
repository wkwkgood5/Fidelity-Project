using System.Collections;
using UnityEngine;
using XInputDotNetPure;

public class HapticsManager : MonoBehaviour
{
    bool playerIndexSet = false;
    PlayerIndex playerIndex;
    GamePadState state;
    GamePadState prevState;

    private bool vibrating = false;
    private float vibrateStrength;
    private float vibrateTime;

    // void Start()
    // {
        // StartCoroutine(DoVibrate(5f));
    // }
    
    void FixedUpdate()
    {
        // SetVibration should be sent in a slower rate.
        // Set vibration according to triggers
        // GamePad.SetVibration(playerIndex, state.Triggers.Left, state.Triggers.Right);

        if (vibrating)
        {
            vibrateTime -= Time.deltaTime;
            if (vibrateTime <= 0f)
            {
                vibrating = false;
                // disable vibration
                GamePad.SetVibration(playerIndex, 0f, 0f);
                return;                
            }
            // enable vibration
            GamePad.SetVibration(playerIndex, vibrateStrength, vibrateStrength);
        }
    }

    public void Vibrate(float strength, float time)
    {
        this.vibrateStrength = strength;
        this.vibrateTime = time;
        this.vibrating = true;
    }
    
    void Update()
    {
        // Find a PlayerIndex, for a single player game will find the first controller that is connected and use it
        if (!playerIndexSet || !prevState.IsConnected)
        {
            for (int i = 0; i < 4; ++i)
            {
                PlayerIndex testPlayerIndex = (PlayerIndex)i;
                GamePadState testState = GamePad.GetState(testPlayerIndex);
                if (testState.IsConnected)
                {
                    // Debug.Log(string.Format("GamePad found {0}", testPlayerIndex));
                    playerIndex = testPlayerIndex;
                    playerIndexSet = true;
                }
            }
        }
        prevState = state;
        state = GamePad.GetState(playerIndex);

        // Detect if a button was pressed this frame
        // if (prevState.Buttons.A == ButtonState.Released && state.Buttons.A == ButtonState.Pressed)

        // Detect if a button was released this frame
        // if (prevState.Buttons.A == ButtonState.Pressed && state.Buttons.A == ButtonState.Released)

        // Make the current object turn
        // transform.localRotation *= Quaternion.Euler(0.0f, state.ThumbSticks.Left.X * 25.0f * Time.deltaTime, 0.0f);
    }

    // IEnumerator DoVibrate(float startOffsetInSeconds)
    // {
    //     yield return new WaitForSeconds(startOffsetInSeconds);
    //     Handheld.Vibrate();
    // }
}