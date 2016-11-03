using UnityEngine;
using System.Collections;

public class TextAnimations : MonoBehaviour
{
    public AnimationCurve whooshAnimationCurve;
    public AnimationCurve shakeAnimationCurve;

    void Awake()
    {
        //StartCoroutine(Whoosh());
    }

    public void Whoosh()
    {
        StartCoroutine(WhooshAnimation());
    }
	IEnumerator WhooshAnimation()
    {
        for(float i = 0; i < 3; i += 0.01f)
        {
            yield return new WaitForSeconds(0.0f);
            this.transform.Translate(new Vector3((whooshAnimationCurve.Evaluate(i) * 17.8f), 
                                                  0.0f,
                                                  0.0f));
        }
    }

    public void Shake()
    {
        StartCoroutine(ShakeAnimation());
    }
    IEnumerator ShakeAnimation()
    {
        for (float i = 0; i < 1; i += 0.03f)
        {
            yield return new WaitForSeconds(0.0f);
            this.transform.Translate(new Vector3((shakeAnimationCurve.Evaluate(i)*2 ), 
                                                 (-shakeAnimationCurve.Evaluate(i) *2), 
                                                 0.0f));
        }
    }
}

