using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotator : MonoBehaviour {

	// Update is called once per frame
	void Update () {
		transform.Rotate (new Vector3 (15, 30, 45) * Time.deltaTime);	//use Time.deltatime to make the movement smooth and frame independent
	}
	//by using deltaTime, everymovement will be like per second
}



