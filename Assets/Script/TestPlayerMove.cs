using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//����ɃR���|�[�l���g���A�^�b�`����
[RequireComponent(typeof(Rigidbody))]
public class TestPlayerMove : MonoBehaviour
{
    //�ړ����x��ݒ�(Inspector�^�u������l��ύX�ł���悤�ɂ���)
    [SerializeField] private float speed = 2.0f;

    //�A�^�b�`���Ă���GameObject��Rigidbody���i�[����ϐ�
    private Rigidbody rigidbody;
    void Start()
    {
        rigidbody = GetComponent<Rigidbody>();
    }

    private void FixedUpdate()
    {
        //���E�̃L�[�̓��͂��擾
        float x = Input.GetAxis("Horizontal");
        //�㉺�̃L�[�̓��͂��擾
        float z = Input.GetAxis("Vertical");

        //�㉺���E�L�[����͂��ē����l��speed���|�����l��AddForce�ɐݒ肵�Ĉړ�������
        //(ForceMode.Impulse�͏u�ԓI�ɗ͂�������Ƃ�������)
        rigidbody.AddForce(x * speed, 0, z * speed, ForceMode.Impulse);
    }
}
