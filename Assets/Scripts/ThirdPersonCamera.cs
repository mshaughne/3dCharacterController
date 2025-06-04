using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ThirdPersonCamera : MonoBehaviour
{
	public Transform target; // the player
	public Vector3 offset = new Vector3(0, 0, -7);
	public float rotationSpeed = 5.0f;

	public float minY = -20f;
	public float maxY = 90f;

	private float currentX = 0f;
	private float currentY = 20f;

	// Start is called before the first frame update
	void Start()
	{
		target = GameObject.FindGameObjectWithTag("Player").transform;
	}

    private void LateUpdate()
    {
		currentX += Input.GetAxis("Mouse X") * rotationSpeed;
		currentY -= Input.GetAxis("Mouse Y") * rotationSpeed;
		currentY = Mathf.Clamp(currentY, minY, maxY);

		Quaternion rotation = Quaternion.Euler(currentY, currentX, 0);

		Vector3 desiredPosition = target.position + rotation * offset;

		transform.position = desiredPosition;
		transform.LookAt(target);
    }
}
