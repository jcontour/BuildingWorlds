using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class autoAnimate : MonoBehaviour {

	Animator anim;

	// Use this for initialization
	void Start () {
		anim = GetComponent<Animator> ();
	}
	
	public void nextAnimation(){
		anim.SetTrigger ("doNext");	
	}
}
