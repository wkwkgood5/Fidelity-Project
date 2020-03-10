using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class FBButtons : MonoBehaviour {

    public void GoBack()
    {
        SceneManager.LoadScene(0);
    }

    public void GoForward()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
}
