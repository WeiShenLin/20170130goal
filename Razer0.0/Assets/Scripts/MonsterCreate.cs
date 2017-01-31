using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MonsterCreate : MonoBehaviour {
	public GameObject Monster;
	private GameObject MonsterClone; 
	private float time = 0;
	private float MonsterInterval; //生怪間隔
	// Use this for initialization
	void Start () {
		MonsterInterval = 0.5f;
	}
	
	// Update is called once per frame
	void Update () {
		//InvokeRepeating("CreateMonster", 2f, 5.0f);
	
		time += Time.deltaTime;
		if (time > MonsterInterval) //抓取時間是否大於生怪間隔
		{
			Vector3 pos = new Vector3(4.0f,Random.Range(-3f,3f),0);
			//Vector3 pos = new Vector3(4.0f,3.0f,0);
			Quaternion rot = transform.rotation;
			MonsterClone = (GameObject)Instantiate (Monster,pos,Quaternion.identity) as GameObject;
			//MonsterClone = (GameObject)Instantiate(Monster, pos, rot);//複製怪物並回傳在設定的座標與角度
			//MonsterClone.transform.SetParent(Monster.transform,false);
			MonsterClone.AddComponent<NPCState>();//把複製的怪物增加狀態
			time = 0f;
		}

	}
	void CreateMonster(){
		Instantiate(Monster);//複製怪物並回傳在設定的座標與角度

	}
}
