using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class H_99_33_M1_5RRHenka : MonoBehaviour
{
    //M1_3preにアタッチ。オブジェクト全体のいどうをするプログラム
    //いちいちunityで当てはめなきゃ駄目　↓---------------

    //k5_3_1_1:gameobject(メソッド、変数)を使いまわす
    public H_99_01_kyoutuHensu kyotu;

    //強調表現点滅に使う変数を共通変数として使う。
    public H_99_01B_kyotuElapse kyotuEla;

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

    private Renderer rrM1_5TextA;
    private Renderer rrM1_5TextB;
    private Renderer rrM1_5TextC;
    private Renderer rrM1_5TextD;
    private Renderer rrM1_5TextE;
    private Renderer rrM1_5TextF;
    private Renderer rrM1_5TextG;

    private Renderer rrM1_5LineAB;
    private Renderer rrM1_5LineBC;
    private Renderer rrM1_5LineCA;
    private Renderer rrM1_5LineAD;
    private Renderer rrM1_5LineAE;
    private Renderer rrM1_5LineAF;
    private Renderer rrM1_5LineAG;
    private Renderer rrM1_5LineBG;
    private Renderer rrM1_5LineCF;

    private Renderer rrM1_5LineStAB;
    private Renderer rrM1_5LineStBC;
    private Renderer rrM1_5LineStCA;
    private Renderer rrM1_5LineStAD;
    private Renderer rrM1_5LineStAE;
    private Renderer rrM1_5LineStAF;
    private Renderer rrM1_5LineStAG;
    private Renderer rrM1_5LineStBG;
    private Renderer rrM1_5LineStCF;

    private Renderer rrM1_5PointA;
    private Renderer rrM1_5PointB;
    private Renderer rrM1_5PointC;
    private Renderer rrM1_5PointF;
    private Renderer rrM1_5PointG;

    private Renderer rrM1_5PointStA;
    private Renderer rrM1_5PointStB;
    private Renderer rrM1_5PointStC;
    private Renderer rrM1_5PointStF;
    private Renderer rrM1_5PointStG;

    private Renderer rrM1_5KakuBAC;
    private Renderer rrM1_5KakuABC;
    private Renderer rrM1_5KakuACB;
    private Renderer rrM1_5KakuAFC;
    private Renderer rrM1_5KakuAGB;
    private Renderer rrM1_5KakuCBF;
    private Renderer rrM1_5KakuBCG;
    private Renderer rrM1_5KakuABG;
    private Renderer rrM1_5KakuACF;
    private Renderer rrM1_5KakuCBG;
    private Renderer rrM1_5KakuBCF;

    private Renderer rrM1_5KakuStBAC;
    private Renderer rrM1_5KakuStABC;
    private Renderer rrM1_5KakuStACB;
    private Renderer rrM1_5KakuStAFC;
    private Renderer rrM1_5KakuStAGB;
    private Renderer rrM1_5KakuStCBF;
    private Renderer rrM1_5KakuStBCG;
    private Renderer rrM1_5KakuStABG;
    private Renderer rrM1_5KakuStACF;
    private Renderer rrM1_5KakuStCBG;
    private Renderer rrM1_5KakuStBCF;

    void Start()
    {
        rrM1_5TextA =M1_5TextA.GetComponent<Renderer>();
        rrM1_5TextB = M1_5TextB.GetComponent<Renderer>();
        rrM1_5TextC = M1_5TextC.GetComponent<Renderer>();
        rrM1_5TextD = M1_5TextD.GetComponent<Renderer>();
        rrM1_5TextE = M1_5TextE.GetComponent<Renderer>();
        rrM1_5TextF = M1_5TextF.GetComponent<Renderer>();
        rrM1_5TextG = M1_5TextG.GetComponent<Renderer>();

        rrM1_5LineAB = M1_5LineAB.GetComponent<Renderer>();
        rrM1_5LineBC = M1_5LineBC.GetComponent<Renderer>();
        rrM1_5LineCA = M1_5LineCA.GetComponent<Renderer>();
        rrM1_5LineAD = M1_5LineAD.GetComponent<Renderer>();
        rrM1_5LineAE = M1_5LineAE.GetComponent<Renderer>();
        rrM1_5LineAF = M1_5LineAF.GetComponent<Renderer>();
        rrM1_5LineAG = M1_5LineAG.GetComponent<Renderer>();
        rrM1_5LineBG = M1_5LineBG.GetComponent<Renderer>();
        rrM1_5LineCF = M1_5LineCF.GetComponent<Renderer>();

        rrM1_5LineStAB = M1_5LineStAB.GetComponent<Renderer>();
        rrM1_5LineStBC = M1_5LineStBC.GetComponent<Renderer>();
        rrM1_5LineStCA = M1_5LineStCA.GetComponent<Renderer>();
        rrM1_5LineStAD = M1_5LineStAD.GetComponent<Renderer>();
        rrM1_5LineStAE = M1_5LineStAE.GetComponent<Renderer>();
        rrM1_5LineStAF = M1_5LineStAF.GetComponent<Renderer>();
        rrM1_5LineStAG = M1_5LineStAG.GetComponent<Renderer>();
        rrM1_5LineStBG = M1_5LineStBG.GetComponent<Renderer>();
        rrM1_5LineStCF = M1_5LineStCF.GetComponent<Renderer>();

        rrM1_5PointA = M1_5PointA.GetComponent<Renderer>();
        rrM1_5PointB = M1_5PointB.GetComponent<Renderer>();
        rrM1_5PointC = M1_5PointC.GetComponent<Renderer>();
        rrM1_5PointF = M1_5PointF.GetComponent<Renderer>();
        rrM1_5PointG = M1_5PointG.GetComponent<Renderer>();

        rrM1_5PointStA = M1_5PointStA.GetComponent<Renderer>();
        rrM1_5PointStB = M1_5PointStB.GetComponent<Renderer>();
        rrM1_5PointStC = M1_5PointStC.GetComponent<Renderer>();
        rrM1_5PointStF = M1_5PointStF.GetComponent<Renderer>();
        rrM1_5PointStG = M1_5PointStG.GetComponent<Renderer>();

        rrM1_5KakuBAC = M1_5KakuBAC.GetComponent<Renderer>();
        rrM1_5KakuABC = M1_5KakuABC.GetComponent<Renderer>();
        rrM1_5KakuACB = M1_5KakuACB.GetComponent<Renderer>();
        rrM1_5KakuAFC = M1_5KakuAFC.GetComponent<Renderer>();
        rrM1_5KakuAGB = M1_5KakuAGB.GetComponent<Renderer>();
        rrM1_5KakuCBF = M1_5KakuCBF.GetComponent<Renderer>();
        rrM1_5KakuBCG = M1_5KakuBCG.GetComponent<Renderer>();
        rrM1_5KakuABG = M1_5KakuABG.GetComponent<Renderer>();
        rrM1_5KakuACF = M1_5KakuACF.GetComponent<Renderer>();
        rrM1_5KakuCBG = M1_5KakuCBG.GetComponent<Renderer>();
        rrM1_5KakuBCF = M1_5KakuBCF.GetComponent<Renderer>();

        rrM1_5KakuStBAC = M1_5KakuStBAC.GetComponent<Renderer>();
        rrM1_5KakuStABC = M1_5KakuStABC.GetComponent<Renderer>();
        rrM1_5KakuStACB = M1_5KakuStACB.GetComponent<Renderer>();
        rrM1_5KakuStAFC = M1_5KakuStAFC.GetComponent<Renderer>();
        rrM1_5KakuStAGB = M1_5KakuStAGB.GetComponent<Renderer>();
        rrM1_5KakuStCBF = M1_5KakuStCBF.GetComponent<Renderer>();
        rrM1_5KakuStBCG = M1_5KakuStBCG.GetComponent<Renderer>();
        rrM1_5KakuStABG = M1_5KakuStABG.GetComponent<Renderer>();
        rrM1_5KakuStACF = M1_5KakuStACF.GetComponent<Renderer>();
        rrM1_5KakuStCBG = M1_5KakuStCBG.GetComponent<Renderer>();
        rrM1_5KakuStBCF = M1_5KakuStBCF.GetComponent<Renderer>();
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log("M1_5RRHenka::" + kyotu.mojiSwitch + "::MC::" + kyotu.MCount + "::RRC::" + kyotu.rrCount);
    }
}
