using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimationControl : MonoBehaviour {

	Animator anim;
	int p_move;
	bool p_color;

	// Use this for initialization
	void Start () {

		anim = GetComponent<Animator> ();
		p_move = 0;
		p_color = false;
		
	}
	
	// Update is called once per frame
	void Update () {

		if (Input.GetKeyDown (KeyCode.UpArrow)) {
			p_move++;
		}
		if (Input.GetKeyDown (KeyCode.DownArrow)) {
			p_move--;
		}
		if (Input.GetKeyDown (KeyCode.Space)) {
			p_color = !p_color;
		}

		anim.SetInteger ("doMove", p_move);
		anim.SetBool ("doColor", p_color);
		
	}
}
