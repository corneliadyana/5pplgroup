using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class camfollow : MonoBehaviour {
	public Transform playerToFollow;
	public float Height;
	public float Zoom;
	public float max;
	public float min;

	// Use this for initialization
	void Start () {
		
	}

	// Update is called once per frame
	void Update () {
		if (playerToFollow.position.x > min && playerToFollow.position.x < max) {
			transform.position = new Vector3 (playerToFollow.position.x, Height, Zoom);
		
		}
	}
}

// camera restrict movement

/*	public float speedo = 0.1f;
	public Transform farleft;
	public Transform farright;
 * 
 * if (Input.touchCount > 0 && Input.GetTouch (0).phase == TouchPhase.Moved) {
			Vector2 touchDeltaPosition = Input.GetTouch (0).deltaPosition;
			transform.Translate (-touchDeltaPosition.x * Time.deltaTime * speedo, 0, 0);

			if (transform.position.x > farright.position.x)
				transform.position = new Vector3 (farright.position.x, transform.position.y, transform.position.z);

			if (transform.position.x < farleft.position.x)
				transform.position = new Vector3 (farleft.position.x, transform.position.y, transform.position.z);
		}*/