using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyByContact : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnTriggerEnter(Collider other) {
		//Debug.Log (other.name);
		if (other.gameObject.CompareTag ("Boundary")) {
			return;	//the control will be returned to the caller of this function (the Unity game loop)
		}
		//if returned, the following codes will not be reached and executed
		Destroy(other.gameObject);
		Destroy(gameObject);	//codewise, it does not matter in what order we mark the objects to be destroyed, as long as they are within the same frame
	} 
}
