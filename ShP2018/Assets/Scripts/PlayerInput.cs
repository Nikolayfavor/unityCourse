using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInput : MonoBehaviour {
	public float speed = 5;
	Animator a;
	void Awake() {
		a = GetComponent<Animator>();
	}
	void Update() {
		Vector2 motion = new Vector2(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical"));
		a.SetFloat("motionX", motion.x);
		a.SetFloat("motionZ", motion.y);
//		motion *= Time.deltaTime * speed;
//		transform.Translate(motion.x, 0, motion.y, Space.Self);
	}
}
