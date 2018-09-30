using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseLook : MonoBehaviour {
	public float mouseSensivitity = 100, verticalSensitivity = - 0.2f,
		joySensitivity = 200, maxAngle = 45, minAngle = -45;
	float camAngle;
	void Awake() {
		camAngle = Camera.main.transform.rotation.eulerAngles.x;
	}
	void Update () {
		Vector2 degrees = new Vector2(
			Input.GetAxis("Horizontal2"),
			Input.GetAxis("Vertical2")
		);
		degrees.Set(
			(	Input.GetAxis("Mouse X") * mouseSensivitity +
				((Mathf.Abs(degrees.x) > 0.1f) ? (degrees.x * joySensitivity) : 0) 	)
		 	* Time.deltaTime,
			Mathf.Clamp((Input.GetAxis("Mouse Y") * mouseSensivitity * verticalSensitivity// +
				//Input.GetAxis("Vertical2") * joySensitivity	)
			)* Time.deltaTime + camAngle, minAngle, maxAngle) - camAngle
			);
		print(degrees.y);
		transform.Rotate(0, degrees.x, 0, Space.World);
		Camera.main.transform.Rotate(degrees.y, 0, 0, Space.Self);
		camAngle+=degrees.y;
	}
}
