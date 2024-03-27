using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScaleCamera : MonoBehaviour
{
    [SerializeField] private float minSize = 5f;
    [SerializeField] private float maxSize = 5.5f;

    [SerializeField] private Camera mainCamera;
    [SerializeField] private SpikeGenerator spikeGenerator;

    void Update()
    {
        float normalizedSpeed = Mathf.InverseLerp(spikeGenerator.MinSpeed, spikeGenerator.MaxSpeed, spikeGenerator.CurrentSpeed);
            
        float targetSize = Mathf.Lerp(minSize, maxSize, normalizedSpeed);
            
        mainCamera.orthographicSize = targetSize;
    }
}