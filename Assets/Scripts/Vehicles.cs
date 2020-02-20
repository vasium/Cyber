using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Vehicles : MonoBehaviour
{
    bool vehiclesOn = false;

    void Start()
    {
        gameObject.SetActive(false);
    }

    public void VehiclesOnOff()
    {
        if (vehiclesOn)
        {
            gameObject.SetActive(false);
            vehiclesOn = false;
        }
        else
        {
            gameObject.SetActive(true);
            vehiclesOn = true;
        }
    }
}
