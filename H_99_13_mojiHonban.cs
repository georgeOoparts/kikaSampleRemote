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
        {"AB", "と","C","を与えられた","長さが異なる二つの直線とし、","AB","の方が長いものとする。","","","","","0"},
        {"AB", "と","C","を与えられた","長さが異なる二つの直線とし、","AB","の方が長いものとする。","","","","","2"},
        {"AB", "と","C","を与えられた","長さが異なる二つの直線とし、","AB","の方が長いものとする。","","","","","5"},
        {"AB", "と","C","を与えられた","長さが異なる二つの直線とし、","AB","の方が長いものとする。","","","","","99"},

        {"このとき、", "AB","から","Cの長さ分","を切り取ることが求められている。","","","","","","","1"},
        {"このとき、", "AB","から","Cの長さ分","を切り取ることが求められている。","","","","","","","3"},
        {"このとき、", "AB","から","Cの長さ分","を切り取ることが求められている。","","","","","","","99"},

        {"AD", "を","C","と同じ長さの","A","から引かれた直線とする","[命題I-2]。","","","","","0"},
        {"AD", "を","C","と同じ長さの","A","から引かれた直線とする","[命題I-2]。","","","","","2"},
        {"AD", "を","C","と同じ長さの","A","から引かれた直線とする","[命題I-2]。","","","","","4"},
        {"AD", "を","C","と同じ長さの","A","から引かれた直線とする","[命題I-2]。","","","","","99"},

        {"そして、", "A","を中心とし","半径AD","の","円DEF","を描く","[公準P-3]。","","","","1"},
        {"そして、", "A","を中心とし","半径AD","の","円DEF","を描く","[公準P-3]。","","","","3"},
        {"そして、", "A","を中心とし","半径AD","の","円DEF","を描く","[公準P-3]。","","","","5"},
        {"そして、", "A","を中心とし","半径AD","の","円DEF","を描く","[公準P-3]。","","","","99"},

        {"A", "は","円DEF","の中心であるから、","AE","は","AD","と等しい","[定義I-15]。","","","0"},
        {"A", "は","円DEF","の中心であるから、","AE","は","AD","と等しい","[定義I-15]。","","","2"},
        {"A", "は","円DEF","の中心であるから、","AE","は","AD","と等しい","[定義I-15]。","","","4"},
        {"A", "は","円DEF","の中心であるから、","AE","は","AD","と等しい","[定義I-15]。","","","6"},
        {"A", "は","円DEF","の中心であるから、","AE","は","AD","と等しい","[定義I-15]。","","","99"},

        {"ここで", "C","は","AD","と等しいから、","AE","と","C","は共に","AD","と等しく、","1"},
        {"ここで", "C","は","AD","と等しいから、","AE","と","C","は共に","AD","と等しく、","3"},
        {"ここで", "C","は","AD","と等しいから、","AE","と","C","は共に","AD","と等しく、","5"},
        {"ここで", "C","は","AD","と等しいから、","AE","と","C","は共に","AD","と等しく、","7"},
        {"ここで", "C","は","AD","と等しいから、","AE","と","C","は共に","AD","と等しく、","9"},
        {"ここで", "C","は","AD","と等しいから、","AE","と","C","は共に","AD","と等しく、","99"},

        {"よって", "AE","は","C","と等しい","[公理A-1]。","","","","","","1"},
        {"よって", "AE","は","C","と等しい","[公理A-1]。","","","","","","3"},
        {"よって", "AE","は","C","と等しい","[公理A-1]。","","","","","","99"},

        {"ゆえに、与えられた", "二つの直線","AB","と","C","について、","AE","は短い方の","直線C","と等しく、","","3"},
        {"ゆえに、与えられた", "二つの直線","AB","と","C","について、","AE","は短い方の","直線C","と等しく、","","5"},
        {"ゆえに、与えられた", "二つの直線","AB","と","C","について、","AE","は短い方の","直線C","と等しく、","","7"},
        {"ゆえに、与えられた", "二つの直線","AB","と","C","について、","AE","は短い方の","直線C","と等しく、","","9"},
        {"ゆえに、与えられた", "二つの直線","AB","と","C","について、","AE","は短い方の","直線C","と等しく、","","11"},
        {"ゆえに、与えられた", "二つの直線","AB","と","C","について、","AE","は短い方の","直線C","と等しく、","","99"},

        {"長い方の", "直線AB","を切り取る。","これが求められていたことであった。","","","","","","","","1"},
        {"長い方の", "直線AB","を切り取る。","これが求められていたことであった。","","","","","","","","99"},
    };
    private string[,] m1_4 = new string[,]
    {
        {"命題I-4","","","","","","","","","","","99"},
        {"二つの三角形", "において、","二つの辺","がそれぞれ等しく、","","","","","","","","0"},
        {"二つの三角形", "において、","二つの辺","がそれぞれ等しく、","","","","","","","","2"},
        {"その二辺に挟まれる角", "も等しいならば、","","","","","","","","","","0"},
        {"底辺", "も等しく、","二つの三角形","は等しい。","","","","","","","","0"},
        {"底辺", "も等しく、","二つの三角形","は等しい。","","","","","","","","2"},
        {"そして、", "等しい二辺","に対する","残りの角","もそれぞれ等しい。","","","","","","","1"},
        {"そして、", "等しい二辺","に対する","残りの角","もそれぞれ等しい。","","","","","","","3"},

        {"二つの三角形", "ABC","と","DEF","において、","","","","","","","1"},
        {"二つの三角形", "ABC","と","DEF","において、","","","","","","","3"},
        
        {"二辺", "AB","と","AC","が二辺","DE","と","DF","にそれぞれ等しい、","","","1"},
        {"二辺", "AB","と","AC","が二辺","DE","と","DF","にそれぞれ等しい、","","","3"},
        {"二辺", "AB","と","AC","が二辺","DE","と","DF","にそれぞれ等しい、","","","5"},
        {"二辺", "AB","と","AC","が二辺","DE","と","DF","にそれぞれ等しい、","","","7"},
        
        {"すなわち、", "AB","と","DE","、","AC","と","DF","が等しいとし、","","","1"},
        {"すなわち、", "AB","と","DE","、","AC","と","DF","が等しいとし、","","","3"},
        {"すなわち、", "AB","と","DE","、","AC","と","DF","が等しいとし、","","","5"},
        {"すなわち、", "AB","と","DE","、","AC","と","DF","が等しいとし、","","","7"},

        {"そして", "角BAC","と","角EDF","が等しいものとする。","","","","","","","1"},
        {"そして", "角BAC","と","角EDF","が等しいものとする。","","","","","","","3"},

        {"このとき、", "底辺BC","と","底辺EF","が等しく、","","","","","","","1"},
        {"このとき、", "底辺BC","と","底辺EF","が等しく、","","","","","","","3"},

        {"角ABC", "と","角DEF","、","角ACB","と","角DFE","が等しいと主張する。","","","","0"},
        {"角ABC", "と","角DEF","、","角ACB","と","角DFE","が等しいと主張する。","","","","2"},
        {"角ABC", "と","角DEF","、","角ACB","と","角DFE","が等しいと主張する。","","","","4"},
        {"角ABC", "と","角DEF","、","角ACB","と","角DFE","が等しいと主張する。","","","","6"},

        {"三角形ABC", "を","三角形DEF","に重ね合わせ、","","","","","","","","0"},
        {"三角形ABC", "を","三角形DEF","に重ね合わせ、","","","","","","","","2"},

        {"点A", "は","点D","に、","直線AB","は","直線DE","と一致するようにする。","","","","0"},
        {"点A", "は","点D","に、","直線AB","は","直線DE","と一致するようにする。","","","","2"},
        {"点A", "は","点D","に、","直線AB","は","直線DE","と一致するようにする。","","","","4"},
        {"点A", "は","点D","に、","直線AB","は","直線DE","と一致するようにする。","","","","6"},

        {"このとき", "AB","と","DE","の長さが等しいことから","点B","は","点E","に一致する。","","","1"},
        {"このとき", "AB","と","DE","の長さが等しいことから","点B","は","点E","に一致する。","","","3"},
        {"このとき", "AB","と","DE","の長さが等しいことから","点B","は","点E","に一致する。","","","5"},
        {"このとき", "AB","と","DE","の長さが等しいことから","点B","は","点E","に一致する。","","","7"},

        {"AB", "と","DE","が一致していることと","角BAC","が","EDF","に等しいことから、","","","","0"},
        {"AB", "と","DE","が一致していることと","角BAC","が","EDF","に等しいことから、","","","","2"},
        {"AB", "と","DE","が一致していることと","角BAC","が","EDF","に等しいことから、","","","","4"},
        {"AB", "と","DE","が一致していることと","角BAC","が","EDF","に等しいことから、","","","","6"},

        {"直線AC", "と","DF","も一致する。","","","","","","","","0"},
        {"直線AC", "と","DF","も一致する。","","","","","","","","2"},

        {"したがって、", "点C","と","点F","は一致する。","","","","","","","1"},
        {"したがって、", "点C","と","点F","は一致する。","","","","","","","3"},
      
        {"点B", "は","点E","と一致しているから","底辺BC","は","底辺EF","と一致する。","","","","0"},
        {"点B", "は","点E","と一致しているから","底辺BC","は","底辺EF","と一致する。","","","","2"},
        {"点B", "は","点E","と一致しているから","底辺BC","は","底辺EF","と一致する。","","","","4"},
        {"点B", "は","点E","と一致しているから","底辺BC","は","底辺EF","と一致する。","","","","6"},


        {"なぜならば、", "もし一致しないとすれば","同じ点を結ぶ直線は","唯一つであることに","反するからである","[公準P-1]。","","","","","","99"},
        
        {"したがって、", "底辺BC","と","底辺EF","は一致し、互いに等しい","[公理A-4]。","","","","","","1"},
        {"したがって、", "底辺BC","と","底辺EF","は一致し、互いに等しい","[公理A-4]。","","","","","","3"},

        {"したがって、", "三角形ABC","は","三角形DEF","と完全に一致し、","互いに等しい","[公理A-4]","","","","","1"},
        {"したがって、", "三角形ABC","は","三角形DEF","と完全に一致し、","互いに等しい","[公理A-4]","","","","","3"},

        {"残りの角", "もそれぞれ一致し、","互いに等しい","[公理A-4]","","","","","","","","1"},

        {"つまり、", "ABC","と","DEF","、","ACB","と","DFE","は等しい","[公理A-4]","","1"},
        {"つまり、", "ABC","と","DEF","、","ACB","と","DFE","は等しい","[公理A-4]","","3"},
        {"つまり、", "ABC","と","DEF","、","ACB","と","DFE","は等しい","[公理A-4]","","5"},
        {"つまり、", "ABC","と","DEF","、","ACB","と","DFE","は等しい","[公理A-4]","","7"},

        {"ゆえに、", "二つの三角形","において、","二つの辺","がそれぞれ等しく、","","","","","","","1"},
        {"ゆえに、", "二つの三角形","において、","二つの辺","がそれぞれ等しく、","","","","","","","3"},

        {"その", "二辺に挟まれる角","も等しいならば、","底辺","も等しく、","二つの三角形","は等しい。","","","","","1"},
        {"その", "二辺に挟まれる角","も等しいならば、","底辺","も等しく、","二つの三角形","は等しい。","","","","","3"},
        {"その", "二辺に挟まれる角","も等しいならば、","底辺","も等しく、","二つの三角形","は等しい。","","","","","5"},

        {"そして、等しい二辺に対する", "残りの角","もそれぞれ等しい。","これが証明すべきことであった。","","","","","","","","1"},
        {"そして、等しい二辺に対する", "残りの角","もそれぞれ等しい。","これが証明すべきことであった。","","","","","","","","99"},
        {"", "","","","","","","","","","","99"},
        {"", "","","","","","","","","","","99"},

    };
    private string[,] m1_5 = new string[,]
    {
        {"命題I-5","","","","","","","","","","","99"},
        {"二等辺三角形", "の","底辺上","の","二つの角","は互いに等しい","","","","","","0"},
        {"二等辺三角形", "の","底辺上","の","二つの角","は互いに等しい","","","","","","2"},
        {"二等辺三角形", "の","底辺上","の","二つの角","は互いに等しい","","","","","","4"},

        {"そして、", "等辺","を延長してできる","底辺下の","二つの角","も互いに等しい。","","","","","","1"},
        {"そして、", "等辺","を延長してできる","底辺下の","二つの角","も互いに等しい。","","","","","","4"},

        {"ABC", "を","辺AB","と","辺AC","が等しい","二等辺三角形","とし、","","","","0"},
        {"ABC", "を","辺AB","と","辺AC","が等しい","二等辺三角形","とし、","","","","2"},
        {"ABC", "を","辺AB","と","辺AC","が等しい","二等辺三角形","とし、","","","","4"},
        {"ABC", "を","辺AB","と","辺AC","が等しい","二等辺三角形","とし、","","","","6"},

        {"BD", "と","CE","を","AB","と","AC","をそれぞれ","延長した","直線とする","[公準P-2]","0"},
        {"BD", "と","CE","を","AB","と","AC","をそれぞれ","延長した","直線とする","[公準P-2]","2"},
        {"BD", "と","CE","を","AB","と","AC","をそれぞれ","延長した","直線とする","[公準P-2]","4"},
        {"BD", "と","CE","を","AB","と","AC","をそれぞれ","延長した","直線とする","[公準P-2]","6"},

        {"このとき、", "角ABC","と","ACB","、","角CBD","と","BCE","が等しいと主張する。","","","1"},
        {"このとき、", "角ABC","と","ACB","、","角CBD","と","BCE","が等しいと主張する。","","","3"},
        {"このとき、", "角ABC","と","ACB","、","角CBD","と","BCE","が等しいと主張する。","","","5"},
        {"このとき、", "角ABC","と","ACB","、","角CBD","と","BCE","が等しいと主張する。","","","7"},

        {"点F", "を","BD","上にとり、","AG","を","AE","から","AF分","切り取ったとする","[命題I-3]","1"},
        {"点F", "を","BD","上にとり、","AG","を","AE","から","AF分","切り取ったとする","[命題I-3]","3"},
        {"点F", "を","BD","上にとり、","AG","を","AE","から","AF分","切り取ったとする","[命題I-3]","5"},
        {"点F", "を","BD","上にとり、","AG","を","AE","から","AF分","切り取ったとする","[命題I-3]","7"},
        {"点F", "を","BD","上にとり、","AG","を","AE","から","AF分","切り取ったとする","[命題I-3]","9"},

        {"そして、", "直線FC","と","GB","を描く","[公準P-1]","","","","","","1"},
        {"そして、", "直線FC","と","GB","を描く","[公準P-1]","","","","","","3"},

        {"AF", "と","AG","、","AB","と","AC","は等しいから、","","","","0"},
        {"AF", "と","AG","、","AB","と","AC","は等しいから、","","","","2"},
        {"AF", "と","AG","、","AB","と","AC","は等しいから、","","","","4"},
        {"AF", "と","AG","、","AB","と","AC","は等しいから、","","","","6"},

        {"FA", "、","AC","はそれぞれ","GA","、","AB","と等しく、","","","","0"},
        {"FA", "、","AC","はそれぞれ","GA","、","AB","と等しく、","","","","2"},
        {"FA", "、","AC","はそれぞれ","GA","、","AB","と等しく、","","","","4"},
        {"FA", "、","AC","はそれぞれ","GA","、","AB","と等しく、","","","","6"},

        {"その挟む", "角FAG","を共有するから、","底辺FC","と","底辺GB","は等しく、","三角形AFC","と","三角形AGB","は等しい。","1"},
        {"その挟む", "角FAG","を共有するから、","底辺FC","と","底辺GB","は等しく、","三角形AFC","と","三角形AGB","は等しい。","3"},
        {"その挟む", "角FAG","を共有するから、","底辺FC","と","底辺GB","は等しく、","三角形AFC","と","三角形AGB","は等しい。","5"},
        {"その挟む", "角FAG","を共有するから、","底辺FC","と","底辺GB","は等しく、","三角形AFC","と","三角形AGB","は等しい。","7"},
        {"その挟む", "角FAG","を共有するから、","底辺FC","と","底辺GB","は等しく、","三角形AFC","と","三角形AGB","は等しい。","9"},

        {"さらに", "等辺","に対する","残りの角","もそれぞれ等しい","[命題I-4]","","","","","","3"},

        {"すなわち、", "ACF","と","ABG","、","AFC","と","AGB","は等しい。","","","1"},
        {"すなわち、", "ACF","と","ABG","、","AFC","と","AGB","は等しい。","","","3"},
        {"すなわち、", "ACF","と","ABG","、","AFC","と","AGB","は等しい。","","","5"},
        {"すなわち、", "ACF","と","ABG","、","AFC","と","AGB","は等しい。","","","7"},

        {"AF", "と","AG","は等しいから、","","","","","","","","0"},
        {"AF", "と","AG","は等しいから、","","","","","","","","2"},

        {"そこから相等しい", "AB","と","AC","を引いた差の","BF","と","CG","は等しい","[公理A-3]","","1"},
        {"そこから相等しい", "AB","と","AC","を引いた差の","BF","と","CG","は等しい","[公理A-3]","","3"},
        {"そこから相等しい", "AB","と","AC","を引いた差の","BF","と","CG","は等しい","[公理A-3]","","5"},
        {"そこから相等しい", "AB","と","AC","を引いた差の","BF","と","CG","は等しい","[公理A-3]","","7"},

        {"FC", "と","GB","は等しいから、","","","","","","","","99"},
        {"FC", "と","GB","は等しいから、","","","","","","","","0"},
        {"FC", "と","GB","は等しいから、","","","","","","","","2"},


        {"BF", "、","FC","と","CG","、","GB","がそれぞれ等しく、","","","","0"},
        {"BF", "、","FC","と","CG","、","GB","がそれぞれ等しく、","","","","2"},
        {"BF", "、","FC","と","CG","、","GB","がそれぞれ等しく、","","","","4"},
        {"BF", "、","FC","と","CG","、","GB","がそれぞれ等しく、","","","","6"},

        {"角BFC", "と","CGB","が等しく、","","","","","","","","0"},
        {"角BFC", "と","CGB","が等しく、","","","","","","","","2"},


        {"底辺BC", "が共有されている。","したがって、","三角形BFC","と","三角形CGB","は等しく、","","","","","0"},
        {"底辺BC", "が共有されている。","したがって、","三角形BFC","と","三角形CGB","は等しく、","","","","","3"},
        {"底辺BC", "が共有されている。","したがって、","三角形BFC","と","三角形CGB","は等しく、","","","","","5"},

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
