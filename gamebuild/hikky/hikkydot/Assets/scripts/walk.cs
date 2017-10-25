using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class walk : MonoBehaviour {
	public float speed; 
	public Rigidbody2D booby;
	public float jumpforce;
	public GameObject GroundCheck;
	public bool isGround = false;
	public LayerMask ray;
	[Range (0f,1f)]public float radius;

	// Use this for initialization
	void Start () {
		
	}

	// Update is called once per frame
	void Update () {
		Collider2D[] colliders = Physics2D.OverlapCircleAll (GroundCheck.transform.position,radius,ray);
		for (int i = 0; i < colliders.Length; i++) {
			if(colliders[i].gameObject != gameObject){
				isGround = true;
			}
		}

		if (Input.GetKey (KeyCode.D)) {
			transform.Translate (speed * Time.deltaTime, 0f, 0f);
			GetComponent<AudioSource> ().UnPause ();
		} 
		else if (Input.GetKey (KeyCode.A)) {
			transform.Translate (-speed * Time.deltaTime, 0f, 0f);
			GetComponent<AudioSource> ().UnPause ();
		}
		else {
			GetComponent<AudioSource> ().Pause ();
		}

		if(Input.GetKeyDown(KeyCode.Space) && isGround){
			booby.velocity = new Vector2 (0f, jumpforce * Time.deltaTime);
			isGround = false;

		}

	}
}
