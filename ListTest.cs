//using NUnit.Framework;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ListTest : MonoBehaviour
{

    public H_99_01_kyoutuHensu kyotu;
    //3次元配列テスト
    private string[,,] intValues;
    void Start()
    {
        textIn();
        




    }
    private int hCount=0;
    void Update()
    {
        //kyotu.rrCountの数を増やす
        if (Input.GetMouseButtonDown(0)) hCount++;
        //if (hCount > 3) 
        //{
        //hCount--;

        //}
        //Debug.Log("testInt::" + intValues[intValues.Length - 1, 1]);
        //Debug.Log("testInt::" + intValues[intValues.GetLength(0) - 1, 1]);
        if (hCount < intValues.GetLongLength(1)) 
        {
            Debug.Log("Mcount::" + kyotu.MCount + " hcount::" + hCount+"atai::" + intValues[kyotu.MCount,hCount, 1]);

        } else {
            //intValues[,intValues.GetLength(0) - 1, 1] = "";//
            Debug.Log("Mcount::" + kyotu.MCount + " hcount::"+hCount);
        }
    }
    void textIn() 
    {
        //　配列の要素数の確保
        intValues = new string[,,]
        {
            {
                {"aaa","bbb","",""},
                {"111", "222","",""},
                {"zzzz", "yyyyy","",""}
            },
            {
                {"aaa11","LFbbb11","",""},
                {"111aa", "LF222aa","",""},
                {"zzzzaa", "LFyyyyyaa","",""}
            }

        };
    }
}
