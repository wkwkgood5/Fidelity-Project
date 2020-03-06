using UnityEngine;
using System.Collections;

public class Action_Red : MonoBehaviour {

    public Transform FPStransform;

    public Transform Redtabletransform;

    public Transform Populate;

    private Vector3 offset_populate;
    private Vector3 offset_redtable;
    private Vector3 origine;

    private bool ifgrab = false;

	void Start()
	{
        origine = transform.position ;

	}
    void Update()
    {
        offset_populate = transform.position - FPStransform.position;
        offset_redtable = FPStransform.position - Redtabletransform.position;
        if (offset_populate.x < 2 
            & offset_populate.x > -2 
            & offset_populate.y < 1 
            & offset_populate.y > -1 
            & offset_populate.z < 1 
            & offset_populate.z > -1
            & ifgrab == false){
            if (Input.GetKeyDown(KeyCode.JoystickButton1)){
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
            & ifgrab == true){
            if (Input.GetKeyDown(KeyCode.JoystickButton0)){
                transform.position = origine + new Vector3 (1.3f,-0.2f,-1.18f);
                this.GetComponent<Rigidbody>().isKinematic = false;
                transform.SetParent(Populate);
                ifgrab = false;
            }   
        }
    }
}