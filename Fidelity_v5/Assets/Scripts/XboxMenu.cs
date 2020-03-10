using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class XboxMenu : MonoBehaviour {

public void GoBack()
    {
        SceneManager.LoadScene(0);
    }

    public void GoForward()
    {
        SceneManager.LoadScene(2);
    }
}
