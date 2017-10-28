using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class exitgame : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetMouseButtonDown (0)) {
			Application.Quit ();
		}
	}
		
	/*public void Clicc(){
		Application.Quit ();

	}*/

}


/*
		if (Input.GetMouseButtonDown (0)) {
			Application.Quit ();
		}*/
	