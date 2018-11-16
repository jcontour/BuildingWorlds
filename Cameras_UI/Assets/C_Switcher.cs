using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class C_Switcher : MonoBehaviour {

	public Camera camera1, camera2;
	public bool mainCameraShowing;

	// Use this for initialization
	void Start () {
		mainCameraShowing = true;
		
	}
	
	// Update is called once per frame
	void Update () {
		if (mainCameraShowing) {
//			camera1.depth = 1;
			camera1.enabled = true;
			camera2.enabled = false;
		} else {
//			camera1.depth = -1;
			camera1.enabled = false;
			camera2.enabled = true;
		}

		if (Input.GetKeyDown (KeyCode.Space)) {
			mainCameraShowing = !mainCameraShowing;
		}
		
	}

}
