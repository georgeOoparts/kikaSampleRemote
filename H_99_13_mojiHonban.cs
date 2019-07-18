using System.Collections;
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
        //kyotu.mojiSwitch 初期値:3
        //変更
        //公理:0,公準:1,定義:2,meidai:3
        if (Input.GetKeyDown("0")) 
        {
            listReset();
            kyotu.rrCount = 0;
            //kyotu.MCount = 0;
            kyotu.mojiSwitch = 0;
        } 
        else if (Input.GetKeyDown("1")) 
        {
            listReset();
            kyotu.rrCount = 0;
            kyotu.mojiSwitch = 1;
        } 
        else if (Input.GetKeyDown("2")) 
        {
            listReset();
            kyotu.rrCount = 0;
            kyotu.mojiSwitch = 2;
        } 
        else if (Input.GetKeyDown("3")) 
        {
            listReset();
            kyotu.rrCount = 0;
            kyotu.mojiSwitch = 3;
        } 
        //rrcountを戻すにはとりあえずｂを押す
        else if (Input.GetKeyDown("b")) {
            listReset();
            if(kyotu.rrCount>0)//0の時はバックできない
            kyotu.rrCount--;
        }
        //mcountを戻すにはとりあえずｂを押す
        else if (Input.GetKeyDown("n")) {
            listReset();
            kyotu.rrCount=0;
            if (kyotu.MCount > 0)//0の時はバックできない
                kyotu.MCount--;
        }

        //kyotu.rrCountの数を増やす
        if (Input.GetMouseButtonDown(0)) 
        {
            listReset();
            //rrcountが紙芝居の最後のページじゃなければ
            //文字が増えるたびここも増える1--------ここから-----123----------
            //公理:0,公準:1,定義:2,meidai:3
            if (kyotu.mojiSwitch == 0)//kouri　4つ
            {
                if (kyotu.MCount == 0) 
                {
                    if (kyotu.rrCount < ka1.GetLength(0)-1) 
                    {
                        kyotu.rrCount++;
                    }
                    
                }
                else if (kyotu.MCount == 1) 
                {
                    if (kyotu.rrCount < ka3.GetLength(0) - 1) 
                    {
                        kyotu.rrCount++;
                    }
                } 
                else if (kyotu.MCount == 2) 
                {
                    if (kyotu.rrCount < ka4.GetLength(0) - 1) 
                    {
                        kyotu.rrCount++;
                    }
                } 
                else if (kyotu.MCount == 3) 
                {
                    if (kyotu.rrCount < ka5.GetLength(0) - 1) 
                    {
                        kyotu.rrCount++;
                    }
                }
            }
            else if (kyotu.mojiSwitch == 1)//koujun　3つ kjp1～3
            {
                if (kyotu.MCount == 0) {
                    if (kyotu.rrCount < kjp1.GetLength(0) - 1) {
                        kyotu.rrCount++;
                    }

                } else if (kyotu.MCount == 1) {
                    if (kyotu.rrCount < kjp2.GetLength(0) - 1) {
                        kyotu.rrCount++;
                    }
                } else if (kyotu.MCount == 2) {
                    if (kyotu.rrCount < kjp3.GetLength(0) - 1) {
                        kyotu.rrCount++;
                    }
                }
            } 
            else if (kyotu.mojiSwitch == 3)//meidai 
            {
                if (kyotu.MCount == 0) 
                {
                    if (kyotu.rrCount < m1_1.GetLength(0)-1) 
                    {
                        kyotu.rrCount++;
                    } 
                } 
                else if (kyotu.MCount == 1) 
                {
                    if (kyotu.rrCount < m1_2.GetLength(0)-1) 
                    {
                        kyotu.rrCount++;
                    } 
                }
            }

        } 
        else if (Input.GetMouseButtonDown(1)) 
        {
            listReset();
            kyotu.MCount++;
            kyotu.rrCount = 0;
        }

        hairetuToList();

        

        //UItextに2次元配列の値を入れていく
        //文章増えるたびに変更2---------------------------------
        for (int i = 0; i < kodomoTextText.Count; i++) 
        {
            //公理:0,公準:1,定義:2,meidai:3
            if (kyotu.mojiSwitch == 0)//kouri
            {
                if (kyotu.MCount == 0) {
                    if (kyotu.rrCount < ka1.GetLength(0)) {
                        //mojipanelの各UItextに文字を代入していく
                        kodomoTextText[i].text = kariList[kyotu.rrCount][i];
                    } else {
                        //最終行を出力し続ける:mojipanelの各UItextに文字を代入していく
                        kodomoTextText[i].text = kariList[ka1.GetLength(0) - 1][i];
                    }

                }
                else if (kyotu.MCount == 1) {
                    if (kyotu.rrCount < ka3.GetLength(0)) {
                        //mojipanelの各UItextに文字を代入していく
                        kodomoTextText[i].text = kariList[kyotu.rrCount][i];
                    } else {
                        //最終行を出力し続ける:mojipanelの各UItextに文字を代入していく
                        kodomoTextText[i].text = kariList[ka3.GetLength(0) - 1][i];
                    }

                } 
                else if (kyotu.MCount == 2) 
                {
                    if (kyotu.rrCount < ka4.GetLength(0)) 
                    {
                        //mojipanelの各UItextに文字を代入していく
                        kodomoTextText[i].text = kariList[kyotu.rrCount][i];
                    } 
                    else 
                    {
                        //最終行を出力し続ける:mojipanelの各UItextに文字を代入していく
                        kodomoTextText[i].text = kariList[ka4.GetLength(0) - 1][i];
                    }

                } 
                else if (kyotu.MCount == 3) 
                {
                    if (kyotu.rrCount < ka5.GetLength(0)) 
                    {
                        //mojipanelの各UItextに文字を代入していく
                        kodomoTextText[i].text = kariList[kyotu.rrCount][i];
                    } 
                    else 
                    {
                        //最終行を出力し続ける:mojipanelの各UItextに文字を代入していく
                        kodomoTextText[i].text = kariList[ka5.GetLength(0) - 1][i];
                    }
                }
            }
            else if (kyotu.mojiSwitch == 1)//koujun 3tu
            {
                if (kyotu.MCount == 0) {
                    if (kyotu.rrCount < kjp1.GetLength(0)) {
                        //mojipanelの各UItextに文字を代入していく
                        kodomoTextText[i].text = kariList[kyotu.rrCount][i];
                    } else {
                        //最終行を出力し続ける:mojipanelの各UItextに文字を代入していく
                        kodomoTextText[i].text = kariList[kjp1.GetLength(0) - 1][i];
                    }

                } else if (kyotu.MCount == 1) {
                    if (kyotu.rrCount < kjp2.GetLength(0)) {
                        //mojipanelの各UItextに文字を代入していく
                        kodomoTextText[i].text = kariList[kyotu.rrCount][i];
                    } else {
                        //最終行を出力し続ける:mojipanelの各UItextに文字を代入していく
                        kodomoTextText[i].text = kariList[kjp2.GetLength(0) - 1][i];
                    }

                } else if (kyotu.MCount == 2) {
                    if (kyotu.rrCount < kjp3.GetLength(0)) {
                        //mojipanelの各UItextに文字を代入していく
                        kodomoTextText[i].text = kariList[kyotu.rrCount][i];
                    } else {
                        //最終行を出力し続ける:mojipanelの各UItextに文字を代入していく
                        kodomoTextText[i].text = kariList[kjp3.GetLength(0) - 1][i];
                    }

                } 
            }
            else if (kyotu.mojiSwitch == 3)//meidai 
            {
                if (kyotu.MCount == 0) {
                    if (kyotu.rrCount < m1_1.GetLength(0)) {
                        //mojipanelの各UItextに文字を代入していく
                        kodomoTextText[i].text = kariList[kyotu.rrCount][i];
                    } else {
                        //最終行を出力し続ける:mojipanelの各UItextに文字を代入していく
                        kodomoTextText[i].text = kariList[m1_1.GetLength(0) - 1][i];
                    }
                } else if (kyotu.MCount == 1) {
                    if (kyotu.rrCount < m1_2.GetLength(0)) {
                        //mojipanelの各UItextに文字を代入していく
                        kodomoTextText[i].text = kariList[kyotu.rrCount][i];//eeee
                    } else {
                        //最終行を出力し続ける:mojipanelの各UItextに文字を代入していく
                        kodomoTextText[i].text = kariList[m1_2.GetLength(0) - 1][i];
                    }
                }
            }
            
        }
        //文章増えるたびに変更
        //文字が入った配列の情報から、強調すべき文字の順番をintで得る

        //公理:0,公準:1,定義:2,meidai:3
        if (kyotu.mojiSwitch == 0)//kouri
        {
            //k10_2:strin>int変換
            if (kyotu.MCount == 0) {
                if (kyotu.rrCount < ka1.GetLength(0))
                    kyouchouHenkanInt = int.Parse(ka1[kyotu.rrCount, ka1.GetLength(1) - 1]);
            }
            else if (kyotu.MCount == 1) {
                if (kyotu.rrCount < ka3.GetLength(0))
                    kyouchouHenkanInt = int.Parse(ka3[kyotu.rrCount, ka3.GetLength(1) - 1]);
            } 
            else if (kyotu.MCount == 2) {
                if (kyotu.rrCount < ka4.GetLength(0))
                    kyouchouHenkanInt = int.Parse(ka4[kyotu.rrCount, ka4.GetLength(1) - 1]);
            } 
            else if (kyotu.MCount == 3) {
                if (kyotu.rrCount < ka5.GetLength(0))
                    kyouchouHenkanInt = int.Parse(ka5[kyotu.rrCount, ka5.GetLength(1) - 1]);
            }
        }
        else if (kyotu.mojiSwitch == 1)//koujun
        {
            //k10_2:strin>int変換
            if (kyotu.MCount == 0) {
                if (kyotu.rrCount < kjp1.GetLength(0))
                    kyouchouHenkanInt = int.Parse(ka1[kyotu.rrCount, kjp1.GetLength(1) - 1]);
            } 
            else if (kyotu.MCount == 1) {
                if (kyotu.rrCount < kjp2.GetLength(0))
                    kyouchouHenkanInt = int.Parse(kjp2[kyotu.rrCount, kjp2.GetLength(1) - 1]);
            } 
            else if (kyotu.MCount == 2) {
                if (kyotu.rrCount < kjp3.GetLength(0))
                    kyouchouHenkanInt = int.Parse(kjp3[kyotu.rrCount, kjp3.GetLength(1) - 1]);
            } 
        } 
        else if (kyotu.mojiSwitch == 3)//meidai 
        {
            //k10_2:strin>int変換
            if (kyotu.MCount == 0) {
                if (kyotu.rrCount < m1_1.GetLength(0))
                    kyouchouHenkanInt = int.Parse(m1_1[kyotu.rrCount, m1_1.GetLength(1) - 1]);
            } 
            else if (kyotu.MCount == 1) {
                if (kyotu.rrCount < m1_2.GetLength(0))
                    kyouchouHenkanInt = int.Parse(m1_2[kyotu.rrCount, m1_2.GetLength(1) - 1]);
            }
            else if (kyotu.MCount == 1) {
                if (kyotu.rrCount < m1_2.GetLength(0))
                    kyouchouHenkanInt = int.Parse(m1_2[kyotu.rrCount, m1_2.GetLength(1) - 1]);
            }

        }
        


        //てきすとの強調kyochouPanel(kyouchouHenkanInt);でどこも強調しない数値99
        //kyouchouHenkanInt = 99;

        //強調すべきパネルを強調するメソッド
        kyochouPanel(kyouchouHenkanInt);///
        Debug.Log("ok::"+/*kyotu.mojiSwitch*//*m1_2.GetLength(0)*/kyotu.rrCount);

    }

    //list 初期化
    void listReset() 
    {
        //kyotu.rrCount = 0;
        ///k0016_99_1_1_4　：Listすべての要素を削除
        kariList.Clear();

        //UItextに2次元配列の値を全てリセット
        //文章増えるたびに変更3---------------------------------
        for (int i = 0; i < kodomoTextText.Count; i++) {

            //公理:0,公準:1,定義:2,meidai:3
            if (kyotu.mojiSwitch == 0)//kouri
            {
                if (kyotu.MCount == 0) {
                    if (kyotu.rrCount < ka1.GetLength(0)) {
                        //mojipanelの各UItextに文字を代入していく
                        kodomoTextText[i].text = "";
                    }
                }
                else if (kyotu.MCount == 1) {
                    if (kyotu.rrCount < ka3.GetLength(0)) {
                        //mojipanelの各UItextに文字を代入していく
                        kodomoTextText[i].text = "";
                    }
                } 
                else if (kyotu.MCount == 2) {
                    if (kyotu.rrCount < ka4.GetLength(0)) {
                        //mojipanelの各UItextに文字を代入していく
                        kodomoTextText[i].text = "";
                    }
                } 
                else if (kyotu.MCount == 3) {
                    if (kyotu.rrCount < ka5.GetLength(0)) {
                        //mojipanelの各UItextに文字を代入していく
                        kodomoTextText[i].text = "";
                    }
                }
            }
            else if (kyotu.mojiSwitch == 1)//koujun
            {
                if (kyotu.MCount == 0) {
                    if (kyotu.rrCount < kjp1.GetLength(0)) {
                        //mojipanelの各UItextに文字を代入していく
                        kodomoTextText[i].text = "";
                    }
                } else if (kyotu.MCount == 1) {
                    if (kyotu.rrCount < kjp2.GetLength(0)) {
                        //mojipanelの各UItextに文字を代入していく
                        kodomoTextText[i].text = "";
                    }
                } else if (kyotu.MCount == 2) {
                    if (kyotu.rrCount < kjp3.GetLength(0)) {
                        //mojipanelの各UItextに文字を代入していく
                        kodomoTextText[i].text = "";
                    }
                } 
            } 
            else if (kyotu.mojiSwitch == 3)//meidai
            {
                if (kyotu.MCount == 0) {
                    if (kyotu.rrCount < m1_1.GetLength(0)) {
                        //mojipanelの各UItextに文字を代入していく
                        kodomoTextText[i].text = "";
                    }
                } else if (kyotu.MCount == 1) {
                    if (kyotu.rrCount < m1_2.GetLength(0)) {
                        //mojipanelの各UItextに文字を代入していく
                        kodomoTextText[i].text = "";//eeee
                    }
                }
            }
            
        }
    }

    //文章増えるたびに変更
    //配列からlistへ文字を送る
    void hairetuToList() 
    {
        //文章増えるたびに変更4---------------------------------
        //文字パネルに入れるlistに内容を入れる
        //公理:0,公準:1,定義:2,meidai:3
        //kouriに対応
        if (kyotu.mojiSwitch == 0) {
            //kouriに対応
            if (kyotu.MCount == 0) {
                for (int i = 0; i < ka1.GetLength(0); i++) {
                    //k0016_99_2_1_1：2次元list [0][],[1][]をつくる
                    kariList.Add(new List<string>());

                    for (int j = 0; j < ka1.GetLength(1); j++) {
                        kariList[i].Add(ka1[i, j]);
                    }
                }
            }
            else if (kyotu.MCount == 1) {
                for (int i = 0; i < ka3.GetLength(0); i++) {
                    //k0016_99_2_1_1：2次元list [0][],[1][]をつくる
                    kariList.Add(new List<string>());

                    for (int j = 0; j < ka3.GetLength(1); j++) {
                        kariList[i].Add(ka3[i, j]);
                    }
                }
            } 
            else if (kyotu.MCount == 2) {
                for (int i = 0; i < ka4.GetLength(0); i++) {
                    //k0016_99_2_1_1：2次元list [0][],[1][]をつくる
                    kariList.Add(new List<string>());

                    for (int j = 0; j < ka4.GetLength(1); j++) {
                        kariList[i].Add(ka4[i, j]);
                    }
                }
            } 
            else if (kyotu.MCount == 3) {
                for (int i = 0; i < ka5.GetLength(0); i++) {
                    //k0016_99_2_1_1：2次元list [0][],[1][]をつくる
                    kariList.Add(new List<string>());

                    for (int j = 0; j < ka5.GetLength(1); j++) {
                        kariList[i].Add(ka5[i, j]);
                    }
                }
            }

        }
        else if (kyotu.mojiSwitch == 1) 
        {
            //koujunに対応 3tu
            if (kyotu.MCount == 0) {
                for (int i = 0; i < kjp1.GetLength(0); i++) {
                    //k0016_99_2_1_1：2次元list [0][],[1][]をつくる
                    kariList.Add(new List<string>());

                    for (int j = 0; j < kjp1.GetLength(1); j++) {
                        kariList[i].Add(kjp1[i, j]);
                    }
                }
            } else if (kyotu.MCount == 1) {
                for (int i = 0; i < kjp2.GetLength(0); i++) {
                    //k0016_99_2_1_1：2次元list [0][],[1][]をつくる
                    kariList.Add(new List<string>());

                    for (int j = 0; j < kjp2.GetLength(1); j++) {
                        kariList[i].Add(kjp2[i, j]);
                    }
                }
            } else if (kyotu.MCount == 2) {
                for (int i = 0; i < kjp3.GetLength(0); i++) {
                    //k0016_99_2_1_1：2次元list [0][],[1][]をつくる
                    kariList.Add(new List<string>());

                    for (int j = 0; j < kjp3.GetLength(1); j++) {
                        kariList[i].Add(kjp3[i, j]);
                    }
                }
            } 

        }
        //meidaiに対応
        else if (kyotu.mojiSwitch == 3)        
        {
            //meidai1に対応
            if (kyotu.MCount == 0) {
                for (int i = 0; i < m1_1.GetLength(0); i++) {
                    //k0016_99_2_1_1：2次元list [0][],[1][]をつくる
                    kariList.Add(new List<string>());

                    for (int j = 0; j < m1_1.GetLength(1); j++) {
                        kariList[i].Add(m1_1[i, j]);
                    }
                }
            }
            //meidai2に対応
            else if (kyotu.MCount == 1) 
            {
                for (int i = 0; i < m1_2.GetLength(0); i++) {
                    //k0016_99_2_1_1：2次元list [0][],[1][]をつくる
                    kariList.Add(new List<string>());

                    for (int j = 0; j < m1_2.GetLength(1); j++) {
                        kariList[i].Add(m1_2[i, j]);
                    }
                }
            }
        }
        //文章増えるたびに変更、ここまで
    }
    //Uitextの中身----------------------------------------------------------------------------------------------------
    //文章増えるたびに変更
    //3次元配列
    private string[,] m1_1 =new string[,]//01
    {
        {"命題I-1","","","","","","","","","","","99"},
    　  {"与えられた直線", "を","一辺","とする","正三角形","を作図する事。","","","","","","0"},
        {"与えられた直線", "を","一辺","とする","正三角形","を作図する事。","","","","","","2"},
        {"与えられた直線", "を","一辺","とする","正三角形","を作図する事。","","","","","","4"},
        {"与えられた直線", "を","一辺","とする","正三角形","を作図する事。","","","","","","99"},
        {"AB","を与えられた","直線","とする。","","","","","","","","0"},
        {"AB","を与えられた","直線","とする。","","","","","","","","99"},
        {"このとき、", "AB","を一辺とする","正三角形","を作図することが","求められている。","","","","","","1"},
        {"このとき、", "AB","を一辺とする","正三角形","を作図することが","求められている。","","","","","","3"},
        {"このとき、", "AB","を一辺とする","正三角形","を作図することが","求められている。","","","","","","99"},
        {"A", "を中心とし、","AB","を半径とする円","BCD","を描く[公準P-3]","","","","","","0"},
        {"A", "を中心とし、","AB","を半径とする円","BCD","を描く[公準P-3]","","","","","","2"},
        {"A", "を中心とし、","AB","を半径とする円","BCD","を描く[公準P-3]","","","","","","4"},
        //↓本文        
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

    private string[,] m1_2 = new string[,]//0
    {
        {"命題I-2","","","","","","","","","","","99"},
        {"与えられた直線", "と","同じ長さの直線","を","与えられた点","から作図すること。","","","","","","0"},
        {"与えられた直線", "と","同じ長さの直線","を","与えられた点","から作図すること。","","","","","","2"},
        {"与えられた直線", "と","同じ長さの直線","を","与えられた点","から作図すること。","","","","","","4"},
        {"与えられた直線", "と","同じ長さの直線","を","与えられた点","から作図すること。","","","","","","99"},
        
    };
    private string[,] m1_3 = new string[,]
    {
        {"命題I-3","","","","","","","","","","","99"},
        {"与えられた直線", "と","同じ長さの直線","を","与えられた点","から作図すること。","","","","","","99"},
        {"与えられた直線", "と","同じ長さの直線","を","与えられた点","から作図すること。","","","","","","0"},
        {"与えられた直線", "と","同じ長さの直線","を","与えられた点","から作図すること。","","","","","","2"},
        {"与えられた直線", "と","同じ長さの直線","を","与えられた点","から作図すること。","","","","","","4"},
        {"与えられた直線", "と","同じ長さの直線","を","与えられた点","から作図すること。","","","","","","99"},
    };
    //kouri---------------------------------------------------------------
    private string[,] ka1 = new string[,]//01
    {
        {"公理a1","","","","","","","","","","","99"},
        {"同じもの","に","等しいもの","は","互いに等しい。","","","","","","","0"},
        {"同じもの","に","等しいもの","は","互いに等しい。","","","","","","","2"},
        {"同じもの","に","等しいもの","は","互いに等しい。","","","","","","","4"},
        {"同じもの","に","等しいもの","は","互いに等しい。","","","","","","","99"},
    };
    private string[,] ka3 = new string[,]//01
    {
        {"公理a3","","","","","","","","","","","99"},
        {"等しいもの","から","等しいもの","を","引いた差","は","互いに等しい。","","","","","0"},
        {"等しいもの","から","等しいもの","を","引いた差","は","互いに等しい。","","","","","2"},
        {"等しいもの","から","等しいもの","を","引いた差","は","互いに等しい。","","","","","4"},
        {"等しいもの","から","等しいもの","を","引いた差","は","互いに等しい。","","","","","99"},

    };
    private string[,] ka4 = new string[,]
    {
        {"公理a4","","","","","","","","","","","99"},
        {"互いに重なり合うもの","は互いに等しい。","","","","","","","","","","0"},
        {"互いに重なり合うもの","は互いに等しい。","","","","","","","","","","99"},
    };
    private string[,] ka5 = new string[,]
    {
        {"公理a5","","","","","","","","","","","99"},
        {"全体","は","部分","より大きい。","","","","","","","","0"},
        {"全体","は","部分","より大きい。","","","","","","","","2"},
        {"全体","は","部分","より大きい。","","","","","","","","99"},
    };
    //koujun------------------------------------------------------------------
    private string[,] kjp1 = new string[,]
    {
        {"公準p1","","","","","","","","","","","99"},
        {"任意の点","から","任意の点","へ","直線","を引くこと。","","","","","","0"},
        {"任意の点","から","任意の点","へ","直線","を引くこと。","","","","","","2"},
        {"任意の点","から","任意の点","へ","直線","を引くこと。","","","","","","4"},
        {"任意の点","から","任意の点","へ","直線","を引くこと。","","","","","","99"},
    };
    private string[,] kjp2 = new string[,]
    {
        {"公準p2","","","","","","","","","","","99"},
        {"任意の直線","を連続して延ばすこと。","","","","","","","","","","0"},
        {"任意の直線","を連続して延ばすこと。","","","","","","","","","","99"},
    };
    private string[,] kjp3 = new string[,]
    {
        {"公準p3","","","","","","","","","","","99"},
        {"任意の中心","と","任意の半径","の","円","を描くこと。","","","","","","0"},
        {"任意の中心","と","任意の半径","の","円","を描くこと。","","","","","","2"},
        {"任意の中心","と","任意の半径","の","円","を描くこと。","","","","","","4"},
        {"任意の中心","と","任意の半径","の","円","を描くこと。","","","","","","99"},
    };
    //teigi
    private string[,] tdi1 = new string[,]
    {
        {"定義di1","","","","","","","","","","","99"},
        {"点は部分をもたないものである。","に","等しいもの","は互いに等しい。","","","","","","","","99"},
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
