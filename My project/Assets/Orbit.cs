using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Orbit : MonoBehaviour
{
    public float rotationSpeed;
    void start()
    {

    }
    void Update()
    {
        transform.Rotate(new Vector3(0,rotationSpeed, 0) * Time.deltaTime);
    }
}
