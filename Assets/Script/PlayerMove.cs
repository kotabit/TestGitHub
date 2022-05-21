using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    //Unityの公式スクリプトレファンスにあるものと同じ
    //十字キーのみで操作(→キー=前後左右移動)
    //CharacterControllerが必要

    #region//インスペクターで設定する
    [Header("移動速度")] float speed = 6.0f;//歩行速度
    [Header("ジャンプ力")] float jumpSpeed = 8.0f;//ジャンプ力
    [Header("重力の大きさ")] float gravity = 20.0f;//重力の大きさ
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

        if(controller.isGrounded)//地面に接しているかどうか
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
