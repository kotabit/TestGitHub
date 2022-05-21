using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AimController : MonoBehaviour
{
    public GameObject player;
    public float CameraSensitivity = 3f;
    private Vector3 offset;
    private Vector3 setPosition;

    //������float�ɕς��܂���
    private float moveOffsetY;

    //���a
    private float r = 5;

    //���W�A��
    private float deg = 0;

    //���ړ���
    float horizontal;

    //�c�ړ���
    float vertical;

    void Start()
    {
        offset = transform.position + player.transform.position;
    }
    void LateUpdate()
    {
        //���Rf�̂Ƃ����ϐ��ɂ����犴���ݒ�ł���
        horizontal = Input.GetAxis("Mouse X") * CameraSensitivity;
        vertical = Input.GetAxis("Mouse Y");

        //�v���}�C�ύX�ňړ����]
        if (horizontal != 0)
        {

            deg -= horizontal;

        }

        if (vertical != 0)
        {

            moveOffsetY -= vertical;

        }

        setPosition.x = player.transform.position.x - r * Mathf.Cos(Mathf.Deg2Rad * deg);

        setPosition.y = player.transform.position.y - moveOffsetY;

        setPosition.z = player.transform.position.z - r * Mathf.Sin(Mathf.Deg2Rad * deg);

        transform.position = setPosition;

    }

}
