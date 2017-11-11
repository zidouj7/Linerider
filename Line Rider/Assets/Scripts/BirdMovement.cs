using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BirdMovement : MonoBehaviour { 


    Vector3 velocity = Vector3.zero;
    public Vector3 gravity;
    public Vector3 flapVelocity;
    private float maxSpeed = 6f;
    public float forwardSpeed = 1f;

    bool didFlap = false;


	// Use this for initialization
	void Start () {
		
	}

    //Update is for graphics and input
    void Update()
    {
        if (Input.GetKeyDown("space"))
        {
            didFlap = true;

        }
    }

    // FixedUpdate is for physics
    void FixedUpdate() {
        velocity.x += forwardSpeed;

        velocity += gravity * Time.deltaTime;


        if (didFlap == true)
        {
            didFlap = false;
            velocity += flapVelocity;
        }

        velocity = Vector3.ClampMagnitude(velocity, maxSpeed);

        transform.position += velocity * Time.deltaTime;
        float angle = 0;

        if(velocity.y < 0)
        {
            angle = Mathf.Lerp(0, -90, -velocity.y / maxSpeed);
        }


        //transform.rotation = Quaternion.Euler(0, 0, angle);
    }
}
