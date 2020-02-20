using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Drones : MonoBehaviour
{
    bool dronesOn = false;

    void Start()
    {
        gameObject.SetActive(false);
    }

    public void DronesOnOff()
    {
        if (dronesOn)
        {
            gameObject.SetActive(false);
            dronesOn = false;
        }
        else
        {
            gameObject.SetActive(true);
            dronesOn = true;
        }
    }
}
