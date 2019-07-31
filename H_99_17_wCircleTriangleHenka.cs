﻿using System.Collections;
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

    public GameObject wcPointA;
    public GameObject wcTextA;
    public GameObject wcStrongTextCubeA;

    public GameObject wcPointB;
    public GameObject wcTextB;
    public GameObject wcStrongTextCubeB;

    public GameObject wcPointC;
    public GameObject wcTextC;
    public GameObject wcStrongTextCubeC;

    public GameObject wcPointD;
    public GameObject wcTextD;
    public GameObject wcStrongTextCubeD;

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
    private Renderer rrPointA;
    private Renderer rrTextA;
    private Renderer rrStrongTextCubeA;

    private Renderer rrPointB;
    private Renderer rrTextB;
    private Renderer rrStrongTextCubeB;

    private Renderer rrPointC;
    private Renderer rrTextC;
    private Renderer rrStrongTextCubeC;

    private Renderer rrPointD;
    private Renderer rrTextD;
    private Renderer rrStrongTextCubeD;

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

        rrPointA = wcPointA.GetComponent<Renderer>();
        rrTextA = wcTextA.GetComponent<Renderer>();
        rrStrongTextCubeA = wcStrongTextCubeA.GetComponent<Renderer>();

        rrPointB = wcPointB.GetComponent<Renderer>();
        rrTextB = wcTextB.GetComponent<Renderer>();
        rrStrongTextCubeB = wcStrongTextCubeB.GetComponent<Renderer>();

        rrPointC = wcPointC.GetComponent<Renderer>();
        rrTextC = wcTextC.GetComponent<Renderer>();
        rrStrongTextCubeC = wcStrongTextCubeC.GetComponent<Renderer>();

        rrPointD = wcPointD.GetComponent<Renderer>();
        rrTextD = wcTextD.GetComponent<Renderer>();
        rrStrongTextCubeD = wcStrongTextCubeD.GetComponent<Renderer>();

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
        Debug.Log("MS::" + kyotu.mojiSwitch + "::MC::" + kyotu.MCount + "::RRC::" + kyotu.rrCount);

    }
    //rrCountでオブジェの表示、強調を変化させるメソッド---------------------------
    private void henka(int count) 
    {
        if (count == 5) 
        {
            reset();
            rrTextA.enabled = true;
            rrTextB.enabled = true;
            rrlineAB.enabled = true;
            rrlineSAB.enabled = kyotuEla.tenmetuOnOff;
        }
        else if(count == 6) 
        {
            reset();
            rrTextA.enabled = true;
            rrTextB.enabled = true;
            rrlineAB.enabled = true;
        } 
        else if (count == 7) 
        {
            reset();
            rrTextA.enabled = true;
            rrTextB.enabled = true;
            rrlineAB.enabled = true;
            rrlineSAB.enabled = kyotuEla.tenmetuOnOff;
        } 
        else if (count == 8) {
            reset();
            rrTextA.enabled = true;
            rrTextB.enabled = true;

            rrlineAB.enabled = true;
            rrlineSAB.enabled = kyotuEla.tenmetuOnOff;
            rrlineBC.enabled = true;
            rrlineSBC.enabled = kyotuEla.tenmetuOnOff;
            rrlineCA.enabled = true;
            rrlineSCA.enabled = kyotuEla.tenmetuOnOff;
        } 
        else if (count == 9) 
        {
            reset();
            rrTextA.enabled = true;
            rrTextB.enabled = true;

            rrlineAB.enabled = true;
            rrlineBC.enabled = true;
            rrlineCA.enabled = true;
        } 
        else if (count == 10) 
        {
            reset();

            rrTextA.enabled = true;

            rrTextB.enabled = true;

            rrlineAB.enabled = true;
            

            rrPointA.enabled= kyotuEla.tenmetuOnOff;

        } 
        else if (count == 11) 
        {
            reset();

            rrTextA.enabled = true;

            rrTextB.enabled = true;

            rrlineAB.enabled = true;
            

            rrlineSAB.enabled = kyotuEla.tenmetuOnOff;

            rrPointA.enabled = true;

        } 
        else if (count == 12) 
        {
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

        } else if (count == 13) 
        {
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
        } 
        else if (count == 14) 
        {
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
        } 
        else if (count == 15) 
        {
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
        } else if (count == 16) 
        {
            reset();
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
        } 
        else if (count == 17) 
        {
            reset();
        } 
        else if (count == 18) 
        {
            reset();
        } 
        else if (count == 19) 
        {
            reset();
        } 
        else if (count == 20) 
        {
            reset();
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

        rrPointA.enabled = false;
        rrTextA.enabled = false;
        rrStrongTextCubeA.enabled = false;

        rrPointB.enabled = false;
        rrTextB.enabled = false;
        rrStrongTextCubeB.enabled = false;

        rrPointC.enabled = false;
        rrTextC.enabled = false;
        rrStrongTextCubeC.enabled = false;

        rrPointD.enabled = false;
        rrTextD.enabled = false;
        rrStrongTextCubeD.enabled = false;

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
