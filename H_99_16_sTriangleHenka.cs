﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class H_99_16_sTriangleHenka : MonoBehaviour
{
    //sampletriangeにアタッチ、zukeiの表示変化するプログラム
    //いっぱいインスペで当てはめるオブジェが有る。
    //zukei のポイントを表すApoint、Bpoint、Cpointは
    //アタッチするのはPPRRPointAであることに注意

    //k5_3_1_1:gameobject(メソッド、変数)を使いまわす

    public H_99_01_kyoutuHensu kyotu;

    //強調表現点滅に使う変数を共通変数として使う。
    public H_99_01B_kyotuElapse kyotuEla;


    public GameObject lineAB;
    public GameObject lineSAB;

    public GameObject lineBC;
    public GameObject lineSBC;

    public GameObject lineCA;
    public GameObject lineSCA;

    public GameObject lineAP;
    public GameObject lineSAP;

    //zukei のポイントを表すgameobject
    //アタッチするのはPPRRPointAであることに注意

    public GameObject pointA;
    public GameObject textA;
    public GameObject strongTextCubeA;

    public GameObject pointB;
    public GameObject textB;
    public GameObject strongTextCubeB;

    public GameObject pointC;
    public GameObject textC;
    public GameObject strongTextCubeC;

    //public GameObject pointP;
    //public GameObject textP;
    //public GameObject strongTextCubeP;
    private Renderer rrlineAB;
    private Renderer rrlineSAB;

    private Renderer rrlineBC;
    private Renderer rrlineSBC;

    private Renderer rrlineCA;
    private Renderer rrlineSCA;

    private Renderer rrPointA;
    private Renderer rrTextA;
    private Renderer rrStrongTextCubeA;

    private Renderer rrPointB;
    private Renderer rrTextB;
    private Renderer rrStrongTextCubeB;

    private Renderer rrPointC;
    private Renderer rrTextC;
    private Renderer rrStrongTextCubeC;

    void Start()
    {
        //k6_aa:ストップウォッチスタート
        //stopwatch.Start();

        rrlineAB = lineAB.GetComponent<Renderer>();
        rrlineSAB = lineSAB.GetComponent<Renderer>();

        rrlineBC = lineBC.GetComponent<Renderer>();
        rrlineSBC = lineSBC.GetComponent<Renderer>();

        rrlineCA = lineCA.GetComponent<Renderer>();
        rrlineSCA = lineSCA.GetComponent<Renderer>();

        rrPointA = pointA.GetComponent<Renderer>();
        rrTextA = textA.GetComponent<Renderer>();
        rrStrongTextCubeA = strongTextCubeA.GetComponent<Renderer>();

        rrPointB = pointB.GetComponent<Renderer>();
        rrTextB = textB.GetComponent<Renderer>();
        rrStrongTextCubeB = strongTextCubeB.GetComponent<Renderer>();

        rrPointC = pointC.GetComponent<Renderer>();
        rrTextC = textC.GetComponent<Renderer>();
        rrStrongTextCubeC = strongTextCubeC.GetComponent<Renderer>();
    }

    void Update()
    {
        Debug.Log("woooo"+kyotuEla.tenmetuOnOff);

        //k6_ac:何秒たったかを変数elapseに入れる
        //elapse = (float)stopwatch.Elapsed.TotalSeconds;

        //k5_3_1_1_1:gameobject(メソッド、変数)を使いまわす

        henka(kyotu.rrCount);

        //Debug.Log("wwwwwwwwwwwwwwww" + kyotu.rrCount);
    }
    //rrCountでオブジェの表示、強調を変化させるメソッド---------------------------
    private void henka(int count) 
    {
        if (count == 0) 
        {
            reset();
        } 
        else if (count == 1) 
        {
            reset();
            rrlineBC.enabled = true;
            //共通変数の kyotuEla.tenmetuOnOffで点滅処理
            rrlineSBC.enabled = kyotuEla.tenmetuOnOff;

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
    }
}
