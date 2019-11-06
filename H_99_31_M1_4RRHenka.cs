using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class H_99_31_M1_4RRHenka : MonoBehaviour {//atama
    //M1_3preにアタッチ。オブジェクト全体のいどうをするプログラム
    //いちいちunityで当てはめなきゃ駄目　↓---------------

    //k5_3_1_1:gameobject(メソッド、変数)を使いまわす
    public H_99_01_kyoutuHensu kyotu;

    //強調表現点滅に使う変数を共通変数として使う。
    public H_99_01B_kyotuElapse kyotuEla;

    public Material MColor0;
    public Material MColor1;
    public Material MColor2;
    public Material MColor3;
    public Material MColor4;
    public Material MColor5;
    public Material MColor6;
    public Material MColor7;
    public Material MColor8;
    public Material MColor9;

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
        

        rrM1_4LineBC.enabled = false;
        rrM1_4LineStBC.enabled = false;

        rrM1_4LineCA.enabled = false;
        rrM1_4LineStCA.enabled = false;
        
        rrM1_4LineDE.enabled = false;
        rrM1_4LineStDE.enabled = false;
       

        rrM1_4LineEF.enabled = false;
        rrM1_4LineStEF.enabled = false;

        rrM1_4LineFD.enabled = false;
        rrM1_4LineStFD.enabled = false;
        


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
        Debug.Log("M1_4RRHenka::" + kyotu.mojiSwitch + "::MC::" + kyotu.MCount + "::RRC::" + kyotu.rrCount);

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
            }
            else if (count == 1) //henka1
            {
                reset();
                //k0018_99_1_1_1://obj.GetComponent<Renderer>().material = ColorPink;
                rrM1_4LineAB.material = MColor1;
                rrM1_4LineCA.material = MColor1;
                rrM1_4LineDE.material = MColor1;
                rrM1_4LineFD.material = MColor1;

                rrM1_4LineStAB.material = MColor5;
                rrM1_4LineStBC.material = MColor5;
                rrM1_4LineStCA.material = MColor5;
                rrM1_4LineStDE.material = MColor5;
                rrM1_4LineStEF.material = MColor5;
                rrM1_4LineStFD.material = MColor5;

                rrM1_4LineAB.enabled = true;
                rrM1_4LineBC.enabled = true;
                rrM1_4LineCA.enabled = true;
                rrM1_4LineDE.enabled = true;
                rrM1_4LineEF.enabled = true;
                rrM1_4LineFD.enabled = true;

                rrM1_4LineStAB.enabled = kyotuEla.tenmetuOnOff;
                rrM1_4LineStBC.enabled = kyotuEla.tenmetuOnOff;
                rrM1_4LineStCA.enabled = kyotuEla.tenmetuOnOff;
                rrM1_4LineStDE.enabled = kyotuEla.tenmetuOnOff;
                rrM1_4LineStEF.enabled = kyotuEla.tenmetuOnOff;
                rrM1_4LineStFD.enabled = kyotuEla.tenmetuOnOff;
            } else if (count == 2) {
                reset();
                //k0018_99_1_1_1://obj.GetComponent<Renderer>().material = ColorPink;
                rrM1_4LineAB.material = MColor1;
                rrM1_4LineCA.material = MColor1;
                rrM1_4LineDE.material = MColor1;
                rrM1_4LineFD.material = MColor1;

                rrM1_4LineStAB.material = MColor5;
                rrM1_4LineStBC.material = MColor5;
                rrM1_4LineStCA.material = MColor5;
                rrM1_4LineStDE.material = MColor5;
                rrM1_4LineStEF.material = MColor5;
                rrM1_4LineStFD.material = MColor5;

                rrM1_4LineAB.enabled = true;
                rrM1_4LineBC.enabled = true;
                rrM1_4LineCA.enabled = true;
                rrM1_4LineDE.enabled = true;
                rrM1_4LineEF.enabled = true;
                rrM1_4LineFD.enabled = true;

                rrM1_4LineStAB.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_4LineStBC.enabled = kyotuEla.tenmetuOnOff;
                rrM1_4LineStCA.enabled = kyotuEla.tenmetuOnOff;
                rrM1_4LineStDE.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_4LineStEF.enabled = kyotuEla.tenmetuOnOff;
                rrM1_4LineStFD.enabled = kyotuEla.tenmetuOnOff;
            } else if (count == 3) {
                reset();
                //k0018_99_1_1_1://obj.GetComponent<Renderer>().material = ColorPink;
                rrM1_4LineAB.material = MColor2;
                rrM1_4LineCA.material = MColor1;
                rrM1_4LineDE.material = MColor2;
                rrM1_4LineFD.material = MColor1;

                rrM1_4LineStAB.material = MColor2;
                rrM1_4LineStBC.material = MColor5;
                rrM1_4LineStCA.material = MColor4;
                rrM1_4LineStDE.material = MColor2;
                rrM1_4LineStEF.material = MColor5;
                rrM1_4LineStFD.material = MColor4;

                rrM1_4LineAB.enabled = true;
                rrM1_4LineBC.enabled = true;
                rrM1_4LineCA.enabled = true;
                rrM1_4LineDE.enabled = true;
                rrM1_4LineEF.enabled = true;
                rrM1_4LineFD.enabled = true;

                rrM1_4LineStAB.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_4LineStBC.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_4LineStCA.enabled = kyotuEla.tenmetuOnOff;
                rrM1_4LineStDE.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_4LineStEF.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_4LineStFD.enabled = kyotuEla.tenmetuOnOff;
            } else if (count == 4) {
                reset();
                //k0018_99_1_1_1://obj.GetComponent<Renderer>().material = ColorPink;
                rrM1_4LineAB.material = MColor2;
                rrM1_4LineCA.material = MColor4;
                rrM1_4LineDE.material = MColor2;
                rrM1_4LineFD.material = MColor4;

                rrM1_4LineStAB.material = MColor2;
                rrM1_4LineStBC.material = MColor5;
                rrM1_4LineStCA.material = MColor4;
                rrM1_4LineStDE.material = MColor2;
                rrM1_4LineStEF.material = MColor5;
                rrM1_4LineStFD.material = MColor4;

                rrM1_4LineAB.enabled = true;
                rrM1_4LineBC.enabled = true;
                rrM1_4LineCA.enabled = true;
                rrM1_4LineDE.enabled = true;
                rrM1_4LineEF.enabled = true;
                rrM1_4LineFD.enabled = true;

                //rrM1_4LineStAB.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_4LineStBC.enabled = kyotuEla.tenmetuOnOff;
                rrM1_4LineStCA.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_4LineStDE.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_4LineStEF.enabled = kyotuEla.tenmetuOnOff;
                rrM1_4LineStFD.enabled = kyotuEla.tenmetuOnOff;
            } else if (count == 5) {
                reset();
                //k0018_99_1_1_1://obj.GetComponent<Renderer>().material = ColorPink;
                rrM1_4LineAB.material = MColor2;
                rrM1_4LineCA.material = MColor4;
                rrM1_4LineDE.material = MColor2;
                rrM1_4LineFD.material = MColor4;

                rrM1_4LineStAB.material = MColor2;
                rrM1_4LineStBC.material = MColor5;
                rrM1_4LineStCA.material = MColor4;
                rrM1_4LineStDE.material = MColor2;
                rrM1_4LineStEF.material = MColor5;
                rrM1_4LineStFD.material = MColor4;

                rrM1_4LineAB.enabled = true;
                rrM1_4LineBC.enabled = true;
                rrM1_4LineCA.enabled = true;
                rrM1_4LineDE.enabled = true;
                rrM1_4LineEF.enabled = true;
                rrM1_4LineFD.enabled = true;

                rrM1_4LineStAB.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_4LineStBC.enabled = kyotuEla.tenmetuOnOff;
                rrM1_4LineStCA.enabled = kyotuEla.tenmetuOnOff;
                rrM1_4LineStDE.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_4LineStEF.enabled = kyotuEla.tenmetuOnOff;
                rrM1_4LineStFD.enabled = kyotuEla.tenmetuOnOff;
            } else if (count == 6) {
                reset();
                //k0018_99_1_1_1://obj.GetComponent<Renderer>().material = ColorPink;
                rrM1_4LineAB.material = MColor2;
                rrM1_4LineCA.material = MColor4;
                rrM1_4LineDE.material = MColor2;
                rrM1_4LineFD.material = MColor4;

                rrM1_4LineStAB.material = MColor2;
                rrM1_4LineStBC.material = MColor5;
                rrM1_4LineStCA.material = MColor4;
                rrM1_4LineStDE.material = MColor2;
                rrM1_4LineStEF.material = MColor5;
                rrM1_4LineStFD.material = MColor4;

                rrM1_4LineAB.enabled = true;
                rrM1_4LineBC.enabled = true;
                rrM1_4LineCA.enabled = true;
                rrM1_4LineDE.enabled = true;
                rrM1_4LineEF.enabled = true;
                rrM1_4LineFD.enabled = true;

                //rrM1_4LineStAB.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_4LineStBC.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_4LineStCA.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_4LineStDE.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_4LineStEF.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_4LineStFD.enabled = kyotuEla.tenmetuOnOff;

                rrM1_4kakuBAC.enabled = true;
                rrM1_4kakuEDF.enabled = true;

                rrM1_4kakuStBAC.enabled = kyotuEla.tenmetuOnOff;
                rrM1_4kakuStEDF.enabled = kyotuEla.tenmetuOnOff;
            } else if (count == 7) {
                reset();
                //k0018_99_1_1_1://obj.GetComponent<Renderer>().material = ColorPink;
                rrM1_4LineAB.material = MColor2;
                rrM1_4LineCA.material = MColor4;
                rrM1_4LineDE.material = MColor2;
                rrM1_4LineFD.material = MColor4;

                rrM1_4LineStAB.material = MColor2;
                rrM1_4LineStBC.material = MColor5;
                rrM1_4LineStCA.material = MColor4;
                rrM1_4LineStDE.material = MColor2;
                rrM1_4LineStEF.material = MColor5;
                rrM1_4LineStFD.material = MColor4;

                rrM1_4LineAB.enabled = true;
                rrM1_4LineBC.enabled = true;
                rrM1_4LineCA.enabled = true;
                rrM1_4LineDE.enabled = true;
                rrM1_4LineEF.enabled = true;
                rrM1_4LineFD.enabled = true;

                //rrM1_4LineStAB.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_4LineStBC.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_4LineStCA.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_4LineStDE.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_4LineStEF.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_4LineStFD.enabled = kyotuEla.tenmetuOnOff;

                rrM1_4kakuBAC.enabled = true;
                rrM1_4kakuEDF.enabled = true;

                rrM1_4kakuStBAC.enabled = kyotuEla.tenmetuOnOff;
                rrM1_4kakuStEDF.enabled = kyotuEla.tenmetuOnOff;
            } else if (count == 8) {//henka8
                reset();
                //k0018_99_1_1_1://obj.GetComponent<Renderer>().material = ColorPink;
                rrM1_4LineAB.material = MColor2;
                rrM1_4LineCA.material = MColor4;
                rrM1_4LineDE.material = MColor2;
                rrM1_4LineFD.material = MColor4;

                rrM1_4LineStAB.material = MColor2;
                rrM1_4LineStBC.material = MColor5;
                rrM1_4LineStCA.material = MColor4;
                rrM1_4LineStDE.material = MColor2;
                rrM1_4LineStEF.material = MColor5;
                rrM1_4LineStFD.material = MColor4;

                rrM1_4LineAB.enabled = true;
                rrM1_4LineBC.enabled = true;
                rrM1_4LineCA.enabled = true;
                rrM1_4LineDE.enabled = true;
                rrM1_4LineEF.enabled = true;
                rrM1_4LineFD.enabled = true;

                //rrM1_4LineStAB.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_4LineStBC.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_4LineStCA.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_4LineStDE.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_4LineStEF.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_4LineStFD.enabled = kyotuEla.tenmetuOnOff;

                rrM1_4kakuBAC.enabled = true;
                rrM1_4kakuEDF.enabled = true;

                //rrM1_4kakuStBAC.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_4kakuStEDF.enabled = kyotuEla.tenmetuOnOff;
            } else if (count == 9) {
                reset();
                //k0018_99_1_1_1://obj.GetComponent<Renderer>().material = ColorPink;
                rrM1_4LineAB.material = MColor2;
                rrM1_4LineCA.material = MColor4;
                rrM1_4LineDE.material = MColor2;
                rrM1_4LineFD.material = MColor4;

                rrM1_4LineStAB.material = MColor2;
                rrM1_4LineStBC.material = MColor1;
                rrM1_4LineStCA.material = MColor4;
                rrM1_4LineStDE.material = MColor2;
                rrM1_4LineStEF.material = MColor1;
                rrM1_4LineStFD.material = MColor4;

                rrM1_4LineAB.enabled = true;
                rrM1_4LineBC.enabled = true;
                rrM1_4LineCA.enabled = true;
                rrM1_4LineDE.enabled = true;
                rrM1_4LineEF.enabled = true;
                rrM1_4LineFD.enabled = true;

                //rrM1_4LineStAB.enabled = kyotuEla.tenmetuOnOff;
                rrM1_4LineStBC.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_4LineStCA.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_4LineStDE.enabled = kyotuEla.tenmetuOnOff;
                rrM1_4LineStEF.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_4LineStFD.enabled = kyotuEla.tenmetuOnOff;

                rrM1_4kakuBAC.enabled = true;
                rrM1_4kakuEDF.enabled = true;

                //rrM1_4kakuStBAC.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_4kakuStEDF.enabled = kyotuEla.tenmetuOnOff;
            } else if (count == 10) {
                reset();
                //k0018_99_1_1_1://obj.GetComponent<Renderer>().material = ColorPink;
                rrM1_4LineAB.material = MColor2;
                rrM1_4LineCA.material = MColor4;
                rrM1_4LineDE.material = MColor2;
                rrM1_4LineFD.material = MColor4;

                rrM1_4LineStAB.material = MColor2;
                rrM1_4LineStBC.material = MColor1;
                rrM1_4LineStCA.material = MColor4;
                rrM1_4LineStDE.material = MColor2;
                rrM1_4LineStEF.material = MColor1;
                rrM1_4LineStFD.material = MColor4;

                rrM1_4LineAB.enabled = true;
                rrM1_4LineBC.enabled = true;
                rrM1_4LineCA.enabled = true;
                rrM1_4LineDE.enabled = true;
                rrM1_4LineEF.enabled = true;
                rrM1_4LineFD.enabled = true;

                //rrM1_4LineStAB.enabled = kyotuEla.tenmetuOnOff;
                rrM1_4LineStBC.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_4LineStCA.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_4LineStDE.enabled = kyotuEla.tenmetuOnOff;
                rrM1_4LineStEF.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_4LineStFD.enabled = kyotuEla.tenmetuOnOff;

                rrM1_4kakuBAC.enabled = true;
                rrM1_4kakuEDF.enabled = true;

                //rrM1_4kakuStBAC.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_4kakuStEDF.enabled = kyotuEla.tenmetuOnOff;
            } else if (count == 11) {
                reset();
                //k0018_99_1_1_1://obj.GetComponent<Renderer>().material = ColorPink;
                rrM1_4LineAB.material = MColor2;
                rrM1_4LineCA.material = MColor4;
                rrM1_4LineDE.material = MColor2;
                rrM1_4LineFD.material = MColor4;

                rrM1_4LineStAB.material = MColor2;
                rrM1_4LineStBC.material = MColor1;
                rrM1_4LineStCA.material = MColor4;
                rrM1_4LineStDE.material = MColor2;
                rrM1_4LineStEF.material = MColor1;
                rrM1_4LineStFD.material = MColor4;

                rrM1_4LineAB.enabled = true;
                rrM1_4LineBC.enabled = true;
                rrM1_4LineCA.enabled = true;
                rrM1_4LineDE.enabled = true;
                rrM1_4LineEF.enabled = true;
                rrM1_4LineFD.enabled = true;

                rrM1_4LineStAB.enabled = kyotuEla.tenmetuOnOff;
                rrM1_4LineStBC.enabled = kyotuEla.tenmetuOnOff;
                rrM1_4LineStCA.enabled = kyotuEla.tenmetuOnOff;
                rrM1_4LineStDE.enabled = kyotuEla.tenmetuOnOff;
                rrM1_4LineStEF.enabled = kyotuEla.tenmetuOnOff;
                rrM1_4LineStFD.enabled = kyotuEla.tenmetuOnOff;

                rrM1_4kakuBAC.enabled = true;
                rrM1_4kakuEDF.enabled = true;

                //rrM1_4kakuStBAC.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_4kakuStEDF.enabled = kyotuEla.tenmetuOnOff;
            } else if (count == 12) {
                reset();
                //k0018_99_1_1_1://obj.GetComponent<Renderer>().material = ColorPink;
                rrM1_4LineAB.material = MColor2;
                rrM1_4LineCA.material = MColor4;
                rrM1_4LineDE.material = MColor2;
                rrM1_4LineFD.material = MColor4;

                rrM1_4LineStAB.material = MColor2;
                rrM1_4LineStBC.material = MColor1;
                rrM1_4LineStCA.material = MColor4;
                rrM1_4LineStDE.material = MColor2;
                rrM1_4LineStEF.material = MColor1;
                rrM1_4LineStFD.material = MColor4;

                rrM1_4LineAB.enabled = true;
                rrM1_4LineBC.enabled = true;
                rrM1_4LineCA.enabled = true;
                rrM1_4LineDE.enabled = true;
                rrM1_4LineEF.enabled = true;
                rrM1_4LineFD.enabled = true;

                rrM1_4LineStAB.enabled = kyotuEla.tenmetuOnOff;
                rrM1_4LineStBC.enabled = kyotuEla.tenmetuOnOff;
                rrM1_4LineStCA.enabled = kyotuEla.tenmetuOnOff;
                rrM1_4LineStDE.enabled = kyotuEla.tenmetuOnOff;
                rrM1_4LineStEF.enabled = kyotuEla.tenmetuOnOff;
                rrM1_4LineStFD.enabled = kyotuEla.tenmetuOnOff;

                rrM1_4kakuBAC.enabled = true;
                rrM1_4kakuEDF.enabled = true;

                //rrM1_4kakuStBAC.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_4kakuStEDF.enabled = kyotuEla.tenmetuOnOff;
            } else if (count == 13) {
                reset();
                //k0018_99_1_1_1://obj.GetComponent<Renderer>().material = ColorPink;
                rrM1_4LineAB.material = MColor1;
                rrM1_4LineCA.material = MColor1;
                rrM1_4LineDE.material = MColor1;
                rrM1_4LineFD.material = MColor1;

                rrM1_4LineStAB.material = MColor2;
                rrM1_4LineStBC.material = MColor5;
                rrM1_4LineStCA.material = MColor4;
                rrM1_4LineStDE.material = MColor2;
                rrM1_4LineStEF.material = MColor5;
                rrM1_4LineStFD.material = MColor4;

                rrM1_4LineAB.enabled = true;
                rrM1_4LineBC.enabled = true;
                rrM1_4LineCA.enabled = true;
                rrM1_4LineDE.enabled = true;
                rrM1_4LineEF.enabled = true;
                rrM1_4LineFD.enabled = true;

                rrM1_4LineStAB.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_4LineStBC.enabled = kyotuEla.tenmetuOnOff;
                rrM1_4LineStCA.enabled = kyotuEla.tenmetuOnOff;
                rrM1_4LineStDE.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_4LineStEF.enabled = kyotuEla.tenmetuOnOff;
                rrM1_4LineStFD.enabled = kyotuEla.tenmetuOnOff;

                rrM1_4kakuBAC.enabled = true;
                rrM1_4kakuEDF.enabled = true;

                //rrM1_4kakuStBAC.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_4kakuStEDF.enabled = kyotuEla.tenmetuOnOff;
            } else if (count == 14) {
                reset();
                //k0018_99_1_1_1://obj.GetComponent<Renderer>().material = ColorPink;
                rrM1_4LineAB.material = MColor1;
                rrM1_4LineCA.material = MColor1;
                rrM1_4LineDE.material = MColor1;
                rrM1_4LineFD.material = MColor1;

                rrM1_4LineStAB.material = MColor2;
                rrM1_4LineStBC.material = MColor5;
                rrM1_4LineStCA.material = MColor4;
                rrM1_4LineStDE.material = MColor2;
                rrM1_4LineStEF.material = MColor5;
                rrM1_4LineStFD.material = MColor4;

                rrM1_4LineAB.enabled = true;
                rrM1_4LineBC.enabled = true;
                rrM1_4LineCA.enabled = true;
                rrM1_4LineDE.enabled = true;
                rrM1_4LineEF.enabled = true;
                rrM1_4LineFD.enabled = true;

                rrM1_4LineStAB.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_4LineStBC.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_4LineStCA.enabled = kyotuEla.tenmetuOnOff;
                rrM1_4LineStDE.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_4LineStEF.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_4LineStFD.enabled = kyotuEla.tenmetuOnOff;

                rrM1_4kakuBAC.enabled = true;
                rrM1_4kakuEDF.enabled = true;

                rrM1_4kakuACB.enabled = true;
                rrM1_4kakuDFE.enabled = true;

                rrM1_4kakuStACB.enabled = kyotuEla.tenmetuOnOff;
                rrM1_4kakuStDFE.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_4kakuStBAC.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_4kakuStEDF.enabled = kyotuEla.tenmetuOnOff;
            } else if (count == 15) {
                reset();
                //k0018_99_1_1_1://obj.GetComponent<Renderer>().material = ColorPink;
                rrM1_4LineAB.material = MColor1;
                rrM1_4LineCA.material = MColor1;
                rrM1_4LineDE.material = MColor1;
                rrM1_4LineFD.material = MColor1;

                rrM1_4LineStAB.material = MColor2;
                rrM1_4LineStBC.material = MColor5;
                rrM1_4LineStCA.material = MColor4;
                rrM1_4LineStDE.material = MColor2;
                rrM1_4LineStEF.material = MColor5;
                rrM1_4LineStFD.material = MColor4;

                rrM1_4LineAB.enabled = true;
                rrM1_4LineBC.enabled = true;
                rrM1_4LineCA.enabled = true;
                rrM1_4LineDE.enabled = true;
                rrM1_4LineEF.enabled = true;
                rrM1_4LineFD.enabled = true;

                //rrM1_4LineStAB.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_4LineStBC.enabled = kyotuEla.tenmetuOnOff;
                rrM1_4LineStCA.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_4LineStDE.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_4LineStEF.enabled = kyotuEla.tenmetuOnOff;
                rrM1_4LineStFD.enabled = kyotuEla.tenmetuOnOff;

                rrM1_4kakuBAC.enabled = true;
                rrM1_4kakuABC.enabled = true;
                rrM1_4kakuACB.enabled = true;

                rrM1_4kakuEDF.enabled = true;
                rrM1_4kakuDEF.enabled = true;
                rrM1_4kakuDFE.enabled = true;

                //rrM1_4kakuStBAC.enabled = kyotuEla.tenmetuOnOff;
                rrM1_4kakuStABC.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_4kakuStACB.enabled = kyotuEla.tenmetuOnOff;
                rrM1_4kakuStDEF.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_4kakuStDFE.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_4kakuStEDF.enabled = kyotuEla.tenmetuOnOff;
            } else if (count == 16) {
                reset();
                //k0018_99_1_1_1://obj.GetComponent<Renderer>().material = ColorPink;
                rrM1_4LineAB.material = MColor1;
                rrM1_4LineCA.material = MColor1;
                rrM1_4LineDE.material = MColor1;
                rrM1_4LineFD.material = MColor1;

                rrM1_4LineStAB.material = MColor2;
                rrM1_4LineStBC.material = MColor5;
                rrM1_4LineStCA.material = MColor4;
                rrM1_4LineStDE.material = MColor2;
                rrM1_4LineStEF.material = MColor5;
                rrM1_4LineStFD.material = MColor4;

                rrM1_4LineAB.enabled = true;
                rrM1_4LineBC.enabled = true;
                rrM1_4LineCA.enabled = true;
                rrM1_4LineDE.enabled = true;
                rrM1_4LineEF.enabled = true;
                rrM1_4LineFD.enabled = true;

                //rrM1_4LineStAB.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_4LineStBC.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_4LineStCA.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_4LineStDE.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_4LineStEF.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_4LineStFD.enabled = kyotuEla.tenmetuOnOff;

                rrM1_4kakuBAC.enabled = true;
                rrM1_4kakuABC.enabled = true;
                rrM1_4kakuACB.enabled = true;

                rrM1_4kakuEDF.enabled = true;
                rrM1_4kakuDEF.enabled = true;
                rrM1_4kakuDFE.enabled = true;

                rrM1_4kakuStABC.enabled = kyotuEla.tenmetuOnOff;
                rrM1_4kakuStACB.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_4kakuStBAC.enabled = kyotuEla.tenmetuOnOff;

                rrM1_4kakuStDEF.enabled = kyotuEla.tenmetuOnOff;
                rrM1_4kakuStDFE.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_4kakuStEDF.enabled = kyotuEla.tenmetuOnOff;
            } else if (count == 17) {
                reset();
                //k0018_99_1_1_1://obj.GetComponent<Renderer>().material = ColorPink;
                rrM1_4LineAB.material = MColor1;
                rrM1_4LineCA.material = MColor1;
                rrM1_4LineDE.material = MColor1;
                rrM1_4LineFD.material = MColor1;

                rrM1_4LineStAB.material = MColor2;
                rrM1_4LineStBC.material = MColor5;
                rrM1_4LineStCA.material = MColor4;
                rrM1_4LineStDE.material = MColor2;
                rrM1_4LineStEF.material = MColor5;
                rrM1_4LineStFD.material = MColor4;

                rrM1_4LineAB.enabled = true;
                rrM1_4LineBC.enabled = true;
                rrM1_4LineCA.enabled = true;
                rrM1_4LineDE.enabled = true;
                rrM1_4LineEF.enabled = true;
                rrM1_4LineFD.enabled = true;

                //rrM1_4LineStAB.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_4LineStBC.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_4LineStCA.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_4LineStDE.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_4LineStEF.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_4LineStFD.enabled = kyotuEla.tenmetuOnOff;

                rrM1_4kakuBAC.enabled = true;
                rrM1_4kakuABC.enabled = true;
                rrM1_4kakuACB.enabled = true;

                rrM1_4kakuEDF.enabled = true;
                rrM1_4kakuDEF.enabled = true;
                rrM1_4kakuDFE.enabled = true;

                rrM1_4kakuStABC.enabled = kyotuEla.tenmetuOnOff;
                rrM1_4kakuStACB.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_4kakuStBAC.enabled = kyotuEla.tenmetuOnOff;

                rrM1_4kakuStDEF.enabled = kyotuEla.tenmetuOnOff;
                rrM1_4kakuStDFE.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_4kakuStEDF.enabled = kyotuEla.tenmetuOnOff;
            } else if (count == 18) {//henka18
                reset();
                //k0018_99_1_1_1://obj.GetComponent<Renderer>().material = ColorPink;
                rrM1_4LineAB.material = MColor1;
                rrM1_4LineCA.material = MColor1;
                rrM1_4LineDE.material = MColor1;
                rrM1_4LineFD.material = MColor1;

                rrM1_4LineStAB.material = MColor2;
                rrM1_4LineStBC.material = MColor5;
                rrM1_4LineStCA.material = MColor4;
                rrM1_4LineStDE.material = MColor2;
                rrM1_4LineStEF.material = MColor5;
                rrM1_4LineStFD.material = MColor4;

                
            } else if (count == 19) {//henka19
                reset();
                //k0018_99_1_1_1://obj.GetComponent<Renderer>().material = ColorPink;
                rrM1_4LineAB.material = MColor1;
                rrM1_4LineCA.material = MColor1;
                rrM1_4LineDE.material = MColor1;
                rrM1_4LineFD.material = MColor1;

                rrM1_4LineStAB.material = MColor5;
                rrM1_4LineStBC.material = MColor5;
                rrM1_4LineStCA.material = MColor5;
                rrM1_4LineStDE.material = MColor5;
                rrM1_4LineStEF.material = MColor5;
                rrM1_4LineStFD.material = MColor5;

                rrM1_4LineAB.enabled = true;
                rrM1_4LineBC.enabled = true;
                rrM1_4LineCA.enabled = true;
                rrM1_4LineDE.enabled = true;
                rrM1_4LineEF.enabled = true;
                rrM1_4LineFD.enabled = true;

                rrM1_4LineStAB.enabled = kyotuEla.tenmetuOnOff;
                rrM1_4LineStBC.enabled = kyotuEla.tenmetuOnOff;
                rrM1_4LineStCA.enabled = kyotuEla.tenmetuOnOff;
                rrM1_4LineStDE.enabled = kyotuEla.tenmetuOnOff;
                rrM1_4LineStEF.enabled = kyotuEla.tenmetuOnOff;
                rrM1_4LineStFD.enabled = kyotuEla.tenmetuOnOff;

                //rrM1_4kakuBAC.enabled = true;
                //rrM1_4kakuABC.enabled = true;
                //rrM1_4kakuACB.enabled = true;

                //rrM1_4kakuEDF.enabled = true;
                //rrM1_4kakuDEF.enabled = true;
                //rrM1_4kakuDFE.enabled = true;

                //rrM1_4kakuStABC.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_4kakuStACB.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_4kakuStBAC.enabled = kyotuEla.tenmetuOnOff;

                //rrM1_4kakuStDEF.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_4kakuStDFE.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_4kakuStEDF.enabled = kyotuEla.tenmetuOnOff;
            } else if (count == 20) {//henka20
                reset();
                //k0018_99_1_1_1://obj.GetComponent<Renderer>().material = ColorPink;
                rrM1_4LineAB.material = MColor1;
                rrM1_4LineCA.material = MColor1;
                rrM1_4LineDE.material = MColor1;
                rrM1_4LineFD.material = MColor1;

                rrM1_4LineStAB.material = MColor5;
                rrM1_4LineStBC.material = MColor5;
                rrM1_4LineStCA.material = MColor5;
                rrM1_4LineStDE.material = MColor5;
                rrM1_4LineStEF.material = MColor5;
                rrM1_4LineStFD.material = MColor5;

                rrM1_4TextA.enabled = true;
                rrM1_4TextB.enabled = true;
                rrM1_4TextC.enabled = true;

                rrM1_4PointA.enabled = true;
                rrM1_4PointB.enabled = true;
                rrM1_4PointC.enabled = true;

                rrM1_4LineAB.enabled = true;
                rrM1_4LineBC.enabled = true;
                rrM1_4LineCA.enabled = true;
                rrM1_4LineDE.enabled = true;
                rrM1_4LineEF.enabled = true;
                rrM1_4LineFD.enabled = true;

                rrM1_4LineStAB.enabled = kyotuEla.tenmetuOnOff;
                rrM1_4LineStBC.enabled = kyotuEla.tenmetuOnOff;
                rrM1_4LineStCA.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_4LineStDE.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_4LineStEF.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_4LineStFD.enabled = kyotuEla.tenmetuOnOff;

                //rrM1_4kakuBAC.enabled = true;
                //rrM1_4kakuABC.enabled = true;
                //rrM1_4kakuACB.enabled = true;

                //rrM1_4kakuEDF.enabled = true;
                //rrM1_4kakuDEF.enabled = true;
                //rrM1_4kakuDFE.enabled = true;

                //rrM1_4kakuStABC.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_4kakuStACB.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_4kakuStBAC.enabled = kyotuEla.tenmetuOnOff;

                //rrM1_4kakuStDEF.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_4kakuStDFE.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_4kakuStEDF.enabled = kyotuEla.tenmetuOnOff;
            } else if (count == 21) {//henka21
                reset();
                //k0018_99_1_1_1://obj.GetComponent<Renderer>().material = ColorPink;
                rrM1_4LineAB.material = MColor1;
                rrM1_4LineCA.material = MColor1;
                rrM1_4LineDE.material = MColor1;
                rrM1_4LineFD.material = MColor1;

                rrM1_4LineStAB.material = MColor5;
                rrM1_4LineStBC.material = MColor5;
                rrM1_4LineStCA.material = MColor5;
                rrM1_4LineStDE.material = MColor5;
                rrM1_4LineStEF.material = MColor5;
                rrM1_4LineStFD.material = MColor5;

                rrM1_4TextA.enabled = true;
                rrM1_4TextB.enabled = true;
                rrM1_4TextC.enabled = true;
                rrM1_4TextD.enabled = true;
                rrM1_4TextE.enabled = true;
                rrM1_4TextF.enabled = true;

                rrM1_4PointA.enabled = true;
                rrM1_4PointB.enabled = true;
                rrM1_4PointC.enabled = true;
                rrM1_4PointD.enabled = true;
                rrM1_4PointE.enabled = true;
                rrM1_4PointF.enabled = true;

                rrM1_4LineAB.enabled = true;
                rrM1_4LineBC.enabled = true;
                rrM1_4LineCA.enabled = true;
                rrM1_4LineDE.enabled = true;
                rrM1_4LineEF.enabled = true;
                rrM1_4LineFD.enabled = true;

                //rrM1_4LineStAB.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_4LineStBC.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_4LineStCA.enabled = kyotuEla.tenmetuOnOff;
                rrM1_4LineStDE.enabled = kyotuEla.tenmetuOnOff;
                rrM1_4LineStEF.enabled = kyotuEla.tenmetuOnOff;
                rrM1_4LineStFD.enabled = kyotuEla.tenmetuOnOff;

                //rrM1_4kakuBAC.enabled = true;
                //rrM1_4kakuABC.enabled = true;
                //rrM1_4kakuACB.enabled = true;

                //rrM1_4kakuEDF.enabled = true;
                //rrM1_4kakuDEF.enabled = true;
                //rrM1_4kakuDFE.enabled = true;

                //rrM1_4kakuStABC.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_4kakuStACB.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_4kakuStBAC.enabled = kyotuEla.tenmetuOnOff;

                //rrM1_4kakuStDEF.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_4kakuStDFE.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_4kakuStEDF.enabled = kyotuEla.tenmetuOnOff;
            } else if (count == 22) {//henka22
                reset();
                //k0018_99_1_1_1://obj.GetComponent<Renderer>().material = ColorPink;
                rrM1_4LineAB.material = MColor2;
                rrM1_4LineCA.material = MColor1;
                rrM1_4LineDE.material = MColor1;
                rrM1_4LineFD.material = MColor1;

                rrM1_4LineStAB.material = MColor2;
                rrM1_4LineStBC.material = MColor5;
                rrM1_4LineStCA.material = MColor5;
                rrM1_4LineStDE.material = MColor5;
                rrM1_4LineStEF.material = MColor5;
                rrM1_4LineStFD.material = MColor5;

                rrM1_4TextA.enabled = true;
                rrM1_4TextB.enabled = true;
                rrM1_4TextC.enabled = true;
                rrM1_4TextD.enabled = true;
                rrM1_4TextE.enabled = true;
                rrM1_4TextF.enabled = true;

                rrM1_4PointA.enabled = true;
                rrM1_4PointB.enabled = true;
                rrM1_4PointC.enabled = true;
                rrM1_4PointD.enabled = true;
                rrM1_4PointE.enabled = true;
                rrM1_4PointF.enabled = true;

                rrM1_4LineAB.enabled = true;
                rrM1_4LineBC.enabled = true;
                rrM1_4LineCA.enabled = true;
                rrM1_4LineDE.enabled = true;
                rrM1_4LineEF.enabled = true;
                rrM1_4LineFD.enabled = true;

                rrM1_4LineStAB.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_4LineStBC.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_4LineStCA.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_4LineStDE.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_4LineStEF.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_4LineStFD.enabled = kyotuEla.tenmetuOnOff;

                //rrM1_4kakuBAC.enabled = true;
                //rrM1_4kakuABC.enabled = true;
                //rrM1_4kakuACB.enabled = true;

                //rrM1_4kakuEDF.enabled = true;
                //rrM1_4kakuDEF.enabled = true;
                //rrM1_4kakuDFE.enabled = true;

                //rrM1_4kakuStABC.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_4kakuStACB.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_4kakuStBAC.enabled = kyotuEla.tenmetuOnOff;

                //rrM1_4kakuStDEF.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_4kakuStDFE.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_4kakuStEDF.enabled = kyotuEla.tenmetuOnOff;
            } else if (count == 23) {//henka23
                reset();
                //k0018_99_1_1_1://obj.GetComponent<Renderer>().material = ColorPink;
                rrM1_4LineAB.material = MColor2;
                rrM1_4LineCA.material = MColor4;
                rrM1_4LineDE.material = MColor1;
                rrM1_4LineFD.material = MColor1;

                rrM1_4LineStAB.material = MColor2;
                rrM1_4LineStBC.material = MColor5;
                rrM1_4LineStCA.material = MColor4;
                rrM1_4LineStDE.material = MColor5;
                rrM1_4LineStEF.material = MColor5;
                rrM1_4LineStFD.material = MColor5;

                rrM1_4TextA.enabled = true;
                rrM1_4TextB.enabled = true;
                rrM1_4TextC.enabled = true;
                rrM1_4TextD.enabled = true;
                rrM1_4TextE.enabled = true;
                rrM1_4TextF.enabled = true;

                rrM1_4PointA.enabled = true;
                rrM1_4PointB.enabled = true;
                rrM1_4PointC.enabled = true;
                rrM1_4PointD.enabled = true;
                rrM1_4PointE.enabled = true;
                rrM1_4PointF.enabled = true;

                rrM1_4LineAB.enabled = true;
                rrM1_4LineBC.enabled = true;
                rrM1_4LineCA.enabled = true;
                rrM1_4LineDE.enabled = true;
                rrM1_4LineEF.enabled = true;
                rrM1_4LineFD.enabled = true;

                //rrM1_4LineStAB.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_4LineStBC.enabled = kyotuEla.tenmetuOnOff;
                rrM1_4LineStCA.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_4LineStDE.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_4LineStEF.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_4LineStFD.enabled = kyotuEla.tenmetuOnOff;

                //rrM1_4kakuBAC.enabled = true;
                //rrM1_4kakuABC.enabled = true;
                //rrM1_4kakuACB.enabled = true;

                //rrM1_4kakuEDF.enabled = true;
                //rrM1_4kakuDEF.enabled = true;
                //rrM1_4kakuDFE.enabled = true;

                //rrM1_4kakuStABC.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_4kakuStACB.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_4kakuStBAC.enabled = kyotuEla.tenmetuOnOff;

                //rrM1_4kakuStDEF.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_4kakuStDFE.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_4kakuStEDF.enabled = kyotuEla.tenmetuOnOff;
            } else if (count == 24) {//henka24
                reset();
                //k0018_99_1_1_1://obj.GetComponent<Renderer>().material = ColorPink;
                rrM1_4LineAB.material = MColor2;
                rrM1_4LineCA.material = MColor4;
                rrM1_4LineDE.material = MColor2;
                rrM1_4LineFD.material = MColor1;

                rrM1_4LineStAB.material = MColor2;
                rrM1_4LineStBC.material = MColor5;
                rrM1_4LineStCA.material = MColor4;
                rrM1_4LineStDE.material = MColor2;
                rrM1_4LineStEF.material = MColor5;
                rrM1_4LineStFD.material = MColor4;

                rrM1_4TextA.enabled = true;
                rrM1_4TextB.enabled = true;
                rrM1_4TextC.enabled = true;
                rrM1_4TextD.enabled = true;
                rrM1_4TextE.enabled = true;
                rrM1_4TextF.enabled = true;

                rrM1_4PointA.enabled = true;
                rrM1_4PointB.enabled = true;
                rrM1_4PointC.enabled = true;
                rrM1_4PointD.enabled = true;
                rrM1_4PointE.enabled = true;
                rrM1_4PointF.enabled = true;

                rrM1_4LineAB.enabled = true;
                rrM1_4LineBC.enabled = true;
                rrM1_4LineCA.enabled = true;
                rrM1_4LineDE.enabled = true;
                rrM1_4LineEF.enabled = true;
                rrM1_4LineFD.enabled = true;

                //rrM1_4LineStAB.enabled = kyotuEla.tenmetuOnOff;
                rrM1_4LineStAB.enabled = true;

                //rrM1_4LineStBC.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_4LineStCA.enabled = kyotuEla.tenmetuOnOff;
                rrM1_4LineStDE.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_4LineStEF.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_4LineStFD.enabled = kyotuEla.tenmetuOnOff;

                //rrM1_4kakuBAC.enabled = true;
                //rrM1_4kakuABC.enabled = true;
                //rrM1_4kakuACB.enabled = true;

                //rrM1_4kakuEDF.enabled = true;
                //rrM1_4kakuDEF.enabled = true;
                //rrM1_4kakuDFE.enabled = true;

                //rrM1_4kakuStABC.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_4kakuStACB.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_4kakuStBAC.enabled = kyotuEla.tenmetuOnOff;

                //rrM1_4kakuStDEF.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_4kakuStDFE.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_4kakuStEDF.enabled = kyotuEla.tenmetuOnOff;
            } else if (count == 25) {//henka25
                reset();
                //k0018_99_1_1_1://obj.GetComponent<Renderer>().material = ColorPink;
                rrM1_4LineAB.material = MColor2;
                rrM1_4LineCA.material = MColor4;
                rrM1_4LineDE.material = MColor2;
                rrM1_4LineFD.material = MColor4;

                rrM1_4LineStAB.material = MColor2;
                rrM1_4LineStBC.material = MColor5;
                rrM1_4LineStCA.material = MColor4;
                rrM1_4LineStDE.material = MColor2;
                rrM1_4LineStEF.material = MColor5;
                rrM1_4LineStFD.material = MColor4;

                rrM1_4TextA.enabled = true;
                rrM1_4TextB.enabled = true;
                rrM1_4TextC.enabled = true;
                rrM1_4TextD.enabled = true;
                rrM1_4TextE.enabled = true;
                rrM1_4TextF.enabled = true;

                rrM1_4PointA.enabled = true;
                rrM1_4PointB.enabled = true;
                rrM1_4PointC.enabled = true;
                rrM1_4PointD.enabled = true;
                rrM1_4PointE.enabled = true;
                rrM1_4PointF.enabled = true;

                rrM1_4LineAB.enabled = true;
                rrM1_4LineBC.enabled = true;
                rrM1_4LineCA.enabled = true;
                rrM1_4LineDE.enabled = true;
                rrM1_4LineEF.enabled = true;
                rrM1_4LineFD.enabled = true;

                //rrM1_4LineStAB.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_4LineStAB.enabled = true;

                //rrM1_4LineStBC.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_4LineStCA.enabled = kyotuEla.tenmetuOnOff;
                rrM1_4LineStCA.enabled = true;

                //rrM1_4LineStDE.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_4LineStEF.enabled = kyotuEla.tenmetuOnOff;
                rrM1_4LineStFD.enabled = kyotuEla.tenmetuOnOff;

                //rrM1_4kakuBAC.enabled = true;
                //rrM1_4kakuABC.enabled = true;
                //rrM1_4kakuACB.enabled = true;

                //rrM1_4kakuEDF.enabled = true;
                //rrM1_4kakuDEF.enabled = true;
                //rrM1_4kakuDFE.enabled = true;

                //rrM1_4kakuStABC.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_4kakuStACB.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_4kakuStBAC.enabled = kyotuEla.tenmetuOnOff;

                //rrM1_4kakuStDEF.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_4kakuStDFE.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_4kakuStEDF.enabled = kyotuEla.tenmetuOnOff;
            } else if (count == 26) {//henka26
                reset();
                //k0018_99_1_1_1://obj.GetComponent<Renderer>().material = ColorPink;
                rrM1_4LineAB.material = MColor2;
                rrM1_4LineCA.material = MColor4;
                rrM1_4LineDE.material = MColor2;
                rrM1_4LineFD.material = MColor4;

                rrM1_4LineStAB.material = MColor2;
                rrM1_4LineStBC.material = MColor5;
                rrM1_4LineStCA.material = MColor4;
                rrM1_4LineStDE.material = MColor2;
                rrM1_4LineStEF.material = MColor5;
                rrM1_4LineStFD.material = MColor4;

                rrM1_4TextA.enabled = true;
                rrM1_4TextB.enabled = true;
                rrM1_4TextC.enabled = true;
                rrM1_4TextD.enabled = true;
                rrM1_4TextE.enabled = true;
                rrM1_4TextF.enabled = true;

                rrM1_4PointA.enabled = true;
                rrM1_4PointB.enabled = true;
                rrM1_4PointC.enabled = true;
                rrM1_4PointD.enabled = true;
                rrM1_4PointE.enabled = true;
                rrM1_4PointF.enabled = true;

                rrM1_4LineAB.enabled = true;
                rrM1_4LineBC.enabled = true;
                rrM1_4LineCA.enabled = true;
                rrM1_4LineDE.enabled = true;
                rrM1_4LineEF.enabled = true;
                rrM1_4LineFD.enabled = true;

                rrM1_4LineStAB.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_4LineStAB.enabled = true;

                //rrM1_4LineStBC.enabled = kyotuEla.tenmetuOnOff;
                rrM1_4LineStCA.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_4LineStCA.enabled = true;

                rrM1_4LineStDE.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_4LineStEF.enabled = kyotuEla.tenmetuOnOff;
                rrM1_4LineStFD.enabled = kyotuEla.tenmetuOnOff;

                //rrM1_4kakuBAC.enabled = true;
                //rrM1_4kakuABC.enabled = true;
                //rrM1_4kakuACB.enabled = true;

                //rrM1_4kakuEDF.enabled = true;
                //rrM1_4kakuDEF.enabled = true;
                //rrM1_4kakuDFE.enabled = true;

                //rrM1_4kakuStABC.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_4kakuStACB.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_4kakuStBAC.enabled = kyotuEla.tenmetuOnOff;

                //rrM1_4kakuStDEF.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_4kakuStDFE.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_4kakuStEDF.enabled = kyotuEla.tenmetuOnOff;
            } else if (count == 27) {//henka27
                reset();
                //k0018_99_1_1_1://obj.GetComponent<Renderer>().material = ColorPink;
                rrM1_4LineAB.material = MColor2;
                rrM1_4LineCA.material = MColor4;
                rrM1_4LineDE.material = MColor2;
                rrM1_4LineFD.material = MColor4;

                rrM1_4LineStAB.material = MColor2;
                rrM1_4LineStBC.material = MColor5;
                rrM1_4LineStCA.material = MColor4;
                rrM1_4LineStDE.material = MColor2;
                rrM1_4LineStEF.material = MColor5;
                rrM1_4LineStFD.material = MColor4;

                rrM1_4TextA.enabled = true;
                rrM1_4TextB.enabled = true;
                rrM1_4TextC.enabled = true;
                rrM1_4TextD.enabled = true;
                rrM1_4TextE.enabled = true;
                rrM1_4TextF.enabled = true;

                rrM1_4PointA.enabled = true;
                rrM1_4PointB.enabled = true;
                rrM1_4PointC.enabled = true;
                rrM1_4PointD.enabled = true;
                rrM1_4PointE.enabled = true;
                rrM1_4PointF.enabled = true;

                rrM1_4LineAB.enabled = true;
                rrM1_4LineBC.enabled = true;
                rrM1_4LineCA.enabled = true;
                rrM1_4LineDE.enabled = true;
                rrM1_4LineEF.enabled = true;
                rrM1_4LineFD.enabled = true;

                //rrM1_4LineStAB.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_4LineStAB.enabled = true;

                //rrM1_4LineStBC.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_4LineStCA.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_4LineStCA.enabled = true;

                //rrM1_4LineStDE.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_4LineStEF.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_4LineStFD.enabled = kyotuEla.tenmetuOnOff;

                rrM1_4kakuBAC.enabled = true;
                //rrM1_4kakuABC.enabled = true;
                //rrM1_4kakuACB.enabled = true;

                //rrM1_4kakuEDF.enabled = true;
                //rrM1_4kakuDEF.enabled = true;
                //rrM1_4kakuDFE.enabled = true;

                //rrM1_4kakuStABC.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_4kakuStACB.enabled = kyotuEla.tenmetuOnOff;
                rrM1_4kakuStBAC.enabled = kyotuEla.tenmetuOnOff;

                //rrM1_4kakuStDEF.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_4kakuStDFE.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_4kakuStEDF.enabled = kyotuEla.tenmetuOnOff;
            } else if (count == 28) {//henka28
                reset();
                //k0018_99_1_1_1://obj.GetComponent<Renderer>().material = ColorPink;
                rrM1_4LineAB.material = MColor2;
                rrM1_4LineCA.material = MColor4;
                rrM1_4LineDE.material = MColor2;
                rrM1_4LineFD.material = MColor4;

                rrM1_4LineStAB.material = MColor2;
                rrM1_4LineStBC.material = MColor5;
                rrM1_4LineStCA.material = MColor4;
                rrM1_4LineStDE.material = MColor2;
                rrM1_4LineStEF.material = MColor5;
                rrM1_4LineStFD.material = MColor4;

                rrM1_4TextA.enabled = true;
                rrM1_4TextB.enabled = true;
                rrM1_4TextC.enabled = true;
                rrM1_4TextD.enabled = true;
                rrM1_4TextE.enabled = true;
                rrM1_4TextF.enabled = true;

                rrM1_4PointA.enabled = true;
                rrM1_4PointB.enabled = true;
                rrM1_4PointC.enabled = true;
                rrM1_4PointD.enabled = true;
                rrM1_4PointE.enabled = true;
                rrM1_4PointF.enabled = true;

                rrM1_4LineAB.enabled = true;
                rrM1_4LineBC.enabled = true;
                rrM1_4LineCA.enabled = true;
                rrM1_4LineDE.enabled = true;
                rrM1_4LineEF.enabled = true;
                rrM1_4LineFD.enabled = true;

                //rrM1_4LineStAB.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_4LineStAB.enabled = true;

                //rrM1_4LineStBC.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_4LineStCA.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_4LineStCA.enabled = true;

                //rrM1_4LineStDE.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_4LineStEF.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_4LineStFD.enabled = kyotuEla.tenmetuOnOff;

                rrM1_4kakuBAC.enabled = true;
                //rrM1_4kakuABC.enabled = true;
                //rrM1_4kakuACB.enabled = true;

                rrM1_4kakuEDF.enabled = true;
                //rrM1_4kakuDEF.enabled = true;
                //rrM1_4kakuDFE.enabled = true;

                //rrM1_4kakuStABC.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_4kakuStACB.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_4kakuStBAC.enabled = kyotuEla.tenmetuOnOff;
                rrM1_4kakuStBAC.enabled = true;

                //rrM1_4kakuStDEF.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_4kakuStDFE.enabled = kyotuEla.tenmetuOnOff;
                rrM1_4kakuStEDF.enabled = kyotuEla.tenmetuOnOff;
            } else if (count == 29) {//henka29
                reset();
                //k0018_99_1_1_1://obj.GetComponent<Renderer>().material = ColorPink;
                rrM1_4LineAB.material = MColor2;
                rrM1_4LineCA.material = MColor4;
                rrM1_4LineDE.material = MColor2;
                rrM1_4LineFD.material = MColor4;

                rrM1_4LineStAB.material = MColor2;
                rrM1_4LineStBC.material = MColor5;
                rrM1_4LineStCA.material = MColor4;
                rrM1_4LineStDE.material = MColor2;
                rrM1_4LineStEF.material = MColor5;
                rrM1_4LineStFD.material = MColor4;

                rrM1_4TextA.enabled = true;
                rrM1_4TextB.enabled = true;
                rrM1_4TextC.enabled = true;
                rrM1_4TextD.enabled = true;
                rrM1_4TextE.enabled = true;
                rrM1_4TextF.enabled = true;

                rrM1_4PointA.enabled = true;
                rrM1_4PointB.enabled = true;
                rrM1_4PointC.enabled = true;
                rrM1_4PointD.enabled = true;
                rrM1_4PointE.enabled = true;
                rrM1_4PointF.enabled = true;

                rrM1_4LineAB.enabled = true;
                rrM1_4LineBC.enabled = true;
                rrM1_4LineCA.enabled = true;
                rrM1_4LineDE.enabled = true;
                rrM1_4LineEF.enabled = true;
                rrM1_4LineFD.enabled = true;

                //rrM1_4LineStAB.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_4LineStAB.enabled = true;

                //rrM1_4LineStBC.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_4LineStCA.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_4LineStCA.enabled = true;

                //rrM1_4LineStDE.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_4LineStEF.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_4LineStFD.enabled = kyotuEla.tenmetuOnOff;

                rrM1_4kakuBAC.enabled = true;
                //rrM1_4kakuABC.enabled = true;
                //rrM1_4kakuACB.enabled = true;

                rrM1_4kakuEDF.enabled = true;
                //rrM1_4kakuDEF.enabled = true;
                //rrM1_4kakuDFE.enabled = true;

                //rrM1_4kakuStABC.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_4kakuStACB.enabled = kyotuEla.tenmetuOnOff;
                rrM1_4kakuStBAC.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_4kakuStBAC.enabled = true;

                //rrM1_4kakuStDEF.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_4kakuStDFE.enabled = kyotuEla.tenmetuOnOff;
                rrM1_4kakuStEDF.enabled = kyotuEla.tenmetuOnOff;
            } else if (count == 30) {//henka30
                reset();
                //k0018_99_1_1_1://obj.GetComponent<Renderer>().material = ColorPink;
                rrM1_4LineAB.material = MColor2;
                rrM1_4LineCA.material = MColor4;
                rrM1_4LineDE.material = MColor2;
                rrM1_4LineFD.material = MColor4;

                rrM1_4LineStAB.material = MColor2;
                rrM1_4LineStBC.material = MColor5;
                rrM1_4LineStCA.material = MColor4;
                rrM1_4LineStDE.material = MColor2;
                rrM1_4LineStEF.material = MColor5;
                rrM1_4LineStFD.material = MColor4;

                rrM1_4TextA.enabled = true;
                rrM1_4TextB.enabled = true;
                rrM1_4TextC.enabled = true;
                rrM1_4TextD.enabled = true;
                rrM1_4TextE.enabled = true;
                rrM1_4TextF.enabled = true;

                rrM1_4PointA.enabled = true;
                rrM1_4PointB.enabled = true;
                rrM1_4PointC.enabled = true;
                rrM1_4PointD.enabled = true;
                rrM1_4PointE.enabled = true;
                rrM1_4PointF.enabled = true;

                rrM1_4LineAB.enabled = true;
                rrM1_4LineBC.enabled = true;
                rrM1_4LineCA.enabled = true;
                rrM1_4LineDE.enabled = true;
                rrM1_4LineEF.enabled = true;
                rrM1_4LineFD.enabled = true;

                //rrM1_4LineStAB.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_4LineStAB.enabled = true;

                //rrM1_4LineStBC.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_4LineStCA.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_4LineStCA.enabled = true;

                //rrM1_4LineStDE.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_4LineStEF.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_4LineStFD.enabled = kyotuEla.tenmetuOnOff;

                rrM1_4kakuBAC.enabled = true;
                //rrM1_4kakuABC.enabled = true;
                //rrM1_4kakuACB.enabled = true;

                rrM1_4kakuEDF.enabled = true;
                //rrM1_4kakuDEF.enabled = true;
                //rrM1_4kakuDFE.enabled = true;

                //rrM1_4kakuStABC.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_4kakuStACB.enabled = kyotuEla.tenmetuOnOff;
                rrM1_4kakuStBAC.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_4kakuStBAC.enabled = true;

                //rrM1_4kakuStDEF.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_4kakuStDFE.enabled = kyotuEla.tenmetuOnOff;
                rrM1_4kakuStEDF.enabled = kyotuEla.tenmetuOnOff;
            } else if (count == 31) {//henka31
                reset();
                //k0018_99_1_1_1://obj.GetComponent<Renderer>().material = ColorPink;
                rrM1_4LineAB.material = MColor2;
                rrM1_4LineCA.material = MColor4;
                rrM1_4LineDE.material = MColor2;
                rrM1_4LineFD.material = MColor4;

                rrM1_4LineStAB.material = MColor2;
                rrM1_4LineStBC.material = MColor1;
                rrM1_4LineStCA.material = MColor4;
                rrM1_4LineStDE.material = MColor2;
                rrM1_4LineStEF.material = MColor1;
                rrM1_4LineStFD.material = MColor4;

                rrM1_4TextA.enabled = true;
                rrM1_4TextB.enabled = true;
                rrM1_4TextC.enabled = true;
                rrM1_4TextD.enabled = true;
                rrM1_4TextE.enabled = true;
                rrM1_4TextF.enabled = true;

                rrM1_4PointA.enabled = true;
                rrM1_4PointB.enabled = true;
                rrM1_4PointC.enabled = true;
                rrM1_4PointD.enabled = true;
                rrM1_4PointE.enabled = true;
                rrM1_4PointF.enabled = true;

                rrM1_4LineAB.enabled = true;
                rrM1_4LineBC.enabled = true;
                rrM1_4LineCA.enabled = true;
                rrM1_4LineDE.enabled = true;
                rrM1_4LineEF.enabled = true;
                rrM1_4LineFD.enabled = true;

                //rrM1_4LineStAB.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_4LineStAB.enabled = true;

                rrM1_4LineStBC.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_4LineStCA.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_4LineStCA.enabled = true;

                //rrM1_4LineStDE.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_4LineStEF.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_4LineStFD.enabled = kyotuEla.tenmetuOnOff;

                rrM1_4kakuBAC.enabled = true;
                //rrM1_4kakuABC.enabled = true;
                //rrM1_4kakuACB.enabled = true;

                rrM1_4kakuEDF.enabled = true;
                //rrM1_4kakuDEF.enabled = true;
                //rrM1_4kakuDFE.enabled = true;

                //rrM1_4kakuStABC.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_4kakuStACB.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_4kakuStBAC.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_4kakuStBAC.enabled = true;

                //rrM1_4kakuStDEF.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_4kakuStDFE.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_4kakuStEDF.enabled = kyotuEla.tenmetuOnOff;
            } else if (count == 32) {//henka32
                reset();
                //k0018_99_1_1_1://obj.GetComponent<Renderer>().material = ColorPink;
                rrM1_4LineAB.material = MColor2;
                rrM1_4LineCA.material = MColor4;
                rrM1_4LineDE.material = MColor2;
                rrM1_4LineFD.material = MColor4;

                rrM1_4LineStAB.material = MColor2;
                rrM1_4LineStBC.material = MColor1;
                rrM1_4LineStCA.material = MColor4;
                rrM1_4LineStDE.material = MColor2;
                rrM1_4LineStEF.material = MColor1;
                rrM1_4LineStFD.material = MColor4;

                rrM1_4TextA.enabled = true;
                rrM1_4TextB.enabled = true;
                rrM1_4TextC.enabled = true;
                rrM1_4TextD.enabled = true;
                rrM1_4TextE.enabled = true;
                rrM1_4TextF.enabled = true;

                rrM1_4PointA.enabled = true;
                rrM1_4PointB.enabled = true;
                rrM1_4PointC.enabled = true;
                rrM1_4PointD.enabled = true;
                rrM1_4PointE.enabled = true;
                rrM1_4PointF.enabled = true;

                rrM1_4LineAB.enabled = true;
                rrM1_4LineBC.enabled = true;
                rrM1_4LineCA.enabled = true;
                rrM1_4LineDE.enabled = true;
                rrM1_4LineEF.enabled = true;
                rrM1_4LineFD.enabled = true;

                //rrM1_4LineStAB.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_4LineStAB.enabled = true;

                //rrM1_4LineStBC.enabled = kyotuEla.tenmetuOnOff;
                rrM1_4LineStBC.enabled = true;
                //rrM1_4LineStCA.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_4LineStCA.enabled = true;

                //rrM1_4LineStDE.enabled = kyotuEla.tenmetuOnOff;
                rrM1_4LineStEF.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_4LineStFD.enabled = kyotuEla.tenmetuOnOff;

                rrM1_4kakuBAC.enabled = true;
                //rrM1_4kakuABC.enabled = true;
                //rrM1_4kakuACB.enabled = true;

                rrM1_4kakuEDF.enabled = true;
                //rrM1_4kakuDEF.enabled = true;
                //rrM1_4kakuDFE.enabled = true;

                //rrM1_4kakuStABC.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_4kakuStACB.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_4kakuStBAC.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_4kakuStBAC.enabled = true;

                //rrM1_4kakuStDEF.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_4kakuStDFE.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_4kakuStEDF.enabled = kyotuEla.tenmetuOnOff;
            } else if (count == 33) {//henka33
                reset();
                //k0018_99_1_1_1://obj.GetComponent<Renderer>().material = ColorPink;
                rrM1_4LineAB.material = MColor2;
                rrM1_4LineCA.material = MColor4;
                rrM1_4LineDE.material = MColor2;
                rrM1_4LineFD.material = MColor4;

                rrM1_4LineStAB.material = MColor2;
                rrM1_4LineStBC.material = MColor1;
                rrM1_4LineStCA.material = MColor4;
                rrM1_4LineStDE.material = MColor2;
                rrM1_4LineStEF.material = MColor1;
                rrM1_4LineStFD.material = MColor4;

                rrM1_4TextA.enabled = true;
                rrM1_4TextB.enabled = true;
                rrM1_4TextC.enabled = true;
                rrM1_4TextD.enabled = true;
                rrM1_4TextE.enabled = true;
                rrM1_4TextF.enabled = true;

                rrM1_4PointA.enabled = true;
                rrM1_4PointB.enabled = true;
                rrM1_4PointC.enabled = true;
                rrM1_4PointD.enabled = true;
                rrM1_4PointE.enabled = true;
                rrM1_4PointF.enabled = true;

                rrM1_4LineAB.enabled = true;
                rrM1_4LineBC.enabled = true;
                rrM1_4LineCA.enabled = true;
                rrM1_4LineDE.enabled = true;
                rrM1_4LineEF.enabled = true;
                rrM1_4LineFD.enabled = true;

                //rrM1_4LineStAB.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_4LineStAB.enabled = true;

                rrM1_4LineStBC.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_4LineStBC.enabled = true;
                //rrM1_4LineStCA.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_4LineStCA.enabled = true;

                //rrM1_4LineStDE.enabled = kyotuEla.tenmetuOnOff;
                rrM1_4LineStEF.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_4LineStFD.enabled = kyotuEla.tenmetuOnOff;

                rrM1_4kakuBAC.enabled = true;
                //rrM1_4kakuABC.enabled = true;
                //rrM1_4kakuACB.enabled = true;

                rrM1_4kakuEDF.enabled = true;
                //rrM1_4kakuDEF.enabled = true;
                //rrM1_4kakuDFE.enabled = true;

                //rrM1_4kakuStABC.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_4kakuStACB.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_4kakuStBAC.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_4kakuStBAC.enabled = true;

                //rrM1_4kakuStDEF.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_4kakuStDFE.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_4kakuStEDF.enabled = kyotuEla.tenmetuOnOff;
            } else if (count == 34) {//henka34
                reset();
                //k0018_99_1_1_1://obj.GetComponent<Renderer>().material = ColorPink;
                rrM1_4LineAB.material = MColor2;
                rrM1_4LineCA.material = MColor4;
                rrM1_4LineDE.material = MColor2;
                rrM1_4LineFD.material = MColor4;

                rrM1_4LineStAB.material = MColor2;
                rrM1_4LineStBC.material = MColor1;
                rrM1_4LineStCA.material = MColor4;
                rrM1_4LineStDE.material = MColor2;
                rrM1_4LineStEF.material = MColor1;
                rrM1_4LineStFD.material = MColor4;

                rrM1_4TextA.enabled = true;
                rrM1_4TextB.enabled = true;
                rrM1_4TextC.enabled = true;
                rrM1_4TextD.enabled = true;
                rrM1_4TextE.enabled = true;
                rrM1_4TextF.enabled = true;

                rrM1_4PointA.enabled = true;
                rrM1_4PointB.enabled = true;
                rrM1_4PointC.enabled = true;
                rrM1_4PointD.enabled = true;
                rrM1_4PointE.enabled = true;
                rrM1_4PointF.enabled = true;

                rrM1_4LineAB.enabled = true;
                rrM1_4LineBC.enabled = true;
                rrM1_4LineCA.enabled = true;
                rrM1_4LineDE.enabled = true;
                rrM1_4LineEF.enabled = true;
                rrM1_4LineFD.enabled = true;

                //rrM1_4LineStAB.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_4LineStAB.enabled = true;

                //rrM1_4LineStBC.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_4LineStBC.enabled = true;
                //rrM1_4LineStCA.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_4LineStCA.enabled = true;

                //rrM1_4LineStDE.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_4LineStEF.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_4LineStFD.enabled = kyotuEla.tenmetuOnOff;

                rrM1_4kakuBAC.enabled = true;
                rrM1_4kakuABC.enabled = true;
                //rrM1_4kakuACB.enabled = true;

                rrM1_4kakuEDF.enabled = true;
                //rrM1_4kakuDEF.enabled = true;
                //rrM1_4kakuDFE.enabled = true;

                rrM1_4kakuStABC.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_4kakuStACB.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_4kakuStBAC.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_4kakuStBAC.enabled = true;

                //rrM1_4kakuStDEF.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_4kakuStDFE.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_4kakuStEDF.enabled = kyotuEla.tenmetuOnOff;
            } else if (count == 35) {//henka35
                reset();
                //k0018_99_1_1_1://obj.GetComponent<Renderer>().material = ColorPink;
                rrM1_4LineAB.material = MColor2;
                rrM1_4LineCA.material = MColor4;
                rrM1_4LineDE.material = MColor2;
                rrM1_4LineFD.material = MColor4;

                rrM1_4LineStAB.material = MColor2;
                rrM1_4LineStBC.material = MColor1;
                rrM1_4LineStCA.material = MColor4;
                rrM1_4LineStDE.material = MColor2;
                rrM1_4LineStEF.material = MColor1;
                rrM1_4LineStFD.material = MColor4;

                rrM1_4TextA.enabled = true;
                rrM1_4TextB.enabled = true;
                rrM1_4TextC.enabled = true;
                rrM1_4TextD.enabled = true;
                rrM1_4TextE.enabled = true;
                rrM1_4TextF.enabled = true;

                rrM1_4PointA.enabled = true;
                rrM1_4PointB.enabled = true;
                rrM1_4PointC.enabled = true;
                rrM1_4PointD.enabled = true;
                rrM1_4PointE.enabled = true;
                rrM1_4PointF.enabled = true;

                rrM1_4LineAB.enabled = true;
                rrM1_4LineBC.enabled = true;
                rrM1_4LineCA.enabled = true;
                rrM1_4LineDE.enabled = true;
                rrM1_4LineEF.enabled = true;
                rrM1_4LineFD.enabled = true;

                //rrM1_4LineStAB.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_4LineStAB.enabled = true;

                //rrM1_4LineStBC.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_4LineStBC.enabled = true;
                //rrM1_4LineStCA.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_4LineStCA.enabled = true;

                //rrM1_4LineStDE.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_4LineStEF.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_4LineStFD.enabled = kyotuEla.tenmetuOnOff;

                rrM1_4kakuBAC.enabled = true;
                rrM1_4kakuABC.enabled = true;
                //rrM1_4kakuACB.enabled = true;

                rrM1_4kakuEDF.enabled = true;
                rrM1_4kakuDEF.enabled = true;
                //rrM1_4kakuDFE.enabled = true;

                //rrM1_4kakuStABC.enabled = kyotuEla.tenmetuOnOff;
                rrM1_4kakuStABC.enabled = true;

                //rrM1_4kakuStACB.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_4kakuStBAC.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_4kakuStBAC.enabled = true;

                rrM1_4kakuStDEF.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_4kakuStDFE.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_4kakuStEDF.enabled = kyotuEla.tenmetuOnOff;
            } else if (count == 36) {//henka36
                reset();
                //k0018_99_1_1_1://obj.GetComponent<Renderer>().material = ColorPink;
                rrM1_4LineAB.material = MColor2;
                rrM1_4LineCA.material = MColor4;
                rrM1_4LineDE.material = MColor2;
                rrM1_4LineFD.material = MColor4;

                rrM1_4LineStAB.material = MColor2;
                rrM1_4LineStBC.material = MColor1;
                rrM1_4LineStCA.material = MColor4;
                rrM1_4LineStDE.material = MColor2;
                rrM1_4LineStEF.material = MColor1;
                rrM1_4LineStFD.material = MColor4;

                rrM1_4TextA.enabled = true;
                rrM1_4TextB.enabled = true;
                rrM1_4TextC.enabled = true;
                rrM1_4TextD.enabled = true;
                rrM1_4TextE.enabled = true;
                rrM1_4TextF.enabled = true;

                rrM1_4PointA.enabled = true;
                rrM1_4PointB.enabled = true;
                rrM1_4PointC.enabled = true;
                rrM1_4PointD.enabled = true;
                rrM1_4PointE.enabled = true;
                rrM1_4PointF.enabled = true;

                rrM1_4LineAB.enabled = true;
                rrM1_4LineBC.enabled = true;
                rrM1_4LineCA.enabled = true;
                rrM1_4LineDE.enabled = true;
                rrM1_4LineEF.enabled = true;
                rrM1_4LineFD.enabled = true;

                //rrM1_4LineStAB.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_4LineStAB.enabled = true;

                //rrM1_4LineStBC.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_4LineStBC.enabled = true;
                //rrM1_4LineStCA.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_4LineStCA.enabled = true;

                //rrM1_4LineStDE.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_4LineStEF.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_4LineStFD.enabled = kyotuEla.tenmetuOnOff;

                rrM1_4kakuBAC.enabled = true;
                rrM1_4kakuABC.enabled = true;
                rrM1_4kakuACB.enabled = true;

                rrM1_4kakuEDF.enabled = true;
                rrM1_4kakuDEF.enabled = true;
                //rrM1_4kakuDFE.enabled = true;

                //rrM1_4kakuStABC.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_4kakuStABC.enabled = true;

                rrM1_4kakuStACB.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_4kakuStBAC.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_4kakuStBAC.enabled = true;

                //rrM1_4kakuStDEF.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_4kakuStDFE.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_4kakuStEDF.enabled = kyotuEla.tenmetuOnOff;
            } else if (count == 37) {//henka37
                reset();
                //k0018_99_1_1_1://obj.GetComponent<Renderer>().material = ColorPink;
                rrM1_4LineAB.material = MColor2;
                rrM1_4LineCA.material = MColor4;
                rrM1_4LineDE.material = MColor2;
                rrM1_4LineFD.material = MColor4;

                rrM1_4LineStAB.material = MColor2;
                rrM1_4LineStBC.material = MColor1;
                rrM1_4LineStCA.material = MColor4;
                rrM1_4LineStDE.material = MColor2;
                rrM1_4LineStEF.material = MColor1;
                rrM1_4LineStFD.material = MColor4;

                rrM1_4TextA.enabled = true;
                rrM1_4TextB.enabled = true;
                rrM1_4TextC.enabled = true;
                rrM1_4TextD.enabled = true;
                rrM1_4TextE.enabled = true;
                rrM1_4TextF.enabled = true;

                rrM1_4PointA.enabled = true;
                rrM1_4PointB.enabled = true;
                rrM1_4PointC.enabled = true;
                rrM1_4PointD.enabled = true;
                rrM1_4PointE.enabled = true;
                rrM1_4PointF.enabled = true;

                rrM1_4LineAB.enabled = true;
                rrM1_4LineBC.enabled = true;
                rrM1_4LineCA.enabled = true;
                rrM1_4LineDE.enabled = true;
                rrM1_4LineEF.enabled = true;
                rrM1_4LineFD.enabled = true;

                //rrM1_4LineStAB.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_4LineStAB.enabled = true;

                //rrM1_4LineStBC.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_4LineStBC.enabled = true;
                //rrM1_4LineStCA.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_4LineStCA.enabled = true;

                //rrM1_4LineStDE.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_4LineStEF.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_4LineStFD.enabled = kyotuEla.tenmetuOnOff;

                rrM1_4kakuBAC.enabled = true;
                rrM1_4kakuABC.enabled = true;
                rrM1_4kakuACB.enabled = true;

                rrM1_4kakuEDF.enabled = true;
                rrM1_4kakuDEF.enabled = true;
                rrM1_4kakuDFE.enabled = true;

                //rrM1_4kakuStABC.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_4kakuStABC.enabled = true;

                //rrM1_4kakuStACB.enabled = kyotuEla.tenmetuOnOff;
                rrM1_4kakuStACB.enabled = true;
                //rrM1_4kakuStBAC.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_4kakuStBAC.enabled = true;

                //rrM1_4kakuStDEF.enabled = kyotuEla.tenmetuOnOff;
                rrM1_4kakuStDFE.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_4kakuStEDF.enabled = kyotuEla.tenmetuOnOff;
            } else if (count == 38) {//henka38
                reset();
                //k0018_99_1_1_1://obj.GetComponent<Renderer>().material = ColorPink;
                rrM1_4LineAB.material = MColor2;
                rrM1_4LineCA.material = MColor4;
                rrM1_4LineDE.material = MColor2;
                rrM1_4LineFD.material = MColor4;

                rrM1_4LineStAB.material = MColor2;
                rrM1_4LineStBC.material = MColor1;
                rrM1_4LineStCA.material = MColor4;
                rrM1_4LineStDE.material = MColor2;
                rrM1_4LineStEF.material = MColor1;
                rrM1_4LineStFD.material = MColor4;

                rrM1_4TextA.enabled = true;
                rrM1_4TextB.enabled = true;
                rrM1_4TextC.enabled = true;
                rrM1_4TextD.enabled = true;
                rrM1_4TextE.enabled = true;
                rrM1_4TextF.enabled = true;

                rrM1_4PointA.enabled = true;
                rrM1_4PointB.enabled = true;
                rrM1_4PointC.enabled = true;
                rrM1_4PointD.enabled = true;
                rrM1_4PointE.enabled = true;
                rrM1_4PointF.enabled = true;

                rrM1_4LineAB.enabled = true;
                rrM1_4LineBC.enabled = true;
                rrM1_4LineCA.enabled = true;
                rrM1_4LineDE.enabled = true;
                rrM1_4LineEF.enabled = true;
                rrM1_4LineFD.enabled = true;

                //rrM1_4LineStAB.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_4LineStAB.enabled = true;

                //rrM1_4LineStBC.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_4LineStBC.enabled = true;
                //rrM1_4LineStCA.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_4LineStCA.enabled = true;

                //rrM1_4LineStDE.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_4LineStEF.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_4LineStFD.enabled = kyotuEla.tenmetuOnOff;

                rrM1_4kakuBAC.enabled = true;
                rrM1_4kakuABC.enabled = true;
                rrM1_4kakuACB.enabled = true;

                rrM1_4kakuEDF.enabled = true;
                rrM1_4kakuDEF.enabled = true;
                rrM1_4kakuDFE.enabled = true;

                rrM1_4kakuStABC.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_4kakuStABC.enabled = true;

                rrM1_4kakuStACB.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_4kakuStACB.enabled = true;
                //rrM1_4kakuStBAC.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_4kakuStBAC.enabled = true;

                rrM1_4kakuStDEF.enabled = kyotuEla.tenmetuOnOff;
                rrM1_4kakuStDFE.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_4kakuStEDF.enabled = kyotuEla.tenmetuOnOff;
            } else if (count == 39) {//henka39
                reset();
                //k0018_99_1_1_1://obj.GetComponent<Renderer>().material = ColorPink;
                rrM1_4LineAB.material = MColor2;
                rrM1_4LineCA.material = MColor4;
                rrM1_4LineDE.material = MColor2;
                rrM1_4LineFD.material = MColor4;

                rrM1_4LineStAB.material = MColor2;
                rrM1_4LineStBC.material = MColor5;
                rrM1_4LineStCA.material = MColor4;
                rrM1_4LineStDE.material = MColor2;
                rrM1_4LineStEF.material = MColor5;
                rrM1_4LineStFD.material = MColor4;

                rrM1_4TextA.enabled = true;
                rrM1_4TextB.enabled = true;
                rrM1_4TextC.enabled = true;
                rrM1_4TextD.enabled = true;
                rrM1_4TextE.enabled = true;
                rrM1_4TextF.enabled = true;

                rrM1_4PointA.enabled = true;
                rrM1_4PointB.enabled = true;
                rrM1_4PointC.enabled = true;
                rrM1_4PointD.enabled = true;
                rrM1_4PointE.enabled = true;
                rrM1_4PointF.enabled = true;

                rrM1_4LineAB.enabled = true;
                rrM1_4LineBC.enabled = true;
                rrM1_4LineCA.enabled = true;
                rrM1_4LineDE.enabled = true;
                rrM1_4LineEF.enabled = true;
                rrM1_4LineFD.enabled = true;

                rrM1_4LineStAB.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_4LineStAB.enabled = true;

                rrM1_4LineStBC.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_4LineStBC.enabled = true;
                rrM1_4LineStCA.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_4LineStCA.enabled = true;

                //rrM1_4LineStDE.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_4LineStEF.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_4LineStFD.enabled = kyotuEla.tenmetuOnOff;

                rrM1_4kakuBAC.enabled = true;
                //rrM1_4kakuABC.enabled = true;
                //rrM1_4kakuACB.enabled = true;

                rrM1_4kakuEDF.enabled = true;
                //rrM1_4kakuDEF.enabled = true;
                //rrM1_4kakuDFE.enabled = true;

                //rrM1_4kakuStABC.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_4kakuStABC.enabled = true;

                //rrM1_4kakuStACB.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_4kakuStACB.enabled = true;
                //rrM1_4kakuStBAC.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_4kakuStBAC.enabled = true;

                //rrM1_4kakuStDEF.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_4kakuStDFE.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_4kakuStEDF.enabled = kyotuEla.tenmetuOnOff;
            } else if (count == 40) {//henka40
                reset();
                //k0018_99_1_1_1://obj.GetComponent<Renderer>().material = ColorPink;
                rrM1_4LineAB.material = MColor2;
                rrM1_4LineCA.material = MColor4;
                rrM1_4LineDE.material = MColor2;
                rrM1_4LineFD.material = MColor4;

                rrM1_4LineStAB.material = MColor2;
                rrM1_4LineStBC.material = MColor5;
                rrM1_4LineStCA.material = MColor4;
                rrM1_4LineStDE.material = MColor2;
                rrM1_4LineStEF.material = MColor5;
                rrM1_4LineStFD.material = MColor4;

                rrM1_4TextA.enabled = true;
                rrM1_4TextB.enabled = true;
                rrM1_4TextC.enabled = true;
                rrM1_4TextD.enabled = true;
                rrM1_4TextE.enabled = true;
                rrM1_4TextF.enabled = true;

                rrM1_4PointA.enabled = true;
                rrM1_4PointB.enabled = true;
                rrM1_4PointC.enabled = true;
                rrM1_4PointD.enabled = true;
                rrM1_4PointE.enabled = true;
                rrM1_4PointF.enabled = true;

                rrM1_4LineAB.enabled = true;
                rrM1_4LineBC.enabled = true;
                rrM1_4LineCA.enabled = true;
                rrM1_4LineDE.enabled = true;
                rrM1_4LineEF.enabled = true;
                rrM1_4LineFD.enabled = true;

                //rrM1_4LineStAB.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_4LineStAB.enabled = true;

                //rrM1_4LineStBC.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_4LineStBC.enabled = true;
                //rrM1_4LineStCA.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_4LineStCA.enabled = true;

                rrM1_4LineStDE.enabled = kyotuEla.tenmetuOnOff;
                rrM1_4LineStEF.enabled = kyotuEla.tenmetuOnOff;
                rrM1_4LineStFD.enabled = kyotuEla.tenmetuOnOff;

                rrM1_4kakuBAC.enabled = true;
                //rrM1_4kakuABC.enabled = true;
                //rrM1_4kakuACB.enabled = true;

                rrM1_4kakuEDF.enabled = true;
                //rrM1_4kakuDEF.enabled = true;
                //rrM1_4kakuDFE.enabled = true;

                //rrM1_4kakuStABC.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_4kakuStABC.enabled = true;

                //rrM1_4kakuStACB.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_4kakuStACB.enabled = true;
                //rrM1_4kakuStBAC.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_4kakuStBAC.enabled = true;

                //rrM1_4kakuStDEF.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_4kakuStDFE.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_4kakuStEDF.enabled = kyotuEla.tenmetuOnOff;
            } else if (count == 41) {//henka41
                reset();
                //k0018_99_1_1_1://obj.GetComponent<Renderer>().material = ColorPink;
                rrM1_4LineAB.material = MColor2;
                rrM1_4LineCA.material = MColor4;
                rrM1_4LineDE.material = MColor2;
                rrM1_4LineFD.material = MColor4;

                rrM1_4LineStAB.material = MColor2;
                rrM1_4LineStBC.material = MColor5;
                rrM1_4LineStCA.material = MColor4;
                rrM1_4LineStDE.material = MColor2;
                rrM1_4LineStEF.material = MColor5;
                rrM1_4LineStFD.material = MColor4;

                rrM1_4TextA.enabled = true;
                rrM1_4TextB.enabled = true;
                rrM1_4TextC.enabled = true;
                rrM1_4TextD.enabled = true;
                rrM1_4TextE.enabled = true;
                rrM1_4TextF.enabled = true;

                rrM1_4PointA.enabled = true;
                rrM1_4PointB.enabled = true;
                rrM1_4PointC.enabled = true;
                rrM1_4PointD.enabled = true;
                rrM1_4PointE.enabled = true;
                rrM1_4PointF.enabled = true;

                rrM1_4LineAB.enabled = true;
                rrM1_4LineBC.enabled = true;
                rrM1_4LineCA.enabled = true;
                rrM1_4LineDE.enabled = true;
                rrM1_4LineEF.enabled = true;
                rrM1_4LineFD.enabled = true;

                rrM1_4LineStAB.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_4LineStAB.enabled = true;

                rrM1_4LineStBC.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_4LineStBC.enabled = true;
                rrM1_4LineStCA.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_4LineStCA.enabled = true;

                rrM1_4LineStDE.enabled = kyotuEla.tenmetuOnOff;
                rrM1_4LineStEF.enabled = kyotuEla.tenmetuOnOff;
                rrM1_4LineStFD.enabled = kyotuEla.tenmetuOnOff;

                rrM1_4kakuBAC.enabled = true;
                //rrM1_4kakuABC.enabled = true;
                //rrM1_4kakuACB.enabled = true;

                rrM1_4kakuEDF.enabled = true;
                //rrM1_4kakuDEF.enabled = true;
                //rrM1_4kakuDFE.enabled = true;

                //rrM1_4kakuStABC.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_4kakuStABC.enabled = true;

                //rrM1_4kakuStACB.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_4kakuStACB.enabled = true;
                //rrM1_4kakuStBAC.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_4kakuStBAC.enabled = true;

                //rrM1_4kakuStDEF.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_4kakuStDFE.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_4kakuStEDF.enabled = kyotuEla.tenmetuOnOff;
            } else if (count == 42) {//henka42
                reset();
                //k0018_99_1_1_1://obj.GetComponent<Renderer>().material = ColorPink;
                rrM1_4LineAB.material = MColor2;
                rrM1_4LineCA.material = MColor4;
                rrM1_4LineDE.material = MColor2;
                rrM1_4LineFD.material = MColor4;

                rrM1_4LineStAB.material = MColor2;
                rrM1_4LineStBC.material = MColor5;
                rrM1_4LineStCA.material = MColor4;
                rrM1_4LineStDE.material = MColor2;
                rrM1_4LineStEF.material = MColor5;
                rrM1_4LineStFD.material = MColor4;

                rrM1_4TextA.enabled = true;
                rrM1_4TextB.enabled = true;
                rrM1_4TextC.enabled = true;
                rrM1_4TextD.enabled = true;
                rrM1_4TextE.enabled = true;
                rrM1_4TextF.enabled = true;

                rrM1_4PointA.enabled = true;
                rrM1_4PointB.enabled = true;
                rrM1_4PointC.enabled = true;
                rrM1_4PointD.enabled = true;
                rrM1_4PointE.enabled = true;
                rrM1_4PointF.enabled = true;

                rrM1_4PointStA.enabled = kyotuEla.tenmetuOnOff;

                rrM1_4LineAB.enabled = true;
                rrM1_4LineBC.enabled = true;
                rrM1_4LineCA.enabled = true;
                rrM1_4LineDE.enabled = true;
                rrM1_4LineEF.enabled = true;
                rrM1_4LineFD.enabled = true;

                //rrM1_4LineStAB.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_4LineStAB.enabled = true;

                //rrM1_4LineStBC.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_4LineStBC.enabled = true;
                //rrM1_4LineStCA.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_4LineStCA.enabled = true;

                //rrM1_4LineStDE.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_4LineStEF.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_4LineStFD.enabled = kyotuEla.tenmetuOnOff;

                rrM1_4kakuBAC.enabled = true;
                //rrM1_4kakuABC.enabled = true;
                //rrM1_4kakuACB.enabled = true;

                rrM1_4kakuEDF.enabled = true;
                //rrM1_4kakuDEF.enabled = true;
                //rrM1_4kakuDFE.enabled = true;

                //rrM1_4kakuStABC.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_4kakuStABC.enabled = true;

                //rrM1_4kakuStACB.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_4kakuStACB.enabled = true;
                //rrM1_4kakuStBAC.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_4kakuStBAC.enabled = true;

                //rrM1_4kakuStDEF.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_4kakuStDFE.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_4kakuStEDF.enabled = kyotuEla.tenmetuOnOff;
            } else if (count == 43) {//henka43
                reset();
                //k0018_99_1_1_1://obj.GetComponent<Renderer>().material = ColorPink;
                rrM1_4LineAB.material = MColor2;
                rrM1_4LineCA.material = MColor4;
                rrM1_4LineDE.material = MColor2;
                rrM1_4LineFD.material = MColor4;

                rrM1_4LineStAB.material = MColor2;
                rrM1_4LineStBC.material = MColor5;
                rrM1_4LineStCA.material = MColor4;
                rrM1_4LineStDE.material = MColor2;
                rrM1_4LineStEF.material = MColor5;
                rrM1_4LineStFD.material = MColor4;

                rrM1_4TextA.enabled = true;
                rrM1_4TextB.enabled = true;
                rrM1_4TextC.enabled = true;
                rrM1_4TextD.enabled = true;
                rrM1_4TextE.enabled = true;
                rrM1_4TextF.enabled = true;

                rrM1_4PointA.enabled = true;
                rrM1_4PointB.enabled = true;
                rrM1_4PointC.enabled = true;
                rrM1_4PointD.enabled = true;
                rrM1_4PointE.enabled = true;
                rrM1_4PointF.enabled = true;

                //rrM1_4PointStA.enabled = kyotuEla.tenmetuOnOff;
                rrM1_4PointStA.enabled = true;

                rrM1_4PointStD.enabled = kyotuEla.tenmetuOnOff;

                rrM1_4LineAB.enabled = true;
                rrM1_4LineBC.enabled = true;
                rrM1_4LineCA.enabled = true;
                rrM1_4LineDE.enabled = true;
                rrM1_4LineEF.enabled = true;
                rrM1_4LineFD.enabled = true;

                //rrM1_4LineStAB.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_4LineStAB.enabled = true;

                //rrM1_4LineStBC.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_4LineStBC.enabled = true;
                //rrM1_4LineStCA.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_4LineStCA.enabled = true;

                //rrM1_4LineStDE.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_4LineStEF.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_4LineStFD.enabled = kyotuEla.tenmetuOnOff;

                rrM1_4kakuBAC.enabled = true;
                //rrM1_4kakuABC.enabled = true;
                //rrM1_4kakuACB.enabled = true;

                rrM1_4kakuEDF.enabled = true;
                //rrM1_4kakuDEF.enabled = true;
                //rrM1_4kakuDFE.enabled = true;

                //rrM1_4kakuStABC.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_4kakuStABC.enabled = true;

                //rrM1_4kakuStACB.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_4kakuStACB.enabled = true;
                //rrM1_4kakuStBAC.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_4kakuStBAC.enabled = true;

                //rrM1_4kakuStDEF.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_4kakuStDFE.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_4kakuStEDF.enabled = kyotuEla.tenmetuOnOff;
            } else if (count == 44) {//henka44
                reset();
                //k0018_99_1_1_1://obj.GetComponent<Renderer>().material = ColorPink;
                rrM1_4LineAB.material = MColor2;
                rrM1_4LineCA.material = MColor4;
                rrM1_4LineDE.material = MColor2;
                rrM1_4LineFD.material = MColor4;

                rrM1_4LineStAB.material = MColor2;
                rrM1_4LineStBC.material = MColor5;
                rrM1_4LineStCA.material = MColor4;
                rrM1_4LineStDE.material = MColor2;
                rrM1_4LineStEF.material = MColor5;
                rrM1_4LineStFD.material = MColor4;

                rrM1_4TextA.enabled = true;
                rrM1_4TextB.enabled = true;
                rrM1_4TextC.enabled = true;
                rrM1_4TextD.enabled = true;
                rrM1_4TextE.enabled = true;
                rrM1_4TextF.enabled = true;

                rrM1_4PointA.enabled = true;
                rrM1_4PointB.enabled = true;
                rrM1_4PointC.enabled = true;
                rrM1_4PointD.enabled = true;
                rrM1_4PointE.enabled = true;
                rrM1_4PointF.enabled = true;

                //rrM1_4PointStA.enabled = kyotuEla.tenmetuOnOff;
                rrM1_4PointStA.enabled = true;

                //rrM1_4PointStD.enabled = kyotuEla.tenmetuOnOff;
                rrM1_4PointStD.enabled = true;

                rrM1_4LineAB.enabled = true;
                rrM1_4LineBC.enabled = true;
                rrM1_4LineCA.enabled = true;
                rrM1_4LineDE.enabled = true;
                rrM1_4LineEF.enabled = true;
                rrM1_4LineFD.enabled = true;

                rrM1_4LineStAB.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_4LineStAB.enabled = true;

                //rrM1_4LineStBC.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_4LineStBC.enabled = true;
                //rrM1_4LineStCA.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_4LineStCA.enabled = true;

                //rrM1_4LineStDE.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_4LineStEF.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_4LineStFD.enabled = kyotuEla.tenmetuOnOff;

                rrM1_4kakuBAC.enabled = true;
                //rrM1_4kakuABC.enabled = true;
                //rrM1_4kakuACB.enabled = true;

                rrM1_4kakuEDF.enabled = true;
                //rrM1_4kakuDEF.enabled = true;
                //rrM1_4kakuDFE.enabled = true;

                //rrM1_4kakuStABC.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_4kakuStABC.enabled = true;

                //rrM1_4kakuStACB.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_4kakuStACB.enabled = true;
                //rrM1_4kakuStBAC.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_4kakuStBAC.enabled = true;

                //rrM1_4kakuStDEF.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_4kakuStDFE.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_4kakuStEDF.enabled = kyotuEla.tenmetuOnOff;
            } else if (count == 45) {//henka45
                reset();
                //k0018_99_1_1_1://obj.GetComponent<Renderer>().material = ColorPink;
                rrM1_4LineAB.material = MColor2;
                rrM1_4LineCA.material = MColor4;
                rrM1_4LineDE.material = MColor2;
                rrM1_4LineFD.material = MColor4;

                rrM1_4LineStAB.material = MColor2;
                rrM1_4LineStBC.material = MColor5;
                rrM1_4LineStCA.material = MColor4;
                rrM1_4LineStDE.material = MColor2;
                rrM1_4LineStEF.material = MColor5;
                rrM1_4LineStFD.material = MColor4;

                rrM1_4TextA.enabled = true;
                rrM1_4TextB.enabled = true;
                rrM1_4TextC.enabled = true;
                rrM1_4TextD.enabled = true;
                rrM1_4TextE.enabled = true;
                rrM1_4TextF.enabled = true;

                rrM1_4PointA.enabled = true;
                rrM1_4PointB.enabled = true;
                rrM1_4PointC.enabled = true;
                rrM1_4PointD.enabled = true;
                rrM1_4PointE.enabled = true;
                rrM1_4PointF.enabled = true;

                //rrM1_4PointStA.enabled = kyotuEla.tenmetuOnOff;
                rrM1_4PointStA.enabled = true;

                //rrM1_4PointStD.enabled = kyotuEla.tenmetuOnOff;
                rrM1_4PointStD.enabled = true;

                rrM1_4LineAB.enabled = true;
                rrM1_4LineBC.enabled = true;
                rrM1_4LineCA.enabled = true;
                rrM1_4LineDE.enabled = true;
                rrM1_4LineEF.enabled = true;
                rrM1_4LineFD.enabled = true;

                //rrM1_4LineStAB.enabled = kyotuEla.tenmetuOnOff;
                rrM1_4LineStAB.enabled = true;

                //rrM1_4LineStBC.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_4LineStBC.enabled = true;
                //rrM1_4LineStCA.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_4LineStCA.enabled = true;

                rrM1_4LineStDE.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_4LineStDE.enabled = true;

                //rrM1_4LineStEF.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_4LineStFD.enabled = kyotuEla.tenmetuOnOff;

                rrM1_4kakuBAC.enabled = true;
                //rrM1_4kakuABC.enabled = true;
                //rrM1_4kakuACB.enabled = true;

                rrM1_4kakuEDF.enabled = true;
                //rrM1_4kakuDEF.enabled = true;
                //rrM1_4kakuDFE.enabled = true;

                //rrM1_4kakuStABC.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_4kakuStABC.enabled = true;

                //rrM1_4kakuStACB.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_4kakuStACB.enabled = true;
                //rrM1_4kakuStBAC.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_4kakuStBAC.enabled = true;

                //rrM1_4kakuStDEF.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_4kakuStDFE.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_4kakuStEDF.enabled = kyotuEla.tenmetuOnOff;
            } else if (count == 46) {//henka46
                reset();
                //k0018_99_1_1_1://obj.GetComponent<Renderer>().material = ColorPink;
                rrM1_4LineAB.material = MColor2;
                rrM1_4LineCA.material = MColor4;
                rrM1_4LineDE.material = MColor2;
                rrM1_4LineFD.material = MColor4;

                rrM1_4LineStAB.material = MColor2;
                rrM1_4LineStBC.material = MColor5;
                rrM1_4LineStCA.material = MColor4;
                rrM1_4LineStDE.material = MColor2;
                rrM1_4LineStEF.material = MColor5;
                rrM1_4LineStFD.material = MColor4;

                rrM1_4TextA.enabled = true;
                rrM1_4TextB.enabled = true;
                rrM1_4TextC.enabled = true;
                rrM1_4TextD.enabled = true;
                rrM1_4TextE.enabled = true;
                rrM1_4TextF.enabled = true;

                rrM1_4PointA.enabled = true;
                rrM1_4PointB.enabled = true;
                rrM1_4PointC.enabled = true;
                rrM1_4PointD.enabled = true;
                rrM1_4PointE.enabled = true;
                rrM1_4PointF.enabled = true;

                rrM1_4PointStA.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_4PointStA.enabled = true;

                rrM1_4PointStD.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_4PointStD.enabled = true;

                rrM1_4LineAB.enabled = true;
                rrM1_4LineBC.enabled = true;
                rrM1_4LineCA.enabled = true;
                rrM1_4LineDE.enabled = true;
                rrM1_4LineEF.enabled = true;
                rrM1_4LineFD.enabled = true;

                rrM1_4LineStAB.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_4LineStAB.enabled = true;

                //rrM1_4LineStBC.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_4LineStBC.enabled = true;
                //rrM1_4LineStCA.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_4LineStCA.enabled = true;

                rrM1_4LineStDE.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_4LineStDE.enabled = true;

                //rrM1_4LineStEF.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_4LineStFD.enabled = kyotuEla.tenmetuOnOff;

                rrM1_4kakuBAC.enabled = true;
                //rrM1_4kakuABC.enabled = true;
                //rrM1_4kakuACB.enabled = true;

                rrM1_4kakuEDF.enabled = true;
                //rrM1_4kakuDEF.enabled = true;
                //rrM1_4kakuDFE.enabled = true;

                //rrM1_4kakuStABC.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_4kakuStABC.enabled = true;

                //rrM1_4kakuStACB.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_4kakuStACB.enabled = true;
                //rrM1_4kakuStBAC.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_4kakuStBAC.enabled = true;

                //rrM1_4kakuStDEF.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_4kakuStDFE.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_4kakuStEDF.enabled = kyotuEla.tenmetuOnOff;
            } else if (count == 47) {//henka47
                reset();
                //k0018_99_1_1_1://obj.GetComponent<Renderer>().material = ColorPink;
                rrM1_4LineAB.material = MColor2;
                rrM1_4LineCA.material = MColor4;
                rrM1_4LineDE.material = MColor2;
                rrM1_4LineFD.material = MColor4;

                rrM1_4LineStAB.material = MColor2;
                rrM1_4LineStBC.material = MColor5;
                rrM1_4LineStCA.material = MColor4;
                rrM1_4LineStDE.material = MColor2;
                rrM1_4LineStEF.material = MColor5;
                rrM1_4LineStFD.material = MColor4;

                rrM1_4TextA.enabled = true;
                rrM1_4TextB.enabled = true;
                rrM1_4TextC.enabled = true;
                rrM1_4TextD.enabled = true;
                rrM1_4TextE.enabled = true;
                rrM1_4TextF.enabled = true;

                rrM1_4PointA.enabled = true;
                rrM1_4PointB.enabled = true;
                rrM1_4PointC.enabled = true;
                rrM1_4PointD.enabled = true;
                rrM1_4PointE.enabled = true;
                rrM1_4PointF.enabled = true;

                //rrM1_4PointStA.enabled = kyotuEla.tenmetuOnOff;
                rrM1_4PointStA.enabled = true;

                //rrM1_4PointStD.enabled = kyotuEla.tenmetuOnOff;
                rrM1_4PointStD.enabled = true;

                rrM1_4LineAB.enabled = true;
                rrM1_4LineBC.enabled = true;
                rrM1_4LineCA.enabled = true;
                rrM1_4LineDE.enabled = true;
                rrM1_4LineEF.enabled = true;
                rrM1_4LineFD.enabled = true;

                rrM1_4LineStAB.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_4LineStAB.enabled = true;

                //rrM1_4LineStBC.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_4LineStBC.enabled = true;
                //rrM1_4LineStCA.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_4LineStCA.enabled = true;

                //rrM1_4LineStDE.enabled = kyotuEla.tenmetuOnOff;
                rrM1_4LineStDE.enabled = true;

                //rrM1_4LineStEF.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_4LineStFD.enabled = kyotuEla.tenmetuOnOff;

                rrM1_4kakuBAC.enabled = true;
                //rrM1_4kakuABC.enabled = true;
                //rrM1_4kakuACB.enabled = true;

                rrM1_4kakuEDF.enabled = true;
                //rrM1_4kakuDEF.enabled = true;
                //rrM1_4kakuDFE.enabled = true;

                //rrM1_4kakuStABC.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_4kakuStABC.enabled = true;

                //rrM1_4kakuStACB.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_4kakuStACB.enabled = true;
                //rrM1_4kakuStBAC.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_4kakuStBAC.enabled = true;

                //rrM1_4kakuStDEF.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_4kakuStDFE.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_4kakuStEDF.enabled = kyotuEla.tenmetuOnOff;
            } else if (count == 48) {//henka48
                reset();
                //k0018_99_1_1_1://obj.GetComponent<Renderer>().material = ColorPink;
                rrM1_4LineAB.material = MColor2;
                rrM1_4LineCA.material = MColor4;
                rrM1_4LineDE.material = MColor2;
                rrM1_4LineFD.material = MColor4;

                rrM1_4LineStAB.material = MColor2;
                rrM1_4LineStBC.material = MColor5;
                rrM1_4LineStCA.material = MColor4;
                rrM1_4LineStDE.material = MColor2;
                rrM1_4LineStEF.material = MColor5;
                rrM1_4LineStFD.material = MColor4;

                rrM1_4TextA.enabled = true;
                rrM1_4TextB.enabled = true;
                rrM1_4TextC.enabled = true;
                rrM1_4TextD.enabled = true;
                rrM1_4TextE.enabled = true;
                rrM1_4TextF.enabled = true;

                rrM1_4PointA.enabled = true;
                rrM1_4PointB.enabled = true;
                rrM1_4PointC.enabled = true;
                rrM1_4PointD.enabled = true;
                rrM1_4PointE.enabled = true;
                rrM1_4PointF.enabled = true;

                //rrM1_4PointStA.enabled = kyotuEla.tenmetuOnOff;
                rrM1_4PointStA.enabled = true;

                //rrM1_4PointStD.enabled = kyotuEla.tenmetuOnOff;
                rrM1_4PointStD.enabled = true;

                rrM1_4LineAB.enabled = true;
                rrM1_4LineBC.enabled = true;
                rrM1_4LineCA.enabled = true;
                rrM1_4LineDE.enabled = true;
                rrM1_4LineEF.enabled = true;
                rrM1_4LineFD.enabled = true;

                //rrM1_4LineStAB.enabled = kyotuEla.tenmetuOnOff;
                rrM1_4LineStAB.enabled = true;

                //rrM1_4LineStBC.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_4LineStBC.enabled = true;
                //rrM1_4LineStCA.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_4LineStCA.enabled = true;

                rrM1_4LineStDE.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_4LineStDE.enabled = true;

                //rrM1_4LineStEF.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_4LineStFD.enabled = kyotuEla.tenmetuOnOff;

                rrM1_4kakuBAC.enabled = true;
                //rrM1_4kakuABC.enabled = true;
                //rrM1_4kakuACB.enabled = true;

                rrM1_4kakuEDF.enabled = true;
                //rrM1_4kakuDEF.enabled = true;
                //rrM1_4kakuDFE.enabled = true;

                //rrM1_4kakuStABC.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_4kakuStABC.enabled = true;

                //rrM1_4kakuStACB.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_4kakuStACB.enabled = true;
                //rrM1_4kakuStBAC.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_4kakuStBAC.enabled = true;

                //rrM1_4kakuStDEF.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_4kakuStDFE.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_4kakuStEDF.enabled = kyotuEla.tenmetuOnOff;
            } else if (count == 49) {//henka49
                reset();
                //k0018_99_1_1_1://obj.GetComponent<Renderer>().material = ColorPink;
                rrM1_4LineAB.material = MColor2;
                rrM1_4LineCA.material = MColor4;
                rrM1_4LineDE.material = MColor2;
                rrM1_4LineFD.material = MColor4;

                rrM1_4LineStAB.material = MColor2;
                rrM1_4LineStBC.material = MColor5;
                rrM1_4LineStCA.material = MColor4;
                rrM1_4LineStDE.material = MColor2;
                rrM1_4LineStEF.material = MColor5;
                rrM1_4LineStFD.material = MColor4;

                rrM1_4TextA.enabled = true;
                rrM1_4TextB.enabled = true;
                rrM1_4TextC.enabled = true;
                rrM1_4TextD.enabled = true;
                rrM1_4TextE.enabled = true;
                rrM1_4TextF.enabled = true;

                rrM1_4PointA.enabled = true;
                rrM1_4PointB.enabled = true;
                rrM1_4PointC.enabled = true;
                rrM1_4PointD.enabled = true;
                rrM1_4PointE.enabled = true;
                rrM1_4PointF.enabled = true;

                //rrM1_4PointStA.enabled = kyotuEla.tenmetuOnOff;
                rrM1_4PointStA.enabled = true;

                //rrM1_4PointStD.enabled = kyotuEla.tenmetuOnOff;
                rrM1_4PointStD.enabled = true;

                rrM1_4LineAB.enabled = true;
                rrM1_4LineBC.enabled = true;
                rrM1_4LineCA.enabled = true;
                rrM1_4LineDE.enabled = true;
                rrM1_4LineEF.enabled = true;
                rrM1_4LineFD.enabled = true;

                rrM1_4LineStAB.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_4LineStAB.enabled = true;

                //rrM1_4LineStBC.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_4LineStBC.enabled = true;
                //rrM1_4LineStCA.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_4LineStCA.enabled = true;

                rrM1_4LineStDE.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_4LineStDE.enabled = true;

                //rrM1_4LineStEF.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_4LineStFD.enabled = kyotuEla.tenmetuOnOff;

                rrM1_4kakuBAC.enabled = true;
                //rrM1_4kakuABC.enabled = true;
                //rrM1_4kakuACB.enabled = true;

                rrM1_4kakuEDF.enabled = true;
                //rrM1_4kakuDEF.enabled = true;
                //rrM1_4kakuDFE.enabled = true;

                //rrM1_4kakuStABC.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_4kakuStABC.enabled = true;

                //rrM1_4kakuStACB.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_4kakuStACB.enabled = true;
                //rrM1_4kakuStBAC.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_4kakuStBAC.enabled = true;

                //rrM1_4kakuStDEF.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_4kakuStDFE.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_4kakuStEDF.enabled = kyotuEla.tenmetuOnOff;
            } else if (count == 50) {//henka50
                reset();
                //k0018_99_1_1_1://obj.GetComponent<Renderer>().material = ColorPink;
                rrM1_4LineAB.material = MColor2;
                rrM1_4LineCA.material = MColor4;
                rrM1_4LineDE.material = MColor2;
                rrM1_4LineFD.material = MColor4;

                rrM1_4LineStAB.material = MColor2;
                rrM1_4LineStBC.material = MColor5;
                rrM1_4LineStCA.material = MColor4;
                rrM1_4LineStDE.material = MColor2;
                rrM1_4LineStEF.material = MColor5;
                rrM1_4LineStFD.material = MColor4;

                rrM1_4TextA.enabled = true;
                rrM1_4TextB.enabled = true;
                rrM1_4TextC.enabled = true;
                rrM1_4TextD.enabled = true;
                rrM1_4TextE.enabled = true;
                rrM1_4TextF.enabled = true;

                rrM1_4PointA.enabled = true;
                rrM1_4PointB.enabled = true;
                rrM1_4PointC.enabled = true;
                rrM1_4PointD.enabled = true;
                rrM1_4PointE.enabled = true;
                rrM1_4PointF.enabled = true;

                //rrM1_4PointStA.enabled = kyotuEla.tenmetuOnOff;
                rrM1_4PointStA.enabled = true;

                //rrM1_4PointStD.enabled = kyotuEla.tenmetuOnOff;
                rrM1_4PointStD.enabled = true;

                rrM1_4LineAB.enabled = true;
                rrM1_4LineBC.enabled = true;
                rrM1_4LineCA.enabled = true;
                rrM1_4LineDE.enabled = true;
                rrM1_4LineEF.enabled = true;
                rrM1_4LineFD.enabled = true;

                rrM1_4LineStAB.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_4LineStAB.enabled = true;

                //rrM1_4LineStBC.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_4LineStBC.enabled = true;
                //rrM1_4LineStCA.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_4LineStCA.enabled = true;

                rrM1_4LineStDE.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_4LineStDE.enabled = true;

                //rrM1_4LineStEF.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_4LineStFD.enabled = kyotuEla.tenmetuOnOff;

                rrM1_4kakuBAC.enabled = true;
                //rrM1_4kakuABC.enabled = true;
                //rrM1_4kakuACB.enabled = true;

                rrM1_4kakuEDF.enabled = true;
                //rrM1_4kakuDEF.enabled = true;
                //rrM1_4kakuDFE.enabled = true;

                //rrM1_4kakuStABC.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_4kakuStABC.enabled = true;

                //rrM1_4kakuStACB.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_4kakuStACB.enabled = true;
                //rrM1_4kakuStBAC.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_4kakuStBAC.enabled = true;

                //rrM1_4kakuStDEF.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_4kakuStDFE.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_4kakuStEDF.enabled = kyotuEla.tenmetuOnOff;
            } else if (count == 51) {//henka51
                reset();
                //k0018_99_1_1_1://obj.GetComponent<Renderer>().material = ColorPink;
                rrM1_4LineAB.material = MColor2;
                rrM1_4LineCA.material = MColor4;
                rrM1_4LineDE.material = MColor2;
                rrM1_4LineFD.material = MColor4;

                rrM1_4LineStAB.material = MColor2;
                rrM1_4LineStBC.material = MColor5;
                rrM1_4LineStCA.material = MColor4;
                rrM1_4LineStDE.material = MColor2;
                rrM1_4LineStEF.material = MColor5;
                rrM1_4LineStFD.material = MColor4;

                rrM1_4TextA.enabled = true;
                rrM1_4TextB.enabled = true;
                rrM1_4TextC.enabled = true;
                rrM1_4TextD.enabled = true;
                rrM1_4TextE.enabled = true;
                rrM1_4TextF.enabled = true;

                rrM1_4PointA.enabled = true;
                rrM1_4PointB.enabled = true;
                rrM1_4PointC.enabled = true;
                rrM1_4PointD.enabled = true;
                rrM1_4PointE.enabled = true;
                rrM1_4PointF.enabled = true;

                //rrM1_4PointStA.enabled = kyotuEla.tenmetuOnOff;
                rrM1_4PointStA.enabled = true;

                //rrM1_4PointStD.enabled = kyotuEla.tenmetuOnOff;
                rrM1_4PointStD.enabled = true;

                rrM1_4LineAB.enabled = true;
                rrM1_4LineBC.enabled = true;
                rrM1_4LineCA.enabled = true;
                rrM1_4LineDE.enabled = true;
                rrM1_4LineEF.enabled = true;
                rrM1_4LineFD.enabled = true;

                rrM1_4LineStAB.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_4LineStAB.enabled = true;

                //rrM1_4LineStBC.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_4LineStBC.enabled = true;
                //rrM1_4LineStCA.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_4LineStCA.enabled = true;

                rrM1_4LineStDE.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_4LineStDE.enabled = true;

                //rrM1_4LineStEF.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_4LineStFD.enabled = kyotuEla.tenmetuOnOff;

                rrM1_4kakuBAC.enabled = true;
                //rrM1_4kakuABC.enabled = true;
                //rrM1_4kakuACB.enabled = true;

                rrM1_4kakuEDF.enabled = true;
                //rrM1_4kakuDEF.enabled = true;
                //rrM1_4kakuDFE.enabled = true;

                //rrM1_4kakuStABC.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_4kakuStABC.enabled = true;

                //rrM1_4kakuStACB.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_4kakuStACB.enabled = true;
                //rrM1_4kakuStBAC.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_4kakuStBAC.enabled = true;

                //rrM1_4kakuStDEF.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_4kakuStDFE.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_4kakuStEDF.enabled = kyotuEla.tenmetuOnOff;
            } else if (count == 52) {//henka52
                reset();
                //k0018_99_1_1_1://obj.GetComponent<Renderer>().material = ColorPink;
                rrM1_4LineAB.material = MColor2;
                rrM1_4LineCA.material = MColor4;
                rrM1_4LineDE.material = MColor2;
                rrM1_4LineFD.material = MColor4;

                rrM1_4LineStAB.material = MColor2;
                rrM1_4LineStBC.material = MColor5;
                rrM1_4LineStCA.material = MColor4;
                rrM1_4LineStDE.material = MColor2;
                rrM1_4LineStEF.material = MColor5;
                rrM1_4LineStFD.material = MColor4;

                rrM1_4TextA.enabled = true;
                rrM1_4TextB.enabled = true;
                rrM1_4TextC.enabled = true;
                rrM1_4TextD.enabled = true;
                rrM1_4TextE.enabled = true;
                rrM1_4TextF.enabled = true;

                rrM1_4PointA.enabled = true;
                rrM1_4PointB.enabled = true;
                rrM1_4PointC.enabled = true;
                rrM1_4PointD.enabled = true;
                rrM1_4PointE.enabled = true;
                rrM1_4PointF.enabled = true;

                //rrM1_4PointStA.enabled = kyotuEla.tenmetuOnOff;
                rrM1_4PointStA.enabled = true;

                rrM1_4PointStB.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_4PointStB.enabled = true;

                //rrM1_4PointStD.enabled = kyotuEla.tenmetuOnOff;
                rrM1_4PointStD.enabled = true;

                rrM1_4LineAB.enabled = true;
                rrM1_4LineBC.enabled = true;
                rrM1_4LineCA.enabled = true;
                rrM1_4LineDE.enabled = true;
                rrM1_4LineEF.enabled = true;
                rrM1_4LineFD.enabled = true;

                //rrM1_4LineStAB.enabled = kyotuEla.tenmetuOnOff;
                rrM1_4LineStAB.enabled = true;

                //rrM1_4LineStBC.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_4LineStBC.enabled = true;
                //rrM1_4LineStCA.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_4LineStCA.enabled = true;

                //rrM1_4LineStDE.enabled = kyotuEla.tenmetuOnOff;
                rrM1_4LineStDE.enabled = true;

                //rrM1_4LineStEF.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_4LineStFD.enabled = kyotuEla.tenmetuOnOff;

                rrM1_4kakuBAC.enabled = true;
                //rrM1_4kakuABC.enabled = true;
                //rrM1_4kakuACB.enabled = true;

                rrM1_4kakuEDF.enabled = true;
                //rrM1_4kakuDEF.enabled = true;
                //rrM1_4kakuDFE.enabled = true;

                //rrM1_4kakuStABC.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_4kakuStABC.enabled = true;

                //rrM1_4kakuStACB.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_4kakuStACB.enabled = true;
                //rrM1_4kakuStBAC.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_4kakuStBAC.enabled = true;

                //rrM1_4kakuStDEF.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_4kakuStDFE.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_4kakuStEDF.enabled = kyotuEla.tenmetuOnOff;
            } else if (count == 53) {//henka53
                reset();
                //k0018_99_1_1_1://obj.GetComponent<Renderer>().material = ColorPink;
                rrM1_4LineAB.material = MColor2;
                rrM1_4LineCA.material = MColor4;
                rrM1_4LineDE.material = MColor2;
                rrM1_4LineFD.material = MColor4;

                rrM1_4LineStAB.material = MColor2;
                rrM1_4LineStBC.material = MColor5;
                rrM1_4LineStCA.material = MColor4;
                rrM1_4LineStDE.material = MColor2;
                rrM1_4LineStEF.material = MColor5;
                rrM1_4LineStFD.material = MColor4;

                rrM1_4TextA.enabled = true;
                rrM1_4TextB.enabled = true;
                rrM1_4TextC.enabled = true;
                rrM1_4TextD.enabled = true;
                rrM1_4TextE.enabled = true;
                rrM1_4TextF.enabled = true;

                rrM1_4PointA.enabled = true;
                rrM1_4PointB.enabled = true;
                rrM1_4PointC.enabled = true;
                rrM1_4PointD.enabled = true;
                rrM1_4PointE.enabled = true;
                rrM1_4PointF.enabled = true;

                //rrM1_4PointStA.enabled = kyotuEla.tenmetuOnOff;
                rrM1_4PointStA.enabled = true;

                //rrM1_4PointStB.enabled = kyotuEla.tenmetuOnOff;
                rrM1_4PointStB.enabled = true;

                //rrM1_4PointStD.enabled = kyotuEla.tenmetuOnOff;
                rrM1_4PointStD.enabled = true;

                rrM1_4PointStE.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_4PointStE.enabled = true;

                rrM1_4LineAB.enabled = true;
                rrM1_4LineBC.enabled = true;
                rrM1_4LineCA.enabled = true;
                rrM1_4LineDE.enabled = true;
                rrM1_4LineEF.enabled = true;
                rrM1_4LineFD.enabled = true;

                //rrM1_4LineStAB.enabled = kyotuEla.tenmetuOnOff;
                rrM1_4LineStAB.enabled = true;

                //rrM1_4LineStBC.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_4LineStBC.enabled = true;
                //rrM1_4LineStCA.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_4LineStCA.enabled = true;

                //rrM1_4LineStDE.enabled = kyotuEla.tenmetuOnOff;
                rrM1_4LineStDE.enabled = true;

                //rrM1_4LineStEF.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_4LineStFD.enabled = kyotuEla.tenmetuOnOff;

                rrM1_4kakuBAC.enabled = true;
                //rrM1_4kakuABC.enabled = true;
                //rrM1_4kakuACB.enabled = true;

                rrM1_4kakuEDF.enabled = true;
                //rrM1_4kakuDEF.enabled = true;
                //rrM1_4kakuDFE.enabled = true;

                //rrM1_4kakuStABC.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_4kakuStABC.enabled = true;

                //rrM1_4kakuStACB.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_4kakuStACB.enabled = true;
                //rrM1_4kakuStBAC.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_4kakuStBAC.enabled = true;

                //rrM1_4kakuStDEF.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_4kakuStDFE.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_4kakuStEDF.enabled = kyotuEla.tenmetuOnOff;
            } else if (count == 54) {//henka54
                reset();
                //k0018_99_1_1_1://obj.GetComponent<Renderer>().material = ColorPink;
                rrM1_4LineAB.material = MColor2;
                rrM1_4LineCA.material = MColor4;
                rrM1_4LineDE.material = MColor2;
                rrM1_4LineFD.material = MColor4;

                rrM1_4LineStAB.material = MColor2;
                rrM1_4LineStBC.material = MColor5;
                rrM1_4LineStCA.material = MColor4;
                rrM1_4LineStDE.material = MColor2;
                rrM1_4LineStEF.material = MColor5;
                rrM1_4LineStFD.material = MColor4;

                rrM1_4TextA.enabled = true;
                rrM1_4TextB.enabled = true;
                rrM1_4TextC.enabled = true;
                rrM1_4TextD.enabled = true;
                rrM1_4TextE.enabled = true;
                rrM1_4TextF.enabled = true;

                rrM1_4PointA.enabled = true;
                rrM1_4PointB.enabled = true;
                rrM1_4PointC.enabled = true;
                rrM1_4PointD.enabled = true;
                rrM1_4PointE.enabled = true;
                rrM1_4PointF.enabled = true;

                //rrM1_4PointStA.enabled = kyotuEla.tenmetuOnOff;
                rrM1_4PointStA.enabled = true;

                rrM1_4PointStB.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_4PointStB.enabled = true;

                //rrM1_4PointStD.enabled = kyotuEla.tenmetuOnOff;
                rrM1_4PointStD.enabled = true;

                rrM1_4PointStE.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_4PointStE.enabled = true;

                rrM1_4LineAB.enabled = true;
                rrM1_4LineBC.enabled = true;
                rrM1_4LineCA.enabled = true;
                rrM1_4LineDE.enabled = true;
                rrM1_4LineEF.enabled = true;
                rrM1_4LineFD.enabled = true;

                //rrM1_4LineStAB.enabled = kyotuEla.tenmetuOnOff;
                rrM1_4LineStAB.enabled = true;

                //rrM1_4LineStBC.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_4LineStBC.enabled = true;
                //rrM1_4LineStCA.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_4LineStCA.enabled = true;

                //rrM1_4LineStDE.enabled = kyotuEla.tenmetuOnOff;
                rrM1_4LineStDE.enabled = true;

                //rrM1_4LineStEF.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_4LineStFD.enabled = kyotuEla.tenmetuOnOff;

                rrM1_4kakuBAC.enabled = true;
                //rrM1_4kakuABC.enabled = true;
                //rrM1_4kakuACB.enabled = true;

                rrM1_4kakuEDF.enabled = true;
                //rrM1_4kakuDEF.enabled = true;
                //rrM1_4kakuDFE.enabled = true;

                //rrM1_4kakuStABC.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_4kakuStABC.enabled = true;

                //rrM1_4kakuStACB.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_4kakuStACB.enabled = true;
                //rrM1_4kakuStBAC.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_4kakuStBAC.enabled = true;

                //rrM1_4kakuStDEF.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_4kakuStDFE.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_4kakuStEDF.enabled = kyotuEla.tenmetuOnOff;
            } else if (count == 55) {//henka55
                reset();
                //k0018_99_1_1_1://obj.GetComponent<Renderer>().material = ColorPink;
                rrM1_4LineAB.material = MColor2;
                rrM1_4LineCA.material = MColor4;
                rrM1_4LineDE.material = MColor2;
                rrM1_4LineFD.material = MColor4;

                rrM1_4LineStAB.material = MColor2;
                rrM1_4LineStBC.material = MColor5;
                rrM1_4LineStCA.material = MColor4;
                rrM1_4LineStDE.material = MColor2;
                rrM1_4LineStEF.material = MColor5;
                rrM1_4LineStFD.material = MColor4;

                rrM1_4TextA.enabled = true;
                rrM1_4TextB.enabled = true;
                rrM1_4TextC.enabled = true;
                rrM1_4TextD.enabled = true;
                rrM1_4TextE.enabled = true;
                rrM1_4TextF.enabled = true;

                rrM1_4PointA.enabled = true;
                rrM1_4PointB.enabled = true;
                rrM1_4PointC.enabled = true;
                rrM1_4PointD.enabled = true;
                rrM1_4PointE.enabled = true;
                rrM1_4PointF.enabled = true;

                //rrM1_4PointStA.enabled = kyotuEla.tenmetuOnOff;
                rrM1_4PointStA.enabled = true;

                //rrM1_4PointStB.enabled = kyotuEla.tenmetuOnOff;
                rrM1_4PointStB.enabled = true;

                //rrM1_4PointStD.enabled = kyotuEla.tenmetuOnOff;
                rrM1_4PointStD.enabled = true;

                //rrM1_4PointStE.enabled = kyotuEla.tenmetuOnOff;
                rrM1_4PointStE.enabled = true;

                rrM1_4LineAB.enabled = true;
                rrM1_4LineBC.enabled = true;
                rrM1_4LineCA.enabled = true;
                rrM1_4LineDE.enabled = true;
                rrM1_4LineEF.enabled = true;
                rrM1_4LineFD.enabled = true;

                rrM1_4LineStAB.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_4LineStAB.enabled = true;

                //rrM1_4LineStBC.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_4LineStBC.enabled = true;
                //rrM1_4LineStCA.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_4LineStCA.enabled = true;

                //rrM1_4LineStDE.enabled = kyotuEla.tenmetuOnOff;
                rrM1_4LineStDE.enabled = true;

                //rrM1_4LineStEF.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_4LineStFD.enabled = kyotuEla.tenmetuOnOff;

                rrM1_4kakuBAC.enabled = true;
                //rrM1_4kakuABC.enabled = true;
                //rrM1_4kakuACB.enabled = true;

                rrM1_4kakuEDF.enabled = true;
                //rrM1_4kakuDEF.enabled = true;
                //rrM1_4kakuDFE.enabled = true;

                //rrM1_4kakuStABC.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_4kakuStABC.enabled = true;

                //rrM1_4kakuStACB.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_4kakuStACB.enabled = true;
                //rrM1_4kakuStBAC.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_4kakuStBAC.enabled = true;

                //rrM1_4kakuStDEF.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_4kakuStDFE.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_4kakuStEDF.enabled = kyotuEla.tenmetuOnOff;
            } else if (count == 56) {//henka56
                reset();
                //k0018_99_1_1_1://obj.GetComponent<Renderer>().material = ColorPink;
                rrM1_4LineAB.material = MColor2;
                rrM1_4LineCA.material = MColor4;
                rrM1_4LineDE.material = MColor2;
                rrM1_4LineFD.material = MColor4;

                rrM1_4LineStAB.material = MColor2;
                rrM1_4LineStBC.material = MColor5;
                rrM1_4LineStCA.material = MColor4;
                rrM1_4LineStDE.material = MColor2;
                rrM1_4LineStEF.material = MColor5;
                rrM1_4LineStFD.material = MColor4;

                rrM1_4TextA.enabled = true;
                rrM1_4TextB.enabled = true;
                rrM1_4TextC.enabled = true;
                rrM1_4TextD.enabled = true;
                rrM1_4TextE.enabled = true;
                rrM1_4TextF.enabled = true;

                rrM1_4PointA.enabled = true;
                rrM1_4PointB.enabled = true;
                rrM1_4PointC.enabled = true;
                rrM1_4PointD.enabled = true;
                rrM1_4PointE.enabled = true;
                rrM1_4PointF.enabled = true;

                //rrM1_4PointStA.enabled = kyotuEla.tenmetuOnOff;
                rrM1_4PointStA.enabled = true;

                //rrM1_4PointStB.enabled = kyotuEla.tenmetuOnOff;
                rrM1_4PointStB.enabled = true;

                //rrM1_4PointStD.enabled = kyotuEla.tenmetuOnOff;
                rrM1_4PointStD.enabled = true;

                //rrM1_4PointStE.enabled = kyotuEla.tenmetuOnOff;
                rrM1_4PointStE.enabled = true;

                rrM1_4LineAB.enabled = true;
                rrM1_4LineBC.enabled = true;
                rrM1_4LineCA.enabled = true;
                rrM1_4LineDE.enabled = true;
                rrM1_4LineEF.enabled = true;
                rrM1_4LineFD.enabled = true;

                //rrM1_4LineStAB.enabled = kyotuEla.tenmetuOnOff;
                rrM1_4LineStAB.enabled = true;

                //rrM1_4LineStBC.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_4LineStBC.enabled = true;
                //rrM1_4LineStCA.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_4LineStCA.enabled = true;

                rrM1_4LineStDE.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_4LineStDE.enabled = true;

                //rrM1_4LineStEF.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_4LineStFD.enabled = kyotuEla.tenmetuOnOff;

                rrM1_4kakuBAC.enabled = true;
                //rrM1_4kakuABC.enabled = true;
                //rrM1_4kakuACB.enabled = true;

                rrM1_4kakuEDF.enabled = true;
                //rrM1_4kakuDEF.enabled = true;
                //rrM1_4kakuDFE.enabled = true;

                //rrM1_4kakuStABC.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_4kakuStABC.enabled = true;

                //rrM1_4kakuStACB.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_4kakuStACB.enabled = true;
                //rrM1_4kakuStBAC.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_4kakuStBAC.enabled = true;

                //rrM1_4kakuStDEF.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_4kakuStDFE.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_4kakuStEDF.enabled = kyotuEla.tenmetuOnOff;
            } else if (count == 57) {//henka57
                reset();
                //k0018_99_1_1_1://obj.GetComponent<Renderer>().material = ColorPink;
                rrM1_4LineAB.material = MColor2;
                rrM1_4LineCA.material = MColor4;
                rrM1_4LineDE.material = MColor2;
                rrM1_4LineFD.material = MColor4;

                rrM1_4LineStAB.material = MColor2;
                rrM1_4LineStBC.material = MColor5;
                rrM1_4LineStCA.material = MColor4;
                rrM1_4LineStDE.material = MColor2;
                rrM1_4LineStEF.material = MColor5;
                rrM1_4LineStFD.material = MColor4;

                rrM1_4TextA.enabled = true;
                rrM1_4TextB.enabled = true;
                rrM1_4TextC.enabled = true;
                rrM1_4TextD.enabled = true;
                rrM1_4TextE.enabled = true;
                rrM1_4TextF.enabled = true;

                rrM1_4PointA.enabled = true;
                rrM1_4PointB.enabled = true;
                rrM1_4PointC.enabled = true;
                rrM1_4PointD.enabled = true;
                rrM1_4PointE.enabled = true;
                rrM1_4PointF.enabled = true;

                //rrM1_4PointStA.enabled = kyotuEla.tenmetuOnOff;
                rrM1_4PointStA.enabled = true;

                //rrM1_4PointStB.enabled = kyotuEla.tenmetuOnOff;
                rrM1_4PointStB.enabled = true;

                //rrM1_4PointStD.enabled = kyotuEla.tenmetuOnOff;
                rrM1_4PointStD.enabled = true;

                //rrM1_4PointStE.enabled = kyotuEla.tenmetuOnOff;
                rrM1_4PointStE.enabled = true;

                rrM1_4LineAB.enabled = true;
                rrM1_4LineBC.enabled = true;
                rrM1_4LineCA.enabled = true;
                rrM1_4LineDE.enabled = true;
                rrM1_4LineEF.enabled = true;
                rrM1_4LineFD.enabled = true;

                rrM1_4LineStAB.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_4LineStAB.enabled = true;

                //rrM1_4LineStBC.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_4LineStBC.enabled = true;
                //rrM1_4LineStCA.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_4LineStCA.enabled = true;

                rrM1_4LineStDE.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_4LineStDE.enabled = true;

                //rrM1_4LineStEF.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_4LineStFD.enabled = kyotuEla.tenmetuOnOff;

                rrM1_4kakuBAC.enabled = true;
                //rrM1_4kakuABC.enabled = true;
                //rrM1_4kakuACB.enabled = true;

                rrM1_4kakuEDF.enabled = true;
                //rrM1_4kakuDEF.enabled = true;
                //rrM1_4kakuDFE.enabled = true;

                //rrM1_4kakuStABC.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_4kakuStABC.enabled = true;

                //rrM1_4kakuStACB.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_4kakuStACB.enabled = true;
                //rrM1_4kakuStBAC.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_4kakuStBAC.enabled = true;

                //rrM1_4kakuStDEF.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_4kakuStDFE.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_4kakuStEDF.enabled = kyotuEla.tenmetuOnOff;
            } else if (count == 58) {//henka58
                reset();
                //k0018_99_1_1_1://obj.GetComponent<Renderer>().material = ColorPink;
                rrM1_4LineAB.material = MColor2;
                rrM1_4LineCA.material = MColor4;
                rrM1_4LineDE.material = MColor2;
                rrM1_4LineFD.material = MColor4;

                rrM1_4LineStAB.material = MColor2;
                rrM1_4LineStBC.material = MColor5;
                rrM1_4LineStCA.material = MColor4;
                rrM1_4LineStDE.material = MColor2;
                rrM1_4LineStEF.material = MColor5;
                rrM1_4LineStFD.material = MColor4;

                rrM1_4TextA.enabled = true;
                rrM1_4TextB.enabled = true;
                rrM1_4TextC.enabled = true;
                rrM1_4TextD.enabled = true;
                rrM1_4TextE.enabled = true;
                rrM1_4TextF.enabled = true;

                rrM1_4PointA.enabled = true;
                rrM1_4PointB.enabled = true;
                rrM1_4PointC.enabled = true;
                rrM1_4PointD.enabled = true;
                rrM1_4PointE.enabled = true;
                rrM1_4PointF.enabled = true;

                //rrM1_4PointStA.enabled = kyotuEla.tenmetuOnOff;
                rrM1_4PointStA.enabled = true;

                //rrM1_4PointStB.enabled = kyotuEla.tenmetuOnOff;
                rrM1_4PointStB.enabled = true;

                //rrM1_4PointStD.enabled = kyotuEla.tenmetuOnOff;
                rrM1_4PointStD.enabled = true;

                //rrM1_4PointStE.enabled = kyotuEla.tenmetuOnOff;
                rrM1_4PointStE.enabled = true;

                rrM1_4LineAB.enabled = true;
                rrM1_4LineBC.enabled = true;
                rrM1_4LineCA.enabled = true;
                rrM1_4LineDE.enabled = true;
                rrM1_4LineEF.enabled = true;
                rrM1_4LineFD.enabled = true;

                //rrM1_4LineStAB.enabled = kyotuEla.tenmetuOnOff;
                rrM1_4LineStAB.enabled = true;

                //rrM1_4LineStBC.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_4LineStBC.enabled = true;
                //rrM1_4LineStCA.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_4LineStCA.enabled = true;

                //rrM1_4LineStDE.enabled = kyotuEla.tenmetuOnOff;
                rrM1_4LineStDE.enabled = true;

                //rrM1_4LineStEF.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_4LineStFD.enabled = kyotuEla.tenmetuOnOff;

                rrM1_4kakuBAC.enabled = true;
                //rrM1_4kakuABC.enabled = true;
                //rrM1_4kakuACB.enabled = true;

                rrM1_4kakuEDF.enabled = true;
                //rrM1_4kakuDEF.enabled = true;
                //rrM1_4kakuDFE.enabled = true;

                //rrM1_4kakuStABC.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_4kakuStABC.enabled = true;

                //rrM1_4kakuStACB.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_4kakuStACB.enabled = true;
                rrM1_4kakuStBAC.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_4kakuStBAC.enabled = true;

                //rrM1_4kakuStDEF.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_4kakuStDFE.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_4kakuStEDF.enabled = kyotuEla.tenmetuOnOff;
            } else if (count == 59) {//henka59
                reset();
                //k0018_99_1_1_1://obj.GetComponent<Renderer>().material = ColorPink;
                rrM1_4LineAB.material = MColor2;
                rrM1_4LineCA.material = MColor4;
                rrM1_4LineDE.material = MColor2;
                rrM1_4LineFD.material = MColor4;

                rrM1_4LineStAB.material = MColor2;
                rrM1_4LineStBC.material = MColor5;
                rrM1_4LineStCA.material = MColor4;
                rrM1_4LineStDE.material = MColor2;
                rrM1_4LineStEF.material = MColor5;
                rrM1_4LineStFD.material = MColor4;

                rrM1_4TextA.enabled = true;
                rrM1_4TextB.enabled = true;
                rrM1_4TextC.enabled = true;
                rrM1_4TextD.enabled = true;
                rrM1_4TextE.enabled = true;
                rrM1_4TextF.enabled = true;

                rrM1_4PointA.enabled = true;
                rrM1_4PointB.enabled = true;
                rrM1_4PointC.enabled = true;
                rrM1_4PointD.enabled = true;
                rrM1_4PointE.enabled = true;
                rrM1_4PointF.enabled = true;

                //rrM1_4PointStA.enabled = kyotuEla.tenmetuOnOff;
                rrM1_4PointStA.enabled = true;

                //rrM1_4PointStB.enabled = kyotuEla.tenmetuOnOff;
                rrM1_4PointStB.enabled = true;

                //rrM1_4PointStD.enabled = kyotuEla.tenmetuOnOff;
                rrM1_4PointStD.enabled = true;

                //rrM1_4PointStE.enabled = kyotuEla.tenmetuOnOff;
                rrM1_4PointStE.enabled = true;

                rrM1_4LineAB.enabled = true;
                rrM1_4LineBC.enabled = true;
                rrM1_4LineCA.enabled = true;
                rrM1_4LineDE.enabled = true;
                rrM1_4LineEF.enabled = true;
                rrM1_4LineFD.enabled = true;

                //rrM1_4LineStAB.enabled = kyotuEla.tenmetuOnOff;
                rrM1_4LineStAB.enabled = true;

                //rrM1_4LineStBC.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_4LineStBC.enabled = true;
                //rrM1_4LineStCA.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_4LineStCA.enabled = true;

                //rrM1_4LineStDE.enabled = kyotuEla.tenmetuOnOff;
                rrM1_4LineStDE.enabled = true;

                //rrM1_4LineStEF.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_4LineStFD.enabled = kyotuEla.tenmetuOnOff;

                rrM1_4kakuBAC.enabled = true;
                //rrM1_4kakuABC.enabled = true;
                //rrM1_4kakuACB.enabled = true;

                rrM1_4kakuEDF.enabled = true;
                //rrM1_4kakuDEF.enabled = true;
                //rrM1_4kakuDFE.enabled = true;

                //rrM1_4kakuStABC.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_4kakuStABC.enabled = true;

                //rrM1_4kakuStACB.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_4kakuStACB.enabled = true;
                //rrM1_4kakuStBAC.enabled = kyotuEla.tenmetuOnOff;
                rrM1_4kakuStBAC.enabled = true;

                //rrM1_4kakuStDEF.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_4kakuStDFE.enabled = kyotuEla.tenmetuOnOff;
                rrM1_4kakuStEDF.enabled = kyotuEla.tenmetuOnOff;
            } else if (count == 60) {//henka60
                reset();
                //k0018_99_1_1_1://obj.GetComponent<Renderer>().material = ColorPink;
                rrM1_4LineAB.material = MColor2;
                rrM1_4LineCA.material = MColor4;
                rrM1_4LineDE.material = MColor2;
                rrM1_4LineFD.material = MColor4;

                rrM1_4LineStAB.material = MColor2;
                rrM1_4LineStBC.material = MColor5;
                rrM1_4LineStCA.material = MColor4;
                rrM1_4LineStDE.material = MColor2;
                rrM1_4LineStEF.material = MColor5;
                rrM1_4LineStFD.material = MColor4;

                rrM1_4TextA.enabled = true;
                rrM1_4TextB.enabled = true;
                rrM1_4TextC.enabled = true;
                rrM1_4TextD.enabled = true;
                rrM1_4TextE.enabled = true;
                rrM1_4TextF.enabled = true;

                rrM1_4PointA.enabled = true;
                rrM1_4PointB.enabled = true;
                rrM1_4PointC.enabled = true;
                rrM1_4PointD.enabled = true;
                rrM1_4PointE.enabled = true;
                rrM1_4PointF.enabled = true;

                //rrM1_4PointStA.enabled = kyotuEla.tenmetuOnOff;
                rrM1_4PointStA.enabled = true;

                //rrM1_4PointStB.enabled = kyotuEla.tenmetuOnOff;
                rrM1_4PointStB.enabled = true;

                //rrM1_4PointStD.enabled = kyotuEla.tenmetuOnOff;
                rrM1_4PointStD.enabled = true;

                //rrM1_4PointStE.enabled = kyotuEla.tenmetuOnOff;
                rrM1_4PointStE.enabled = true;

                rrM1_4LineAB.enabled = true;
                rrM1_4LineBC.enabled = true;
                rrM1_4LineCA.enabled = true;
                rrM1_4LineDE.enabled = true;
                rrM1_4LineEF.enabled = true;
                rrM1_4LineFD.enabled = true;

                //rrM1_4LineStAB.enabled = kyotuEla.tenmetuOnOff;
                rrM1_4LineStAB.enabled = true;

                //rrM1_4LineStBC.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_4LineStBC.enabled = true;
                //rrM1_4LineStCA.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_4LineStCA.enabled = true;

                //rrM1_4LineStDE.enabled = kyotuEla.tenmetuOnOff;
                rrM1_4LineStDE.enabled = true;

                //rrM1_4LineStEF.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_4LineStFD.enabled = kyotuEla.tenmetuOnOff;

                rrM1_4kakuBAC.enabled = true;
                //rrM1_4kakuABC.enabled = true;
                //rrM1_4kakuACB.enabled = true;

                rrM1_4kakuEDF.enabled = true;
                //rrM1_4kakuDEF.enabled = true;
                //rrM1_4kakuDFE.enabled = true;

                //rrM1_4kakuStABC.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_4kakuStABC.enabled = true;

                //rrM1_4kakuStACB.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_4kakuStACB.enabled = true;
                rrM1_4kakuStBAC.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_4kakuStBAC.enabled = true;

                //rrM1_4kakuStDEF.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_4kakuStDFE.enabled = kyotuEla.tenmetuOnOff;
                rrM1_4kakuStEDF.enabled = kyotuEla.tenmetuOnOff;
            } else if (count == 61) {//henka61
                reset();
                //k0018_99_1_1_1://obj.GetComponent<Renderer>().material = ColorPink;
                rrM1_4LineAB.material = MColor2;
                rrM1_4LineCA.material = MColor4;
                rrM1_4LineDE.material = MColor2;
                rrM1_4LineFD.material = MColor4;

                rrM1_4LineStAB.material = MColor2;
                rrM1_4LineStBC.material = MColor5;
                rrM1_4LineStCA.material = MColor4;
                rrM1_4LineStDE.material = MColor2;
                rrM1_4LineStEF.material = MColor5;
                rrM1_4LineStFD.material = MColor4;

                rrM1_4TextA.enabled = true;
                rrM1_4TextB.enabled = true;
                rrM1_4TextC.enabled = true;
                rrM1_4TextD.enabled = true;
                rrM1_4TextE.enabled = true;
                rrM1_4TextF.enabled = true;

                rrM1_4PointA.enabled = true;
                rrM1_4PointB.enabled = true;
                rrM1_4PointC.enabled = true;
                rrM1_4PointD.enabled = true;
                rrM1_4PointE.enabled = true;
                rrM1_4PointF.enabled = true;

                //rrM1_4PointStA.enabled = kyotuEla.tenmetuOnOff;
                rrM1_4PointStA.enabled = true;

                //rrM1_4PointStB.enabled = kyotuEla.tenmetuOnOff;
                rrM1_4PointStB.enabled = true;

                //rrM1_4PointStD.enabled = kyotuEla.tenmetuOnOff;
                rrM1_4PointStD.enabled = true;

                //rrM1_4PointStE.enabled = kyotuEla.tenmetuOnOff;
                rrM1_4PointStE.enabled = true;

                rrM1_4LineAB.enabled = true;
                rrM1_4LineBC.enabled = true;
                rrM1_4LineCA.enabled = true;
                rrM1_4LineDE.enabled = true;
                rrM1_4LineEF.enabled = true;
                rrM1_4LineFD.enabled = true;

                //rrM1_4LineStAB.enabled = kyotuEla.tenmetuOnOff;
                rrM1_4LineStAB.enabled = true;

                //rrM1_4LineStBC.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_4LineStBC.enabled = true;
                //rrM1_4LineStCA.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_4LineStCA.enabled = true;

                //rrM1_4LineStDE.enabled = kyotuEla.tenmetuOnOff;
                rrM1_4LineStDE.enabled = true;

                //rrM1_4LineStEF.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_4LineStFD.enabled = kyotuEla.tenmetuOnOff;

                rrM1_4kakuBAC.enabled = true;
                //rrM1_4kakuABC.enabled = true;
                //rrM1_4kakuACB.enabled = true;

                rrM1_4kakuEDF.enabled = true;
                //rrM1_4kakuDEF.enabled = true;
                //rrM1_4kakuDFE.enabled = true;

                //rrM1_4kakuStABC.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_4kakuStABC.enabled = true;

                //rrM1_4kakuStACB.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_4kakuStACB.enabled = true;
                rrM1_4kakuStBAC.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_4kakuStBAC.enabled = true;

                //rrM1_4kakuStDEF.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_4kakuStDFE.enabled = kyotuEla.tenmetuOnOff;
                rrM1_4kakuStEDF.enabled = kyotuEla.tenmetuOnOff;
            } else if (count == 62) {//henka62
                reset();
                //k0018_99_1_1_1://obj.GetComponent<Renderer>().material = ColorPink;
                rrM1_4LineAB.material = MColor2;
                rrM1_4LineCA.material = MColor4;
                rrM1_4LineDE.material = MColor2;
                rrM1_4LineFD.material = MColor4;

                rrM1_4LineStAB.material = MColor2;
                rrM1_4LineStBC.material = MColor5;
                rrM1_4LineStCA.material = MColor4;
                rrM1_4LineStDE.material = MColor2;
                rrM1_4LineStEF.material = MColor5;
                rrM1_4LineStFD.material = MColor4;

                rrM1_4TextA.enabled = true;
                rrM1_4TextB.enabled = true;
                rrM1_4TextC.enabled = true;
                rrM1_4TextD.enabled = true;
                rrM1_4TextE.enabled = true;
                rrM1_4TextF.enabled = true;

                rrM1_4PointA.enabled = true;
                rrM1_4PointB.enabled = true;
                rrM1_4PointC.enabled = true;
                rrM1_4PointD.enabled = true;
                rrM1_4PointE.enabled = true;
                rrM1_4PointF.enabled = true;

                //rrM1_4PointStA.enabled = kyotuEla.tenmetuOnOff;
                rrM1_4PointStA.enabled = true;

                //rrM1_4PointStB.enabled = kyotuEla.tenmetuOnOff;
                rrM1_4PointStB.enabled = true;

                //rrM1_4PointStD.enabled = kyotuEla.tenmetuOnOff;
                rrM1_4PointStD.enabled = true;

                //rrM1_4PointStE.enabled = kyotuEla.tenmetuOnOff;
                rrM1_4PointStE.enabled = true;

                rrM1_4LineAB.enabled = true;
                rrM1_4LineBC.enabled = true;
                rrM1_4LineCA.enabled = true;
                rrM1_4LineDE.enabled = true;
                rrM1_4LineEF.enabled = true;
                rrM1_4LineFD.enabled = true;

                //rrM1_4LineStAB.enabled = kyotuEla.tenmetuOnOff;
                rrM1_4LineStAB.enabled = true;

                //rrM1_4LineStBC.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_4LineStBC.enabled = true;
                rrM1_4LineStCA.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_4LineStCA.enabled = true;

                //rrM1_4LineStDE.enabled = kyotuEla.tenmetuOnOff;
                rrM1_4LineStDE.enabled = true;

                //rrM1_4LineStEF.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_4LineStFD.enabled = kyotuEla.tenmetuOnOff;

                rrM1_4kakuBAC.enabled = true;
                //rrM1_4kakuABC.enabled = true;
                //rrM1_4kakuACB.enabled = true;

                rrM1_4kakuEDF.enabled = true;
                //rrM1_4kakuDEF.enabled = true;
                //rrM1_4kakuDFE.enabled = true;

                //rrM1_4kakuStABC.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_4kakuStABC.enabled = true;

                //rrM1_4kakuStACB.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_4kakuStACB.enabled = true;
                //rrM1_4kakuStBAC.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_4kakuStBAC.enabled = true;

                //rrM1_4kakuStDEF.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_4kakuStDFE.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_4kakuStEDF.enabled = kyotuEla.tenmetuOnOff;
            } else if (count == 63) {//henka63
                reset();
                //k0018_99_1_1_1://obj.GetComponent<Renderer>().material = ColorPink;
                rrM1_4LineAB.material = MColor2;
                rrM1_4LineCA.material = MColor4;
                rrM1_4LineDE.material = MColor2;
                rrM1_4LineFD.material = MColor4;

                rrM1_4LineStAB.material = MColor2;
                rrM1_4LineStBC.material = MColor5;
                rrM1_4LineStCA.material = MColor4;
                rrM1_4LineStDE.material = MColor2;
                rrM1_4LineStEF.material = MColor5;
                rrM1_4LineStFD.material = MColor4;

                rrM1_4TextA.enabled = true;
                rrM1_4TextB.enabled = true;
                rrM1_4TextC.enabled = true;
                rrM1_4TextD.enabled = true;
                rrM1_4TextE.enabled = true;
                rrM1_4TextF.enabled = true;

                rrM1_4PointA.enabled = true;
                rrM1_4PointB.enabled = true;
                rrM1_4PointC.enabled = true;
                rrM1_4PointD.enabled = true;
                rrM1_4PointE.enabled = true;
                rrM1_4PointF.enabled = true;

                //rrM1_4PointStA.enabled = kyotuEla.tenmetuOnOff;
                rrM1_4PointStA.enabled = true;

                //rrM1_4PointStB.enabled = kyotuEla.tenmetuOnOff;
                rrM1_4PointStB.enabled = true;

                //rrM1_4PointStD.enabled = kyotuEla.tenmetuOnOff;
                rrM1_4PointStD.enabled = true;

                //rrM1_4PointStE.enabled = kyotuEla.tenmetuOnOff;
                rrM1_4PointStE.enabled = true;

                rrM1_4LineAB.enabled = true;
                rrM1_4LineBC.enabled = true;
                rrM1_4LineCA.enabled = true;
                rrM1_4LineDE.enabled = true;
                rrM1_4LineEF.enabled = true;
                rrM1_4LineFD.enabled = true;

                //rrM1_4LineStAB.enabled = kyotuEla.tenmetuOnOff;
                rrM1_4LineStAB.enabled = true;

                //rrM1_4LineStBC.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_4LineStBC.enabled = true;
                //rrM1_4LineStCA.enabled = kyotuEla.tenmetuOnOff;
                rrM1_4LineStCA.enabled = true;

                //rrM1_4LineStDE.enabled = kyotuEla.tenmetuOnOff;
                rrM1_4LineStDE.enabled = true;

                //rrM1_4LineStEF.enabled = kyotuEla.tenmetuOnOff;
                rrM1_4LineStFD.enabled = kyotuEla.tenmetuOnOff;

                rrM1_4kakuBAC.enabled = true;
                //rrM1_4kakuABC.enabled = true;
                //rrM1_4kakuACB.enabled = true;

                rrM1_4kakuEDF.enabled = true;
                //rrM1_4kakuDEF.enabled = true;
                //rrM1_4kakuDFE.enabled = true;

                //rrM1_4kakuStABC.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_4kakuStABC.enabled = true;

                //rrM1_4kakuStACB.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_4kakuStACB.enabled = true;
                //rrM1_4kakuStBAC.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_4kakuStBAC.enabled = true;

                //rrM1_4kakuStDEF.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_4kakuStDFE.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_4kakuStEDF.enabled = kyotuEla.tenmetuOnOff;
            } else if (count == 64) {//henka64
                reset();
                //k0018_99_1_1_1://obj.GetComponent<Renderer>().material = ColorPink;
                rrM1_4LineAB.material = MColor2;
                rrM1_4LineCA.material = MColor4;
                rrM1_4LineDE.material = MColor2;
                rrM1_4LineFD.material = MColor4;

                rrM1_4LineStAB.material = MColor2;
                rrM1_4LineStBC.material = MColor5;
                rrM1_4LineStCA.material = MColor4;
                rrM1_4LineStDE.material = MColor2;
                rrM1_4LineStEF.material = MColor5;
                rrM1_4LineStFD.material = MColor4;

                rrM1_4TextA.enabled = true;
                rrM1_4TextB.enabled = true;
                rrM1_4TextC.enabled = true;
                rrM1_4TextD.enabled = true;
                rrM1_4TextE.enabled = true;
                rrM1_4TextF.enabled = true;

                rrM1_4PointA.enabled = true;
                rrM1_4PointB.enabled = true;
                rrM1_4PointC.enabled = true;
                rrM1_4PointD.enabled = true;
                rrM1_4PointE.enabled = true;
                rrM1_4PointF.enabled = true;

                //rrM1_4PointStA.enabled = kyotuEla.tenmetuOnOff;
                rrM1_4PointStA.enabled = true;

                //rrM1_4PointStB.enabled = kyotuEla.tenmetuOnOff;
                rrM1_4PointStB.enabled = true;

                //rrM1_4PointStD.enabled = kyotuEla.tenmetuOnOff;
                rrM1_4PointStD.enabled = true;

                //rrM1_4PointStE.enabled = kyotuEla.tenmetuOnOff;
                rrM1_4PointStE.enabled = true;

                rrM1_4LineAB.enabled = true;
                rrM1_4LineBC.enabled = true;
                rrM1_4LineCA.enabled = true;
                rrM1_4LineDE.enabled = true;
                rrM1_4LineEF.enabled = true;
                rrM1_4LineFD.enabled = true;

                //rrM1_4LineStAB.enabled = kyotuEla.tenmetuOnOff;
                rrM1_4LineStAB.enabled = true;

                //rrM1_4LineStBC.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_4LineStBC.enabled = true;
                rrM1_4LineStCA.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_4LineStCA.enabled = true;

                //rrM1_4LineStDE.enabled = kyotuEla.tenmetuOnOff;
                rrM1_4LineStDE.enabled = true;

                //rrM1_4LineStEF.enabled = kyotuEla.tenmetuOnOff;
                rrM1_4LineStFD.enabled = kyotuEla.tenmetuOnOff;

                rrM1_4kakuBAC.enabled = true;
                //rrM1_4kakuABC.enabled = true;
                //rrM1_4kakuACB.enabled = true;

                rrM1_4kakuEDF.enabled = true;
                //rrM1_4kakuDEF.enabled = true;
                //rrM1_4kakuDFE.enabled = true;

                //rrM1_4kakuStABC.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_4kakuStABC.enabled = true;

                //rrM1_4kakuStACB.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_4kakuStACB.enabled = true;
                //rrM1_4kakuStBAC.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_4kakuStBAC.enabled = true;

                //rrM1_4kakuStDEF.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_4kakuStDFE.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_4kakuStEDF.enabled = kyotuEla.tenmetuOnOff;
            } else if (count == 65) {//henka65
                reset();
                //k0018_99_1_1_1://obj.GetComponent<Renderer>().material = ColorPink;
                rrM1_4LineAB.material = MColor2;
                rrM1_4LineCA.material = MColor4;
                rrM1_4LineDE.material = MColor2;
                rrM1_4LineFD.material = MColor4;

                rrM1_4LineStAB.material = MColor2;
                rrM1_4LineStBC.material = MColor5;
                rrM1_4LineStCA.material = MColor4;
                rrM1_4LineStDE.material = MColor2;
                rrM1_4LineStEF.material = MColor5;
                rrM1_4LineStFD.material = MColor4;

                rrM1_4TextA.enabled = true;
                rrM1_4TextB.enabled = true;
                rrM1_4TextC.enabled = true;
                rrM1_4TextD.enabled = true;
                rrM1_4TextE.enabled = true;
                rrM1_4TextF.enabled = true;

                rrM1_4PointA.enabled = true;
                rrM1_4PointB.enabled = true;
                rrM1_4PointC.enabled = true;
                rrM1_4PointD.enabled = true;
                rrM1_4PointE.enabled = true;
                rrM1_4PointF.enabled = true;

                //rrM1_4PointStA.enabled = kyotuEla.tenmetuOnOff;
                rrM1_4PointStA.enabled = true;

                //rrM1_4PointStB.enabled = kyotuEla.tenmetuOnOff;
                rrM1_4PointStB.enabled = true;

                //rrM1_4PointStD.enabled = kyotuEla.tenmetuOnOff;
                rrM1_4PointStD.enabled = true;

                //rrM1_4PointStE.enabled = kyotuEla.tenmetuOnOff;
                rrM1_4PointStE.enabled = true;

                rrM1_4LineAB.enabled = true;
                rrM1_4LineBC.enabled = true;
                rrM1_4LineCA.enabled = true;
                rrM1_4LineDE.enabled = true;
                rrM1_4LineEF.enabled = true;
                rrM1_4LineFD.enabled = true;

                //rrM1_4LineStAB.enabled = kyotuEla.tenmetuOnOff;
                rrM1_4LineStAB.enabled = true;

                //rrM1_4LineStBC.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_4LineStBC.enabled = true;
                rrM1_4LineStCA.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_4LineStCA.enabled = true;

                //rrM1_4LineStDE.enabled = kyotuEla.tenmetuOnOff;
                rrM1_4LineStDE.enabled = true;

                //rrM1_4LineStEF.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_4LineStFD.enabled = kyotuEla.tenmetuOnOff;

                rrM1_4kakuBAC.enabled = true;
                //rrM1_4kakuABC.enabled = true;
                //rrM1_4kakuACB.enabled = true;

                rrM1_4kakuEDF.enabled = true;
                //rrM1_4kakuDEF.enabled = true;
                //rrM1_4kakuDFE.enabled = true;

                //rrM1_4kakuStABC.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_4kakuStABC.enabled = true;

                //rrM1_4kakuStACB.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_4kakuStACB.enabled = true;
                //rrM1_4kakuStBAC.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_4kakuStBAC.enabled = true;

                //rrM1_4kakuStDEF.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_4kakuStDFE.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_4kakuStEDF.enabled = kyotuEla.tenmetuOnOff;
            } else if (count == 66) {//henka66
                reset();
                //k0018_99_1_1_1://obj.GetComponent<Renderer>().material = ColorPink;
                rrM1_4LineAB.material = MColor2;
                rrM1_4LineCA.material = MColor4;
                rrM1_4LineDE.material = MColor2;
                rrM1_4LineFD.material = MColor4;

                rrM1_4LineStAB.material = MColor2;
                rrM1_4LineStBC.material = MColor5;
                rrM1_4LineStCA.material = MColor4;
                rrM1_4LineStDE.material = MColor2;
                rrM1_4LineStEF.material = MColor5;
                rrM1_4LineStFD.material = MColor4;

                rrM1_4TextA.enabled = true;
                rrM1_4TextB.enabled = true;
                rrM1_4TextC.enabled = true;
                rrM1_4TextD.enabled = true;
                rrM1_4TextE.enabled = true;
                rrM1_4TextF.enabled = true;

                rrM1_4PointA.enabled = true;
                rrM1_4PointB.enabled = true;
                rrM1_4PointC.enabled = true;
                rrM1_4PointD.enabled = true;
                rrM1_4PointE.enabled = true;
                rrM1_4PointF.enabled = true;

                //rrM1_4PointStA.enabled = kyotuEla.tenmetuOnOff;
                rrM1_4PointStA.enabled = true;

                //rrM1_4PointStB.enabled = kyotuEla.tenmetuOnOff;
                rrM1_4PointStB.enabled = true;

                //rrM1_4PointStD.enabled = kyotuEla.tenmetuOnOff;
                rrM1_4PointStD.enabled = true;

                //rrM1_4PointStE.enabled = kyotuEla.tenmetuOnOff;
                rrM1_4PointStE.enabled = true;

                rrM1_4LineAB.enabled = true;
                rrM1_4LineBC.enabled = true;
                rrM1_4LineCA.enabled = true;
                rrM1_4LineDE.enabled = true;
                rrM1_4LineEF.enabled = true;
                rrM1_4LineFD.enabled = true;

                //rrM1_4LineStAB.enabled = kyotuEla.tenmetuOnOff;
                rrM1_4LineStAB.enabled = true;

                //rrM1_4LineStBC.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_4LineStBC.enabled = true;
                //rrM1_4LineStCA.enabled = kyotuEla.tenmetuOnOff;
                rrM1_4LineStCA.enabled = true;

                //rrM1_4LineStDE.enabled = kyotuEla.tenmetuOnOff;
                rrM1_4LineStDE.enabled = true;

                //rrM1_4LineStEF.enabled = kyotuEla.tenmetuOnOff;
                rrM1_4LineStFD.enabled = kyotuEla.tenmetuOnOff;

                rrM1_4kakuBAC.enabled = true;
                //rrM1_4kakuABC.enabled = true;
                //rrM1_4kakuACB.enabled = true;

                rrM1_4kakuEDF.enabled = true;
                //rrM1_4kakuDEF.enabled = true;
                //rrM1_4kakuDFE.enabled = true;

                //rrM1_4kakuStABC.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_4kakuStABC.enabled = true;

                //rrM1_4kakuStACB.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_4kakuStACB.enabled = true;
                //rrM1_4kakuStBAC.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_4kakuStBAC.enabled = true;

                //rrM1_4kakuStDEF.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_4kakuStDFE.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_4kakuStEDF.enabled = kyotuEla.tenmetuOnOff;
            } else if (count == 67) {//henka67
                reset();
                //k0018_99_1_1_1://obj.GetComponent<Renderer>().material = ColorPink;
                rrM1_4LineAB.material = MColor2;
                rrM1_4LineCA.material = MColor4;
                rrM1_4LineDE.material = MColor2;
                rrM1_4LineFD.material = MColor4;

                rrM1_4LineStAB.material = MColor2;
                rrM1_4LineStBC.material = MColor5;
                rrM1_4LineStCA.material = MColor4;
                rrM1_4LineStDE.material = MColor2;
                rrM1_4LineStEF.material = MColor5;
                rrM1_4LineStFD.material = MColor4;

                rrM1_4TextA.enabled = true;
                rrM1_4TextB.enabled = true;
                rrM1_4TextC.enabled = true;
                rrM1_4TextD.enabled = true;
                rrM1_4TextE.enabled = true;
                rrM1_4TextF.enabled = true;

                rrM1_4PointA.enabled = true;
                rrM1_4PointB.enabled = true;
                rrM1_4PointC.enabled = true;
                rrM1_4PointD.enabled = true;
                rrM1_4PointE.enabled = true;
                rrM1_4PointF.enabled = true;

                //rrM1_4PointStA.enabled = kyotuEla.tenmetuOnOff;
                rrM1_4PointStA.enabled = true;

                //rrM1_4PointStB.enabled = kyotuEla.tenmetuOnOff;
                rrM1_4PointStB.enabled = true;

                //rrM1_4PointStD.enabled = kyotuEla.tenmetuOnOff;
                rrM1_4PointStD.enabled = true;

                //rrM1_4PointStE.enabled = kyotuEla.tenmetuOnOff;
                rrM1_4PointStE.enabled = true;

                rrM1_4LineAB.enabled = true;
                rrM1_4LineBC.enabled = true;
                rrM1_4LineCA.enabled = true;
                rrM1_4LineDE.enabled = true;
                rrM1_4LineEF.enabled = true;
                rrM1_4LineFD.enabled = true;

                //rrM1_4LineStAB.enabled = kyotuEla.tenmetuOnOff;
                rrM1_4LineStAB.enabled = true;

                //rrM1_4LineStBC.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_4LineStBC.enabled = true;
                rrM1_4LineStCA.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_4LineStCA.enabled = true;

                //rrM1_4LineStDE.enabled = kyotuEla.tenmetuOnOff;
                rrM1_4LineStDE.enabled = true;

                //rrM1_4LineStEF.enabled = kyotuEla.tenmetuOnOff;
                rrM1_4LineStFD.enabled = kyotuEla.tenmetuOnOff;

                rrM1_4kakuBAC.enabled = true;
                //rrM1_4kakuABC.enabled = true;
                //rrM1_4kakuACB.enabled = true;

                rrM1_4kakuEDF.enabled = true;
                //rrM1_4kakuDEF.enabled = true;
                //rrM1_4kakuDFE.enabled = true;

                //rrM1_4kakuStABC.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_4kakuStABC.enabled = true;

                //rrM1_4kakuStACB.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_4kakuStACB.enabled = true;
                //rrM1_4kakuStBAC.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_4kakuStBAC.enabled = true;

                //rrM1_4kakuStDEF.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_4kakuStDFE.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_4kakuStEDF.enabled = kyotuEla.tenmetuOnOff;
            } else if (count == 68) {//henka68
                reset();
                //k0018_99_1_1_1://obj.GetComponent<Renderer>().material = ColorPink;
                rrM1_4LineAB.material = MColor2;
                rrM1_4LineCA.material = MColor4;
                rrM1_4LineDE.material = MColor2;
                rrM1_4LineFD.material = MColor4;

                rrM1_4LineStAB.material = MColor2;
                rrM1_4LineStBC.material = MColor5;
                rrM1_4LineStCA.material = MColor4;
                rrM1_4LineStDE.material = MColor2;
                rrM1_4LineStEF.material = MColor5;
                rrM1_4LineStFD.material = MColor4;

                rrM1_4TextA.enabled = true;
                rrM1_4TextB.enabled = true;
                rrM1_4TextC.enabled = true;
                rrM1_4TextD.enabled = true;
                rrM1_4TextE.enabled = true;
                rrM1_4TextF.enabled = true;

                rrM1_4PointA.enabled = true;
                rrM1_4PointB.enabled = true;
                rrM1_4PointC.enabled = true;
                rrM1_4PointD.enabled = true;
                rrM1_4PointE.enabled = true;
                rrM1_4PointF.enabled = true;

                //rrM1_4PointStA.enabled = kyotuEla.tenmetuOnOff;
                rrM1_4PointStA.enabled = true;

                //rrM1_4PointStB.enabled = kyotuEla.tenmetuOnOff;
                rrM1_4PointStB.enabled = true;

                //rrM1_4PointStD.enabled = kyotuEla.tenmetuOnOff;
                rrM1_4PointStD.enabled = true;

                //rrM1_4PointStE.enabled = kyotuEla.tenmetuOnOff;
                rrM1_4PointStE.enabled = true;

                rrM1_4LineAB.enabled = true;
                rrM1_4LineBC.enabled = true;
                rrM1_4LineCA.enabled = true;
                rrM1_4LineDE.enabled = true;
                rrM1_4LineEF.enabled = true;
                rrM1_4LineFD.enabled = true;

                //rrM1_4LineStAB.enabled = kyotuEla.tenmetuOnOff;
                rrM1_4LineStAB.enabled = true;

                //rrM1_4LineStBC.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_4LineStBC.enabled = true;
                rrM1_4LineStCA.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_4LineStCA.enabled = true;

                //rrM1_4LineStDE.enabled = kyotuEla.tenmetuOnOff;
                rrM1_4LineStDE.enabled = true;

                //rrM1_4LineStEF.enabled = kyotuEla.tenmetuOnOff;
                rrM1_4LineStFD.enabled = kyotuEla.tenmetuOnOff;

                rrM1_4kakuBAC.enabled = true;
                //rrM1_4kakuABC.enabled = true;
                //rrM1_4kakuACB.enabled = true;

                rrM1_4kakuEDF.enabled = true;
                //rrM1_4kakuDEF.enabled = true;
                //rrM1_4kakuDFE.enabled = true;

                //rrM1_4kakuStABC.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_4kakuStABC.enabled = true;

                //rrM1_4kakuStACB.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_4kakuStACB.enabled = true;
                //rrM1_4kakuStBAC.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_4kakuStBAC.enabled = true;

                //rrM1_4kakuStDEF.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_4kakuStDFE.enabled = kyotuEla.tenmetuOnOff;
                //rrM1_4kakuStEDF.enabled = kyotuEla.tenmetuOnOff;
            }
        }
    }
}
