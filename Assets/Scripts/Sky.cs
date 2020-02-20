using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Sky : MonoBehaviour
{
    public Color colorStart = Color.blue;
    public Color colorEnd = Color.green;
    public float duration = 1.0F;
    
    void Update()
    {
        float lerp = Mathf.PingPong(Time.time, duration) / duration;
        // RenderSettings.skybox.SetColor("_Tint", Color.Lerp(colorStart, colorEnd, lerp));
        // RenderSettings.skybox.SetFloat ("_Exposure", Mathf.Sin (Time.time * Mathf.Deg2Rad * 100) + 2);
    }
}