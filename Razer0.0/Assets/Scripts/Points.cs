using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Points : MonoBehaviour
{
    public TextMesh Mytext;//用來參考自己的TextMesh
    public int MyScore;//用來參考自己的TextMesh


    // Use this for initialization
    void Start()
    {
        Mytext = GetComponent<TextMesh>();
    }
    void addScore(int add)
    {
        MyScore += add;
        Mytext.text = MyScore.ToString();
    }
    void Good_test()
    {
        MyScore += 10;
        Mytext.text = MyScore.ToString();
    }
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.Z))
        {
            addScore(5);
        }
        if (Input.GetKey(KeyCode.X))
        {
            Good_test();
        }
    }
}
