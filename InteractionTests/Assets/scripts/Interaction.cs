using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Interaction : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		// clicked in general
		if (Input.GetButton ("Fire1")) {
//			Debug.Log ("clicked button");
		}

		if (Input.GetKey (KeyCode.R)) {
			GetComponent<Renderer> ().material.color = Color.red;
		}
		if (Input.GetKey (KeyCode.G)) {
			GetComponent<Renderer> ().material.color = Color.green;
		}
		if (Input.GetKey (KeyCode.B)) {
			GetComponent<Renderer> ().material.color = Color.blue;
		}


	}

	void OnCollisionEnter(Collision other){
		if (other.gameObject.tag == "Player") {
			Debug.Log ("collision enter");
		}
	}

	void OnCollisionStay(Collision other){
		if (other.gameObject.tag == "Player") {
			Debug.Log ("colliding");
			GetComponent<Renderer> ().material.color = Color.yellow;
		}
	}

	void OnCollisionExit(Collision other){
		if (other.gameObject.tag == "Player") {
			Debug.Log ("collision exit");
		}
	}


	//clicked on the object
	void OnMouseDown(){
		Debug.Log ("clicked on cube");
		GetComponent<Renderer> ().material.color = Color.red;

		transform.position = new Vector3 (transform.position.x, transform.position.y + 5, transform.position.z);
		GetComponent<AudioSource> ().Play ();
	}
}
