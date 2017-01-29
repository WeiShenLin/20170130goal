using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletCreate : MonoBehaviour {
	public GameObject Bullet;
	private GameObject BulletClone; 
	private float time = 0;
	private float BulletInterval; //子彈間距

	// Use this for initialization
	void Start () {
		BulletInterval = 0.00001f;
	}
	
	// Update is called once per frame
	void Update () {
		time += Time.deltaTime;
		if (Input.GetKeyDown (KeyCode.Space) && time>BulletInterval) //抓取鍵盤控鍵是否按下與時間是否大於子彈間隔
		{
			Vector3 pos = transform.position;
			Quaternion rot = transform.rotation;
			BulletClone = (GameObject)Instantiate(Bullet, pos, rot);//複製子彈並回傳在設定的座標與角度
			BulletClone.AddComponent<BulletState>();
			time = 0;
		}
	}
}
