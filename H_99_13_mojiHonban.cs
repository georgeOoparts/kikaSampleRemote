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
            else if (kyotu.mojiSwitch == 2)//teigi　2つ
            {
                if (kyotu.MCount == 0) {
                    if (kyotu.rrCount < tdi1.GetLength(0) - 1) {
                        kyotu.rrCount++;
                    }

                } else if (kyotu.MCount == 1) {
                    if (kyotu.rrCount < tdi15.GetLength(0) - 1) {
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
            else if (kyotu.mojiSwitch == 2)//teigi 2tu
            {
                if (kyotu.MCount == 0) {
                    if (kyotu.rrCount < tdi1.GetLength(0)) {
                        //mojipanelの各UItextに文字を代入していく
                        kodomoTextText[i].text = kariList[kyotu.rrCount][i];
                    } else {
                        //最終行を出力し続ける:mojipanelの各UItextに文字を代入していく
                        kodomoTextText[i].text = kariList[tdi1.GetLength(0) - 1][i];
                    }

                } else if (kyotu.MCount == 1) {
                    if (kyotu.rrCount < tdi15.GetLength(0)) {
                        //mojipanelの各UItextに文字を代入していく
                        kodomoTextText[i].text = kariList[kyotu.rrCount][i];
                    } else {
                        //最終行を出力し続ける:mojipanelの各UItextに文字を代入していく
                        kodomoTextText[i].text = kariList[tdi15.GetLength(0) - 1][i];
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
        else if (kyotu.mojiSwitch == 2)//teigi
        {
            //k10_2:strin>int変換
            if (kyotu.MCount == 0) {
                if (kyotu.rrCount < tdi1.GetLength(0))
                    kyouchouHenkanInt = int.Parse(tdi1[kyotu.rrCount, tdi1.GetLength(1) - 1]);
            } else if (kyotu.MCount == 1) {
                if (kyotu.rrCount < tdi15.GetLength(0))
                    kyouchouHenkanInt = int.Parse(tdi15[kyotu.rrCount, tdi15.GetLength(1) - 1]);
            } 
        } else if (kyotu.mojiSwitch == 3)//meidai 
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
            else if (kyotu.mojiSwitch == 2)//teigi
            {
                if (kyotu.MCount == 0) {
                    if (kyotu.rrCount < tdi1.GetLength(0)) {
                        //mojipanelの各UItextに文字を代入していく
                        kodomoTextText[i].text = "";
                    }
                } else if (kyotu.MCount == 1) {
                    if (kyotu.rrCount < tdi15.GetLength(0)) {
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
        else if (kyotu.mojiSwitch == 2) 
        {
            //koujunに対応 3tu
            if (kyotu.MCount == 0) {
                for (int i = 0; i < tdi1.GetLength(0); i++) {
                    //k0016_99_2_1_1：2次元list [0][],[1][]をつくる
                    kariList.Add(new List<string>());

                    for (int j = 0; j < tdi1.GetLength(1); j++) {
                        kariList[i].Add(tdi1[i, j]);
                    }
                }
            } else if (kyotu.MCount == 1) {
                for (int i = 0; i < tdi15.GetLength(0); i++) {
                    //k0016_99_2_1_1：2次元list [0][],[1][]をつくる
                    kariList.Add(new List<string>());

                    for (int j = 0; j < tdi15.GetLength(1); j++) {
                        kariList[i].Add(tdi15[i, j]);
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
        //
        {"Aを与えられた点、", "BCを与えられた直線","とする。","","","","","","","","","0"},
        {"Aを与えられた点、", "BCを与えられた直線","とする。","","","","","","","","","1"},
        {"Aを与えられた点、", "BCを与えられた直線","とする。","","","","","","","","","99"},
        {"このとき、", "A","から","BC","と同じ長さの直線","を作図することが求められている。","","","","","","1"},
        {"このとき、", "A","から","BC","と同じ長さの直線","を作図することが求められている。","","","","","","3"},
        {"このとき、", "A","から","BC","と同じ長さの直線","を作図することが求められている。","","","","","","99"},
        {"AB", "を","A","と","B","を結ぶ直線とすると","[公準P-1]","","","","","0"},
        {"AB", "を","A","と","B","を結ぶ直線とすると","[公準P-1]","","","","","2"},
        {"AB", "を","A","と","B","を結ぶ直線とすると","[公準P-1]","","","","","4"},
        {"AB", "を","A","と","B","を結ぶ直線とすると","[公準P-1]","","","","","99"},

        {"直線AB", "を","一辺とする","正三角形DAB","を作図することができる","[命題I-1]","","","","","","0"},
        {"直線AB", "を","一辺とする","正三角形DAB","を作図することができる","[命題I-1]","","","","","","3"},
        {"直線AB", "を","一辺とする","正三角形DAB","を作図することができる","[命題I-1]","","","","","","99"},

        {"DA", "と","DB","を延長し、","直線AE","と","BF","を描く","[公準P-2]","","","0"},
        {"DA", "と","DB","を延長し、","直線AE","と","BF","を描く","[公準P-2]","","","2"},
        {"DA", "と","DB","を延長し、","直線AE","と","BF","を描く","[公準P-2]","","","4"},
        {"DA", "と","DB","を延長し、","直線AE","と","BF","を描く","[公準P-2]","","","6"},
        {"DA", "と","DB","を延長し、","直線AE","と","BF","を描く","[公準P-2]","","","99"},
        
        {"そして、", "B","を中心とし","BC","を半径とする","円CGH","を描き","[公準P-3]","","","","1"},
        {"そして、", "B","を中心とし","BC","を半径とする","円CGH","を描き","[公準P-3]","","","","3"},
        {"そして、", "B","を中心とし","BC","を半径とする","円CGH","を描き","[公準P-3]","","","","5"},
        {"そして、", "B","を中心とし","BC","を半径とする","円CGH","を描き","[公準P-3]","","","","99"},

        {"D", "を中心とし","DG","を半径とする","円GKL","を描く","[公準P-3]","","","","","0"},
        {"D", "を中心とし","DG","を半径とする","円GKL","を描く","[公準P-3]","","","","","2"},
        {"D", "を中心とし","DG","を半径とする","円GKL","を描く","[公準P-3]","","","","","4"},
        {"D", "を中心とし","DG","を半径とする","円GKL","を描く","[公準P-3]","","","","","99"},
        
        
        //{"", "","","","","","","","","","","99"},
        {"ここで、", "B","は","円CGH","の中心であるから、","BC","は","BG","と等しい","[定義DI-15]","","1"},
        {"ここで、", "B","は","円CGH","の中心であるから、","BC","は","BG","と等しい","[定義DI-15]","","3"},
        {"ここで、", "B","は","円CGH","の中心であるから、","BC","は","BG","と等しい","[定義DI-15]","","5"},
        {"ここで、", "B","は","円CGH","の中心であるから、","BC","は","BG","と等しい","[定義DI-15]","","7"},
        {"ここで、", "B","は","円CGH","の中心であるから、","BC","は","BG","と等しい","[定義DI-15]","","99"},

        {"また、", "D","は","円GKL","の中心であるから、","DL","は","DG","と等しい","[定義DI-15]。","","1"},
        {"また、", "D","は","円GKL","の中心であるから、","DL","は","DG","と等しい","[定義DI-15]。","","3"},
        {"また、", "D","は","円GKL","の中心であるから、","DL","は","DG","と等しい","[定義DI-15]。","","5"},
        {"また、", "D","は","円GKL","の中心であるから、","DL","は","DG","と等しい","[定義DI-15]。","","7"},
        {"また、", "D","は","円GKL","の中心であるから、","DL","は","DG","と等しい","[定義DI-15]。","","99"},

        {"これらの中にある", "DA","と","DB","は等しいから、","それらを引いた差のAL","は","BG","と等しい","[公理A-3]。","","1"},
        {"これらの中にある", "DA","と","DB","は等しいから、","それらを引いた差のAL","は","BG","と等しい","[公理A-3]。","","3"},
        {"これらの中にある", "DA","と","DB","は等しいから、","それらを引いた差のAL","は","BG","と等しい","[公理A-3]。","","5"},
        {"これらの中にある", "DA","と","DB","は等しいから、","それらを引いた差のAL","は","BG","と等しい","[公理A-3]。","","7"},
        {"これらの中にある", "DA","と","DB","は等しいから、","それらを引いた差のAL","は","BG","と等しい","[公理A-3]。","","9"},
        {"これらの中にある", "DA","と","DB","は等しいから、","それらを引いた差のAL","は","BG","と等しい","[公理A-3]。","","99"},

        {"BC", "と","BG","は等しいから、","同じものに等しいものは等しいことから","[公理A-1]","、AL","は","BC","と等しい。","","0"},
        {"BC", "と","BG","は等しいから、","同じものに等しいものは等しいことから","[公理A-1]","、AL","は","BC","と等しい。","","2"},
        {"BC", "と","BG","は等しいから、","同じものに等しいものは等しいことから","[公理A-1]","、AL","は","BC","と等しい。","","7"},
        {"BC", "と","BG","は等しいから、","同じものに等しいものは等しいことから","[公理A-1]","、AL","は","BC","と等しい。","","9"},
        {"BC", "と","BG","は等しいから、","同じものに等しいものは等しいことから","[公理A-1]","、AL","は","BC","と等しい。","","99"},

        {"ゆえに、", "直線AL","は与えられた","直線BC","と等しく、","与えられた","点A","から引かれている。","","","","1"},
        {"ゆえに、", "直線AL","は与えられた","直線BC","と等しく、","与えられた","点A","から引かれている。","","","","3"},
        {"ゆえに、", "直線AL","は与えられた","直線BC","と等しく、","与えられた","点A","から引かれている。","","","","6"},
        {"ゆえに、", "直線AL","は与えられた","直線BC","と等しく、","与えられた","点A","から引かれている。","","","","99"},

        {"これが求められていた", "ことであった。","","","","","","","","","","99"},
        //{"", "","","","","","","","","","","99"},

    };
    private string[,] m1_3 = new string[,]
    {
        {"命題I-3","","","","","","","","","","","99"},
        {"長さが異なる", "二つの直線","が与えられたとき、","長い方","から","短い方","の長さを切り取ること。","","","","","1"},
        {"長さが異なる", "二つの直線","が与えられたとき、","長い方","から","短い方","の長さを切り取ること。","","","","","3"},
        {"長さが異なる", "二つの直線","が与えられたとき、","長い方","から","短い方","の長さを切り取ること。","","","","","5"},
        {"長さが異なる", "二つの直線","が与えられたとき、","長い方","から","短い方","の長さを切り取ること。","","","","","99"},
        //{"", "","","","","","","","","","","99"},
        {"ABとCを与えられた長さが異なる二つの直線とし、ABの方が長いものとする。", "","","","","","","","","","","99"},
        {"このとき、ABからCの長さ分を切り取ることが求められている。", "","","","","","","","","","","99"},
        {"ADをCと同じ長さのAから引かれた直線とする[命題I-2]。", "","","","","","","","","","","99"},
        {"そして、Aを中心とし半径ADの円DEFを描く[公準P-3]。", "","","","","","","","","","","99"},
        {"Aは円DEFの中心であるから、AEはADと等しい[定義I-15]。", "","","","","","","","","","","99"},
        {"ここでCはADと等しいから、AEとCは共にADと等しく、よってAEはCと等しい[公理A-1]。", "","","","","","","","","","","99"},
        {"ゆえに、与えられた二つの直線ABとCについて、AEは短い方の直線Cと等しく、", "","","","","","","","","","","99"},
        {"長い方の直線ABを切り取る。これが求められていたことであった。", "","","","","","","","","","","99"},
    };
    private string[,] m1_4 = new string[,]
    {
        {"命題I-4","","","","","","","","","","","99"},
        {"二つの三角形において、二つの辺がそれぞれ等しく、", "","","","","","","","","","","99"},
        {"その二辺に挟まれる角も等しいならば、", "","","","","","","","","","","99"},
        {"底辺も等しく、二つの三角形は等しい。", "","","","","","","","","","","99"},
        {"そして、等しい二辺に対する残りの角もそれぞれ等しい。", "","","","","","","","","","","99"},
        
        {"二つの三角形ABCとDEFにおいて、", "","","","","","","","","","","99"},
        {"二辺ABとACが二辺DEとDFにそれぞれ等しい、", "","","","","","","","","","","99"},
        {"すなわち、ABとDE、ACとDFが等しいとし、", "","","","","","","","","","","99"},
        {"そして角BACと角EDFが等しいものとする。", "","","","","","","","","","","99"},
        {"このとき、底辺BCと底辺EFが等しく、", "","","","","","","","","","","99"},
        {"角ABCと角DEF、角ACBと角DFEが等しいと主張する。", "","","","","","","","","","","99"},
        {"三角形ABCを三角形DEFに重ね合わせ、", "","","","","","","","","","","99"},
        {"点Aは点Dに、直線ABは直線DEと一致するようにする。", "","","","","","","","","","","99"},
        {"このときABとDEの長さが等しいことから点Bは点Eに一致する。", "","","","","","","","","","","99"},
        {"ABとDEが一致していることと角BACがEDFに等しいことから、", "","","","","","","","","","","99"},
        {"直線ACとDFも一致する。", "","","","","","","","","","","99"},
        {"したがって、点Cと点Fは一致する。", "","","","","","","","","","","99"},
        {"点Bは点Eと一致しているから底辺BCは底辺EFと一致する。", "","","","","","","","","","","99"},
        {"なぜならば、もし一致しないとすれば同じ点を結ぶ直線は唯一つであることに反するからである[公準P-1]。", "","","","","","","","","","","99"},
        {"したがって、底辺BCと底辺EFは一致し、互いに等しい[公理A-4]。", "","","","","","","","","","","99"},
        {"したがって、三角形ABCは三角形DEFと完全に一致し、互いに等しい[公理A-4]。", "","","","","","","","","","","99"},
        {"残りの角もそれぞれ一致し、互いに等しい[公理A-4]。", "","","","","","","","","","","99"},
        {"つまり、ABCとDEF、ACBとDFEは等しい[公理A-4]。", "","","","","","","","","","","99"},
        {"ゆえに、二つの三角形において、二つの辺がそれぞれ等しく、", "","","","","","","","","","","99"},
        {"その二辺に挟まれる角も等しいならば、底辺も等しく、二つの三角形は等しい。", "","","","","","","","","","","99"},
        {"そして、等しい二辺に対する残りの角もそれぞれ等しい。これが証明すべきことであった。", "","","","","","","","","","","99"},
        {"", "","","","","","","","","","","99"},
        {"", "","","","","","","","","","","99"},

    };
    private string[,] m1_5 = new string[,]
    {
        {"命題I-5","","","","","","","","","","","99"},
        {"二等辺三角形の底辺上の二つの角は互いに等しい、", "","","","","","","","","","","99"},
        {"そして、等辺を延長してできる底辺下の二つの角も互いに等しい。", "","","","","","","","","","","99"},

        {"ABCを辺ABと辺ACが等しい二等辺三角形とし、", "","","","","","","","","","","99"},
        {"BDとCEをABとACをそれぞれ延長した直線とする[公準P-2]。", "","","","","","","","","","","99"},
        {"このとき、角ABCとACB、角CBDとBCEが等しいと主張する。", "","","","","","","","","","","99"},
        {"点FをBD上にとり、AGをAEからAF分切り取ったとする[命題I-3]。", "","","","","","","","","","","99"},
        {"そして、直線FCとGBを描く[公準P-1]。", "","","","","","","","","","","99"},
        {"AFとAG、ABとACは等しいから、FA、ACはそれぞれGA、ABと等しく、", "","","","","","","","","","","99"},
        {"その挟む角FAGを共有するから、底辺FCと底辺GBは等しく、三角形AFCと三角形AGBは等しい。", "","","","","","","","","","","99"},
        {"さらに等辺に対する残りの角もそれぞれ等しい[命題I-4]。", "","","","","","","","","","","99"},
        {"すなわち、ACFとABG、AFCとAGBは等しい。AFとAGは等しいから、", "","","","","","","","","","","99"},
        {"そこから相等しいABとACを引いた差のBFとCGは等しい[公理A-3]。", "","","","","","","","","","","99"},
        {"FCとGBは等しいから、BF、FCとCG、GBがそれぞれ等しく、角BFCとCGBが等しく、", "","","","","","","","","","","99"},
        {"底辺BCが共有されている。したがって、三角形BFCと三角形CGBは等しく、", "","","","","","","","","","","99"},
        {"等しい二辺に対する残りの角もそれぞれ等しい[命題I-4]。", "","","","","","","","","","","99"},
        {"よって、FBCとGCB、BCFとＣＢＧは等しい。角ABGと角ACFは等しいが、", "","","","","","","","","","","99"},
        {"これからCBGとBCFを引いた残りのABCとACBは等しい[公理A-3]。", "","","","","","","","","","","99"},
        {"これらは三角形ABCの底辺上にある。またFBCとGCBも等しく、これらは底辺下にある。", "","","","","","","","","","","99"},
        {"ゆえに、二等辺三角形の底辺上の二つの角は互いに等しい、", "","","","","","","","","","","99"},
        {"そして、等辺を延長してできる底辺下の二つの角も互いに等しい。", "","","","","","","","","","","99"},
        {"これが証明すべきことであった。", "","","","","","","","","","","99"},
        {"", "","","","","","","","","","","99"},
    };
    private string[,] m1_6 = new string[,]
    {
        {"命題I-6","","","","","","","","","","","99"},
        {"三角形の二つの角が等しいならば、それらに対する二つの辺も互いに等しい。", "","","","","","","","","","","99"},
        
        {"三角形ABCにおいて角ABCと角ACBが等しいものとする。", "","","","","","","","","","","99"},
        {"このとき、辺ABが辺ACに等しいと主張する。", "","","","","","","","","","","99"},
        {"もしABがACと等しくなければどちらかが長いことになる。", "","","","","","","","","","","99"},
        {"ABがACより長いとすれば、ACと同じ長さの直線DBを切り取ることができる[命題I-3]。", "","","","","","","","","","","99"},
        {"このとき、直線DCを引く[公準P-1]。", "","","","","","","","","","","99"},
        {"DBはACと等しく、BCを共有しているから、DB、ＢＣとAC、CBの二辺がそれぞれ等しく、", "","","","","","","","","","","99"},
        {"角DBCと角ACBが等しい。", "","","","","","","","","","","99"},
        {"よって、底辺DCはABと等しく、三角形DBCと三角形ACBは等しい[命題I-4]。", "","","","","","","","","","","99"},
        {"これは小さいものと大きいものが等しいことになり矛盾である[公理A-5]。", "","","","","","","","","","","99"},
        {"したがって、ABとACは等しい。", "","","","","","","","","","","99"},
        {"ゆえに、三角形の二つの角が等しいならば、それらに対する二つの辺も互いに等しい。", "","","","","","","","","","","99"},
        {"これが証明すべきことであった。", "","","","","","","","","","","99"},

        //{"", "","","","","","","","","","","99"},
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
    //teigi 2tu
    private string[,] tdi1 = new string[,]
    {
        {"定義di1","","","","","","","","","","","99"},
        {"点","は","部分","をもたないものである。","","","","","","","","0"},
        {"点","は","部分","をもたないものである。","","","","","","","","99"},
    };
    private string[,] tdi15 = new string[,]
   {
        {"定義di15","","","","","","","","","","","99"},
        {"円","とは","周と呼ばれる一つの線","の境界で囲まれた平面図形であって、","","","","","","","","0"},
        {"円","とは","周と呼ばれる一つの線","の境界で囲まれた平面図形であって、","","","","","","","","2"},
        {"その中にある一つの点","から","円周上の点","に","引かれた直線","の長さがすべて等しいようなものである。","","","","","","0"},
        {"その中にある一つの点","から","円周上の点","に","引かれた直線","の長さがすべて等しいようなものである。","","","","","","2"},
        {"その中にある一つの点","から","円周上の点","に","引かれた直線","の長さがすべて等しいようなものである。","","","","","","6"},
        {"その中にある一つの点","から","円周上の点","に","引かれた直線","の長さがすべて等しいようなものである。","","","","","","99"},
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
