using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NPCState : MonoBehaviour {
	private int HP = 5;
	// Use this for initialization
	void Start () {

	}
	void OnTriggerEnter2D(Collider2D collider){
		if (collider.tag == "Bullet") 
		{
			Destroy (collider.gameObject);
			HP -= BulletState.BulletAtk;
		}
	}
	// Update is called once per frame
	void Update () {
		if (HP <= 0)
			Destroy (gameObject);
	}
}
