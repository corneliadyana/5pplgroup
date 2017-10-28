using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeSprite : MonoBehaviour {

	public Animator anim;
	ClickFleslit helpme;

	// Use this for initialization
	void Start () {
		helpme = GetComponent<ClickFleslit> ();
		//anim = GetComponent<Animator> ();
	}
	
	// Update is called once per frame
	void Update () {
		if (anim.GetBool ("Tolong") == false) {
			if (Input.GetKeyDown(KeyCode.A)) {
				anim.SetBool ("Tolong", true);
			}
		} else {
			if (Input.GetKeyDown(KeyCode.A)) {
				anim.SetBool ("Tolong", false);
			}
		}
	}
}
