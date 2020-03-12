using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TimeCount : MonoBehaviour{
	public GameObject TimeText;
	public int TotalTime = 120;

	void Start ()
	{
	    
	}

	public void Counttime(){

		StartCoroutine(CountDown());
	}

	IEnumerator CountDown()
	{
	    while (TotalTime >=0)
	    {
	        TimeText.GetComponent<Text>().text = "Time: "+TotalTime.ToString();
	        yield return new WaitForSeconds(1);
	        TotalTime--;

	    }
	}
}