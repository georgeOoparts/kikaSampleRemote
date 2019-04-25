using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class H_99_12_zukeiPPRR : MonoBehaviour
{
    //PPRRのzukei変化をコントロールするプルグラム
    //ターンは共通変数のrrCountで進む
    //rrcountはtestPrehubYobi2で進むようにしてある。

    //k5_3_1_1:gameobject(メソッド、変数)を使いまわす
    public H_99_01_kyoutuHensu kyotu;


    //pprrのオブジェを当てはめる
    //>まずは文字から
    public GameObject pprrTextA;
    public GameObject pprrTextB;
    public GameObject pprrTextC;
    public GameObject pprrTextP;

    //>線を当てはめる
    public GameObject pprrLineAB;
    public GameObject pprrLineBC;
    public GameObject pprrLineCA;
    public GameObject pprrLineAP;

    //>強調線を当てはめる
    public GameObject pprrLineSAB;
    public GameObject pprrLineSBC;
    public GameObject pprrLineSCA;
    public GameObject pprrLineSAP;

    void Start()
    {
        
    }

    void Update()
    {
        //k5_3_1_1_1:gameobject(メソッド、変数)を使いまわす
        //yosu.cube1で普通に使える
        //Debug.Log("zykei" + kyotu.rrCount);
        Debug.Log(pprrTextA.name);

    }
}
