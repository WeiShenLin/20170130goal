using UnityEngine;
using System.Collections;

public class BACKMENU : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	if (Input.GetKeyDown (KeyCode.Escape)) 
			Application.LoadLevel("s0");

		if (Input.GetKeyDown (KeyCode.R)) 
			Application.LoadLevel("s1");
	}
}
