using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class H_99_45_KA_4RRHenka : MonoBehaviour
{
    //M1_5RRにアタッチ。オブジェクト全体のいどうをするプログラム
    //いちいちunityで当てはめなきゃ駄目　↓---------------

    //k5_3_1_1:gameobject(メソッド、変数)を使いまわす
    public H_99_01_kyoutuHensu kyotu;

    //強調表現点滅に使う変数を共通変数として使う。
    public H_99_01B_kyotuElapse kyotuEla;

    //MColor0Blue_point;
    public Material MColor0;
    //MColor1Yellow_line;
    public Material MColor1;
    //MColor2Green_kaku;
    public Material MColor2;
    //MColor3Red_St1;
    public Material MColor3;
    //MColor4Orange_St2
    public Material MColor4;
    //MColor5Purple_same1;
    public Material MColor5;
    //MColor6Pink_same2
    public Material MColor6;
    //MColor7DarkPurple_same3
    public Material MColor7;
    //MColor8White_same4
    public Material MColor8;
    //MColor9Black_same5
    public Material MColor9;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //Debug.Log("KA_4RRHenka::" + kyotu.mojiSwitch + "::MC::" + kyotu.MCount + "::RRC::" + kyotu.rrCount);

    }
}
