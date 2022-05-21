using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Cinemachine;

public class ChangeCamera : MonoBehaviour
{

    public CinemachineVirtualCamera vcamera;

    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space))
        {
            vcamera.Priority = 100;
        }
    }
}
