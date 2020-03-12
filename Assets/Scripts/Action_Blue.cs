using UnityEngine;
using System.Collections;

public class Action_Blue : MonoBehaviour {

    public Transform FPStransform;

    public Transform Bluetabletransform;

    public Transform Populate;

    private Vector3 offset_populate;
    private Vector3 offset_bluetable;
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
        offset_bluetable = FPStransform.position - Bluetabletransform.position;
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

        if (offset_bluetable.x < 2 
            & offset_bluetable.x > -2 
            & offset_bluetable.y < 2 
            & offset_bluetable.y > -2 
            & offset_bluetable.z < 2 
            & offset_bluetable.z > -2
            & ifgrab == true){
            if (Input.GetKeyDown(KeyCode.JoystickButton0)){
                transform.position = origine + new Vector3 (2.75f,-0.2f,-1.7f);
                this.GetComponent<Rigidbody>().isKinematic = false;
                transform.SetParent(Populate);
                ifgrab = false;
                hapticsManager.Vibrate(1.0f, 0.3f);
            }   
        }
    }
}