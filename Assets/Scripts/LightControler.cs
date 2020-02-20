using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightControler : MonoBehaviour
{
    public bool on = true;
    public GameObject[] prefabs;

    bool canPushButton = true;
    AudioSource audioData;

    void Start()
    {
        audioData = GetComponent<AudioSource>();
    }

    public void LightsOnOff()
    {
        if (on)
        {
            audioData.Play(0);
            StartCoroutine(LightsOff());
        }
        else
        {
            audioData.Play(0);
            StartCoroutine(LightsOn());
        }
    }

    IEnumerator LightsOn()
    {
        for (int i = -46; i < 24; i += 1)
        {
            foreach (GameObject go in prefabs)
            {
                foreach (Light light in go.GetComponentsInChildren<Light>())
                {
                    if (light.transform.position.x < i)
                    {
                        light.enabled = true;
                    }
                }
            }
            canPushButton = false;
            yield return new WaitForSeconds(0.05f);
        }
        on = true;
        canPushButton = true;
        yield break;
    }

    IEnumerator LightsOff()
    {
        for (int i = -46; i < 24; i += 1)
        {
            foreach (GameObject go in prefabs)
            {
                foreach (Light light in go.GetComponentsInChildren<Light>())
                {
                    if (light.transform.position.x < i)
                    {
                        light.enabled = false;
                    }
                }
            }
            canPushButton = false;
            yield return new WaitForSeconds(0.05f);
        }
        on = false;
        canPushButton = true;
        yield break;
    }
}