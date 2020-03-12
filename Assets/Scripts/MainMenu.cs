using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour {



    //void Awake() 
    //{
    //    
    //}
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.A))
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
            print("A key was pressed");
        }

        if (Input.GetKeyDown(KeyCode.S))
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 4);
            print("S key was pressed");
        }

        if (Input.GetKeyDown(KeyCode.D))
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 7);
            print("D key was pressed");
        }




    }

    //public void PlayGameXbox ()
        //{
        //   
        //}

    //public void PlayGameVive()
        //{
        //SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 3);
        //}

    //public void PlayGameLeap()
    //{
        //SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 5);
    //}
}
