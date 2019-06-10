﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class H_99_13_mojiHonban : MonoBehaviour
{
    //UIオブジェcanvasworld＞UIオブジェtextpanelの中に
    //UIプレハブpremoji（UIpanel＞UITEXT）を呼び出す
    //UIプレハブの文章の内容を決定する。
    //アタッチ＞UIオブジェcanvasworld＞UIオブジェtextpanel
    //セット＞kyotuhensu、kyotuhensuelapse(maincameraをセット)、UIオブジェプレハブpremoji

    //uitext のプレハブ //canvasはプレハブ化せずにおく、publicにはしておく

    //k5_3_1_1:gameobject(メソッド、変数)を使いまわす
    //このスクリプトをアタッチしたオブジェクトにいちいちこのオブジェクトをアタッチ
    public H_99_01_kyoutuHensu kyotu;
    
    //強調表現点滅に使う変数を共通変数として使う。
    public H_99_01B_kyotuElapse kyotuEla;

    //k0014_2 :プレハブ（画面のobjでもOK）を使う objにはりつけ
    public GameObject premoji;

    //k0016_99_1_1：listの宣言
    //prehubとして呼び出したmojipanelに当てはめるオブジェ
    List<GameObject> mojiPanel = new List<GameObject>();

    //mojipanelの子オブジェtextに当てはめるオブジェ
    List<GameObject> kodomoTextObj = new List<GameObject>();

    //textオブジェのコンポTEXTに当てはめるText変数
    List<Text> kodomoTextText = new List<Text>();

    void Start() 
    {
        //配列に解説文を割り当てる。
        setWord();
        for (int i = 0; i < 11; i++) 
        {
            //プレハブを使う
            //k0016_99_1_1_1：list新しい値を入れる
            mojiPanel.Add(Instantiate(premoji) as GameObject);
            //premojiの子供オブジェであるtextをlistにする。
            kodomoTextObj.Add(mojiPanel[i].transform.GetChild(0).gameObject);
            ////premojiの子供オブジェであるtextのコンポートメントであるTextをlistにする。
            kodomoTextText.Add(kodomoTextObj[i].GetComponent<Text>());

            //k0014_2_1_1 :プレハブをtextPanelの子供にする()
            mojiPanel[i].transform.SetParent(this.gameObject.transform, false);

            //k0014_2_1_1: オブジェの名前を変化させる
            mojiPanel[i].name = "mojiPanel" + i;
            kodomoTextObj[i].name = "text" + i;
        }
        //k6_aa:ストップウォッチスタート
        stopwatch.Start();
    }


    private int kyouchouHenkanInt;
    void Update() 
    {
        //k6_ac:何秒たったかを変数elapseに入れる
        elapse = (float)stopwatch.Elapsed.TotalSeconds;

        //kyotu.rrCountの数を増やす
        if (Input.GetMouseButtonDown(0))
            kyotu.rrCount++;
        //Debug.Log("rrCount" + kyotu.rrCount);
        else if (Input.GetMouseButtonDown(1)) 
        {
            kyotu.MCount++;
            kyotu.rrCount = 0;
        }

        //Debug.Log("MCount" + kyotu.MCount);


        //UItextに2次元配列の値を入れていく
        for (int i = 0; i < kodomoTextText.Count; i++) 
        {
            //k0017_99_2_1:2次元配列　最初の要素の個数を得る
            if (kyotu.rrCount < intValues.GetLength(1) && kyotu.MCount < intValues.GetLength(0)) 
            {
                kodomoTextText[i].text = intValues[kyotu.MCount, kyotu.rrCount, i];
            } 
            else
                kodomoTextText[i].text = "";


        }
        //k10_2:strin>int変換
        if (kyotu.rrCount < intValues.GetLength(1) && kyotu.MCount < intValues.GetLength(0)) 
        {
            kyouchouHenkanInt = int.Parse(intValues[kyotu.MCount, kyotu.rrCount, intValues.GetLength(2) - 1]);
        } 
        else 
        {
            //てきすとの強調kyochouPanel(kyouchouHenkanInt);でどこも強調しない数値99
            kyouchouHenkanInt = 99;
        }


        //強調すべきパネルを強調するメソッド
        kyochouPanel(kyouchouHenkanInt);///
        //Debug.Log("OKKKKKK");
        

    }
    //点滅強調に使う。kyochoHantei()メソッド--------------------------------------------------------
    //void kyochouPanel(int count) の中で使う。
    //k6_a:ストップウォッチ関数を使う時のおまじない。
    //updateでelapse = (float)stopwatch.Elapsed.TotalSeconds;忘れずに 
    private System.Diagnostics.Stopwatch stopwatch
        = new System.Diagnostics.Stopwatch();
    //このelapseはH_99_12_zukeiPPRRのほうで共通変数として利用される
    //それによって、点滅のタイミングを完全に合わせる
    public float elapse = 0;
    private bool tenmetuOnOff = true;
    public float interval = 0.35f;

    bool kyochoHantei() {
        if (tenmetuOnOff == true) {
            if (elapse >= interval) {
                tenmetuOnOff = false;

                //k6_ab:ストップウォッチの時間をリセット
                stopwatch.Reset();
                //k6_aa:ストップウォッチスタート
                stopwatch.Start();
                return (tenmetuOnOff);
            }
            return (true);
        } else if (elapse >= interval) {
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
    void kyochouPanel(int count) 
    {
       
        for (int i = 0; i < kodomoTextText.Count; i++) 
        {
            mojiPanel[i].GetComponent<Image>().enabled = false;
        }
        
        if (count!=99) 
        {
            //k7_1_2:オブジェを見えるようにするよ。
            mojiPanel[count].GetComponent<Image>().enabled = kyochoHantei();///
        }
            
    }
    //Uitextの中身----------------------------------------------------------------------------------------------------
    private string[,,] intValues;
    void setWord() 
    {
        //　配列の要素数の確保
        intValues = new string[,,]
        {
            {
                {"命題I-1","","","","","","","","","","","99"},
                {"与えられた直線", "を","一辺","とする","正三角形","を作図する事。","","","","","","0"},
                {"与えられた直線", "を","一辺","とする","正三角形","を作図する事。","","","","","","2"},
                {"与えられた直線", "を","一辺","とする","正三角形","を作図する事。","","","","","","4"},
                {"与えられた直線", "を","一辺","とする","正三角形","を作図する事。","","","","","","99"},
                {"", "","","","","","","","","","","99"},
                {"", "","","","","","","","","","","99"},
                {"", "","","","","","","","","","","99"},
                {"", "","","","","","","","","","","99"},
                {"", "","","","","","","","","","","99"},
                {"", "","","","","","","","","","","99"},
                {"", "","","","","","","","","","","99"},
                {"", "","","","","","","","","","","99"},
                {"", "","","","","","","","","","","99"},
                {"", "","","","","","","","","","","99"},
                {"", "","","","","","","","","","","99"},
                {"", "","","","","","","","","","","99"},
                {"", "","","","","","","","","","","99"},
                {"", "","","","","","","","","","","99"},
                {"", "","","","","","","","","","","99"},
                {"", "","","","","","","","","","","99"},
                {"", "","","","","","","","","","","99"},
                {"", "","","","","","","","","","","99"},
                {"", "","","","","","","","","","","99"},
                {"", "","","","","","","","","","","99"},
                {"", "","","","","","","","","","","99"},
                {"", "","","","","","","","","","","99"},
                {"", "","","","","","","","","","","99"},
                {"", "","","","","","","","","","","99"},
                {"", "","","","","","","","","","","99"},
                {"", "","","","","","","","","","","99"},
                {"", "","","","","","","","","","","99"},
                {"", "","","","","","","","","","","99"},
                {"", "","","","","","","","","","","99"},
                {"", "","","","","","","","","","","99"},
                {"", "","","","","","","","","","","99"},
                {"", "","","","","","","","","","","99"},
                {"", "","","","","","","","","","","99"},
                {"", "","","","","","","","","","","99"},
                {"", "","","","","","","","","","","99"},
                {"", "","","","","","","","","","","99"},
                {"", "","","","","","","","","","","99"},
                {"", "","","","","","","","","","","99"},
                {"", "","","","","","","","","","","99"},
                {"", "","","","","","","","","","","99"},
                {"", "","","","","","","","","","","99"},
                {"", "","","","","","","","","","","99"},
                {"", "","","","","","","","","","","99"},
                {"", "","","","","","","","","","","99"},
                {"", "","","","","","","","","","","99"},
                {"", "","","","","","","","","","","99"},
                {"", "","","","","","","","","","","99"},
                {"", "","","","","","","","","","","99"},
                {"", "","","","","","","","","","","99"},
                {"", "","","","","","","","","","","99"},
                {"", "","","","","","","","","","","99"},
                {"", "","","","","","","","","","","99"},
                {"", "","","","","","","","","","","99"},
                {"", "","","","","","","","","","","99"},
                {"", "","","","","","","","","","","99"},
                {"", "","","","","","","","","","","99"},
                {"", "","","","","","","","","","","99"},
                {"", "","","","","","","","","","","99"},
                {"", "","","","","","","","","","","99"},
                {"", "","","","","","","","","","","99"},
                {"", "","","","","","","","","","","99"},
                {"", "","","","","","","","","","","99"},
                {"", "","","","","","","","","","","99"},
                {"", "","","","","","","","","","","99"},
                {"", "","","","","","","","","","","99"},
                {"", "","","","","","","","","","","99"},
                {"", "","","","","","","","","","","99"},
                {"", "","","","","","","","","","","99"},
                {"", "","","","","","","","","","","99"},
                {"", "","","","","","","","","","","99"},
                {"", "","","","","","","","","","","99"},
                {"", "","","","","","","","","","","99"}
            },
            {
                {"AB","を与えられた","直線","とする。","","","","","","","","0"},
                {"AB","を与えられた","直線","とする。","","","","","","","","99"},
                {"このとき、", "AB","を一辺とする","正三角形","を作図することが","求められている。","","","","","","1"},
                {"このとき、", "AB","を一辺とする","正三角形","を作図することが","求められている。","","","","","","3"},
                {"このとき、", "AB","を一辺とする","正三角形","を作図することが","求められている。","","","","","","99"},
                {"A", "を中心とし、","AB","を半径とする円","BCD","を描く[公準P-3]","","","","","","0"},
                {"A", "を中心とし、","AB","を半径とする円","BCD","を描く[公準P-3]","","","","","","2"},
                {"A", "を中心とし、","AB","を半径とする円","BCD","を描く[公準P-3]","","","","","","4"},
                {"A", "を中心とし、","AB","を半径とする円","BCD","を描く[公準P-3]","","","","","","99"},
                {"BA", "を半径とする円","ACE","を描く[公準P-3]。","","","","","","","","0"},
                {"BA", "を半径とする円","ACE","を描く[公準P-3]。","","","","","","","","2"},
                {"BA", "を半径とする円","ACE","を描く[公準P-3]。","","","","","","","","99"},
                {"そして二つの円の交点", "C","と","A","と","B","を結ぶ直線","CA","と","CB","を描く[公準P-1]。","1"},
                {"そして二つの円の交点", "C","と","A","と","B","を結ぶ直線","CA","と","CB","を描く[公準P-1]。","3"},
                {"そして二つの円の交点", "C","と","A","と","B","を結ぶ直線","CA","と","CB","を描く[公準P-1]。","5"},
                {"そして二つの円の交点", "C","と","A","と","B","を結ぶ直線","CA","と","CB","を描く[公準P-1]。","7"},
                {"そして二つの円の交点", "C","と","A","と","B","を結ぶ直線","CA","と","CB","を描く[公準P-1]。","9"},
                {"そして二つの円の交点", "C","と","A","と","B","を結ぶ直線","CA","と","CB","を描く[公準P-1]。","99"},
                {"点", "A","は円","CDB","の中心であるから、","AC","は","AB","と等しい","[定義DI-15]。","","1"},
                {"点", "A","は円","CDB","の中心であるから、","AC","は","AB","と等しい","[定義DI-15]。","","3"},
                {"点", "A","は円","CDB","の中心であるから、","AC","は","AB","と等しい","[定義DI-15]。","","5"},
                {"点", "A","は円","CDB","の中心であるから、","AC","は","AB","と等しい","[定義DI-15]。","","7"},
                {"点", "A","は円","CDB","の中心であるから、","AC","は","AB","と等しい","[定義DI-15]。","","99"},
                {"また点", "B","は円","CAE","の中心であるから、","BC","と","BA","は等しい","[定義DI-15]。","","1"},
                {"また点", "B","は円","CAE","の中心であるから、","BC","と","BA","は等しい","[定義DI-15]。","","3"},
                {"また点", "B","は円","CAE","の中心であるから、","BC","と","BA","は等しい","[定義DI-15]。","","5"},
                {"また点", "B","は円","CAE","の中心であるから、","BC","と","BA","は等しい","[定義DI-15]。","","7"},
                {"また点", "B","は円","CAE","の中心であるから、","BC","と","BA","は等しい","[定義DI-15]。","","99"},
                {"CA", "は","AB","と等しかったから、","CA","と","CB","は共に","AB","と等しい。","","0"},
                {"CA", "は","AB","と等しかったから、","CA","と","CB","は共に","AB","と等しい。","","2"},
                {"CA", "は","AB","と等しかったから、","CA","と","CB","は共に","AB","と等しい。","","4"},
                {"CA", "は","AB","と等しかったから、","CA","と","CB","は共に","AB","と等しい。","","6"},
                {"CA", "は","AB","と等しかったから、","CA","と","CB","は共に","AB","と等しい。","","8"},
                {"CA", "は","AB","と等しかったから、","CA","と","CB","は共に","AB","と等しい。","","99"},
                {"同じもの", "に","等しいもの","は互いに等しかったから","[公理A-1]","","","","","","","0"},
                {"同じもの", "に","等しいもの","は互いに等しかったから","[公理A-1]","","","","","","","2"},
                {"同じもの", "に","等しいもの","は互いに等しかったから","[公理A-1]","","","","","","","99"},
                {"CA", "は","CB","に等しく、","CA","、","AB","、","BC","の三辺はすべて","互いに等しい。","0"},
                {"CA", "は","CB","に等しく、","CA","、","AB","、","BC","の三辺はすべて","互いに等しい。","2"},
                {"CA", "は","CB","に等しく、","CA","、","AB","、","BC","の三辺はすべて","互いに等しい。","4"},
                {"CA", "は","CB","に等しく、","CA","、","AB","、","BC","の三辺はすべて","互いに等しい。","6"},
                {"CA", "は","CB","に等しく、","CA","、","AB","、","BC","の三辺はすべて","互いに等しい。","8"},
                {"CA", "は","CB","に等しく、","CA","、","AB","、","BC","の三辺はすべて","互いに等しい。","99"},
                {"ゆえに、三角形", "ABC","は正三角形であり、","与えられた直線","AB","から作図","されたものである。","","","","","1"},
                {"ゆえに、三角形", "ABC","は正三角形であり、","与えられた直線","AB","から作図","されたものである。","","","","","4"},
                {"ゆえに、三角形", "ABC","は正三角形であり、","与えられた直線","AB","から作図","されたものである。","","","","","99"},
                {"これが求められていた", "ことであった。","","","","","","","","","","99"},
                {"", "","","","","","","","","","","99"},
                {"", "","","","","","","","","","","99"},
                {"", "","","","","","","","","","","99"},
                {"", "","","","","","","","","","","99"},
                {"", "","","","","","","","","","","99"},
                {"", "","","","","","","","","","","99"},
                {"", "","","","","","","","","","","99"},
                {"", "","","","","","","","","","","99"},
                {"", "","","","","","","","","","","99"},
                {"", "","","","","","","","","","","99"},
                {"", "","","","","","","","","","","99"},
                {"", "","","","","","","","","","","99"},
                {"", "","","","","","","","","","","99"},
                {"", "","","","","","","","","","","99"},
                {"", "","","","","","","","","","","99"},
                {"", "","","","","","","","","","","99"},
                {"", "","","","","","","","","","","99"},
                {"", "","","","","","","","","","","99"},
                {"", "","","","","","","","","","","99"},
                {"", "","","","","","","","","","","99"},
                {"", "","","","","","","","","","","99"},
                {"", "","","","","","","","","","","99"},
                {"", "","","","","","","","","","","99"},
                {"", "","","","","","","","","","","99"},
                {"", "","","","","","","","","","","99"},
                {"", "","","","","","","","","","","99"},
                {"", "","","","","","","","","","","99"},
                {"", "","","","","","","","","","","99"},
                {"", "","","","","","","","","","","99"},
                {"", "","","","","","","","","","","99"}
            },
            {
                {"命題I-1","","","","","","","","","","99","99"},
                {"与えられた直線", "を","一辺","とする","正三角形","を作図する事。","","","","","","0"},
                {"与えられた直線", "を","一辺","とする","正三角形","を作図する事。","","","","","","2"},
                {"与えられた直線", "を","一辺","とする","正三角形","を作図する事。","","","","","","4"},
                {"与えられた直線", "を","一辺","とする","正三角形","を作図する事。","","","","","","99"},
                {"", "","","","","","","","","","","99"},
                {"", "","","","","","","","","","","99"},
                {"", "","","","","","","","","","","99"},
                {"", "","","","","","","","","","","99"},
                {"", "","","","","","","","","","","99"},
                {"", "","","","","","","","","","","99"},
                {"", "","","","","","","","","","","99"},
                {"", "","","","","","","","","","","99"},
                {"", "","","","","","","","","","","99"},
                {"", "","","","","","","","","","","99"},
                {"", "","","","","","","","","","","99"},
                {"", "","","","","","","","","","","99"},
                {"", "","","","","","","","","","","99"},
                {"", "","","","","","","","","","","99"},
                {"", "","","","","","","","","","","99"},
                {"", "","","","","","","","","","","99"},
                {"", "","","","","","","","","","","99"},
                {"", "","","","","","","","","","","99"},
                {"", "","","","","","","","","","","99"},
                {"", "","","","","","","","","","","99"},
                {"", "","","","","","","","","","","99"},
                {"", "","","","","","","","","","","99"},
                {"", "","","","","","","","","","","99"},
                {"", "","","","","","","","","","","99"},
                {"", "","","","","","","","","","","99"},
                {"", "","","","","","","","","","","99"},
                {"", "","","","","","","","","","","99"},
                {"", "","","","","","","","","","","99"},
                {"", "","","","","","","","","","","99"},
                {"", "","","","","","","","","","","99"},
                {"", "","","","","","","","","","","99"},
                {"", "","","","","","","","","","","99"},
                {"", "","","","","","","","","","","99"},
                {"", "","","","","","","","","","","99"},
                {"", "","","","","","","","","","","99"},
                {"", "","","","","","","","","","","99"},
                {"", "","","","","","","","","","","99"},
                {"", "","","","","","","","","","","99"},
                {"", "","","","","","","","","","","99"},
                {"", "","","","","","","","","","","99"},
                {"", "","","","","","","","","","","99"},
                {"", "","","","","","","","","","","99"},
                {"", "","","","","","","","","","","99"},
                {"", "","","","","","","","","","","99"},
                {"", "","","","","","","","","","","99"},
                {"", "","","","","","","","","","","99"},
                {"", "","","","","","","","","","","99"},
                {"", "","","","","","","","","","","99"},
                {"", "","","","","","","","","","","99"},
                {"", "","","","","","","","","","","99"},
                {"", "","","","","","","","","","","99"},
                {"", "","","","","","","","","","","99"},
                {"", "","","","","","","","","","","99"},
                {"", "","","","","","","","","","","99"},
                {"", "","","","","","","","","","","99"},
                {"", "","","","","","","","","","","99"},
                {"", "","","","","","","","","","","99"},
                {"", "","","","","","","","","","","99"},
                {"", "","","","","","","","","","","99"},
                {"", "","","","","","","","","","","99"},
                {"", "","","","","","","","","","","99"},
                {"", "","","","","","","","","","","99"},
                {"", "","","","","","","","","","","99"},
                {"", "","","","","","","","","","","99"},
                {"", "","","","","","","","","","","99"},
                {"", "","","","","","","","","","","99"},
                {"", "","","","","","","","","","","99"},
                {"", "","","","","","","","","","","99"},
                {"", "","","","","","","","","","","99"},
                {"", "","","","","","","","","","","99"},
                {"", "","","","","","","","","","","99"},
                {"", "","","","","","","","","","","99"}
            }
        };
    }
   
}
