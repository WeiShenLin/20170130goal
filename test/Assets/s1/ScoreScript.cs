using UnityEngine;
using System.Collections;

public class ScoreScript : MonoBehaviour {
	public TextMesh ScoreView;
	private int Score=0;
	// Use this for initialization
	void Start () {
		ScoreView.text = "Score:" + Score.ToString ();	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void AddScore(){//分數增加
		Score += 10;
		ScoreView.text = "Score:" + Score.ToString ();


	}
}
