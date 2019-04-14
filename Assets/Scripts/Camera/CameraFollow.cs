using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour {

    public Transform target;
    public float smoothing = 5f;

    Vector3 offset;     // distance between the camera and the player

    void Start()
    {
        // store offset in Start()
        offset = transform.position - target.position;
    }

    void FixedUpdate()
    // in every physic step, use FixedUpdate() to move the camera
    {
        Vector3 targetCamPos = target.position + offset;
        transform.position = Vector3.Lerp(transform.position, targetCamPos, smoothing * Time.deltaTime);
    }
}
