﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotate : MonoBehaviour
{
    public float rotatespeed = 1.5f;
    // Start is called before the first frame update
    void Start()
    {
           
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (transform.localScale.z > 0 )
        {
            transform.localScale -= new Vector3(0, 0, 0.001f);

        }
    }
}
