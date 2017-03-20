using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[System.Serializable] //in order to view properties in Unity's inspector 
public class Boundary{
	public float xMin, xMax, zMin, zMax;
}
	
public class PlayerController : MonoBehaviour {

	public Boundary boundary;
	public float speed;
	public float tilt;

	private Rigidbody rb;

//	public Text messageText;

	void Start() {
		rb = GetComponent<Rigidbody>();
	}

	void FixedUpdate() {
		float moveHorizontal = Input.GetAxis ("Horizontal");
		float moveVertical = Input.GetAxis ("Vertical");
		rb.velocity = new Vector3(moveHorizontal, 0.0f, moveVertical) * speed;

		rb.position = new Vector3 (
			Mathf.Clamp(rb.position.x, boundary.xMin, boundary.xMax),
			0.0f,
			Mathf.Clamp(rb.position.z, boundary.zMin, boundary.zMax)
		);

		rb.rotation = Quaternion.Euler (0.0f, 0.0f, rb.velocity.x * (-tilt));
			
	}
}

