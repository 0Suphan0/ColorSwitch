using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateCircle : MonoBehaviour
{
    public float rotateForce;

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(0f,0f,rotateForce*Time.deltaTime);
    }
}
