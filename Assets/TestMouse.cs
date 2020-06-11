﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestMouse : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        TrackMouse();
    }

    void TrackMouse()
    {
        this.transform.position = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        //Debug.Log(Input.mousePosition);
    }
}
