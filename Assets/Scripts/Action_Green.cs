using UnityEngine;
using System.Collections;

public class Action_Green : MonoBehaviour {

    public Transform FPStransform;

    public Transform Greentabletransform;

    public Transform Populate;


    private Vector3 offset_populate;
    private Vector3 offset_greentable;
    private Vector3 origine;

    private bool ifgrab = false;

    private HapticsManager hapticsManager;
    
    void Start()
    {
	    origine = transform.position;
    }

    private void Awake()
    {
	    var hapticsManagerGO = GameObject.FindWithTag("HapticsManager");
	    if (hapticsManagerGO)
		    hapticsManager = hapticsManagerGO.GetComponent<HapticsManager>();
	    else
		    Debug.LogWarning("Haptics Manager missing in scene");
    }
    
    void Update()
    {
        offset_populate = transform.position - FPStransform.position;
        offset_greentable = FPStransform.position - Greentabletransform.position;
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
                hapticsManager.Vibrate(1.0f, 0.3f);
            } 
        }

        if (offset_greentable.x < 2 
        	& offset_greentable.x > -2 
        	& offset_greentable.y < 2 
        	& offset_greentable.y > -2 
        	& offset_greentable.z < 2 
        	& offset_greentable.z > -2
        	& ifgrab == true){
            if (Input.GetKeyDown(KeyCode.JoystickButton0)){
                transform.position = origine + new Vector3 (1.5f,-0.2f,2.0f);
                this.GetComponent<Rigidbody>().isKinematic = false;
                transform.SetParent(Populate);
                ifgrab = false;
                hapticsManager.Vibrate(1.0f, 0.3f);
            }   
        }
    }
}