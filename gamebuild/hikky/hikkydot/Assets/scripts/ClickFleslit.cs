using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class ClickFleslit : MonoBehaviour {

	public ChangeSprite cs;
	public bool isImgOn;
	public Image img;

	void Start () {
		img.enabled = true;
		isImgOn = true;
	}

	void Update () {
		if (Input.GetMouseButtonDown(0)) {
		//if (Input.GetKeyDown(KeyCode.A)) {
			if (isImgOn == true) {
				img.enabled = false;
				isImgOn = false;
				cs.anim.SetBool ("Tolong", true);
			}

			else {
				img.enabled = true;
				isImgOn = true;
				cs.anim.SetBool ("Tolong", false);
			}
		}
	}
}
