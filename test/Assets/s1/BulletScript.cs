using UnityEngine;
using System.Collections;

public class BulletScript : MonoBehaviour {
	public float MyLifeTime;//子彈最大飛行時間
	private float MyTime=0f;//儲存時間
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		MyTime += 1f * Time.deltaTime;//累計時間
		if (MyLifeTime < MyTime) //如果時間超過 沒有加{}的if代表只判斷下一行
			Destroy (gameObject);//自毀
	}
	void OnTriggerEnter (){
		Destroy (gameObject);
	}

}




