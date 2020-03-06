using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeColour : MonoBehaviour {

	private int RandomColor;

	private Vector3 origine;

	void Start () {

		origine = transform.position ;

		RandomColor = Random.Range(1, 4);
		if (RandomColor==1){
			this.GetComponent<Renderer>().material.color = Color.red;
		}
		if (RandomColor==2){
			this.GetComponent<Renderer>().material.color = Color.green;
		}
		if (RandomColor==3){
			this.GetComponent<Renderer>().material.color = Color.blue;
		}
		
	}
	
	// Update is called once per frame
	void Update () {

	}

	void OnCollisionEnter(Collision theCollision){
		
		if(theCollision.gameObject.name == "Table_red"){
			StopCoroutine("CountDown1");
			StopCoroutine("CountDown2");
			StopCoroutine("CountDown3");
			StartCoroutine("CountDown1");	
		}

		if(theCollision.gameObject.name == "Table_green"){
			StopCoroutine("CountDown1");
			StopCoroutine("CountDown2");
			StopCoroutine("CountDown3");
			StartCoroutine("CountDown2");
		}

		if(theCollision.gameObject.name == "Table_blue"){
			StopCoroutine("CountDown1");
			StopCoroutine("CountDown2");
			StopCoroutine("CountDown3");
			StartCoroutine("CountDown3");
		}
	}

	public void changecolour(){
		RandomColor = Random.Range(1, 4);
        if (RandomColor==1){
			this.GetComponent<Renderer>().material.color = Color.red;
		}
		if (RandomColor==2){
			this.GetComponent<Renderer>().material.color = Color.green;
		}
		if (RandomColor==3){
			this.GetComponent<Renderer>().material.color = Color.blue;
		}
    }

	IEnumerator CountDown1()
	{
	    yield return new WaitForSeconds(0.3f);
	    this.transform.position = origine;
		RandomColor = Random.Range(1, 4);
		if (RandomColor==1){
			this.GetComponent<Renderer>().material.color = Color.red;
		}
		if (RandomColor==2){
			this.GetComponent<Renderer>().material.color = Color.green;
		}
		if (RandomColor==3){
			this.GetComponent<Renderer>().material.color = Color.blue;
		}
	}

	IEnumerator CountDown2()
	{
	    yield return new WaitForSeconds(0.3f);
	    this.transform.position = origine;
		RandomColor = Random.Range(1, 4);
		if (RandomColor==1){
			this.GetComponent<Renderer>().material.color = Color.red;
		}
		if (RandomColor==2){
			this.GetComponent<Renderer>().material.color = Color.green;
		}
		if (RandomColor==3){
			this.GetComponent<Renderer>().material.color = Color.blue;
		}
	}

	IEnumerator CountDown3()
	{
	    yield return new WaitForSeconds(0.3f);
	    this.transform.position = origine;
		RandomColor = Random.Range(1, 4);
		if (RandomColor==1){
			this.GetComponent<Renderer>().material.color = Color.red;
		}
		if (RandomColor==2){
			this.GetComponent<Renderer>().material.color = Color.green;
		}
		if (RandomColor==3){
			this.GetComponent<Renderer>().material.color = Color.blue;
		}
	}
}
