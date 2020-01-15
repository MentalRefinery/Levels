using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlanetRotationScript : MonoBehaviour
{
    public float rotationSpeed = 10f;

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(0, rotationSpeed, 0);
    }
}
