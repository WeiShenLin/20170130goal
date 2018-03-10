using UnityEngine;
using System.Collections;

public class UI : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnGUI(){
		if(GUI.Button (new Rect(100,100,300,100),"開始遊戲")){
			Application.LoadLevel("s1");
		}
	}
}
