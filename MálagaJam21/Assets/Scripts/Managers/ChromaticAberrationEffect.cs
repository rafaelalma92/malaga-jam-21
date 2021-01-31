﻿using UnityEngine;
using UnityEngine.Rendering;

public class ChromaticAberrationEffect : MonoBehaviour
{
    public static ChromaticAberrationEffect Instance { get; private set; }

    private Volume volume;

    private void Awake()
    {
        Instance = this;

        volume = GetComponent<Volume>();
    }

    private void Update()
    {
        if(volume.weight > 0)
        {
            float decreaseSpeed = 1f;
            volume.weight -= decreaseSpeed * Time.deltaTime;
        }
    }

    public void SetWeight(float weight)
    {
        volume.weight = weight;
    }
}