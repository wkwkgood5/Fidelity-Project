using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class FBButtons : MonoBehaviour {

    void Update() 
    {
        if (Input.GetKeyDown(KeyCode.F))
        {
            SceneManager.LoadScene(0);
            print("F key was pressed");
        }

        if (Input.GetKeyDown(KeyCode.G))
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
            print("G key was pressed");
        };

    }

    //public void GoBack()
    //{
    //   SceneManager.LoadScene(0);
    //}

    //public void GoForward()
    //{
    //    SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    //}
}
