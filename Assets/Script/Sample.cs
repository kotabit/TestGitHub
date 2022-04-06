using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sample : MonoBehaviour
{
    int hp = 100;//-1,-2,0,100
    float speed = 0.11f;//¬”
    string name = "100";//•¶š—ñ
    bool IsHuman = true;//false

    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("c#•Ï”‚É‚Â‚¢‚Ä");
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
