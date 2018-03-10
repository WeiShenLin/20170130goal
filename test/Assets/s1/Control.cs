using UnityEngine;
using System.Collections;

public class Control : MonoBehaviour {
	public float speed;//速度
	public Transform RFP,LFP;//左右兩個發設點的位置
	public Rigidbody Bullet;//子彈
	public float BulletSpeed;

	private float Vrot,TargetRotationAngle;//用來儲存軟旋轉的值 ,用來儲存目標旋轉角度

	private float lastFireTime;//紀錄最後發射時間
	public float frequency;//發射頻率

	private bool RForLF = true;//左右發射點紀錄開關

	public int HP=5;
	public TextMesh HpText;//HP顯示文字

	// Use this for initialization
	void Start () {
		//HP初始話更新顯示
		string HPView="";
		for (int i = 0; i < HP; i++) {//用迴圈來計算該顯示多少個|
			// 迴圈工作區
			HPView=HPView+"|";//堆疊文字|
		}
		HpText.text = "HP:" + HPView;//更新顯示
	}
	
	// Update is called once per frame
	void Update () {
		Move ();
		Shot ();


	}

	void Move(){//控制飛行的程式
		float addr = Mathf.SmoothDampAngle (transform.eulerAngles.z, TargetRotationAngle, ref Vrot, 0.2f);//控制飛機軟旋轉
		transform.rotation = Quaternion.Euler (0, 0, addr);//指定旋轉方向

		if(Input.GetKey (KeyCode.S)){
			//OnHit();
		}

		if (Input.GetKey (KeyCode.A)) {//如果按下A

			if (transform.position.x >= -8f){//如果沒有超過最大範圍才可移動
				transform.position += new Vector3 (-speed * Time.deltaTime, 0, 0);//移動
				TargetRotationAngle=50f;//設定旋轉目標值
			}
		} else if (Input.GetKey (KeyCode.D)) {//如果按下D

			if (transform.position.x <= 8f){//同樣是判斷
				transform.position += new Vector3 (speed * Time.deltaTime, 0, 0);//移動
				TargetRotationAngle=-50f;//設定旋轉目標值

			}
		} else {
			TargetRotationAngle=0f;//設定旋轉目標值為0
		}
	}


	void Shot(){//射擊控制

		if (Input.GetKey (KeyCode.Space)) {//如果按下空白建

			if (Time.time > lastFireTime + 1 / frequency) {

				if(RForLF){//控制左右發射
					Rigidbody NewBullet = (Rigidbody)Instantiate(Bullet,RFP.transform.position,transform.rotation);//再RFP產生子但
					NewBullet.velocity = new Vector3(0,0,BulletSpeed*Time.deltaTime);//利用剛體運動推動子彈
					Physics.IgnoreCollision(NewBullet.GetComponent<Collider>(), GetComponent<Collider>());//子彈忽略與玩家的碰撞
					RForLF=false;//改變開關

				}else{
					Rigidbody NewBullet = (Rigidbody)Instantiate(Bullet,LFP.transform.position,transform.rotation);//再RFP產生子但
					NewBullet.velocity = new Vector3(0,0,BulletSpeed*Time.deltaTime);//利用剛體運動推動子彈
					Physics.IgnoreCollision(NewBullet.GetComponent<Collider>(), GetComponent<Collider>());//子彈忽略與玩家的碰撞
					RForLF=true;//改變開關
				}
				lastFireTime =Time.time;//紀錄最後發設時間
			}
		}
	}



	void OnTriggerEnter (){//當被打到時 這是移個Unity內建的觸發程式
		HP-=1;
		if (HP <= 0) {
			HpText.text = "GameOver";
			Destroy(gameObject);
		} else {
			string HPView="";
			for (int i = 0; i < HP; i++) {//用迴圈來計算該顯示多少個|
				// 迴圈工作區
				HPView=HPView+"|";//堆疊文字|
			}
			HpText.text = "HP:" + HPView;//更新顯示
		}


	}

}
