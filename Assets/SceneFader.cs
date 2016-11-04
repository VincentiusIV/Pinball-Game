using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class SceneFader : MonoBehaviour
{
    public Material mat;
    private RawImage image;

    private CanvasRenderer rend;
    private Color color;

    void Awake()
    {
        StartCoroutine(fade());
        rend = GetComponent<CanvasRenderer>();
        rend.SetMaterial(mat, 0);
        image = GetComponent<RawImage>();
    }
	IEnumerator fade()
    {
        for (int i = 0; i < 255; i++)
        {
            yield return new WaitForSeconds(0.0f);
            color.a += 0.01f;
            image.color = color;
            
            /*mat.SetColor("color",color);
            rend.SetMaterial(mat, 0);*/
            Debug.Log("changed mat");
        }
        
    }
}
