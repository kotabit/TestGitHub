using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    //Unity�̌����X�N���v�g���t�@���X�ɂ�����̂Ɠ���
    //�\���L�[�݂̂ő���(���L�[=�O�㍶�E�ړ�)
    //CharacterController���K�v

    #region//�C���X�y�N�^�[�Őݒ肷��
    [Header("�ړ����x")] float speed = 6.0f;//���s���x
    [Header("�W�����v��")] float jumpSpeed = 8.0f;//�W�����v��
    [Header("�d�͂̑傫��")] float gravity = 20.0f;//�d�͂̑傫��
    #endregion

    private CharacterController controller;
    private Vector3 moveDirection = Vector3.zero;
    private float h, v;
    void Start()
    {
        controller = GetComponent<CharacterController>();
    }

   
    void Update()
    {
        h = Input.GetAxis("Horizontal");
        v = Input.GetAxis("Vertical");

        if(controller.isGrounded)//�n�ʂɐڂ��Ă��邩�ǂ���
        {
            moveDirection = new Vector3(h, 0, v);
            moveDirection = transform.TransformDirection(moveDirection);
            moveDirection *= speed;
            if (Input.GetButton("Jump"))
                moveDirection.y = jumpSpeed;
        }
        moveDirection.y -= gravity * Time.deltaTime;
        controller.Move(moveDirection * Time.deltaTime);
        //Debug.Log(moveDirection);
    }
}
