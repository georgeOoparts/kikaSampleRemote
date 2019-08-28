using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class H_99_29_M1_3RRHenka : MonoBehaviour
{
    //M1_3preにアタッチ。オブジェクト全体のいどうをするプログラム
    //いちいちunityで当てはめなきゃ駄目　↓---------------

    //k5_3_1_1:gameobject(メソッド、変数)を使いまわす
    public H_99_01_kyoutuHensu kyotu;

    //lineを当てはめる
    public GameObject M1_3LineAE;
    public GameObject M1_3LineSAE;

    public GameObject M1_3LineAB;
    public GameObject M1_3LineSAB;

    public GameObject M1_3LineAD;
    public GameObject M1_3LineSAD;

    public GameObject M1_3LineEB;
    public GameObject M1_3LineSEB;

    public GameObject M1_3LineC;
    public GameObject M1_3LineSC;

    //pointを当てはめる
    public GameObject M1_3PointA;
    public GameObject M1_3PointB;
    public GameObject M1_3PointD;
    public GameObject M1_3PointE;
    public GameObject M1_3PointF;

    //>強調pointを当てはめる
    public GameObject M1_3StPointA;
    public GameObject M1_3StPointB;
    public GameObject M1_3StPointD;
    public GameObject M1_3StPointE;
    public GameObject M1_3StPointF;

    //circleを当てはめる
    public GameObject M1_3Circle;
    public GameObject M1_2StCircle;

    //TEXTを当てはめる
    public GameObject M1_3TextA;
    public GameObject M1_3TextB;
    public GameObject M1_3TextC;
    public GameObject M1_3TextD;
    public GameObject M1_3TextE;
    public GameObject M1_3TextF;

    //renderer当てはめ
    //＞linerederer当てはめ
    private Renderer rrM1_3LineAE;
    private Renderer rrM1_3LineSAE;

    private Renderer rrM1_3LineAB;
    private Renderer rrM1_3LineSAB;

    private Renderer rrM1_3LineAD;
    private Renderer rrM1_3LineSAD;

    private Renderer rrM1_3LineEB;
    private Renderer rrM1_3LineSEB;

    private Renderer rrM1_3LineC;
    private Renderer rrM1_3LineSC;
 
    //＞＞point rederer当てはめ
    private Renderer rrM1_3PointA;
    private Renderer rrM1_3PointB;
    private Renderer rrM1_3PointD;
    private Renderer rrM1_3PointE;
    private Renderer rrM1_3PointF;
    //＞＞強調point rederer当てはめ
    private Renderer rrM1_3StPointA;
    private Renderer rrM1_3StPointB;
    private Renderer rrM1_3StPointD;
    private Renderer rrM1_3StPointE;
    private Renderer rrM1_3StPointF;

    //＞circle rederer当てはめ
    private Renderer rrM1_3Circle;
    private Renderer rrM1_2StCircle;

    //＞text rederer当てはめ
    private Renderer rrM1_3TextA;
    private Renderer rrM1_3TextB;
    private Renderer rrM1_3TextC;
    private Renderer rrM1_3TextD;
    private Renderer rrM1_3TextE;
    private Renderer rrM1_3TextF;
   
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log("M1_3RRHenka::" + kyotu.mojiSwitch + "::MC::" + kyotu.MCount + "::RRC::" + kyotu.rrCount);

    }
}
