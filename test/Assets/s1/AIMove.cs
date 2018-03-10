using UnityEngine;
using System.Collections;

public class AIMove : MonoBehaviour {

	public string Status;//用一個字串來代表並儲存狀態
	public bool RorL;//用來記錄上一次的左右狀態
	public float RLT=2,DT=1,TempTime,Timing;//RLT為儲存左右時間、DT為向下時間、TempTime用來暫時儲存RLT和DT，Timing則是用來計時，這邊設定程左右移動兩秒就會向下移動一秒，然後在左右移動兩秒
	
	void Start () {
		TempTime = RLT;//給與初始化狀態 不給予的話可能會從意外的狀態開始 建議新手們要提早有初始化的觀念
		Status = "goright";
	}
	
	void Update () {
		Timing += 1*Time.deltaTime;//計時器不斷累加
		//-----------------------------------從這邊開始是屬於判斷區塊-------------------------------
		if (Timing >= TempTime) {//當計時器時間大於暫存時間時，進入判斷
			
			if(Status=="goright" || Status=="goleft"){//假如當前是往左或往右的狀態，那接下來的狀態就是往下
				
				Status="godown";//進入往下狀態
				TempTime=DT;//因為將要進入向下移動的狀態，因此讀取向下時間
				
			}else if(Status=="godown") {//如果目前為狀態
				
				if(RorL){//如果上一次是往右
					
					Status="goright";//那現在就進入往左狀態
					RorL=false;//開關變換
					
				}else{//由於BOOL只有兩種狀態，不是false就是true，因此else的狀態理所當然就是指false，故不多寫
					
					Status="goleft";//那現在就進入往左狀態
					RorL=true;//開關變換
					
				}//上一次往左還是往右的判斷結束了
				
				TempTime=RLT;//因為現在進入左或右的移動狀態，因此暫存計時器讀取左和右的時間
			}
			
			Timing=0;//計時器歸零
			
		}
		
		//-----------------------------------判斷區塊結束-------------------------------
		
		
		//-----------------------------------從這邊開始是狀態與行動-------------------------------
		if (Status == "goright") {//如果現在是往右的狀態
			transform.position += new Vector3 (5 * Time.deltaTime, 0, 0);//那就往右
		} else if (Status == "goleft") {//如果現在是往左的狀態
			transform.position += new Vector3 (-5 * Time.deltaTime, 0, 0);//那就往左
		} else if (Status == "godown") {//如果現在是往下的狀態
			transform.position += new Vector3 (0, 0, -1 * Time.deltaTime);//那就往下
		}
		//-----------------------------------狀態與行動結束-------------------------------
	}
}
