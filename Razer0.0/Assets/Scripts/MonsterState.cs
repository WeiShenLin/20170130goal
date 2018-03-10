using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MonsterState : MonoBehaviour {
	private int HP = 1;
    static public int MonsterAtk;//子彈攻擊力
    private float MonsterSpeed;//怪物移動速度

	// Use this for initialization
	void Start () {
        MonsterSpeed = 0.05f;
        MonsterAtk = 5;

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
		transform.Translate (-MonsterSpeed, 0,0);
		if (HP <= 0) {
			Destroy (gameObject);
            //Points.Good_test();
        }
		Destroy (gameObject,3);
	}
}
