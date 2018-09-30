using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInputControl : MonoBehaviour {
	Animator a;
	void Awake() {
		a = GetComponent<Animator>();
	}
	void Update () {
		a.SetFloat("motionX", Input.GetAxis("Horizontal"));
		a.SetFloat("motionZ", Input.GetAxis("Vertical"));
		a.SetBool("dancing", Input.GetAxisRaw("Fire1") > 0);
	}
}