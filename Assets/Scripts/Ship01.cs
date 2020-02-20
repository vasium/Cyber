using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ship01 : MonoBehaviour
{
    float speed = 1.0f;
    Rigidbody rb;
    float pos;

    void Start()
    {
        rb = this.GetComponent<Rigidbody>();
        rb.velocity = new Vector3(speed, 0, 0);
    }

    void Update()
    {
        pos = transform.position.x;

        if (pos > 15)
        {
            Destroy(gameObject);
        }
    }
}
