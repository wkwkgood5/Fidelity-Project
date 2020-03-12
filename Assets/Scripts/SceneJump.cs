using System.Collections;
using UnityEngine.UI;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneJump : MonoBehaviour{

	public void JumpToPractice(){

		SceneManager.LoadSceneAsync("XBox_practice",LoadSceneMode.Single);
		//AsyncOperation  NextScene=SceneManager.LoadSceneAsync("XBox_practice",LoadSceneMode.Additive);
	}

	public void RestartPractice(){

		//SceneManager.LoadScene ("XBox_practice");
		SceneManager.LoadSceneAsync("XBox_practice",LoadSceneMode.Single);
		//AsyncOperation  NextScene=SceneManager.LoadSceneAsync("XBox_practice",LoadSceneMode.Additive);
	}

	public void JumpToUI(){

		AsyncOperation  NextScene=SceneManager.LoadSceneAsync("UI",LoadSceneMode.Single);
	}

	public void JumpToLeap(){

		AsyncOperation  NextScene=SceneManager.LoadSceneAsync("Leap",LoadSceneMode.Single);
	}
}