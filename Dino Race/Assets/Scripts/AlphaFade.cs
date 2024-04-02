using UnityEngine;
using System.Collections;

public class AlphaFade : MonoBehaviour
{

    public float fadeSpeed = 1f;
    public float fadeTime = 1f;
    public bool fadeIn = true;
    public SpriteRenderer text;

    void Update()
    {
        if (fadeIn)
        {
            float currentAlpha = 0f;
            float Fade = Mathf.SmoothDamp(currentAlpha, 1f, ref currentAlpha, fadeTime, fadeSpeed);
            text.color = new Color(1f, 1f, 1f, Fade);
        }

        if (!fadeIn)
        {
            float currentAlpha = 1f;
            float Fade = Mathf.SmoothDamp(currentAlpha, 0f, ref currentAlpha, fadeTime, fadeSpeed);
            text.color = new Color(1f, 1f, 1f, Fade);
        }
    }
}
