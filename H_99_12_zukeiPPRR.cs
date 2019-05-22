using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class H_99_12_zukeiPPRR : MonoBehaviour
{
    //空のオブジェPPRRにアタッチして　zukei変化をコントロールするプルグラム
    //ターンは共通変数のrrCountで進む
    //rrcountはtestPrehubYobi2で進むようにしてある。
    //とりあえずa,b,cなどの文字のばっくを点滅させる。

    //k5_3_1_1:gameobject(メソッド、変数)を使いまわす
    public H_99_01_kyoutuHensu kyotu;


    //pprrのオブジェを当てはめる

    //>点（シリンダーオブジェの角度変えた物）    
    public GameObject pointA;
    public GameObject pointB;
    public GameObject pointC;
    public GameObject pointP;

    //>それぞれの点の名前をあらわす文字
    public GameObject pointTextA;
    public GameObject pointTextB;
    public GameObject pointTextC;
    public GameObject pointTextP;

    //>それぞれの点の名前をあらわす文字を強調するためのCUBEオブジェ
    public GameObject pointTextStrongA;
    public GameObject pointTextStrongB;
    public GameObject pointTextStrongC;
    public GameObject pointTextStrongP;

    //>線を当てはめる
    public GameObject LineAB;
    public GameObject LineBC;
    public GameObject LineCA;
    public GameObject LineAP;

    //>強調線を当てはめる
    public GameObject LineSAB;
    public GameObject LineSBC;
    public GameObject LineSCA;
    public GameObject LineSAP;

    void Start()
    {
        //Debug.Log(pprrTextA.name);
        
        //kyouchoupanelの点滅の時間処理のために使う。ストップウォッチ
        //k6_aa:ストップウォッチスタート
        stopwatch.Start();

    }

    void Update()
    {
        //k6_ac:何秒たったかを変数elapseに入れる
        elapse = (float)stopwatch.Elapsed.TotalSeconds;

        //強調表現の為のメソッドrrcountで処理
        kyochouPanel(kyotu.rrCount);//

    }
    //点滅強調に使う。kyochoHantei()メソッド--------------------------------------------------------
    //void kyochouPanel(int count) の中で使う。
    //startメソッドで、stopwatch.Start();
    //updateメソッドで、 elapse = (float)stopwatch.Elapsed.TotalSeconds;
    //をわすれずに
    //k6_a:ストップウォッチ関数を使う時のおまじない。
    private System.Diagnostics.Stopwatch stopwatch
        = new System.Diagnostics.Stopwatch();
    private float elapse;
    private bool tenmetuOnOff = true;
    public float interval = 0.35f;

    bool kyochoHantei() 
    {
        if (tenmetuOnOff == true) 
        {
            if (elapse >= interval) 
            {
                tenmetuOnOff = false;

                //k6_ab:ストップウォッチの時間をリセット
                stopwatch.Reset();
                //k6_aa:ストップウォッチスタート
                stopwatch.Start();
                return (tenmetuOnOff);
            }
            return (true);
        } 
        else if (elapse >= interval) 
        {
            tenmetuOnOff = true;

            //k6_ab:ストップウォッチの時間をリセット
            stopwatch.Reset();
            //k6_aa:ストップウォッチスタート
            stopwatch.Start();
            return (tenmetuOnOff);
        }
        return (false);
    }

    //kyochouPanel(int count) ------------------------------------------------------------------------------
    void kyochouPanel(int count) {
        if (count == 0) 
        {
            //strongtextの点滅強調

            //k7B_1_1:オブジェを存在するけど見えなくする。
            //k7B_1_2:オブジェを見えるようにするよ。

            pointTextStrongA.GetComponent<Renderer>().enabled = kyochoHantei();
            pointTextStrongB.GetComponent<Renderer>().enabled = tenmetuOnOff;
            pointTextStrongC.GetComponent<Renderer>().enabled = tenmetuOnOff;

            //lineA,B,Cの点滅強調

            //k7B_1_1:オブジェを存在するけど見えなくする。
            //k7B_1_2:オブジェを見えるようにするよ。

            LineSAB.GetComponent<Renderer>().enabled = tenmetuOnOff;
            LineSBC.GetComponent<Renderer>().enabled = tenmetuOnOff;
            LineSCA.GetComponent<Renderer>().enabled = tenmetuOnOff;

            //lineA,B,Cの点滅強調

            //k7B_1_1:オブジェを存在するけど見えなくする。
            //k7B_1_2:オブジェを見えるようにするよ。

            pointA.GetComponent<Renderer>().enabled = tenmetuOnOff;
            pointB.GetComponent<Renderer>().enabled = tenmetuOnOff;
            pointC.GetComponent<Renderer>().enabled = tenmetuOnOff;

            Debug.Log("OKKKK:::"+ elapse);
        }
        else if (count == 1) 
        {
            //初期リセット
            //>線の初期リセット
            LineAB.GetComponent<Renderer>().enabled = true;
            LineBC.GetComponent<Renderer>().enabled = true;
            LineCA.GetComponent<Renderer>().enabled = true;
            LineAP.GetComponent<Renderer>().enabled = false;

            //>強調線の初期リセット
            LineSAB.GetComponent<Renderer>().enabled = false;
            LineSBC.GetComponent<Renderer>().enabled = false;
            LineSCA.GetComponent<Renderer>().enabled = false;
            LineSAP.GetComponent<Renderer>().enabled = false;

            //>点の初期リセット
            pointA.GetComponent<Renderer>().enabled = false;
            pointB.GetComponent<Renderer>().enabled = false;
            pointC.GetComponent<Renderer>().enabled = false;
            pointP.GetComponent<Renderer>().enabled = false;

            //>強調文字キューブの初期リセット
            pointTextStrongA.GetComponent<Renderer>().enabled = false;
            pointTextStrongB.GetComponent<Renderer>().enabled = false;
            pointTextStrongC.GetComponent<Renderer>().enabled = false;
            pointTextStrongP.GetComponent<Renderer>().enabled = false;
        }
    }
}
