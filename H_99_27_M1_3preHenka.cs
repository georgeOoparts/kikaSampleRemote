﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class H_99_27_M1_3preHenka : MonoBehaviour
{
    //M1_3Objectにアタッチ、countで変化させる

    //いちいちunityで当てはめなきゃ駄目　↓---------------

    //k5_3_1_1:gameobject(メソッド、変数)を使いまわす
    public H_99_01_kyoutuHensu kyotu;

    //強調表現点滅に使う変数を共通変数として使う。
    public H_99_01B_kyotuElapse kyotuEla;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log("M1_3Henka::" + kyotu.mojiSwitch + "::MC::" + kyotu.MCount + "::RRC::" + kyotu.rrCount);

    }
}
