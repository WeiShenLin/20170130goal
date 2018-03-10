using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HeroState : MonoBehaviour {
    public float HP;//現有血量
    // Use this for initialization
    void Start () {
        HP = 100;
	}
    void OnTriggerEnter2D(Collider2D collider)
    {
        if (collider.tag == "Enemy")
        {
            Destroy(collider.gameObject);
            HP -= MonsterState.MonsterAtk;  
        }
    }
    // Update is called once per frame
    void Update () {
		
	}
}
