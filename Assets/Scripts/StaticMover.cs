using UnityEngine;

public class StaticMover : MonoBehaviour
{
    // A simple script that moves an object along the z axis in a constant speed

    public float speed;

    public bool xAxis;
    public bool yAxis;
    public bool zAxis;

    private float xValue;
    private float yValue;
    private float zValue;

    void Awake ()
    {
        if(xAxis)
        {
            xValue = Time.deltaTime * -speed;
        }
        if (yAxis)
        {
            yValue = Time.deltaTime * -speed;
        }
        if (zAxis)
        {
            zValue = Time.deltaTime * -speed;
        }
    }
	// Update is called once per frame
	void Update ()
    {
        transform.Translate(xValue, yValue, zValue);
	}
}
