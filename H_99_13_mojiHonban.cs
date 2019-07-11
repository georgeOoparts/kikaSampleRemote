﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class H_99_13_mojiHonban : MonoBehaviour
{
    //クリックした回数に合わせて、文字の表示、文字のバック点滅強調をするプログラム
    //ユクユクはこれを分割させたい。
    //　プレハブセット、共通変数セット、最後までクリックしても表示させる。めん土井。

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

    //4次元listを定義
    //List<List<List<List<string>>>> bunsho = new List<List<List<List<string>>>>();
    //k0016_99_2_1：2次元listの宣言
    private List<List<string>> kariList = new List<List<string>>();
    
    //k0016_99_1_1：listの宣言
    private List<string> M1 = new List<string>();

    void Start() 
    {
        
        //ここから↓ないとバグ出る-----------------
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
        //ここから↑ないとバグ出る-----------------
    }
   

    private int kyouchouHenkanInt;
    void Update() 
    {
        if (Input.GetKeyDown("0")) 
        {
            listReset();
            kyotu.mojiSwitch = 0;
        } 
        else if (Input.GetKeyDown("1")) 
        {
            listReset();
            kyotu.mojiSwitch = 1;
        } 
        else if (Input.GetKeyDown("2")) 
        {
            listReset();
            kyotu.mojiSwitch = 2;
        } 
        else if (Input.GetKeyDown("3")) 
        {
            listReset();
            kyotu.mojiSwitch = 3;
        }

        //kyotu.rrCountの数を増やす
        if (Input.GetMouseButtonDown(0)) 
        {
            listReset();
            kyotu.rrCount++;
        } 
        else if (Input.GetMouseButtonDown(1)) 
        {
            listReset();
            kyotu.MCount++;
            kyotu.rrCount = 0;
        }
        //listReset();
        hairetuToList();
        

        //UItextに2次元配列の値を入れていく
        //文章増えるたびに変更
        for (int i = 0; i < kodomoTextText.Count; i++) 
        {
            if (kyotu.MCount == 0) 
            {
                if (kyotu.rrCount < m1_0.GetLength(0)) {
                    //mojipanelの各UItextに文字を代入していく
                    kodomoTextText[i].text = kariList[kyotu.rrCount][i];
                } else {
                    //最終行を出力し続ける:mojipanelの各UItextに文字を代入していく
                    kodomoTextText[i].text = kariList[m1_0.GetLength(0) - 1][i];
                }
            }
            else if (kyotu.MCount == 1) {
                if (kyotu.rrCount < m1_1.GetLength(0)) {
                    //mojipanelの各UItextに文字を代入していく
                    kodomoTextText[i].text = kariList[kyotu.rrCount][i];//eeee
                } else {
                    //最終行を出力し続ける:mojipanelの各UItextに文字を代入していく
                    kodomoTextText[i].text = kariList[m1_1.GetLength(0) - 1][i];
                }
            }
        }
        //文章増えるたびに変更
        //文字が入った配列の情報から、強調すべき文字の順番をintで得る
        //k10_2:strin>int変換
        if (kyotu.MCount == 0) 
        {
            if (kyotu.rrCount < m1_0.GetLength(0))
                kyouchouHenkanInt = int.Parse(m1_0[kyotu.rrCount, m1_0.GetLength(1) - 1]);
        }
        else if (kyotu.MCount == 1) {
            if (kyotu.rrCount < m1_1.GetLength(0))
                kyouchouHenkanInt = int.Parse(m1_1[kyotu.rrCount, m1_1.GetLength(1) - 1]);
        }


        //てきすとの強調kyochouPanel(kyouchouHenkanInt);でどこも強調しない数値99
        //kyouchouHenkanInt = 99;

        //強調すべきパネルを強調するメソッド
        kyochouPanel(kyouchouHenkanInt);///
        Debug.Log("okkkkkk");

    }

    //list 初期化
    void listReset() 
    {
        ///k0016_99_1_1_4　：Listすべての要素を削除
        kariList.Clear();
    }

    //文章増えるたびに変更
    //配列からlistへ文字を送る
    void hairetuToList() 
    {
        //文字パネルに入れるlistに内容を入れる
        if(kyotu.MCount==0) 
        {
            for (int i = 0; i < m1_0.GetLength(0); i++) {
                //k0016_99_2_1_1：2次元list [0][],[1][]をつくる
                kariList.Add(new List<string>());

                for (int j = 0; j < m1_0.GetLength(1); j++) {
                    kariList[i].Add(m1_0[i, j]);
                }
            }
        }
        else if (kyotu.MCount == 1) {
            for (int i = 0; i < m1_1.GetLength(0); i++) {
                //k0016_99_2_1_1：2次元list [0][],[1][]をつくる
                kariList.Add(new List<string>());

                for (int j = 0; j < m1_1.GetLength(1); j++) {
                    kariList[i].Add(m1_1[i, j]);
                }
            }
        }
    }
    //Uitextの中身----------------------------------------------------------------------------------------------------
    //文章増えるたびに変更
    //3次元配列
    private string[,] m1_0 =new string[,]
    {
        {"命題I-1","","","","","","","","","","","99"},
    　  {"与えられた直線", "を","一辺","とする","正三角形","を作図する事。","","","","","","0"},
        {"与えられた直線", "を","一辺","とする","正三角形","を作図する事。","","","","","","2"},
        {"与えられた直線", "を","一辺","とする","正三角形","を作図する事。","","","","","","4"},
        {"与えられた直線", "を","一辺","とする","正三角形","を作図する事。","","","","","","99"},
    };

    private string[,] m1_1 = new string[,]
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
    };

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
            //共通変数の kyotuEla.tenmetuOnOffで点滅処理
            mojiPanel[count].GetComponent<Image>().enabled = kyotuEla.tenmetuOnOff;///
        }
            
    }
    //Uitextの中身----------------------------------------------------------------------------------------------------
    //3次元配列
   
}
