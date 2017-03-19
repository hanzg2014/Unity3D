using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEngine.UI;	//in order to use the UI elements

public class PlayerController : MonoBehaviour {
	public float speed;
	public Text countText;
	public Text winText;

	private Rigidbody rb;
	private int count;

	//the Start() is called on the first frame that the script is active
	void Start()
	{
		rb = GetComponent<Rigidbody> (); //reference to the Rigidbody component in the same object
		count = 0;
		SetCountText ();
		winText.text = "";
	}

	//Update() is called before rendering a frame
//	void Update (){
//		
//	}

	//FixedUpdate() is called before any physical calculations
	void FixedUpdate()
	{
		float moveHorizontal = Input.GetAxis ("Horizontal");
		float moveVertical = Input.GetAxis ("Vertical");

		Vector3 movement = new Vector3 (moveHorizontal, 0.0f, moveVertical);

		rb.AddForce (movement * speed);
			
	}

	//use in the argument the reference to the collider object
	void OnTriggerEnter(Collider other)
	{
		if (other.gameObject.CompareTag ("Pick Up")) 
		{
			other.gameObject.SetActive (false);
			count = count + 1;
			SetCountText ();
		}
	}



	void SetCountText()
	{
		countText.text = "Count:" + count.ToString ();
		if (count >= 12) {
			winText.text = "You Win!";
		}
	}

//	// Use this for initialization
//	void Start () {
//		
//	}
//	
//	// Update is called once per frame
//	void Update () {
//		
//	}
}
