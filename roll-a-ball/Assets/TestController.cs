using UnityEngine;
using System.Collections.Generic;
using System.Collections;

public class TestController : MonoBehaviour {
	public Rigidbody rb;
	void Start() {
		rb = GetComponent<Rigidbody>();
	}
	void FixedUpdate() {
		//if (Input.GetButtonDown("Jump"))
			rb.velocity = new Vector3(0, -0.5f, 0);

	}
}	