using UnityEngine;
using System.Collections;

public class FlipperController : MonoBehaviour
{
    public float forceIntensity;

	// Use this for initialization
	void Start ()
    {
	    if(forceIntensity == 0.0f)
        {
            Debug.Log("Force intensity cannot be 0");
        }
	}
	
	// Update is called every frame
	void Update()
    {
        if(Input.GetButtonDown("Space"))
        {
            GetComponent<Rigidbody>().AddForce(transform.forward * forceIntensity, ForceMode.Acceleration);
            //GetComponent<Rigidbody>().useGravity = true;
        }
    }
}
