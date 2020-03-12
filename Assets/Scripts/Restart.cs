using UnityEngine;
using System.Collections;

public class Restart : MonoBehaviour {

    public Transform Redtransform;
    public Transform Greentransform;
    public Transform Bluetransform;
    public Transform Randomtransform;

    private Vector3 Redorigine;
    private Vector3 Greenorigine;
    private Vector3 Blueorigine;
    private Vector3 Randomorigine;
    

	void Start()
	{
        Redorigine = Redtransform.position;
        Greenorigine = Greentransform.position;
        Blueorigine = Bluetransform.position;
        Randomorigine = Randomtransform.position;
	}
    void Update()
    {
        
    }

    public void Reset(){

		Redtransform.position = Redorigine;
		Greentransform.position = Greenorigine;
		Bluetransform.position = Blueorigine;
        Randomtransform.position = Randomorigine;
	}
}