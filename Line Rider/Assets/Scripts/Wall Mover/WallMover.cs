using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WallMover : MonoBehaviour
{

    public float forwardSpeed = 10f;
    Vector3 velocity = Vector3.zero;

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void FixedUpdate()
    {
        velocity.x += forwardSpeed;


    }
}
