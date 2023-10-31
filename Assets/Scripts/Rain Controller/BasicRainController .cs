using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(ParticleSystem))]
public class BasicRainController : RainController, ISALeftMouseClick
{
    ParticleSystem rain;

    void Awake()
    {
        rain = GetComponent<ParticleSystem>();
        rain.Stop();
    }

    public override void BeginRain()
    {
        rain.Play();
    }

    public override void EndRain()
    {
        rain.Stop();
    }

    public void OnLeftMouseClickSignal()
    {
        if (rain.isPlaying)
            rain.Stop();
        else
            rain.Play();
    }
}
