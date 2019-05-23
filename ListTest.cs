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
        //　配列の要素数の確保
        intValues = new string[,] 
        {
            {"aaa","bbb","",""},
            {"111", "222","",""},
            {"zzzz", "yyyyy","",""}
        };

        Debug.Log("testInt::"+intValues[0,1]);

        //t = "weeeee";
        //list[0].Add(t);
        //listlist[0][0] = "wweee";
        //listlist.Add(new List<string>());
        //list[0].
        //allList[0] = new List<int>();
        //allList[1] = new List<int>();

        //allList[0].Add(0);
        //allList[0].Add(1);
        //allList[0].Add(2);

        //allList[1].Add(3);
        //allList[1].Add(4);
        //allList[1].Add(5);

        //allList.Add(list1);
        //allList.Add(list2);
        // k0016_99_1_1_1：list新しい値を入れる
        //testInt0.Add(0);
        //testInt0.Add(1);
        //testInt0.Add(2);
        //testInt0.Add(3);
        //listlist[0].Add("999");

        //Debug.Log("testInt::"+ listlist[0][0]);
    }

    void Update()
    {
        
    }
}
