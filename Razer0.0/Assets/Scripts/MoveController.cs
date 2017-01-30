using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveController : MonoBehaviour {
	public GameObject Character;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKey ("down")||Input.GetKey (KeyCode.S)){
			transform.Translate(0,-Time.deltaTime,0);
		}

		if (Input.GetKey ("up")||Input.GetKey (KeyCode.W)){
			transform.Translate(0,Time.deltaTime,0);
		}

		if (Input.GetKey ("left")||Input.GetKey (KeyCode.A)){
			transform.Translate(-Time.deltaTime,0,0);
		}

		if (Input.GetKey ("right")||Input.GetKey (KeyCode.D)){
			transform.Translate(Time.deltaTime,0,0);
		}
	}
}
