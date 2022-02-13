using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChaseBall : MonoBehaviour
{
   public Transform ball;

    // Update is called once per frame
    void Update()
    {
        if (ball.position.y> transform.position.y)
        {
            transform.position = new Vector3(transform.position.x, ball.position.y, transform.position.z);
        }
    }
}
