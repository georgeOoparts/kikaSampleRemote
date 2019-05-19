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
    //>まずは文字から
    public GameObject pprrTextA;
    public GameObject pprrTextB;
    public GameObject pprrTextC;
    public GameObject pprrTextP;

    //>線を当てはめる
    public GameObject pprrLineAB;
    public GameObject pprrLineBC;
    public GameObject pprrLineCA;
    public GameObject pprrLineAP;

    //>強調線を当てはめる
    public GameObject pprrLineSAB;
    public GameObject pprrLineSBC;
    public GameObject pprrLineSCA;
    public GameObject pprrLineSAP;

    void Start()
    {
        //pprrTextA.GetComponent<Renderer>().enabled = false; 
            //renderer.enabled = false;
        //Debug.Log(pprrTextA.name);

    }

    void Update()
    {
        //k6_ac:何秒たったかを変数elapseに入れる
        elapse = (float)stopwatch.Elapsed.TotalSeconds;
        
        //k5_3_1_1_1:gameobject(メソッド、変数)を使いまわす
        //yosu.cube1で普通に使える
        //Debug.Log("zykei" + kyotu.rrCount);
        //Debug.Log(pprrTextA.name);
        //kyochouPanel(kyotu.rrCount);//

    }
    //点滅強調に使う。kyochoHantei()メソッド--------------------------------------------------------
    //void kyochouPanel(int count) の中で使う。
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
        if (count == 0) {
            //mojiPanel[1]の点滅強調
            //k7_1_2:オブジェを見えるようにするよ。
            //k7_a:オブジェを存在するけど見えなくする。
            //mojiPanel[1].GetComponent<Image>().enabled = kyochoHantei();
            //pprrTextA.GetComponent<Image>().enabled = kyochoHantei();//////
            //pprrTextA.GetComponent<Image>().enabled = false;
            //} else if (count == 1) {
            //    for (int i = 0; i < kodomoTextText.Count; i++) {
            //        mojiPanel[i].GetComponent<Image>().enabled = false;
            //    }

            //    //k7_1_2:オブジェを見えるようにするよ。
            //    mojiPanel[1].GetComponent<Image>().enabled = kyochoHantei();


            //} else if (count == 2) {
            //    for (int i = 0; i < kodomoTextText.Count; i++) {
            //        mojiPanel[i].GetComponent<Image>().enabled = false;
            //    }
            //    //k7_1_2:オブジェを見えるようにするよ。
            //    mojiPanel[3].GetComponent<Image>().enabled = kyochoHantei();
            //} else if (count == 3) {
            //    for (int i = 0; i < kodomoTextText.Count; i++) {
            //        mojiPanel[i].GetComponent<Image>().enabled = false;
            //    }
            //    //k7_1_2:オブジェを見えるようにするよ。
            //    mojiPanel[5].GetComponent<Image>().enabled = kyochoHantei();
            //} else if (count == 4) {
            //    for (int i = 0; i < kodomoTextText.Count; i++) {
            //        mojiPanel[i].GetComponent<Image>().enabled = false;
            //    }
            //    //k7_1_2:オブジェを見えるようにするよ。
            //    mojiPanel[1].GetComponent<Image>().enabled = kyochoHantei();
            //} else if (count == 5) {
            //    for (int i = 0; i < kodomoTextText.Count; i++) {
            //        mojiPanel[i].GetComponent<Image>().enabled = false;
            //    }
            //    //k7_1_2:オブジェを見えるようにするよ。
            //    mojiPanel[3].GetComponent<Image>().enabled = kyochoHantei();
            //} else if (count == 6) {
            //    for (int i = 0; i < kodomoTextText.Count; i++) {
            //        mojiPanel[i].GetComponent<Image>().enabled = false;
            //    }
            //    //k7_1_2:オブジェを見えるようにするよ。
            //    mojiPanel[5].GetComponent<Image>().enabled = kyochoHantei();
            //}
        }
    }
}
