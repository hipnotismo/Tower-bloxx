﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cube_kinetic : MonoBehaviour
{
    private Rigidbody rb;
    void Start()
    {
        rb = GetComponent<Rigidbody>();

    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnCollisionEnter(Collision collision)
    {
        rb.isKinematic = true;
        Debug.Log("fuck");
    }
}
