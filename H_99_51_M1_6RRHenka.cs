using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class H_99_51_M1_6RRHenka : MonoBehaviour {
    //M1_5RRにアタッチ。オブジェクト全体のいどうをするプログラム
    //いちいちunityで当てはめなきゃ駄目　↓---------------

    //k5_3_1_1:gameobject(メソッド、変数)を使いまわす
    public H_99_01_kyoutuHensu kyotu;

    //強調表現点滅に使う変数を共通変数として使う。
    public H_99_01B_kyotuElapse kyotuEla;

    public GameObject M1_6TextA;
    public GameObject M1_6TextB;
    public GameObject M1_6TextC;
    public GameObject M1_6TextD;

    public GameObject M1_6LineAB;
    public GameObject M1_6LineBC;
    public GameObject M1_6LineAC;
    public GameObject M1_6LineCD;
    public GameObject M1_6LineAD;
    public GameObject M1_6LineBD;

    public GameObject M1_6StLineAB;
    public GameObject M1_6StLineBC;
    public GameObject M1_6StLineAC;
    public GameObject M1_6StLineCD;
    public GameObject M1_6StLineAD;
    public GameObject M1_6StLineBD;

    public GameObject M1_6PointA;
    public GameObject M1_6PointB;
    public GameObject M1_6PointC;
    public GameObject M1_6PointD;

    public GameObject M1_6StPointA;
    public GameObject M1_6StPointB;
    public GameObject M1_6StPointC;
    public GameObject M1_6StPointD;

    public GameObject M1_6kakuABC;
    public GameObject M1_6kakuACB;
    public GameObject M1_6kakuBCD;

    public GameObject M1_6StkakuABC;
    public GameObject M1_6StkakuACB;
    public GameObject M1_6StkakuBCD;

    private Renderer rrM1_6TextA;
    private Renderer rrM1_6TextB;
    private Renderer rrM1_6TextC;
    private Renderer rrM1_6TextD;

    private Renderer rrM1_6LineAB;
    private Renderer rrM1_6LineBC;
    private Renderer rrM1_6LineAC;
    private Renderer rrM1_6LineCD;
    private Renderer rrM1_6LineAD;
    private Renderer rrM1_6LineBD;

    private Renderer rrM1_6StLineAB;
    private Renderer rrM1_6StLineBC;
    private Renderer rrM1_6StLineAC;
    private Renderer rrM1_6StLineCD;
    private Renderer rrM1_6StLineAD;
    private Renderer rrM1_6StLineBD;

    private Renderer rrM1_6PointA;
    private Renderer rrM1_6PointB;
    private Renderer rrM1_6PointC;
    private Renderer rrM1_6PointD;

    private Renderer rrM1_6StPointA;
    private Renderer rrM1_6StPointB;
    private Renderer rrM1_6StPointC;
    private Renderer rrM1_6StPointD;

    private Renderer rrM1_6kakuABC;
    private Renderer rrM1_6kakuACB;
    private Renderer rrM1_6kakuBCD;

    private Renderer rrM1_6StkakuABC;
    private Renderer rrM1_6StkakuACB;
    private Renderer rrM1_6StkakuBCD;

    void Start() {
        rrM1_6TextA = M1_6TextA.GetComponent<Renderer>();
        rrM1_6TextB = M1_6TextB.GetComponent<Renderer>();
        rrM1_6TextC = M1_6TextC.GetComponent<Renderer>();
        rrM1_6TextD = M1_6TextD.GetComponent<Renderer>();

        rrM1_6LineAB = M1_6LineAB.GetComponent<Renderer>();
        rrM1_6LineBC = M1_6LineBC.GetComponent<Renderer>();
        rrM1_6LineAC = M1_6LineAC.GetComponent<Renderer>();
        rrM1_6LineCD = M1_6LineCD.GetComponent<Renderer>();
        rrM1_6LineAD = M1_6LineAD.GetComponent<Renderer>();
        rrM1_6LineBD = M1_6LineBD.GetComponent<Renderer>();

        rrM1_6StLineAB = M1_6StLineAB.GetComponent<Renderer>();
        rrM1_6StLineBC = M1_6StLineBC.GetComponent<Renderer>();
        rrM1_6StLineAC = M1_6StLineAC.GetComponent<Renderer>();
        rrM1_6StLineCD = M1_6StLineCD.GetComponent<Renderer>();
        rrM1_6StLineAD = M1_6StLineAD.GetComponent<Renderer>();
        rrM1_6StLineBD = M1_6StLineBD.GetComponent<Renderer>();

        rrM1_6PointA = M1_6PointA.GetComponent<Renderer>();
        rrM1_6PointB = M1_6PointB.GetComponent<Renderer>();
        rrM1_6PointC = M1_6PointC.GetComponent<Renderer>();
        rrM1_6PointD = M1_6PointD.GetComponent<Renderer>();

        rrM1_6StPointA = M1_6StPointA.GetComponent<Renderer>();
        rrM1_6StPointB = M1_6StPointB.GetComponent<Renderer>();
        rrM1_6StPointC = M1_6StPointC.GetComponent<Renderer>();
        rrM1_6StPointD = M1_6StPointD.GetComponent<Renderer>();

        rrM1_6kakuABC = M1_6kakuABC.GetComponent<Renderer>();
        rrM1_6kakuACB = M1_6kakuACB.GetComponent<Renderer>();
        rrM1_6kakuBCD = M1_6kakuBCD.GetComponent<Renderer>();

        rrM1_6StkakuABC = M1_6StkakuABC.GetComponent<Renderer>();
        rrM1_6StkakuACB = M1_6StkakuACB.GetComponent<Renderer>();
        rrM1_6StkakuBCD = M1_6StkakuBCD.GetComponent<Renderer>();

    }
    //リセット表示を全部消すメソッド　kyotu.rrcount------resetW-----------------------
    private void reset() {
        //k7B_1_1:オブジェを存在するけど見えなくする。
        //this.gameObject.GetComponent<Renderer>().enabled = false; 

        //k7B_1_2:オブジェを見えるようにするよ。
        //this.gameObject.GetComponent<Renderer>().enabled = true;

        //gameobjectを見えなくする
        //＞line：gameobjectを見えなくす

        rrM1_6TextA.enabled = false;
        rrM1_6TextB.enabled = false;
        rrM1_6TextC.enabled = false;
        rrM1_6TextD.enabled = false;

        rrM1_6LineAB.enabled = false;
        rrM1_6LineBC.enabled = false;
        rrM1_6LineAC.enabled = false;
        rrM1_6LineCD.enabled = false;
        rrM1_6LineAD.enabled = false;
        rrM1_6LineBD.enabled = false;

        rrM1_6StLineAB.enabled = false;
        rrM1_6StLineBC.enabled = false;
        rrM1_6StLineAC.enabled = false;
        rrM1_6StLineCD.enabled = false;
        rrM1_6StLineAD.enabled = false;
        rrM1_6StLineBD.enabled = false;

        rrM1_6PointA.enabled = false;
        rrM1_6PointB.enabled = false;
        rrM1_6PointC.enabled = false;
        rrM1_6PointD.enabled = false;

        rrM1_6StPointA.enabled = false;
        rrM1_6StPointB.enabled = false;
        rrM1_6StPointC.enabled = false;
        rrM1_6StPointD.enabled = false;

        rrM1_6kakuABC.enabled = false;
        rrM1_6kakuACB.enabled = false;
        rrM1_6kakuBCD.enabled = false;

        rrM1_6StkakuABC.enabled = false;
        rrM1_6StkakuACB.enabled = false;
        rrM1_6StkakuBCD.enabled = false;
    }
    void Update() {
        henka(kyotu.rrCount);
        Debug.Log("KA_6RRHenka::" + kyotu.mojiSwitch + "::MC::" + kyotu.MCount + "::RRC::" + kyotu.rrCount);

    }
    //rrCountでオブジェの表示、強調を変化させるメソッド---------------------------
    private void henka(int count) {//henkaW
        //m1_3のときのみ実行
        if (kyotu.mojiSwitch == 3 & kyotu.MCount == 5) {
            if (count == 0) {
                reset();
            } else if (count == 1) {//henka1
                reset();
               
            }
        }
    }
}
