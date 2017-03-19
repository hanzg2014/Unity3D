using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour {
	public GameObject Player;	//reference to the Player

	private Vector3 offset;
	// Use this for initialization
	void Start () {
		//use the positions Vector3 in transform menu to subtract that of the Player object
		offset = transform.position - Player.transform.position;
	}
	
	// Update is called once per frame
	// Late Update is called after all other objects are updated
	void LateUpdate () {	
		transform.position = Player.transform.position + offset;
	}
}
