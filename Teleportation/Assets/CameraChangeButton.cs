using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraChangeButton : MonoBehaviour {

	public GameObject startCam;
	public GameObject fps;

	public void changeCamera(){
		startCam.GetComponent<Camera> ().depth = -1;
		fps.SetActive (true);
	}

}
