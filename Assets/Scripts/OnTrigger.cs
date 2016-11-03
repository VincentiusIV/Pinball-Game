using UnityEngine;
using System.Collections;

public class OnTrigger : MonoBehaviour
{
    public float forceAmount;
    public GameObject explosion;

    void OnTriggerStay(Collider col)
    {
        if (col.CompareTag("Ball") && this.CompareTag("RestartTrigger"))
        {
            col.gameObject.transform.rotation = this.transform.rotation;
            col.gameObject.GetComponent<Rigidbody>().AddForce(transform.up * forceAmount, ForceMode.Force);
        }

        if (col.CompareTag("Ball") && this.CompareTag("SpeedUp"))
        {
            col.gameObject.transform.rotation = this.transform.rotation;
            col.gameObject.GetComponent<Rigidbody>().AddForce(transform.up * forceAmount, ForceMode.Acceleration);
        }

        if(col.CompareTag("Ball") && this.CompareTag("DestroyTrigger"))
        {
            Instantiate(explosion, col.transform.position, Quaternion.identity);
            Destroy(col.gameObject);
        }
    }
}
