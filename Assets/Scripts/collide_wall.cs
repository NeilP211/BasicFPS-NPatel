using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class collide_wall : MonoBehaviour
{
    public float thrust = 50.0f;
    public Rigidbody rb;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    void FixedUpdate()
    {
        rb.AddForce(transform.forward * thrust);
    }
}
