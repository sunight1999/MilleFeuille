using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(ParticleSystem))]
public class RainController : MonoBehaviour, IRainController, ISALeftMouseClick
{
    ParticleSystem rain;

    void Awake()
    {
        rain = GetComponent<ParticleSystem>();
        rain.Stop();
    }

    public void BeginRain()
    {
        rain.Play();
    }

    public void OnMouseClickSignal()
    {
        if (rain.isPlaying)
            rain.Stop();
        else
            rain.Play();
    }

    public void EndRain()
    {
        rain.Stop();
    }
}
