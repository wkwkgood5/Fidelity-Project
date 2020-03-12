using UnityEngine;
using System.Collections;

public class PractiseToTest : MonoBehaviour {

    public GameObject Redtransform;
    public GameObject Greentransform;
    public GameObject Bluetransform;
    public GameObject Randomtransform;
    

	void Start()
	{
        
	}
    void Update()
    {
        
    }

    public void ThreeToOne(){

		Redtransform.SetActive(false);
        Greentransform.SetActive(false);
        Bluetransform.SetActive(false);
        Randomtransform.SetActive(true);
	}

    public void OneToThree(){

        Redtransform.SetActive(true);
        Greentransform.SetActive(true);
        Bluetransform.SetActive(true);
        Randomtransform.SetActive(false);
    }
}