﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LookAtSun : MonoBehaviour
{
    public Transform target;

    
    void Update()
    {
        if (target !=  null)
        {
            transform.LookAt(target);
        }
    }
}
