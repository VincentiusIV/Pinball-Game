using UnityEngine;
using System.Collections;

public class DestroyAfterTime : MonoBehaviour
{
    public float time;

    void Awake()
    {
        StartCoroutine(waitAndDestroy());
    }

    IEnumerator waitAndDestroy()
    {
        yield return new WaitForSeconds(time);
        Destroy(this.gameObject);
    }
}