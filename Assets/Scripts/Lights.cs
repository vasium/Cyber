using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lights : MonoBehaviour
{
    Light _light;

    void Start()
    {
        _light = GetComponent<Light>();
    }

    void Update()
    {
        // Toggle light on/off when L key is pressed.
        // if (Input.GetKeyUp(KeyCode.L))
        // {
        //     StartCoroutine("Fade");
        // }
    }

    IEnumerator Fade()
    {
        for (int f = 1; f >= 0; f += 10)
        {
            _light.enabled = !_light.enabled;
            yield return new WaitForSeconds(.1f);

        }
    }
}