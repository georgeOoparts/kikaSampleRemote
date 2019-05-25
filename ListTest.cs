//using NUnit.Framework;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ListTest : MonoBehaviour
{
    //k0016_99_1_1：listの宣言
    //private List<int> testInt0 = new List<int>();

    //List<List<int>> allList= new List<List<int>>();

    //List<List<int>> allList = new List<List<int>>();
    //List list1 = new List();
    //List list2 = new List();

    //List<List<string>> listlist;
    //List<List<int>> = new List<List<int>>();
    //List<int> list = new List<int>();
    //private List<string> list = new List<string>();

    //string t;
    private string[,] intValues;
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
        if (hCount < 3) {
            Debug.Log("testInt::" + intValues[hCount, 1]);

        } else {
            intValues[intValues.GetLength(0) - 1, 1] = "";//
            Debug.Log("testInt::" + intValues[intValues.GetLength(0) - 1, 1]);
        }
    }
    void textIn() 
    {
        //　配列の要素数の確保
        intValues = new string[,]
        {
            {"aaa","bbb","",""},
            {"111", "222","",""},
            {"zzzz", "yyyyy","",""}
        };
    }
}
