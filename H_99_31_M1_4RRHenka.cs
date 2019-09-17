using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class H_99_31_M1_4RRHenka : MonoBehaviour {
    //M1_3preにアタッチ。オブジェクト全体のいどうをするプログラム
    //いちいちunityで当てはめなきゃ駄目　↓---------------

    //k5_3_1_1:gameobject(メソッド、変数)を使いまわす
    public H_99_01_kyoutuHensu kyotu;

    //強調表現点滅に使う変数を共通変数として使う。
    public H_99_01B_kyotuElapse kyotuEla;

    public GameObject M1_4LineAB;
    public GameObject M1_4LineBC;
    public GameObject M1_4LineCA;
    public GameObject M1_4LineDE;
    public GameObject M1_4LineEF;
    public GameObject M1_4LineFD;

    public GameObject M1_4LineStAB;
    public GameObject M1_4LineStBC;
    public GameObject M1_4LineStCA;
    public GameObject M1_4LineStDE;
    public GameObject M1_4LineStEF;
    public GameObject M1_4LineStFD;

    public GameObject M1_4LineStAB2;
    public GameObject M1_4LineStCA2;
    public GameObject M1_4LineStDE2;
    public GameObject M1_4LineStFD2;

    public GameObject M1_4PointA;
    public GameObject M1_4PointB;
    public GameObject M1_4PointC;
    public GameObject M1_4PointD;
    public GameObject M1_4PointE;
    public GameObject M1_4PointF;

    public GameObject M1_4PointStA;
    public GameObject M1_4PointStB;
    public GameObject M1_4PointStC;
    public GameObject M1_4PointStD;
    public GameObject M1_4PointStE;
    public GameObject M1_4PointStF;

    public GameObject M1_4TextA;
    public GameObject M1_4TextB;
    public GameObject M1_4TextC;
    public GameObject M1_4TextD;
    public GameObject M1_4TextE;
    public GameObject M1_4TextF;

   

    public GameObject M1_4kakuBAC;
    public GameObject M1_4kakuStBAC;
    public GameObject M1_4kakuABC;
    public GameObject M1_4kakuStABC;
    public GameObject M1_4kakuACB;
    public GameObject M1_4kakuStACB;

    public GameObject M1_4kakuEDF;
    public GameObject M1_4kakuStEDF;
    public GameObject M1_4kakuDEF;
    public GameObject M1_4kakuStDEF;
    public GameObject M1_4kakuDFE;
    public GameObject M1_4kakuStDFE;


    private Renderer rrM1_4LineAB;
    private Renderer rrM1_4LineBC;
    private Renderer rrM1_4LineCA;
    private Renderer rrM1_4LineDE;
    private Renderer rrM1_4LineEF;
    private Renderer rrM1_4LineFD;

    private Renderer rrM1_4LineStAB;
    private Renderer rrM1_4LineStBC;
    private Renderer rrM1_4LineStCA;
    private Renderer rrM1_4LineStDE;
    private Renderer rrM1_4LineStEF;
    private Renderer rrM1_4LineStFD;

    private Renderer rrM1_4LineStAB2;
    private Renderer rrM1_4LineStCA2;
    private Renderer rrM1_4LineStDE2;
    private Renderer rrM1_4LineStFD2;

    private Renderer rrM1_4PointA;
    private Renderer rrM1_4PointB;
    private Renderer rrM1_4PointC;
    private Renderer rrM1_4PointD;
    private Renderer rrM1_4PointE;
    private Renderer rrM1_4PointF;

    private Renderer rrM1_4PointStA;
    private Renderer rrM1_4PointStB;
    private Renderer rrM1_4PointStC;
    private Renderer rrM1_4PointStD;
    private Renderer rrM1_4PointStE;
    private Renderer rrM1_4PointStF;

    private Renderer rrM1_4TextA;
    private Renderer rrM1_4TextB;
    private Renderer rrM1_4TextC;
    private Renderer rrM1_4TextD;
    private Renderer rrM1_4TextE;
    private Renderer rrM1_4TextF;

   

    private Renderer rrM1_4kakuBAC;
    private Renderer rrM1_4kakuStBAC;
    private Renderer rrM1_4kakuABC;
    private Renderer rrM1_4kakuStABC;
    private Renderer rrM1_4kakuACB;
    private Renderer rrM1_4kakuStACB;

    private Renderer rrM1_4kakuEDF;
    private Renderer rrM1_4kakuStEDF;
    private Renderer rrM1_4kakuDEF;
    private Renderer rrM1_4kakuStDEF;
    private Renderer rrM1_4kakuDFE;
    private Renderer rrM1_4kakuStDFE;

    void Start() {
        rrM1_4LineAB = M1_4LineAB.GetComponent<Renderer>();
        rrM1_4LineBC = M1_4LineBC.GetComponent<Renderer>();
        rrM1_4LineCA = M1_4LineCA.GetComponent<Renderer>();
        rrM1_4LineDE = M1_4LineDE.GetComponent<Renderer>();
        rrM1_4LineEF = M1_4LineEF.GetComponent<Renderer>();
        rrM1_4LineFD = M1_4LineFD.GetComponent<Renderer>();

        rrM1_4LineStAB = M1_4LineStAB.GetComponent<Renderer>();
        rrM1_4LineStBC = M1_4LineStBC.GetComponent<Renderer>();
        rrM1_4LineStCA = M1_4LineStCA.GetComponent<Renderer>();
        rrM1_4LineStDE = M1_4LineStDE.GetComponent<Renderer>();
        rrM1_4LineStEF = M1_4LineStEF.GetComponent<Renderer>();
        rrM1_4LineStFD = M1_4LineStFD.GetComponent<Renderer>();

        rrM1_4LineStAB2 = M1_4LineStAB2.GetComponent<Renderer>();
        rrM1_4LineStCA2 = M1_4LineStCA2.GetComponent<Renderer>();

        rrM1_4LineStDE2 = M1_4LineStDE2.GetComponent<Renderer>();
        rrM1_4LineStFD2 = M1_4LineStFD2.GetComponent<Renderer>();

        rrM1_4PointA = M1_4PointA.GetComponent<Renderer>();
        rrM1_4PointB = M1_4PointB.GetComponent<Renderer>();
        rrM1_4PointC = M1_4PointC.GetComponent<Renderer>();
        rrM1_4PointD = M1_4PointD.GetComponent<Renderer>();
        rrM1_4PointE = M1_4PointE.GetComponent<Renderer>();
        rrM1_4PointF = M1_4PointF.GetComponent<Renderer>();

        rrM1_4PointStA = M1_4PointStA.GetComponent<Renderer>();
        rrM1_4PointStB = M1_4PointStB.GetComponent<Renderer>();
        rrM1_4PointStC = M1_4PointStC.GetComponent<Renderer>();
        rrM1_4PointStD = M1_4PointStD.GetComponent<Renderer>();
        rrM1_4PointStE = M1_4PointStE.GetComponent<Renderer>();
        rrM1_4PointStF = M1_4PointStF.GetComponent<Renderer>();

        rrM1_4TextA = M1_4TextA.GetComponent<Renderer>();
        rrM1_4TextB = M1_4TextB.GetComponent<Renderer>();
        rrM1_4TextC = M1_4TextC.GetComponent<Renderer>();
        rrM1_4TextD = M1_4TextD.GetComponent<Renderer>();
        rrM1_4TextE = M1_4TextE.GetComponent<Renderer>();
        rrM1_4TextF = M1_4TextF.GetComponent<Renderer>();

       

        rrM1_4kakuBAC = M1_4kakuBAC.GetComponent<Renderer>();
        rrM1_4kakuStBAC = M1_4kakuStBAC.GetComponent<Renderer>();
        rrM1_4kakuABC = M1_4kakuABC.GetComponent<Renderer>();
        rrM1_4kakuStABC = M1_4kakuStABC.GetComponent<Renderer>();
        rrM1_4kakuACB = M1_4kakuACB.GetComponent<Renderer>();
        rrM1_4kakuStACB = M1_4kakuStACB.GetComponent<Renderer>();


        rrM1_4kakuEDF = M1_4kakuEDF.GetComponent<Renderer>();
        rrM1_4kakuStEDF = M1_4kakuStEDF.GetComponent<Renderer>();
        rrM1_4kakuDEF = M1_4kakuDEF.GetComponent<Renderer>();
        rrM1_4kakuStDEF = M1_4kakuStDEF.GetComponent<Renderer>();
        rrM1_4kakuDFE = M1_4kakuDFE.GetComponent<Renderer>();
        rrM1_4kakuStDFE = M1_4kakuStDFE.GetComponent<Renderer>();

    }
    //リセット表示を全部消すメソッド　kyotu.rrcount-----------------------------
    private void reset() {
        //k7B_1_1:オブジェを存在するけど見えなくする。
        //this.gameObject.GetComponent<Renderer>().enabled = false; 

        //k7B_1_2:オブジェを見えるようにするよ。
        //this.gameObject.GetComponent<Renderer>().enabled = true;

        //gameobjectを見えなくする
        //＞line：gameobjectを見えなくする

        rrM1_4LineAB.enabled = false;
        rrM1_4LineStAB.enabled = false;
        rrM1_4LineStAB2.enabled = false;


        rrM1_4LineBC.enabled = false;
        rrM1_4LineStBC.enabled = false;

        rrM1_4LineCA.enabled = false;
        rrM1_4LineStCA.enabled = false;
        rrM1_4LineStCA2.enabled = false;


        rrM1_4LineDE.enabled = false;
        rrM1_4LineStDE.enabled = false;
        rrM1_4LineStDE2.enabled = false;


        rrM1_4LineEF.enabled = false;
        rrM1_4LineStEF.enabled = false;

        rrM1_4LineFD.enabled = false;
        rrM1_4LineStFD.enabled = false;
        rrM1_4LineStFD2.enabled = false;


        //＞point：gameobjectを見えなくする
        rrM1_4PointA.enabled = false;
        rrM1_4PointB.enabled = false;
        rrM1_4PointC.enabled = false;

        rrM1_4PointD.enabled = false;
        rrM1_4PointE.enabled = false;
        rrM1_4PointF.enabled = false;
        //＞pointSt：gameobjectを見えなくする
        rrM1_4PointStA.enabled = false;
        rrM1_4PointStB.enabled = false;
        rrM1_4PointStC.enabled = false;
        rrM1_4PointStD.enabled = false;
        rrM1_4PointStE.enabled = false;
        rrM1_4PointStF.enabled = false;

        ////＞text：gameobjectを見えなくする
        rrM1_4TextA.enabled = false;
        rrM1_4TextB.enabled = false;
        rrM1_4TextC.enabled = false;
        rrM1_4TextD.enabled = false;
        rrM1_4TextE.enabled = false;
        rrM1_4TextF.enabled = false;

        rrM1_4kakuBAC.enabled = false;
        rrM1_4kakuStBAC.enabled = false;
        rrM1_4kakuABC.enabled = false;
        rrM1_4kakuStABC.enabled = false;
        rrM1_4kakuACB.enabled = false;
        rrM1_4kakuStACB.enabled = false;

        rrM1_4kakuEDF.enabled = false;
        rrM1_4kakuStEDF.enabled = false;
        rrM1_4kakuDEF.enabled = false;
        rrM1_4kakuStDEF.enabled = false;
        rrM1_4kakuDFE.enabled = false;
        rrM1_4kakuStDFE.enabled = false;
    }

    // Update is called once per frame
    void Update() 
    {

        henka(kyotu.rrCount);
        //Debug.Log("M1_4RRHenka::" + kyotu.mojiSwitch + "::MC::" + kyotu.MCount + "::RRC::" + kyotu.rrCount);

    }
    //rrCountでオブジェの表示、強調を変化させるメソッド---------------------------
    private void henka(int count) 
    {
        //m1_3のときのみ実行
        if (kyotu.mojiSwitch == 3 & kyotu.MCount == 3) 
        {
            if (count == 0) 
            {
                reset();
                rrM1_4LineAB.enabled = false;
                rrM1_4LineStAB.enabled = false;
                rrM1_4LineStAB2.enabled = false;


                rrM1_4LineBC.enabled = false;
                rrM1_4LineStBC.enabled = false;

                rrM1_4LineCA.enabled = false;
                rrM1_4LineStCA.enabled = false;
                rrM1_4LineStCA2.enabled = false;


                rrM1_4LineDE.enabled = false;
                rrM1_4LineStDE.enabled = false;
                rrM1_4LineStDE2.enabled = false;


                rrM1_4LineEF.enabled = false;
                rrM1_4LineStEF.enabled = false;

                rrM1_4LineFD.enabled = false;
                rrM1_4LineStFD.enabled = false;
                rrM1_4LineStFD2.enabled = false;


                //＞point：gameobjectを見えなくする
                rrM1_4PointA.enabled = false;
                rrM1_4PointB.enabled = false;
                rrM1_4PointC.enabled = false;

                rrM1_4PointD.enabled = false;
                rrM1_4PointE.enabled = false;
                rrM1_4PointF.enabled = false;
                //＞pointSt：gameobjectを見えなくする
                rrM1_4PointStA.enabled = false;
                rrM1_4PointStB.enabled = false;
                rrM1_4PointStC.enabled = false;
                rrM1_4PointStD.enabled = false;
                rrM1_4PointStE.enabled = false;
                rrM1_4PointStF.enabled = false;

                ////＞text：gameobjectを見えなくする
                rrM1_4TextA.enabled = false;
                rrM1_4TextB.enabled = false;
                rrM1_4TextC.enabled = false;
                rrM1_4TextD.enabled = false;
                rrM1_4TextE.enabled = false;
                rrM1_4TextF.enabled = false;

                rrM1_4kakuBAC.enabled = false;
                rrM1_4kakuStBAC.enabled = false;
                rrM1_4kakuABC.enabled = false;
                rrM1_4kakuStABC.enabled = false;
                rrM1_4kakuACB.enabled = false;
                rrM1_4kakuStACB.enabled = false;

                rrM1_4kakuEDF.enabled = false;
                rrM1_4kakuStEDF.enabled = false;
                rrM1_4kakuDEF.enabled = false;
                rrM1_4kakuStDEF.enabled = false;
                rrM1_4kakuDFE.enabled = false;
                rrM1_4kakuStDFE.enabled = false;

            }
            else if (count == 1) 
            {
                reset();
                rrM1_4LineAB.enabled = true;
                rrM1_4LineStAB.enabled =kyotuEla.tenmetuOnOff; 

                rrM1_4LineBC.enabled = true;
                rrM1_4LineStBC.enabled = kyotuEla.tenmetuOnOff;

                rrM1_4LineCA.enabled = true;
                rrM1_4LineStCA.enabled = kyotuEla.tenmetuOnOff;

                rrM1_4LineDE.enabled = true;
                rrM1_4LineStDE.enabled = kyotuEla.tenmetuOnOff;

                rrM1_4LineEF.enabled = true;
                rrM1_4LineStEF.enabled = kyotuEla.tenmetuOnOff;

                rrM1_4LineFD.enabled = true;
                rrM1_4LineStFD.enabled = kyotuEla.tenmetuOnOff;
            }
            else if (count == 2) 
            {
                reset();
                rrM1_4LineAB.enabled = true;
                rrM1_4LineStAB.enabled = false; 
                    //kyotuEla.tenmetuOnOff;
                rrM1_4LineStAB2.enabled = kyotuEla.tenmetuOnOff;

                rrM1_4LineBC.enabled = true;
                rrM1_4LineStBC.enabled = //kyotuEla.tenmetuOnOff;
                    false;

                rrM1_4LineCA.enabled = true;
                rrM1_4LineStCA.enabled =//kyotuEla.tenmetuOnOff;
                    false;
                rrM1_4LineStCA2.enabled =kyotuEla.tenmetuOnOff;
                    //false;

                rrM1_4LineDE.enabled = true;
                rrM1_4LineStDE.enabled = //kyotuEla.tenmetuOnOff;
                    false;
                rrM1_4LineStDE2.enabled = kyotuEla.tenmetuOnOff;
                    //false;

                rrM1_4LineEF.enabled = true;
                rrM1_4LineStEF.enabled = //kyotuEla.tenmetuOnOff;
                    false;
                rrM1_4LineFD.enabled = true;
                rrM1_4LineStFD.enabled = //kyotuEla.tenmetuOnOff;
                    false;
                rrM1_4LineStFD2.enabled = kyotuEla.tenmetuOnOff;
                    //false;
            }
            else if (count == 3) {
                reset();
                rrM1_4LineAB.enabled = true;
                rrM1_4LineStAB.enabled = false;
                //kyotuEla.tenmetuOnOff;
                rrM1_4LineStAB2.enabled = //kyotuEla.tenmetuOnOff;
                    false;

                rrM1_4LineBC.enabled = true;
                rrM1_4LineStBC.enabled = //kyotuEla.tenmetuOnOff;
                    false;

                rrM1_4LineCA.enabled = true;
                rrM1_4LineStCA.enabled =//kyotuEla.tenmetuOnOff;
                    false;
                rrM1_4LineStCA2.enabled = //kyotuEla.tenmetuOnOff;
                    false;

                rrM1_4LineDE.enabled = true;
                rrM1_4LineStDE.enabled = //kyotuEla.tenmetuOnOff;
                    false;
                rrM1_4LineStDE2.enabled = //kyotuEla.tenmetuOnOff;
                    false;

                rrM1_4LineEF.enabled = true;
                rrM1_4LineStEF.enabled = //kyotuEla.tenmetuOnOff;
                    false;
                rrM1_4LineFD.enabled = true;
                rrM1_4LineStFD.enabled = //kyotuEla.tenmetuOnOff;
                    false;
                rrM1_4LineStFD2.enabled = //kyotuEla.tenmetuOnOff;
                    false;

                rrM1_4kakuBAC.enabled = true;
                rrM1_4kakuStBAC.enabled = kyotuEla.tenmetuOnOff;
                //false;

                rrM1_4kakuEDF.enabled = true;
                rrM1_4kakuStEDF.enabled = kyotuEla.tenmetuOnOff;
                //false;
            }
            else if (count == 4) {
                reset();
                rrM1_4LineAB.enabled = true;
                rrM1_4LineStAB.enabled = false;
                //kyotuEla.tenmetuOnOff;
                rrM1_4LineStAB2.enabled = //kyotuEla.tenmetuOnOff;
                    false;

                rrM1_4LineBC.enabled = true;
                rrM1_4LineStBC.enabled = kyotuEla.tenmetuOnOff;
                    //false;

                rrM1_4LineCA.enabled = true;
                rrM1_4LineStCA.enabled =//kyotuEla.tenmetuOnOff;
                    false;
                rrM1_4LineStCA2.enabled = //kyotuEla.tenmetuOnOff;
                    false;

                rrM1_4LineDE.enabled = true;
                rrM1_4LineStDE.enabled = //kyotuEla.tenmetuOnOff;
                    false;
                rrM1_4LineStDE2.enabled = //kyotuEla.tenmetuOnOff;
                    false;

                rrM1_4LineEF.enabled = true;
                rrM1_4LineStEF.enabled = kyotuEla.tenmetuOnOff;
                    //false;
                rrM1_4LineFD.enabled = true;
                rrM1_4LineStFD.enabled = //kyotuEla.tenmetuOnOff;
                    false;
                rrM1_4LineStFD2.enabled = //kyotuEla.tenmetuOnOff;
                    false;

                rrM1_4kakuBAC.enabled = true;
                rrM1_4kakuStBAC.enabled = 
                //kyotuEla.tenmetuOnOff;
                false;

                rrM1_4kakuEDF.enabled = true;
                rrM1_4kakuStEDF.enabled = 
                //kyotuEla.tenmetuOnOff;
                false;
            } else if (count == 5) {
                reset();
                rrM1_4LineAB.enabled = true;
                rrM1_4LineStAB.enabled = //false;
                kyotuEla.tenmetuOnOff;
                rrM1_4LineStAB2.enabled = //kyotuEla.tenmetuOnOff;
                    false;

                rrM1_4LineBC.enabled = true;
                rrM1_4LineStBC.enabled = kyotuEla.tenmetuOnOff;
                //false;

                rrM1_4LineCA.enabled = true;
                rrM1_4LineStCA.enabled =kyotuEla.tenmetuOnOff;
                    //false;
                rrM1_4LineStCA2.enabled = //kyotuEla.tenmetuOnOff;
                    false;

                rrM1_4LineDE.enabled = true;
                rrM1_4LineStDE.enabled = kyotuEla.tenmetuOnOff;
                    //false;
                rrM1_4LineStDE2.enabled = //kyotuEla.tenmetuOnOff;
                    false;

                rrM1_4LineEF.enabled = true;
                rrM1_4LineStEF.enabled = kyotuEla.tenmetuOnOff;
                //false;
                rrM1_4LineFD.enabled = true;
                rrM1_4LineStFD.enabled = kyotuEla.tenmetuOnOff;
                    //false;
                rrM1_4LineStFD2.enabled = //kyotuEla.tenmetuOnOff;
                    false;

                rrM1_4kakuBAC.enabled = true;
                rrM1_4kakuStBAC.enabled =
                //kyotuEla.tenmetuOnOff;
                false;

                rrM1_4kakuEDF.enabled = true;
                rrM1_4kakuStEDF.enabled =
                //kyotuEla.tenmetuOnOff;
                false;
            } else if (count == 6) {
                reset();
                rrM1_4LineAB.enabled = true;
                rrM1_4LineStAB.enabled = false;
                //kyotuEla.tenmetuOnOff;
                rrM1_4LineStAB2.enabled = kyotuEla.tenmetuOnOff;
                    //false;

                rrM1_4LineBC.enabled = true;
                rrM1_4LineStBC.enabled = //kyotuEla.tenmetuOnOff;
                false;

                rrM1_4LineCA.enabled = true;
                rrM1_4LineStCA.enabled = //kyotuEla.tenmetuOnOff;
                false;
                rrM1_4LineStCA2.enabled = kyotuEla.tenmetuOnOff;
                    //false;

                rrM1_4LineDE.enabled = true;
                rrM1_4LineStDE.enabled = //kyotuEla.tenmetuOnOff;
                false;
                rrM1_4LineStDE2.enabled = kyotuEla.tenmetuOnOff;
                    //false;

                rrM1_4LineEF.enabled = true;
                rrM1_4LineStEF.enabled = //kyotuEla.tenmetuOnOff;
                false;
                rrM1_4LineFD.enabled = true;
                rrM1_4LineStFD.enabled = //kyotuEla.tenmetuOnOff;
                false;
                rrM1_4LineStFD2.enabled = kyotuEla.tenmetuOnOff;
                    //false;

                rrM1_4kakuBAC.enabled = true;
                rrM1_4kakuStBAC.enabled =
                //kyotuEla.tenmetuOnOff;
                false;

                rrM1_4kakuEDF.enabled = true;
                rrM1_4kakuStEDF.enabled =
                //kyotuEla.tenmetuOnOff;
                false;
            } else if (count == 7) {
                reset();
                rrM1_4LineAB.enabled = true;
                rrM1_4LineStAB.enabled = false;
                //kyotuEla.tenmetuOnOff;
                rrM1_4LineStAB2.enabled = //kyotuEla.tenmetuOnOff;
                //false;
                true;

                rrM1_4LineBC.enabled = true;
                rrM1_4LineStBC.enabled = //kyotuEla.tenmetuOnOff;
                false;

                rrM1_4LineCA.enabled = true;
                rrM1_4LineStCA.enabled = //kyotuEla.tenmetuOnOff;
                false;
                rrM1_4LineStCA2.enabled = //kyotuEla.tenmetuOnOff;
                //false;
                true;


                rrM1_4LineDE.enabled = true;
                rrM1_4LineStDE.enabled = //kyotuEla.tenmetuOnOff;
                false;
                rrM1_4LineStDE2.enabled = //kyotuEla.tenmetuOnOff;
                //false;
                true;


                rrM1_4LineEF.enabled = true;
                rrM1_4LineStEF.enabled = //kyotuEla.tenmetuOnOff;
                false;
                rrM1_4LineFD.enabled = true;
                rrM1_4LineStFD.enabled = //kyotuEla.tenmetuOnOff;
                false;
                rrM1_4LineStFD2.enabled = //kyotuEla.tenmetuOnOff;
                //false;
                true;


                rrM1_4kakuBAC.enabled = true;
                rrM1_4kakuStBAC.enabled =
                //kyotuEla.tenmetuOnOff;
                false;

                rrM1_4kakuABC.enabled = true;
                rrM1_4kakuStABC.enabled =
                kyotuEla.tenmetuOnOff;
                //false;

                rrM1_4kakuACB.enabled = true;
                rrM1_4kakuStACB.enabled =
                kyotuEla.tenmetuOnOff;
                //false;


                rrM1_4kakuEDF.enabled = true;
                rrM1_4kakuStEDF.enabled =
                //kyotuEla.tenmetuOnOff;
                false;

                rrM1_4kakuDEF.enabled = true;
                rrM1_4kakuStDEF.enabled =
                kyotuEla.tenmetuOnOff;
                //false;

                rrM1_4kakuDFE.enabled = true;
                rrM1_4kakuStDFE.enabled =
                kyotuEla.tenmetuOnOff;
                //false;
            } else if (count == 8) {
                reset();
                rrM1_4LineAB.enabled = true;
                rrM1_4LineStAB.enabled = //false;
                kyotuEla.tenmetuOnOff;
                rrM1_4LineStAB2.enabled = //kyotuEla.tenmetuOnOff;
                false;
                //true;

                rrM1_4LineBC.enabled = true;
                rrM1_4LineStBC.enabled = kyotuEla.tenmetuOnOff;
                //false;

                rrM1_4LineCA.enabled = true;
                rrM1_4LineStCA.enabled = kyotuEla.tenmetuOnOff;
                //false;
                rrM1_4LineStCA2.enabled = //kyotuEla.tenmetuOnOff;
                false;
                //true;


                rrM1_4LineDE.enabled = true;
                rrM1_4LineStDE.enabled = //kyotuEla.tenmetuOnOff;
                false;
                rrM1_4LineStDE2.enabled = //kyotuEla.tenmetuOnOff;
                false;
                //true;


                rrM1_4LineEF.enabled = true;
                rrM1_4LineStEF.enabled = //kyotuEla.tenmetuOnOff;
                false;
                rrM1_4LineFD.enabled = true;
                rrM1_4LineStFD.enabled = //kyotuEla.tenmetuOnOff;
                false;
                rrM1_4LineStFD2.enabled = //kyotuEla.tenmetuOnOff;
                false;
                //true;


                rrM1_4kakuBAC.enabled = //true;
                    false;

                rrM1_4kakuStBAC.enabled =
                //kyotuEla.tenmetuOnOff;
                false;

                rrM1_4kakuABC.enabled = //true;
                    false;
                rrM1_4kakuStABC.enabled =
                //kyotuEla.tenmetuOnOff;
                false;

                rrM1_4kakuACB.enabled = //true;
                    false;

                rrM1_4kakuStACB.enabled =
                //kyotuEla.tenmetuOnOff;
                false;


                rrM1_4kakuEDF.enabled = //true;
                    false;

                rrM1_4kakuStEDF.enabled =
                //kyotuEla.tenmetuOnOff;
                false;

                rrM1_4kakuDEF.enabled = //true;
                    false;

                rrM1_4kakuStDEF.enabled =
                //kyotuEla.tenmetuOnOff;
                false;

                rrM1_4kakuDFE.enabled = //true;
                    false;

                rrM1_4kakuStDFE.enabled =
                //kyotuEla.tenmetuOnOff;
                false;

                rrM1_4TextA.enabled = true;
                rrM1_4TextB.enabled = true;
                rrM1_4TextC.enabled = true;

            } else if (count == 9) {
                reset();
                rrM1_4LineAB.enabled = true;
                rrM1_4LineStAB.enabled = false;
                //kyotuEla.tenmetuOnOff;
                rrM1_4LineStAB2.enabled = //kyotuEla.tenmetuOnOff;
                false;
                //true;

                rrM1_4LineBC.enabled = true;
                rrM1_4LineStBC.enabled = //kyotuEla.tenmetuOnOff;
                false;

                rrM1_4LineCA.enabled = true;
                rrM1_4LineStCA.enabled = //kyotuEla.tenmetuOnOff;
                false;
                rrM1_4LineStCA2.enabled = //kyotuEla.tenmetuOnOff;
                false;
                //true;


                rrM1_4LineDE.enabled = true;
                rrM1_4LineStDE.enabled = kyotuEla.tenmetuOnOff;
                //false;
                rrM1_4LineStDE2.enabled = //kyotuEla.tenmetuOnOff;
                false;
                //true;


                rrM1_4LineEF.enabled = true;
                rrM1_4LineStEF.enabled = kyotuEla.tenmetuOnOff;
                //false;
                rrM1_4LineFD.enabled = true;
                rrM1_4LineStFD.enabled = kyotuEla.tenmetuOnOff;
                //false;
                rrM1_4LineStFD2.enabled = //kyotuEla.tenmetuOnOff;
                false;
                //true;


                rrM1_4kakuBAC.enabled = //true;
                    false;

                rrM1_4kakuStBAC.enabled =
                //kyotuEla.tenmetuOnOff;
                false;

                rrM1_4kakuABC.enabled = //true;
                    false;
                rrM1_4kakuStABC.enabled =
                //kyotuEla.tenmetuOnOff;
                false;

                rrM1_4kakuACB.enabled = //true;
                    false;

                rrM1_4kakuStACB.enabled =
                //kyotuEla.tenmetuOnOff;
                false;


                rrM1_4kakuEDF.enabled = //true;
                    false;

                rrM1_4kakuStEDF.enabled =
                //kyotuEla.tenmetuOnOff;
                false;

                rrM1_4kakuDEF.enabled = //true;
                    false;

                rrM1_4kakuStDEF.enabled =
                //kyotuEla.tenmetuOnOff;
                false;

                rrM1_4kakuDFE.enabled = //true;
                    false;

                rrM1_4kakuStDFE.enabled =
                //kyotuEla.tenmetuOnOff;
                false;

                rrM1_4TextA.enabled = true;
                rrM1_4TextB.enabled = true;
                rrM1_4TextC.enabled = true;

                rrM1_4TextD.enabled = true;
                rrM1_4TextE.enabled = true;
                rrM1_4TextF.enabled = true;

            } else if (count == 10) {
                reset();
                rrM1_4LineAB.enabled = true;
                rrM1_4LineStAB.enabled = false;
                //kyotuEla.tenmetuOnOff;
                rrM1_4LineStAB2.enabled = kyotuEla.tenmetuOnOff;
                //false;
                //true;

                rrM1_4LineBC.enabled = true;
                rrM1_4LineStBC.enabled = //kyotuEla.tenmetuOnOff;
                false;

                rrM1_4LineCA.enabled = true;
                rrM1_4LineStCA.enabled = //kyotuEla.tenmetuOnOff;
                false;
                rrM1_4LineStCA2.enabled = //kyotuEla.tenmetuOnOff;
                false;
                //true;


                rrM1_4LineDE.enabled = true;
                rrM1_4LineStDE.enabled = //kyotuEla.tenmetuOnOff;
                false;
                rrM1_4LineStDE2.enabled = //kyotuEla.tenmetuOnOff;
                false;
                //true;


                rrM1_4LineEF.enabled = true;
                rrM1_4LineStEF.enabled = //kyotuEla.tenmetuOnOff;
                false;
                rrM1_4LineFD.enabled = true;
                rrM1_4LineStFD.enabled = //kyotuEla.tenmetuOnOff;
                false;
                rrM1_4LineStFD2.enabled = //kyotuEla.tenmetuOnOff;
                false;
                //true;


                rrM1_4kakuBAC.enabled = //true;
                    false;

                rrM1_4kakuStBAC.enabled =
                //kyotuEla.tenmetuOnOff;
                false;

                rrM1_4kakuABC.enabled = //true;
                    false;
                rrM1_4kakuStABC.enabled =
                //kyotuEla.tenmetuOnOff;
                false;

                rrM1_4kakuACB.enabled = //true;
                    false;

                rrM1_4kakuStACB.enabled =
                //kyotuEla.tenmetuOnOff;
                false;


                rrM1_4kakuEDF.enabled = //true;
                    false;

                rrM1_4kakuStEDF.enabled =
                //kyotuEla.tenmetuOnOff;
                false;

                rrM1_4kakuDEF.enabled = //true;
                    false;

                rrM1_4kakuStDEF.enabled =
                //kyotuEla.tenmetuOnOff;
                false;

                rrM1_4kakuDFE.enabled = //true;
                    false;

                rrM1_4kakuStDFE.enabled =
                //kyotuEla.tenmetuOnOff;
                false;

                rrM1_4TextA.enabled = true;
                rrM1_4TextB.enabled = true;
                rrM1_4TextC.enabled = true;

                rrM1_4TextD.enabled = true;
                rrM1_4TextE.enabled = true;
                rrM1_4TextF.enabled = true;

            } else if (count == 11) {
                reset();
                rrM1_4LineAB.enabled = true;
                rrM1_4LineStAB.enabled = false;
                //kyotuEla.tenmetuOnOff;
                rrM1_4LineStAB2.enabled = //kyotuEla.tenmetuOnOff;
                //false;
                true;

                rrM1_4LineBC.enabled = true;
                rrM1_4LineStBC.enabled = //kyotuEla.tenmetuOnOff;
                false;

                rrM1_4LineCA.enabled = true;
                rrM1_4LineStCA.enabled = //kyotuEla.tenmetuOnOff;
                false;
                rrM1_4LineStCA2.enabled = kyotuEla.tenmetuOnOff;
                //false;
                //true;


                rrM1_4LineDE.enabled = true;
                rrM1_4LineStDE.enabled = //kyotuEla.tenmetuOnOff;
                false;
                rrM1_4LineStDE2.enabled = //kyotuEla.tenmetuOnOff;
                false;
                //true;


                rrM1_4LineEF.enabled = true;
                rrM1_4LineStEF.enabled = //kyotuEla.tenmetuOnOff;
                false;
                rrM1_4LineFD.enabled = true;
                rrM1_4LineStFD.enabled = //kyotuEla.tenmetuOnOff;
                false;
                rrM1_4LineStFD2.enabled = //kyotuEla.tenmetuOnOff;
                false;
                //true;


                rrM1_4kakuBAC.enabled = //true;
                    false;

                rrM1_4kakuStBAC.enabled =
                //kyotuEla.tenmetuOnOff;
                false;

                rrM1_4kakuABC.enabled = //true;
                    false;
                rrM1_4kakuStABC.enabled =
                //kyotuEla.tenmetuOnOff;
                false;

                rrM1_4kakuACB.enabled = //true;
                    false;

                rrM1_4kakuStACB.enabled =
                //kyotuEla.tenmetuOnOff;
                false;


                rrM1_4kakuEDF.enabled = //true;
                    false;

                rrM1_4kakuStEDF.enabled =
                //kyotuEla.tenmetuOnOff;
                false;

                rrM1_4kakuDEF.enabled = //true;
                    false;

                rrM1_4kakuStDEF.enabled =
                //kyotuEla.tenmetuOnOff;
                false;

                rrM1_4kakuDFE.enabled = //true;
                    false;

                rrM1_4kakuStDFE.enabled =
                //kyotuEla.tenmetuOnOff;
                false;

                rrM1_4TextA.enabled = true;
                rrM1_4TextB.enabled = true;
                rrM1_4TextC.enabled = true;

                rrM1_4TextD.enabled = true;
                rrM1_4TextE.enabled = true;
                rrM1_4TextF.enabled = true;

            } else if (count == 12) {
                reset();
                rrM1_4LineAB.enabled = true;
                rrM1_4LineStAB.enabled = false;
                //kyotuEla.tenmetuOnOff;
                rrM1_4LineStAB2.enabled = //kyotuEla.tenmetuOnOff;
                //false;
                true;

                rrM1_4LineBC.enabled = true;
                rrM1_4LineStBC.enabled = //kyotuEla.tenmetuOnOff;
                false;

                rrM1_4LineCA.enabled = true;
                rrM1_4LineStCA.enabled = //kyotuEla.tenmetuOnOff;
                false;
                rrM1_4LineStCA2.enabled = //kyotuEla.tenmetuOnOff;
                //false;
                true;


                rrM1_4LineDE.enabled = true;
                rrM1_4LineStDE.enabled = //kyotuEla.tenmetuOnOff;
                false;
                rrM1_4LineStDE2.enabled = kyotuEla.tenmetuOnOff;
                //false;
                //true;


                rrM1_4LineEF.enabled = true;
                rrM1_4LineStEF.enabled = //kyotuEla.tenmetuOnOff;
                false;
                rrM1_4LineFD.enabled = true;
                rrM1_4LineStFD.enabled = //kyotuEla.tenmetuOnOff;
                false;
                rrM1_4LineStFD2.enabled = //kyotuEla.tenmetuOnOff;
                false;
                //true;


                rrM1_4kakuBAC.enabled = //true;
                    false;

                rrM1_4kakuStBAC.enabled =
                //kyotuEla.tenmetuOnOff;
                false;

                rrM1_4kakuABC.enabled = //true;
                    false;
                rrM1_4kakuStABC.enabled =
                //kyotuEla.tenmetuOnOff;
                false;

                rrM1_4kakuACB.enabled = //true;
                    false;

                rrM1_4kakuStACB.enabled =
                //kyotuEla.tenmetuOnOff;
                false;


                rrM1_4kakuEDF.enabled = //true;
                    false;

                rrM1_4kakuStEDF.enabled =
                //kyotuEla.tenmetuOnOff;
                false;

                rrM1_4kakuDEF.enabled = //true;
                    false;

                rrM1_4kakuStDEF.enabled =
                //kyotuEla.tenmetuOnOff;
                false;

                rrM1_4kakuDFE.enabled = //true;
                    false;

                rrM1_4kakuStDFE.enabled =
                //kyotuEla.tenmetuOnOff;
                false;

                rrM1_4TextA.enabled = true;
                rrM1_4TextB.enabled = true;
                rrM1_4TextC.enabled = true;

                rrM1_4TextD.enabled = true;
                rrM1_4TextE.enabled = true;
                rrM1_4TextF.enabled = true;

            } else if (count == 13) {
                reset();
                rrM1_4LineAB.enabled = true;
                rrM1_4LineStAB.enabled = false;
                //kyotuEla.tenmetuOnOff;
                rrM1_4LineStAB2.enabled = //kyotuEla.tenmetuOnOff;
                //false;
                true;

                rrM1_4LineBC.enabled = true;
                rrM1_4LineStBC.enabled = //kyotuEla.tenmetuOnOff;
                false;

                rrM1_4LineCA.enabled = true;
                rrM1_4LineStCA.enabled = //kyotuEla.tenmetuOnOff;
                false;
                rrM1_4LineStCA2.enabled = //kyotuEla.tenmetuOnOff;
                //false;
                true;


                rrM1_4LineDE.enabled = true;
                rrM1_4LineStDE.enabled = //kyotuEla.tenmetuOnOff;
                false;
                rrM1_4LineStDE2.enabled = //kyotuEla.tenmetuOnOff;
                //false;
                true;


                rrM1_4LineEF.enabled = true;
                rrM1_4LineStEF.enabled = //kyotuEla.tenmetuOnOff;
                false;
                rrM1_4LineFD.enabled = true;
                rrM1_4LineStFD.enabled = //kyotuEla.tenmetuOnOff;
                false;
                rrM1_4LineStFD2.enabled = kyotuEla.tenmetuOnOff;
                //false;
                //true;


                rrM1_4kakuBAC.enabled = //true;
                    false;

                rrM1_4kakuStBAC.enabled =
                //kyotuEla.tenmetuOnOff;
                false;

                rrM1_4kakuABC.enabled = //true;
                    false;
                rrM1_4kakuStABC.enabled =
                //kyotuEla.tenmetuOnOff;
                false;

                rrM1_4kakuACB.enabled = //true;
                    false;

                rrM1_4kakuStACB.enabled =
                //kyotuEla.tenmetuOnOff;
                false;


                rrM1_4kakuEDF.enabled = //true;
                    false;

                rrM1_4kakuStEDF.enabled =
                //kyotuEla.tenmetuOnOff;
                false;

                rrM1_4kakuDEF.enabled = //true;
                    false;

                rrM1_4kakuStDEF.enabled =
                //kyotuEla.tenmetuOnOff;
                false;

                rrM1_4kakuDFE.enabled = //true;
                    false;

                rrM1_4kakuStDFE.enabled =
                //kyotuEla.tenmetuOnOff;
                false;

                rrM1_4TextA.enabled = true;
                rrM1_4TextB.enabled = true;
                rrM1_4TextC.enabled = true;

                rrM1_4TextD.enabled = true;
                rrM1_4TextE.enabled = true;
                rrM1_4TextF.enabled = true;

            } else if (count == 14) {
                reset();
                rrM1_4LineAB.enabled = true;
                rrM1_4LineStAB.enabled = false;
                //kyotuEla.tenmetuOnOff;
                rrM1_4LineStAB2.enabled = kyotuEla.tenmetuOnOff;
                //false;
                //true;

                rrM1_4LineBC.enabled = true;
                rrM1_4LineStBC.enabled = //kyotuEla.tenmetuOnOff;
                false;

                rrM1_4LineCA.enabled = true;
                rrM1_4LineStCA.enabled = //kyotuEla.tenmetuOnOff;
                false;
                rrM1_4LineStCA2.enabled = //kyotuEla.tenmetuOnOff;
                //false;
                true;


                rrM1_4LineDE.enabled = true;
                rrM1_4LineStDE.enabled = //kyotuEla.tenmetuOnOff;
                false;
                rrM1_4LineStDE2.enabled = //kyotuEla.tenmetuOnOff;
                //false;
                true;


                rrM1_4LineEF.enabled = true;
                rrM1_4LineStEF.enabled = //kyotuEla.tenmetuOnOff;
                false;
                rrM1_4LineFD.enabled = true;
                rrM1_4LineStFD.enabled = //kyotuEla.tenmetuOnOff;
                false;
                rrM1_4LineStFD2.enabled = //kyotuEla.tenmetuOnOff;
                //false;
                true;


                rrM1_4kakuBAC.enabled = //true;
                    false;

                rrM1_4kakuStBAC.enabled =
                //kyotuEla.tenmetuOnOff;
                false;

                rrM1_4kakuABC.enabled = //true;
                    false;
                rrM1_4kakuStABC.enabled =
                //kyotuEla.tenmetuOnOff;
                false;

                rrM1_4kakuACB.enabled = //true;
                    false;

                rrM1_4kakuStACB.enabled =
                //kyotuEla.tenmetuOnOff;
                false;


                rrM1_4kakuEDF.enabled = //true;
                    false;

                rrM1_4kakuStEDF.enabled =
                //kyotuEla.tenmetuOnOff;
                false;

                rrM1_4kakuDEF.enabled = //true;
                    false;

                rrM1_4kakuStDEF.enabled =
                //kyotuEla.tenmetuOnOff;
                false;

                rrM1_4kakuDFE.enabled = //true;
                    false;

                rrM1_4kakuStDFE.enabled =
                //kyotuEla.tenmetuOnOff;
                false;

                rrM1_4TextA.enabled = true;
                rrM1_4TextB.enabled = true;
                rrM1_4TextC.enabled = true;

                rrM1_4TextD.enabled = true;
                rrM1_4TextE.enabled = true;
                rrM1_4TextF.enabled = true;
            } else if (count == 15) {
                reset();
                rrM1_4LineAB.enabled = true;
                rrM1_4LineStAB.enabled = false;
                //kyotuEla.tenmetuOnOff;
                rrM1_4LineStAB2.enabled = //kyotuEla.tenmetuOnOff;
                //false;
                true;

                rrM1_4LineBC.enabled = true;
                rrM1_4LineStBC.enabled = //kyotuEla.tenmetuOnOff;
                false;

                rrM1_4LineCA.enabled = true;
                rrM1_4LineStCA.enabled = //kyotuEla.tenmetuOnOff;
                false;
                rrM1_4LineStCA2.enabled = //kyotuEla.tenmetuOnOff;
                //false;
                true;


                rrM1_4LineDE.enabled = true;
                rrM1_4LineStDE.enabled = //kyotuEla.tenmetuOnOff;
                false;
                rrM1_4LineStDE2.enabled = kyotuEla.tenmetuOnOff;
                //false;
                //true;


                rrM1_4LineEF.enabled = true;
                rrM1_4LineStEF.enabled = //kyotuEla.tenmetuOnOff;
                false;
                rrM1_4LineFD.enabled = true;
                rrM1_4LineStFD.enabled = //kyotuEla.tenmetuOnOff;
                false;
                rrM1_4LineStFD2.enabled = //kyotuEla.tenmetuOnOff;
                //false;
                true;


                rrM1_4kakuBAC.enabled = //true;
                    false;

                rrM1_4kakuStBAC.enabled =
                //kyotuEla.tenmetuOnOff;
                false;

                rrM1_4kakuABC.enabled = //true;
                    false;
                rrM1_4kakuStABC.enabled =
                //kyotuEla.tenmetuOnOff;
                false;

                rrM1_4kakuACB.enabled = //true;
                    false;

                rrM1_4kakuStACB.enabled =
                //kyotuEla.tenmetuOnOff;
                false;


                rrM1_4kakuEDF.enabled = //true;
                    false;

                rrM1_4kakuStEDF.enabled =
                //kyotuEla.tenmetuOnOff;
                false;

                rrM1_4kakuDEF.enabled = //true;
                    false;

                rrM1_4kakuStDEF.enabled =
                //kyotuEla.tenmetuOnOff;
                false;

                rrM1_4kakuDFE.enabled = //true;
                    false;

                rrM1_4kakuStDFE.enabled =
                //kyotuEla.tenmetuOnOff;
                false;

                rrM1_4TextA.enabled = true;
                rrM1_4TextB.enabled = true;
                rrM1_4TextC.enabled = true;

                rrM1_4TextD.enabled = true;
                rrM1_4TextE.enabled = true;
                rrM1_4TextF.enabled = true;
            } else if (count == 16) {
                reset();
                rrM1_4LineAB.enabled = true;
                rrM1_4LineStAB.enabled = false;
                //kyotuEla.tenmetuOnOff;
                rrM1_4LineStAB2.enabled = //kyotuEla.tenmetuOnOff;
                //false;
                true;

                rrM1_4LineBC.enabled = true;
                rrM1_4LineStBC.enabled = //kyotuEla.tenmetuOnOff;
                false;

                rrM1_4LineCA.enabled = true;
                rrM1_4LineStCA.enabled = //kyotuEla.tenmetuOnOff;
                false;
                rrM1_4LineStCA2.enabled = kyotuEla.tenmetuOnOff;
                //false;
                //true;


                rrM1_4LineDE.enabled = true;
                rrM1_4LineStDE.enabled = //kyotuEla.tenmetuOnOff;
                false;
                rrM1_4LineStDE2.enabled = //kyotuEla.tenmetuOnOff;
                //false;
                true;


                rrM1_4LineEF.enabled = true;
                rrM1_4LineStEF.enabled = //kyotuEla.tenmetuOnOff;
                false;
                rrM1_4LineFD.enabled = true;
                rrM1_4LineStFD.enabled = //kyotuEla.tenmetuOnOff;
                false;
                rrM1_4LineStFD2.enabled = //kyotuEla.tenmetuOnOff;
                //false;
                true;


                rrM1_4kakuBAC.enabled = //true;
                    false;

                rrM1_4kakuStBAC.enabled =
                //kyotuEla.tenmetuOnOff;
                false;

                rrM1_4kakuABC.enabled = //true;
                    false;
                rrM1_4kakuStABC.enabled =
                //kyotuEla.tenmetuOnOff;
                false;

                rrM1_4kakuACB.enabled = //true;
                    false;

                rrM1_4kakuStACB.enabled =
                //kyotuEla.tenmetuOnOff;
                false;


                rrM1_4kakuEDF.enabled = //true;
                    false;

                rrM1_4kakuStEDF.enabled =
                //kyotuEla.tenmetuOnOff;
                false;

                rrM1_4kakuDEF.enabled = //true;
                    false;

                rrM1_4kakuStDEF.enabled =
                //kyotuEla.tenmetuOnOff;
                false;

                rrM1_4kakuDFE.enabled = //true;
                    false;

                rrM1_4kakuStDFE.enabled =
                //kyotuEla.tenmetuOnOff;
                false;

                rrM1_4TextA.enabled = true;
                rrM1_4TextB.enabled = true;
                rrM1_4TextC.enabled = true;

                rrM1_4TextD.enabled = true;
                rrM1_4TextE.enabled = true;
                rrM1_4TextF.enabled = true;
            } else if (count == 17) {
                reset();
                rrM1_4LineAB.enabled = true;
                rrM1_4LineStAB.enabled = false;
                //kyotuEla.tenmetuOnOff;
                rrM1_4LineStAB2.enabled = //kyotuEla.tenmetuOnOff;
                //false;
                true;

                rrM1_4LineBC.enabled = true;
                rrM1_4LineStBC.enabled = //kyotuEla.tenmetuOnOff;
                false;

                rrM1_4LineCA.enabled = true;
                rrM1_4LineStCA.enabled = //kyotuEla.tenmetuOnOff;
                false;
                rrM1_4LineStCA2.enabled = //kyotuEla.tenmetuOnOff;
                //false;
                true;


                rrM1_4LineDE.enabled = true;
                rrM1_4LineStDE.enabled = //kyotuEla.tenmetuOnOff;
                false;
                rrM1_4LineStDE2.enabled = //kyotuEla.tenmetuOnOff;
                //false;
                true;


                rrM1_4LineEF.enabled = true;
                rrM1_4LineStEF.enabled = //kyotuEla.tenmetuOnOff;
                false;
                rrM1_4LineFD.enabled = true;
                rrM1_4LineStFD.enabled = //kyotuEla.tenmetuOnOff;
                false;
                rrM1_4LineStFD2.enabled = kyotuEla.tenmetuOnOff;
                //false;
                //true;


                rrM1_4kakuBAC.enabled = //true;
                    false;

                rrM1_4kakuStBAC.enabled =
                //kyotuEla.tenmetuOnOff;
                false;

                rrM1_4kakuABC.enabled = //true;
                    false;
                rrM1_4kakuStABC.enabled =
                //kyotuEla.tenmetuOnOff;
                false;

                rrM1_4kakuACB.enabled = //true;
                    false;

                rrM1_4kakuStACB.enabled =
                //kyotuEla.tenmetuOnOff;
                false;


                rrM1_4kakuEDF.enabled = //true;
                    false;

                rrM1_4kakuStEDF.enabled =
                //kyotuEla.tenmetuOnOff;
                false;

                rrM1_4kakuDEF.enabled = //true;
                    false;

                rrM1_4kakuStDEF.enabled =
                //kyotuEla.tenmetuOnOff;
                false;

                rrM1_4kakuDFE.enabled = //true;
                    false;

                rrM1_4kakuStDFE.enabled =
                //kyotuEla.tenmetuOnOff;
                false;

                rrM1_4TextA.enabled = true;
                rrM1_4TextB.enabled = true;
                rrM1_4TextC.enabled = true;

                rrM1_4TextD.enabled = true;
                rrM1_4TextE.enabled = true;
                rrM1_4TextF.enabled = true;
            } else if (count == 18) {
                reset();
                rrM1_4LineAB.enabled = true;
                rrM1_4LineStAB.enabled = false;
                //kyotuEla.tenmetuOnOff;
                rrM1_4LineStAB2.enabled = //kyotuEla.tenmetuOnOff;
                //false;
                true;

                rrM1_4LineBC.enabled = true;
                rrM1_4LineStBC.enabled = //kyotuEla.tenmetuOnOff;
                false;

                rrM1_4LineCA.enabled = true;
                rrM1_4LineStCA.enabled = //kyotuEla.tenmetuOnOff;
                false;
                rrM1_4LineStCA2.enabled = //kyotuEla.tenmetuOnOff;
                //false;
                true;


                rrM1_4LineDE.enabled = true;
                rrM1_4LineStDE.enabled = //kyotuEla.tenmetuOnOff;
                false;
                rrM1_4LineStDE2.enabled = //kyotuEla.tenmetuOnOff;
                //false;
                true;


                rrM1_4LineEF.enabled = true;
                rrM1_4LineStEF.enabled = //kyotuEla.tenmetuOnOff;
                false;
                rrM1_4LineFD.enabled = true;
                rrM1_4LineStFD.enabled = //kyotuEla.tenmetuOnOff;
                false;
                rrM1_4LineStFD2.enabled = //kyotuEla.tenmetuOnOff;
                //false;
                true;


                rrM1_4kakuBAC.enabled = true;
                    //false;

                rrM1_4kakuStBAC.enabled =
                kyotuEla.tenmetuOnOff;
                //false;

                rrM1_4kakuABC.enabled = //true;
                    false;
                rrM1_4kakuStABC.enabled =
                //kyotuEla.tenmetuOnOff;
                false;

                rrM1_4kakuACB.enabled = //true;
                    false;

                rrM1_4kakuStACB.enabled =
                //kyotuEla.tenmetuOnOff;
                false;


                rrM1_4kakuEDF.enabled = //true;
                    false;

                rrM1_4kakuStEDF.enabled =
                //kyotuEla.tenmetuOnOff;
                false;

                rrM1_4kakuDEF.enabled = //true;
                    false;

                rrM1_4kakuStDEF.enabled =
                //kyotuEla.tenmetuOnOff;
                false;

                rrM1_4kakuDFE.enabled = //true;
                    false;

                rrM1_4kakuStDFE.enabled =
                //kyotuEla.tenmetuOnOff;
                false;

                rrM1_4TextA.enabled = true;
                rrM1_4TextB.enabled = true;
                rrM1_4TextC.enabled = true;

                rrM1_4TextD.enabled = true;
                rrM1_4TextE.enabled = true;
                rrM1_4TextF.enabled = true;
            } else if (count == 19) {
                reset();
                rrM1_4LineAB.enabled = true;
                rrM1_4LineStAB.enabled = false;
                //kyotuEla.tenmetuOnOff;
                rrM1_4LineStAB2.enabled = //kyotuEla.tenmetuOnOff;
                //false;
                true;

                rrM1_4LineBC.enabled = true;
                rrM1_4LineStBC.enabled = //kyotuEla.tenmetuOnOff;
                false;

                rrM1_4LineCA.enabled = true;
                rrM1_4LineStCA.enabled = //kyotuEla.tenmetuOnOff;
                false;
                rrM1_4LineStCA2.enabled = //kyotuEla.tenmetuOnOff;
                //false;
                true;


                rrM1_4LineDE.enabled = true;
                rrM1_4LineStDE.enabled = //kyotuEla.tenmetuOnOff;
                false;
                rrM1_4LineStDE2.enabled = //kyotuEla.tenmetuOnOff;
                //false;
                true;


                rrM1_4LineEF.enabled = true;
                rrM1_4LineStEF.enabled = //kyotuEla.tenmetuOnOff;
                false;
                rrM1_4LineFD.enabled = true;
                rrM1_4LineStFD.enabled = //kyotuEla.tenmetuOnOff;
                false;
                rrM1_4LineStFD2.enabled = //kyotuEla.tenmetuOnOff;
                //false;
                true;


                rrM1_4kakuBAC.enabled = true;
                //false;

                rrM1_4kakuStBAC.enabled =
                //kyotuEla.tenmetuOnOff;
                false;

                rrM1_4kakuABC.enabled = //true;
                    false;
                rrM1_4kakuStABC.enabled =
                //kyotuEla.tenmetuOnOff;
                false;

                rrM1_4kakuACB.enabled = //true;
                    false;

                rrM1_4kakuStACB.enabled =
                //kyotuEla.tenmetuOnOff;
                false;


                rrM1_4kakuEDF.enabled = true;
                    //false;

                rrM1_4kakuStEDF.enabled =
                kyotuEla.tenmetuOnOff;
                //false;

                rrM1_4kakuDEF.enabled = //true;
                    false;

                rrM1_4kakuStDEF.enabled =
                //kyotuEla.tenmetuOnOff;
                false;

                rrM1_4kakuDFE.enabled = //true;
                    false;

                rrM1_4kakuStDFE.enabled =
                //kyotuEla.tenmetuOnOff;
                false;

                rrM1_4TextA.enabled = true;
                rrM1_4TextB.enabled = true;
                rrM1_4TextC.enabled = true;

                rrM1_4TextD.enabled = true;
                rrM1_4TextE.enabled = true;
                rrM1_4TextF.enabled = true;
            } else if (count == 20) {
                reset();
                rrM1_4LineAB.enabled = true;
                rrM1_4LineStAB.enabled = false;
                //kyotuEla.tenmetuOnOff;
                rrM1_4LineStAB2.enabled = //kyotuEla.tenmetuOnOff;
                //false;
                true;

                rrM1_4LineBC.enabled = true;
                rrM1_4LineStBC.enabled = kyotuEla.tenmetuOnOff;
                //false;

                rrM1_4LineCA.enabled = true;
                rrM1_4LineStCA.enabled = //kyotuEla.tenmetuOnOff;
                false;
                rrM1_4LineStCA2.enabled = //kyotuEla.tenmetuOnOff;
                //false;
                true;


                rrM1_4LineDE.enabled = true;
                rrM1_4LineStDE.enabled = //kyotuEla.tenmetuOnOff;
                false;
                rrM1_4LineStDE2.enabled = //kyotuEla.tenmetuOnOff;
                //false;
                true;


                rrM1_4LineEF.enabled = true;
                rrM1_4LineStEF.enabled = //kyotuEla.tenmetuOnOff;
                false;
                rrM1_4LineFD.enabled = true;
                rrM1_4LineStFD.enabled = //kyotuEla.tenmetuOnOff;
                false;
                rrM1_4LineStFD2.enabled = //kyotuEla.tenmetuOnOff;
                //false;
                true;


                rrM1_4kakuBAC.enabled = true;
                //false;

                rrM1_4kakuStBAC.enabled =
                //kyotuEla.tenmetuOnOff;
                false;

                rrM1_4kakuABC.enabled = //true;
                    false;
                rrM1_4kakuStABC.enabled =
                //kyotuEla.tenmetuOnOff;
                false;

                rrM1_4kakuACB.enabled = //true;
                    false;

                rrM1_4kakuStACB.enabled =
                //kyotuEla.tenmetuOnOff;
                false;


                rrM1_4kakuEDF.enabled = true;
                //false;

                rrM1_4kakuStEDF.enabled =
                //kyotuEla.tenmetuOnOff;
                false;

                rrM1_4kakuDEF.enabled = //true;
                    false;

                rrM1_4kakuStDEF.enabled =
                //kyotuEla.tenmetuOnOff;
                false;

                rrM1_4kakuDFE.enabled = //true;
                    false;

                rrM1_4kakuStDFE.enabled =
                //kyotuEla.tenmetuOnOff;
                false;

                rrM1_4TextA.enabled = true;
                rrM1_4TextB.enabled = true;
                rrM1_4TextC.enabled = true;

                rrM1_4TextD.enabled = true;
                rrM1_4TextE.enabled = true;
                rrM1_4TextF.enabled = true;
            } else if (count == 21) {
                reset();
                rrM1_4LineAB.enabled = true;
                rrM1_4LineStAB.enabled = false;
                //kyotuEla.tenmetuOnOff;
                rrM1_4LineStAB2.enabled = //kyotuEla.tenmetuOnOff;
                //false;
                true;

                rrM1_4LineBC.enabled = true;
                rrM1_4LineStBC.enabled = //kyotuEla.tenmetuOnOff;
                false;

                rrM1_4LineCA.enabled = true;
                rrM1_4LineStCA.enabled = //kyotuEla.tenmetuOnOff;
                false;
                rrM1_4LineStCA2.enabled = //kyotuEla.tenmetuOnOff;
                //false;
                true;


                rrM1_4LineDE.enabled = true;
                rrM1_4LineStDE.enabled = //kyotuEla.tenmetuOnOff;
                false;
                rrM1_4LineStDE2.enabled = //kyotuEla.tenmetuOnOff;
                //false;
                true;


                rrM1_4LineEF.enabled = true;
                rrM1_4LineStEF.enabled = kyotuEla.tenmetuOnOff;
                //false;
                rrM1_4LineFD.enabled = true;
                rrM1_4LineStFD.enabled = //kyotuEla.tenmetuOnOff;
                false;
                rrM1_4LineStFD2.enabled = //kyotuEla.tenmetuOnOff;
                //false;
                true;


                rrM1_4kakuBAC.enabled = true;
                //false;

                rrM1_4kakuStBAC.enabled =
                //kyotuEla.tenmetuOnOff;
                false;

                rrM1_4kakuABC.enabled = //true;
                    false;
                rrM1_4kakuStABC.enabled =
                //kyotuEla.tenmetuOnOff;
                false;

                rrM1_4kakuACB.enabled = //true;
                    false;

                rrM1_4kakuStACB.enabled =
                //kyotuEla.tenmetuOnOff;
                false;


                rrM1_4kakuEDF.enabled = true;
                //false;

                rrM1_4kakuStEDF.enabled =
                //kyotuEla.tenmetuOnOff;
                false;

                rrM1_4kakuDEF.enabled = //true;
                    false;

                rrM1_4kakuStDEF.enabled =
                //kyotuEla.tenmetuOnOff;
                false;

                rrM1_4kakuDFE.enabled = //true;
                    false;

                rrM1_4kakuStDFE.enabled =
                //kyotuEla.tenmetuOnOff;
                false;

                rrM1_4TextA.enabled = true;
                rrM1_4TextB.enabled = true;
                rrM1_4TextC.enabled = true;

                rrM1_4TextD.enabled = true;
                rrM1_4TextE.enabled = true;
                rrM1_4TextF.enabled = true;
            } else if (count == 22) {
                reset();
                rrM1_4LineAB.enabled = true;
                rrM1_4LineStAB.enabled = false;
                //kyotuEla.tenmetuOnOff;
                rrM1_4LineStAB2.enabled = //kyotuEla.tenmetuOnOff;
                //false;
                true;

                rrM1_4LineBC.enabled = true;
                rrM1_4LineStBC.enabled = //kyotuEla.tenmetuOnOff;
                false;

                rrM1_4LineCA.enabled = true;
                rrM1_4LineStCA.enabled = //kyotuEla.tenmetuOnOff;
                false;
                rrM1_4LineStCA2.enabled = //kyotuEla.tenmetuOnOff;
                //false;
                true;


                rrM1_4LineDE.enabled = true;
                rrM1_4LineStDE.enabled = //kyotuEla.tenmetuOnOff;
                false;
                rrM1_4LineStDE2.enabled = //kyotuEla.tenmetuOnOff;
                //false;
                true;


                rrM1_4LineEF.enabled = true;
                rrM1_4LineStEF.enabled = //kyotuEla.tenmetuOnOff;
                false;
                rrM1_4LineFD.enabled = true;
                rrM1_4LineStFD.enabled = //kyotuEla.tenmetuOnOff;
                false;
                rrM1_4LineStFD2.enabled = //kyotuEla.tenmetuOnOff;
                //false;
                true;


                rrM1_4kakuBAC.enabled = true;
                //false;

                rrM1_4kakuStBAC.enabled =
                //kyotuEla.tenmetuOnOff;
                false;

                rrM1_4kakuABC.enabled = true;
                    //false;
                rrM1_4kakuStABC.enabled =
                kyotuEla.tenmetuOnOff;
                //false;

                rrM1_4kakuACB.enabled = //true;
                    false;

                rrM1_4kakuStACB.enabled =
                //kyotuEla.tenmetuOnOff;
                false;


                rrM1_4kakuEDF.enabled = true;
                //false;

                rrM1_4kakuStEDF.enabled =
                //kyotuEla.tenmetuOnOff;
                false;

                rrM1_4kakuDEF.enabled = //true;
                    false;

                rrM1_4kakuStDEF.enabled =
                //kyotuEla.tenmetuOnOff;
                false;

                rrM1_4kakuDFE.enabled = //true;
                    false;

                rrM1_4kakuStDFE.enabled =
                //kyotuEla.tenmetuOnOff;
                false;

                rrM1_4TextA.enabled = true;
                rrM1_4TextB.enabled = true;
                rrM1_4TextC.enabled = true;

                rrM1_4TextD.enabled = true;
                rrM1_4TextE.enabled = true;
                rrM1_4TextF.enabled = true;
            } else if (count == 23) {
                reset();
                rrM1_4LineAB.enabled = true;
                rrM1_4LineStAB.enabled = false;
                //kyotuEla.tenmetuOnOff;
                rrM1_4LineStAB2.enabled = //kyotuEla.tenmetuOnOff;
                //false;
                true;

                rrM1_4LineBC.enabled = true;
                rrM1_4LineStBC.enabled = //kyotuEla.tenmetuOnOff;
                false;

                rrM1_4LineCA.enabled = true;
                rrM1_4LineStCA.enabled = //kyotuEla.tenmetuOnOff;
                false;
                rrM1_4LineStCA2.enabled = //kyotuEla.tenmetuOnOff;
                //false;
                true;


                rrM1_4LineDE.enabled = true;
                rrM1_4LineStDE.enabled = //kyotuEla.tenmetuOnOff;
                false;
                rrM1_4LineStDE2.enabled = //kyotuEla.tenmetuOnOff;
                //false;
                true;


                rrM1_4LineEF.enabled = true;
                rrM1_4LineStEF.enabled = //kyotuEla.tenmetuOnOff;
                false;
                rrM1_4LineFD.enabled = true;
                rrM1_4LineStFD.enabled = //kyotuEla.tenmetuOnOff;
                false;
                rrM1_4LineStFD2.enabled = //kyotuEla.tenmetuOnOff;
                //false;
                true;


                rrM1_4kakuBAC.enabled = true;
                //false;

                rrM1_4kakuStBAC.enabled =
                //kyotuEla.tenmetuOnOff;
                false;

                rrM1_4kakuABC.enabled = true;
                //false;
                rrM1_4kakuStABC.enabled =
                //kyotuEla.tenmetuOnOff;
                false;

                rrM1_4kakuACB.enabled = //true;
                    false;

                rrM1_4kakuStACB.enabled =
                //kyotuEla.tenmetuOnOff;
                false;


                rrM1_4kakuEDF.enabled = true;
                //false;

                rrM1_4kakuStEDF.enabled =
                //kyotuEla.tenmetuOnOff;
                false;

                rrM1_4kakuDEF.enabled = true;
                    //false;

                rrM1_4kakuStDEF.enabled =
                kyotuEla.tenmetuOnOff;
                //false;

                rrM1_4kakuDFE.enabled = //true;
                    false;

                rrM1_4kakuStDFE.enabled =
                //kyotuEla.tenmetuOnOff;
                false;

                rrM1_4TextA.enabled = true;
                rrM1_4TextB.enabled = true;
                rrM1_4TextC.enabled = true;

                rrM1_4TextD.enabled = true;
                rrM1_4TextE.enabled = true;
                rrM1_4TextF.enabled = true;
            } else if (count == 24) {
                reset();
                rrM1_4LineAB.enabled = true;
                rrM1_4LineStAB.enabled = false;
                //kyotuEla.tenmetuOnOff;
                rrM1_4LineStAB2.enabled = //kyotuEla.tenmetuOnOff;
                //false;
                true;

                rrM1_4LineBC.enabled = true;
                rrM1_4LineStBC.enabled = //kyotuEla.tenmetuOnOff;
                false;

                rrM1_4LineCA.enabled = true;
                rrM1_4LineStCA.enabled = //kyotuEla.tenmetuOnOff;
                false;
                rrM1_4LineStCA2.enabled = //kyotuEla.tenmetuOnOff;
                //false;
                true;


                rrM1_4LineDE.enabled = true;
                rrM1_4LineStDE.enabled = //kyotuEla.tenmetuOnOff;
                false;
                rrM1_4LineStDE2.enabled = //kyotuEla.tenmetuOnOff;
                //false;
                true;


                rrM1_4LineEF.enabled = true;
                rrM1_4LineStEF.enabled = //kyotuEla.tenmetuOnOff;
                false;
                rrM1_4LineFD.enabled = true;
                rrM1_4LineStFD.enabled = //kyotuEla.tenmetuOnOff;
                false;
                rrM1_4LineStFD2.enabled = //kyotuEla.tenmetuOnOff;
                //false;
                true;


                rrM1_4kakuBAC.enabled = true;
                //false;

                rrM1_4kakuStBAC.enabled =
                //kyotuEla.tenmetuOnOff;
                false;

                rrM1_4kakuABC.enabled = true;
                //false;
                rrM1_4kakuStABC.enabled =
                //kyotuEla.tenmetuOnOff;
                false;

                rrM1_4kakuACB.enabled = true;
                    //false;

                rrM1_4kakuStACB.enabled =
                kyotuEla.tenmetuOnOff;
                //false;


                rrM1_4kakuEDF.enabled = true;
                //false;

                rrM1_4kakuStEDF.enabled =
                //kyotuEla.tenmetuOnOff;
                false;

                rrM1_4kakuDEF.enabled = true;
                //false;

                rrM1_4kakuStDEF.enabled =
                //kyotuEla.tenmetuOnOff;
                false;

                rrM1_4kakuDFE.enabled = //true;
                    false;

                rrM1_4kakuStDFE.enabled =
                //kyotuEla.tenmetuOnOff;
                false;

                rrM1_4TextA.enabled = true;
                rrM1_4TextB.enabled = true;
                rrM1_4TextC.enabled = true;

                rrM1_4TextD.enabled = true;
                rrM1_4TextE.enabled = true;
                rrM1_4TextF.enabled = true;
            } else if (count == 25) {
                reset();
                rrM1_4LineAB.enabled = true;
                rrM1_4LineStAB.enabled = false;
                //kyotuEla.tenmetuOnOff;
                rrM1_4LineStAB2.enabled = //kyotuEla.tenmetuOnOff;
                //false;
                true;

                rrM1_4LineBC.enabled = true;
                rrM1_4LineStBC.enabled = //kyotuEla.tenmetuOnOff;
                false;

                rrM1_4LineCA.enabled = true;
                rrM1_4LineStCA.enabled = //kyotuEla.tenmetuOnOff;
                false;
                rrM1_4LineStCA2.enabled = //kyotuEla.tenmetuOnOff;
                //false;
                true;


                rrM1_4LineDE.enabled = true;
                rrM1_4LineStDE.enabled = //kyotuEla.tenmetuOnOff;
                false;
                rrM1_4LineStDE2.enabled = //kyotuEla.tenmetuOnOff;
                //false;
                true;


                rrM1_4LineEF.enabled = true;
                rrM1_4LineStEF.enabled = //kyotuEla.tenmetuOnOff;
                false;
                rrM1_4LineFD.enabled = true;
                rrM1_4LineStFD.enabled = //kyotuEla.tenmetuOnOff;
                false;
                rrM1_4LineStFD2.enabled = //kyotuEla.tenmetuOnOff;
                //false;
                true;


                rrM1_4kakuBAC.enabled = true;
                //false;

                rrM1_4kakuStBAC.enabled =
                //kyotuEla.tenmetuOnOff;
                false;

                rrM1_4kakuABC.enabled = true;
                //false;
                rrM1_4kakuStABC.enabled =
                //kyotuEla.tenmetuOnOff;
                false;

                rrM1_4kakuACB.enabled = true;
                //false;

                rrM1_4kakuStACB.enabled =
                //kyotuEla.tenmetuOnOff;
                false;


                rrM1_4kakuEDF.enabled = true;
                //false;

                rrM1_4kakuStEDF.enabled =
                //kyotuEla.tenmetuOnOff;
                false;

                rrM1_4kakuDEF.enabled = true;
                //false;

                rrM1_4kakuStDEF.enabled =
                //kyotuEla.tenmetuOnOff;
                false;

                rrM1_4kakuDFE.enabled = //true;
                    true;

                rrM1_4kakuStDFE.enabled =
                kyotuEla.tenmetuOnOff;
                //false;

                rrM1_4TextA.enabled = true;
                rrM1_4TextB.enabled = true;
                rrM1_4TextC.enabled = true;

                rrM1_4TextD.enabled = true;
                rrM1_4TextE.enabled = true;
                rrM1_4TextF.enabled = true;
            } else if (count == 26) {
                reset();
                rrM1_4LineAB.enabled = true;
                rrM1_4LineStAB.enabled = //false;
                kyotuEla.tenmetuOnOff;
                rrM1_4LineStAB2.enabled = //kyotuEla.tenmetuOnOff;
                //false;
                true;

                rrM1_4LineBC.enabled = true;
                rrM1_4LineStBC.enabled = kyotuEla.tenmetuOnOff;
                //false;

                rrM1_4LineCA.enabled = true;
                rrM1_4LineStCA.enabled = kyotuEla.tenmetuOnOff;
                //false;
                rrM1_4LineStCA2.enabled = //kyotuEla.tenmetuOnOff;
                //false;
                true;


                rrM1_4LineDE.enabled = true;
                rrM1_4LineStDE.enabled = //kyotuEla.tenmetuOnOff;
                false;
                rrM1_4LineStDE2.enabled = //kyotuEla.tenmetuOnOff;
                //false;
                true;


                rrM1_4LineEF.enabled = true;
                rrM1_4LineStEF.enabled = //kyotuEla.tenmetuOnOff;
                false;
                rrM1_4LineFD.enabled = true;
                rrM1_4LineStFD.enabled = //kyotuEla.tenmetuOnOff;
                false;
                rrM1_4LineStFD2.enabled = //kyotuEla.tenmetuOnOff;
                //false;
                true;


                rrM1_4kakuBAC.enabled = true;
                //false;

                rrM1_4kakuStBAC.enabled =
                //kyotuEla.tenmetuOnOff;
                false;

                rrM1_4kakuABC.enabled = //true;
                false;
                rrM1_4kakuStABC.enabled =
                //kyotuEla.tenmetuOnOff;
                false;

                rrM1_4kakuACB.enabled = //true;
                false;

                rrM1_4kakuStACB.enabled =
                //kyotuEla.tenmetuOnOff;
                false;


                rrM1_4kakuEDF.enabled = true;
                //false;

                rrM1_4kakuStEDF.enabled =
                //kyotuEla.tenmetuOnOff;
                false;

                rrM1_4kakuDEF.enabled = //true;
                false;

                rrM1_4kakuStDEF.enabled =
                //kyotuEla.tenmetuOnOff;
                false;

                rrM1_4kakuDFE.enabled = //true;
                    false;

                rrM1_4kakuStDFE.enabled =
                //kyotuEla.tenmetuOnOff;
                false;

                rrM1_4TextA.enabled = true;
                rrM1_4TextB.enabled = true;
                rrM1_4TextC.enabled = true;

                rrM1_4TextD.enabled = true;
                rrM1_4TextE.enabled = true;
                rrM1_4TextF.enabled = true;
            } else if (count == 27) {
                reset();
                rrM1_4LineAB.enabled = true;
                rrM1_4LineStAB.enabled = false;
                //kyotuEla.tenmetuOnOff;
                rrM1_4LineStAB2.enabled = //kyotuEla.tenmetuOnOff;
                //false;
                true;

                rrM1_4LineBC.enabled = true;
                rrM1_4LineStBC.enabled = //kyotuEla.tenmetuOnOff;
                false;

                rrM1_4LineCA.enabled = true;
                rrM1_4LineStCA.enabled = //kyotuEla.tenmetuOnOff;
                false;
                rrM1_4LineStCA2.enabled = //kyotuEla.tenmetuOnOff;
                //false;
                true;


                rrM1_4LineDE.enabled = true;
                rrM1_4LineStDE.enabled = kyotuEla.tenmetuOnOff;
                //false;
                rrM1_4LineStDE2.enabled = //kyotuEla.tenmetuOnOff;
                //false;
                true;


                rrM1_4LineEF.enabled = true;
                rrM1_4LineStEF.enabled = kyotuEla.tenmetuOnOff;
                //false;
                rrM1_4LineFD.enabled = true;
                rrM1_4LineStFD.enabled = kyotuEla.tenmetuOnOff;
                //false;
                rrM1_4LineStFD2.enabled = //kyotuEla.tenmetuOnOff;
                //false;
                true;


                rrM1_4kakuBAC.enabled = true;
                //false;

                rrM1_4kakuStBAC.enabled =
                //kyotuEla.tenmetuOnOff;
                false;

                rrM1_4kakuABC.enabled = //true;
                false;
                rrM1_4kakuStABC.enabled =
                //kyotuEla.tenmetuOnOff;
                false;

                rrM1_4kakuACB.enabled = //true;
                false;

                rrM1_4kakuStACB.enabled =
                //kyotuEla.tenmetuOnOff;
                false;


                rrM1_4kakuEDF.enabled = true;
                //false;

                rrM1_4kakuStEDF.enabled =
                //kyotuEla.tenmetuOnOff;
                false;

                rrM1_4kakuDEF.enabled = //true;
                false;

                rrM1_4kakuStDEF.enabled =
                //kyotuEla.tenmetuOnOff;
                false;

                rrM1_4kakuDFE.enabled = //true;
                    false;

                rrM1_4kakuStDFE.enabled =
                //kyotuEla.tenmetuOnOff;
                false;

                rrM1_4TextA.enabled = true;
                rrM1_4TextB.enabled = true;
                rrM1_4TextC.enabled = true;

                rrM1_4TextD.enabled = true;
                rrM1_4TextE.enabled = true;
                rrM1_4TextF.enabled = true;
            } else if (count == 28) {
                reset();
                rrM1_4LineAB.enabled = true;
                rrM1_4LineStAB.enabled = false;
                //kyotuEla.tenmetuOnOff;
                rrM1_4LineStAB2.enabled = //kyotuEla.tenmetuOnOff;
                //false;
                true;

                rrM1_4LineBC.enabled = true;
                rrM1_4LineStBC.enabled = //kyotuEla.tenmetuOnOff;
                false;

                rrM1_4LineCA.enabled = true;
                rrM1_4LineStCA.enabled = //kyotuEla.tenmetuOnOff;
                false;
                rrM1_4LineStCA2.enabled = //kyotuEla.tenmetuOnOff;
                //false;
                true;


                rrM1_4LineDE.enabled = true;
                rrM1_4LineStDE.enabled = //kyotuEla.tenmetuOnOff;
                false;
                rrM1_4LineStDE2.enabled = //kyotuEla.tenmetuOnOff;
                //false;
                true;


                rrM1_4LineEF.enabled = true;
                rrM1_4LineStEF.enabled = //kyotuEla.tenmetuOnOff;
                false;
                rrM1_4LineFD.enabled = true;
                rrM1_4LineStFD.enabled = //kyotuEla.tenmetuOnOff;
                false;
                rrM1_4LineStFD2.enabled = //kyotuEla.tenmetuOnOff;
                //false;
                true;


                rrM1_4kakuBAC.enabled = true;
                //false;

                rrM1_4kakuStBAC.enabled =
                //kyotuEla.tenmetuOnOff;
                false;

                rrM1_4kakuABC.enabled = //true;
                false;
                rrM1_4kakuStABC.enabled =
                //kyotuEla.tenmetuOnOff;
                false;

                rrM1_4kakuACB.enabled = //true;
                false;

                rrM1_4kakuStACB.enabled =
                //kyotuEla.tenmetuOnOff;
                false;


                rrM1_4kakuEDF.enabled = true;
                //false;

                rrM1_4kakuStEDF.enabled =
                //kyotuEla.tenmetuOnOff;
                false;

                rrM1_4kakuDEF.enabled = //true;
                false;

                rrM1_4kakuStDEF.enabled =
                //kyotuEla.tenmetuOnOff;
                false;

                rrM1_4kakuDFE.enabled = //true;
                    false;

                rrM1_4kakuStDFE.enabled =
                //kyotuEla.tenmetuOnOff;
                false;

                rrM1_4TextA.enabled = true;
                rrM1_4TextB.enabled = true;
                rrM1_4TextC.enabled = true;

                rrM1_4TextD.enabled = true;
                rrM1_4TextE.enabled = true;
                rrM1_4TextF.enabled = true;

                rrM1_4PointA.enabled = true;
                rrM1_4PointStA.enabled = kyotuEla.tenmetuOnOff;
            } else if (count == 29) {
                reset();
                rrM1_4LineAB.enabled = true;
                rrM1_4LineStAB.enabled = false;
                //kyotuEla.tenmetuOnOff;
                rrM1_4LineStAB2.enabled = //kyotuEla.tenmetuOnOff;
                //false;
                true;

                rrM1_4LineBC.enabled = true;
                rrM1_4LineStBC.enabled = //kyotuEla.tenmetuOnOff;
                false;

                rrM1_4LineCA.enabled = true;
                rrM1_4LineStCA.enabled = //kyotuEla.tenmetuOnOff;
                false;
                rrM1_4LineStCA2.enabled = //kyotuEla.tenmetuOnOff;
                //false;
                true;


                rrM1_4LineDE.enabled = true;
                rrM1_4LineStDE.enabled = //kyotuEla.tenmetuOnOff;
                false;
                rrM1_4LineStDE2.enabled = //kyotuEla.tenmetuOnOff;
                //false;
                true;


                rrM1_4LineEF.enabled = true;
                rrM1_4LineStEF.enabled = //kyotuEla.tenmetuOnOff;
                false;
                rrM1_4LineFD.enabled = true;
                rrM1_4LineStFD.enabled = //kyotuEla.tenmetuOnOff;
                false;
                rrM1_4LineStFD2.enabled = //kyotuEla.tenmetuOnOff;
                //false;
                true;


                rrM1_4kakuBAC.enabled = true;
                //false;

                rrM1_4kakuStBAC.enabled =
                //kyotuEla.tenmetuOnOff;
                false;

                rrM1_4kakuABC.enabled = //true;
                false;
                rrM1_4kakuStABC.enabled =
                //kyotuEla.tenmetuOnOff;
                false;

                rrM1_4kakuACB.enabled = //true;
                false;

                rrM1_4kakuStACB.enabled =
                //kyotuEla.tenmetuOnOff;
                false;


                rrM1_4kakuEDF.enabled = true;
                //false;

                rrM1_4kakuStEDF.enabled =
                //kyotuEla.tenmetuOnOff;
                false;

                rrM1_4kakuDEF.enabled = //true;
                false;

                rrM1_4kakuStDEF.enabled =
                //kyotuEla.tenmetuOnOff;
                false;

                rrM1_4kakuDFE.enabled = //true;
                    false;

                rrM1_4kakuStDFE.enabled =
                //kyotuEla.tenmetuOnOff;
                false;

                rrM1_4TextA.enabled = true;
                rrM1_4TextB.enabled = true;
                rrM1_4TextC.enabled = true;

                rrM1_4TextD.enabled = true;
                rrM1_4TextE.enabled = true;
                rrM1_4TextF.enabled = true;

                rrM1_4PointA.enabled = true;
                rrM1_4PointStA.enabled = //kyotuEla.tenmetuOnOff;
                                         //false;
                    true;

                rrM1_4PointD.enabled = true;
                rrM1_4PointStD.enabled = kyotuEla.tenmetuOnOff;
                    //false;
            } else if (count == 30) {
                reset();
                rrM1_4LineAB.enabled = true;
                rrM1_4LineStAB.enabled = //false;
                kyotuEla.tenmetuOnOff;
                rrM1_4LineStAB2.enabled = //kyotuEla.tenmetuOnOff;
                //false;
                true;

                rrM1_4LineBC.enabled = true;
                rrM1_4LineStBC.enabled = //kyotuEla.tenmetuOnOff;
                false;

                rrM1_4LineCA.enabled = true;
                rrM1_4LineStCA.enabled = //kyotuEla.tenmetuOnOff;
                false;
                rrM1_4LineStCA2.enabled = //kyotuEla.tenmetuOnOff;
                //false;
                true;


                rrM1_4LineDE.enabled = true;
                rrM1_4LineStDE.enabled = //kyotuEla.tenmetuOnOff;
                false;
                rrM1_4LineStDE2.enabled = //kyotuEla.tenmetuOnOff;
                //false;
                true;


                rrM1_4LineEF.enabled = true;
                rrM1_4LineStEF.enabled = //kyotuEla.tenmetuOnOff;
                false;
                rrM1_4LineFD.enabled = true;
                rrM1_4LineStFD.enabled = //kyotuEla.tenmetuOnOff;
                false;
                rrM1_4LineStFD2.enabled = //kyotuEla.tenmetuOnOff;
                //false;
                true;


                rrM1_4kakuBAC.enabled = true;
                //false;

                rrM1_4kakuStBAC.enabled =
                //kyotuEla.tenmetuOnOff;
                false;

                rrM1_4kakuABC.enabled = //true;
                false;
                rrM1_4kakuStABC.enabled =
                //kyotuEla.tenmetuOnOff;
                false;

                rrM1_4kakuACB.enabled = //true;
                false;

                rrM1_4kakuStACB.enabled =
                //kyotuEla.tenmetuOnOff;
                false;


                rrM1_4kakuEDF.enabled = true;
                //false;

                rrM1_4kakuStEDF.enabled =
                //kyotuEla.tenmetuOnOff;
                false;

                rrM1_4kakuDEF.enabled = //true;
                false;

                rrM1_4kakuStDEF.enabled =
                //kyotuEla.tenmetuOnOff;
                false;

                rrM1_4kakuDFE.enabled = //true;
                    false;

                rrM1_4kakuStDFE.enabled =
                //kyotuEla.tenmetuOnOff;
                false;

                rrM1_4TextA.enabled = true;
                rrM1_4TextB.enabled = true;
                rrM1_4TextC.enabled = true;

                rrM1_4TextD.enabled = true;
                rrM1_4TextE.enabled = true;
                rrM1_4TextF.enabled = true;

                rrM1_4PointA.enabled = true;
                rrM1_4PointStA.enabled = //kyotuEla.tenmetuOnOff;
                                         false;
                                        //true;

                rrM1_4PointD.enabled = true;
                rrM1_4PointStD.enabled = //kyotuEla.tenmetuOnOff;
                                        false;
            } else if (count == 31) {
                reset();
                rrM1_4LineAB.enabled = true;
                rrM1_4LineStAB.enabled = false;
                //kyotuEla.tenmetuOnOff;
                rrM1_4LineStAB2.enabled = //kyotuEla.tenmetuOnOff;
                //false;
                true;

                rrM1_4LineBC.enabled = true;
                rrM1_4LineStBC.enabled = //kyotuEla.tenmetuOnOff;
                false;

                rrM1_4LineCA.enabled = true;
                rrM1_4LineStCA.enabled = //kyotuEla.tenmetuOnOff;
                false;
                rrM1_4LineStCA2.enabled = //kyotuEla.tenmetuOnOff;
                //false;
                true;


                rrM1_4LineDE.enabled = true;
                rrM1_4LineStDE.enabled = kyotuEla.tenmetuOnOff;
                //false;
                rrM1_4LineStDE2.enabled = //kyotuEla.tenmetuOnOff;
                //false;
                true;


                rrM1_4LineEF.enabled = true;
                rrM1_4LineStEF.enabled = //kyotuEla.tenmetuOnOff;
                false;
                rrM1_4LineFD.enabled = true;
                rrM1_4LineStFD.enabled = //kyotuEla.tenmetuOnOff;
                false;
                rrM1_4LineStFD2.enabled = //kyotuEla.tenmetuOnOff;
                //false;
                true;


                rrM1_4kakuBAC.enabled = true;
                //false;

                rrM1_4kakuStBAC.enabled =
                //kyotuEla.tenmetuOnOff;
                false;

                rrM1_4kakuABC.enabled = //true;
                false;
                rrM1_4kakuStABC.enabled =
                //kyotuEla.tenmetuOnOff;
                false;

                rrM1_4kakuACB.enabled = //true;
                false;

                rrM1_4kakuStACB.enabled =
                //kyotuEla.tenmetuOnOff;
                false;


                rrM1_4kakuEDF.enabled = true;
                //false;

                rrM1_4kakuStEDF.enabled =
                //kyotuEla.tenmetuOnOff;
                false;

                rrM1_4kakuDEF.enabled = //true;
                false;

                rrM1_4kakuStDEF.enabled =
                //kyotuEla.tenmetuOnOff;
                false;

                rrM1_4kakuDFE.enabled = //true;
                    false;

                rrM1_4kakuStDFE.enabled =
                //kyotuEla.tenmetuOnOff;
                false;

                rrM1_4TextA.enabled = true;
                rrM1_4TextB.enabled = true;
                rrM1_4TextC.enabled = true;

                rrM1_4TextD.enabled = true;
                rrM1_4TextE.enabled = true;
                rrM1_4TextF.enabled = true;

                rrM1_4PointA.enabled = true;
                rrM1_4PointStA.enabled = //kyotuEla.tenmetuOnOff;
                                         false;
                //true;

                rrM1_4PointD.enabled = true;
                rrM1_4PointStD.enabled = //kyotuEla.tenmetuOnOff;
                                        false;
            } else if (count == 32) {
                reset();
                rrM1_4LineAB.enabled = true;
                rrM1_4LineStAB.enabled = //false;
                kyotuEla.tenmetuOnOff;
                rrM1_4LineStAB2.enabled = //kyotuEla.tenmetuOnOff;
                //false;
                true;

                rrM1_4LineBC.enabled = true;
                rrM1_4LineStBC.enabled = //kyotuEla.tenmetuOnOff;
                false;

                rrM1_4LineCA.enabled = true;
                rrM1_4LineStCA.enabled = //kyotuEla.tenmetuOnOff;
                false;
                rrM1_4LineStCA2.enabled = //kyotuEla.tenmetuOnOff;
                //false;
                true;


                rrM1_4LineDE.enabled = true;
                rrM1_4LineStDE.enabled = //kyotuEla.tenmetuOnOff;
                false;
                rrM1_4LineStDE2.enabled = //kyotuEla.tenmetuOnOff;
                //false;
                true;


                rrM1_4LineEF.enabled = true;
                rrM1_4LineStEF.enabled = //kyotuEla.tenmetuOnOff;
                false;
                rrM1_4LineFD.enabled = true;
                rrM1_4LineStFD.enabled = //kyotuEla.tenmetuOnOff;
                false;
                rrM1_4LineStFD2.enabled = //kyotuEla.tenmetuOnOff;
                //false;
                true;


                rrM1_4kakuBAC.enabled = true;
                //false;

                rrM1_4kakuStBAC.enabled =
                //kyotuEla.tenmetuOnOff;
                false;

                rrM1_4kakuABC.enabled = //true;
                false;
                rrM1_4kakuStABC.enabled =
                //kyotuEla.tenmetuOnOff;
                false;

                rrM1_4kakuACB.enabled = //true;
                false;

                rrM1_4kakuStACB.enabled =
                //kyotuEla.tenmetuOnOff;
                false;


                rrM1_4kakuEDF.enabled = true;
                //false;

                rrM1_4kakuStEDF.enabled =
                //kyotuEla.tenmetuOnOff;
                false;

                rrM1_4kakuDEF.enabled = //true;
                false;

                rrM1_4kakuStDEF.enabled =
                //kyotuEla.tenmetuOnOff;
                false;

                rrM1_4kakuDFE.enabled = //true;
                    false;

                rrM1_4kakuStDFE.enabled =
                //kyotuEla.tenmetuOnOff;
                false;

                rrM1_4TextA.enabled = true;
                rrM1_4TextB.enabled = true;
                rrM1_4TextC.enabled = true;

                rrM1_4TextD.enabled = true;
                rrM1_4TextE.enabled = true;
                rrM1_4TextF.enabled = true;

                rrM1_4PointA.enabled = true;
                rrM1_4PointStA.enabled = //kyotuEla.tenmetuOnOff;
                                         false;
                //true;

                rrM1_4PointD.enabled = true;
                rrM1_4PointStD.enabled = //kyotuEla.tenmetuOnOff;
                                        false;
            } else if (count == 33) {
                reset();
                rrM1_4LineAB.enabled = true;
                rrM1_4LineStAB.enabled = false;
                //kyotuEla.tenmetuOnOff;
                rrM1_4LineStAB2.enabled = //kyotuEla.tenmetuOnOff;
                //false;
                true;

                rrM1_4LineBC.enabled = true;
                rrM1_4LineStBC.enabled = //kyotuEla.tenmetuOnOff;
                false;

                rrM1_4LineCA.enabled = true;
                rrM1_4LineStCA.enabled = //kyotuEla.tenmetuOnOff;
                false;
                rrM1_4LineStCA2.enabled = //kyotuEla.tenmetuOnOff;
                //false;
                true;


                rrM1_4LineDE.enabled = true;
                rrM1_4LineStDE.enabled = kyotuEla.tenmetuOnOff;
                //false;
                rrM1_4LineStDE2.enabled = //kyotuEla.tenmetuOnOff;
                //false;
                true;


                rrM1_4LineEF.enabled = true;
                rrM1_4LineStEF.enabled = //kyotuEla.tenmetuOnOff;
                false;
                rrM1_4LineFD.enabled = true;
                rrM1_4LineStFD.enabled = //kyotuEla.tenmetuOnOff;
                false;
                rrM1_4LineStFD2.enabled = //kyotuEla.tenmetuOnOff;
                //false;
                true;


                rrM1_4kakuBAC.enabled = true;
                //false;

                rrM1_4kakuStBAC.enabled =
                //kyotuEla.tenmetuOnOff;
                false;

                rrM1_4kakuABC.enabled = //true;
                false;
                rrM1_4kakuStABC.enabled =
                //kyotuEla.tenmetuOnOff;
                false;

                rrM1_4kakuACB.enabled = //true;
                false;

                rrM1_4kakuStACB.enabled =
                //kyotuEla.tenmetuOnOff;
                false;


                rrM1_4kakuEDF.enabled = true;
                //false;

                rrM1_4kakuStEDF.enabled =
                //kyotuEla.tenmetuOnOff;
                false;

                rrM1_4kakuDEF.enabled = //true;
                false;

                rrM1_4kakuStDEF.enabled =
                //kyotuEla.tenmetuOnOff;
                false;

                rrM1_4kakuDFE.enabled = //true;
                    false;

                rrM1_4kakuStDFE.enabled =
                //kyotuEla.tenmetuOnOff;
                false;

                rrM1_4TextA.enabled = true;
                rrM1_4TextB.enabled = true;
                rrM1_4TextC.enabled = true;

                rrM1_4TextD.enabled = true;
                rrM1_4TextE.enabled = true;
                rrM1_4TextF.enabled = true;

                rrM1_4PointA.enabled = true;
                rrM1_4PointStA.enabled = //kyotuEla.tenmetuOnOff;
                                         false;
                //true;

                rrM1_4PointD.enabled = true;
                rrM1_4PointStD.enabled = //kyotuEla.tenmetuOnOff;
                                        false;
            } else if (count == 34) {
                reset();
                rrM1_4LineAB.enabled = true;
                rrM1_4LineStAB.enabled = false;
                //kyotuEla.tenmetuOnOff;
                rrM1_4LineStAB2.enabled = //kyotuEla.tenmetuOnOff;
                //false;
                true;

                rrM1_4LineBC.enabled = true;
                rrM1_4LineStBC.enabled = //kyotuEla.tenmetuOnOff;
                false;

                rrM1_4LineCA.enabled = true;
                rrM1_4LineStCA.enabled = //kyotuEla.tenmetuOnOff;
                false;
                rrM1_4LineStCA2.enabled = //kyotuEla.tenmetuOnOff;
                //false;
                true;


                rrM1_4LineDE.enabled = true;
                rrM1_4LineStDE.enabled = //kyotuEla.tenmetuOnOff;
                false;
                rrM1_4LineStDE2.enabled = //kyotuEla.tenmetuOnOff;
                //false;
                true;


                rrM1_4LineEF.enabled = true;
                rrM1_4LineStEF.enabled = //kyotuEla.tenmetuOnOff;
                false;
                rrM1_4LineFD.enabled = true;
                rrM1_4LineStFD.enabled = //kyotuEla.tenmetuOnOff;
                false;
                rrM1_4LineStFD2.enabled = //kyotuEla.tenmetuOnOff;
                //false;
                true;


                rrM1_4kakuBAC.enabled = true;
                //false;

                rrM1_4kakuStBAC.enabled =
                //kyotuEla.tenmetuOnOff;
                false;

                rrM1_4kakuABC.enabled = //true;
                false;
                rrM1_4kakuStABC.enabled =
                //kyotuEla.tenmetuOnOff;
                false;

                rrM1_4kakuACB.enabled = //true;
                false;

                rrM1_4kakuStACB.enabled =
                //kyotuEla.tenmetuOnOff;
                false;


                rrM1_4kakuEDF.enabled = true;
                //false;

                rrM1_4kakuStEDF.enabled =
                //kyotuEla.tenmetuOnOff;
                false;

                rrM1_4kakuDEF.enabled = //true;
                false;

                rrM1_4kakuStDEF.enabled =
                //kyotuEla.tenmetuOnOff;
                false;

                rrM1_4kakuDFE.enabled = //true;
                    false;

                rrM1_4kakuStDFE.enabled =
                //kyotuEla.tenmetuOnOff;
                false;

                rrM1_4TextA.enabled = true;
                rrM1_4TextB.enabled = true;
                rrM1_4TextC.enabled = true;

                rrM1_4TextD.enabled = true;
                rrM1_4TextE.enabled = true;
                rrM1_4TextF.enabled = true;

                rrM1_4PointA.enabled = true;
                rrM1_4PointStA.enabled = //kyotuEla.tenmetuOnOff;
                                         false;
                //true;

                rrM1_4PointB.enabled = true;
                rrM1_4PointStB.enabled = kyotuEla.tenmetuOnOff;
                                         //false;
                //true;

                rrM1_4PointD.enabled = true;
                rrM1_4PointStD.enabled = //kyotuEla.tenmetuOnOff;
                                        false;
            } else if (count == 35) {
                reset();
                rrM1_4LineAB.enabled = true;
                rrM1_4LineStAB.enabled = false;
                //kyotuEla.tenmetuOnOff;
                rrM1_4LineStAB2.enabled = //kyotuEla.tenmetuOnOff;
                //false;
                true;

                rrM1_4LineBC.enabled = true;
                rrM1_4LineStBC.enabled = //kyotuEla.tenmetuOnOff;
                false;

                rrM1_4LineCA.enabled = true;
                rrM1_4LineStCA.enabled = //kyotuEla.tenmetuOnOff;
                false;
                rrM1_4LineStCA2.enabled = //kyotuEla.tenmetuOnOff;
                //false;
                true;


                rrM1_4LineDE.enabled = true;
                rrM1_4LineStDE.enabled = //kyotuEla.tenmetuOnOff;
                false;
                rrM1_4LineStDE2.enabled = //kyotuEla.tenmetuOnOff;
                //false;
                true;


                rrM1_4LineEF.enabled = true;
                rrM1_4LineStEF.enabled = //kyotuEla.tenmetuOnOff;
                false;
                rrM1_4LineFD.enabled = true;
                rrM1_4LineStFD.enabled = //kyotuEla.tenmetuOnOff;
                false;
                rrM1_4LineStFD2.enabled = //kyotuEla.tenmetuOnOff;
                //false;
                true;


                rrM1_4kakuBAC.enabled = true;
                //false;

                rrM1_4kakuStBAC.enabled =
                //kyotuEla.tenmetuOnOff;
                false;

                rrM1_4kakuABC.enabled = //true;
                false;
                rrM1_4kakuStABC.enabled =
                //kyotuEla.tenmetuOnOff;
                false;

                rrM1_4kakuACB.enabled = //true;
                false;

                rrM1_4kakuStACB.enabled =
                //kyotuEla.tenmetuOnOff;
                false;


                rrM1_4kakuEDF.enabled = true;
                //false;

                rrM1_4kakuStEDF.enabled =
                //kyotuEla.tenmetuOnOff;
                false;

                rrM1_4kakuDEF.enabled = //true;
                false;

                rrM1_4kakuStDEF.enabled =
                //kyotuEla.tenmetuOnOff;
                false;

                rrM1_4kakuDFE.enabled = //true;
                    false;

                rrM1_4kakuStDFE.enabled =
                //kyotuEla.tenmetuOnOff;
                false;

                rrM1_4TextA.enabled = true;
                rrM1_4TextB.enabled = true;
                rrM1_4TextC.enabled = true;

                rrM1_4TextD.enabled = true;
                rrM1_4TextE.enabled = true;
                rrM1_4TextF.enabled = true;

                rrM1_4PointA.enabled = true;
                rrM1_4PointStA.enabled = //kyotuEla.tenmetuOnOff;
                                         false;
                //true;

                rrM1_4PointB.enabled = true;
                rrM1_4PointStB.enabled = //kyotuEla.tenmetuOnOff;
                //false;
                true;

                rrM1_4PointD.enabled = true;
                rrM1_4PointStD.enabled = //kyotuEla.tenmetuOnOff;
                                        false;
                rrM1_4PointE.enabled = true;
                rrM1_4PointStE.enabled = kyotuEla.tenmetuOnOff;
                                        //false;
            } else if (count == 36) {
                reset();
                rrM1_4LineAB.enabled = true;
                rrM1_4LineStAB.enabled = //false;
                kyotuEla.tenmetuOnOff;
                rrM1_4LineStAB2.enabled = //kyotuEla.tenmetuOnOff;
                //false;
                true;

                rrM1_4LineBC.enabled = true;
                rrM1_4LineStBC.enabled = //kyotuEla.tenmetuOnOff;
                false;

                rrM1_4LineCA.enabled = true;
                rrM1_4LineStCA.enabled = //kyotuEla.tenmetuOnOff;
                false;
                rrM1_4LineStCA2.enabled = //kyotuEla.tenmetuOnOff;
                //false;
                true;


                rrM1_4LineDE.enabled = true;
                rrM1_4LineStDE.enabled = //kyotuEla.tenmetuOnOff;
                false;
                rrM1_4LineStDE2.enabled = //kyotuEla.tenmetuOnOff;
                //false;
                true;


                rrM1_4LineEF.enabled = true;
                rrM1_4LineStEF.enabled = //kyotuEla.tenmetuOnOff;
                false;
                rrM1_4LineFD.enabled = true;
                rrM1_4LineStFD.enabled = //kyotuEla.tenmetuOnOff;
                false;
                rrM1_4LineStFD2.enabled = //kyotuEla.tenmetuOnOff;
                //false;
                true;


                rrM1_4kakuBAC.enabled = true;
                //false;

                rrM1_4kakuStBAC.enabled =
                //kyotuEla.tenmetuOnOff;
                false;

                rrM1_4kakuABC.enabled = //true;
                false;
                rrM1_4kakuStABC.enabled =
                //kyotuEla.tenmetuOnOff;
                false;

                rrM1_4kakuACB.enabled = //true;
                false;

                rrM1_4kakuStACB.enabled =
                //kyotuEla.tenmetuOnOff;
                false;


                rrM1_4kakuEDF.enabled = true;
                //false;

                rrM1_4kakuStEDF.enabled =
                //kyotuEla.tenmetuOnOff;
                false;

                rrM1_4kakuDEF.enabled = //true;
                false;

                rrM1_4kakuStDEF.enabled =
                //kyotuEla.tenmetuOnOff;
                false;

                rrM1_4kakuDFE.enabled = //true;
                    false;

                rrM1_4kakuStDFE.enabled =
                //kyotuEla.tenmetuOnOff;
                false;

                rrM1_4TextA.enabled = true;
                rrM1_4TextB.enabled = true;
                rrM1_4TextC.enabled = true;

                rrM1_4TextD.enabled = true;
                rrM1_4TextE.enabled = true;
                rrM1_4TextF.enabled = true;

                rrM1_4PointA.enabled = true;
                rrM1_4PointStA.enabled = //kyotuEla.tenmetuOnOff;
                                         false;
                //true;

                rrM1_4PointB.enabled = true;
                rrM1_4PointStB.enabled = //kyotuEla.tenmetuOnOff;
                false;
                //true;

                rrM1_4PointD.enabled = true;
                rrM1_4PointStD.enabled = //kyotuEla.tenmetuOnOff;
                                        false;
                rrM1_4PointE.enabled = true;
                rrM1_4PointStE.enabled = //kyotuEla.tenmetuOnOff;
                false;
            } else if (count == 37) {
                reset();
                rrM1_4LineAB.enabled = true;
                rrM1_4LineStAB.enabled = false;
                //kyotuEla.tenmetuOnOff;
                rrM1_4LineStAB2.enabled = //kyotuEla.tenmetuOnOff;
                //false;
                true;

                rrM1_4LineBC.enabled = true;
                rrM1_4LineStBC.enabled = //kyotuEla.tenmetuOnOff;
                false;

                rrM1_4LineCA.enabled = true;
                rrM1_4LineStCA.enabled = //kyotuEla.tenmetuOnOff;
                false;
                rrM1_4LineStCA2.enabled = //kyotuEla.tenmetuOnOff;
                //false;
                true;


                rrM1_4LineDE.enabled = true;
                rrM1_4LineStDE.enabled = kyotuEla.tenmetuOnOff;
                //false;
                rrM1_4LineStDE2.enabled = //kyotuEla.tenmetuOnOff;
                //false;
                true;


                rrM1_4LineEF.enabled = true;
                rrM1_4LineStEF.enabled = //kyotuEla.tenmetuOnOff;
                false;
                rrM1_4LineFD.enabled = true;
                rrM1_4LineStFD.enabled = //kyotuEla.tenmetuOnOff;
                false;
                rrM1_4LineStFD2.enabled = //kyotuEla.tenmetuOnOff;
                //false;
                true;


                rrM1_4kakuBAC.enabled = true;
                //false;

                rrM1_4kakuStBAC.enabled =
                //kyotuEla.tenmetuOnOff;
                false;

                rrM1_4kakuABC.enabled = //true;
                false;
                rrM1_4kakuStABC.enabled =
                //kyotuEla.tenmetuOnOff;
                false;

                rrM1_4kakuACB.enabled = //true;
                false;

                rrM1_4kakuStACB.enabled =
                //kyotuEla.tenmetuOnOff;
                false;


                rrM1_4kakuEDF.enabled = true;
                //false;

                rrM1_4kakuStEDF.enabled =
                //kyotuEla.tenmetuOnOff;
                false;

                rrM1_4kakuDEF.enabled = //true;
                false;

                rrM1_4kakuStDEF.enabled =
                //kyotuEla.tenmetuOnOff;
                false;

                rrM1_4kakuDFE.enabled = //true;
                    false;

                rrM1_4kakuStDFE.enabled =
                //kyotuEla.tenmetuOnOff;
                false;

                rrM1_4TextA.enabled = true;
                rrM1_4TextB.enabled = true;
                rrM1_4TextC.enabled = true;

                rrM1_4TextD.enabled = true;
                rrM1_4TextE.enabled = true;
                rrM1_4TextF.enabled = true;

                rrM1_4PointA.enabled = true;
                rrM1_4PointStA.enabled = //kyotuEla.tenmetuOnOff;
                                         false;
                //true;

                rrM1_4PointB.enabled = true;
                rrM1_4PointStB.enabled = //kyotuEla.tenmetuOnOff;
                false;
                //true;

                rrM1_4PointD.enabled = true;
                rrM1_4PointStD.enabled = //kyotuEla.tenmetuOnOff;
                                        false;
                rrM1_4PointE.enabled = true;
                rrM1_4PointStE.enabled = //kyotuEla.tenmetuOnOff;
                false;
            } else if (count == 38) {
                reset();
                rrM1_4LineAB.enabled = true;
                rrM1_4LineStAB.enabled = false;
                //kyotuEla.tenmetuOnOff;
                rrM1_4LineStAB2.enabled = //kyotuEla.tenmetuOnOff;
                //false;
                true;

                rrM1_4LineBC.enabled = true;
                rrM1_4LineStBC.enabled = //kyotuEla.tenmetuOnOff;
                false;

                rrM1_4LineCA.enabled = true;
                rrM1_4LineStCA.enabled = //kyotuEla.tenmetuOnOff;
                false;
                rrM1_4LineStCA2.enabled = //kyotuEla.tenmetuOnOff;
                //false;
                true;


                rrM1_4LineDE.enabled = true;
                rrM1_4LineStDE.enabled = //kyotuEla.tenmetuOnOff;
                false;
                rrM1_4LineStDE2.enabled = //kyotuEla.tenmetuOnOff;
                //false;
                true;


                rrM1_4LineEF.enabled = true;
                rrM1_4LineStEF.enabled = //kyotuEla.tenmetuOnOff;
                false;
                rrM1_4LineFD.enabled = true;
                rrM1_4LineStFD.enabled = //kyotuEla.tenmetuOnOff;
                false;
                rrM1_4LineStFD2.enabled = //kyotuEla.tenmetuOnOff;
                //false;
                true;


                rrM1_4kakuBAC.enabled = true;
                //false;

                rrM1_4kakuStBAC.enabled =
                kyotuEla.tenmetuOnOff;
                //false;

                rrM1_4kakuABC.enabled = //true;
                false;
                rrM1_4kakuStABC.enabled =
                //kyotuEla.tenmetuOnOff;
                false;

                rrM1_4kakuACB.enabled = //true;
                false;

                rrM1_4kakuStACB.enabled =
                //kyotuEla.tenmetuOnOff;
                false;


                rrM1_4kakuEDF.enabled = true;
                //false;

                rrM1_4kakuStEDF.enabled =
                //kyotuEla.tenmetuOnOff;
                false;

                rrM1_4kakuDEF.enabled = //true;
                false;

                rrM1_4kakuStDEF.enabled =
                //kyotuEla.tenmetuOnOff;
                false;

                rrM1_4kakuDFE.enabled = //true;
                    false;

                rrM1_4kakuStDFE.enabled =
                //kyotuEla.tenmetuOnOff;
                false;

                rrM1_4TextA.enabled = true;
                rrM1_4TextB.enabled = true;
                rrM1_4TextC.enabled = true;

                rrM1_4TextD.enabled = true;
                rrM1_4TextE.enabled = true;
                rrM1_4TextF.enabled = true;

                rrM1_4PointA.enabled = true;
                rrM1_4PointStA.enabled = //kyotuEla.tenmetuOnOff;
                                         false;
                //true;

                rrM1_4PointB.enabled = true;
                rrM1_4PointStB.enabled = //kyotuEla.tenmetuOnOff;
                false;
                //true;

                rrM1_4PointD.enabled = true;
                rrM1_4PointStD.enabled = //kyotuEla.tenmetuOnOff;
                                        false;
                rrM1_4PointE.enabled = true;
                rrM1_4PointStE.enabled = //kyotuEla.tenmetuOnOff;
                false;
            } else if (count == 39) {
                reset();
                rrM1_4LineAB.enabled = true;
                rrM1_4LineStAB.enabled = false;
                //kyotuEla.tenmetuOnOff;
                rrM1_4LineStAB2.enabled = //kyotuEla.tenmetuOnOff;
                //false;
                true;

                rrM1_4LineBC.enabled = true;
                rrM1_4LineStBC.enabled = //kyotuEla.tenmetuOnOff;
                false;

                rrM1_4LineCA.enabled = true;
                rrM1_4LineStCA.enabled = //kyotuEla.tenmetuOnOff;
                false;
                rrM1_4LineStCA2.enabled = //kyotuEla.tenmetuOnOff;
                //false;
                true;


                rrM1_4LineDE.enabled = true;
                rrM1_4LineStDE.enabled = //kyotuEla.tenmetuOnOff;
                false;
                rrM1_4LineStDE2.enabled = //kyotuEla.tenmetuOnOff;
                //false;
                true;


                rrM1_4LineEF.enabled = true;
                rrM1_4LineStEF.enabled = //kyotuEla.tenmetuOnOff;
                false;
                rrM1_4LineFD.enabled = true;
                rrM1_4LineStFD.enabled = //kyotuEla.tenmetuOnOff;
                false;
                rrM1_4LineStFD2.enabled = //kyotuEla.tenmetuOnOff;
                //false;
                true;


                rrM1_4kakuBAC.enabled = true;
                //false;

                rrM1_4kakuStBAC.enabled =
                //kyotuEla.tenmetuOnOff;
                false;

                rrM1_4kakuABC.enabled = //true;
                false;
                rrM1_4kakuStABC.enabled =
                //kyotuEla.tenmetuOnOff;
                false;

                rrM1_4kakuACB.enabled = //true;
                false;

                rrM1_4kakuStACB.enabled =
                //kyotuEla.tenmetuOnOff;
                false;


                rrM1_4kakuEDF.enabled = true;
                //false;

                rrM1_4kakuStEDF.enabled =
                kyotuEla.tenmetuOnOff;
                //false;

                rrM1_4kakuDEF.enabled = //true;
                false;

                rrM1_4kakuStDEF.enabled =
                //kyotuEla.tenmetuOnOff;
                false;

                rrM1_4kakuDFE.enabled = //true;
                    false;

                rrM1_4kakuStDFE.enabled =
                //kyotuEla.tenmetuOnOff;
                false;

                rrM1_4TextA.enabled = true;
                rrM1_4TextB.enabled = true;
                rrM1_4TextC.enabled = true;

                rrM1_4TextD.enabled = true;
                rrM1_4TextE.enabled = true;
                rrM1_4TextF.enabled = true;

                rrM1_4PointA.enabled = true;
                rrM1_4PointStA.enabled = //kyotuEla.tenmetuOnOff;
                                         false;
                //true;

                rrM1_4PointB.enabled = true;
                rrM1_4PointStB.enabled = //kyotuEla.tenmetuOnOff;
                false;
                //true;

                rrM1_4PointD.enabled = true;
                rrM1_4PointStD.enabled = //kyotuEla.tenmetuOnOff;
                                        false;
                rrM1_4PointE.enabled = true;
                rrM1_4PointStE.enabled = //kyotuEla.tenmetuOnOff;
                false;
            } else if (count == 40) {
                reset();
                rrM1_4LineAB.enabled = true;
                rrM1_4LineStAB.enabled = false;
                //kyotuEla.tenmetuOnOff;
                rrM1_4LineStAB2.enabled = //kyotuEla.tenmetuOnOff;
                //false;
                true;

                rrM1_4LineBC.enabled = true;
                rrM1_4LineStBC.enabled = //kyotuEla.tenmetuOnOff;
                false;

                rrM1_4LineCA.enabled = true;
                rrM1_4LineStCA.enabled = kyotuEla.tenmetuOnOff;
                //false;
                rrM1_4LineStCA2.enabled = //kyotuEla.tenmetuOnOff;
                //false;
                true;


                rrM1_4LineDE.enabled = true;
                rrM1_4LineStDE.enabled = //kyotuEla.tenmetuOnOff;
                false;
                rrM1_4LineStDE2.enabled = //kyotuEla.tenmetuOnOff;
                //false;
                true;


                rrM1_4LineEF.enabled = true;
                rrM1_4LineStEF.enabled = //kyotuEla.tenmetuOnOff;
                false;
                rrM1_4LineFD.enabled = true;
                rrM1_4LineStFD.enabled = //kyotuEla.tenmetuOnOff;
                false;
                rrM1_4LineStFD2.enabled = //kyotuEla.tenmetuOnOff;
                //false;
                true;


                rrM1_4kakuBAC.enabled = true;
                //false;

                rrM1_4kakuStBAC.enabled =
                //kyotuEla.tenmetuOnOff;
                false;

                rrM1_4kakuABC.enabled = //true;
                false;
                rrM1_4kakuStABC.enabled =
                //kyotuEla.tenmetuOnOff;
                false;

                rrM1_4kakuACB.enabled = //true;
                false;

                rrM1_4kakuStACB.enabled =
                //kyotuEla.tenmetuOnOff;
                false;


                rrM1_4kakuEDF.enabled = true;
                //false;

                rrM1_4kakuStEDF.enabled =
                //kyotuEla.tenmetuOnOff;
                false;

                rrM1_4kakuDEF.enabled = //true;
                false;

                rrM1_4kakuStDEF.enabled =
                //kyotuEla.tenmetuOnOff;
                false;

                rrM1_4kakuDFE.enabled = //true;
                    false;

                rrM1_4kakuStDFE.enabled =
                //kyotuEla.tenmetuOnOff;
                false;

                rrM1_4TextA.enabled = true;
                rrM1_4TextB.enabled = true;
                rrM1_4TextC.enabled = true;

                rrM1_4TextD.enabled = true;
                rrM1_4TextE.enabled = true;
                rrM1_4TextF.enabled = true;

                rrM1_4PointA.enabled = true;
                rrM1_4PointStA.enabled = //kyotuEla.tenmetuOnOff;
                                         false;
                //true;

                rrM1_4PointB.enabled = true;
                rrM1_4PointStB.enabled = //kyotuEla.tenmetuOnOff;
                false;
                //true;
                //rrM1_4PointC.enabled = true;
                //rrM1_4PointStC.enabled = //kyotuEla.tenmetuOnOff;
                //false;
                //true;

                rrM1_4PointD.enabled = true;
                rrM1_4PointStD.enabled = //kyotuEla.tenmetuOnOff;
                                        false;
                rrM1_4PointE.enabled = true;
                rrM1_4PointStE.enabled = //kyotuEla.tenmetuOnOff;
                false;
            } else if (count == 41) {
                reset();
                rrM1_4LineAB.enabled = true;
                rrM1_4LineStAB.enabled = false;
                //kyotuEla.tenmetuOnOff;
                rrM1_4LineStAB2.enabled = //kyotuEla.tenmetuOnOff;
                //false;
                true;

                rrM1_4LineBC.enabled = true;
                rrM1_4LineStBC.enabled = //kyotuEla.tenmetuOnOff;
                false;

                rrM1_4LineCA.enabled = true;
                rrM1_4LineStCA.enabled = //kyotuEla.tenmetuOnOff;
                false;
                rrM1_4LineStCA2.enabled = //kyotuEla.tenmetuOnOff;
                //false;
                true;


                rrM1_4LineDE.enabled = true;
                rrM1_4LineStDE.enabled = //kyotuEla.tenmetuOnOff;
                false;
                rrM1_4LineStDE2.enabled = //kyotuEla.tenmetuOnOff;
                //false;
                true;


                rrM1_4LineEF.enabled = true;
                rrM1_4LineStEF.enabled = //kyotuEla.tenmetuOnOff;
                false;
                rrM1_4LineFD.enabled = true;
                rrM1_4LineStFD.enabled = kyotuEla.tenmetuOnOff;
                //false;
                rrM1_4LineStFD2.enabled = //kyotuEla.tenmetuOnOff;
                //false;
                true;


                rrM1_4kakuBAC.enabled = true;
                //false;

                rrM1_4kakuStBAC.enabled =
                //kyotuEla.tenmetuOnOff;
                false;

                rrM1_4kakuABC.enabled = //true;
                false;
                rrM1_4kakuStABC.enabled =
                //kyotuEla.tenmetuOnOff;
                false;

                rrM1_4kakuACB.enabled = //true;
                false;

                rrM1_4kakuStACB.enabled =
                //kyotuEla.tenmetuOnOff;
                false;


                rrM1_4kakuEDF.enabled = true;
                //false;

                rrM1_4kakuStEDF.enabled =
                //kyotuEla.tenmetuOnOff;
                false;

                rrM1_4kakuDEF.enabled = //true;
                false;

                rrM1_4kakuStDEF.enabled =
                //kyotuEla.tenmetuOnOff;
                false;

                rrM1_4kakuDFE.enabled = //true;
                    false;

                rrM1_4kakuStDFE.enabled =
                //kyotuEla.tenmetuOnOff;
                false;

                rrM1_4TextA.enabled = true;
                rrM1_4TextB.enabled = true;
                rrM1_4TextC.enabled = true;

                rrM1_4TextD.enabled = true;
                rrM1_4TextE.enabled = true;
                rrM1_4TextF.enabled = true;

                rrM1_4PointA.enabled = true;
                rrM1_4PointStA.enabled = //kyotuEla.tenmetuOnOff;
                                         false;
                //true;

                rrM1_4PointB.enabled = true;
                rrM1_4PointStB.enabled = //kyotuEla.tenmetuOnOff;
                false;
                //true;
                //rrM1_4PointC.enabled = true;
                //rrM1_4PointStC.enabled = //kyotuEla.tenmetuOnOff;
                //false;
                //true;

                rrM1_4PointD.enabled = true;
                rrM1_4PointStD.enabled = //kyotuEla.tenmetuOnOff;
                                        false;
                rrM1_4PointE.enabled = true;
                rrM1_4PointStE.enabled = //kyotuEla.tenmetuOnOff;
                false;
                //rrM1_4PointF.enabled = true;
                //rrM1_4PointStF.enabled = //kyotuEla.tenmetuOnOff;
                //false;
            } else if (count == 42) {
                reset();
                rrM1_4LineAB.enabled = true;
                rrM1_4LineStAB.enabled = false;
                //kyotuEla.tenmetuOnOff;
                rrM1_4LineStAB2.enabled = //kyotuEla.tenmetuOnOff;
                //false;
                true;

                rrM1_4LineBC.enabled = true;
                rrM1_4LineStBC.enabled = //kyotuEla.tenmetuOnOff;
                false;

                rrM1_4LineCA.enabled = true;
                rrM1_4LineStCA.enabled = //kyotuEla.tenmetuOnOff;
                false;
                rrM1_4LineStCA2.enabled = //kyotuEla.tenmetuOnOff;
                //false;
                true;


                rrM1_4LineDE.enabled = true;
                rrM1_4LineStDE.enabled = //kyotuEla.tenmetuOnOff;
                false;
                rrM1_4LineStDE2.enabled = //kyotuEla.tenmetuOnOff;
                //false;
                true;


                rrM1_4LineEF.enabled = true;
                rrM1_4LineStEF.enabled = //kyotuEla.tenmetuOnOff;
                false;
                rrM1_4LineFD.enabled = true;
                rrM1_4LineStFD.enabled = //kyotuEla.tenmetuOnOff;
                false;
                rrM1_4LineStFD2.enabled = //kyotuEla.tenmetuOnOff;
                //false;
                true;


                rrM1_4kakuBAC.enabled = true;
                //false;

                rrM1_4kakuStBAC.enabled =
                //kyotuEla.tenmetuOnOff;
                false;

                rrM1_4kakuABC.enabled = //true;
                false;
                rrM1_4kakuStABC.enabled =
                //kyotuEla.tenmetuOnOff;
                false;

                rrM1_4kakuACB.enabled = //true;
                false;

                rrM1_4kakuStACB.enabled =
                //kyotuEla.tenmetuOnOff;
                false;


                rrM1_4kakuEDF.enabled = true;
                //false;

                rrM1_4kakuStEDF.enabled =
                //kyotuEla.tenmetuOnOff;
                false;

                rrM1_4kakuDEF.enabled = //true;
                false;

                rrM1_4kakuStDEF.enabled =
                //kyotuEla.tenmetuOnOff;
                false;

                rrM1_4kakuDFE.enabled = //true;
                    false;

                rrM1_4kakuStDFE.enabled =
                //kyotuEla.tenmetuOnOff;
                false;

                rrM1_4TextA.enabled = true;
                rrM1_4TextB.enabled = true;
                rrM1_4TextC.enabled = true;

                rrM1_4TextD.enabled = true;
                rrM1_4TextE.enabled = true;
                rrM1_4TextF.enabled = true;

                rrM1_4PointA.enabled = true;
                rrM1_4PointStA.enabled = //kyotuEla.tenmetuOnOff;
                                         false;
                //true;

                rrM1_4PointB.enabled = true;
                rrM1_4PointStB.enabled = //kyotuEla.tenmetuOnOff;
                false;
                //true;
                rrM1_4PointC.enabled = true;
                rrM1_4PointStC.enabled = kyotuEla.tenmetuOnOff;
                //false;
                //true;

                rrM1_4PointD.enabled = true;
                rrM1_4PointStD.enabled = //kyotuEla.tenmetuOnOff;
                                        false;
                rrM1_4PointE.enabled = true;
                rrM1_4PointStE.enabled = //kyotuEla.tenmetuOnOff;
                false;
                //rrM1_4PointF.enabled = true;
                //rrM1_4PointStF.enabled = //kyotuEla.tenmetuOnOff;
                //false;
            } else if (count == 43) {
                reset();
                rrM1_4LineAB.enabled = true;
                rrM1_4LineStAB.enabled = false;
                //kyotuEla.tenmetuOnOff;
                rrM1_4LineStAB2.enabled = //kyotuEla.tenmetuOnOff;
                //false;
                true;

                rrM1_4LineBC.enabled = true;
                rrM1_4LineStBC.enabled = //kyotuEla.tenmetuOnOff;
                false;

                rrM1_4LineCA.enabled = true;
                rrM1_4LineStCA.enabled = //kyotuEla.tenmetuOnOff;
                false;
                rrM1_4LineStCA2.enabled = //kyotuEla.tenmetuOnOff;
                //false;
                true;


                rrM1_4LineDE.enabled = true;
                rrM1_4LineStDE.enabled = //kyotuEla.tenmetuOnOff;
                false;
                rrM1_4LineStDE2.enabled = //kyotuEla.tenmetuOnOff;
                //false;
                true;


                rrM1_4LineEF.enabled = true;
                rrM1_4LineStEF.enabled = //kyotuEla.tenmetuOnOff;
                false;
                rrM1_4LineFD.enabled = true;
                rrM1_4LineStFD.enabled = //kyotuEla.tenmetuOnOff;
                false;
                rrM1_4LineStFD2.enabled = //kyotuEla.tenmetuOnOff;
                //false;
                true;


                rrM1_4kakuBAC.enabled = true;
                //false;

                rrM1_4kakuStBAC.enabled =
                //kyotuEla.tenmetuOnOff;
                false;

                rrM1_4kakuABC.enabled = //true;
                false;
                rrM1_4kakuStABC.enabled =
                //kyotuEla.tenmetuOnOff;
                false;

                rrM1_4kakuACB.enabled = //true;
                false;

                rrM1_4kakuStACB.enabled =
                //kyotuEla.tenmetuOnOff;
                false;


                rrM1_4kakuEDF.enabled = true;
                //false;

                rrM1_4kakuStEDF.enabled =
                //kyotuEla.tenmetuOnOff;
                false;

                rrM1_4kakuDEF.enabled = //true;
                false;

                rrM1_4kakuStDEF.enabled =
                //kyotuEla.tenmetuOnOff;
                false;

                rrM1_4kakuDFE.enabled = //true;
                    false;

                rrM1_4kakuStDFE.enabled =
                //kyotuEla.tenmetuOnOff;
                false;

                rrM1_4TextA.enabled = true;
                rrM1_4TextB.enabled = true;
                rrM1_4TextC.enabled = true;

                rrM1_4TextD.enabled = true;
                rrM1_4TextE.enabled = true;
                rrM1_4TextF.enabled = true;

                rrM1_4PointA.enabled = true;
                rrM1_4PointStA.enabled = //kyotuEla.tenmetuOnOff;
                                         false;
                //true;

                rrM1_4PointB.enabled = true;
                rrM1_4PointStB.enabled = //kyotuEla.tenmetuOnOff;
                false;
                //true;
                rrM1_4PointC.enabled = true;
                rrM1_4PointStC.enabled = //kyotuEla.tenmetuOnOff;
                //false;
                true;

                rrM1_4PointD.enabled = true;
                rrM1_4PointStD.enabled = //kyotuEla.tenmetuOnOff;
                                        false;
                rrM1_4PointE.enabled = true;
                rrM1_4PointStE.enabled = //kyotuEla.tenmetuOnOff;
                false;
                rrM1_4PointF.enabled = true;
                rrM1_4PointStF.enabled = kyotuEla.tenmetuOnOff;
                //false;
            } else if (count == 44) {
                reset();
                rrM1_4LineAB.enabled = true;
                rrM1_4LineStAB.enabled = false;
                //kyotuEla.tenmetuOnOff;
                rrM1_4LineStAB2.enabled = //kyotuEla.tenmetuOnOff;
                //false;
                true;

                rrM1_4LineBC.enabled = true;
                rrM1_4LineStBC.enabled = //kyotuEla.tenmetuOnOff;
                false;

                rrM1_4LineCA.enabled = true;
                rrM1_4LineStCA.enabled = //kyotuEla.tenmetuOnOff;
                false;
                rrM1_4LineStCA2.enabled = //kyotuEla.tenmetuOnOff;
                //false;
                true;


                rrM1_4LineDE.enabled = true;
                rrM1_4LineStDE.enabled = //kyotuEla.tenmetuOnOff;
                false;
                rrM1_4LineStDE2.enabled = //kyotuEla.tenmetuOnOff;
                //false;
                true;


                rrM1_4LineEF.enabled = true;
                rrM1_4LineStEF.enabled = //kyotuEla.tenmetuOnOff;
                false;
                rrM1_4LineFD.enabled = true;
                rrM1_4LineStFD.enabled = //kyotuEla.tenmetuOnOff;
                false;
                rrM1_4LineStFD2.enabled = //kyotuEla.tenmetuOnOff;
                //false;
                true;


                rrM1_4kakuBAC.enabled = true;
                //false;

                rrM1_4kakuStBAC.enabled =
                //kyotuEla.tenmetuOnOff;
                false;

                rrM1_4kakuABC.enabled = //true;
                false;
                rrM1_4kakuStABC.enabled =
                //kyotuEla.tenmetuOnOff;
                false;

                rrM1_4kakuACB.enabled = //true;
                false;

                rrM1_4kakuStACB.enabled =
                //kyotuEla.tenmetuOnOff;
                false;


                rrM1_4kakuEDF.enabled = true;
                //false;

                rrM1_4kakuStEDF.enabled =
                //kyotuEla.tenmetuOnOff;
                false;

                rrM1_4kakuDEF.enabled = //true;
                false;

                rrM1_4kakuStDEF.enabled =
                //kyotuEla.tenmetuOnOff;
                false;

                rrM1_4kakuDFE.enabled = //true;
                    false;

                rrM1_4kakuStDFE.enabled =
                //kyotuEla.tenmetuOnOff;
                false;

                rrM1_4TextA.enabled = true;
                rrM1_4TextB.enabled = true;
                rrM1_4TextC.enabled = true;

                rrM1_4TextD.enabled = true;
                rrM1_4TextE.enabled = true;
                rrM1_4TextF.enabled = true;

                rrM1_4PointA.enabled = true;
                rrM1_4PointStA.enabled = //kyotuEla.tenmetuOnOff;
                                         false;
                //true;

                rrM1_4PointB.enabled = true;
                rrM1_4PointStB.enabled = kyotuEla.tenmetuOnOff;
                //false;
                //true;
                rrM1_4PointC.enabled = true;
                rrM1_4PointStC.enabled = //kyotuEla.tenmetuOnOff;
                false;
                //true;

                rrM1_4PointD.enabled = true;
                rrM1_4PointStD.enabled = //kyotuEla.tenmetuOnOff;
                                        false;
                rrM1_4PointE.enabled = true;
                rrM1_4PointStE.enabled = //kyotuEla.tenmetuOnOff;
                false;
                rrM1_4PointF.enabled = true;
                rrM1_4PointStF.enabled = //kyotuEla.tenmetuOnOff;
                false;
            } else if (count == 45) {
                reset();
                rrM1_4LineAB.enabled = true;
                rrM1_4LineStAB.enabled = false;
                //kyotuEla.tenmetuOnOff;
                rrM1_4LineStAB2.enabled = //kyotuEla.tenmetuOnOff;
                //false;
                true;

                rrM1_4LineBC.enabled = true;
                rrM1_4LineStBC.enabled = //kyotuEla.tenmetuOnOff;
                false;

                rrM1_4LineCA.enabled = true;
                rrM1_4LineStCA.enabled = //kyotuEla.tenmetuOnOff;
                false;
                rrM1_4LineStCA2.enabled = //kyotuEla.tenmetuOnOff;
                //false;
                true;


                rrM1_4LineDE.enabled = true;
                rrM1_4LineStDE.enabled = //kyotuEla.tenmetuOnOff;
                false;
                rrM1_4LineStDE2.enabled = //kyotuEla.tenmetuOnOff;
                //false;
                true;


                rrM1_4LineEF.enabled = true;
                rrM1_4LineStEF.enabled = //kyotuEla.tenmetuOnOff;
                false;
                rrM1_4LineFD.enabled = true;
                rrM1_4LineStFD.enabled = //kyotuEla.tenmetuOnOff;
                false;
                rrM1_4LineStFD2.enabled = //kyotuEla.tenmetuOnOff;
                //false;
                true;


                rrM1_4kakuBAC.enabled = true;
                //false;

                rrM1_4kakuStBAC.enabled =
                //kyotuEla.tenmetuOnOff;
                false;

                rrM1_4kakuABC.enabled = //true;
                false;
                rrM1_4kakuStABC.enabled =
                //kyotuEla.tenmetuOnOff;
                false;

                rrM1_4kakuACB.enabled = //true;
                false;

                rrM1_4kakuStACB.enabled =
                //kyotuEla.tenmetuOnOff;
                false;


                rrM1_4kakuEDF.enabled = true;
                //false;

                rrM1_4kakuStEDF.enabled =
                //kyotuEla.tenmetuOnOff;
                false;

                rrM1_4kakuDEF.enabled = //true;
                false;

                rrM1_4kakuStDEF.enabled =
                //kyotuEla.tenmetuOnOff;
                false;

                rrM1_4kakuDFE.enabled = //true;
                    false;

                rrM1_4kakuStDFE.enabled =
                //kyotuEla.tenmetuOnOff;
                false;

                rrM1_4TextA.enabled = true;
                rrM1_4TextB.enabled = true;
                rrM1_4TextC.enabled = true;

                rrM1_4TextD.enabled = true;
                rrM1_4TextE.enabled = true;
                rrM1_4TextF.enabled = true;

                rrM1_4PointA.enabled = true;
                rrM1_4PointStA.enabled = //kyotuEla.tenmetuOnOff;
                                         false;
                //true;

                rrM1_4PointB.enabled = true;
                rrM1_4PointStB.enabled = //kyotuEla.tenmetuOnOff;
                //false;
                true;
                rrM1_4PointC.enabled = true;
                rrM1_4PointStC.enabled = //kyotuEla.tenmetuOnOff;
                false;
                //true;

                rrM1_4PointD.enabled = true;
                rrM1_4PointStD.enabled = //kyotuEla.tenmetuOnOff;
                                        false;
                rrM1_4PointE.enabled = true;
                rrM1_4PointStE.enabled = kyotuEla.tenmetuOnOff;
                //false;
                rrM1_4PointF.enabled = true;
                rrM1_4PointStF.enabled = //kyotuEla.tenmetuOnOff;
                false;
            } else if (count == 46) {
                reset();
                rrM1_4LineAB.enabled = true;
                rrM1_4LineStAB.enabled = false;
                //kyotuEla.tenmetuOnOff;
                rrM1_4LineStAB2.enabled = //kyotuEla.tenmetuOnOff;
                //false;
                true;

                rrM1_4LineBC.enabled = true;
                rrM1_4LineStBC.enabled = kyotuEla.tenmetuOnOff;
                //false;

                rrM1_4LineCA.enabled = true;
                rrM1_4LineStCA.enabled = //kyotuEla.tenmetuOnOff;
                false;
                rrM1_4LineStCA2.enabled = //kyotuEla.tenmetuOnOff;
                //false;
                true;


                rrM1_4LineDE.enabled = true;
                rrM1_4LineStDE.enabled = //kyotuEla.tenmetuOnOff;
                false;
                rrM1_4LineStDE2.enabled = //kyotuEla.tenmetuOnOff;
                //false;
                true;


                rrM1_4LineEF.enabled = true;
                rrM1_4LineStEF.enabled = //kyotuEla.tenmetuOnOff;
                false;
                rrM1_4LineFD.enabled = true;
                rrM1_4LineStFD.enabled = //kyotuEla.tenmetuOnOff;
                false;
                rrM1_4LineStFD2.enabled = //kyotuEla.tenmetuOnOff;
                //false;
                true;


                rrM1_4kakuBAC.enabled = true;
                //false;

                rrM1_4kakuStBAC.enabled =
                //kyotuEla.tenmetuOnOff;
                false;

                rrM1_4kakuABC.enabled = //true;
                false;
                rrM1_4kakuStABC.enabled =
                //kyotuEla.tenmetuOnOff;
                false;

                rrM1_4kakuACB.enabled = //true;
                false;

                rrM1_4kakuStACB.enabled =
                //kyotuEla.tenmetuOnOff;
                false;


                rrM1_4kakuEDF.enabled = true;
                //false;

                rrM1_4kakuStEDF.enabled =
                //kyotuEla.tenmetuOnOff;
                false;

                rrM1_4kakuDEF.enabled = //true;
                false;

                rrM1_4kakuStDEF.enabled =
                //kyotuEla.tenmetuOnOff;
                false;

                rrM1_4kakuDFE.enabled = //true;
                    false;

                rrM1_4kakuStDFE.enabled =
                //kyotuEla.tenmetuOnOff;
                false;

                rrM1_4TextA.enabled = true;
                rrM1_4TextB.enabled = true;
                rrM1_4TextC.enabled = true;

                rrM1_4TextD.enabled = true;
                rrM1_4TextE.enabled = true;
                rrM1_4TextF.enabled = true;

                rrM1_4PointA.enabled = true;
                rrM1_4PointStA.enabled = //kyotuEla.tenmetuOnOff;
                                         false;
                //true;

                rrM1_4PointB.enabled = true;
                rrM1_4PointStB.enabled = //kyotuEla.tenmetuOnOff;
                false;
                //true;
                rrM1_4PointC.enabled = true;
                rrM1_4PointStC.enabled = //kyotuEla.tenmetuOnOff;
                false;
                //true;

                rrM1_4PointD.enabled = true;
                rrM1_4PointStD.enabled = //kyotuEla.tenmetuOnOff;
                                        false;
                rrM1_4PointE.enabled = true;
                rrM1_4PointStE.enabled = //kyotuEla.tenmetuOnOff;
                false;
                rrM1_4PointF.enabled = true;
                rrM1_4PointStF.enabled = //kyotuEla.tenmetuOnOff;
                false;
            } else if (count == 47) {
                reset();
                rrM1_4LineAB.enabled = true;
                rrM1_4LineStAB.enabled = false;
                //kyotuEla.tenmetuOnOff;
                rrM1_4LineStAB2.enabled = //kyotuEla.tenmetuOnOff;
                //false;
                true;

                rrM1_4LineBC.enabled = true;
                rrM1_4LineStBC.enabled = //kyotuEla.tenmetuOnOff;
                //false;
                true;

                rrM1_4LineCA.enabled = true;
                rrM1_4LineStCA.enabled = //kyotuEla.tenmetuOnOff;
                false;
                rrM1_4LineStCA2.enabled = //kyotuEla.tenmetuOnOff;
                //false;
                true;


                rrM1_4LineDE.enabled = true;
                rrM1_4LineStDE.enabled = //kyotuEla.tenmetuOnOff;
                false;
                rrM1_4LineStDE2.enabled = //kyotuEla.tenmetuOnOff;
                //false;
                true;


                rrM1_4LineEF.enabled = true;
                rrM1_4LineStEF.enabled = kyotuEla.tenmetuOnOff;
                //false;
                rrM1_4LineFD.enabled = true;
                rrM1_4LineStFD.enabled = //kyotuEla.tenmetuOnOff;
                false;
                rrM1_4LineStFD2.enabled = //kyotuEla.tenmetuOnOff;
                //false;
                true;


                rrM1_4kakuBAC.enabled = true;
                //false;

                rrM1_4kakuStBAC.enabled =
                //kyotuEla.tenmetuOnOff;
                false;

                rrM1_4kakuABC.enabled = //true;
                false;
                rrM1_4kakuStABC.enabled =
                //kyotuEla.tenmetuOnOff;
                false;

                rrM1_4kakuACB.enabled = //true;
                false;

                rrM1_4kakuStACB.enabled =
                //kyotuEla.tenmetuOnOff;
                false;


                rrM1_4kakuEDF.enabled = true;
                //false;

                rrM1_4kakuStEDF.enabled =
                //kyotuEla.tenmetuOnOff;
                false;

                rrM1_4kakuDEF.enabled = //true;
                false;

                rrM1_4kakuStDEF.enabled =
                //kyotuEla.tenmetuOnOff;
                false;

                rrM1_4kakuDFE.enabled = //true;
                    false;

                rrM1_4kakuStDFE.enabled =
                //kyotuEla.tenmetuOnOff;
                false;

                rrM1_4TextA.enabled = true;
                rrM1_4TextB.enabled = true;
                rrM1_4TextC.enabled = true;

                rrM1_4TextD.enabled = true;
                rrM1_4TextE.enabled = true;
                rrM1_4TextF.enabled = true;

                rrM1_4PointA.enabled = true;
                rrM1_4PointStA.enabled = //kyotuEla.tenmetuOnOff;
                                         false;
                //true;

                rrM1_4PointB.enabled = true;
                rrM1_4PointStB.enabled = //kyotuEla.tenmetuOnOff;
                false;
                //true;
                rrM1_4PointC.enabled = true;
                rrM1_4PointStC.enabled = //kyotuEla.tenmetuOnOff;
                false;
                //true;

                rrM1_4PointD.enabled = true;
                rrM1_4PointStD.enabled = //kyotuEla.tenmetuOnOff;
                                        false;
                rrM1_4PointE.enabled = true;
                rrM1_4PointStE.enabled = //kyotuEla.tenmetuOnOff;
                false;
                rrM1_4PointF.enabled = true;
                rrM1_4PointStF.enabled = //kyotuEla.tenmetuOnOff;
                false;
            } else if (count == 48) {
                reset();
                rrM1_4LineAB.enabled = true;
                rrM1_4LineStAB.enabled = false;
                //kyotuEla.tenmetuOnOff;
                rrM1_4LineStAB2.enabled = //kyotuEla.tenmetuOnOff;
                //false;
                true;

                rrM1_4LineBC.enabled = true;
                rrM1_4LineStBC.enabled = //kyotuEla.tenmetuOnOff;
                false;
                //true;

                rrM1_4LineCA.enabled = true;
                rrM1_4LineStCA.enabled = //kyotuEla.tenmetuOnOff;
                false;
                rrM1_4LineStCA2.enabled = //kyotuEla.tenmetuOnOff;
                //false;
                true;


                rrM1_4LineDE.enabled = true;
                rrM1_4LineStDE.enabled = //kyotuEla.tenmetuOnOff;
                false;
                rrM1_4LineStDE2.enabled = //kyotuEla.tenmetuOnOff;
                //false;
                true;


                rrM1_4LineEF.enabled = true;
                rrM1_4LineStEF.enabled = //kyotuEla.tenmetuOnOff;
                false;
                rrM1_4LineFD.enabled = true;
                rrM1_4LineStFD.enabled = //kyotuEla.tenmetuOnOff;
                false;
                rrM1_4LineStFD2.enabled = //kyotuEla.tenmetuOnOff;
                //false;
                true;


                rrM1_4kakuBAC.enabled = true;
                //false;

                rrM1_4kakuStBAC.enabled =
                //kyotuEla.tenmetuOnOff;
                false;

                rrM1_4kakuABC.enabled = //true;
                false;
                rrM1_4kakuStABC.enabled =
                //kyotuEla.tenmetuOnOff;
                false;

                rrM1_4kakuACB.enabled = //true;
                false;

                rrM1_4kakuStACB.enabled =
                //kyotuEla.tenmetuOnOff;
                false;


                rrM1_4kakuEDF.enabled = true;
                //false;

                rrM1_4kakuStEDF.enabled =
                //kyotuEla.tenmetuOnOff;
                false;

                rrM1_4kakuDEF.enabled = //true;
                false;

                rrM1_4kakuStDEF.enabled =
                //kyotuEla.tenmetuOnOff;
                false;

                rrM1_4kakuDFE.enabled = //true;
                    false;

                rrM1_4kakuStDFE.enabled =
                //kyotuEla.tenmetuOnOff;
                false;

                rrM1_4TextA.enabled = true;
                rrM1_4TextB.enabled = true;
                rrM1_4TextC.enabled = true;

                rrM1_4TextD.enabled = true;
                rrM1_4TextE.enabled = true;
                rrM1_4TextF.enabled = true;

                rrM1_4PointA.enabled = true;
                rrM1_4PointStA.enabled = //kyotuEla.tenmetuOnOff;
                                         false;
                //true;

                rrM1_4PointB.enabled = true;
                rrM1_4PointStB.enabled = //kyotuEla.tenmetuOnOff;
                false;
                //true;
                rrM1_4PointC.enabled = true;
                rrM1_4PointStC.enabled = //kyotuEla.tenmetuOnOff;
                false;
                //true;

                rrM1_4PointD.enabled = true;
                rrM1_4PointStD.enabled = //kyotuEla.tenmetuOnOff;
                                        false;
                rrM1_4PointE.enabled = true;
                rrM1_4PointStE.enabled = //kyotuEla.tenmetuOnOff;
                false;
                rrM1_4PointF.enabled = true;
                rrM1_4PointStF.enabled = //kyotuEla.tenmetuOnOff;
                false;
            } else if (count == 49) {
                reset();
                rrM1_4LineAB.enabled = true;
                rrM1_4LineStAB.enabled = false;
                //kyotuEla.tenmetuOnOff;
                rrM1_4LineStAB2.enabled = //kyotuEla.tenmetuOnOff;
                //false;
                true;

                rrM1_4LineBC.enabled = true;
                rrM1_4LineStBC.enabled = //kyotuEla.tenmetuOnOff;
                false;
                //true;

                rrM1_4LineCA.enabled = true;
                rrM1_4LineStCA.enabled = //kyotuEla.tenmetuOnOff;
                false;
                rrM1_4LineStCA2.enabled = //kyotuEla.tenmetuOnOff;
                //false;
                true;


                rrM1_4LineDE.enabled = true;
                rrM1_4LineStDE.enabled = //kyotuEla.tenmetuOnOff;
                false;
                rrM1_4LineStDE2.enabled = //kyotuEla.tenmetuOnOff;
                //false;
                true;


                rrM1_4LineEF.enabled = true;
                rrM1_4LineStEF.enabled = //kyotuEla.tenmetuOnOff;
                false;
                rrM1_4LineFD.enabled = true;
                rrM1_4LineStFD.enabled = //kyotuEla.tenmetuOnOff;
                false;
                rrM1_4LineStFD2.enabled = //kyotuEla.tenmetuOnOff;
                //false;
                true;


                rrM1_4kakuBAC.enabled = true;
                //false;

                rrM1_4kakuStBAC.enabled =
                //kyotuEla.tenmetuOnOff;
                false;

                rrM1_4kakuABC.enabled = //true;
                false;
                rrM1_4kakuStABC.enabled =
                //kyotuEla.tenmetuOnOff;
                false;

                rrM1_4kakuACB.enabled = //true;
                false;

                rrM1_4kakuStACB.enabled =
                //kyotuEla.tenmetuOnOff;
                false;


                rrM1_4kakuEDF.enabled = true;
                //false;

                rrM1_4kakuStEDF.enabled =
                //kyotuEla.tenmetuOnOff;
                false;

                rrM1_4kakuDEF.enabled = //true;
                false;

                rrM1_4kakuStDEF.enabled =
                //kyotuEla.tenmetuOnOff;
                false;

                rrM1_4kakuDFE.enabled = //true;
                    false;

                rrM1_4kakuStDFE.enabled =
                //kyotuEla.tenmetuOnOff;
                false;

                rrM1_4TextA.enabled = true;
                rrM1_4TextB.enabled = true;
                rrM1_4TextC.enabled = true;

                rrM1_4TextD.enabled = true;
                rrM1_4TextE.enabled = true;
                rrM1_4TextF.enabled = true;

                rrM1_4PointA.enabled = true;
                rrM1_4PointStA.enabled = //kyotuEla.tenmetuOnOff;
                                         false;
                //true;

                rrM1_4PointB.enabled = true;
                rrM1_4PointStB.enabled = //kyotuEla.tenmetuOnOff;
                false;
                //true;
                rrM1_4PointC.enabled = true;
                rrM1_4PointStC.enabled = //kyotuEla.tenmetuOnOff;
                false;
                //true;

                rrM1_4PointD.enabled = true;
                rrM1_4PointStD.enabled = //kyotuEla.tenmetuOnOff;
                                        false;
                rrM1_4PointE.enabled = true;
                rrM1_4PointStE.enabled = //kyotuEla.tenmetuOnOff;
                false;
                rrM1_4PointF.enabled = true;
                rrM1_4PointStF.enabled = //kyotuEla.tenmetuOnOff;
                false;
            } else if (count == 50) {
                reset();
                rrM1_4LineAB.enabled = true;
                rrM1_4LineStAB.enabled = false;
                //kyotuEla.tenmetuOnOff;
                rrM1_4LineStAB2.enabled = //kyotuEla.tenmetuOnOff;
                //false;
                true;

                rrM1_4LineBC.enabled = true;
                rrM1_4LineStBC.enabled = kyotuEla.tenmetuOnOff;
                //false;
                //true;

                rrM1_4LineCA.enabled = true;
                rrM1_4LineStCA.enabled = //kyotuEla.tenmetuOnOff;
                false;
                rrM1_4LineStCA2.enabled = //kyotuEla.tenmetuOnOff;
                //false;
                true;


                rrM1_4LineDE.enabled = true;
                rrM1_4LineStDE.enabled = //kyotuEla.tenmetuOnOff;
                false;
                rrM1_4LineStDE2.enabled = //kyotuEla.tenmetuOnOff;
                //false;
                true;


                rrM1_4LineEF.enabled = true;
                rrM1_4LineStEF.enabled = //kyotuEla.tenmetuOnOff;
                false;
                rrM1_4LineFD.enabled = true;
                rrM1_4LineStFD.enabled = //kyotuEla.tenmetuOnOff;
                false;
                rrM1_4LineStFD2.enabled = //kyotuEla.tenmetuOnOff;
                //false;
                true;


                rrM1_4kakuBAC.enabled = true;
                //false;

                rrM1_4kakuStBAC.enabled =
                //kyotuEla.tenmetuOnOff;
                false;

                rrM1_4kakuABC.enabled = //true;
                false;
                rrM1_4kakuStABC.enabled =
                //kyotuEla.tenmetuOnOff;
                false;

                rrM1_4kakuACB.enabled = //true;
                false;

                rrM1_4kakuStACB.enabled =
                //kyotuEla.tenmetuOnOff;
                false;


                rrM1_4kakuEDF.enabled = true;
                //false;

                rrM1_4kakuStEDF.enabled =
                //kyotuEla.tenmetuOnOff;
                false;

                rrM1_4kakuDEF.enabled = //true;
                false;

                rrM1_4kakuStDEF.enabled =
                //kyotuEla.tenmetuOnOff;
                false;

                rrM1_4kakuDFE.enabled = //true;
                    false;

                rrM1_4kakuStDFE.enabled =
                //kyotuEla.tenmetuOnOff;
                false;

                rrM1_4TextA.enabled = true;
                rrM1_4TextB.enabled = true;
                rrM1_4TextC.enabled = true;

                rrM1_4TextD.enabled = true;
                rrM1_4TextE.enabled = true;
                rrM1_4TextF.enabled = true;

                rrM1_4PointA.enabled = true;
                rrM1_4PointStA.enabled = //kyotuEla.tenmetuOnOff;
                                         false;
                //true;

                rrM1_4PointB.enabled = true;
                rrM1_4PointStB.enabled = //kyotuEla.tenmetuOnOff;
                false;
                //true;
                rrM1_4PointC.enabled = true;
                rrM1_4PointStC.enabled = //kyotuEla.tenmetuOnOff;
                false;
                //true;

                rrM1_4PointD.enabled = true;
                rrM1_4PointStD.enabled = //kyotuEla.tenmetuOnOff;
                                        false;
                rrM1_4PointE.enabled = true;
                rrM1_4PointStE.enabled = //kyotuEla.tenmetuOnOff;
                false;
                rrM1_4PointF.enabled = true;
                rrM1_4PointStF.enabled = //kyotuEla.tenmetuOnOff;
                false;
            } else if (count == 51) {
                reset();
                rrM1_4LineAB.enabled = true;
                rrM1_4LineStAB.enabled = false;
                //kyotuEla.tenmetuOnOff;
                rrM1_4LineStAB2.enabled = //kyotuEla.tenmetuOnOff;
                //false;
                true;

                rrM1_4LineBC.enabled = true;
                rrM1_4LineStBC.enabled = //kyotuEla.tenmetuOnOff;
                //false;
                true;

                rrM1_4LineCA.enabled = true;
                rrM1_4LineStCA.enabled = //kyotuEla.tenmetuOnOff;
                false;
                rrM1_4LineStCA2.enabled = //kyotuEla.tenmetuOnOff;
                //false;
                true;


                rrM1_4LineDE.enabled = true;
                rrM1_4LineStDE.enabled = //kyotuEla.tenmetuOnOff;
                false;
                rrM1_4LineStDE2.enabled = //kyotuEla.tenmetuOnOff;
                //false;
                true;


                rrM1_4LineEF.enabled = true;
                rrM1_4LineStEF.enabled = kyotuEla.tenmetuOnOff;
                //false;
                rrM1_4LineFD.enabled = true;
                rrM1_4LineStFD.enabled = //kyotuEla.tenmetuOnOff;
                false;
                rrM1_4LineStFD2.enabled = //kyotuEla.tenmetuOnOff;
                //false;
                true;


                rrM1_4kakuBAC.enabled = true;
                //false;

                rrM1_4kakuStBAC.enabled =
                //kyotuEla.tenmetuOnOff;
                false;

                rrM1_4kakuABC.enabled = //true;
                false;
                rrM1_4kakuStABC.enabled =
                //kyotuEla.tenmetuOnOff;
                false;

                rrM1_4kakuACB.enabled = //true;
                false;

                rrM1_4kakuStACB.enabled =
                //kyotuEla.tenmetuOnOff;
                false;


                rrM1_4kakuEDF.enabled = true;
                //false;

                rrM1_4kakuStEDF.enabled =
                //kyotuEla.tenmetuOnOff;
                false;

                rrM1_4kakuDEF.enabled = //true;
                false;

                rrM1_4kakuStDEF.enabled =
                //kyotuEla.tenmetuOnOff;
                false;

                rrM1_4kakuDFE.enabled = //true;
                    false;

                rrM1_4kakuStDFE.enabled =
                //kyotuEla.tenmetuOnOff;
                false;

                rrM1_4TextA.enabled = true;
                rrM1_4TextB.enabled = true;
                rrM1_4TextC.enabled = true;

                rrM1_4TextD.enabled = true;
                rrM1_4TextE.enabled = true;
                rrM1_4TextF.enabled = true;

                rrM1_4PointA.enabled = true;
                rrM1_4PointStA.enabled = //kyotuEla.tenmetuOnOff;
                                         false;
                //true;

                rrM1_4PointB.enabled = true;
                rrM1_4PointStB.enabled = //kyotuEla.tenmetuOnOff;
                false;
                //true;
                rrM1_4PointC.enabled = true;
                rrM1_4PointStC.enabled = //kyotuEla.tenmetuOnOff;
                false;
                //true;

                rrM1_4PointD.enabled = true;
                rrM1_4PointStD.enabled = //kyotuEla.tenmetuOnOff;
                                        false;
                rrM1_4PointE.enabled = true;
                rrM1_4PointStE.enabled = //kyotuEla.tenmetuOnOff;
                false;
                rrM1_4PointF.enabled = true;
                rrM1_4PointStF.enabled = //kyotuEla.tenmetuOnOff;
                false;
            } else if (count == 52) {
                reset();
                rrM1_4LineAB.enabled = true;
                rrM1_4LineStAB.enabled = false;
                //kyotuEla.tenmetuOnOff;
                rrM1_4LineStAB2.enabled = //kyotuEla.tenmetuOnOff;
                //false;
                true;

                rrM1_4LineBC.enabled = true;
                rrM1_4LineStBC.enabled = //kyotuEla.tenmetuOnOff;
                false;
                //true;

                rrM1_4LineCA.enabled = true;
                rrM1_4LineStCA.enabled = //kyotuEla.tenmetuOnOff;
                false;
                rrM1_4LineStCA2.enabled = //kyotuEla.tenmetuOnOff;
                //false;
                true;


                rrM1_4LineDE.enabled = true;
                rrM1_4LineStDE.enabled = //kyotuEla.tenmetuOnOff;
                false;
                rrM1_4LineStDE2.enabled = //kyotuEla.tenmetuOnOff;
                //false;
                true;


                rrM1_4LineEF.enabled = true;
                rrM1_4LineStEF.enabled = //kyotuEla.tenmetuOnOff;
                false;
                rrM1_4LineFD.enabled = true;
                rrM1_4LineStFD.enabled = //kyotuEla.tenmetuOnOff;
                false;
                rrM1_4LineStFD2.enabled = //kyotuEla.tenmetuOnOff;
                //false;
                true;


                rrM1_4kakuBAC.enabled = true;
                //false;

                rrM1_4kakuStBAC.enabled =
                //kyotuEla.tenmetuOnOff;
                false;

                rrM1_4kakuABC.enabled = //true;
                false;
                rrM1_4kakuStABC.enabled =
                //kyotuEla.tenmetuOnOff;
                false;

                rrM1_4kakuACB.enabled = //true;
                false;

                rrM1_4kakuStACB.enabled =
                //kyotuEla.tenmetuOnOff;
                false;


                rrM1_4kakuEDF.enabled = true;
                //false;

                rrM1_4kakuStEDF.enabled =
                //kyotuEla.tenmetuOnOff;
                false;

                rrM1_4kakuDEF.enabled = //true;
                false;

                rrM1_4kakuStDEF.enabled =
                //kyotuEla.tenmetuOnOff;
                false;

                rrM1_4kakuDFE.enabled = //true;
                    false;

                rrM1_4kakuStDFE.enabled =
                //kyotuEla.tenmetuOnOff;
                false;

                rrM1_4TextA.enabled = true;
                rrM1_4TextB.enabled = true;
                rrM1_4TextC.enabled = true;

                rrM1_4TextD.enabled = true;
                rrM1_4TextE.enabled = true;
                rrM1_4TextF.enabled = true;

                rrM1_4PointA.enabled = true;
                rrM1_4PointStA.enabled = //kyotuEla.tenmetuOnOff;
                                         false;
                //true;

                rrM1_4PointB.enabled = true;
                rrM1_4PointStB.enabled = //kyotuEla.tenmetuOnOff;
                false;
                //true;
                rrM1_4PointC.enabled = true;
                rrM1_4PointStC.enabled = //kyotuEla.tenmetuOnOff;
                false;
                //true;

                rrM1_4PointD.enabled = true;
                rrM1_4PointStD.enabled = //kyotuEla.tenmetuOnOff;
                                        false;
                rrM1_4PointE.enabled = true;
                rrM1_4PointStE.enabled = //kyotuEla.tenmetuOnOff;
                false;
                rrM1_4PointF.enabled = true;
                rrM1_4PointStF.enabled = //kyotuEla.tenmetuOnOff;
                false;
            } else if (count == 53) {
                reset();
                rrM1_4LineAB.enabled = true;
                rrM1_4LineStAB.enabled = false;
                //kyotuEla.tenmetuOnOff;
                rrM1_4LineStAB2.enabled = //kyotuEla.tenmetuOnOff;
                //false;
                true;

                rrM1_4LineBC.enabled = true;
                rrM1_4LineStBC.enabled = //kyotuEla.tenmetuOnOff;
                false;
                //true;

                rrM1_4LineCA.enabled = true;
                rrM1_4LineStCA.enabled = //kyotuEla.tenmetuOnOff;
                false;
                rrM1_4LineStCA2.enabled = //kyotuEla.tenmetuOnOff;
                //false;
                true;


                rrM1_4LineDE.enabled = true;
                rrM1_4LineStDE.enabled = //kyotuEla.tenmetuOnOff;
                false;
                rrM1_4LineStDE2.enabled = //kyotuEla.tenmetuOnOff;
                //false;
                true;


                rrM1_4LineEF.enabled = true;
                rrM1_4LineStEF.enabled = //kyotuEla.tenmetuOnOff;
                false;
                rrM1_4LineFD.enabled = true;
                rrM1_4LineStFD.enabled = //kyotuEla.tenmetuOnOff;
                false;
                rrM1_4LineStFD2.enabled = //kyotuEla.tenmetuOnOff;
                //false;
                true;


                rrM1_4kakuBAC.enabled = true;
                //false;

                rrM1_4kakuStBAC.enabled =
                //kyotuEla.tenmetuOnOff;
                false;

                rrM1_4kakuABC.enabled = //true;
                false;
                rrM1_4kakuStABC.enabled =
                //kyotuEla.tenmetuOnOff;
                false;

                rrM1_4kakuACB.enabled = //true;
                false;

                rrM1_4kakuStACB.enabled =
                //kyotuEla.tenmetuOnOff;
                false;


                rrM1_4kakuEDF.enabled = true;
                //false;

                rrM1_4kakuStEDF.enabled =
                //kyotuEla.tenmetuOnOff;
                false;

                rrM1_4kakuDEF.enabled = //true;
                false;

                rrM1_4kakuStDEF.enabled =
                //kyotuEla.tenmetuOnOff;
                false;

                rrM1_4kakuDFE.enabled = //true;
                    false;

                rrM1_4kakuStDFE.enabled =
                //kyotuEla.tenmetuOnOff;
                false;

                rrM1_4TextA.enabled = true;
                rrM1_4TextB.enabled = true;
                rrM1_4TextC.enabled = true;

                rrM1_4TextD.enabled = true;
                rrM1_4TextE.enabled = true;
                rrM1_4TextF.enabled = true;

                rrM1_4PointA.enabled = true;
                rrM1_4PointStA.enabled = //kyotuEla.tenmetuOnOff;
                                         false;
                //true;

                rrM1_4PointB.enabled = true;
                rrM1_4PointStB.enabled = //kyotuEla.tenmetuOnOff;
                false;
                //true;
                rrM1_4PointC.enabled = true;
                rrM1_4PointStC.enabled = //kyotuEla.tenmetuOnOff;
                false;
                //true;

                rrM1_4PointD.enabled = true;
                rrM1_4PointStD.enabled = //kyotuEla.tenmetuOnOff;
                                        false;
                rrM1_4PointE.enabled = true;
                rrM1_4PointStE.enabled = //kyotuEla.tenmetuOnOff;
                false;
                rrM1_4PointF.enabled = true;
                rrM1_4PointStF.enabled = //kyotuEla.tenmetuOnOff;
                false;
            } else if (count == 54) {
                reset();
                rrM1_4LineAB.enabled = true;
                rrM1_4LineStAB.enabled = //false;
                kyotuEla.tenmetuOnOff;
                rrM1_4LineStAB2.enabled = //kyotuEla.tenmetuOnOff;
                //false;
                true;

                rrM1_4LineBC.enabled = true;
                rrM1_4LineStBC.enabled = kyotuEla.tenmetuOnOff;
                //false;
                //true;

                rrM1_4LineCA.enabled = true;
                rrM1_4LineStCA.enabled = kyotuEla.tenmetuOnOff;
                //false;
                rrM1_4LineStCA2.enabled = //kyotuEla.tenmetuOnOff;
                //false;
                true;


                rrM1_4LineDE.enabled = true;
                rrM1_4LineStDE.enabled = //kyotuEla.tenmetuOnOff;
                false;
                rrM1_4LineStDE2.enabled = //kyotuEla.tenmetuOnOff;
                //false;
                true;


                rrM1_4LineEF.enabled = true;
                rrM1_4LineStEF.enabled = //kyotuEla.tenmetuOnOff;
                false;
                rrM1_4LineFD.enabled = true;
                rrM1_4LineStFD.enabled = //kyotuEla.tenmetuOnOff;
                false;
                rrM1_4LineStFD2.enabled = //kyotuEla.tenmetuOnOff;
                //false;
                true;


                rrM1_4kakuBAC.enabled = true;
                //false;

                rrM1_4kakuStBAC.enabled =
                //kyotuEla.tenmetuOnOff;
                false;

                rrM1_4kakuABC.enabled = //true;
                false;
                rrM1_4kakuStABC.enabled =
                //kyotuEla.tenmetuOnOff;
                false;

                rrM1_4kakuACB.enabled = //true;
                false;

                rrM1_4kakuStACB.enabled =
                //kyotuEla.tenmetuOnOff;
                false;


                rrM1_4kakuEDF.enabled = true;
                //false;

                rrM1_4kakuStEDF.enabled =
                //kyotuEla.tenmetuOnOff;
                false;

                rrM1_4kakuDEF.enabled = //true;
                false;

                rrM1_4kakuStDEF.enabled =
                //kyotuEla.tenmetuOnOff;
                false;

                rrM1_4kakuDFE.enabled = //true;
                    false;

                rrM1_4kakuStDFE.enabled =
                //kyotuEla.tenmetuOnOff;
                false;

                rrM1_4TextA.enabled = true;
                rrM1_4TextB.enabled = true;
                rrM1_4TextC.enabled = true;

                rrM1_4TextD.enabled = true;
                rrM1_4TextE.enabled = true;
                rrM1_4TextF.enabled = true;

                rrM1_4PointA.enabled = true;
                rrM1_4PointStA.enabled = //kyotuEla.tenmetuOnOff;
                                         false;
                //true;

                rrM1_4PointB.enabled = true;
                rrM1_4PointStB.enabled = //kyotuEla.tenmetuOnOff;
                false;
                //true;
                rrM1_4PointC.enabled = true;
                rrM1_4PointStC.enabled = //kyotuEla.tenmetuOnOff;
                false;
                //true;

                rrM1_4PointD.enabled = true;
                rrM1_4PointStD.enabled = //kyotuEla.tenmetuOnOff;
                                        false;
                rrM1_4PointE.enabled = true;
                rrM1_4PointStE.enabled = //kyotuEla.tenmetuOnOff;
                false;
                rrM1_4PointF.enabled = true;
                rrM1_4PointStF.enabled = //kyotuEla.tenmetuOnOff;
                false;
            } else if (count == 55) {
                reset();
                rrM1_4LineAB.enabled = true;
                rrM1_4LineStAB.enabled = false;
                //kyotuEla.tenmetuOnOff;
                rrM1_4LineStAB2.enabled = //kyotuEla.tenmetuOnOff;
                //false;
                true;

                rrM1_4LineBC.enabled = true;
                rrM1_4LineStBC.enabled = //kyotuEla.tenmetuOnOff;
                false;
                //true;

                rrM1_4LineCA.enabled = true;
                rrM1_4LineStCA.enabled = //kyotuEla.tenmetuOnOff;
                false;
                rrM1_4LineStCA2.enabled = //kyotuEla.tenmetuOnOff;
                //false;
                true;


                rrM1_4LineDE.enabled = true;
                rrM1_4LineStDE.enabled = kyotuEla.tenmetuOnOff;
                //false;
                rrM1_4LineStDE2.enabled = //kyotuEla.tenmetuOnOff;
                //false;
                true;


                rrM1_4LineEF.enabled = true;
                rrM1_4LineStEF.enabled = kyotuEla.tenmetuOnOff;
                //false;
                rrM1_4LineFD.enabled = true;
                rrM1_4LineStFD.enabled = kyotuEla.tenmetuOnOff;
                //false;
                rrM1_4LineStFD2.enabled = //kyotuEla.tenmetuOnOff;
                //false;
                true;


                rrM1_4kakuBAC.enabled = true;
                //false;

                rrM1_4kakuStBAC.enabled =
                //kyotuEla.tenmetuOnOff;
                false;

                rrM1_4kakuABC.enabled = //true;
                false;
                rrM1_4kakuStABC.enabled =
                //kyotuEla.tenmetuOnOff;
                false;

                rrM1_4kakuACB.enabled = //true;
                false;

                rrM1_4kakuStACB.enabled =
                //kyotuEla.tenmetuOnOff;
                false;


                rrM1_4kakuEDF.enabled = true;
                //false;

                rrM1_4kakuStEDF.enabled =
                //kyotuEla.tenmetuOnOff;
                false;

                rrM1_4kakuDEF.enabled = //true;
                false;

                rrM1_4kakuStDEF.enabled =
                //kyotuEla.tenmetuOnOff;
                false;

                rrM1_4kakuDFE.enabled = //true;
                    false;

                rrM1_4kakuStDFE.enabled =
                //kyotuEla.tenmetuOnOff;
                false;

                rrM1_4TextA.enabled = true;
                rrM1_4TextB.enabled = true;
                rrM1_4TextC.enabled = true;

                rrM1_4TextD.enabled = true;
                rrM1_4TextE.enabled = true;
                rrM1_4TextF.enabled = true;

                rrM1_4PointA.enabled = true;
                rrM1_4PointStA.enabled = //kyotuEla.tenmetuOnOff;
                                         false;
                //true;

                rrM1_4PointB.enabled = true;
                rrM1_4PointStB.enabled = //kyotuEla.tenmetuOnOff;
                false;
                //true;
                rrM1_4PointC.enabled = true;
                rrM1_4PointStC.enabled = //kyotuEla.tenmetuOnOff;
                false;
                //true;

                rrM1_4PointD.enabled = true;
                rrM1_4PointStD.enabled = //kyotuEla.tenmetuOnOff;
                                        false;
                rrM1_4PointE.enabled = true;
                rrM1_4PointStE.enabled = //kyotuEla.tenmetuOnOff;
                false;
                rrM1_4PointF.enabled = true;
                rrM1_4PointStF.enabled = //kyotuEla.tenmetuOnOff;
                false;
            } else if (count == 56) {
                reset();
                rrM1_4LineAB.enabled = true;
                rrM1_4LineStAB.enabled = false;
                //kyotuEla.tenmetuOnOff;
                rrM1_4LineStAB2.enabled = //kyotuEla.tenmetuOnOff;
                //false;
                true;

                rrM1_4LineBC.enabled = true;
                rrM1_4LineStBC.enabled = //kyotuEla.tenmetuOnOff;
                false;
                //true;

                rrM1_4LineCA.enabled = true;
                rrM1_4LineStCA.enabled = //kyotuEla.tenmetuOnOff;
                false;
                rrM1_4LineStCA2.enabled = //kyotuEla.tenmetuOnOff;
                //false;
                true;


                rrM1_4LineDE.enabled = true;
                rrM1_4LineStDE.enabled = //kyotuEla.tenmetuOnOff;
                false;
                rrM1_4LineStDE2.enabled = //kyotuEla.tenmetuOnOff;
                //false;
                true;


                rrM1_4LineEF.enabled = true;
                rrM1_4LineStEF.enabled = //kyotuEla.tenmetuOnOff;
                false;
                rrM1_4LineFD.enabled = true;
                rrM1_4LineStFD.enabled = //kyotuEla.tenmetuOnOff;
                false;
                rrM1_4LineStFD2.enabled = //kyotuEla.tenmetuOnOff;
                //false;
                true;


                rrM1_4kakuBAC.enabled = true;
                //false;

                rrM1_4kakuStBAC.enabled =
                //kyotuEla.tenmetuOnOff;
                false;

                rrM1_4kakuABC.enabled = //true;
                false;
                rrM1_4kakuStABC.enabled =
                //kyotuEla.tenmetuOnOff;
                false;

                rrM1_4kakuACB.enabled = //true;
                false;

                rrM1_4kakuStACB.enabled =
                //kyotuEla.tenmetuOnOff;
                false;


                rrM1_4kakuEDF.enabled = true;
                //false;

                rrM1_4kakuStEDF.enabled =
                //kyotuEla.tenmetuOnOff;
                false;

                rrM1_4kakuDEF.enabled = //true;
                false;

                rrM1_4kakuStDEF.enabled =
                //kyotuEla.tenmetuOnOff;
                false;

                rrM1_4kakuDFE.enabled = //true;
                    false;

                rrM1_4kakuStDFE.enabled =
                //kyotuEla.tenmetuOnOff;
                false;

                rrM1_4TextA.enabled = true;
                rrM1_4TextB.enabled = true;
                rrM1_4TextC.enabled = true;

                rrM1_4TextD.enabled = true;
                rrM1_4TextE.enabled = true;
                rrM1_4TextF.enabled = true;

                rrM1_4PointA.enabled = true;
                rrM1_4PointStA.enabled = //kyotuEla.tenmetuOnOff;
                                         false;
                //true;

                rrM1_4PointB.enabled = true;
                rrM1_4PointStB.enabled = //kyotuEla.tenmetuOnOff;
                false;
                //true;
                rrM1_4PointC.enabled = true;
                rrM1_4PointStC.enabled = //kyotuEla.tenmetuOnOff;
                false;
                //true;

                rrM1_4PointD.enabled = true;
                rrM1_4PointStD.enabled = //kyotuEla.tenmetuOnOff;
                                        false;
                rrM1_4PointE.enabled = true;
                rrM1_4PointStE.enabled = //kyotuEla.tenmetuOnOff;
                false;
                rrM1_4PointF.enabled = true;
                rrM1_4PointStF.enabled = //kyotuEla.tenmetuOnOff;
                false;
            } else if (count == 57) {
                reset();
                rrM1_4LineAB.enabled = true;
                rrM1_4LineStAB.enabled = false;
                //kyotuEla.tenmetuOnOff;
                rrM1_4LineStAB2.enabled = //kyotuEla.tenmetuOnOff;
                //false;
                true;

                rrM1_4LineBC.enabled = true;
                rrM1_4LineStBC.enabled = //kyotuEla.tenmetuOnOff;
                false;
                //true;

                rrM1_4LineCA.enabled = true;
                rrM1_4LineStCA.enabled = //kyotuEla.tenmetuOnOff;
                false;
                rrM1_4LineStCA2.enabled = //kyotuEla.tenmetuOnOff;
                //false;
                true;


                rrM1_4LineDE.enabled = true;
                rrM1_4LineStDE.enabled = //kyotuEla.tenmetuOnOff;
                false;
                rrM1_4LineStDE2.enabled = //kyotuEla.tenmetuOnOff;
                //false;
                true;


                rrM1_4LineEF.enabled = true;
                rrM1_4LineStEF.enabled = //kyotuEla.tenmetuOnOff;
                false;
                rrM1_4LineFD.enabled = true;
                rrM1_4LineStFD.enabled = //kyotuEla.tenmetuOnOff;
                false;
                rrM1_4LineStFD2.enabled = //kyotuEla.tenmetuOnOff;
                //false;
                true;


                rrM1_4kakuBAC.enabled = true;
                //false;

                rrM1_4kakuStBAC.enabled =
                //kyotuEla.tenmetuOnOff;
                false;

                rrM1_4kakuABC.enabled = //true;
                false;
                rrM1_4kakuStABC.enabled =
                //kyotuEla.tenmetuOnOff;
                false;

                rrM1_4kakuACB.enabled = //true;
                false;

                rrM1_4kakuStACB.enabled =
                //kyotuEla.tenmetuOnOff;
                false;


                rrM1_4kakuEDF.enabled = true;
                //false;

                rrM1_4kakuStEDF.enabled =
                //kyotuEla.tenmetuOnOff;
                false;

                rrM1_4kakuDEF.enabled = //true;
                false;

                rrM1_4kakuStDEF.enabled =
                //kyotuEla.tenmetuOnOff;
                false;

                rrM1_4kakuDFE.enabled = //true;
                    false;

                rrM1_4kakuStDFE.enabled =
                //kyotuEla.tenmetuOnOff;
                false;

                rrM1_4TextA.enabled = true;
                rrM1_4TextB.enabled = true;
                rrM1_4TextC.enabled = true;

                rrM1_4TextD.enabled = true;
                rrM1_4TextE.enabled = true;
                rrM1_4TextF.enabled = true;

                rrM1_4PointA.enabled = true;
                rrM1_4PointStA.enabled = //kyotuEla.tenmetuOnOff;
                                         false;
                //true;

                rrM1_4PointB.enabled = true;
                rrM1_4PointStB.enabled = //kyotuEla.tenmetuOnOff;
                false;
                //true;
                rrM1_4PointC.enabled = true;
                rrM1_4PointStC.enabled = //kyotuEla.tenmetuOnOff;
                false;
                //true;

                rrM1_4PointD.enabled = true;
                rrM1_4PointStD.enabled = //kyotuEla.tenmetuOnOff;
                                        false;
                rrM1_4PointE.enabled = true;
                rrM1_4PointStE.enabled = //kyotuEla.tenmetuOnOff;
                false;
                rrM1_4PointF.enabled = true;
                rrM1_4PointStF.enabled = //kyotuEla.tenmetuOnOff;
                false;
            } else if (count == 58) {
                reset();
                rrM1_4LineAB.enabled = true;
                rrM1_4LineStAB.enabled = false;
                //kyotuEla.tenmetuOnOff;
                rrM1_4LineStAB2.enabled = //kyotuEla.tenmetuOnOff;
                //false;
                true;

                rrM1_4LineBC.enabled = true;
                rrM1_4LineStBC.enabled = //kyotuEla.tenmetuOnOff;
                false;
                //true;

                rrM1_4LineCA.enabled = true;
                rrM1_4LineStCA.enabled = //kyotuEla.tenmetuOnOff;
                false;
                rrM1_4LineStCA2.enabled = //kyotuEla.tenmetuOnOff;
                //false;
                true;


                rrM1_4LineDE.enabled = true;
                rrM1_4LineStDE.enabled = //kyotuEla.tenmetuOnOff;
                false;
                rrM1_4LineStDE2.enabled = //kyotuEla.tenmetuOnOff;
                //false;
                true;


                rrM1_4LineEF.enabled = true;
                rrM1_4LineStEF.enabled = //kyotuEla.tenmetuOnOff;
                false;
                rrM1_4LineFD.enabled = true;
                rrM1_4LineStFD.enabled = //kyotuEla.tenmetuOnOff;
                false;
                rrM1_4LineStFD2.enabled = //kyotuEla.tenmetuOnOff;
                //false;
                true;


                rrM1_4kakuBAC.enabled = true;
                //false;

                rrM1_4kakuStBAC.enabled =
                //kyotuEla.tenmetuOnOff;
                false;

                rrM1_4kakuABC.enabled = true;
                //false;
                rrM1_4kakuStABC.enabled =
                kyotuEla.tenmetuOnOff;
                //false;

                rrM1_4kakuACB.enabled = true;
                //false;

                rrM1_4kakuStACB.enabled =
                kyotuEla.tenmetuOnOff;
                //false;


                rrM1_4kakuEDF.enabled = true;
                //false;

                rrM1_4kakuStEDF.enabled =
                //kyotuEla.tenmetuOnOff;
                false;

                rrM1_4kakuDEF.enabled = true;
                //false;

                rrM1_4kakuStDEF.enabled =
                kyotuEla.tenmetuOnOff;
                //false;

                rrM1_4kakuDFE.enabled = true;
                    //false;

                rrM1_4kakuStDFE.enabled =
                kyotuEla.tenmetuOnOff;
                //false;

                rrM1_4TextA.enabled = true;
                rrM1_4TextB.enabled = true;
                rrM1_4TextC.enabled = true;

                rrM1_4TextD.enabled = true;
                rrM1_4TextE.enabled = true;
                rrM1_4TextF.enabled = true;

                rrM1_4PointA.enabled = true;
                rrM1_4PointStA.enabled = //kyotuEla.tenmetuOnOff;
                                         false;
                //true;

                rrM1_4PointB.enabled = true;
                rrM1_4PointStB.enabled = //kyotuEla.tenmetuOnOff;
                false;
                //true;
                rrM1_4PointC.enabled = true;
                rrM1_4PointStC.enabled = //kyotuEla.tenmetuOnOff;
                false;
                //true;

                rrM1_4PointD.enabled = true;
                rrM1_4PointStD.enabled = //kyotuEla.tenmetuOnOff;
                                        false;
                rrM1_4PointE.enabled = true;
                rrM1_4PointStE.enabled = //kyotuEla.tenmetuOnOff;
                rrM1_4PointF.enabled = true;
                //false;
                rrM1_4PointStF.enabled = //kyotuEla.tenmetuOnOff;
                false;
            } else if (count == 59) {
                reset();
                rrM1_4LineAB.enabled = true;
                rrM1_4LineStAB.enabled = false;
                //kyotuEla.tenmetuOnOff;
                rrM1_4LineStAB2.enabled = //kyotuEla.tenmetuOnOff;
                //false;
                true;

                rrM1_4LineBC.enabled = true;
                rrM1_4LineStBC.enabled = //kyotuEla.tenmetuOnOff;
                false;
                //true;

                rrM1_4LineCA.enabled = true;
                rrM1_4LineStCA.enabled = //kyotuEla.tenmetuOnOff;
                false;
                rrM1_4LineStCA2.enabled = //kyotuEla.tenmetuOnOff;
                //false;
                true;


                rrM1_4LineDE.enabled = true;
                rrM1_4LineStDE.enabled = //kyotuEla.tenmetuOnOff;
                false;
                rrM1_4LineStDE2.enabled = //kyotuEla.tenmetuOnOff;
                //false;
                true;


                rrM1_4LineEF.enabled = true;
                rrM1_4LineStEF.enabled = //kyotuEla.tenmetuOnOff;
                false;
                rrM1_4LineFD.enabled = true;
                rrM1_4LineStFD.enabled = //kyotuEla.tenmetuOnOff;
                false;
                rrM1_4LineStFD2.enabled = //kyotuEla.tenmetuOnOff;
                //false;
                true;


                rrM1_4kakuBAC.enabled = true;
                //false;

                rrM1_4kakuStBAC.enabled =
                //kyotuEla.tenmetuOnOff;
                false;

                rrM1_4kakuABC.enabled = true;
                //false;
                rrM1_4kakuStABC.enabled =
                //kyotuEla.tenmetuOnOff;
                false;

                rrM1_4kakuACB.enabled = true;
                //false;

                rrM1_4kakuStACB.enabled =
                //kyotuEla.tenmetuOnOff;
                false;


                rrM1_4kakuEDF.enabled = true;
                //false;

                rrM1_4kakuStEDF.enabled =
                //kyotuEla.tenmetuOnOff;
                false;

                rrM1_4kakuDEF.enabled = true;
                //false;

                rrM1_4kakuStDEF.enabled =
                //kyotuEla.tenmetuOnOff;
                false;

                rrM1_4kakuDFE.enabled = true;
                //false;

                rrM1_4kakuStDFE.enabled =
                //kyotuEla.tenmetuOnOff;
                false;

                rrM1_4TextA.enabled = true;
                rrM1_4TextB.enabled = true;
                rrM1_4TextC.enabled = true;

                rrM1_4TextD.enabled = true;
                rrM1_4TextE.enabled = true;
                rrM1_4TextF.enabled = true;

                rrM1_4PointA.enabled = true;
                rrM1_4PointStA.enabled = //kyotuEla.tenmetuOnOff;
                                         false;
                //true;

                rrM1_4PointB.enabled = true;
                rrM1_4PointStB.enabled = //kyotuEla.tenmetuOnOff;
                false;
                //true;
                rrM1_4PointC.enabled = true;
                rrM1_4PointStC.enabled = //kyotuEla.tenmetuOnOff;
                false;
                //true;

                rrM1_4PointD.enabled = true;
                rrM1_4PointStD.enabled = //kyotuEla.tenmetuOnOff;
                                        false;
                rrM1_4PointE.enabled = true;
                rrM1_4PointStE.enabled = //kyotuEla.tenmetuOnOff;
                false;
                rrM1_4PointF.enabled = true;
                rrM1_4PointStF.enabled = //kyotuEla.tenmetuOnOff;
                false;
            } else if (count == 60) {
                reset();
                rrM1_4LineAB.enabled = true;
                rrM1_4LineStAB.enabled = false;
                //kyotuEla.tenmetuOnOff;
                rrM1_4LineStAB2.enabled = //kyotuEla.tenmetuOnOff;
                //false;
                true;

                rrM1_4LineBC.enabled = true;
                rrM1_4LineStBC.enabled = //kyotuEla.tenmetuOnOff;
                false;
                //true;

                rrM1_4LineCA.enabled = true;
                rrM1_4LineStCA.enabled = //kyotuEla.tenmetuOnOff;
                false;
                rrM1_4LineStCA2.enabled = //kyotuEla.tenmetuOnOff;
                //false;
                true;


                rrM1_4LineDE.enabled = true;
                rrM1_4LineStDE.enabled = //kyotuEla.tenmetuOnOff;
                false;
                rrM1_4LineStDE2.enabled = //kyotuEla.tenmetuOnOff;
                //false;
                true;


                rrM1_4LineEF.enabled = true;
                rrM1_4LineStEF.enabled = //kyotuEla.tenmetuOnOff;
                false;
                rrM1_4LineFD.enabled = true;
                rrM1_4LineStFD.enabled = //kyotuEla.tenmetuOnOff;
                false;
                rrM1_4LineStFD2.enabled = //kyotuEla.tenmetuOnOff;
                //false;
                true;


                rrM1_4kakuBAC.enabled = true;
                //false;

                rrM1_4kakuStBAC.enabled =
                //kyotuEla.tenmetuOnOff;
                false;

                rrM1_4kakuABC.enabled = true;
                //false;
                rrM1_4kakuStABC.enabled =
                //kyotuEla.tenmetuOnOff;
                false;

                rrM1_4kakuACB.enabled = true;
                //false;

                rrM1_4kakuStACB.enabled =
                //kyotuEla.tenmetuOnOff;
                false;


                rrM1_4kakuEDF.enabled = true;
                //false;

                rrM1_4kakuStEDF.enabled =
                //kyotuEla.tenmetuOnOff;
                false;

                rrM1_4kakuDEF.enabled = true;
                //false;

                rrM1_4kakuStDEF.enabled =
                //kyotuEla.tenmetuOnOff;
                false;

                rrM1_4kakuDFE.enabled = true;
                //false;

                rrM1_4kakuStDFE.enabled =
                //kyotuEla.tenmetuOnOff;
                false;

                rrM1_4TextA.enabled = true;
                rrM1_4TextB.enabled = true;
                rrM1_4TextC.enabled = true;

                rrM1_4TextD.enabled = true;
                rrM1_4TextE.enabled = true;
                rrM1_4TextF.enabled = true;

                rrM1_4PointA.enabled = true;
                rrM1_4PointStA.enabled = //kyotuEla.tenmetuOnOff;
                                         false;
                //true;

                rrM1_4PointB.enabled = true;
                rrM1_4PointStB.enabled = //kyotuEla.tenmetuOnOff;
                false;
                //true;
                rrM1_4PointC.enabled = true;
                rrM1_4PointStC.enabled = //kyotuEla.tenmetuOnOff;
                false;
                //true;

                rrM1_4PointD.enabled = true;
                rrM1_4PointStD.enabled = //kyotuEla.tenmetuOnOff;
                                        false;
                rrM1_4PointE.enabled = true;
                rrM1_4PointStE.enabled = //kyotuEla.tenmetuOnOff;
                false;
                rrM1_4PointF.enabled = true;
                rrM1_4PointStF.enabled = //kyotuEla.tenmetuOnOff;
                false;
            } else if (count == 61) {
                reset();
                rrM1_4LineAB.enabled = true;
                rrM1_4LineStAB.enabled = false;
                //kyotuEla.tenmetuOnOff;
                rrM1_4LineStAB2.enabled = //kyotuEla.tenmetuOnOff;
                //false;
                true;

                rrM1_4LineBC.enabled = true;
                rrM1_4LineStBC.enabled = //kyotuEla.tenmetuOnOff;
                false;
                //true;

                rrM1_4LineCA.enabled = true;
                rrM1_4LineStCA.enabled = //kyotuEla.tenmetuOnOff;
                false;
                rrM1_4LineStCA2.enabled = //kyotuEla.tenmetuOnOff;
                //false;
                true;


                rrM1_4LineDE.enabled = true;
                rrM1_4LineStDE.enabled = //kyotuEla.tenmetuOnOff;
                false;
                rrM1_4LineStDE2.enabled = //kyotuEla.tenmetuOnOff;
                //false;
                true;


                rrM1_4LineEF.enabled = true;
                rrM1_4LineStEF.enabled = //kyotuEla.tenmetuOnOff;
                false;
                rrM1_4LineFD.enabled = true;
                rrM1_4LineStFD.enabled = //kyotuEla.tenmetuOnOff;
                false;
                rrM1_4LineStFD2.enabled = //kyotuEla.tenmetuOnOff;
                //false;
                true;


                rrM1_4kakuBAC.enabled = true;
                //false;

                rrM1_4kakuStBAC.enabled =
                //kyotuEla.tenmetuOnOff;
                false;

                rrM1_4kakuABC.enabled = true;
                //false;
                rrM1_4kakuStABC.enabled =
                kyotuEla.tenmetuOnOff;
                //false;

                rrM1_4kakuACB.enabled = true;
                //false;

                rrM1_4kakuStACB.enabled =
                //kyotuEla.tenmetuOnOff;
                false;


                rrM1_4kakuEDF.enabled = true;
                //false;

                rrM1_4kakuStEDF.enabled =
                //kyotuEla.tenmetuOnOff;
                false;

                rrM1_4kakuDEF.enabled = true;
                //false;

                rrM1_4kakuStDEF.enabled =
                //kyotuEla.tenmetuOnOff;
                false;

                rrM1_4kakuDFE.enabled = true;
                //false;

                rrM1_4kakuStDFE.enabled =
                //kyotuEla.tenmetuOnOff;
                false;

                rrM1_4TextA.enabled = true;
                rrM1_4TextB.enabled = true;
                rrM1_4TextC.enabled = true;

                rrM1_4TextD.enabled = true;
                rrM1_4TextE.enabled = true;
                rrM1_4TextF.enabled = true;

                rrM1_4PointA.enabled = true;
                rrM1_4PointStA.enabled = //kyotuEla.tenmetuOnOff;
                                         false;
                //true;

                rrM1_4PointB.enabled = true;
                rrM1_4PointStB.enabled = //kyotuEla.tenmetuOnOff;
                false;
                //true;
                rrM1_4PointC.enabled = true;
                rrM1_4PointStC.enabled = //kyotuEla.tenmetuOnOff;
                false;
                //true;

                rrM1_4PointD.enabled = true;
                rrM1_4PointStD.enabled = //kyotuEla.tenmetuOnOff;
                                        false;
                rrM1_4PointE.enabled = true;
                rrM1_4PointStE.enabled = //kyotuEla.tenmetuOnOff;
                false;
                rrM1_4PointF.enabled = true;
                rrM1_4PointStF.enabled = //kyotuEla.tenmetuOnOff;
                false;
            } else if (count == 62) {
                reset();
                rrM1_4LineAB.enabled = true;
                rrM1_4LineStAB.enabled = false;
                //kyotuEla.tenmetuOnOff;
                rrM1_4LineStAB2.enabled = //kyotuEla.tenmetuOnOff;
                //false;
                true;

                rrM1_4LineBC.enabled = true;
                rrM1_4LineStBC.enabled = //kyotuEla.tenmetuOnOff;
                false;
                //true;

                rrM1_4LineCA.enabled = true;
                rrM1_4LineStCA.enabled = //kyotuEla.tenmetuOnOff;
                false;
                rrM1_4LineStCA2.enabled = //kyotuEla.tenmetuOnOff;
                //false;
                true;


                rrM1_4LineDE.enabled = true;
                rrM1_4LineStDE.enabled = //kyotuEla.tenmetuOnOff;
                false;
                rrM1_4LineStDE2.enabled = //kyotuEla.tenmetuOnOff;
                //false;
                true;


                rrM1_4LineEF.enabled = true;
                rrM1_4LineStEF.enabled = //kyotuEla.tenmetuOnOff;
                false;
                rrM1_4LineFD.enabled = true;
                rrM1_4LineStFD.enabled = //kyotuEla.tenmetuOnOff;
                false;
                rrM1_4LineStFD2.enabled = //kyotuEla.tenmetuOnOff;
                //false;
                true;


                rrM1_4kakuBAC.enabled = true;
                //false;

                rrM1_4kakuStBAC.enabled =
                //kyotuEla.tenmetuOnOff;
                false;

                rrM1_4kakuABC.enabled = true;
                //false;
                rrM1_4kakuStABC.enabled =
                //kyotuEla.tenmetuOnOff;
                false;

                rrM1_4kakuACB.enabled = true;
                //false;

                rrM1_4kakuStACB.enabled =
                //kyotuEla.tenmetuOnOff;
                false;


                rrM1_4kakuEDF.enabled = true;
                //false;

                rrM1_4kakuStEDF.enabled =
                //kyotuEla.tenmetuOnOff;
                false;

                rrM1_4kakuDEF.enabled = true;
                //false;

                rrM1_4kakuStDEF.enabled =
                kyotuEla.tenmetuOnOff;
                //false;

                rrM1_4kakuDFE.enabled = true;
                //false;

                rrM1_4kakuStDFE.enabled =
                //kyotuEla.tenmetuOnOff;
                false;

                rrM1_4TextA.enabled = true;
                rrM1_4TextB.enabled = true;
                rrM1_4TextC.enabled = true;

                rrM1_4TextD.enabled = true;
                rrM1_4TextE.enabled = true;
                rrM1_4TextF.enabled = true;

                rrM1_4PointA.enabled = true;
                rrM1_4PointStA.enabled = //kyotuEla.tenmetuOnOff;
                                         false;
                //true;

                rrM1_4PointB.enabled = true;
                rrM1_4PointStB.enabled = //kyotuEla.tenmetuOnOff;
                false;
                //true;
                rrM1_4PointC.enabled = true;
                rrM1_4PointStC.enabled = //kyotuEla.tenmetuOnOff;
                false;
                //true;

                rrM1_4PointD.enabled = true;
                rrM1_4PointStD.enabled = //kyotuEla.tenmetuOnOff;
                                        false;
                rrM1_4PointE.enabled = true;
                rrM1_4PointStE.enabled = //kyotuEla.tenmetuOnOff;
                false;
                rrM1_4PointF.enabled = true;
                rrM1_4PointStF.enabled = //kyotuEla.tenmetuOnOff;
                false;
            } else if (count == 63) {
                reset();
                rrM1_4LineAB.enabled = true;
                rrM1_4LineStAB.enabled = false;
                //kyotuEla.tenmetuOnOff;
                rrM1_4LineStAB2.enabled = //kyotuEla.tenmetuOnOff;
                //false;
                true;

                rrM1_4LineBC.enabled = true;
                rrM1_4LineStBC.enabled = //kyotuEla.tenmetuOnOff;
                false;
                //true;

                rrM1_4LineCA.enabled = true;
                rrM1_4LineStCA.enabled = //kyotuEla.tenmetuOnOff;
                false;
                rrM1_4LineStCA2.enabled = //kyotuEla.tenmetuOnOff;
                //false;
                true;


                rrM1_4LineDE.enabled = true;
                rrM1_4LineStDE.enabled = //kyotuEla.tenmetuOnOff;
                false;
                rrM1_4LineStDE2.enabled = //kyotuEla.tenmetuOnOff;
                //false;
                true;


                rrM1_4LineEF.enabled = true;
                rrM1_4LineStEF.enabled = //kyotuEla.tenmetuOnOff;
                false;
                rrM1_4LineFD.enabled = true;
                rrM1_4LineStFD.enabled = //kyotuEla.tenmetuOnOff;
                false;
                rrM1_4LineStFD2.enabled = //kyotuEla.tenmetuOnOff;
                //false;
                true;


                rrM1_4kakuBAC.enabled = true;
                //false;

                rrM1_4kakuStBAC.enabled =
                //kyotuEla.tenmetuOnOff;
                false;

                rrM1_4kakuABC.enabled = true;
                //false;
                rrM1_4kakuStABC.enabled =
                //kyotuEla.tenmetuOnOff;
                false;

                rrM1_4kakuACB.enabled = true;
                //false;

                rrM1_4kakuStACB.enabled =
                kyotuEla.tenmetuOnOff;
                //false;


                rrM1_4kakuEDF.enabled = true;
                //false;

                rrM1_4kakuStEDF.enabled =
                //kyotuEla.tenmetuOnOff;
                false;

                rrM1_4kakuDEF.enabled = true;
                //false;

                rrM1_4kakuStDEF.enabled =
                //kyotuEla.tenmetuOnOff;
                false;

                rrM1_4kakuDFE.enabled = true;
                //false;

                rrM1_4kakuStDFE.enabled =
                //kyotuEla.tenmetuOnOff;
                false;

                rrM1_4TextA.enabled = true;
                rrM1_4TextB.enabled = true;
                rrM1_4TextC.enabled = true;

                rrM1_4TextD.enabled = true;
                rrM1_4TextE.enabled = true;
                rrM1_4TextF.enabled = true;

                rrM1_4PointA.enabled = true;
                rrM1_4PointStA.enabled = //kyotuEla.tenmetuOnOff;
                                         false;
                //true;

                rrM1_4PointB.enabled = true;
                rrM1_4PointStB.enabled = //kyotuEla.tenmetuOnOff;
                false;
                //true;
                rrM1_4PointC.enabled = true;
                rrM1_4PointStC.enabled = //kyotuEla.tenmetuOnOff;
                false;
                //true;

                rrM1_4PointD.enabled = true;
                rrM1_4PointStD.enabled = //kyotuEla.tenmetuOnOff;
                                        false;
                rrM1_4PointE.enabled = true;
                rrM1_4PointStE.enabled = //kyotuEla.tenmetuOnOff;
                false;
                rrM1_4PointF.enabled = true;
                rrM1_4PointStF.enabled = //kyotuEla.tenmetuOnOff;
                false;
            } else if (count == 64) {
                reset();
                rrM1_4LineAB.enabled = true;
                rrM1_4LineStAB.enabled = false;
                //kyotuEla.tenmetuOnOff;
                rrM1_4LineStAB2.enabled = //kyotuEla.tenmetuOnOff;
                //false;
                true;

                rrM1_4LineBC.enabled = true;
                rrM1_4LineStBC.enabled = //kyotuEla.tenmetuOnOff;
                false;
                //true;

                rrM1_4LineCA.enabled = true;
                rrM1_4LineStCA.enabled = //kyotuEla.tenmetuOnOff;
                false;
                rrM1_4LineStCA2.enabled = //kyotuEla.tenmetuOnOff;
                //false;
                true;


                rrM1_4LineDE.enabled = true;
                rrM1_4LineStDE.enabled = //kyotuEla.tenmetuOnOff;
                false;
                rrM1_4LineStDE2.enabled = //kyotuEla.tenmetuOnOff;
                //false;
                true;


                rrM1_4LineEF.enabled = true;
                rrM1_4LineStEF.enabled = //kyotuEla.tenmetuOnOff;
                false;
                rrM1_4LineFD.enabled = true;
                rrM1_4LineStFD.enabled = //kyotuEla.tenmetuOnOff;
                false;
                rrM1_4LineStFD2.enabled = //kyotuEla.tenmetuOnOff;
                //false;
                true;


                rrM1_4kakuBAC.enabled = true;
                //false;

                rrM1_4kakuStBAC.enabled =
                //kyotuEla.tenmetuOnOff;
                false;

                rrM1_4kakuABC.enabled = true;
                //false;
                rrM1_4kakuStABC.enabled =
                //kyotuEla.tenmetuOnOff;
                false;

                rrM1_4kakuACB.enabled = true;
                //false;

                rrM1_4kakuStACB.enabled =
                //kyotuEla.tenmetuOnOff;
                false;


                rrM1_4kakuEDF.enabled = true;
                //false;

                rrM1_4kakuStEDF.enabled =
                //kyotuEla.tenmetuOnOff;
                false;

                rrM1_4kakuDEF.enabled = true;
                //false;

                rrM1_4kakuStDEF.enabled =
                //kyotuEla.tenmetuOnOff;
                false;

                rrM1_4kakuDFE.enabled = true;
                //false;

                rrM1_4kakuStDFE.enabled =
                kyotuEla.tenmetuOnOff;
                //false;

                rrM1_4TextA.enabled = true;
                rrM1_4TextB.enabled = true;
                rrM1_4TextC.enabled = true;

                rrM1_4TextD.enabled = true;
                rrM1_4TextE.enabled = true;
                rrM1_4TextF.enabled = true;

                rrM1_4PointA.enabled = true;
                rrM1_4PointStA.enabled = //kyotuEla.tenmetuOnOff;
                                         false;
                //true;

                rrM1_4PointB.enabled = true;
                rrM1_4PointStB.enabled = //kyotuEla.tenmetuOnOff;
                false;
                //true;
                rrM1_4PointC.enabled = true;
                rrM1_4PointStC.enabled = //kyotuEla.tenmetuOnOff;
                false;
                //true;

                rrM1_4PointD.enabled = true;
                rrM1_4PointStD.enabled = //kyotuEla.tenmetuOnOff;
                                        false;
                rrM1_4PointE.enabled = true;
                rrM1_4PointStE.enabled = //kyotuEla.tenmetuOnOff;
                false;
                rrM1_4PointF.enabled = true;
                rrM1_4PointStF.enabled = //kyotuEla.tenmetuOnOff;
                false;
            } else if (count == 65) {
                reset();
                rrM1_4LineAB.enabled = true;
                rrM1_4LineStAB.enabled = false;
                //kyotuEla.tenmetuOnOff;
                rrM1_4LineStAB2.enabled = //kyotuEla.tenmetuOnOff;
                //false;
                true;

                rrM1_4LineBC.enabled = true;
                rrM1_4LineStBC.enabled = //kyotuEla.tenmetuOnOff;
                false;
                //true;

                rrM1_4LineCA.enabled = true;
                rrM1_4LineStCA.enabled = //kyotuEla.tenmetuOnOff;
                false;
                rrM1_4LineStCA2.enabled = //kyotuEla.tenmetuOnOff;
                //false;
                true;


                rrM1_4LineDE.enabled = true;
                rrM1_4LineStDE.enabled = //kyotuEla.tenmetuOnOff;
                false;
                rrM1_4LineStDE2.enabled = //kyotuEla.tenmetuOnOff;
                //false;
                true;


                rrM1_4LineEF.enabled = true;
                rrM1_4LineStEF.enabled = //kyotuEla.tenmetuOnOff;
                false;
                rrM1_4LineFD.enabled = true;
                rrM1_4LineStFD.enabled = //kyotuEla.tenmetuOnOff;
                false;
                rrM1_4LineStFD2.enabled = //kyotuEla.tenmetuOnOff;
                //false;
                true;


                rrM1_4kakuBAC.enabled = true;
                //false;

                rrM1_4kakuStBAC.enabled =
                //kyotuEla.tenmetuOnOff;
                false;

                rrM1_4kakuABC.enabled = true;
                //false;
                rrM1_4kakuStABC.enabled =
                //kyotuEla.tenmetuOnOff;
                false;

                rrM1_4kakuACB.enabled = true;
                //false;

                rrM1_4kakuStACB.enabled =
                //kyotuEla.tenmetuOnOff;
                false;


                rrM1_4kakuEDF.enabled = true;
                //false;

                rrM1_4kakuStEDF.enabled =
                //kyotuEla.tenmetuOnOff;
                false;

                rrM1_4kakuDEF.enabled = true;
                //false;

                rrM1_4kakuStDEF.enabled =
                //kyotuEla.tenmetuOnOff;
                false;

                rrM1_4kakuDFE.enabled = true;
                //false;

                rrM1_4kakuStDFE.enabled =
                //kyotuEla.tenmetuOnOff;
                false;

                rrM1_4TextA.enabled = true;
                rrM1_4TextB.enabled = true;
                rrM1_4TextC.enabled = true;

                rrM1_4TextD.enabled = true;
                rrM1_4TextE.enabled = true;
                rrM1_4TextF.enabled = true;

                rrM1_4PointA.enabled = true;
                rrM1_4PointStA.enabled = //kyotuEla.tenmetuOnOff;
                                         false;
                //true;

                rrM1_4PointB.enabled = true;
                rrM1_4PointStB.enabled = //kyotuEla.tenmetuOnOff;
                false;
                //true;
                rrM1_4PointC.enabled = true;
                rrM1_4PointStC.enabled = //kyotuEla.tenmetuOnOff;
                false;
                //true;

                rrM1_4PointD.enabled = true;
                rrM1_4PointStD.enabled = //kyotuEla.tenmetuOnOff;
                                        false;
                rrM1_4PointE.enabled = true;
                rrM1_4PointStE.enabled = //kyotuEla.tenmetuOnOff;
                false;
                rrM1_4PointF.enabled = true;
                rrM1_4PointStF.enabled = //kyotuEla.tenmetuOnOff;
                false;
            } else if (count == 66) {
                reset();
                rrM1_4LineAB.enabled = true;
                rrM1_4LineStAB.enabled = false;
                //kyotuEla.tenmetuOnOff;
                rrM1_4LineStAB2.enabled = //kyotuEla.tenmetuOnOff;
                //false;
                true;

                rrM1_4LineBC.enabled = true;
                rrM1_4LineStBC.enabled = //kyotuEla.tenmetuOnOff;
                false;
                //true;

                rrM1_4LineCA.enabled = true;
                rrM1_4LineStCA.enabled = //kyotuEla.tenmetuOnOff;
                false;
                rrM1_4LineStCA2.enabled = //kyotuEla.tenmetuOnOff;
                //false;
                true;


                rrM1_4LineDE.enabled = true;
                rrM1_4LineStDE.enabled = //kyotuEla.tenmetuOnOff;
                false;
                rrM1_4LineStDE2.enabled = //kyotuEla.tenmetuOnOff;
                //false;
                true;


                rrM1_4LineEF.enabled = true;
                rrM1_4LineStEF.enabled = //kyotuEla.tenmetuOnOff;
                false;
                rrM1_4LineFD.enabled = true;
                rrM1_4LineStFD.enabled = //kyotuEla.tenmetuOnOff;
                false;
                rrM1_4LineStFD2.enabled = //kyotuEla.tenmetuOnOff;
                //false;
                true;


                rrM1_4kakuBAC.enabled = true;
                //false;

                rrM1_4kakuStBAC.enabled =
                //kyotuEla.tenmetuOnOff;
                false;

                rrM1_4kakuABC.enabled = true;
                //false;
                rrM1_4kakuStABC.enabled =
                //kyotuEla.tenmetuOnOff;
                false;

                rrM1_4kakuACB.enabled = true;
                //false;

                rrM1_4kakuStACB.enabled =
                //kyotuEla.tenmetuOnOff;
                false;


                rrM1_4kakuEDF.enabled = true;
                //false;

                rrM1_4kakuStEDF.enabled =
                //kyotuEla.tenmetuOnOff;
                false;

                rrM1_4kakuDEF.enabled = true;
                //false;

                rrM1_4kakuStDEF.enabled =
                //kyotuEla.tenmetuOnOff;
                false;

                rrM1_4kakuDFE.enabled = true;
                //false;

                rrM1_4kakuStDFE.enabled =
                //kyotuEla.tenmetuOnOff;
                false;

                rrM1_4TextA.enabled = true;
                rrM1_4TextB.enabled = true;
                rrM1_4TextC.enabled = true;

                rrM1_4TextD.enabled = true;
                rrM1_4TextE.enabled = true;
                rrM1_4TextF.enabled = true;

                rrM1_4PointA.enabled = true;
                rrM1_4PointStA.enabled = //kyotuEla.tenmetuOnOff;
                                         false;
                //true;

                rrM1_4PointB.enabled = true;
                rrM1_4PointStB.enabled = //kyotuEla.tenmetuOnOff;
                false;
                //true;
                rrM1_4PointC.enabled = true;
                rrM1_4PointStC.enabled = //kyotuEla.tenmetuOnOff;
                false;
                //true;

                rrM1_4PointD.enabled = true;
                rrM1_4PointStD.enabled = //kyotuEla.tenmetuOnOff;
                                        false;
                rrM1_4PointE.enabled = true;
                rrM1_4PointStE.enabled = //kyotuEla.tenmetuOnOff;
                false;
                rrM1_4PointF.enabled = true;
                rrM1_4PointStF.enabled = //kyotuEla.tenmetuOnOff;
                false;
            } else if (count == 67) {
                reset();
                rrM1_4LineAB.enabled = true;
                rrM1_4LineStAB.enabled = //false;
                kyotuEla.tenmetuOnOff;
                rrM1_4LineStAB2.enabled = //kyotuEla.tenmetuOnOff;
                //false;
                true;

                rrM1_4LineBC.enabled = true;
                rrM1_4LineStBC.enabled = kyotuEla.tenmetuOnOff;
                //false;
                //true;

                rrM1_4LineCA.enabled = true;
                rrM1_4LineStCA.enabled = kyotuEla.tenmetuOnOff;
                //false;
                rrM1_4LineStCA2.enabled = //kyotuEla.tenmetuOnOff;
                //false;
                true;


                rrM1_4LineDE.enabled = true;
                rrM1_4LineStDE.enabled = kyotuEla.tenmetuOnOff;
                //false;
                rrM1_4LineStDE2.enabled = //kyotuEla.tenmetuOnOff;
                //false;
                true;


                rrM1_4LineEF.enabled = true;
                rrM1_4LineStEF.enabled = kyotuEla.tenmetuOnOff;
                //false;
                rrM1_4LineFD.enabled = true;
                rrM1_4LineStFD.enabled = kyotuEla.tenmetuOnOff;
                //false;
                rrM1_4LineStFD2.enabled = //kyotuEla.tenmetuOnOff;
                //false;
                true;


                rrM1_4kakuBAC.enabled = true;
                //false;

                rrM1_4kakuStBAC.enabled =
                //kyotuEla.tenmetuOnOff;
                false;

                rrM1_4kakuABC.enabled = true;
                //false;
                rrM1_4kakuStABC.enabled =
                //kyotuEla.tenmetuOnOff;
                false;

                rrM1_4kakuACB.enabled = true;
                //false;

                rrM1_4kakuStACB.enabled =
                //kyotuEla.tenmetuOnOff;
                false;


                rrM1_4kakuEDF.enabled = true;
                //false;

                rrM1_4kakuStEDF.enabled =
                //kyotuEla.tenmetuOnOff;
                false;

                rrM1_4kakuDEF.enabled = true;
                //false;

                rrM1_4kakuStDEF.enabled =
                //kyotuEla.tenmetuOnOff;
                false;

                rrM1_4kakuDFE.enabled = true;
                //false;

                rrM1_4kakuStDFE.enabled =
                //kyotuEla.tenmetuOnOff;
                false;

                rrM1_4TextA.enabled = true;
                rrM1_4TextB.enabled = true;
                rrM1_4TextC.enabled = true;

                rrM1_4TextD.enabled = true;
                rrM1_4TextE.enabled = true;
                rrM1_4TextF.enabled = true;

                rrM1_4PointA.enabled = true;
                rrM1_4PointStA.enabled = //kyotuEla.tenmetuOnOff;
                                         false;
                //true;

                rrM1_4PointB.enabled = true;
                rrM1_4PointStB.enabled = //kyotuEla.tenmetuOnOff;
                false;
                //true;
                rrM1_4PointC.enabled = true;
                rrM1_4PointStC.enabled = //kyotuEla.tenmetuOnOff;
                false;
                //true;

                rrM1_4PointD.enabled = true;
                rrM1_4PointStD.enabled = //kyotuEla.tenmetuOnOff;
                                        false;
                rrM1_4PointE.enabled = true;
                rrM1_4PointStE.enabled = //kyotuEla.tenmetuOnOff;
                false;
                rrM1_4PointF.enabled = true;
                rrM1_4PointStF.enabled = //kyotuEla.tenmetuOnOff;
                false;
            } else if (count == 68) {
                reset();
                rrM1_4LineAB.enabled = true;
                rrM1_4LineStAB.enabled = //false;
                kyotuEla.tenmetuOnOff;
                rrM1_4LineStAB2.enabled = //kyotuEla.tenmetuOnOff;
                //false;
                true;

                rrM1_4LineBC.enabled = true;
                rrM1_4LineStBC.enabled = //kyotuEla.tenmetuOnOff;
                false;
                //true;

                rrM1_4LineCA.enabled = true;
                rrM1_4LineStCA.enabled = kyotuEla.tenmetuOnOff;
                //false;
                rrM1_4LineStCA2.enabled = //kyotuEla.tenmetuOnOff;
                //false;
                true;


                rrM1_4LineDE.enabled = true;
                rrM1_4LineStDE.enabled = kyotuEla.tenmetuOnOff;
                //false;
                rrM1_4LineStDE2.enabled = //kyotuEla.tenmetuOnOff;
                //false;
                true;


                rrM1_4LineEF.enabled = true;
                rrM1_4LineStEF.enabled = //kyotuEla.tenmetuOnOff;
                false;
                rrM1_4LineFD.enabled = true;
                rrM1_4LineStFD.enabled = kyotuEla.tenmetuOnOff;
                //false;
                rrM1_4LineStFD2.enabled = //kyotuEla.tenmetuOnOff;
                //false;
                true;


                rrM1_4kakuBAC.enabled = true;
                //false;

                rrM1_4kakuStBAC.enabled =
                //kyotuEla.tenmetuOnOff;
                false;

                rrM1_4kakuABC.enabled = true;
                //false;
                rrM1_4kakuStABC.enabled =
                //kyotuEla.tenmetuOnOff;
                false;

                rrM1_4kakuACB.enabled = true;
                //false;

                rrM1_4kakuStACB.enabled =
                //kyotuEla.tenmetuOnOff;
                false;


                rrM1_4kakuEDF.enabled = true;
                //false;

                rrM1_4kakuStEDF.enabled =
                //kyotuEla.tenmetuOnOff;
                false;

                rrM1_4kakuDEF.enabled = true;
                //false;

                rrM1_4kakuStDEF.enabled =
                //kyotuEla.tenmetuOnOff;
                false;

                rrM1_4kakuDFE.enabled = true;
                //false;

                rrM1_4kakuStDFE.enabled =
                //kyotuEla.tenmetuOnOff;
                false;

                rrM1_4TextA.enabled = true;
                rrM1_4TextB.enabled = true;
                rrM1_4TextC.enabled = true;

                rrM1_4TextD.enabled = true;
                rrM1_4TextE.enabled = true;
                rrM1_4TextF.enabled = true;

                rrM1_4PointA.enabled = true;
                rrM1_4PointStA.enabled = //kyotuEla.tenmetuOnOff;
                                         false;
                //true;

                rrM1_4PointB.enabled = true;
                rrM1_4PointStB.enabled = //kyotuEla.tenmetuOnOff;
                false;
                //true;
                rrM1_4PointC.enabled = true;
                rrM1_4PointStC.enabled = //kyotuEla.tenmetuOnOff;
                false;
                //true;

                rrM1_4PointD.enabled = true;
                rrM1_4PointStD.enabled = //kyotuEla.tenmetuOnOff;
                                        false;
                rrM1_4PointE.enabled = true;
                rrM1_4PointStE.enabled = //kyotuEla.tenmetuOnOff;
                false;
                rrM1_4PointF.enabled = true;
                rrM1_4PointStF.enabled = //kyotuEla.tenmetuOnOff;
                false;
            } else if (count == 69) {
                reset();
                rrM1_4LineAB.enabled = true;
                rrM1_4LineStAB.enabled = false;
                //kyotuEla.tenmetuOnOff;
                rrM1_4LineStAB2.enabled = //kyotuEla.tenmetuOnOff;
                //false;
                true;

                rrM1_4LineBC.enabled = true;
                rrM1_4LineStBC.enabled = //kyotuEla.tenmetuOnOff;
                false;
                //true;

                rrM1_4LineCA.enabled = true;
                rrM1_4LineStCA.enabled = //kyotuEla.tenmetuOnOff;
                false;
                rrM1_4LineStCA2.enabled = //kyotuEla.tenmetuOnOff;
                //false;
                true;


                rrM1_4LineDE.enabled = true;
                rrM1_4LineStDE.enabled = //kyotuEla.tenmetuOnOff;
                false;
                rrM1_4LineStDE2.enabled = //kyotuEla.tenmetuOnOff;
                //false;
                true;


                rrM1_4LineEF.enabled = true;
                rrM1_4LineStEF.enabled = //kyotuEla.tenmetuOnOff;
                false;
                rrM1_4LineFD.enabled = true;
                rrM1_4LineStFD.enabled = //kyotuEla.tenmetuOnOff;
                false;
                rrM1_4LineStFD2.enabled = //kyotuEla.tenmetuOnOff;
                //false;
                true;


                rrM1_4kakuBAC.enabled = true;
                //false;

                rrM1_4kakuStBAC.enabled =
                kyotuEla.tenmetuOnOff;
                //false;

                rrM1_4kakuABC.enabled = true;
                //false;
                rrM1_4kakuStABC.enabled =
                //kyotuEla.tenmetuOnOff;
                false;

                rrM1_4kakuACB.enabled = true;
                //false;

                rrM1_4kakuStACB.enabled =
                //kyotuEla.tenmetuOnOff;
                false;


                rrM1_4kakuEDF.enabled = true;
                //false;

                rrM1_4kakuStEDF.enabled =
                kyotuEla.tenmetuOnOff;
                //false;

                rrM1_4kakuDEF.enabled = true;
                //false;

                rrM1_4kakuStDEF.enabled =
                //kyotuEla.tenmetuOnOff;
                false;

                rrM1_4kakuDFE.enabled = true;
                //false;

                rrM1_4kakuStDFE.enabled =
                //kyotuEla.tenmetuOnOff;
                false;

                rrM1_4TextA.enabled = true;
                rrM1_4TextB.enabled = true;
                rrM1_4TextC.enabled = true;

                rrM1_4TextD.enabled = true;
                rrM1_4TextE.enabled = true;
                rrM1_4TextF.enabled = true;

                rrM1_4PointA.enabled = true;
                rrM1_4PointStA.enabled = //kyotuEla.tenmetuOnOff;
                                         false;
                //true;

                rrM1_4PointB.enabled = true;
                rrM1_4PointStB.enabled = //kyotuEla.tenmetuOnOff;
                false;
                //true;
                rrM1_4PointC.enabled = true;
                rrM1_4PointStC.enabled = //kyotuEla.tenmetuOnOff;
                false;
                //true;

                rrM1_4PointD.enabled = true;
                rrM1_4PointStD.enabled = //kyotuEla.tenmetuOnOff;
                                        false;
                rrM1_4PointE.enabled = true;
                rrM1_4PointStE.enabled = //kyotuEla.tenmetuOnOff;
                false;
                rrM1_4PointF.enabled = true;
                rrM1_4PointStF.enabled = //kyotuEla.tenmetuOnOff;
                false;
            } else if (count == 70) {
                reset();
                rrM1_4LineAB.enabled = true;
                rrM1_4LineStAB.enabled = false;
                //kyotuEla.tenmetuOnOff;
                rrM1_4LineStAB2.enabled = //kyotuEla.tenmetuOnOff;
                //false;
                true;

                rrM1_4LineBC.enabled = true;
                rrM1_4LineStBC.enabled = kyotuEla.tenmetuOnOff;
                //false;
                //true;

                rrM1_4LineCA.enabled = true;
                rrM1_4LineStCA.enabled = //kyotuEla.tenmetuOnOff;
                false;
                rrM1_4LineStCA2.enabled = //kyotuEla.tenmetuOnOff;
                //false;
                true;


                rrM1_4LineDE.enabled = true;
                rrM1_4LineStDE.enabled = //kyotuEla.tenmetuOnOff;
                false;
                rrM1_4LineStDE2.enabled = //kyotuEla.tenmetuOnOff;
                //false;
                true;


                rrM1_4LineEF.enabled = true;
                rrM1_4LineStEF.enabled = kyotuEla.tenmetuOnOff;
                //false;
                rrM1_4LineFD.enabled = true;
                rrM1_4LineStFD.enabled = //kyotuEla.tenmetuOnOff;
                false;
                rrM1_4LineStFD2.enabled = //kyotuEla.tenmetuOnOff;
                //false;
                true;


                rrM1_4kakuBAC.enabled = true;
                //false;

                rrM1_4kakuStBAC.enabled =
                //kyotuEla.tenmetuOnOff;
                false;

                rrM1_4kakuABC.enabled = true;
                //false;
                rrM1_4kakuStABC.enabled =
                //kyotuEla.tenmetuOnOff;
                false;

                rrM1_4kakuACB.enabled = true;
                //false;

                rrM1_4kakuStACB.enabled =
                //kyotuEla.tenmetuOnOff;
                false;


                rrM1_4kakuEDF.enabled = true;
                //false;

                rrM1_4kakuStEDF.enabled =
                //kyotuEla.tenmetuOnOff;
                false;

                rrM1_4kakuDEF.enabled = true;
                //false;

                rrM1_4kakuStDEF.enabled =
                //kyotuEla.tenmetuOnOff;
                false;

                rrM1_4kakuDFE.enabled = true;
                //false;

                rrM1_4kakuStDFE.enabled =
                //kyotuEla.tenmetuOnOff;
                false;

                rrM1_4TextA.enabled = true;
                rrM1_4TextB.enabled = true;
                rrM1_4TextC.enabled = true;

                rrM1_4TextD.enabled = true;
                rrM1_4TextE.enabled = true;
                rrM1_4TextF.enabled = true;

                rrM1_4PointA.enabled = true;
                rrM1_4PointStA.enabled = //kyotuEla.tenmetuOnOff;
                                         false;
                //true;

                rrM1_4PointB.enabled = true;
                rrM1_4PointStB.enabled = //kyotuEla.tenmetuOnOff;
                false;
                //true;
                rrM1_4PointC.enabled = true;
                rrM1_4PointStC.enabled = //kyotuEla.tenmetuOnOff;
                false;
                //true;

                rrM1_4PointD.enabled = true;
                rrM1_4PointStD.enabled = //kyotuEla.tenmetuOnOff;
                                        false;
                rrM1_4PointE.enabled = true;
                rrM1_4PointStE.enabled = //kyotuEla.tenmetuOnOff;
                false;
                rrM1_4PointF.enabled = true;
                rrM1_4PointStF.enabled = //kyotuEla.tenmetuOnOff;
                false;
            } else if (count == 71) {
                reset();
                rrM1_4LineAB.enabled = true;
                rrM1_4LineStAB.enabled = //false;
                kyotuEla.tenmetuOnOff;
                rrM1_4LineStAB2.enabled = //kyotuEla.tenmetuOnOff;
                //false;
                true;

                rrM1_4LineBC.enabled = true;
                rrM1_4LineStBC.enabled = kyotuEla.tenmetuOnOff;
                //false;
                //true;

                rrM1_4LineCA.enabled = true;
                rrM1_4LineStCA.enabled = kyotuEla.tenmetuOnOff;
                //false;
                rrM1_4LineStCA2.enabled = //kyotuEla.tenmetuOnOff;
                //false;
                true;


                rrM1_4LineDE.enabled = true;
                rrM1_4LineStDE.enabled = kyotuEla.tenmetuOnOff;
                //false;
                rrM1_4LineStDE2.enabled = //kyotuEla.tenmetuOnOff;
                //false;
                true;


                rrM1_4LineEF.enabled = true;
                rrM1_4LineStEF.enabled = kyotuEla.tenmetuOnOff;
                //false;
                rrM1_4LineFD.enabled = true;
                rrM1_4LineStFD.enabled = kyotuEla.tenmetuOnOff;
                //false;
                rrM1_4LineStFD2.enabled = //kyotuEla.tenmetuOnOff;
                //false;
                true;


                rrM1_4kakuBAC.enabled = true;
                //false;

                rrM1_4kakuStBAC.enabled =
                //kyotuEla.tenmetuOnOff;
                false;

                rrM1_4kakuABC.enabled = true;
                //false;
                rrM1_4kakuStABC.enabled =
                //kyotuEla.tenmetuOnOff;
                false;

                rrM1_4kakuACB.enabled = true;
                //false;

                rrM1_4kakuStACB.enabled =
                //kyotuEla.tenmetuOnOff;
                false;


                rrM1_4kakuEDF.enabled = true;
                //false;

                rrM1_4kakuStEDF.enabled =
                //kyotuEla.tenmetuOnOff;
                false;

                rrM1_4kakuDEF.enabled = true;
                //false;

                rrM1_4kakuStDEF.enabled =
                //kyotuEla.tenmetuOnOff;
                false;

                rrM1_4kakuDFE.enabled = true;
                //false;

                rrM1_4kakuStDFE.enabled =
                //kyotuEla.tenmetuOnOff;
                false;

                rrM1_4TextA.enabled = true;
                rrM1_4TextB.enabled = true;
                rrM1_4TextC.enabled = true;

                rrM1_4TextD.enabled = true;
                rrM1_4TextE.enabled = true;
                rrM1_4TextF.enabled = true;

                rrM1_4PointA.enabled = true;
                rrM1_4PointStA.enabled = //kyotuEla.tenmetuOnOff;
                                         false;
                //true;

                rrM1_4PointB.enabled = true;
                rrM1_4PointStB.enabled = //kyotuEla.tenmetuOnOff;
                false;
                //true;
                rrM1_4PointC.enabled = true;
                rrM1_4PointStC.enabled = //kyotuEla.tenmetuOnOff;
                false;
                //true;

                rrM1_4PointD.enabled = true;
                rrM1_4PointStD.enabled = //kyotuEla.tenmetuOnOff;
                                        false;
                rrM1_4PointE.enabled = true;
                rrM1_4PointStE.enabled = //kyotuEla.tenmetuOnOff;
                false;
                rrM1_4PointF.enabled = true;
                rrM1_4PointStF.enabled = //kyotuEla.tenmetuOnOff;
                false;
            } else if (count == 72) {
                reset();
                rrM1_4LineAB.enabled = true;
                rrM1_4LineStAB.enabled = //false;
                kyotuEla.tenmetuOnOff;
                rrM1_4LineStAB2.enabled = //kyotuEla.tenmetuOnOff;
                //false;
                true;

                rrM1_4LineBC.enabled = true;
                rrM1_4LineStBC.enabled = //kyotuEla.tenmetuOnOff;
                false;
                //true;

                rrM1_4LineCA.enabled = true;
                rrM1_4LineStCA.enabled = kyotuEla.tenmetuOnOff;
                //false;
                rrM1_4LineStCA2.enabled = //kyotuEla.tenmetuOnOff;
                //false;
                true;


                rrM1_4LineDE.enabled = true;
                rrM1_4LineStDE.enabled = kyotuEla.tenmetuOnOff;
                //false;
                rrM1_4LineStDE2.enabled = //kyotuEla.tenmetuOnOff;
                //false;
                true;


                rrM1_4LineEF.enabled = true;
                rrM1_4LineStEF.enabled = //kyotuEla.tenmetuOnOff;
                false;
                rrM1_4LineFD.enabled = true;
                rrM1_4LineStFD.enabled = kyotuEla.tenmetuOnOff;
                //false;
                rrM1_4LineStFD2.enabled = //kyotuEla.tenmetuOnOff;
                //false;
                true;


                rrM1_4kakuBAC.enabled = true;
                //false;

                rrM1_4kakuStBAC.enabled =
                //kyotuEla.tenmetuOnOff;
                false;

                rrM1_4kakuABC.enabled = true;
                //false;
                rrM1_4kakuStABC.enabled =
                //kyotuEla.tenmetuOnOff;
                false;

                rrM1_4kakuACB.enabled = true;
                //false;

                rrM1_4kakuStACB.enabled =
                //kyotuEla.tenmetuOnOff;
                false;


                rrM1_4kakuEDF.enabled = true;
                //false;

                rrM1_4kakuStEDF.enabled =
                //kyotuEla.tenmetuOnOff;
                false;

                rrM1_4kakuDEF.enabled = true;
                //false;

                rrM1_4kakuStDEF.enabled =
                //kyotuEla.tenmetuOnOff;
                false;

                rrM1_4kakuDFE.enabled = true;
                //false;

                rrM1_4kakuStDFE.enabled =
                //kyotuEla.tenmetuOnOff;
                false;

                rrM1_4TextA.enabled = true;
                rrM1_4TextB.enabled = true;
                rrM1_4TextC.enabled = true;

                rrM1_4TextD.enabled = true;
                rrM1_4TextE.enabled = true;
                rrM1_4TextF.enabled = true;

                rrM1_4PointA.enabled = true;
                rrM1_4PointStA.enabled = //kyotuEla.tenmetuOnOff;
                                         false;
                //true;

                rrM1_4PointB.enabled = true;
                rrM1_4PointStB.enabled = //kyotuEla.tenmetuOnOff;
                false;
                //true;
                rrM1_4PointC.enabled = true;
                rrM1_4PointStC.enabled = //kyotuEla.tenmetuOnOff;
                false;
                //true;

                rrM1_4PointD.enabled = true;
                rrM1_4PointStD.enabled = //kyotuEla.tenmetuOnOff;
                                        false;
                rrM1_4PointE.enabled = true;
                rrM1_4PointStE.enabled = //kyotuEla.tenmetuOnOff;
                false;
                rrM1_4PointF.enabled = true;
                rrM1_4PointStF.enabled = //kyotuEla.tenmetuOnOff;
                false;
            } else if (count == 73) {
                reset();
                rrM1_4LineAB.enabled = true;
                rrM1_4LineStAB.enabled = false;
                //kyotuEla.tenmetuOnOff;
                rrM1_4LineStAB2.enabled = //kyotuEla.tenmetuOnOff;
                //false;
                true;

                rrM1_4LineBC.enabled = true;
                rrM1_4LineStBC.enabled = //kyotuEla.tenmetuOnOff;
                false;
                //true;

                rrM1_4LineCA.enabled = true;
                rrM1_4LineStCA.enabled = //kyotuEla.tenmetuOnOff;
                false;
                rrM1_4LineStCA2.enabled = //kyotuEla.tenmetuOnOff;
                //false;
                true;


                rrM1_4LineDE.enabled = true;
                rrM1_4LineStDE.enabled = //kyotuEla.tenmetuOnOff;
                false;
                rrM1_4LineStDE2.enabled = //kyotuEla.tenmetuOnOff;
                //false;
                true;


                rrM1_4LineEF.enabled = true;
                rrM1_4LineStEF.enabled = //kyotuEla.tenmetuOnOff;
                false;
                rrM1_4LineFD.enabled = true;
                rrM1_4LineStFD.enabled = //kyotuEla.tenmetuOnOff;
                false;
                rrM1_4LineStFD2.enabled = //kyotuEla.tenmetuOnOff;
                //false;
                true;


                rrM1_4kakuBAC.enabled = true;
                //false;

                rrM1_4kakuStBAC.enabled =
                //kyotuEla.tenmetuOnOff;
                false;

                rrM1_4kakuABC.enabled = true;
                //false;
                rrM1_4kakuStABC.enabled =
                kyotuEla.tenmetuOnOff;
                //false;

                rrM1_4kakuACB.enabled = true;
                //false;

                rrM1_4kakuStACB.enabled =
                kyotuEla.tenmetuOnOff;
                //false;


                rrM1_4kakuEDF.enabled = true;
                //false;

                rrM1_4kakuStEDF.enabled =
                //kyotuEla.tenmetuOnOff;
                false;

                rrM1_4kakuDEF.enabled = true;
                //false;

                rrM1_4kakuStDEF.enabled =
                kyotuEla.tenmetuOnOff;
                //false;

                rrM1_4kakuDFE.enabled = true;
                //false;

                rrM1_4kakuStDFE.enabled =
                kyotuEla.tenmetuOnOff;
                //false;

                rrM1_4TextA.enabled = true;
                rrM1_4TextB.enabled = true;
                rrM1_4TextC.enabled = true;

                rrM1_4TextD.enabled = true;
                rrM1_4TextE.enabled = true;
                rrM1_4TextF.enabled = true;

                rrM1_4PointA.enabled = true;
                rrM1_4PointStA.enabled = //kyotuEla.tenmetuOnOff;
                                         false;
                //true;

                rrM1_4PointB.enabled = true;
                rrM1_4PointStB.enabled = //kyotuEla.tenmetuOnOff;
                false;
                //true;
                rrM1_4PointC.enabled = true;
                rrM1_4PointStC.enabled = //kyotuEla.tenmetuOnOff;
                false;
                //true;

                rrM1_4PointD.enabled = true;
                rrM1_4PointStD.enabled = //kyotuEla.tenmetuOnOff;
                                        false;
                rrM1_4PointE.enabled = true;
                rrM1_4PointStE.enabled = //kyotuEla.tenmetuOnOff;
                false;
                rrM1_4PointF.enabled = true;
                rrM1_4PointStF.enabled = //kyotuEla.tenmetuOnOff;
                false;
            } else if (count == 74) {
                reset();
                rrM1_4LineAB.enabled = true;
                rrM1_4LineStAB.enabled = false;
                //kyotuEla.tenmetuOnOff;
                rrM1_4LineStAB2.enabled = //kyotuEla.tenmetuOnOff;
                //false;
                true;

                rrM1_4LineBC.enabled = true;
                rrM1_4LineStBC.enabled = //kyotuEla.tenmetuOnOff;
                false;
                //true;

                rrM1_4LineCA.enabled = true;
                rrM1_4LineStCA.enabled = //kyotuEla.tenmetuOnOff;
                false;
                rrM1_4LineStCA2.enabled = //kyotuEla.tenmetuOnOff;
                //false;
                true;


                rrM1_4LineDE.enabled = true;
                rrM1_4LineStDE.enabled = //kyotuEla.tenmetuOnOff;
                false;
                rrM1_4LineStDE2.enabled = //kyotuEla.tenmetuOnOff;
                //false;
                true;


                rrM1_4LineEF.enabled = true;
                rrM1_4LineStEF.enabled = //kyotuEla.tenmetuOnOff;
                false;
                rrM1_4LineFD.enabled = true;
                rrM1_4LineStFD.enabled = //kyotuEla.tenmetuOnOff;
                false;
                rrM1_4LineStFD2.enabled = //kyotuEla.tenmetuOnOff;
                //false;
                true;


                rrM1_4kakuBAC.enabled = true;
                //false;

                rrM1_4kakuStBAC.enabled =
                //kyotuEla.tenmetuOnOff;
                false;

                rrM1_4kakuABC.enabled = true;
                //false;
                rrM1_4kakuStABC.enabled =
                //kyotuEla.tenmetuOnOff;
                false;

                rrM1_4kakuACB.enabled = true;
                //false;

                rrM1_4kakuStACB.enabled =
                //kyotuEla.tenmetuOnOff;
                false;


                rrM1_4kakuEDF.enabled = true;
                //false;

                rrM1_4kakuStEDF.enabled =
                //kyotuEla.tenmetuOnOff;
                false;

                rrM1_4kakuDEF.enabled = true;
                //false;

                rrM1_4kakuStDEF.enabled =
                //kyotuEla.tenmetuOnOff;
                false;

                rrM1_4kakuDFE.enabled = true;
                //false;

                rrM1_4kakuStDFE.enabled =
                //kyotuEla.tenmetuOnOff;
                false;

                rrM1_4TextA.enabled = true;
                rrM1_4TextB.enabled = true;
                rrM1_4TextC.enabled = true;

                rrM1_4TextD.enabled = true;
                rrM1_4TextE.enabled = true;
                rrM1_4TextF.enabled = true;

                rrM1_4PointA.enabled = true;
                rrM1_4PointStA.enabled = //kyotuEla.tenmetuOnOff;
                                         false;
                //true;

                rrM1_4PointB.enabled = true;
                rrM1_4PointStB.enabled = //kyotuEla.tenmetuOnOff;
                false;
                //true;
                rrM1_4PointC.enabled = true;
                rrM1_4PointStC.enabled = //kyotuEla.tenmetuOnOff;
                false;
                //true;

                rrM1_4PointD.enabled = true;
                rrM1_4PointStD.enabled = //kyotuEla.tenmetuOnOff;
                                        false;
                rrM1_4PointE.enabled = true;
                rrM1_4PointStE.enabled = //kyotuEla.tenmetuOnOff;
                false;
                rrM1_4PointF.enabled = true;
                rrM1_4PointStF.enabled = //kyotuEla.tenmetuOnOff;
                false;
            }
        }
    }
}
