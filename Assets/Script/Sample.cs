using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sample : MonoBehaviour
{
    int hp = 100;//-1,-2,0,100
    float speed = 0.11f;//小数
    string name = "100";//文字列
    bool IsHuman = true;//false

    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("c#変数について");
        /*
        Debug.Log(hp);
        Debug.Log(speed);
        Debug.Log(name);
        Debug.Log(IsHuman);
        */
        hp = 100 + 1;
        name = "100" + "1";
        Debug.Log(hp);
        Debug.Log(name);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
