using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GUIScript : MonoBehaviour {

	public Text uitext;
	public Image box1, box2, box3;
	bool haveBox1, haveBox2, haveBox3;

	public Slider slidey;
	float timerVal;

	// Use this for initialization
	void Start () {
		haveBox1 = false;
		haveBox2 = false;
		haveBox3 = false;

		timerVal = 0;
		
	}
	
	// Update is called once per frame
	void Update () {

//		slidey.value = Time.time;
		if (Input.GetKeyDown(KeyCode.UpArrow)){
			timerVal++;
			slidey.value = timerVal;
		}

		if (haveBox1) {
			box1.enabled = true;
		} else {
			box1.enabled = false;
		}

		if (Input.GetKeyDown (KeyCode.Alpha1)) {
			haveBox1 = !haveBox1;
		}

		if (Input.GetKeyDown (KeyCode.W)) {
			uitext.text = "WOW!!";
		}
		if (Input.GetKeyDown (KeyCode.N)) {
			uitext.text = "NEATO";
		}
		if (Input.GetKeyDown (KeyCode.Space)) {
			uitext.text = "";
		}
	}
}
