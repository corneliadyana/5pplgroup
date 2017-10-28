using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class matilampu : MonoBehaviour {

	public bool isImgOn;
	public Image img;

	void Start () {
		img.enabled = false;
		isImgOn = false;
	}

	void Update () {
		if (Input.GetMouseButtonDown(0)) {
			//if (Input.GetKeyDown(KeyCode.A)) {
			if (isImgOn == false) {
				img.enabled = true;
				isImgOn = true;
			}

			else {
				img.enabled = false;
				isImgOn = false;
			}
		}
	}
}
