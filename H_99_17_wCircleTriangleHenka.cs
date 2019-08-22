using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class H_99_17_wCircleTriangleHenka : MonoBehaviour
{

    //いちいちunityで当てはめなきゃ駄目　↓---------------

    //k5_3_1_1:gameobject(メソッド、変数)を使いまわす
    public H_99_01_kyoutuHensu kyotu;

    //強調表現点滅に使う変数を共通変数として使う。
    public H_99_01B_kyotuElapse kyotuEla;

    public GameObject wcLineAB;
    public GameObject wcLineSAB;

    public GameObject wcLineBC;
    public GameObject wcLineSBC;

    public GameObject wcLineCA;
    public GameObject wcLineSCA;

    //public GameObject wcLineAP;
    //public GameObject wcLineSAP;

    //zukei のポイントを表すgameobject
    //アタッチするのはPPRRPointAであることに注意

    public GameObject M1_1StPointA;
    public GameObject wcPointA;
    public GameObject wcTextA;
    public GameObject wcStrongTextCubeA;

    public GameObject M1_1StPointB;
    public GameObject wcPointB;
    public GameObject wcTextB;
    public GameObject wcStrongTextCubeB;

    public GameObject M1_1StPointC;
    public GameObject wcPointC;
    public GameObject wcTextC;
    public GameObject wcStrongTextCubeC;

    public GameObject M1_1StPointD;
    public GameObject wcPointD;
    public GameObject wcTextD;
    public GameObject wcStrongTextCubeD;

    public GameObject M1_1StPointE;
    public GameObject wcPointE;
    public GameObject wcTextE;
    public GameObject wcStrongTextCubeE;

    public GameObject wcCylinder1;
    public GameObject stWcCylinder1;//強調用

    public GameObject wcCylinder2;
    public GameObject stWcCylinder2;//強調用

    //いちいちunityで当てはめなきゃ駄目　↑---------------
    //線分を出したり消したりするときに使う Rendererを当てはめる
    //線のrenderer
    private Renderer rrlineAB;
    private Renderer rrlineSAB;

    private Renderer rrlineBC;
    private Renderer rrlineSBC;

    private Renderer rrlineCA;
    private Renderer rrlineSCA;

    //点のrenderer
    private Renderer rrM1_1StPointA;
    private Renderer rrPointA;
    private Renderer rrTextA;
    private Renderer rrStrongTextCubeA;

    private Renderer rrM1_1StPointB;
    private Renderer rrPointB;
    private Renderer rrTextB;
    private Renderer rrStrongTextCubeB;

    private Renderer rrM1_1StPointC;
    private Renderer rrPointC;
    private Renderer rrTextC;
    private Renderer rrStrongTextCubeC;

    private Renderer rrM1_1StPointD;
    private Renderer rrPointD;
    private Renderer rrTextD;
    private Renderer rrStrongTextCubeD;

    private Renderer rrM1_1StPointE;
    private Renderer rrPointE;
    private Renderer rrTextE;
    private Renderer rrStrongTextCubeE;

    //後ろの２つの円のrenderer
    private Renderer rrCylinder1;
    private Renderer rrStCylinder1;

    private Renderer rrCylinder2;
    private Renderer rrStCylinder2;

    void Start()
    {
        //redererを当てはめていく
        rrlineAB = wcLineAB.GetComponent<Renderer>();
        rrlineSAB = wcLineSAB.GetComponent<Renderer>();

        rrlineBC = wcLineBC.GetComponent<Renderer>();
        rrlineSBC = wcLineSBC.GetComponent<Renderer>();

        rrlineCA = wcLineCA.GetComponent<Renderer>();
        rrlineSCA = wcLineSCA.GetComponent<Renderer>();

        rrM1_1StPointA = M1_1StPointA.GetComponent<Renderer>();
        rrPointA = wcPointA.GetComponent<Renderer>();
        rrTextA = wcTextA.GetComponent<Renderer>();
        rrStrongTextCubeA = wcStrongTextCubeA.GetComponent<Renderer>();

        rrM1_1StPointB = M1_1StPointB.GetComponent<Renderer>();
        rrPointB = wcPointB.GetComponent<Renderer>();
        rrTextB = wcTextB.GetComponent<Renderer>();
        rrStrongTextCubeB = wcStrongTextCubeB.GetComponent<Renderer>();

        rrM1_1StPointC = M1_1StPointC.GetComponent<Renderer>();
        rrPointC = wcPointC.GetComponent<Renderer>();
        rrTextC = wcTextC.GetComponent<Renderer>();
        rrStrongTextCubeC = wcStrongTextCubeC.GetComponent<Renderer>();

        rrM1_1StPointD = M1_1StPointD.GetComponent<Renderer>();
        rrPointD = wcPointD.GetComponent<Renderer>();
        rrTextD = wcTextD.GetComponent<Renderer>();
        rrStrongTextCubeD = wcStrongTextCubeD.GetComponent<Renderer>();

        rrM1_1StPointE = M1_1StPointE.GetComponent<Renderer>();
        rrPointE = wcPointE.GetComponent<Renderer>();
        rrTextE = wcTextE.GetComponent<Renderer>();
        rrStrongTextCubeE = wcStrongTextCubeE.GetComponent<Renderer>();

        // 後ろの２つの円のrenderer
        rrCylinder1 =wcCylinder1.GetComponent<Renderer>();
        rrStCylinder1= stWcCylinder1.GetComponent<Renderer>();

        rrCylinder2 = wcCylinder2.GetComponent<Renderer>();
        rrStCylinder2 = stWcCylinder2.GetComponent<Renderer>();
    }

    // Update is called once per frame
    void Update()
    {
        henka(kyotu.rrCount);
        

    }
    //rrCountでオブジェの表示、強調を変化させるメソッド---------------------------
    private void henka(int count) 
    {
        //m1_1のときのみ実行
        if (kyotu.mojiSwitch == 3 & kyotu.MCount == 0) 
        {
            if (count == 5) {
                reset();
                rrTextA.enabled = true;
                rrTextB.enabled = true;
                rrlineAB.enabled = true;
                rrlineSAB.enabled = kyotuEla.tenmetuOnOff;
            } else if (count == 6) {
                reset();
                rrTextA.enabled = true;
                rrTextB.enabled = true;
                rrlineAB.enabled = true;
            } else if (count == 7) {
                reset();
                rrTextA.enabled = true;
                rrTextB.enabled = true;
                rrlineAB.enabled = true;
                rrlineSAB.enabled = kyotuEla.tenmetuOnOff;
            } else if (count == 8) {
                reset();
                rrTextA.enabled = true;
                rrTextB.enabled = true;

                rrlineAB.enabled = true;
                rrlineSAB.enabled = kyotuEla.tenmetuOnOff;
                rrlineBC.enabled = true;
                rrlineSBC.enabled = kyotuEla.tenmetuOnOff;
                rrlineCA.enabled = true;
                rrlineSCA.enabled = kyotuEla.tenmetuOnOff;
            } else if (count == 9) {
                reset();
                rrTextA.enabled = true;
                rrTextB.enabled = true;

                rrlineAB.enabled = true;
                rrlineBC.enabled = true;
                rrlineCA.enabled = true;
            } else if (count == 10) {
                reset();

                rrTextA.enabled = true;

                rrTextB.enabled = true;

                rrlineAB.enabled = true;

                rrM1_1StPointA.enabled= kyotuEla.tenmetuOnOff;
                rrPointA.enabled = true; 


            } else if (count == 11) {
                reset();

                rrTextA.enabled = true;

                rrTextB.enabled = true;

                rrlineAB.enabled = true;


                rrlineSAB.enabled = kyotuEla.tenmetuOnOff;

                rrPointA.enabled = true;

            } else if (count == 12) {
                reset();

                rrTextA.enabled = true;
                rrTextB.enabled = true;
                rrTextC.enabled = true;
                rrTextD.enabled = true;

                rrlineAB.enabled = true;


                rrPointA.enabled = true;
                rrPointB.enabled = true;
                rrPointC.enabled = true;
                rrPointD.enabled = true;

                rrCylinder1.enabled = true;
                rrStCylinder1.enabled = kyotuEla.tenmetuOnOff;

            } else if (count == 13) {
                reset();
                rrTextA.enabled = true;
                rrTextB.enabled = true;
                rrTextC.enabled = true;
                rrTextD.enabled = true;
                //rrTextE.enabled = true;

                rrlineAB.enabled = true;

                rrPointA.enabled = true;
                rrPointB.enabled = true;
                rrPointC.enabled = true;
                rrPointD.enabled = true;

                rrCylinder1.enabled = true;
            } else if (count == 14) {
                reset();
                rrTextA.enabled = true;
                rrTextB.enabled = true;
                rrTextC.enabled = true;
                rrTextD.enabled = true;
                //rrTextE.enabled = true;

                rrlineAB.enabled = true;
                rrlineSAB.enabled = kyotuEla.tenmetuOnOff;


                rrPointA.enabled = true;
                rrPointB.enabled = true;
                rrPointC.enabled = true;
                rrPointD.enabled = true;

                rrCylinder1.enabled = true;
            } else if (count == 15) {
                reset();
                rrTextA.enabled = true;
                rrTextB.enabled = true;
                rrTextC.enabled = true;
                rrTextD.enabled = true;
                rrTextE.enabled = true;

                rrlineAB.enabled = true;
                //rrlineSAB.enabled = kyotuEla.tenmetuOnOff;


                rrPointA.enabled = true;
                rrPointB.enabled = true;
                rrPointC.enabled = true;
                rrPointD.enabled = true;
                rrPointE.enabled = true;

                rrCylinder1.enabled = true;

                rrCylinder2.enabled = true;
                rrStCylinder2.enabled = kyotuEla.tenmetuOnOff;
            } else if (count == 16) {
                reset();
                rrTextA.enabled = true;
                rrTextB.enabled = true;
                rrTextC.enabled = true;
                rrTextD.enabled = true;
                rrTextE.enabled = true;

                rrlineAB.enabled = true;
                //rrlineSAB.enabled = kyotuEla.tenmetuOnOff;

                rrPointA.enabled = true;
                rrPointB.enabled = true;
                rrPointC.enabled = true;
                rrPointD.enabled = true;
                rrPointE.enabled = true;

                rrCylinder1.enabled = true;

                rrCylinder2.enabled = true;
                //rrStCylinder2.enabled = kyotuEla.tenmetuOnOff;
            } else if (count == 17) {
                reset();
                rrTextA.enabled = true;
                rrTextB.enabled = true;
                rrTextC.enabled = true;
                rrTextD.enabled = true;
                rrTextE.enabled = true;

                rrlineAB.enabled = true;
                //rrlineSAB.enabled = kyotuEla.tenmetuOnOff;

                rrPointA.enabled = true;
                rrPointB.enabled = true;

                rrM1_1StPointC.enabled = kyotuEla.tenmetuOnOff;
                rrPointC.enabled = true;
                rrPointD.enabled = true;
                rrPointE.enabled = true;

                rrCylinder1.enabled = true;

                rrCylinder2.enabled = true;
                //rrStCylinder2.enabled = kyotuEla.tenmetuOnOff;
            } else if (count == 18) {
                reset();
                rrTextA.enabled = true;
                rrTextB.enabled = true;
                rrTextC.enabled = true;
                rrTextD.enabled = true;
                rrTextE.enabled = true;

                rrlineAB.enabled = true;
                //rrlineSAB.enabled = kyotuEla.tenmetuOnOff;

                rrM1_1StPointA.enabled = kyotuEla.tenmetuOnOff;
                rrPointA.enabled = true;
                rrPointB.enabled = true;
                rrPointC.enabled = true;
                rrPointD.enabled = true;
                rrPointE.enabled = true;

                rrCylinder1.enabled = true;

                rrCylinder2.enabled = true;
                //rrStCylinder2.enabled = kyotuEla.tenmetuOnOff;
            } else if (count == 19) {
                reset();
                rrTextA.enabled = true;
                rrTextB.enabled = true;
                rrTextC.enabled = true;
                rrTextD.enabled = true;
                rrTextE.enabled = true;

                rrlineAB.enabled = true;
                //rrlineSAB.enabled = kyotuEla.tenmetuOnOff;

                rrPointA.enabled = true;

                rrM1_1StPointB.enabled = kyotuEla.tenmetuOnOff;
                rrPointB.enabled = true;

                rrPointC.enabled = true;
                rrPointD.enabled = true;
                rrPointE.enabled = true;

                rrCylinder1.enabled = true;

                rrCylinder2.enabled = true;
                //rrStCylinder2.enabled = kyotuEla.tenmetuOnOff;
            } else if (count == 20) {
                reset();
                rrTextA.enabled = true;
                rrTextB.enabled = true;
                rrTextC.enabled = true;
                rrTextD.enabled = true;
                rrTextE.enabled = true;

                rrlineAB.enabled = true;
                rrlineCA.enabled = true;
                rrlineSCA.enabled = kyotuEla.tenmetuOnOff;
                //rrlineSAB.enabled = kyotuEla.tenmetuOnOff;

                rrPointA.enabled = true;
                rrPointB.enabled = true;
                rrPointC.enabled = true;
                rrPointD.enabled = true;
                rrPointE.enabled = true;

                rrCylinder1.enabled = true;

                rrCylinder2.enabled = true;
                //rrStCylinder2.enabled = kyotuEla.tenmetuOnOff;
            } else if (count == 21) {
                reset();
                rrTextA.enabled = true;
                rrTextB.enabled = true;
                rrTextC.enabled = true;
                rrTextD.enabled = true;
                rrTextE.enabled = true;

                rrlineAB.enabled = true;
                rrlineBC.enabled = true;
                rrlineCA.enabled = true;

                rrlineSBC.enabled = kyotuEla.tenmetuOnOff;
                //rrlineSAB.enabled = kyotuEla.tenmetuOnOff;

                rrPointA.enabled = true;
                rrPointB.enabled = true;
                rrPointC.enabled = true;
                rrPointD.enabled = true;
                rrPointE.enabled = true;

                rrCylinder1.enabled = true;

                rrCylinder2.enabled = true;
                //rrStCylinder2.enabled = kyotuEla.tenmetuOnOff;
            } else if (count == 22) {
                reset();
                rrTextA.enabled = true;
                rrTextB.enabled = true;
                rrTextC.enabled = true;
                rrTextD.enabled = true;
                rrTextE.enabled = true;

                rrlineAB.enabled = true;
                rrlineBC.enabled = true;
                rrlineCA.enabled = true;

                //rrlineSBC.enabled = kyotuEla.tenmetuOnOff;
                //rrlineSAB.enabled = kyotuEla.tenmetuOnOff;

                rrPointA.enabled = true;
                rrPointB.enabled = true;
                rrPointC.enabled = true;
                rrPointD.enabled = true;
                rrPointE.enabled = true;

                rrCylinder1.enabled = true;

                rrCylinder2.enabled = true;
                //rrStCylinder2.enabled = kyotuEla.tenmetuOnOff;        
            } else if (count == 23) {
                reset();
                rrTextA.enabled = true;
                rrTextB.enabled = true;
                rrTextC.enabled = true;
                rrTextD.enabled = true;
                rrTextE.enabled = true;

                rrlineAB.enabled = true;
                rrlineBC.enabled = true;
                rrlineCA.enabled = true;

                //rrlineSBC.enabled = kyotuEla.tenmetuOnOff;
                //rrlineSAB.enabled = kyotuEla.tenmetuOnOff;

                rrM1_1StPointA.enabled = kyotuEla.tenmetuOnOff;
                rrPointA.enabled = true;
                rrPointB.enabled = true;
                rrPointC.enabled = true;
                rrPointD.enabled = true;
                rrPointE.enabled = true;

                rrCylinder1.enabled = true;

                rrCylinder2.enabled = true;
                //rrStCylinder2.enabled = kyotuEla.tenmetuOnOff;
            } else if (count == 24) {
                reset();
                rrTextA.enabled = true;
                rrTextB.enabled = true;
                rrTextC.enabled = true;
                rrTextD.enabled = true;
                rrTextE.enabled = true;

                rrlineAB.enabled = true;
                rrlineBC.enabled = true;
                rrlineCA.enabled = true;

                //rrlineSBC.enabled = kyotuEla.tenmetuOnOff;
                //rrlineSAB.enabled = kyotuEla.tenmetuOnOff;

                rrPointA.enabled = true;
                rrPointB.enabled = true;
                rrPointC.enabled = true;
                rrPointD.enabled = true;
                rrPointE.enabled = true;

                rrCylinder1.enabled = true;
                rrStCylinder1.enabled = kyotuEla.tenmetuOnOff;
                rrCylinder2.enabled = true;
                //rrStCylinder2.enabled = kyotuEla.tenmetuOnOff;
            } else if (count == 25) {
                reset();
                rrTextA.enabled = true;
                rrTextB.enabled = true;
                rrTextC.enabled = true;
                rrTextD.enabled = true;
                rrTextE.enabled = true;

                rrlineAB.enabled = true;
                rrlineBC.enabled = true;
                rrlineCA.enabled = true;
                rrlineSCA.enabled = kyotuEla.tenmetuOnOff;
                //rrlineSBC.enabled = kyotuEla.tenmetuOnOff;
                //rrlineSAB.enabled = kyotuEla.tenmetuOnOff;

                rrPointA.enabled = true;
                rrPointB.enabled = true;
                rrPointC.enabled = true;
                rrPointD.enabled = true;
                rrPointE.enabled = true;

                rrCylinder1.enabled = true;
                //rrStCylinder1.enabled = kyotuEla.tenmetuOnOff;
                rrCylinder2.enabled = true;
                //rrStCylinder2.enabled = kyotuEla.tenmetuOnOff;
            } else if (count == 26) {
                reset();
                rrTextA.enabled = true;
                rrTextB.enabled = true;
                rrTextC.enabled = true;
                rrTextD.enabled = true;
                rrTextE.enabled = true;

                rrlineAB.enabled = true;
                rrlineBC.enabled = true;
                rrlineCA.enabled = true;
                //rrlineSCA.enabled = kyotuEla.tenmetuOnOff;
                //rrlineSBC.enabled = kyotuEla.tenmetuOnOff;
                rrlineSAB.enabled = kyotuEla.tenmetuOnOff;

                rrPointA.enabled = true;
                rrPointB.enabled = true;
                rrPointC.enabled = true;
                rrPointD.enabled = true;
                rrPointE.enabled = true;

                rrCylinder1.enabled = true;
                //rrStCylinder1.enabled = kyotuEla.tenmetuOnOff;
                rrCylinder2.enabled = true;
                //rrStCylinder2.enabled = kyotuEla.tenmetuOnOff;
            } else if (count == 27) {
                reset();
                rrTextA.enabled = true;
                rrTextB.enabled = true;
                rrTextC.enabled = true;
                rrTextD.enabled = true;
                rrTextE.enabled = true;

                rrlineAB.enabled = true;
                rrlineBC.enabled = true;
                rrlineCA.enabled = true;
                //rrlineSCA.enabled = kyotuEla.tenmetuOnOff;
                //rrlineSBC.enabled = kyotuEla.tenmetuOnOff;
                //rrlineSAB.enabled = kyotuEla.tenmetuOnOff;

                rrPointA.enabled = true;
                rrPointB.enabled = true;
                rrPointC.enabled = true;
                rrPointD.enabled = true;
                rrPointE.enabled = true;

                rrCylinder1.enabled = true;
                //rrStCylinder1.enabled = kyotuEla.tenmetuOnOff;
                rrCylinder2.enabled = true;
                //rrStCylinder2.enabled = kyotuEla.tenmetuOnOff;
            } else if (count == 28) {
                reset();
                rrTextA.enabled = true;
                rrTextB.enabled = true;
                rrTextC.enabled = true;
                rrTextD.enabled = true;
                rrTextE.enabled = true;

                rrlineAB.enabled = true;
                rrlineBC.enabled = true;
                rrlineCA.enabled = true;
                //rrlineSCA.enabled = kyotuEla.tenmetuOnOff;
                //rrlineSBC.enabled = kyotuEla.tenmetuOnOff;
                //rrlineSAB.enabled = kyotuEla.tenmetuOnOff;

                rrPointA.enabled = true;
                rrM1_1StPointB.enabled = kyotuEla.tenmetuOnOff;
                rrPointB.enabled = true;
                rrPointC.enabled = true;
                rrPointD.enabled = true;
                rrPointE.enabled = true;

                rrCylinder1.enabled = true;
                //rrStCylinder1.enabled = kyotuEla.tenmetuOnOff;
                rrCylinder2.enabled = true;
                //rrStCylinder2.enabled = kyotuEla.tenmetuOnOff;
            } else if (count == 29) {
                reset();
                rrTextA.enabled = true;
                rrTextB.enabled = true;
                rrTextC.enabled = true;
                rrTextD.enabled = true;
                rrTextE.enabled = true;

                rrlineAB.enabled = true;
                rrlineBC.enabled = true;
                rrlineCA.enabled = true;
                //rrlineSCA.enabled = kyotuEla.tenmetuOnOff;
                //rrlineSBC.enabled = kyotuEla.tenmetuOnOff;
                //rrlineSAB.enabled = kyotuEla.tenmetuOnOff;

                rrPointA.enabled = true;
                rrPointB.enabled = true;
                rrPointC.enabled = true;
                rrPointD.enabled = true;
                rrPointE.enabled = true;

                rrCylinder1.enabled = true;
                //rrStCylinder1.enabled = kyotuEla.tenmetuOnOff;
                rrCylinder2.enabled = true;
                rrStCylinder2.enabled = kyotuEla.tenmetuOnOff;
            } else if (count == 30) {
                reset();
                rrTextA.enabled = true;
                rrTextB.enabled = true;
                rrTextC.enabled = true;
                rrTextD.enabled = true;
                rrTextE.enabled = true;

                rrlineAB.enabled = true;
                rrlineBC.enabled = true;
                rrlineCA.enabled = true;
                //rrlineSCA.enabled = kyotuEla.tenmetuOnOff;
                rrlineSBC.enabled = kyotuEla.tenmetuOnOff;
                //rrlineSAB.enabled = kyotuEla.tenmetuOnOff;

                rrPointA.enabled = true;
                rrPointB.enabled = true;
                rrPointC.enabled = true;
                rrPointD.enabled = true;
                rrPointE.enabled = true;

                rrCylinder1.enabled = true;
                //rrStCylinder1.enabled = kyotuEla.tenmetuOnOff;
                rrCylinder2.enabled = true;
                //rrStCylinder2.enabled = kyotuEla.tenmetuOnOff;
            } else if (count == 31) {
                reset();
                rrTextA.enabled = true;
                rrTextB.enabled = true;
                rrTextC.enabled = true;
                rrTextD.enabled = true;
                rrTextE.enabled = true;

                rrlineAB.enabled = true;
                rrlineBC.enabled = true;
                rrlineCA.enabled = true;
                //rrlineSCA.enabled = kyotuEla.tenmetuOnOff;
                //rrlineSBC.enabled = kyotuEla.tenmetuOnOff;
                rrlineSAB.enabled = kyotuEla.tenmetuOnOff;

                rrPointA.enabled = true;
                rrPointB.enabled = true;
                rrPointC.enabled = true;
                rrPointD.enabled = true;
                rrPointE.enabled = true;

                rrCylinder1.enabled = true;
                //rrStCylinder1.enabled = kyotuEla.tenmetuOnOff;
                rrCylinder2.enabled = true;
                //rrStCylinder2.enabled = kyotuEla.tenmetuOnOff;
            } else if (count == 32) {
                reset();
                rrTextA.enabled = true;
                rrTextB.enabled = true;
                rrTextC.enabled = true;
                rrTextD.enabled = true;
                rrTextE.enabled = true;

                rrlineAB.enabled = true;
                rrlineBC.enabled = true;
                rrlineCA.enabled = true;
                //rrlineSCA.enabled = kyotuEla.tenmetuOnOff;
                //rrlineSBC.enabled = kyotuEla.tenmetuOnOff;
                //rrlineSAB.enabled = kyotuEla.tenmetuOnOff;

                rrPointA.enabled = true;
                rrPointB.enabled = true;
                rrPointC.enabled = true;
                rrPointD.enabled = true;
                rrPointE.enabled = true;

                rrCylinder1.enabled = true;
                //rrStCylinder1.enabled = kyotuEla.tenmetuOnOff;
                rrCylinder2.enabled = true;
                //rrStCylinder2.enabled = kyotuEla.tenmetuOnOff;
            } else if (count == 33) {
                reset();
                rrTextA.enabled = true;
                rrTextB.enabled = true;
                rrTextC.enabled = true;
                rrTextD.enabled = true;
                rrTextE.enabled = true;

                rrlineAB.enabled = true;
                rrlineBC.enabled = true;
                rrlineCA.enabled = true;
                rrlineSCA.enabled = kyotuEla.tenmetuOnOff;
                //rrlineSBC.enabled = kyotuEla.tenmetuOnOff;
                //rrlineSAB.enabled = kyotuEla.tenmetuOnOff;

                rrPointA.enabled = true;
                rrPointB.enabled = true;
                rrPointC.enabled = true;
                rrPointD.enabled = true;
                rrPointE.enabled = true;

                rrCylinder1.enabled = true;
                //rrStCylinder1.enabled = kyotuEla.tenmetuOnOff;
                rrCylinder2.enabled = true;
                //rrStCylinder2.enabled = kyotuEla.tenmetuOnOff;
            } else if (count == 34) {
                reset();
                rrTextA.enabled = true;
                rrTextB.enabled = true;
                rrTextC.enabled = true;
                rrTextD.enabled = true;
                rrTextE.enabled = true;

                rrlineAB.enabled = true;
                rrlineBC.enabled = true;
                rrlineCA.enabled = true;
                //rrlineSCA.enabled = kyotuEla.tenmetuOnOff;
                //rrlineSBC.enabled = kyotuEla.tenmetuOnOff;
                rrlineSAB.enabled = kyotuEla.tenmetuOnOff;

                rrPointA.enabled = true;
                rrPointB.enabled = true;
                rrPointC.enabled = true;
                rrPointD.enabled = true;
                rrPointE.enabled = true;

                rrCylinder1.enabled = true;
                //rrStCylinder1.enabled = kyotuEla.tenmetuOnOff;
                rrCylinder2.enabled = true;
                //rrStCylinder2.enabled = kyotuEla.tenmetuOnOff;
            } else if (count == 35) {
                reset();
                rrTextA.enabled = true;
                rrTextB.enabled = true;
                rrTextC.enabled = true;
                rrTextD.enabled = true;
                rrTextE.enabled = true;

                rrlineAB.enabled = true;
                rrlineBC.enabled = true;
                rrlineCA.enabled = true;
                rrlineSCA.enabled = kyotuEla.tenmetuOnOff;
                //rrlineSBC.enabled = kyotuEla.tenmetuOnOff;
                //rrlineSAB.enabled = kyotuEla.tenmetuOnOff;

                rrPointA.enabled = true;
                rrPointB.enabled = true;
                rrPointC.enabled = true;
                rrPointD.enabled = true;
                rrPointE.enabled = true;

                rrCylinder1.enabled = true;
                //rrStCylinder1.enabled = kyotuEla.tenmetuOnOff;
                rrCylinder2.enabled = true;
                //rrStCylinder2.enabled = kyotuEla.tenmetuOnOff;
            } else if (count == 36) {
                reset();
                rrTextA.enabled = true;
                rrTextB.enabled = true;
                rrTextC.enabled = true;
                rrTextD.enabled = true;
                rrTextE.enabled = true;

                rrlineAB.enabled = true;
                rrlineBC.enabled = true;
                rrlineCA.enabled = true;
                //rrlineSCA.enabled = kyotuEla.tenmetuOnOff;
                rrlineSBC.enabled = kyotuEla.tenmetuOnOff;
                //rrlineSAB.enabled = kyotuEla.tenmetuOnOff;

                rrPointA.enabled = true;
                rrPointB.enabled = true;
                rrPointC.enabled = true;
                rrPointD.enabled = true;
                rrPointE.enabled = true;

                rrCylinder1.enabled = true;
                //rrStCylinder1.enabled = kyotuEla.tenmetuOnOff;
                rrCylinder2.enabled = true;
                //rrStCylinder2.enabled = kyotuEla.tenmetuOnOff;
            } else if (count == 37) {
                reset();
                rrTextA.enabled = true;
                rrTextB.enabled = true;
                rrTextC.enabled = true;
                rrTextD.enabled = true;
                rrTextE.enabled = true;

                rrlineAB.enabled = true;
                rrlineBC.enabled = true;
                rrlineCA.enabled = true;
                //rrlineSCA.enabled = kyotuEla.tenmetuOnOff;
                //rrlineSBC.enabled = kyotuEla.tenmetuOnOff;
                rrlineSAB.enabled = kyotuEla.tenmetuOnOff;

                rrPointA.enabled = true;
                rrPointB.enabled = true;
                rrPointC.enabled = true;
                rrPointD.enabled = true;
                rrPointE.enabled = true;

                rrCylinder1.enabled = true;
                //rrStCylinder1.enabled = kyotuEla.tenmetuOnOff;
                rrCylinder2.enabled = true;
                //rrStCylinder2.enabled = kyotuEla.tenmetuOnOff;

            } else if (count == 38) {
                reset();
                rrTextA.enabled = true;
                rrTextB.enabled = true;
                rrTextC.enabled = true;
                rrTextD.enabled = true;
                rrTextE.enabled = true;

                rrlineAB.enabled = true;
                rrlineBC.enabled = true;
                rrlineCA.enabled = true;
                //rrlineSCA.enabled = kyotuEla.tenmetuOnOff;
                //rrlineSBC.enabled = kyotuEla.tenmetuOnOff;
                //rrlineSAB.enabled = kyotuEla.tenmetuOnOff;

                rrPointA.enabled = true;
                rrPointB.enabled = true;
                rrPointC.enabled = true;
                rrPointD.enabled = true;
                rrPointE.enabled = true;

                rrCylinder1.enabled = true;
                //rrStCylinder1.enabled = kyotuEla.tenmetuOnOff;
                rrCylinder2.enabled = true;
                //rrStCylinder2.enabled = kyotuEla.tenmetuOnOff;
            } else if (count == 39) {
                reset();
                rrTextA.enabled = true;
                rrTextB.enabled = true;
                rrTextC.enabled = true;
                rrTextD.enabled = true;
                rrTextE.enabled = true;

                rrlineAB.enabled = true;
                rrlineBC.enabled = true;
                rrlineCA.enabled = true;
                //rrlineSCA.enabled = kyotuEla.tenmetuOnOff;
                //rrlineSBC.enabled = kyotuEla.tenmetuOnOff;
                rrlineSAB.enabled = kyotuEla.tenmetuOnOff;

                rrPointA.enabled = true;
                rrPointB.enabled = true;
                rrPointC.enabled = true;
                rrPointD.enabled = true;
                rrPointE.enabled = true;

                rrCylinder1.enabled = true;
                //rrStCylinder1.enabled = kyotuEla.tenmetuOnOff;
                rrCylinder2.enabled = true;
                //rrStCylinder2.enabled = kyotuEla.tenmetuOnOff;
            } else if (count == 40) {
                reset();
                rrTextA.enabled = true;
                rrTextB.enabled = true;
                rrTextC.enabled = true;
                rrTextD.enabled = true;
                rrTextE.enabled = true;

                rrlineAB.enabled = true;
                rrlineBC.enabled = true;
                rrlineCA.enabled = true;
                rrlineSCA.enabled = kyotuEla.tenmetuOnOff;
                rrlineSBC.enabled = kyotuEla.tenmetuOnOff;
                //rrlineSAB.enabled = kyotuEla.tenmetuOnOff;

                rrPointA.enabled = true;
                rrPointB.enabled = true;
                rrPointC.enabled = true;
                rrPointD.enabled = true;
                rrPointE.enabled = true;

                rrCylinder1.enabled = true;
                //rrStCylinder1.enabled = kyotuEla.tenmetuOnOff;
                rrCylinder2.enabled = true;
                //rrStCylinder2.enabled = kyotuEla.tenmetuOnOff;
            } else if (count == 41) {
                reset();
                rrTextA.enabled = true;
                rrTextB.enabled = true;
                rrTextC.enabled = true;
                rrTextD.enabled = true;
                rrTextE.enabled = true;

                rrlineAB.enabled = true;
                rrlineBC.enabled = true;
                rrlineCA.enabled = true;
                rrlineSCA.enabled = kyotuEla.tenmetuOnOff;
                rrlineSBC.enabled = kyotuEla.tenmetuOnOff;
                //rrlineSAB.enabled = kyotuEla.tenmetuOnOff;

                rrPointA.enabled = true;
                rrPointB.enabled = true;
                rrPointC.enabled = true;
                rrPointD.enabled = true;
                rrPointE.enabled = true;

                rrCylinder1.enabled = true;
                //rrStCylinder1.enabled = kyotuEla.tenmetuOnOff;
                rrCylinder2.enabled = true;
                //rrStCylinder2.enabled = kyotuEla.tenmetuOnOff;
            } else if (count == 42) {
                reset();
                rrTextA.enabled = true;
                rrTextB.enabled = true;
                rrTextC.enabled = true;
                rrTextD.enabled = true;
                rrTextE.enabled = true;

                rrlineAB.enabled = true;
                rrlineBC.enabled = true;
                rrlineCA.enabled = true;
                rrlineSCA.enabled = kyotuEla.tenmetuOnOff;
                //rrlineSBC.enabled = kyotuEla.tenmetuOnOff;
                //rrlineSAB.enabled = kyotuEla.tenmetuOnOff;

                rrPointA.enabled = true;
                rrPointB.enabled = true;
                rrPointC.enabled = true;
                rrPointD.enabled = true;
                rrPointE.enabled = true;

                rrCylinder1.enabled = true;
                //rrStCylinder1.enabled = kyotuEla.tenmetuOnOff;
                rrCylinder2.enabled = true;
                //rrStCylinder2.enabled = kyotuEla.tenmetuOnOff;
            } else if (count == 43) {
                reset();
                rrTextA.enabled = true;
                rrTextB.enabled = true;
                rrTextC.enabled = true;
                rrTextD.enabled = true;
                rrTextE.enabled = true;

                rrlineAB.enabled = true;
                rrlineBC.enabled = true;
                rrlineCA.enabled = true;
                //rrlineSCA.enabled = kyotuEla.tenmetuOnOff;
                rrlineSBC.enabled = kyotuEla.tenmetuOnOff;
                //rrlineSAB.enabled = kyotuEla.tenmetuOnOff;

                rrPointA.enabled = true;
                rrPointB.enabled = true;
                rrPointC.enabled = true;
                rrPointD.enabled = true;
                rrPointE.enabled = true;

                rrCylinder1.enabled = true;
                //rrStCylinder1.enabled = kyotuEla.tenmetuOnOff;
                rrCylinder2.enabled = true;
                //rrStCylinder2.enabled = kyotuEla.tenmetuOnOff;
            } else if (count == 44) {
                reset();
                rrTextA.enabled = true;
                rrTextB.enabled = true;
                rrTextC.enabled = true;
                rrTextD.enabled = true;
                rrTextE.enabled = true;

                rrlineAB.enabled = true;
                rrlineBC.enabled = true;
                rrlineCA.enabled = true;
                rrlineSCA.enabled = kyotuEla.tenmetuOnOff;
                //rrlineSBC.enabled = kyotuEla.tenmetuOnOff;
                //rrlineSAB.enabled = kyotuEla.tenmetuOnOff;

                rrPointA.enabled = true;
                rrPointB.enabled = true;
                rrPointC.enabled = true;
                rrPointD.enabled = true;
                rrPointE.enabled = true;

                rrCylinder1.enabled = true;
                //rrStCylinder1.enabled = kyotuEla.tenmetuOnOff;
                rrCylinder2.enabled = true;
                //rrStCylinder2.enabled = kyotuEla.tenmetuOnOff;
            } else if (count == 45) {
                reset();
                rrTextA.enabled = true;
                rrTextB.enabled = true;
                rrTextC.enabled = true;
                rrTextD.enabled = true;
                rrTextE.enabled = true;

                rrlineAB.enabled = true;
                rrlineBC.enabled = true;
                rrlineCA.enabled = true;
                //rrlineSCA.enabled = kyotuEla.tenmetuOnOff;
                //rrlineSBC.enabled = kyotuEla.tenmetuOnOff;
                rrlineSAB.enabled = kyotuEla.tenmetuOnOff;

                rrPointA.enabled = true;
                rrPointB.enabled = true;
                rrPointC.enabled = true;
                rrPointD.enabled = true;
                rrPointE.enabled = true;

                rrCylinder1.enabled = true;
                //rrStCylinder1.enabled = kyotuEla.tenmetuOnOff;
                rrCylinder2.enabled = true;
                //rrStCylinder2.enabled = kyotuEla.tenmetuOnOff;
            } else if (count == 46) {
                reset();
                rrTextA.enabled = true;
                rrTextB.enabled = true;
                rrTextC.enabled = true;
                rrTextD.enabled = true;
                rrTextE.enabled = true;

                rrlineAB.enabled = true;
                rrlineBC.enabled = true;
                rrlineCA.enabled = true;
                //rrlineSCA.enabled = kyotuEla.tenmetuOnOff;
                rrlineSBC.enabled = kyotuEla.tenmetuOnOff;
                //rrlineSAB.enabled = kyotuEla.tenmetuOnOff;

                rrPointA.enabled = true;
                rrPointB.enabled = true;
                rrPointC.enabled = true;
                rrPointD.enabled = true;
                rrPointE.enabled = true;

                rrCylinder1.enabled = true;
                //rrStCylinder1.enabled = kyotuEla.tenmetuOnOff;
                rrCylinder2.enabled = true;
                //rrStCylinder2.enabled = kyotuEla.tenmetuOnOff;
            } else if (count == 47) {
                reset();
                rrTextA.enabled = true;
                rrTextB.enabled = true;
                rrTextC.enabled = true;
                rrTextD.enabled = true;
                rrTextE.enabled = true;

                rrlineAB.enabled = true;
                rrlineBC.enabled = true;
                rrlineCA.enabled = true;
                rrlineSCA.enabled = kyotuEla.tenmetuOnOff;
                rrlineSBC.enabled = kyotuEla.tenmetuOnOff;
                rrlineSAB.enabled = kyotuEla.tenmetuOnOff;

                rrPointA.enabled = true;
                rrPointB.enabled = true;
                rrPointC.enabled = true;
                rrPointD.enabled = true;
                rrPointE.enabled = true;

                rrCylinder1.enabled = true;
                //rrStCylinder1.enabled = kyotuEla.tenmetuOnOff;
                rrCylinder2.enabled = true;
                //rrStCylinder2.enabled = kyotuEla.tenmetuOnOff;
            } else if (count == 48) {
                reset();
                rrTextA.enabled = true;
                rrTextB.enabled = true;
                rrTextC.enabled = true;
                rrTextD.enabled = true;
                rrTextE.enabled = true;

                rrlineAB.enabled = true;
                rrlineBC.enabled = true;
                rrlineCA.enabled = true;
                rrlineSCA.enabled = kyotuEla.tenmetuOnOff;
                rrlineSBC.enabled = kyotuEla.tenmetuOnOff;
                rrlineSAB.enabled = kyotuEla.tenmetuOnOff;

                rrPointA.enabled = true;
                rrPointB.enabled = true;
                rrPointC.enabled = true;
                rrPointD.enabled = true;
                rrPointE.enabled = true;

                rrCylinder1.enabled = true;
                //rrStCylinder1.enabled = kyotuEla.tenmetuOnOff;
                rrCylinder2.enabled = true;
                //rrStCylinder2.enabled = kyotuEla.tenmetuOnOff;
            } else if (count == 49) {
                reset();
                rrTextA.enabled = true;
                rrTextB.enabled = true;
                rrTextC.enabled = true;
                rrTextD.enabled = true;
                rrTextE.enabled = true;

                rrlineAB.enabled = true;
                rrlineBC.enabled = true;
                rrlineCA.enabled = true;
                //rrlineSCA.enabled = kyotuEla.tenmetuOnOff;
                //rrlineSBC.enabled = kyotuEla.tenmetuOnOff;
                rrlineSAB.enabled = kyotuEla.tenmetuOnOff;

                rrPointA.enabled = true;
                rrPointB.enabled = true;
                rrPointC.enabled = true;
                rrPointD.enabled = true;
                rrPointE.enabled = true;

                rrCylinder1.enabled = true;
                //rrStCylinder1.enabled = kyotuEla.tenmetuOnOff;
                rrCylinder2.enabled = true;
                //rrStCylinder2.enabled = kyotuEla.tenmetuOnOff;
            } else if (count == 50) {
                reset();
                rrTextA.enabled = true;
                rrTextB.enabled = true;
                rrTextC.enabled = true;
                rrTextD.enabled = true;
                rrTextE.enabled = true;

                rrlineAB.enabled = true;
                rrlineBC.enabled = true;
                rrlineCA.enabled = true;
                //rrlineSCA.enabled = kyotuEla.tenmetuOnOff;
                //rrlineSBC.enabled = kyotuEla.tenmetuOnOff;
                //rrlineSAB.enabled = kyotuEla.tenmetuOnOff;

                rrPointA.enabled = true;
                rrPointB.enabled = true;
                rrPointC.enabled = true;
                rrPointD.enabled = true;
                rrPointE.enabled = true;

                rrCylinder1.enabled = true;
                //rrStCylinder1.enabled = kyotuEla.tenmetuOnOff;
                rrCylinder2.enabled = true;
                //rrStCylinder2.enabled = kyotuEla.tenmetuOnOff;
            } else if (count == 51) {
                reset();
                rrTextA.enabled = true;
                rrTextB.enabled = true;
                rrTextC.enabled = true;
                rrTextD.enabled = true;
                rrTextE.enabled = true;

                rrlineAB.enabled = true;
                rrlineBC.enabled = true;
                rrlineCA.enabled = true;
                //rrlineSCA.enabled = kyotuEla.tenmetuOnOff;
                //rrlineSBC.enabled = kyotuEla.tenmetuOnOff;
                //rrlineSAB.enabled = kyotuEla.tenmetuOnOff;

                rrPointA.enabled = true;
                rrPointB.enabled = true;
                rrPointC.enabled = true;
                rrPointD.enabled = true;
                rrPointE.enabled = true;

                rrCylinder1.enabled = true;
                //rrStCylinder1.enabled = kyotuEla.tenmetuOnOff;
                rrCylinder2.enabled = true;
                //rrStCylinder2.enabled = kyotuEla.tenmetuOnOff;
            }
        }
        
    }
    //リセット表示を全部消すメソッド　kyotu.rrcount-----------------------------
    private void reset() 
    {
        //k7B_1_1:オブジェを存在するけど見えなくする。
        //this.gameObject.GetComponent<Renderer>().enabled = false; 

        //k7B_1_2:オブジェを見えるようにするよ。
        //this.gameObject.GetComponent<Renderer>().enabled = true;
        rrlineAB.enabled = false;
        rrlineSAB.enabled = false;

        rrlineBC.enabled = false;
        rrlineSBC.enabled = false;

        rrlineCA.enabled = false;
        rrlineSCA.enabled = false;

        rrM1_1StPointA.enabled = false;
        rrPointA.enabled = false;
        rrTextA.enabled = false;
        rrStrongTextCubeA.enabled = false;

        rrM1_1StPointB.enabled = false;
        rrPointB.enabled = false;
        rrTextB.enabled = false;
        rrStrongTextCubeB.enabled = false;

        rrM1_1StPointC.enabled = false;
        rrPointC.enabled = false;
        rrTextC.enabled = false;
        rrStrongTextCubeC.enabled = false;

        rrM1_1StPointD.enabled = false;
        rrPointD.enabled = false;
        rrTextD.enabled = false;
        rrStrongTextCubeD.enabled = false;

        rrM1_1StPointE.enabled = false;
        rrPointE.enabled = false;
        rrTextE.enabled = false;
        rrStrongTextCubeE.enabled = false;

        // 後ろの２つの円のrenderer
        rrCylinder1.enabled = false;
        rrStCylinder1.enabled = false;

        rrCylinder2.enabled = false;
        rrStCylinder2.enabled = false;
    }

}
