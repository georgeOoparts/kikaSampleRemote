using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class H_99_28_M1_3RR : MonoBehaviour
{
    //M1_3preにアタッチ。オブジェクト全体のいどうをするプログラム
    //いちいちunityで当てはめなきゃ駄目　↓---------------

    //k5_3_1_1:gameobject(メソッド、変数)を使いまわす
    public H_99_01_kyoutuHensu kyotu;

    private Transform M1_3RRMove;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log("M1_3RR::" + kyotu.mojiSwitch + "::MC::" + kyotu.MCount + "::RRC::" + kyotu.rrCount);
    }
}
