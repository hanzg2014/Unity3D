using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyByContact : MonoBehaviour {

	public GameObject explosion;
	public GameObject playerExplosion;

	private GameController gameController;	//private rather than public, since we need not make reference in a public way
	public int scoreValue;	//for GameController


	// Use this for initialization
	void Start () {
		GameObject gameControllerObject = GameObject.FindWithTag("GameController");
		if (gameControllerObject != null) {
			gameController = gameControllerObject.GetComponent<GameController> ();
		}

		if (gameControllerObject == null) {
			Debug.Log ("Cannot find 'GameController' script");
		}

		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnTriggerEnter(Collider other) {
		//Debug.Log (other.name);
		if (other.gameObject.CompareTag ("Boundary")) {
			return;	//the control will be returned to the caller of this function (the Unity game loop)
		}
		Instantiate (explosion, transform.position, transform.rotation);

		if (other.gameObject.CompareTag ("Player")) {
			Instantiate (playerExplosion, other.gameObject.transform.position, other.gameObject.transform.rotation);
			gameController.GameOver ();
		}
		//if returned, the following codes will not be reached and executed
		Destroy(other.gameObject);
		Destroy(gameObject); //this.gameObject	//codewise, it does not matter in what order we mark the objects to be destroyed, as long as they are within the same frame
		gameController.AddScore(scoreValue);
	} 
}
