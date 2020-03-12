using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Action_Random : MonoBehaviour {

    public Transform FPStransform;

    public Transform Redtabletransform;
    public Transform Greentabletransform;
    public Transform Bluetabletransform;

    public Transform Populate;

    private Vector3 offset_populate;
    private Vector3 offset_redtable;
    private Vector3 offset_greentable;
    private Vector3 offset_bluetable;
    private Vector3 origine;

    public GameObject Randomtransform;
    //private GameObject RandomCube;

    private bool ifgrab = false;

	void Start()
	{
        origine = transform.position ;
        //Randomtransform.SetActive(false);
        //RandomCube = transform.Find ("Cube_random").gameObject;
	}
    void Update()
    {
        offset_populate = transform.position - FPStransform.position;
        offset_redtable = FPStransform.position - Redtabletransform.position;
        offset_greentable = FPStransform.position - Greentabletransform.position;
        offset_bluetable = FPStransform.position - Bluetabletransform.position;
        if (offset_populate.x < 2 
            & offset_populate.x > -2 
            & offset_populate.y < 1 
            & offset_populate.y > -1 
            & offset_populate.z < 1 
            & offset_populate.z > -1
            & ifgrab == false){
            if (Input.GetKeyDown(KeyCode.JoystickButton1)){
            //if (Input.GetKeyDown(KeyCode.Z)){
                transform.SetParent(FPStransform, true);
                transform.position = FPStransform.position + new Vector3 (-0.4f,0.2f,0.4f);
                this.GetComponent<Rigidbody>().isKinematic = true;
                ifgrab = true;
            } 
        }

        if (offset_redtable.x < 2 
            & offset_redtable.x > -2
            & offset_redtable.y < 2 
            & offset_redtable.y > -2 
            & offset_redtable.z < 2 
            & offset_redtable.z > -2
            & ifgrab == true
            & this.GetComponent<Renderer>().material.color == Color.red){
            if (Input.GetKeyDown(KeyCode.JoystickButton0)){
            //if (Input.GetKeyDown(KeyCode.X)){
                transform.position = origine + new Vector3 (1.1f,-0.2f,-2.50f);
                this.GetComponent<Rigidbody>().isKinematic = false;
                transform.SetParent(Populate);
                ifgrab = false;
            }   
        }

        if (offset_greentable.x < 2 
            & offset_greentable.x > -2 
            & offset_greentable.y < 2 
            & offset_greentable.y > -2 
            & offset_greentable.z < 2 
            & offset_greentable.z > -2
            & ifgrab == true
            & this.GetComponent<Renderer>().material.color == Color.green){
            if (Input.GetKeyDown(KeyCode.JoystickButton0)){
            //if (Input.GetKeyDown(KeyCode.X)){
                transform.position = origine + new Vector3 (1.5f,-0.2f,2.0f);
                this.GetComponent<Rigidbody>().isKinematic = false;
                transform.SetParent(Populate);
                ifgrab = false;  
            }   
        }

        if (offset_bluetable.x < 2 
            & offset_bluetable.x > -2 
            & offset_bluetable.y < 2 
            & offset_bluetable.y > -2 
            & offset_bluetable.z < 2 
            & offset_bluetable.z > -2
            & ifgrab == true
            & this.GetComponent<Renderer>().material.color == Color.blue){
            if (Input.GetKeyDown(KeyCode.JoystickButton0)){
            //if (Input.GetKeyDown(KeyCode.X)){
                transform.position = origine + new Vector3 (2.75f,-0.2f,0.0f);
                this.GetComponent<Rigidbody>().isKinematic = false;
                transform.SetParent(Populate);
                ifgrab = false;
            }   
        }
    }
}