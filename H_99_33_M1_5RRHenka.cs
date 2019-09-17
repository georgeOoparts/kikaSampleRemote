using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class H_99_33_M1_5RRHenka : MonoBehaviour
{
    //M1_3preにアタッチ。オブジェクト全体のいどうをするプログラム
    //いちいちunityで当てはめなきゃ駄目　↓---------------

    //k5_3_1_1:gameobject(メソッド、変数)を使いまわす
    public H_99_01_kyoutuHensu kyotu;

    public GameObject M1_5TextA;
    public GameObject M1_5TextB;
    public GameObject M1_5TextC;
    public GameObject M1_5TextD;
    public GameObject M1_5TextE;
    public GameObject M1_5TextF;
    public GameObject M1_5TextG;

    public GameObject M1_5LineAB;
    public GameObject M1_5LineBC;
    public GameObject M1_5LineCA;
    public GameObject M1_5LineAD;
    public GameObject M1_5LineAE;
    public GameObject M1_5LineAF;
    public GameObject M1_5LineAG;
    public GameObject M1_5LineBG;
    public GameObject M1_5LineCF;

    public GameObject M1_5LineStAB;
    public GameObject M1_5LineStBC;
    public GameObject M1_5LineStCA;
    public GameObject M1_5LineStAD;
    public GameObject M1_5LineStAE;
    public GameObject M1_5LineStAF;
    public GameObject M1_5LineStAG;
    public GameObject M1_5LineStBG;
    public GameObject M1_5LineStCF;

    public GameObject M1_5PointA;
    public GameObject M1_5PointB;
    public GameObject M1_5PointC;
    public GameObject M1_5PointF;
    public GameObject M1_5PointG;

    public GameObject M1_5PointStA;
    public GameObject M1_5PointStB;
    public GameObject M1_5PointStC;
    public GameObject M1_5PointStF;
    public GameObject M1_5PointStG;

    public GameObject M1_5KakuBAC;
    public GameObject M1_5KakuABC;
    public GameObject M1_5KakuACB;
    public GameObject M1_5KakuAFC;
    public GameObject M1_5KakuAGB;
    public GameObject M1_5KakuCBF;
    public GameObject M1_5KakuBCG;
    public GameObject M1_5KakuABG;
    public GameObject M1_5KakuACF;
    public GameObject M1_5KakuCBG;
    public GameObject M1_5KakuBCF;

    public GameObject M1_5KakuStBAC;
    public GameObject M1_5KakuStABC;
    public GameObject M1_5KakuStACB;
    public GameObject M1_5KakuStAFC;
    public GameObject M1_5KakuStAGB;
    public GameObject M1_5KakuStCBF;
    public GameObject M1_5KakuStBCG;
    public GameObject M1_5KakuStABG;
    public GameObject M1_5KakuStACF;
    public GameObject M1_5KakuStCBG;
    public GameObject M1_5KakuStBCF;



    //強調表現点滅に使う変数を共通変数として使う。
    public H_99_01B_kyotuElapse kyotuEla;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log("M1_5RRHenka::" + kyotu.mojiSwitch + "::MC::" + kyotu.MCount + "::RRC::" + kyotu.rrCount);
    }
}
