using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    public GameObject player;
    public GameObject aimObject;
    public float CameraSensitivity = 3f;
    private Vector3 offset;
    private Vector3 setPosition;
    //îºåa
    private float r = 5;

    //ÉâÉWÉAÉì
    private float deg = 0;

    float horizontal;
    float vertical;
    void Start()
    {
        offset = transform.position - player.transform.position;
        transform.position += offset;
    }
    void LateUpdate()
    {
        //*AimControllerÇ∆àÍèèÇÃílÇ…Ç∑ÇÈÇ±Ç∆
        horizontal = Input.GetAxis("Mouse X") * CameraSensitivity;

        vertical = Input.GetAxis("Mouse Y");
        if (horizontal != 0)
        {
            deg -= horizontal;
        }
        setPosition.x = player.transform.position.x + r * Mathf.Cos(Mathf.Deg2Rad * deg);

        setPosition.y = player.transform.position.y + offset.y;

        setPosition.z = player.transform.position.z + r * Mathf.Sin(Mathf.Deg2Rad * deg);

        transform.position = setPosition;

        transform.LookAt(aimObject.transform);
    }
}
