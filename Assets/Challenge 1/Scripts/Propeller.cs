using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Propeller : MonoBehaviour
{
    private float rotationSpeed = 1000;
    void Update()
    {

        transform.Rotate(Vector3.forward, Time.deltaTime * rotationSpeed);

    }
}
