using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//勝手にコンポーネントをアタッチする
[RequireComponent(typeof(Rigidbody))]
public class TestPlayerMove : MonoBehaviour
{
    //移動速度を設定(Inspectorタブからも値を変更できるようにする)
    [SerializeField] private float speed = 2.0f;

    //アタッチしているGameObjectのRigidbodyを格納する変数
    private Rigidbody rigidbody;
    void Start()
    {
        rigidbody = GetComponent<Rigidbody>();
    }

    private void FixedUpdate()
    {
        //左右のキーの入力を取得
        float x = Input.GetAxis("Horizontal");
        //上下のキーの入力を取得
        float z = Input.GetAxis("Vertical");

        //上下左右キーを入力して得た値にspeedを掛けた値をAddForceに設定して移動させる
        //(ForceMode.Impulseは瞬間的に力を加えるということ)
        rigidbody.AddForce(x * speed, 0, z * speed, ForceMode.Impulse);
    }
}
