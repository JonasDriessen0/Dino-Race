using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WindParticles : MonoBehaviour
{
    [SerializeField] private ParticleSystem ps;
    [SerializeField] private SpikeGenerator spikeGenerator;
    [SerializeField] private float windSpeed;

    private void Start()
    {
        var em = ps.emission;
        em.rateOverTime = 0;
    }

    private void Update()
    {
        windSpeed = spikeGenerator.CurrentSpeed * 1.5f;
        var main = ps.main;
        main.startSpeed = windSpeed;
        
        var em = ps.emission;
        if (spikeGenerator.CurrentSpeed >= 13f)
            em.rateOverTime = 4;
        if (spikeGenerator.CurrentSpeed >= 17f)
            em.rateOverTime = 8;
        if (spikeGenerator.CurrentSpeed >= 24f)
            em.rateOverTime = 13;
        if (spikeGenerator.CurrentSpeed >= 30f)
            em.rateOverTime = 16;
    }
}
