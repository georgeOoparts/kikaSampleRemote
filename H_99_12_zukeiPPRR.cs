using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class H_99_12_zukeiPPRR : MonoBehaviour
{
    //空のオブジェPPRRにアタッチして　zukei表示変化、強調変化をコントロールするプルグラム
    //ターンは共通変数のrrCountで進む
    //rrcountはtestPrehubYobi2で進むようにしてある。
    //とりあえずa,b,cなどの文字のばっくを点滅させる。

    //プロトプロト　完成版　
    //注意、testPrehubYobi2のストップウォッチと同期するためelapseを共通変数にしている

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

    //testPrehubYobi2との共通変数
    public testPrehubYobi2 t2;

    void Start()
    {
       

    }

    void Update()
    {
        //強調表現の為のメソッドrrcountで処理
        kyochouPanel(kyotu.rrCount);//////////////65
    }
    //点滅強調に使う。kyochoHantei()メソッド--------------------------------------------------------
    //void kyochouPanel(int count) の中で使う。
    //startメソッドで、stopwatch.Start();
    
    private bool tenmetuOnOff = true;
    public float interval = 0.35f;

    bool kyochoHantei() 
    {
        if (tenmetuOnOff == true) 
        {
            if (t2.elapse >= interval) //testPrehubYobi2との共通変数
            {
                tenmetuOnOff = false;

                
                return (tenmetuOnOff);
            }
            return (true);
        } 
        else if (t2.elapse >= interval) 
        {
            tenmetuOnOff = true;

            
            return (tenmetuOnOff);
        }
        return (false);
    }

    //kyochouPanel(int count) ------------------------------------------------------------------------------
    void kyochouPanel(int count) {
        if (count == 0) {
            //strongtextの点滅強調

            //k7B_1_1:オブジェを存在するけど見えなくする。
            //k7B_1_2:オブジェを見えるようにするよ。

            pointTextStrongA.GetComponent<Renderer>().enabled = kyochoHantei();//////119
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

        } 
        else if (count == 1) 
        {
            //初期リセット
            if(firstResetCount==1)turnReset();

            //強調
            pointTextStrongA.GetComponent<Renderer>().enabled = kyochoHantei();

            pointA.GetComponent<Renderer>().enabled = tenmetuOnOff;

            //Debug.Log("OKKKK:"+count+"::" + elapse);

        } 
        else if (count == 2) 
        {
            //初期リセット
            if (firstResetCount == 2) turnReset();

            //pointTextStrongB.GetComponent<Renderer>().enabled = kyochoHantei();

    

            LineSBC.GetComponent<Renderer>().enabled = kyochoHantei();
        } 
        else if (count == 3) 
        {
            //初期リセット
            if (firstResetCount == 3) turnReset();

            LineSAP.GetComponent<Renderer>().enabled = kyochoHantei();

        } 
        else if (count == 4) 
        {
            //初期リセット
            if (firstResetCount == 4) turnReset();

            LineSAP.GetComponent<Renderer>().enabled = kyochoHantei();
        } 
        else if (count == 5) 
        {
            //初期リセット
            if (firstResetCount == 5) turnReset();

            LineSBC.GetComponent<Renderer>().enabled = kyochoHantei();
        } 
        else if (count == 6) 
        {
            //初期リセット
            if (firstResetCount == 6) turnReset();

            pointTextStrongP.GetComponent<Renderer>().enabled = kyochoHantei();

            pointP.GetComponent<Renderer>().enabled = tenmetuOnOff;

            pointTextP.GetComponent<Renderer>().enabled = true;

        } 
        else if (count == 7) 
        {
            //初期リセット
            if (firstResetCount == 7) turnReset();
        }
    }
    //ターンの最初にオブジェを初期化するメソッド--------------
    //最初の1回だけリセットしたい。そのための変数
    private int firstResetCount = 1;
    void turnReset() 
    {
        //初期リセット

        if (firstResetCount>=7) 
        {
            pointTextP.GetComponent<Renderer>().enabled = true;
        }

        //>線の初期リセット
        LineAB.GetComponent<Renderer>().enabled = true;
        LineBC.GetComponent<Renderer>().enabled = true;
        LineCA.GetComponent<Renderer>().enabled = true;
        if (firstResetCount >= 3) 
        {
            LineAP.GetComponent<Renderer>().enabled = true;
        } 
        else 
        {
            LineAP.GetComponent<Renderer>().enabled = false;
        }

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

        firstResetCount++;
    }
}
