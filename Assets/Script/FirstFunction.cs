using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FirstFunction : MonoBehaviour
{
    //Listについて:同じものをまとめたもの
    //宣言の仕方
    //取得の仕方
    //for文との組み合わせ:for文:繰り返し処理の定番機能

    //問い①nからmまでの偶数の和を返す関数を作成せよ
    //問い➁1からnまでの３の倍数と３のつく数字を要素とするリストを返す関数を作成せよ
    void Start()
    {
        List<int> threeAhoNumberList = GetThreeAhoNumberList(20);
        foreach(int number in threeAhoNumberList)
        {
            Debug.Log(number);
        }

    }

    int GetSumEven(int _n,int _m)
    {
        int sum = 0;
        for (int i = _n;i <= _m;i++)
        {
            if(i%2 == 0)//1奇数
            {
                Debug.Log(i);
                sum += i;//
            }
        }
        return sum;
    }

    List<int> GetThreeAhoNumberList(int _n)
    {
        List<int> threeAhoNumberList = new List<int>();


        for(int i = 1;i <= _n;i++)
        {
            if(IsThreeAhoNumber(i))
            {
                threeAhoNumberList.Add(i);
            }
        }
        return threeAhoNumberList;
    }

    //3の倍数と3のつく数字かどうか
    bool IsThreeAhoNumber(int _number)
    {
        if(_number%3 == 0)
        {
            return true;
        }
        while(_number != 0)
        {
            if (_number % 10 == 3)
            {
                return true;
            }
            _number = _number / 10;
        }

        return false;
    }

}
