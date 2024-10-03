using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SmoothMovement : MonoBehaviour
{
    public Transform point1;
    public Vector3 target;
    private Vector3 velocity = Vector3.zero;
    public float smoothTime = 0.0f;

    public float maxSpeed = 10;

    public void onButton()
    {
        while (Vector3.Distance(point1.transform.position, target) > 0.01f) {
            point1.position = Vector3.SmoothDamp(point1.position, target, ref velocity, smoothTime, maxSpeed, Time.deltaTime);
        }
    }

}
