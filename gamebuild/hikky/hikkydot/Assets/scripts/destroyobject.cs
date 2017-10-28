using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class destroyobject : MonoBehaviour {

	public GameObject todestroy;
	public ChangeSprite cs;

	void ontrigg(){
		if (Input.GetMouseButtonDown(0)) {
			Instantiate (todestroy.transform.position, todestroy.transform.rotation);
			Destroy (todestroy);
			cs.anim.SetBool ("Tolong", true);
		}
	}

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
