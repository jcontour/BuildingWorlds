using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Teleportation : MonoBehaviour {

	public GameObject redCube, blueCube;

	void OnTriggerEnter(Collider other){
		if (other.gameObject.tag == "toRed") {
			transform.position = blueCube.transform.position + new Vector3 (0, 0, -5);
		}
		if (other.gameObject.tag == "toBlue") {
			transform.position = redCube.transform.position + new Vector3 (0, 0, 5);
		}

	}

}
