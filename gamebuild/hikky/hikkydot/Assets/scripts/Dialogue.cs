using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Dialogue : MonoBehaviour {

	public string[] arr;
	public Text apakek;
	int angka;

	// Use this for initialization
	void Start () {
		angka = 0;
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown (KeyCode.Space)) {
			apakek.text = arr [angka];
			angka++;
		}
	}
}
