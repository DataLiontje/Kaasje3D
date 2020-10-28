﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwingBlade : MonoBehaviour
{

    public float delta = 1.5f;  // Amount to move left and right from the start point
    public float speed = 2.0f;
    public float direction = 1;
    private Quaternion startPos;
    
    // Start is called before the first frame update
    void Start()
    {
        startPos = transform.rotation;
    }

    // Update is called once per frame
    void Update()
    {
        Quaternion a = startPos;
        a.y += direction * (delta * Mathf.Sin(Time.time * speed));
        transform.rotation = a;
    }
}
