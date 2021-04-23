﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectRotator : MonoBehaviour
{

    public float rotationSpeed;

    void Start()
    {
        rotationSpeed = Random.Range(0.5f*rotationSpeed,1.5f*rotationSpeed);
    }

    void FixedUpdate()
    {
        transform.Rotate(new Vector3(0f, 0f, rotationSpeed));
    }
}
