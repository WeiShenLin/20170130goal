﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletState : MonoBehaviour {
	static public int BulletAtk;//子彈攻擊力
	private float BulletSpeed;//子彈速度

	// Use this for initialization
	void Start () {
		BulletSpeed = 0.5f;
		BulletAtk = 2;
	}
	
	// Update is called once per frame
	void Update () {
		transform.Translate (BulletSpeed,0,0);
		Destroy (gameObject,1); //子彈在一秒後自動銷毀
	}
}
