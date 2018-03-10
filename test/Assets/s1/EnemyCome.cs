using UnityEngine;
using System.Collections;

public class EnemyCome : MonoBehaviour {
	public Transform TargetPosition;//紀錄點1和點2
	private Vector3 Vx;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		Vector3 Go = Vector3.SmoothDamp (transform.position,TargetPosition.position,ref Vx,1f);
		transform.position = Go;
	}
}