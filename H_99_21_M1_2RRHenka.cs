using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class H_99_21_M1_2RRHenka : MonoBehaviour {
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

    //>強調pointを当てはめる
    public GameObject M1_2StPointD;
    public GameObject M1_2StPointA;
    public GameObject M1_2StPointB;
    public GameObject M1_2StPointC;
    public GameObject M1_2StPointE;
    public GameObject M1_2StPointF;
    public GameObject M1_2StPointG;
    public GameObject M1_2StPointH;
    public GameObject M1_2StPointK;
    public GameObject M1_2StPointL;

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

    //＞＞point rederer当てはめ
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

    //＞＞point rederer当てはめ
    private Renderer rrStPointD;
    private Renderer rrStPointA;
    private Renderer rrStPointB;
    private Renderer rrStPointC;
    private Renderer rrStPointE;
    private Renderer rrStPointF;
    private Renderer rrStPointG;
    private Renderer rrStPointH;
    private Renderer rrStPointK;
    private Renderer rrStPointL;

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

    void Start() {
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
        rrPointD = M1_2PointD.GetComponent<Renderer>();
        rrPointA = M1_2PointA.GetComponent<Renderer>();
        rrPointB = M1_2PointB.GetComponent<Renderer>();
        rrPointC = M1_2PointC.GetComponent<Renderer>();
        rrPointE = M1_2PointE.GetComponent<Renderer>();
        rrPointF = M1_2PointF.GetComponent<Renderer>();
        rrPointG = M1_2PointG.GetComponent<Renderer>();
        rrPointH = M1_2PointH.GetComponent<Renderer>();
        rrPointK = M1_2PointK.GetComponent<Renderer>();
        rrPointL = M1_2PointL.GetComponent<Renderer>();

        rrStPointD = M1_2StPointD.GetComponent<Renderer>();
        rrStPointA = M1_2StPointA.GetComponent<Renderer>();
        rrStPointB = M1_2StPointB.GetComponent<Renderer>();
        rrStPointC = M1_2StPointC.GetComponent<Renderer>();
        rrStPointE = M1_2StPointE.GetComponent<Renderer>();
        rrStPointF = M1_2StPointF.GetComponent<Renderer>();
        rrStPointG = M1_2StPointG.GetComponent<Renderer>();
        rrStPointH = M1_2StPointH.GetComponent<Renderer>();
        rrStPointK = M1_2StPointK.GetComponent<Renderer>();
        rrStPointL = M1_2StPointL.GetComponent<Renderer>();

        ////＞circle：gameobjectをredererに当てはめていく
        rrBigCircle = M1_2BigCircle.GetComponent<Renderer>();
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
    void Update() {
        henka(kyotu.rrCount);
        //Debug.Log("M1_2henka::" + kyotu.mojiSwitch + "::MC::" + kyotu.MCount + "::RRC::" + kyotu.rrCount);
    }
    //リセット表示を全部消すメソッド　kyotu.rrcount-----------------------------
    private void reset() {
        //k7B_1_1:オブジェを存在するけど見えなくする。
        //this.gameObject.GetComponent<Renderer>().enabled = false; 

        //k7B_1_2:オブジェを見えるようにするよ。
        //this.gameObject.GetComponent<Renderer>().enabled = true;

        //gameobjectを見えなくする
        //＞line：gameobjectを見えなくする

        rrLineDB.enabled=false;
        rrLineSDB.enabled = false;

        rrLineDA.enabled=false;
        rrLineSDA.enabled=false;

        rrLineAB.enabled = false;
        rrLineSAB.enabled = false;

        rrLineAL.enabled = false;
        rrLineSAL.enabled = false;

        rrLineBG.enabled = false;
        rrLineSBG.enabled = false;

        rrLineAE.enabled = false;
        rrLineSAE.enabled = false;

        rrLineBF.enabled = false;
        rrLineSBF.enabled = false;

        rrLineBC.enabled = false;
        rrLineSBC.enabled = false;

        rrLineDL.enabled = false;
        rrLineSDL.enabled = false;

        rrLineDG.enabled = false;
        rrLineSDG.enabled = false;

    //rrLineDG.enabled = false;
        //rrLineSDG.enabled = false;

        //＞point：gameobjectを見えなくする
        rrPointD.enabled = false;
        rrPointA.enabled = false;
        rrPointB.enabled = false;
        rrPointC.enabled = false;
        rrPointE.enabled = false;
        rrPointF.enabled = false;
        rrPointG.enabled = false;
        rrPointH.enabled = false;
        rrPointK.enabled = false;
        rrPointL.enabled = false;

        rrStPointD.enabled = false;
        rrStPointA.enabled = false;
        rrStPointB.enabled = false;
        rrStPointC.enabled = false;
        rrStPointE.enabled = false;
        rrStPointF.enabled = false;
        rrStPointG.enabled = false;
        rrStPointH.enabled = false;
        rrStPointK.enabled = false;
        rrStPointL.enabled = false;

        ////＞circle：gameobjectを見えなくする
        rrBigCircle.enabled = false;
        rrSBigCircle.enabled = false;

        rrSmallCircle.enabled = false;
        rrSSmallCircle.enabled = false;

        ////＞text：gameobjectを見えなくする
        rrTextD.enabled = false;
        rrTextA.enabled = false;
        rrTextB.enabled = false;
        rrTextH.enabled = false;
        rrTextC.enabled = false;
        rrTextG.enabled = false;
        rrTextL.enabled = false;
        rrTextE.enabled = false;
        rrTextF.enabled = false;
        rrTextK.enabled = false;
    }
    //rrCountでオブジェの表示、強調を変化させるメソッド---------------------------
    private void henka(int count) {
        //m1_2のときのみ実行
        if (kyotu.mojiSwitch == 3 & kyotu.MCount == 1) {
            if (count == 5) {
                reset();
                //gameobjectを見えるようにする
                //＞point：gameobjectを見えるようにする
                rrPointA.enabled = true;
                rrStPointA.enabled = kyotuEla.tenmetuOnOff;
                
                ////＞text：gameobjectを見えるようにする
                rrTextA.enabled = true;
            }
            else if (count == 6) {
                reset();
                //gameobjectを見えるようにする
                //＞line：gameobjectを見えるようにする
                rrLineBC.enabled = true;
                rrLineSBC.enabled = kyotuEla.tenmetuOnOff;

                //＞point：gameobjectを見えるようにする
                rrPointA.enabled = true;
               
                ////＞text：gameobjectを見えるようにする
                rrTextA.enabled = true;
                rrTextB.enabled = true;
                rrTextH.enabled = false;
                rrTextC.enabled = true;
            } else if (count == 7) {
                reset();
                //gameobjectを見えるようにする
                //＞line：gameobjectを見えるようにする
                rrLineBC.enabled = true;
                
                //＞point：gameobjectを見えるようにする
                rrPointD.enabled = false;
                rrPointA.enabled = true;
                
                ////＞text：gameobjectを見えるようにする
                rrTextD.enabled = false;
                rrTextA.enabled = true;
                rrTextB.enabled = true;
                rrTextH.enabled = false;
                rrTextC.enabled = true;
                
            } else if (count == 8) {
                reset();
                //gameobjectを見えるようにする
                //＞line：gameobjectを見えるようにする
                rrLineBC.enabled = true;
                rrLineSBC.enabled = false;//kyotuEla.tenmetuOnOff;

                //＞point：gameobjectを見えるようにする
                rrPointD.enabled = false;
                rrPointA.enabled = true;
                rrStPointA.enabled = kyotuEla.tenmetuOnOff;
               
                ////＞text：gameobjectを見えるようにする
                rrTextD.enabled = false;
                rrTextA.enabled = true;
                rrTextB.enabled = true;
                rrTextH.enabled = false;
                rrTextC.enabled = true;
                
            } else if (count == 9) {
                reset();
                //gameobjectを見えるようにする
                //＞line：gameobjectを見えるようにする
               
                rrLineBC.enabled = true;
                rrLineSBC.enabled = kyotuEla.tenmetuOnOff;

               //＞point：gameobjectを見えるようにする
                rrPointA.enabled = true;//kyotuEla.tenmetuOnOff;
                
                ////＞text：gameobjectを見えるようにする
                rrTextD.enabled = false;
                rrTextA.enabled = true;
                rrTextB.enabled = true;
                rrTextH.enabled = false;
                rrTextC.enabled = true;
                
            } else if (count == 10) {
                reset();
                //gameobjectを見えるようにする
                
                rrLineBC.enabled = true;
                rrLineSBC.enabled = false;//kyotuEla.tenmetuOnOff;

                //＞point：gameobjectを見えるようにする
                rrPointA.enabled = true;//kyotuEla.tenmetuOnOff;

                ///＞text：gameobjectを見えるようにする
                rrTextD.enabled = false;
                rrTextA.enabled = true;
                rrTextB.enabled = true;
                rrTextH.enabled = false;
                rrTextC.enabled = true;
                
            } else if (count == 11) {
                reset();
                //gameobjectを見えるようにする
                //＞line：gameobjectを見えるようにする
                rrLineAB.enabled = true;
                rrLineSAB.enabled = //false;
                kyotuEla.tenmetuOnOff;

                rrLineBC.enabled = true;
                rrLineSBC.enabled = false;//kyotuEla.tenmetuOnOff;

                //＞point：gameobjectを見えるようにする
                rrPointA.enabled = true;//kyotuEla.tenmetuOnOff;

                ////＞text：gameobjectを見えるようにする
                rrTextD.enabled = false;
                rrTextA.enabled = true;
                rrTextB.enabled = true;
                rrTextH.enabled = false;
                rrTextC.enabled = true;
                
            } else if (count == 12) {
                reset();
                //gameobjectを見えるようにする
                //＞line：gameobjectを見えるようにする

                rrLineAB.enabled = true;
                rrLineSAB.enabled = false;
                //kyotuEla.tenmetuOnOff;

                rrLineBC.enabled = true;
                rrLineSBC.enabled = false;//kyotuEla.tenmetuOnOff;

                //＞point：gameobjectを見えるようにする
                rrPointA.enabled = true;
                rrStPointA.enabled = kyotuEla.tenmetuOnOff;

                ////＞text：gameobjectを見えるようにする
                rrTextD.enabled = false;
                rrTextA.enabled = true;
                rrTextB.enabled = true;
                rrTextH.enabled = false;
                rrTextC.enabled = true;
                
            } else if (count == 13) {
                reset();
                //gameobjectを見えるようにする
                //＞line：gameobjectを見えるようにする

                rrLineAB.enabled = true;
                rrLineSAB.enabled = false;
                //kyotuEla.tenmetuOnOff;

                rrLineBC.enabled = true;
                rrLineSBC.enabled = false;//kyotuEla.tenmetuOnOff;

                //＞point：gameobjectを見えるようにする
                rrPointA.enabled = true;
                //kyotuEla.tenmetuOnOff;

                rrPointB.enabled = true;
                rrStPointB.enabled = kyotuEla.tenmetuOnOff;

                ////＞text：gameobjectを見えるようにする
                rrTextD.enabled = false;
                rrTextA.enabled = true;
                rrTextB.enabled = true;
                rrTextH.enabled = false;
                rrTextC.enabled = true;
                
            } else if (count == 14) {
                reset();
                //gameobjectを見えるようにする
                //＞line：gameobjectを見えるようにする

                rrLineAB.enabled = true;
                rrLineSAB.enabled = false;
                //kyotuEla.tenmetuOnOff;

                rrLineBC.enabled = true;
                rrLineSBC.enabled = false;//kyotuEla.tenmetuOnOff;

                //＞point：gameobjectを見えるようにする
                rrPointA.enabled = true;
                //kyotuEla.tenmetuOnOff;

                rrPointB.enabled = true;
                //kyotuEla.tenmetuOnOff;

                ////＞text：gameobjectを見えるようにする
                rrTextD.enabled = false;
                rrTextA.enabled = true;
                rrTextB.enabled = true;
                rrTextH.enabled = false;
                rrTextC.enabled = true;
                
            } else if (count == 15) {
                reset();
                //gameobjectを見えるようにする
                //＞line：gameobjectを見えるようにする

                rrLineAB.enabled = true;
                rrLineSAB.enabled = //false;
                kyotuEla.tenmetuOnOff;

                rrLineBC.enabled = true;
                rrLineSBC.enabled = false;//kyotuEla.tenmetuOnOff;

                //＞point：gameobjectを見えるようにする
                rrPointA.enabled = true;
                //kyotuEla.tenmetuOnOff;

                rrPointB.enabled = true;
                //kyotuEla.tenmetuOnOff;

                ////＞text：gameobjectを見えるようにする
                rrTextD.enabled = false;
                rrTextA.enabled = true;
                rrTextB.enabled = true;
                rrTextH.enabled = false;
                rrTextC.enabled = true;
                
            } else if (count == 16) {
                reset();
                //gameobjectを見えるようにする
                //＞line：gameobjectを見えるようにする

                rrLineAB.enabled = true;
                rrLineSAB.enabled = //false;
                kyotuEla.tenmetuOnOff;

                rrLineDA.enabled = true;
                rrLineSDA.enabled = //false;
                kyotuEla.tenmetuOnOff;

                rrLineDB.enabled = true;
                rrLineSDB.enabled = //false;
                kyotuEla.tenmetuOnOff;

                rrLineBC.enabled = true;
                rrLineSBC.enabled = false;//kyotuEla.tenmetuOnOff;

                //＞point：gameobjectを見えるようにする
                rrPointD.enabled = true;
                //kyotuEla.tenmetuOnOff;

                rrPointA.enabled = true;
                //kyotuEla.tenmetuOnOff;

                rrPointB.enabled = true;
                //kyotuEla.tenmetuOnOff;

                ////＞text：gameobjectを見えるようにする
                rrTextD.enabled = true;
                rrTextA.enabled = true;
                rrTextB.enabled = true;
                rrTextH.enabled = false;
                rrTextC.enabled = true;
               
            } else if (count == 17) {
                reset();
                //gameobjectを見えるようにする
                //＞line：gameobjectを見えるようにする

                rrLineAB.enabled = true;
                rrLineSAB.enabled = false;

                rrLineDA.enabled = true;
                rrLineSDA.enabled = false;

                rrLineDB.enabled = true;
                rrLineSDB.enabled = false;

                rrLineBC.enabled = true;
                rrLineSBC.enabled = false;//kyotuEla.tenmetuOnOff;

                //＞point：gameobjectを見えるようにする
                rrPointD.enabled = true;

                rrPointA.enabled = true;

                rrPointB.enabled = true;

                ////＞text：gameobjectを見えるようにする
                rrTextD.enabled = true;
                rrTextA.enabled = true;
                rrTextB.enabled = true;
                rrTextH.enabled = false;
                rrTextC.enabled = true;
                
            } else if (count == 18) {
                reset();
                //gameobjectを見えるようにする
                //＞line：gameobjectを見えるようにする

                rrLineAB.enabled = true;
                rrLineSAB.enabled = false;

                rrLineDA.enabled = true;
                rrLineSDA.enabled =kyotuEla.tenmetuOnOff;

                rrLineDB.enabled = true;
                rrLineSDB.enabled = false;

                rrLineBC.enabled = true;
                rrLineSBC.enabled = false;//kyotuEla.tenmetuOnOff;

                //＞point：gameobjectを見えるようにする
                rrPointD.enabled = true;

                rrPointA.enabled = true;

                rrPointB.enabled = true;

                ////＞text：gameobjectを見えるようにする
                rrTextD.enabled = true;
                rrTextA.enabled = true;
                rrTextB.enabled = true;
                rrTextH.enabled = false;
                rrTextC.enabled = true;
                
            } else if (count == 19) {
                reset();
                //gameobjectを見えるようにする
                //＞line：gameobjectを見えるようにする

                rrLineAB.enabled = true;
                rrLineSAB.enabled = false;

                rrLineDA.enabled = true;
                rrLineSDA.enabled = false;

                rrLineDB.enabled = true;
                rrLineSDB.enabled = kyotuEla.tenmetuOnOff;

                rrLineBC.enabled = true;
                rrLineSBC.enabled = false;//kyotuEla.tenmetuOnOff;

                //＞point：gameobjectを見えるようにする
                rrPointD.enabled = true;

                rrPointA.enabled = true;

                rrPointB.enabled = true;

                ////＞text：gameobjectを見えるようにする
                rrTextD.enabled = true;
                rrTextA.enabled = true;
                rrTextB.enabled = true;
                rrTextH.enabled = false;
                rrTextC.enabled = true;
                
            } else if (count == 20) {
                reset();
                //gameobjectを見えるようにする
                //＞line：gameobjectを見えるようにする

                rrLineAB.enabled = true;
                rrLineSAB.enabled = false;

                rrLineDA.enabled = true;
                rrLineSDA.enabled = false;

                rrLineDB.enabled = true;
                rrLineSDB.enabled = false;

                rrLineBC.enabled = true;
                rrLineSBC.enabled = false;//kyotuEla.tenmetuOnOff;

                rrLineAE.enabled = true;
                rrLineSAE.enabled = //false;
                kyotuEla.tenmetuOnOff;

                //＞point：gameobjectを見えるようにする
                rrPointD.enabled = true;

                rrPointA.enabled = true;

                rrPointB.enabled = true;

               ////＞text：gameobjectを見えるようにする
                rrTextD.enabled = true;
                rrTextA.enabled = true;
                rrTextB.enabled = true;
                rrTextH.enabled = false;
                rrTextC.enabled = true;
                rrTextG.enabled = false;
                rrTextL.enabled = false;
                rrTextE.enabled = true;
               
            } else if (count == 21) {
                reset();
                //gameobjectを見えるようにする
                //＞line：gameobjectを見えるようにする

                rrLineAB.enabled = true;
                rrLineSAB.enabled = false;

                rrLineDA.enabled = true;
                rrLineSDA.enabled = false;

                rrLineDB.enabled = true;
                rrLineSDB.enabled = false;

                rrLineBC.enabled = true;
                rrLineSBC.enabled = false;//kyotuEla.tenmetuOnOff;

                rrLineAE.enabled = true;
                rrLineSAE.enabled = false;

                rrLineBF.enabled = true;
                rrLineSBF.enabled = kyotuEla.tenmetuOnOff;

                //＞point：gameobjectを見えるようにする
                rrPointD.enabled = true;

                rrPointA.enabled = true;

                rrPointB.enabled = true;

                ////＞text：gameobjectを見えるようにする
                rrTextD.enabled = true;
                rrTextA.enabled = true;
                rrTextB.enabled = true;
                rrTextH.enabled = false;
                rrTextC.enabled = true;
                rrTextG.enabled = false;
                rrTextL.enabled = false;
                rrTextE.enabled = true;
                rrTextF.enabled = true;
                rrTextK.enabled = false;
            } else if (count == 22) {
                reset();
                //gameobjectを見えるようにする
                //＞line：gameobjectを見えるようにする

                rrLineAB.enabled = true;
                rrLineSAB.enabled = false;

                rrLineDA.enabled = true;
                rrLineSDA.enabled = false;

                rrLineDB.enabled = true;
                rrLineSDB.enabled = false;

                rrLineBC.enabled = true;
                rrLineSBC.enabled = false;//kyotuEla.tenmetuOnOff;

                rrLineAE.enabled = true;
                rrLineSAE.enabled = false;

                rrLineBF.enabled = true;
                rrLineSBF.enabled = false;

                //＞point：gameobjectを見えるようにする
                rrPointD.enabled = true;

                rrPointA.enabled = true;

                rrPointB.enabled = true;

                ////＞text：gameobjectを見えるようにする
                rrTextD.enabled = true;
                rrTextA.enabled = true;
                rrTextB.enabled = true;
                rrTextH.enabled = false;
                rrTextC.enabled = true;
                rrTextG.enabled = false;
                rrTextL.enabled = false;
                rrTextE.enabled = true;
                rrTextF.enabled = true;
                rrTextK.enabled = false;
            } else if (count == 23) {
                reset();
                //gameobjectを見えるようにする
                //＞line：gameobjectを見えるようにする

                rrLineAB.enabled = true;
                rrLineSAB.enabled = false;

                rrLineDA.enabled = true;
                rrLineSDA.enabled = false;

                rrLineDB.enabled = true;
                rrLineSDB.enabled = false;

                rrLineBC.enabled = true;
                rrLineSBC.enabled = false;//kyotuEla.tenmetuOnOff;

                rrLineAE.enabled = true;
                rrLineSAE.enabled = false;

                rrLineBF.enabled = true;
                rrLineSBF.enabled = false;

                //＞point：gameobjectを見えるようにする
                rrPointD.enabled = true;

                rrPointA.enabled = true;

                rrPointB.enabled = true;
                rrStPointB.enabled = kyotuEla.tenmetuOnOff;

                ////＞circle：gameobjectを見えるようにする
                rrBigCircle.enabled = false;
                rrSBigCircle.enabled = false;

                rrSmallCircle.enabled = false;
                rrSSmallCircle.enabled = false;

                ////＞text：gameobjectを見えるようにする
                rrTextD.enabled = true;
                rrTextA.enabled = true;
                rrTextB.enabled = true;
                rrTextH.enabled = false;
                rrTextC.enabled = true;
                rrTextG.enabled = false;
                rrTextL.enabled = false;
                rrTextE.enabled = true;
                rrTextF.enabled = true;
                rrTextK.enabled = false;
            } else if (count == 24) {
                reset();
                //gameobjectを見えるようにする
                //＞line：gameobjectを見えるようにする

                rrLineAB.enabled = true;
                rrLineSAB.enabled = false;

                rrLineDA.enabled = true;
                rrLineSDA.enabled = false;

                rrLineDB.enabled = true;
                rrLineSDB.enabled = false;

                rrLineBC.enabled = true;
                rrLineSBC.enabled = kyotuEla.tenmetuOnOff;

                rrLineAE.enabled = true;
                rrLineSAE.enabled = false;

                rrLineBF.enabled = true;
                rrLineSBF.enabled = false;

                //＞point：gameobjectを見えるようにする
                rrPointD.enabled = true;

                rrPointA.enabled = true;

                rrPointB.enabled = true;

                rrPointC.enabled = true;

                ////＞circle：gameobjectを見えるようにする
                rrBigCircle.enabled = false;
                rrSBigCircle.enabled = false;

                rrSmallCircle.enabled = false;
                rrSSmallCircle.enabled = false;

                ////＞text：gameobjectを見えるようにする
                rrTextD.enabled = true;
                rrTextA.enabled = true;
                rrTextB.enabled = true;
                rrTextH.enabled = false;
                rrTextC.enabled = true;
                rrTextG.enabled = false;
                rrTextL.enabled = false;
                rrTextE.enabled = true;
                rrTextF.enabled = true;
                rrTextK.enabled = false;
            } else if (count == 25) {
                reset();
                //gameobjectを見えるようにする
                //＞line：gameobjectを見えるようにする

                rrLineAB.enabled = true;
                rrLineSAB.enabled = false;

                rrLineDA.enabled = true;
                rrLineSDA.enabled = false;

                rrLineDB.enabled = true;
                rrLineSDB.enabled = false;

                rrLineBC.enabled = true;
                rrLineSBC.enabled = false;

                rrLineAE.enabled = true;
                rrLineSAE.enabled = false;

                rrLineBF.enabled = true;
                rrLineSBF.enabled = false;

                //＞point：gameobjectを見えるようにする
                rrPointD.enabled = true;

                rrPointA.enabled = true;

                rrPointB.enabled = true;

                rrPointC.enabled = true;

                rrPointG.enabled = true;

                rrPointH.enabled = true;

                ////＞circle：gameobjectを見えるようにする
                rrBigCircle.enabled = false;
                rrSBigCircle.enabled = false;

                rrSmallCircle.enabled = true;
                rrSSmallCircle.enabled = //false;
                kyotuEla.tenmetuOnOff;
                
                ////＞text：gameobjectを見えるようにする
                rrTextD.enabled = true;
                rrTextA.enabled = true;
                rrTextB.enabled = true;
                rrTextH.enabled = true;
                rrTextC.enabled = true;
                rrTextG.enabled = true;
                rrTextL.enabled = false;
                rrTextE.enabled = true;
                rrTextF.enabled = true;
                rrTextK.enabled = false;
            } else if (count == 26) {
                reset();
                //gameobjectを見えるようにする
                //＞line：gameobjectを見えるようにする

                rrLineAB.enabled = true;
                rrLineSAB.enabled = false;

                rrLineDA.enabled = true;
                rrLineSDA.enabled = false;

                rrLineDB.enabled = true;
                rrLineSDB.enabled = false;

                rrLineBC.enabled = true;
                rrLineSBC.enabled = false;

                rrLineAE.enabled = true;
                rrLineSAE.enabled = false;

                rrLineBF.enabled = true;
                rrLineSBF.enabled = false;

                //＞point：gameobjectを見えるようにする
                rrPointD.enabled = true;

                rrPointA.enabled = true;

                rrPointB.enabled = true;

                rrPointC.enabled = true;

                rrPointG.enabled = true;

                rrPointH.enabled = true;

                ////＞circle：gameobjectを見えるようにする
                rrBigCircle.enabled = false;
                rrSBigCircle.enabled = false;

                rrSmallCircle.enabled = true;
                rrSSmallCircle.enabled = false;

                ////＞text：gameobjectを見えるようにする
                rrTextD.enabled = true;
                rrTextA.enabled = true;
                rrTextB.enabled = true;
                rrTextH.enabled = true;
                rrTextC.enabled = true;
                rrTextG.enabled = true;
                rrTextL.enabled = false;
                rrTextE.enabled = true;
                rrTextF.enabled = true;
                rrTextK.enabled = false;
            } else if (count == 27) {
                reset();
                //gameobjectを見えるようにする
                //＞line：gameobjectを見えるようにする

                rrLineAB.enabled = true;
                rrLineSAB.enabled = false;

                rrLineDA.enabled = true;
                rrLineSDA.enabled = false;

                rrLineDB.enabled = true;
                rrLineSDB.enabled = false;

                rrLineBC.enabled = true;
                rrLineSBC.enabled = false;

                rrLineAE.enabled = true;
                rrLineSAE.enabled = false;

                rrLineBF.enabled = true;
                rrLineSBF.enabled = false;

                //＞point：gameobjectを見えるようにする
                rrStPointD.enabled= kyotuEla.tenmetuOnOff;
                rrPointD.enabled =true;

                rrPointA.enabled = true;

                rrPointB.enabled = true;

                rrPointC.enabled = true;

                rrPointG.enabled = true;

                rrPointH.enabled = true;

                ////＞circle：gameobjectを見えるようにする
                rrBigCircle.enabled = false;
                rrSBigCircle.enabled = false;

                rrSmallCircle.enabled = true;
                rrSSmallCircle.enabled = false;
                //kyotuEla.tenmetuOnOff;

                ////＞text：gameobjectを見えるようにする
                rrTextD.enabled = true;
                rrTextA.enabled = true;
                rrTextB.enabled = true;
                rrTextH.enabled = true;
                rrTextC.enabled = true;
                rrTextG.enabled = true;
                rrTextL.enabled = false;
                rrTextE.enabled = true;
                rrTextF.enabled = true;
                rrTextK.enabled = false;
            } else if (count == 28) {
                reset();
                //gameobjectを見えるようにする
                //＞line：gameobjectを見えるようにする

                rrLineAB.enabled = true;
                rrLineSAB.enabled = false;

                rrLineDA.enabled = true;
                rrLineSDA.enabled = false;

                rrLineDB.enabled = true;
                rrLineSDB.enabled = false;

                rrLineBC.enabled = true;
                rrLineSBC.enabled = false;

                rrLineAE.enabled = true;
                rrLineSAE.enabled = false;

                rrLineBF.enabled = true;
                rrLineSBF.enabled = false;

                rrLineDG.enabled = true;
                rrLineSDG.enabled = kyotuEla.tenmetuOnOff;

                //＞point：gameobjectを見えるようにする
                //rrStPointD.enabled = kyotuEla.tenmetuOnOff;
                rrPointD.enabled = true;

                rrPointA.enabled = true;

                rrPointB.enabled = true;

                rrPointC.enabled = true;

                rrPointG.enabled = true;

                rrPointH.enabled = true;

                ////＞circle：gameobjectを見えるようにする
                rrBigCircle.enabled = false;
                rrSBigCircle.enabled = false;

                rrSmallCircle.enabled = true;
                rrSSmallCircle.enabled = false;

                ////＞text：gameobjectを見えるようにする
                rrTextD.enabled = true;
                rrTextA.enabled = true;
                rrTextB.enabled = true;
                rrTextH.enabled = true;
                rrTextC.enabled = true;
                rrTextG.enabled = true;
                rrTextL.enabled = false;
                rrTextE.enabled = true;
                rrTextF.enabled = true;
                rrTextK.enabled = false;
            } else if (count == 29) {
                reset();
                //gameobjectを見えるようにする
                //＞line：gameobjectを見えるようにする

                rrLineAB.enabled = true;
                rrLineSAB.enabled = false;

                rrLineDA.enabled = true;
                rrLineSDA.enabled = false;

                rrLineDB.enabled = true;
                rrLineSDB.enabled = false;

                rrLineBC.enabled = true;
                rrLineSBC.enabled = false;

                rrLineAE.enabled = true;
                rrLineSAE.enabled = false;

                rrLineBF.enabled = true;
                rrLineSBF.enabled = false;

                rrLineDG.enabled = true;

                //＞point：gameobjectを見えるようにする
                rrPointD.enabled = true;

                rrPointA.enabled = true;

                rrPointB.enabled = true;

                rrPointC.enabled = true;

                rrPointG.enabled = true;

                rrPointH.enabled = true;

                rrPointK.enabled = true;

                rrPointL.enabled = true;


                ////＞circle：gameobjectを見えるようにする
                rrBigCircle.enabled = true;
                rrSBigCircle.enabled = kyotuEla.tenmetuOnOff;

                rrSmallCircle.enabled = true;

                ////＞text：gameobjectを見えるようにする
                rrTextD.enabled = true;
                rrTextA.enabled = true;
                rrTextB.enabled = true;
                rrTextH.enabled = true;
                rrTextC.enabled = true;
                rrTextG.enabled = true;
                rrTextL.enabled = true;
                rrTextE.enabled = true;
                rrTextF.enabled = true;
                rrTextK.enabled = true;
            } else if (count == 30) {
                reset();
                //gameobjectを見えるようにする
                //＞line：gameobjectを見えるようにする

                rrLineAB.enabled = true;
                rrLineSAB.enabled = false;

                rrLineDA.enabled = true;
                rrLineSDA.enabled = false;

                rrLineDB.enabled = true;
                rrLineSDB.enabled = false;

                rrLineBC.enabled = true;
                rrLineSBC.enabled = false;

                rrLineAE.enabled = true;
                rrLineSAE.enabled = false;

                rrLineBF.enabled = true;
                rrLineSBF.enabled = false;

                rrLineDG.enabled = true;

                //＞point：gameobjectを見えるようにする
                rrPointD.enabled = true;

                rrPointA.enabled = true;

                rrPointB.enabled = true;

                rrPointC.enabled = true;

                rrPointG.enabled = true;

                rrPointH.enabled = true;

                rrPointK.enabled = true;

                rrPointL.enabled = true;


                ////＞circle：gameobjectを見えるようにする
                rrBigCircle.enabled = true;

                rrSmallCircle.enabled = true;

                ////＞text：gameobjectを見えるようにする
                rrTextD.enabled = true;
                rrTextA.enabled = true;
                rrTextB.enabled = true;
                rrTextH.enabled = true;
                rrTextC.enabled = true;
                rrTextG.enabled = true;
                rrTextL.enabled = true;
                rrTextE.enabled = true;
                rrTextF.enabled = true;
                rrTextK.enabled = true;
            } else if (count == 31) {
                reset();
                //gameobjectを見えるようにする
                //＞line：gameobjectを見えるようにする

                rrLineAB.enabled = true;
                rrLineSAB.enabled = false;

                rrLineDA.enabled = true;
                rrLineSDA.enabled = false;

                rrLineDB.enabled = true;
                rrLineSDB.enabled = false;

                rrLineBC.enabled = true;
                rrLineSBC.enabled = false;

                rrLineAE.enabled = true;
                rrLineSAE.enabled = false;

                rrLineBF.enabled = true;
                rrLineSBF.enabled = false;

                rrLineDG.enabled = true;

                //＞point：gameobjectを見えるようにする
                rrPointD.enabled = true;

                rrPointA.enabled = true;

                rrPointB.enabled = true;
                rrStPointB.enabled = kyotuEla.tenmetuOnOff;

                rrPointC.enabled = true;

                rrPointG.enabled = true;

                rrPointH.enabled = true;

                rrPointK.enabled = true;

                rrPointL.enabled = true;


                ////＞circle：gameobjectを見えるようにする
                rrBigCircle.enabled = true;

                rrSmallCircle.enabled = true;
                //rrSSmallCircle.enabled = kyotuEla.tenmetuOnOff;

                ////＞text：gameobjectを見えるようにする
                rrTextD.enabled = true;
                rrTextA.enabled = true;
                rrTextB.enabled = true;
                rrTextH.enabled = true;
                rrTextC.enabled = true;
                rrTextG.enabled = true;
                rrTextL.enabled = true;
                rrTextE.enabled = true;
                rrTextF.enabled = true;
                rrTextK.enabled = true;
            } else if (count == 32) {
                reset();
                //gameobjectを見えるようにする
                //＞line：gameobjectを見えるようにする

                rrLineAB.enabled = true;
                rrLineSAB.enabled = false;

                rrLineDA.enabled = true;
                rrLineSDA.enabled = false;

                rrLineDB.enabled = true;
                rrLineSDB.enabled = false;

                rrLineBC.enabled = true;
                rrLineSBC.enabled = false;

                rrLineAE.enabled = true;
                rrLineSAE.enabled = false;

                rrLineBF.enabled = true;
                rrLineSBF.enabled = false;

                rrLineDG.enabled = true;

                //＞point：gameobjectを見えるようにする
                rrPointD.enabled = true;

                rrPointA.enabled = true;

                rrPointB.enabled = true;

                rrPointC.enabled = true;

                rrPointG.enabled = true;

                rrPointH.enabled = true;

                rrPointK.enabled = true;

                rrPointL.enabled = true;


                ////＞circle：gameobjectを見えるようにする
                rrBigCircle.enabled = true;

                rrSmallCircle.enabled = true;
                rrSSmallCircle.enabled = kyotuEla.tenmetuOnOff;

                ////＞text：gameobjectを見えるようにする
                rrTextD.enabled = true;
                rrTextA.enabled = true;
                rrTextB.enabled = true;
                rrTextH.enabled = true;
                rrTextC.enabled = true;
                rrTextG.enabled = true;
                rrTextL.enabled = true;
                rrTextE.enabled = true;
                rrTextF.enabled = true;
                rrTextK.enabled = true;
            } else if (count == 33) {
                reset();
                //gameobjectを見えるようにする
                //＞line：gameobjectを見えるようにする

                rrLineAB.enabled = true;
                rrLineSAB.enabled = false;

                rrLineDA.enabled = true;
                rrLineSDA.enabled = false;

                rrLineDB.enabled = true;
                rrLineSDB.enabled = false;

                rrLineBC.enabled = true;
                rrLineSBC.enabled = kyotuEla.tenmetuOnOff;

                rrLineAE.enabled = true;
                rrLineSAE.enabled = false;

                rrLineBF.enabled = true;
                rrLineSBF.enabled = false;

                rrLineDG.enabled = true;

                //＞point：gameobjectを見えるようにする
                rrPointD.enabled = true;

                rrPointA.enabled = true;

                rrPointB.enabled = true;

                rrPointC.enabled = true;

                rrPointG.enabled = true;

                rrPointH.enabled = true;

                rrPointK.enabled = true;

                rrPointL.enabled = true;


                ////＞circle：gameobjectを見えるようにする
                rrBigCircle.enabled = true;

                rrSmallCircle.enabled = true;

                ////＞text：gameobjectを見えるようにする
                rrTextD.enabled = true;
                rrTextA.enabled = true;
                rrTextB.enabled = true;
                rrTextH.enabled = true;
                rrTextC.enabled = true;
                rrTextG.enabled = true;
                rrTextL.enabled = true;
                rrTextE.enabled = true;
                rrTextF.enabled = true;
                rrTextK.enabled = true;
            } else if (count == 34) {
                reset();
                //gameobjectを見えるようにする
                //＞line：gameobjectを見えるようにする

                rrLineAB.enabled = true;
                rrLineSAB.enabled = false;

                rrLineDA.enabled = true;
                rrLineSDA.enabled = false;

                rrLineDB.enabled = true;
                rrLineSDB.enabled = false;

                rrLineBC.enabled = true;

                rrLineSBG.enabled = kyotuEla.tenmetuOnOff;

                rrLineAE.enabled = true;
                rrLineSAE.enabled = false;

                rrLineBF.enabled = true;
                rrLineSBF.enabled = false;

                rrLineDG.enabled = true;

                //＞point：gameobjectを見えるようにする
                rrPointD.enabled = true;

                rrPointA.enabled = true;

                rrPointB.enabled = true;

                rrPointC.enabled = true;

                rrPointG.enabled = true;

                rrPointH.enabled = true;

                rrPointK.enabled = true;

                rrPointL.enabled = true;


                ////＞circle：gameobjectを見えるようにする
                rrBigCircle.enabled = true;

                rrSmallCircle.enabled = true;

                ////＞text：gameobjectを見えるようにする
                rrTextD.enabled = true;
                rrTextA.enabled = true;
                rrTextB.enabled = true;
                rrTextH.enabled = true;
                rrTextC.enabled = true;
                rrTextG.enabled = true;
                rrTextL.enabled = true;
                rrTextE.enabled = true;
                rrTextF.enabled = true;
                rrTextK.enabled = true;
            } else if (count == 35) {
                reset();
                //gameobjectを見えるようにする

                rrLineAB.enabled = true;
                rrLineSAB.enabled = false;

                rrLineDA.enabled = true;
                rrLineSDA.enabled = false;

                rrLineDB.enabled = true;
                rrLineSDB.enabled = false;

                rrLineBC.enabled = true;

                rrLineAE.enabled = true;
                rrLineSAE.enabled = false;

                rrLineBF.enabled = true;
                rrLineSBF.enabled = false;

                rrLineDG.enabled = true;

                //＞point：gameobjectを見えるようにする
                rrPointD.enabled = true;

                rrPointA.enabled = true;

                rrPointB.enabled = true;

                rrPointC.enabled = true;

                rrPointG.enabled = true;

                rrPointH.enabled = true;

                rrPointK.enabled = true;

                rrPointL.enabled = true;


                ////＞circle：gameobjectを見えるようにする
                rrBigCircle.enabled = true;

                rrSmallCircle.enabled = true;

                ////＞text：gameobjectを見えるようにする
                rrTextD.enabled = true;
                rrTextA.enabled = true;
                rrTextB.enabled = true;
                rrTextH.enabled = true;
                rrTextC.enabled = true;
                rrTextG.enabled = true;
                rrTextL.enabled = true;
                rrTextE.enabled = true;
                rrTextF.enabled = true;
                rrTextK.enabled = true;
            } else if (count == 36) {
                reset();
                //gameobjectを見えるようにする
                //＞line：gameobjectを見えるようにする

                rrLineAB.enabled = true;
                rrLineSAB.enabled = false;

                rrLineDA.enabled = true;
                rrLineSDA.enabled = false;

                rrLineDB.enabled = true;
                rrLineSDB.enabled = false;

                rrLineBC.enabled = true;

                rrLineAE.enabled = true;
                rrLineSAE.enabled = false;

                rrLineBF.enabled = true;
                rrLineSBF.enabled = false;

                rrLineDG.enabled = true;

                //＞point：gameobjectを見えるようにする
                rrStPointD.enabled = kyotuEla.tenmetuOnOff;
                rrPointD.enabled = true;

                rrPointA.enabled = true;

                rrPointB.enabled = true;

                rrPointC.enabled = true;

                rrPointG.enabled = true;

                rrPointH.enabled = true;

                rrPointK.enabled = true;

                rrPointL.enabled = true;

                ////＞circle：gameobjectを見えるようにする
                rrBigCircle.enabled = true;

                rrSmallCircle.enabled = true;

                ////＞text：gameobjectを見えるようにする
                rrTextD.enabled = true;
                rrTextA.enabled = true;
                rrTextB.enabled = true;
                rrTextH.enabled = true;
                rrTextC.enabled = true;
                rrTextG.enabled = true;
                rrTextL.enabled = true;
                rrTextE.enabled = true;
                rrTextF.enabled = true;
                rrTextK.enabled = true;
            } else if (count == 37) {
                reset();
                //gameobjectを見えるようにする
                //＞line：gameobjectを見えるようにする

                rrLineAB.enabled = true;
                rrLineSAB.enabled = false;

                rrLineDA.enabled = true;
                rrLineSDA.enabled = false;

                rrLineDB.enabled = true;
                rrLineSDB.enabled = false;

                rrLineBC.enabled = true;

                rrLineAE.enabled = true;
                rrLineSAE.enabled = false;

                rrLineBF.enabled = true;
                rrLineSBF.enabled = false;

                rrLineDG.enabled = true;

                //＞point：gameobjectを見えるようにする
                rrPointD.enabled = true;

                rrPointA.enabled = true;

                rrPointB.enabled = true;

                rrPointC.enabled = true;

                rrPointG.enabled = true;

                rrPointH.enabled = true;

                rrPointK.enabled = true;

                rrPointL.enabled = true;

                ////＞circle：gameobjectを見えるようにする
                rrBigCircle.enabled = true;
                rrSBigCircle.enabled = kyotuEla.tenmetuOnOff;

                rrSmallCircle.enabled = true;

                ////＞text：gameobjectを見えるようにする
                rrTextD.enabled = true;
                rrTextA.enabled = true;
                rrTextB.enabled = true;
                rrTextH.enabled = true;
                rrTextC.enabled = true;
                rrTextG.enabled = true;
                rrTextL.enabled = true;
                rrTextE.enabled = true;
                rrTextF.enabled = true;
                rrTextK.enabled = true;
            } else if (count == 38) {
                reset();
                //gameobjectを見えるようにする
                //＞line：gameobjectを見えるようにする

                rrLineAB.enabled = true;
                rrLineSAB.enabled = false;

                rrLineDA.enabled = true;
                rrLineSDA.enabled = false;

                rrLineDB.enabled = true;
                rrLineSDB.enabled = false;

                rrLineBC.enabled = true;

                rrLineAE.enabled = true;
                rrLineSAE.enabled = false;

                rrLineBF.enabled = true;
                rrLineSBF.enabled = false;

                rrLineDG.enabled = true;

                rrLineSDL.enabled = kyotuEla.tenmetuOnOff;
                
                //＞point：gameobjectを見えるようにする
                rrPointD.enabled = true;

                rrPointA.enabled = true;

                rrPointB.enabled = true;

                rrPointC.enabled = true;

                rrPointG.enabled = true;

                rrPointH.enabled = true;

                rrPointK.enabled = true;

                rrPointL.enabled = true;


                ////＞circle：gameobjectを見えるようにする
                rrBigCircle.enabled = true;

                rrSmallCircle.enabled = true;

                ////＞text：gameobjectを見えるようにする
                rrTextD.enabled = true;
                rrTextA.enabled = true;
                rrTextB.enabled = true;
                rrTextH.enabled = true;
                rrTextC.enabled = true;
                rrTextG.enabled = true;
                rrTextL.enabled = true;
                rrTextE.enabled = true;
                rrTextF.enabled = true;
                rrTextK.enabled = true;
            } else if (count == 39) {
                reset();
                //gameobjectを見えるようにする
                //＞line：gameobjectを見えるようにする

                rrLineAB.enabled = true;
                rrLineSAB.enabled = false;

                rrLineDA.enabled = true;
                rrLineSDA.enabled = false;

                rrLineDB.enabled = true;
                rrLineSDB.enabled = false;

                rrLineBC.enabled = true;

                rrLineAE.enabled = true;
                rrLineSAE.enabled = false;

                rrLineBF.enabled = true;

                rrLineSDG.enabled = kyotuEla.tenmetuOnOff;

                //＞point：gameobjectを見えるようにする
                rrPointD.enabled = true;

                rrPointA.enabled = true;

                rrPointB.enabled = true;

                rrPointC.enabled = true;

                rrPointG.enabled = true;

                rrPointH.enabled = true;

                rrPointK.enabled = true;

                rrPointL.enabled = true;


                ////＞circle：gameobjectを見えるようにする
                rrBigCircle.enabled = true;

                rrSmallCircle.enabled = true;

                ////＞text：gameobjectを見えるようにする
                rrTextD.enabled = true;
                rrTextA.enabled = true;
                rrTextB.enabled = true;
                rrTextH.enabled = true;
                rrTextC.enabled = true;
                rrTextG.enabled = true;
                rrTextL.enabled = true;
                rrTextE.enabled = true;
                rrTextF.enabled = true;
                rrTextK.enabled = true;
            } else if (count == 40) {
                reset();
                //gameobjectを見えるようにする

                rrLineAB.enabled = true;
                rrLineSAB.enabled = false;

                rrLineDA.enabled = true;
                rrLineSDA.enabled = false;

                rrLineDB.enabled = true;
                rrLineSDB.enabled = false;

                rrLineBC.enabled = true;

                rrLineAE.enabled = true;
                rrLineSAE.enabled = false;

                rrLineBF.enabled = true;

                //＞point：gameobjectを見えるようにする
                rrPointD.enabled = true;

                rrPointA.enabled = true;

                rrPointB.enabled = true;

                rrPointC.enabled = true;

                rrPointG.enabled = true;

                rrPointH.enabled = true;

                rrPointK.enabled = true;

                rrPointL.enabled = true;


                ////＞circle：gameobjectを見えるようにする
                rrBigCircle.enabled = true;

                rrSmallCircle.enabled = true;

                ////＞text：gameobjectを見えるようにする
                rrTextD.enabled = true;
                rrTextA.enabled = true;
                rrTextB.enabled = true;
                rrTextH.enabled = true;
                rrTextC.enabled = true;
                rrTextG.enabled = true;
                rrTextL.enabled = true;
                rrTextE.enabled = true;
                rrTextF.enabled = true;
                rrTextK.enabled = true;
            } else if (count == 41) {
                reset();
                //gameobjectを見えるようにする
                //＞line：gameobjectを見えるようにする

                rrLineAB.enabled = true;
                rrLineSAB.enabled = false;

                rrLineDA.enabled = true;
                rrLineSDA.enabled = kyotuEla.tenmetuOnOff;

                rrLineDB.enabled = true;
                rrLineSDB.enabled = false;

                rrLineBC.enabled = true;

                rrLineAE.enabled = true;
                rrLineSAE.enabled = false;

                rrLineBF.enabled = true;
                
                rrPointD.enabled = true;

                rrPointA.enabled = true;

                rrPointB.enabled = true;

                rrPointC.enabled = true;

                rrPointG.enabled = true;

                rrPointH.enabled = true;

                rrPointK.enabled = true;

                rrPointL.enabled = true;

                ////＞circle：gameobjectを見えるようにする
                rrBigCircle.enabled = true;

                rrSmallCircle.enabled = true;

                ////＞text：gameobjectを見えるようにする
                rrTextD.enabled = true;
                rrTextA.enabled = true;
                rrTextB.enabled = true;
                rrTextH.enabled = true;
                rrTextC.enabled = true;
                rrTextG.enabled = true;
                rrTextL.enabled = true;
                rrTextE.enabled = true;
                rrTextF.enabled = true;
                rrTextK.enabled = true;
            } else if (count == 42) {
                reset();
                //gameobjectを見えるようにする
                //＞line：gameobjectを見えるようにする

                rrLineAB.enabled = true;
                rrLineSAB.enabled = false;

                rrLineDA.enabled = true;

                rrLineDB.enabled = true;
                rrLineSDB.enabled = kyotuEla.tenmetuOnOff;

                rrLineBC.enabled = true;

                rrLineAE.enabled = true;
                rrLineSAE.enabled = false;

                rrLineBF.enabled = true;
                
                //＞point：gameobjectを見えるようにする
                rrPointD.enabled = true;

                rrPointA.enabled = true;

                rrPointB.enabled = true;

                rrPointC.enabled = true;

                rrPointG.enabled = true;

                rrPointH.enabled = true;

                rrPointK.enabled = true;

                rrPointL.enabled = true;

                ////＞circle：gameobjectを見えるようにする
                rrBigCircle.enabled = true;

                rrSmallCircle.enabled = true;

                ////＞text：gameobjectを見えるようにする
                rrTextD.enabled = true;
                rrTextA.enabled = true;
                rrTextB.enabled = true;
                rrTextH.enabled = true;
                rrTextC.enabled = true;
                rrTextG.enabled = true;
                rrTextL.enabled = true;
                rrTextE.enabled = true;
                rrTextF.enabled = true;
                rrTextK.enabled = true;
            } else if (count == 43) {
                reset();
                //gameobjectを見えるようにする
                //＞line：gameobjectを見えるようにする

                rrLineAB.enabled = true;
                rrLineSAB.enabled = false;
                //kyotuEla.tenmetuOnOff;

                rrLineSAL.enabled= kyotuEla.tenmetuOnOff;

                rrLineDA.enabled = true;

                rrLineDB.enabled = true;

                rrLineBC.enabled = true;

                rrLineAE.enabled = true;
                rrLineSAE.enabled = false;

                rrLineBF.enabled = true;
                
                //＞point：gameobjectを見えるようにする
                rrPointD.enabled = true;

                rrPointA.enabled = true;

                rrPointB.enabled = true;

                rrPointC.enabled = true;

                rrPointG.enabled = true;

                rrPointH.enabled = true;

                rrPointK.enabled = true;

                rrPointL.enabled = true;


                ////＞circle：gameobjectを見えるようにする
                rrBigCircle.enabled = true;

                rrSmallCircle.enabled = true;

                ////＞text：gameobjectを見えるようにする
                rrTextD.enabled = true;
                rrTextA.enabled = true;
                rrTextB.enabled = true;
                rrTextH.enabled = true;
                rrTextC.enabled = true;
                rrTextG.enabled = true;
                rrTextL.enabled = true;
                rrTextE.enabled = true;
                rrTextF.enabled = true;
                rrTextK.enabled = true;
            } else if (count == 44) {
                reset();
                //gameobjectを見えるようにする
                //＞line：gameobjectを見えるようにする

                rrLineAB.enabled = true;
                rrLineSAB.enabled = false;

                rrLineDA.enabled = true;

                rrLineDB.enabled = true;

                rrLineBC.enabled = true;

                rrLineAE.enabled = true;
                rrLineSAE.enabled = false;

                rrLineBF.enabled = true;

                rrLineSBG.enabled = kyotuEla.tenmetuOnOff;

                //＞point：gameobjectを見えるようにする
                rrPointD.enabled = true;

                rrPointA.enabled = true;

                rrPointB.enabled = true;

                rrPointC.enabled = true;

                rrPointG.enabled = true;

                rrPointH.enabled = true;

                rrPointK.enabled = true;

                rrPointL.enabled = true;

                ////＞circle：gameobjectを見えるようにする
                rrBigCircle.enabled = true;

                rrSmallCircle.enabled = true;

                ////＞text：gameobjectを見えるようにする
                rrTextD.enabled = true;
                rrTextA.enabled = true;
                rrTextB.enabled = true;
                rrTextH.enabled = true;
                rrTextC.enabled = true;
                rrTextG.enabled = true;
                rrTextL.enabled = true;
                rrTextE.enabled = true;
                rrTextF.enabled = true;
                rrTextK.enabled = true;
            } else if (count == 45) {
                reset();
                //gameobjectを見えるようにする
                //＞line：gameobjectを見えるようにする

                rrLineAB.enabled = true;
                rrLineSAB.enabled = false;

                rrLineDA.enabled = true;

                rrLineDB.enabled = true;

                rrLineBC.enabled = true;

                rrLineAE.enabled = true;
                rrLineSAE.enabled = false;

                rrLineBF.enabled = true;

                //＞point：gameobjectを見えるようにする
                rrPointD.enabled = true;

                rrPointA.enabled = true;

                rrPointB.enabled = true;

                rrPointC.enabled = true;

                rrPointG.enabled = true;

                rrPointH.enabled = true;

                rrPointK.enabled = true;

                rrPointL.enabled = true;

                ////＞circle：gameobjectを見えるようにする
                rrBigCircle.enabled = true;

                rrSmallCircle.enabled = true;

                ////＞text：gameobjectを見えるようにする
                rrTextD.enabled = true;
                rrTextA.enabled = true;
                rrTextB.enabled = true;
                rrTextH.enabled = true;
                rrTextC.enabled = true;
                rrTextG.enabled = true;
                rrTextL.enabled = true;
                rrTextE.enabled = true;
                rrTextF.enabled = true;
                rrTextK.enabled = true;
            } else if (count == 46) {
                reset();
                //gameobjectを見えるようにする
                //＞line：gameobjectを見えるようにする

                rrLineAB.enabled = true;
                rrLineSAB.enabled = false;

                rrLineDA.enabled = true;

                rrLineDB.enabled = true;

                rrLineBC.enabled = true;
                rrLineSBC.enabled = kyotuEla.tenmetuOnOff;

                rrLineAE.enabled = true;
                rrLineSAE.enabled = false;

                rrLineBF.enabled = true;

                //＞point：gameobjectを見えるようにする
                rrPointD.enabled = true;

                rrPointA.enabled = true;

                rrPointB.enabled = true;

                rrPointC.enabled = true;

                rrPointG.enabled = true;

                rrPointH.enabled = true;

                rrPointK.enabled = true;

                rrPointL.enabled = true;

                ////＞circle：gameobjectを見えるようにする
                rrBigCircle.enabled = true;

                rrSmallCircle.enabled = true;

                ////＞text：gameobjectを見えるようにする
                rrTextD.enabled = true;
                rrTextA.enabled = true;
                rrTextB.enabled = true;
                rrTextH.enabled = true;
                rrTextC.enabled = true;
                rrTextG.enabled = true;
                rrTextL.enabled = true;
                rrTextE.enabled = true;
                rrTextF.enabled = true;
                rrTextK.enabled = true;
            } else if (count == 47) {
                reset();
                //gameobjectを見えるようにする
                //＞line：gameobjectを見えるようにする

                rrLineAB.enabled = true;
                rrLineSAB.enabled = false;

                rrLineDA.enabled = true;

                rrLineDB.enabled = true;

                rrLineBC.enabled = true;

                rrLineSBG.enabled = kyotuEla.tenmetuOnOff;

                rrLineAE.enabled = true;
                rrLineSAE.enabled = false;

                rrLineBF.enabled = true;
                
                //＞point：gameobjectを見えるようにする
                rrPointD.enabled = true;

                rrPointA.enabled = true;

                rrPointB.enabled = true;

                rrPointC.enabled = true;

                rrPointG.enabled = true;

                rrPointH.enabled = true;

                rrPointK.enabled = true;

                rrPointL.enabled = true;

                ////＞circle：gameobjectを見えるようにする
                rrBigCircle.enabled = true;

                rrSmallCircle.enabled = true;

                ////＞text：gameobjectを見えるようにする
                rrTextD.enabled = true;
                rrTextA.enabled = true;
                rrTextB.enabled = true;
                rrTextH.enabled = true;
                rrTextC.enabled = true;
                rrTextG.enabled = true;
                rrTextL.enabled = true;
                rrTextE.enabled = true;
                rrTextF.enabled = true;
                rrTextK.enabled = true;
            } else if (count == 48) {
                reset();
                //gameobjectを見えるようにする
                //＞line：gameobjectを見えるようにする

                rrLineAB.enabled = true;
                rrLineSAB.enabled = false;

                rrLineSAL.enabled = kyotuEla.tenmetuOnOff;

                rrLineDA.enabled = true;

                rrLineDB.enabled = true;

                rrLineBC.enabled = true;

                rrLineAE.enabled = true;
                rrLineSAE.enabled = false;

                rrLineBF.enabled = true;
                
                //＞point：gameobjectを見えるようにする
                rrPointD.enabled = true;

                rrPointA.enabled = true;

                rrPointB.enabled = true;

                rrPointC.enabled = true;

                rrPointG.enabled = true;

                rrPointH.enabled = true;

                rrPointK.enabled = true;

                rrPointL.enabled = true;

                ////＞circle：gameobjectを見えるようにする
                rrBigCircle.enabled = true;

                rrSmallCircle.enabled = true;

                ////＞text：gameobjectを見えるようにする
                rrTextD.enabled = true;
                rrTextA.enabled = true;
                rrTextB.enabled = true;
                rrTextH.enabled = true;
                rrTextC.enabled = true;
                rrTextG.enabled = true;
                rrTextL.enabled = true;
                rrTextE.enabled = true;
                rrTextF.enabled = true;
                rrTextK.enabled = true;
            } else if (count == 49) {
                reset();
                //gameobjectを見えるようにする
                //＞line：gameobjectを見えるようにする

                rrLineAB.enabled = true;
                rrLineSAB.enabled = false;

                rrLineDA.enabled = true;

                rrLineDB.enabled = true;

                rrLineBC.enabled = true;
                rrLineSBC.enabled = kyotuEla.tenmetuOnOff;

                rrLineAE.enabled = true;
                rrLineSAE.enabled = false;

                rrLineBF.enabled = true;

                //＞point：gameobjectを見えるようにする
                rrPointD.enabled = true;

                rrPointA.enabled = true;

                rrPointB.enabled = true;

                rrPointC.enabled = true;

                rrPointG.enabled = true;

                rrPointH.enabled = true;

                rrPointK.enabled = true;

                rrPointL.enabled = true;

                ////＞circle：gameobjectを見えるようにする
                rrBigCircle.enabled = true;

                rrSmallCircle.enabled = true;

                ////＞text：gameobjectを見えるようにする
                rrTextD.enabled = true;
                rrTextA.enabled = true;
                rrTextB.enabled = true;
                rrTextH.enabled = true;
                rrTextC.enabled = true;
                rrTextG.enabled = true;
                rrTextL.enabled = true;
                rrTextE.enabled = true;
                rrTextF.enabled = true;
                rrTextK.enabled = true;
            } else if (count == 50) {
                reset();
                //gameobjectを見えるようにする
                //＞line：gameobjectを見えるようにする

                rrLineAB.enabled = true;
                rrLineSAB.enabled = false;

                rrLineDA.enabled = true;

                rrLineDB.enabled = true;

                rrLineBC.enabled = true;

                rrLineAE.enabled = true;
                rrLineSAE.enabled = false;

                rrLineBF.enabled = true;

                //＞point：gameobjectを見えるようにする
                rrPointD.enabled = true;

                rrPointA.enabled = true;

                rrPointB.enabled = true;

                rrPointC.enabled = true;

                rrPointG.enabled = true;

                rrPointH.enabled = true;

                rrPointK.enabled = true;

                rrPointL.enabled = true;

                ////＞circle：gameobjectを見えるようにする
                rrBigCircle.enabled = true;

                rrSmallCircle.enabled = true;

                ////＞text：gameobjectを見えるようにする
                rrTextD.enabled = true;
                rrTextA.enabled = true;
                rrTextB.enabled = true;
                rrTextH.enabled = true;
                rrTextC.enabled = true;
                rrTextG.enabled = true;
                rrTextL.enabled = true;
                rrTextE.enabled = true;
                rrTextF.enabled = true;
                rrTextK.enabled = true;
            } else if (count == 51) {
                reset();
                //gameobjectを見えるようにする
                //＞line：gameobjectを見えるようにする

                rrLineAB.enabled = true;
                rrLineSAB.enabled = false;

                rrLineSAL.enabled = kyotuEla.tenmetuOnOff;

                rrLineDA.enabled = true;

                rrLineDB.enabled = true;

                rrLineBC.enabled = true;

                rrLineAE.enabled = true;
                rrLineSAE.enabled = false;

                rrLineBF.enabled = true;

                //＞point：gameobjectを見えるようにする
                rrPointD.enabled = true;

                rrPointA.enabled = true;

                rrPointB.enabled = true;

                rrPointC.enabled = true;

                rrPointG.enabled = true;

                rrPointH.enabled = true;

                rrPointK.enabled = true;

                rrPointL.enabled = true;


                ////＞circle：gameobjectを見えるようにする
                rrBigCircle.enabled = true;

                rrSmallCircle.enabled = true;

                ////＞text：gameobjectを見えるようにする
                rrTextD.enabled = true;
                rrTextA.enabled = true;
                rrTextB.enabled = true;
                rrTextH.enabled = true;
                rrTextC.enabled = true;
                rrTextG.enabled = true;
                rrTextL.enabled = true;
                rrTextE.enabled = true;
                rrTextF.enabled = true;
                rrTextK.enabled = true;
            } else if (count == 52) {
                reset();
                //gameobjectを見えるようにする
                //＞line：gameobjectを見えるようにする

                rrLineAB.enabled = true;
                rrLineSAB.enabled = false;

                rrLineDA.enabled = true;

                rrLineDB.enabled = true;

                rrLineBC.enabled = true;
                rrLineSBC.enabled = kyotuEla.tenmetuOnOff;

                rrLineAE.enabled = true;
                rrLineSAE.enabled = false;

                rrLineBF.enabled = true;

                //＞point：gameobjectを見えるようにする
                rrPointD.enabled = true;

                rrPointA.enabled = true;

                rrPointB.enabled = true;

                rrPointC.enabled = true;

                rrPointG.enabled = true;

                rrPointH.enabled = true;

                rrPointK.enabled = true;

                rrPointL.enabled = true;

                ////＞circle：gameobjectを見えるようにする
                rrBigCircle.enabled = true;

                rrSmallCircle.enabled = true;

                ////＞text：gameobjectを見えるようにする
                rrTextD.enabled = true;
                rrTextA.enabled = true;
                rrTextB.enabled = true;
                rrTextH.enabled = true;
                rrTextC.enabled = true;
                rrTextG.enabled = true;
                rrTextL.enabled = true;
                rrTextE.enabled = true;
                rrTextF.enabled = true;
                rrTextK.enabled = true;
            } else if (count == 53) {
                reset();
                //gameobjectを見えるようにする
                //＞line：gameobjectを見えるようにする

                rrLineAB.enabled = true;
                rrLineSAB.enabled = false;

                rrLineDA.enabled = true;

                rrLineDB.enabled = true;

                rrLineBC.enabled = true;

                rrLineAE.enabled = true;
                rrLineSAE.enabled = false;

                rrLineBF.enabled = true;

                //＞point：gameobjectを見えるようにする
                rrPointD.enabled = true;

                rrPointA.enabled = true;
                rrStPointA.enabled = kyotuEla.tenmetuOnOff;

                rrPointB.enabled = true;

                rrPointC.enabled = true;

                rrPointG.enabled = true;

                rrPointH.enabled = true;

                rrPointK.enabled = true;

                rrPointL.enabled = true;

                ////＞circle：gameobjectを見えるようにする
                rrBigCircle.enabled = true;

                rrSmallCircle.enabled = true;

                ////＞text：gameobjectを見えるようにする
                rrTextD.enabled = true;
                rrTextA.enabled = true;
                rrTextB.enabled = true;
                rrTextH.enabled = true;
                rrTextC.enabled = true;
                rrTextG.enabled = true;
                rrTextL.enabled = true;
                rrTextE.enabled = true;
                rrTextF.enabled = true;
                rrTextK.enabled = true;
            } else if (count == 54) {
                reset();
                //gameobjectを見えるようにする
                //＞line：gameobjectを見えるようにする

                rrLineAB.enabled = true;
                rrLineSAB.enabled = false;

                rrLineDA.enabled = true;

                rrLineDB.enabled = true;

                rrLineBC.enabled = true;

                rrLineAE.enabled = true;
                rrLineSAE.enabled = false;

                rrLineBF.enabled = true;

                //＞point：gameobjectを見えるようにする
                rrPointD.enabled = true;

                rrPointA.enabled = true;

                rrPointB.enabled = true;

                rrPointC.enabled = true;

                rrPointG.enabled = true;

                rrPointH.enabled = true;

                rrPointK.enabled = true;

                rrPointL.enabled = true;

                ////＞circle：gameobjectを見えるようにする
                rrBigCircle.enabled = true;

                rrSmallCircle.enabled = true;

                ////＞text：gameobjectを見えるようにする
                rrTextD.enabled = true;
                rrTextA.enabled = true;
                rrTextB.enabled = true;
                rrTextH.enabled = true;
                rrTextC.enabled = true;
                rrTextG.enabled = true;
                rrTextL.enabled = true;
                rrTextE.enabled = true;
                rrTextF.enabled = true;
                rrTextK.enabled = true;
            }
        }
    }

}
