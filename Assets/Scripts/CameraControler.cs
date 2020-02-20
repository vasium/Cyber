using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraControler : MonoBehaviour
{
    public Camera[] cameras;

    CameraMovement cameraMovement;
    int cameraNumber = 1;

    void Start()
    {
        cameraMovement = new CameraMovement();
        cameras[0].enabled = true;
        cameras[1].enabled = false;
        cameras[2].enabled = false;
        cameras[3].enabled = false;
        cameras[4].enabled = false;
        cameras[5].enabled = false;
        cameras[6].enabled = false;
        cameras[7].enabled = false;
        cameras[8].enabled = false;
        cameras[9].enabled = false;
    }

    private void SelectCamera(int index)
    {
        for (int i = 0; i < cameras.Length; i++)
        {
            if (i == index)
            {
                cameras[i].enabled = true;
            }
            else
            {
                cameras[i].enabled = false;
            }
        }
    }

    public void SwitchCamera()
    {
        if (cameraNumber < 10)
        {
            SelectCamera(cameraNumber);
            cameraNumber++;
        }
        else
        {
            SelectCamera(0);
            cameraMovement.ResetPosition();
            cameraNumber = 1;
        }
    }
}
