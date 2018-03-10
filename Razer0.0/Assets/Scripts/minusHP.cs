using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class minusHP : MonoBehaviour {
    public float maxHP;//最大血量
    public float HP;//現有血量
    
    // Use this for initialization
    void Start () {
        

    }
    //public void minus(float HeroHP) {
    //    HP = HeroHP;
        
    //}

    // Update is called once per frame
    void Update () {
        this.transform.localPosition = new Vector3(-100 + 100 * (HP / maxHP), 0.0f, 0.0f);
    }
}
