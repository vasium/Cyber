using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMovement : MonoBehaviour
{
    Vector3 targetPosition;
    Vector3 startPosition;

    void Start()
    {
        targetPosition = new Vector3(10f, 0.53f, 0.26f);
        // transform.position = startPosition;
    }

    void Update()
    {
        // transform.position = startPosition;
        // counter += Time.deltaTime / movementTime;
        transform.position = Vector3.Lerp(this.transform.position, targetPosition, 0.001f);
    }

    public void ResetPosition()
    {
        Camera.main.transform.position = new Vector3(-7f, 0.53f, 0.26f);
    }
}
