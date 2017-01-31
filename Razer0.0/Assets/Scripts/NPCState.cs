using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NPCState : MonoBehaviour {
	private int HP = 1;
	private float NPCSpeed;//怪物移動速度

	// Use this for initialization
	void Start () {
		NPCSpeed = 0.1f;
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
		transform.Translate (-NPCSpeed,0,0);
		if (HP <= 0) {
			Destroy (gameObject);
		}
		Destroy (gameObject,5);
	}
}
