using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GroundMover : MonoBehaviour {

    public float speedBG = 0.5f;

    private void FixedUpdate()
    {
        Vector3 pos = transform.position;
        pos.x += speedBG * Time.deltaTime;
        transform.position = pos;
    }


}
