using UnityEngine;
using System.Collections;

public class TerrainMove : MonoBehaviour {
	public GameObject[] T = new GameObject[3];//參考三塊地形
	public float MoveSpeed;//移動速度
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		T[0].transform.position -= new Vector3 (0,0,MoveSpeed);
		T[1].transform.position -= new Vector3 (0,0,MoveSpeed);
		T[2].transform.position -= new Vector3 (0,0,MoveSpeed);

		if (T [0].transform.position.z <= -150f)
			T [0].transform.position = new Vector3 (0,transform.position.y,T[2].transform.position.z+150f);

		if (T [1].transform.position.z <= -150f)
			T [1].transform.position = new Vector3 (0,transform.position.y,T[0].transform.position.z+150f);

		if (T [2].transform.position.z <= -150f)
			T [2].transform.position = new Vector3 (0,transform.position.y,T[1].transform.position.z+150f);

		}


}
