using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[System.Serializable] //in order to view properties in Unity's inspector 
public class Boundary{
	public float xMin, xMax, zMin, zMax;
}
	
public class PlayerController : MonoBehaviour {

	public Boundary boundary;
	public float speed;
	public float tilt;
	public GameObject shot;	//drag a prefab
//	public GameObject shotSpawn;
	public Transform shotSpawn;	//Unity is clever enough to reference the GameObject.Transform component for us even we only drag the GameObject
	public float fireRate;	//the unity is second


	private float nextFire;

	private Rigidbody rb;
	private AudioSource ad;


//	public Text messageText;

	void Start() {
		rb = GetComponent<Rigidbody> ();
		ad = GetComponent<AudioSource> ();	// need the same kind of reference like Rigidbody
		nextFire = 0.0f;	//Don't forget to initiate nextFire with 0

	}

	void Update(){	//Unity will execute all the codes in Update() function before each frame
		if (Input.GetButton("Fire1")&& Time.time > nextFire) {
			Instantiate (shot, shotSpawn.position, shotSpawn.rotation);// as GameObject;
			nextFire = Time.time + fireRate;	//there will be a cooldown time (fireRate) after each shot
			ad.Play();
		}
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

		rb.rotation = Quaternion.Euler (0.0f, 0.0f, rb.velocity.x * (-tilt));	//use the negative value for tilt, or it will become opposite
			
	}

}

