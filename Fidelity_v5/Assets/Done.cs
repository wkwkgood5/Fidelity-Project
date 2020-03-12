using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Done : MonoBehaviour {

	
	// Update is called once per frame
	void Update () {

		if (Input.GetKeyDown(KeyCode.G))
		{
			SceneManager.LoadScene(0);
			print("G key was pressed");
		};
	}
}
