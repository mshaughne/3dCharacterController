using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public Transform target;
    public Vector3 offset;
    public float smoothSpeed = 0.125f;

    private Vector3 velocity = Vector3.zero;

    private void Start()
    {
        target = GameObject.FindGameObjectWithTag("Player").transform;
    }

    private void LateUpdate()
    {
        Vector3 desiredPos = target.position + offset;

        transform.position = Vector3.SmoothDamp(transform.position, desiredPos, ref velocity, smoothSpeed);

        transform.LookAt(target);
    }
}
