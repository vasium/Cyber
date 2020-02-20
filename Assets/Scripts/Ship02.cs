using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ship02 : MonoBehaviour
{
    float speed = 1.0f;
    Rigidbody rb;
    float pos;

    void Start()
    {
        rb = this.GetComponent<Rigidbody>();
        rb.velocity = new Vector3(0, 0, -speed);
    }

    void Update()
    {
        pos = transform.position.z;

        if (pos < -15)
        {
            Destroy(gameObject);
        }
    }
}
