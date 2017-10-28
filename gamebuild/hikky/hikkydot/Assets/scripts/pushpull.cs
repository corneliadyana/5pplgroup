using UnityEngine;
using System.Collections;

public class pushpull : MonoBehaviour {

	public float defaultMass;
	public float imovableMass;
	public bool beingPushed;
	float xPos;

	public Vector3 lastPos;

	public int mode;
	public int colliding;
	// Use this for initialization
	void Start () {
		xPos = transform.position.x;
		lastPos = transform.position;
	}

	// Update is called once per frame
	void FixedUpdate () {
		if (mode == 0) {
			if (beingPushed == false) {
				transform.position = new Vector3 (xPos, transform.position.y);
			} else
				xPos = transform.position.x;
		} else if (mode == 1) {

			if (beingPushed == false) {


				GetComponent<Rigidbody2D> ().mass=imovableMass;

			} else {
				GetComponent<Rigidbody2D> ().mass=defaultMass;
				//	GetComponent<Rigidbody2D> ().isKinematic = false;
			}

		}
	}


}

/*using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pushpull : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnCollisionEnter(Collision c) {
		float force = 3;

		if (c.gameObject.tag == "box") {
			Vector3 dir = c.contacts [0].point - transform.position;
			dir = -dir.normalized;

			GetComponent<Rigidbody> ().AddForce (dir * force);
		}
	}
}*/

/* if (Input.GetKey (KeyCode.D)) {
			rigidbody.AddForce (0, 0, pushForce);
		} */