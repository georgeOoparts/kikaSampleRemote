using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class H_99_21_M1_2RRHenka : MonoBehaviour
{
    //M1_2Objectにアタッチ、countで変化させる

    //いちいちunityで当てはめなきゃ駄目　↓---------------

    //k5_3_1_1:gameobject(メソッド、変数)を使いまわす
    public H_99_01_kyoutuHensu kyotu;

    //強調表現点滅に使う変数を共通変数として使う。
    public H_99_01B_kyotuElapse kyotuEla;

    //lineを当てはめる
    public GameObject M1_2LineDB;
    public GameObject M1_2LineSDB;

    public GameObject M1_2LineDA;
    public GameObject M1_2LineSDA;

    public GameObject M1_2LineAB;
    public GameObject M1_2LineSAB;

    public GameObject M1_2LineAL;
    public GameObject M1_2LineSAL;

    public GameObject M1_2LineBG;
    public GameObject M1_2LineSBG;

    public GameObject M1_2LineAE;
    public GameObject M1_2LineSAE;

    public GameObject M1_2LineBF;
    public GameObject M1_2LineSBF;

    public GameObject M1_2LineBC;
    public GameObject M1_2LineSBC;

    public GameObject M1_2LineDL;
    public GameObject M1_2LineSDL;

    public GameObject M1_2LineDG;
    public GameObject M1_2LineSDG;

    //pointを当てはめる
    public GameObject M1_2PointD;
    public GameObject M1_2PointA;
    public GameObject M1_2PointB;
    public GameObject M1_2PointC;
    public GameObject M1_2PointE;
    public GameObject M1_2PointF;
    public GameObject M1_2PointG;
    public GameObject M1_2PointH;
    public GameObject M1_2PointK;
    public GameObject M1_2PointL;

    //circleを当てはめる
    public GameObject M1_2BigCircle;
    public GameObject M1_2SBigCircle;

    public GameObject M1_2SmallCircle;
    public GameObject M1_2SSmallCircle;

    //TEXTを当てはめる
    public GameObject M1_2TextD;
    public GameObject M1_2TextA;
    public GameObject M1_2TextB;
    public GameObject M1_2TextH;
    public GameObject M1_2TextC;
    public GameObject M1_2TextG;
    public GameObject M1_2TextL;
    public GameObject M1_2TextE;
    public GameObject M1_2TextF;
    public GameObject M1_2TextK;

    //いちいちunityで当てはめなきゃ駄目　↑---------------

    //renderer当てはめ
    //＞linerederer当てはめ
    private Renderer rrLineDB;
    private Renderer rrLineSDB;

    private Renderer rrLineDA;
    private Renderer rrLineSDA;

    private Renderer rrLineAB;
    private Renderer rrLineSAB;

    private Renderer rrLineAL;
    private Renderer rrLineSAL;

    private Renderer rrLineBG;
    private Renderer rrLineSBG;

    private Renderer rrLineAE;
    private Renderer rrLineSAE;

    private Renderer rrLineBF;
    private Renderer rrLineSBF;

    private Renderer rrLineBC;
    private Renderer rrLineSBC;

    private Renderer rrLineDL;
    private Renderer rrLineSDL;

    private Renderer rrLineDG;
    private Renderer rrLineSDG;

    //＞point rederer当てはめ
    private Renderer rrPointD;
    private Renderer rrPointA;
    private Renderer rrPointB;
    private Renderer rrPointC;
    private Renderer rrPointE;
    private Renderer rrPointF;
    private Renderer rrPointG;
    private Renderer rrPointH;
    private Renderer rrPointK;
    private Renderer rrPointL;

    //＞circle rederer当てはめ
    private Renderer rrBigCircle;
    private Renderer rrSBigCircle;

    private Renderer rrSmallCircle;
    private Renderer rrSSmallCircle;

    //＞text rederer当てはめ
    private Renderer rrTextD;
    private Renderer rrTextA;
    private Renderer rrTextB;
    private Renderer rrTextH;
    private Renderer rrTextC;
    private Renderer rrTextG;
    private Renderer rrTextL;
    private Renderer rrTextE;
    private Renderer rrTextF;
    private Renderer rrTextK;
   
   void Start()
   {
        //gameobjectをredererに当てはめていく
        //＞line：gameobjectをredererに当てはめていく
        rrLineDB = M1_2LineDB.GetComponent<Renderer>();
        rrLineSDB = M1_2LineSDB.GetComponent<Renderer>();

        rrLineDA = M1_2LineDA.GetComponent<Renderer>();
        rrLineSDA = M1_2LineSDA.GetComponent<Renderer>();

        rrLineAB = M1_2LineAB.GetComponent<Renderer>();
        rrLineSAB = M1_2LineSAB.GetComponent<Renderer>();

        rrLineAL = M1_2LineAL.GetComponent<Renderer>();
        rrLineSAL = M1_2LineSAL.GetComponent<Renderer>();

        rrLineBG = M1_2LineBG.GetComponent<Renderer>();
        rrLineSBG = M1_2LineSBG.GetComponent<Renderer>();

        rrLineAE = M1_2LineAE.GetComponent<Renderer>();
        rrLineSAE = M1_2LineSAE.GetComponent<Renderer>();

        rrLineBF = M1_2LineBF.GetComponent<Renderer>();
        rrLineSBF = M1_2LineSBF.GetComponent<Renderer>();

        rrLineBC = M1_2LineBC.GetComponent<Renderer>();
        rrLineSBC = M1_2LineSBC.GetComponent<Renderer>();

        rrLineDL = M1_2LineDL.GetComponent<Renderer>();
        rrLineSDL = M1_2LineSDL.GetComponent<Renderer>();

        rrLineDG = M1_2LineDG.GetComponent<Renderer>();
        rrLineSDG = M1_2LineSDG.GetComponent<Renderer>();

        //＞point：gameobjectをredererに当てはめていく
        rrPointD= M1_2PointD.GetComponent<Renderer>();
        rrPointA = M1_2PointA.GetComponent<Renderer>();
        rrPointB = M1_2PointB.GetComponent<Renderer>();
        rrPointC = M1_2PointC.GetComponent<Renderer>();
        rrPointE = M1_2PointE.GetComponent<Renderer>();
        rrPointF = M1_2PointF.GetComponent<Renderer>();
        rrPointG = M1_2PointG.GetComponent<Renderer>();
        rrPointH = M1_2PointH.GetComponent<Renderer>();
        rrPointK = M1_2PointK.GetComponent<Renderer>();
        rrPointL = M1_2PointL.GetComponent<Renderer>();

        ////＞circle：gameobjectをredererに当てはめていく
        rrBigCircle= M1_2BigCircle.GetComponent<Renderer>();
        rrSBigCircle = M1_2SBigCircle.GetComponent<Renderer>();

        rrSmallCircle = M1_2SmallCircle.GetComponent<Renderer>();
        rrSSmallCircle = M1_2SSmallCircle.GetComponent<Renderer>();

        ////＞text：gameobjectをredererに当てはめていく
        rrTextD = M1_2TextD.GetComponent<Renderer>();
        rrTextA = M1_2TextA.GetComponent<Renderer>();
        rrTextB = M1_2TextB.GetComponent<Renderer>();
        rrTextH = M1_2TextH.GetComponent<Renderer>();
        rrTextC = M1_2TextC.GetComponent<Renderer>();
        rrTextG = M1_2TextG.GetComponent<Renderer>();
        rrTextL = M1_2TextL.GetComponent<Renderer>();
        rrTextE = M1_2TextE.GetComponent<Renderer>();
        rrTextF = M1_2TextF.GetComponent<Renderer>();
        rrTextK = M1_2TextK.GetComponent<Renderer>();
    }

    // Update is called once per frame
    void Update()
    {
        //henka(kyotu.rrCount);
        Debug.Log("M1_2henka::" + kyotu.mojiSwitch + "::MC::" + kyotu.MCount + "::RRC::" + kyotu.rrCount); 
    }

}
