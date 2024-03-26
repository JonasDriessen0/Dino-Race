using UnityEngine;

public class CameraShake : MonoBehaviour
{
    public float shakeDuration = 0.1f;
    public float shakeIntensity = 0.5f;

    private Vector3 initialPosition;

    void Awake()
    {
        initialPosition = transform.localPosition;
    }

    public void Shake()
    {
        InvokeRepeating("DoShake", 0, 0.01f);
        Invoke("StopShake", shakeDuration);
    }

    void DoShake()
    {
        float randomX = Random.Range(-1f, 1f) * shakeIntensity;
        float randomY = Random.Range(-1f, 1f) * shakeIntensity;
        transform.localPosition = initialPosition + new Vector3(randomX, randomY, 0);
    }

    void StopShake()
    {
        CancelInvoke("DoShake");
        transform.localPosition = initialPosition;
    }
}