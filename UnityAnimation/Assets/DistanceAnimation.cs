using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DistanceAnimation : MonoBehaviour {

	Animator cameraAnim;
	Animator sphereAnim;
	public GameObject sphere;

	float dist;


	// Use this for initialization
	void Start () {

		cameraAnim = GetComponent<Animator> ();
		sphereAnim = sphere.GetComponent<Animator> ();
		
	}
	
	// Update is called once per frame
	void Update () {
		dist = Vector3.Distance (transform.position, sphere.transform.position);
		cameraAnim.SetFloat ("doZoom", dist);
		sphereAnim.SetFloat ("doShake", dist);
	}
}
