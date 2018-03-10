using UnityEngine;
using System.Collections;

public class AI : MonoBehaviour {
	public Transform AIFP;//AI的發射點
	public Rigidbody Bullet;//子彈
	public float BulletSpeed;//子彈速度

	public ScoreScript RefScore;

	public float i;//計時器
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame

	void Update () {

			//計時器，避免太早發射

		if (i > 1.25f) {
			AIFire ();
		} else {
			i+=1*Time.deltaTime;
		}



	
	}

	void AIFire(){///用亂數來決定AI的發射時機
		int Ran = Random.Range(0,90);
		if (Ran>=89) {
			Rigidbody NewBullet = (Rigidbody)Instantiate(Bullet,AIFP.transform.position,transform.rotation);//再RFP產生子但
			NewBullet.velocity = new Vector3(Random.Range(-2,2),0,-BulletSpeed*Time.deltaTime);//用亂數來製作子但散射 利用剛體運動推動子彈 
			Physics.IgnoreCollision(NewBullet.GetComponent<Collider>(), GetComponent<Collider>());//子彈忽略與AI的碰撞
		}
	}

	void OnTriggerEnter (){
		RefScore.SendMessage ("AddScore");//傳送訊息呼叫分數欄的分數增加 Unity內建的方法
		Destroy (gameObject);//自爆
	}

}
