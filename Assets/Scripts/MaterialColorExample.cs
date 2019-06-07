using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MaterialColorExample : MonoBehaviour
{
    // Fade the color from red to green
    // back and forth over the defined duration

    Color colorStart = Color.red;
    Color colorEnd = Color.green;
    float duration = 1.0f;
    Renderer rend;

    void Start()
    {
        rend = GetComponent<Renderer>();
    }

    void Update()
    {
        float lerp = Mathf.PingPong(Time.time, duration) / duration;
        rend.material.color = Color.Lerp(colorStart, colorEnd, lerp);
    }
}
