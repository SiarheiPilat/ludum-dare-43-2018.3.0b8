﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class deadAdjust : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        transform.position -= new Vector3(0.0f, 0.5f);   
    }
}
