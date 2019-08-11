﻿using System.Collections;
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
    private Renderer rrlineSBD;

    private Renderer rrLineDA;
    private Renderer rrlineSDA;

    private Renderer rrLineAB;
    private Renderer rrlineSAB;

    private Renderer rrLineAL;
    private Renderer rrlineSAL;

    private Renderer rrLineBG;
    private Renderer rrlineSBG;

    private Renderer rrLineAE;
    private Renderer rrlineSAE;

    private Renderer rrLineBF;
    private Renderer rrlineSBF;

    private Renderer rrLineBC;
    private Renderer rrlineSBC;

    private Renderer rrLineDL;
    private Renderer rrlineSDL;

    private Renderer rrLineDG;
    private Renderer rrlineSDG;

    //＞point rederer当てはめ
    private Renderer pointD;
    private Renderer pointA;
    private Renderer pointC;
    private Renderer pointE;
    private Renderer pointF;
    private Renderer pointG;
    private Renderer pointH;
    private Renderer pointK;
    private Renderer pointL;

    //＞circle rederer当てはめ
    private Renderer BigCircle;
    private Renderer SBigCircle;

    private Renderer SmallCircle;
    private Renderer SSmallCircle;

    //＞text rederer当てはめ
    private Renderer TextD;
    private Renderer TextA;
    private Renderer TextB;
    private Renderer TextH;
    private Renderer TextC;
    private Renderer TextG;
    private Renderer TextL;
    private Renderer TextE;
    private Renderer TextF;
    private Renderer TextK;
   
   
   
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log("M1_2henka::" + kyotu.mojiSwitch + "::MC::" + kyotu.MCount + "::RRC::" + kyotu.rrCount); 

    }
}
