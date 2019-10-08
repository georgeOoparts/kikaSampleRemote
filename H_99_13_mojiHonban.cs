using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class H_99_13_mojiHonban : MonoBehaviour {
    //atama
    //{"", "","","","","","","","","","","","","","","","99","99","99"},

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
        for (int i = 0; i < 16; i++) 
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

    //強調する文字が配列の何番目かを入れる変数（強調できる文字数２つ）
    //99は何も文字を強調しないという整数
    private int kyouchouHenkanInt1=99;
    private int kyouchouHenkanInt2=99;
    private int kyouchouHenkanInt3 = 99;

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
                else if (kyotu.MCount == 2) {
                    if (kyotu.rrCount < m1_3.GetLength(0) - 1) {
                        kyotu.rrCount++;
                    }
                } 
                else if (kyotu.MCount == 3) {
                    if (kyotu.rrCount < m1_4.GetLength(0) - 1) {
                        kyotu.rrCount++;
                    }
                } 
                else if (kyotu.MCount == 4) {
                    if (kyotu.rrCount < m1_5.GetLength(0) - 1) {
                        kyotu.rrCount++;
                    }
                } 
                else if (kyotu.MCount == 5) {
                    if (kyotu.rrCount < m1_6.GetLength(0) - 1) {
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
                } 
                else if (kyotu.MCount == 1) {
                    if (kyotu.rrCount < m1_2.GetLength(0)) {
                        //mojipanelの各UItextに文字を代入していく
                        kodomoTextText[i].text = kariList[kyotu.rrCount][i];//eeee
                    } else {
                        //最終行を出力し続ける:mojipanelの各UItextに文字を代入していく
                        kodomoTextText[i].text = kariList[m1_2.GetLength(0) - 1][i];
                    }
                } 
                else if (kyotu.MCount == 2) {
                    if (kyotu.rrCount < m1_3.GetLength(0)) {
                        //mojipanelの各UItextに文字を代入していく
                        kodomoTextText[i].text = kariList[kyotu.rrCount][i];//eeee
                    } else {
                        //最終行を出力し続ける:mojipanelの各UItextに文字を代入していく
                        kodomoTextText[i].text = kariList[m1_3.GetLength(0) - 1][i];
                    }
                } 
                else if (kyotu.MCount == 3) {
                    if (kyotu.rrCount < m1_4.GetLength(0)) {
                        //mojipanelの各UItextに文字を代入していく
                        kodomoTextText[i].text = kariList[kyotu.rrCount][i];//eeee
                    } else {
                        //最終行を出力し続ける:mojipanelの各UItextに文字を代入していく
                        kodomoTextText[i].text = kariList[m1_4.GetLength(0) - 1][i];
                    }
                } 
                else if (kyotu.MCount == 4) {
                    if (kyotu.rrCount < m1_5.GetLength(0)) {
                        //mojipanelの各UItextに文字を代入していく
                        kodomoTextText[i].text = kariList[kyotu.rrCount][i];//eeee
                    } else {
                        //最終行を出力し続ける:mojipanelの各UItextに文字を代入していく
                        kodomoTextText[i].text = kariList[m1_5.GetLength(0) - 1][i];
                    }
                } 
                else if (kyotu.MCount == 5) {
                    if (kyotu.rrCount < m1_6.GetLength(0)) {
                        //mojipanelの各UItextに文字を代入していく
                        kodomoTextText[i].text = kariList[kyotu.rrCount][i];//eeee
                    } else {
                        //最終行を出力し続ける:mojipanelの各UItextに文字を代入していく
                        kodomoTextText[i].text = kariList[m1_6.GetLength(0) - 1][i];
                    }
                }
            }
            
        }
        //文章増えるたびに変更
        //文字が入った配列の情報から、強調すべき文字の順番をintで得る
        //強調できる文字数２つ
        //ka1.GetLength(1) - 2　１つめ
        //ka1.GetLength(1) - 1　2つめ
        //公理:0,公準:1,定義:2,meidai:3
        if (kyotu.mojiSwitch == 0)//kouri
        {
            //k10_2:strin>int変換
            if (kyotu.MCount == 0) {
                if (kyotu.rrCount < ka1.GetLength(0))
                    kyouchouHenkanInt1 = int.Parse(ka1[kyotu.rrCount, ka1.GetLength(1) - 1]);
                    kyouchouHenkanInt2 = int.Parse(ka1[kyotu.rrCount, ka1.GetLength(1) - 2]);
                    kyouchouHenkanInt3 = int.Parse(ka1[kyotu.rrCount, ka1.GetLength(1) - 3]);
            }
            else if (kyotu.MCount == 1) {
                if (kyotu.rrCount < ka3.GetLength(0))
                    kyouchouHenkanInt1 = int.Parse(ka3[kyotu.rrCount, ka3.GetLength(1) - 1]);
                    kyouchouHenkanInt2 = int.Parse(ka3[kyotu.rrCount, ka3.GetLength(1) - 2]);
                    kyouchouHenkanInt3 = int.Parse(ka3[kyotu.rrCount, ka3.GetLength(1) - 3]);

            } else if (kyotu.MCount == 2) {
                if (kyotu.rrCount < ka4.GetLength(0))
                    kyouchouHenkanInt1 = int.Parse(ka4[kyotu.rrCount, ka4.GetLength(1) - 1]);
                    kyouchouHenkanInt2 = int.Parse(ka4[kyotu.rrCount, ka4.GetLength(1) - 2]);
                    kyouchouHenkanInt3 = int.Parse(ka4[kyotu.rrCount, ka4.GetLength(1) - 3]);

            } else if (kyotu.MCount == 3) {
                if (kyotu.rrCount < ka5.GetLength(0))
                    kyouchouHenkanInt1 = int.Parse(ka5[kyotu.rrCount, ka5.GetLength(1) - 1]);
                    kyouchouHenkanInt2 = int.Parse(ka5[kyotu.rrCount, ka5.GetLength(1) - 2]);
                    kyouchouHenkanInt3 = int.Parse(ka5[kyotu.rrCount, ka5.GetLength(1) - 3]);

            }
        }
        else if (kyotu.mojiSwitch == 1)//koujun
        {
            //k10_2:strin>int変換
            if (kyotu.MCount == 0) {
                if (kyotu.rrCount < kjp1.GetLength(0))
                    kyouchouHenkanInt1 = int.Parse(kjp1[kyotu.rrCount, kjp1.GetLength(1) - 1]);
                    kyouchouHenkanInt2 = int.Parse(kjp1[kyotu.rrCount, kjp1.GetLength(1) - 2]);
                    kyouchouHenkanInt3 = int.Parse(kjp1[kyotu.rrCount, kjp1.GetLength(1) - 3]);

            } else if (kyotu.MCount == 1) {
                if (kyotu.rrCount < kjp2.GetLength(0))
                    kyouchouHenkanInt1 = int.Parse(kjp2[kyotu.rrCount, kjp2.GetLength(1) - 1]);
                    kyouchouHenkanInt2 = int.Parse(kjp2[kyotu.rrCount, kjp2.GetLength(1) - 2]);
                    kyouchouHenkanInt3 = int.Parse(kjp2[kyotu.rrCount, kjp2.GetLength(1) - 3]);

            } else if (kyotu.MCount == 2) {
                if (kyotu.rrCount < kjp3.GetLength(0))
                    kyouchouHenkanInt1 = int.Parse(kjp3[kyotu.rrCount, kjp3.GetLength(1) - 1]);
                    kyouchouHenkanInt2 = int.Parse(kjp3[kyotu.rrCount, kjp3.GetLength(1) - 2]);
                    kyouchouHenkanInt3 = int.Parse(kjp3[kyotu.rrCount, kjp3.GetLength(1) - 3]);

            }
        } 
        else if (kyotu.mojiSwitch == 2)//teigi
        {
            //k10_2:strin>int変換
            if (kyotu.MCount == 0) {
                if (kyotu.rrCount < tdi1.GetLength(0))
                    kyouchouHenkanInt1 = int.Parse(tdi1[kyotu.rrCount, tdi1.GetLength(1) - 1]);
                    kyouchouHenkanInt2 = int.Parse(tdi1[kyotu.rrCount, tdi1.GetLength(1) - 2]);
                    kyouchouHenkanInt3 = int.Parse(tdi1[kyotu.rrCount, tdi1.GetLength(1) - 3]);

            } else if (kyotu.MCount == 1) {
                if (kyotu.rrCount < tdi15.GetLength(0))
                    kyouchouHenkanInt1 = int.Parse(tdi15[kyotu.rrCount, tdi15.GetLength(1) - 1]);
                    kyouchouHenkanInt2 = int.Parse(tdi15[kyotu.rrCount, tdi15.GetLength(1) - 2]);
                    kyouchouHenkanInt3 = int.Parse(tdi15[kyotu.rrCount, tdi15.GetLength(1) - 3]);


            }
        } 
        else if (kyotu.mojiSwitch == 3)//meidai 
        {
            //k10_2:strin>int変換
            if (kyotu.MCount == 0) {
                if (kyotu.rrCount < m1_1.GetLength(0))
                    //強調する配列番号１、最後の番号から1つ手前である
                    kyouchouHenkanInt1 = int.Parse(m1_1[kyotu.rrCount, m1_1.GetLength(1) - 1]);
                    //強調する配列番号２、最後の番号である
                    kyouchouHenkanInt2 = int.Parse(m1_1[kyotu.rrCount, m1_1.GetLength(1) - 2]);
                    kyouchouHenkanInt3 = int.Parse(m1_1[kyotu.rrCount, m1_1.GetLength(1) - 3]);

            } else if (kyotu.MCount == 1) {
                if (kyotu.rrCount < m1_2.GetLength(0))
                    kyouchouHenkanInt1 = int.Parse(m1_2[kyotu.rrCount, m1_2.GetLength(1) - 1]);///bug
                    kyouchouHenkanInt2 = int.Parse(m1_2[kyotu.rrCount, m1_2.GetLength(1) - 2]);
                    kyouchouHenkanInt3 = int.Parse(m1_2[kyotu.rrCount, m1_2.GetLength(1) - 3]);

            } else if (kyotu.MCount == 2) {
                if (kyotu.rrCount < m1_3.GetLength(0))
                    kyouchouHenkanInt1 = int.Parse(m1_3[kyotu.rrCount, m1_3.GetLength(1) - 1]);
                    kyouchouHenkanInt2 = int.Parse(m1_3[kyotu.rrCount, m1_3.GetLength(1) - 2]);
                    kyouchouHenkanInt3 = int.Parse(m1_2[kyotu.rrCount, m1_2.GetLength(1) - 3]);

            } else if (kyotu.MCount == 3) {
                if (kyotu.rrCount < m1_4.GetLength(0))
                    kyouchouHenkanInt1 = int.Parse(m1_4[kyotu.rrCount, m1_4.GetLength(1) - 1]);
                    kyouchouHenkanInt2 = int.Parse(m1_4[kyotu.rrCount, m1_4.GetLength(1) - 2]);
                    kyouchouHenkanInt3 = int.Parse(m1_4[kyotu.rrCount, m1_4.GetLength(1) - 3]);

            } else if (kyotu.MCount == 4) {
                if (kyotu.rrCount < m1_5.GetLength(0))
                    kyouchouHenkanInt1 = int.Parse(m1_5[kyotu.rrCount, m1_5.GetLength(1) - 1]);
                    kyouchouHenkanInt2 = int.Parse(m1_5[kyotu.rrCount, m1_5.GetLength(1) - 2]);
                    kyouchouHenkanInt3 = int.Parse(m1_5[kyotu.rrCount, m1_5.GetLength(1) - 3]);

            } else if (kyotu.MCount == 5) {
                if (kyotu.rrCount < m1_6.GetLength(0))
                    kyouchouHenkanInt1 = int.Parse(m1_6[kyotu.rrCount, m1_6.GetLength(1) - 1]);
                    kyouchouHenkanInt2 = int.Parse(m1_6[kyotu.rrCount, m1_6.GetLength(1) - 2]);
                    kyouchouHenkanInt3 = int.Parse(m1_6[kyotu.rrCount, m1_6.GetLength(1) - 3]);

            }

        }

        


        //てきすとの強調kyochouPanel(kyouchouHenkanInt);でどこも強調しない数値99
        //kyouchouHenkanInt = 99;

        //強調すべきパネルを強調するメソッド
        kyochouPanel(kyouchouHenkanInt1, kyouchouHenkanInt2, kyouchouHenkanInt3);///

        //Debug.Log("MS::" + kyotu.mojiSwitch + "::MC::" + kyotu.MCount + "::RRC::" + kyotu.rrCount);

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
            //配列後ろから2つが強調文字につかわれるので
            //if (kyotu.rrCount < ka1.GetLength(0)-1)となる
            //公理:0,公準:1,定義:2,meidai:3
            if (kyotu.mojiSwitch == 0)//kouri
            {
                if (kyotu.MCount == 0) {
                    if (kyotu.rrCount < ka1.GetLength(0)-1) {
                        //mojipanelの各UItextに文字を代入していく
                        kodomoTextText[i].text = "";
                    }
                }
                else if (kyotu.MCount == 1) {
                    if (kyotu.rrCount < ka3.GetLength(0)-1) {
                        //mojipanelの各UItextに文字を代入していく
                        kodomoTextText[i].text = "";
                    }
                } 
                else if (kyotu.MCount == 2) {
                    if (kyotu.rrCount < ka4.GetLength(0)-1) {
                        //mojipanelの各UItextに文字を代入していく
                        kodomoTextText[i].text = "";
                    }
                } 
                else if (kyotu.MCount == 3) {
                    if (kyotu.rrCount < ka5.GetLength(0)-1) {
                        //mojipanelの各UItextに文字を代入していく
                        kodomoTextText[i].text = "";
                    }
                }
            }
            else if (kyotu.mojiSwitch == 1)//koujun
            {
                if (kyotu.MCount == 0) {
                    if (kyotu.rrCount < kjp1.GetLength(0)-1) {
                        //mojipanelの各UItextに文字を代入していく
                        kodomoTextText[i].text = "";
                    }
                } else if (kyotu.MCount == 1) {
                    if (kyotu.rrCount < kjp2.GetLength(0)-1) {
                        //mojipanelの各UItextに文字を代入していく
                        kodomoTextText[i].text = "";
                    }
                } else if (kyotu.MCount == 2) {
                    if (kyotu.rrCount < kjp3.GetLength(0)-1) {
                        //mojipanelの各UItextに文字を代入していく
                        kodomoTextText[i].text = "";
                    }
                } 
            } 
            else if (kyotu.mojiSwitch == 2)//teigi
            {
                if (kyotu.MCount == 0) {
                    if (kyotu.rrCount < tdi1.GetLength(0)-1) {
                        //mojipanelの各UItextに文字を代入していく
                        kodomoTextText[i].text = "";
                    }
                } else if (kyotu.MCount == 1) {
                    if (kyotu.rrCount < tdi15.GetLength(0) - 1) {
                        //mojipanelの各UItextに文字を代入していく
                        kodomoTextText[i].text = "";
                    }
                }
            } 
            else if (kyotu.mojiSwitch == 3)//meidai
            {
                if (kyotu.MCount == 0) {
                    if (kyotu.rrCount < m1_1.GetLength(0)-1) {
                        //mojipanelの各UItextに文字を代入していく
                        kodomoTextText[i].text = "";
                    }
                } else if (kyotu.MCount == 1) {
                    if (kyotu.rrCount < m1_2.GetLength(0) - 1) {
                        //mojipanelの各UItextに文字を代入していく
                        kodomoTextText[i].text = "";//eeee
                    }
                } 
                else if (kyotu.MCount == 2) {
                    if (kyotu.rrCount < m1_3.GetLength(0) - 1) {
                        //mojipanelの各UItextに文字を代入していく
                        kodomoTextText[i].text = "";//eeee
                    }
                } 
                else if (kyotu.MCount == 3) {
                    if (kyotu.rrCount < m1_4.GetLength(0) - 1) {
                        //mojipanelの各UItextに文字を代入していく
                        kodomoTextText[i].text = "";//eeee
                    }
                } 
                else if (kyotu.MCount == 4) {
                    if (kyotu.rrCount < m1_5.GetLength(0) - 1) {
                        //mojipanelの各UItextに文字を代入していく
                        kodomoTextText[i].text = "";//eeee
                    }
                } 
                else if (kyotu.MCount == 5) {
                    if (kyotu.rrCount < m1_6.GetLength(0) - 1) {
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
                    // ka1.GetLength(1)-1 注意　後ろ2つは文字強調
                    for (int j = 0; j < ka1.GetLength(1)-1; j++) {
                        kariList[i].Add(ka1[i, j]);
                    }
                }
            }
            else if (kyotu.MCount == 1) {
                for (int i = 0; i < ka3.GetLength(0); i++) {
                    //k0016_99_2_1_1：2次元list [0][],[1][]をつくる
                    kariList.Add(new List<string>());

                    for (int j = 0; j < ka3.GetLength(1) - 1; j++) {
                        kariList[i].Add(ka3[i, j]);
                    }
                }
            } 
            else if (kyotu.MCount == 2) {
                for (int i = 0; i < ka4.GetLength(0); i++) {
                    //k0016_99_2_1_1：2次元list [0][],[1][]をつくる
                    kariList.Add(new List<string>());

                    for (int j = 0; j < ka4.GetLength(1) - 1; j++) {
                        kariList[i].Add(ka4[i, j]);
                    }
                }
            } 
            else if (kyotu.MCount == 3) {
                for (int i = 0; i < ka5.GetLength(0); i++) {
                    //k0016_99_2_1_1：2次元list [0][],[1][]をつくる
                    kariList.Add(new List<string>());

                    for (int j = 0; j < ka5.GetLength(1) - 1; j++) {
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

                    for (int j = 0; j < kjp1.GetLength(1) - 1; j++) {
                        kariList[i].Add(kjp1[i, j]);
                    }
                }
            } else if (kyotu.MCount == 1) {
                for (int i = 0; i < kjp2.GetLength(0); i++) {
                    //k0016_99_2_1_1：2次元list [0][],[1][]をつくる
                    kariList.Add(new List<string>());

                    for (int j = 0; j < kjp2.GetLength(1) - 1; j++) {
                        kariList[i].Add(kjp2[i, j]);
                    }
                }
            } else if (kyotu.MCount == 2) {
                for (int i = 0; i < kjp3.GetLength(0); i++) {
                    //k0016_99_2_1_1：2次元list [0][],[1][]をつくる
                    kariList.Add(new List<string>());

                    for (int j = 0; j < kjp3.GetLength(1) - 1; j++) {
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

                    for (int j = 0; j < tdi1.GetLength(1) - 1; j++) {
                        kariList[i].Add(tdi1[i, j]);
                    }
                }
            } else if (kyotu.MCount == 1) {
                for (int i = 0; i < tdi15.GetLength(0); i++) {
                    //k0016_99_2_1_1：2次元list [0][],[1][]をつくる
                    kariList.Add(new List<string>());

                    for (int j = 0; j < tdi15.GetLength(1) - 1; j++) {
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

                    for (int j = 0; j < m1_1.GetLength(1) - 1; j++) {
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

                    for (int j = 0; j < m1_2.GetLength(1) - 1; j++) {
                        kariList[i].Add(m1_2[i, j]);
                    }
                }
            }
            //meidai3に対応
            else if (kyotu.MCount == 2) {
                for (int i = 0; i < m1_3.GetLength(0); i++) {
                    //k0016_99_2_1_1：2次元list [0][],[1][]をつくる
                    kariList.Add(new List<string>());

                    for (int j = 0; j < m1_3.GetLength(1) - 1; j++) {
                        kariList[i].Add(m1_3[i, j]);
                    }
                }
            }
            //meidai4に対応
            else if (kyotu.MCount == 3) {
                for (int i = 0; i < m1_4.GetLength(0); i++) {
                    //k0016_99_2_1_1：2次元list [0][],[1][]をつくる
                    kariList.Add(new List<string>());

                    for (int j = 0; j < m1_4.GetLength(1) - 1; j++) {
                        kariList[i].Add(m1_4[i, j]);
                    }
                }
            }
            //meidai4に対応
            else if (kyotu.MCount == 4) {
                for (int i = 0; i < m1_5.GetLength(0); i++) {
                    //k0016_99_2_1_1：2次元list [0][],[1][]をつくる
                    kariList.Add(new List<string>());

                    for (int j = 0; j < m1_5.GetLength(1) - 1; j++) {
                        kariList[i].Add(m1_5[i, j]);
                    }
                }
            }
            //meidai4に対応
            else if (kyotu.MCount == 5) {
                for (int i = 0; i < m1_6.GetLength(0); i++) {
                    //k0016_99_2_1_1：2次元list [0][],[1][]をつくる
                    kariList.Add(new List<string>());

                    for (int j = 0; j < m1_6.GetLength(1) - 1; j++) {
                        kariList[i].Add(m1_6[i, j]);
                    }
                }
            }
        }
        //文章増えるたびに変更、ここまで
    }
    //Uitextの中身----------------------------------------------------------------------------------------------------
    //文章増えるたびに変更
    //3次元配列
    private string[,] m1_1 =new string[,]//m1_1w
    {
        
        {"命題I-1","","","","","","","","","","","","","","","","99","99","99"},
    　  {"与えられた直線", "を","一辺","とする","正三角形","を作図する事。","","","","","","","","","","","0","99","99"},
        {"与えられた直線", "を","一辺","とする","正三角形","を作図する事。","","","","","","","","","","","2","99","99"},
        {"与えられた直線", "を","一辺","とする","正三角形","を作図する事。","","","","","","","","","","","4","99","99"},
        {"与えられた直線", "を","一辺","とする","正三角形","を作図する事。","","","","","","","","","","","99","99","99"},
        {"AB","を与えられた","直線","とする。","","","","","","","","","","","","","0","99","99"},
        {"AB","を与えられた","直線","とする。","","","","","","","","","","","","","99","99","99"},
        {"このとき、", "AB","を一辺とする","正三角形","を作図することが","求められている。","","","","","","","","","","","1","99","99"},
        {"このとき、", "AB","を一辺とする","正三角形","を作図することが","求められている。","","","","","","","","","","","3","99","99"},
        {"このとき、", "AB","を一辺とする","正三角形","を作図することが","求められている。","","","","","","","","","","","99","99","99"},
        {"A", "を中心とし、","AB","を半径とする円","BCD","を描く[公準P-3]","","","","","","","","","","","0","99","99"},
        {"A", "を中心とし、","AB","を半径とする円","BCD","を描く[公準P-3]","","","","","","","","","","","2","99","99"},
        {"A", "を中心とし、","AB","を半径とする円","BCD","を描く[公準P-3]","","","","","","","","","","","4","99","99"},
        //↓本文        
        {"A", "を中心とし、","AB","を半径とする円","BCD","を描く[公準P-3]","","","","","","","","","","","99","99","99"},
        {"BA", "を半径とする円","ACE","を描く[公準P-3]。","","","","","","","","","","","","","0","99","99"},
        {"BA", "を半径とする円","ACE","を描く[公準P-3]。","","","","","","","","","","","","","2","99","99"},
        {"BA", "を半径とする円","ACE","を描く[公準P-3]。","","","","","","","","","","","","","99","99","99"},
        {"そして二つの円の交点", "C","と","A","と","B","を結ぶ直線","CA","と","CB","を描く[公準P-1]。","","","","","","1","99","99"},
        {"そして二つの円の交点", "C","と","A","と","B","を結ぶ直線","CA","と","CB","を描く[公準P-1]。","","","","","","3","99","99"},
        {"そして二つの円の交点", "C","と","A","と","B","を結ぶ直線","CA","と","CB","を描く[公準P-1]。","","","","","","5","99","99"},
        {"そして二つの円の交点", "C","と","A","と","B","を結ぶ直線","CA","と","CB","を描く[公準P-1]。","","","","","","7","99","99"},
        {"そして二つの円の交点", "C","と","A","と","B","を結ぶ直線","CA","と","CB","を描く[公準P-1]。","","","","","","9","99","99"},
        {"そして二つの円の交点", "C","と","A","と","B","を結ぶ直線","CA","と","CB","を描く[公準P-1]。","","","","","","99","99","99"},
        {"点", "A","は円","CDB","の中心であるから、","AC","は","AB","と等しい","[定義DI-15]。","","","","","","","1","99","99"},
        {"点", "A","は円","CDB","の中心であるから、","AC","は","AB","と等しい","[定義DI-15]。","","","","","","","3","99","99"},
        {"点", "A","は円","CDB","の中心であるから、","AC","は","AB","と等しい","[定義DI-15]。","","","","","","","5","99","99"},
        {"点", "A","は円","CDB","の中心であるから、","AC","は","AB","と等しい","[定義DI-15]。","","","","","","","7","99","99"},
        {"点", "A","は円","CDB","の中心であるから、","AC","は","AB","と等しい","[定義DI-15]。","","","","","","","99","99","99"},
        {"また点", "B","は円","CAE","の中心であるから、","BC","と","BA","は等しい","[定義DI-15]。","","","","","","","1","99","99"},
        {"また点", "B","は円","CAE","の中心であるから、","BC","と","BA","は等しい","[定義DI-15]。","","","","","","","3","99","99"},
        {"また点", "B","は円","CAE","の中心であるから、","BC","と","BA","は等しい","[定義DI-15]。","","","","","","","5","99","99"},
        {"また点", "B","は円","CAE","の中心であるから、","BC","と","BA","は等しい","[定義DI-15]。","","","","","","","7","99","99"},
        {"また点", "B","は円","CAE","の中心であるから、","BC","と","BA","は等しい","[定義DI-15]。","","","","","","","99","99","99"},
        {"CA", "は","AB","と等しかったから、","CA","と","CB","は共に","AB","と等しい。","","","","","","","0","99","99"},
        {"CA", "は","AB","と等しかったから、","CA","と","CB","は共に","AB","と等しい。","","","","","","","2","99","99"},
        {"CA", "は","AB","と等しかったから、","CA","と","CB","は共に","AB","と等しい。","","","","","","","4","99","99"},
        {"CA", "は","AB","と等しかったから、","CA","と","CB","は共に","AB","と等しい。","","","","","","","6","99","99"},
        {"CA", "は","AB","と等しかったから、","CA","と","CB","は共に","AB","と等しい。","","","","","","","8","99","99"},
        {"CA", "は","AB","と等しかったから、","CA","と","CB","は共に","AB","と等しい。","","","","","","","99","99","99"},
        {"同じもの", "に","等しいもの","は互いに等しかったから","[公理A-1]","","","","","","","","","","","","0","99","99"},
        {"同じもの", "に","等しいもの","は互いに等しかったから","[公理A-1]","","","","","","","","","","","","2","99","99"},
        {"同じもの", "に","等しいもの","は互いに等しかったから","[公理A-1]","","","","","","","","","","","","99","99","99"},
        {"CA", "は","CB","に等しく、","CA","、","AB","、","BC","の三辺はすべて","互いに等しい。","","","","","","0","99","99"},
        {"CA", "は","CB","に等しく、","CA","、","AB","、","BC","の三辺はすべて","互いに等しい。","","","","","","2","99","99"},
        {"CA", "は","CB","に等しく、","CA","、","AB","、","BC","の三辺はすべて","互いに等しい。","","","","","","4","99","99"},
        {"CA", "は","CB","に等しく、","CA","、","AB","、","BC","の三辺はすべて","互いに等しい。","","","","","","6","99","99"},
        {"CA", "は","CB","に等しく、","CA","、","AB","、","BC","の三辺はすべて","互いに等しい。","","","","","","8","99","99"},
        {"CA", "は","CB","に等しく、","CA","、","AB","、","BC","の三辺はすべて","互いに等しい。","","","","","","99","99","99"},
        {"ゆえに、三角形", "ABC","は正三角形であり、","与えられた直線","AB","から作図","されたものである。","","","","","","","","","","1","99","99"},
        {"ゆえに、三角形", "ABC","は正三角形であり、","与えられた直線","AB","から作図","されたものである。","","","","","","","","","","4","99","99"},
        {"ゆえに、三角形", "ABC","は正三角形であり、","与えられた直線","AB","から作図","されたものである。","","","","","","","","","","99","99","99"},
        {"これが求められていた", "ことであった。","","","","","","","","","","","","","","","99","99","99"},

    };

    private string[,] m1_2 = new string[,]//m1_2w
    {
        {"命題I-2","","","","","","","","","","","","","","","","99","99","99"},
        {"与えられた直線", "と","同じ長さの直線","を","与えられた点","から作図すること。","","","","","","","","","","","0","99","99"},
        {"与えられた直線", "と","同じ長さの直線","を","与えられた点","から作図すること。","","","","","","","","","","","2","99","99"},
        {"与えられた直線", "と","同じ長さの直線","を","与えられた点","から作図すること。","","","","","","","","","","","4","99","99"},
        {"与えられた直線", "と","同じ長さの直線","を","与えられた点","から作図すること。","","","","","","","","","","","99","99","99"},
        //
        {"Aを与えられた点、", "BCを与えられた直線","とする。","","","","","","","","","","","","","","0","99","99"},
        {"Aを与えられた点、", "BCを与えられた直線","とする。","","","","","","","","","","","","","","1","99","99"},
        {"Aを与えられた点、", "BCを与えられた直線","とする。","","","","","","","","","","","","","","99","99","99"},
        {"このとき、", "A","から","BC","と同じ長さの直線","を作図することが求められている。","","","","","","","","","","","1","99","99"},
        {"このとき、", "A","から","BC","と同じ長さの直線","を作図することが求められている。","","","","","","","","","","","3","99","99"},
        {"このとき、", "A","から","BC","と同じ長さの直線","を作図することが求められている。","","","","","","","","","","","99","99","99"},
        {"AB", "を","A","と","B","を結ぶ直線とすると","[公準P-1]","","","","","","","","","","0","99","99"},
        {"AB", "を","A","と","B","を結ぶ直線とすると","[公準P-1]","","","","","","","","","","2","99","99"},
        {"AB", "を","A","と","B","を結ぶ直線とすると","[公準P-1]","","","","","","","","","","4","99","99"},
        {"AB", "を","A","と","B","を結ぶ直線とすると","[公準P-1]","","","","","","","","","","99","99","99"},

        {"直線AB", "を","一辺とする","正三角形DAB","を作図することができる","[命題I-1]","","","","","","","","","","","0","99","99"},
        {"直線AB", "を","一辺とする","正三角形DAB","を作図することができる","[命題I-1]","","","","","","","","","","","3","99","99"},
        {"直線AB", "を","一辺とする","正三角形DAB","を作図することができる","[命題I-1]","","","","","","","","","","","99","99","99"},

        {"DA", "と","DB","を延長し、","直線AE","と","BF","を描く","[公準P-2]","","","","","","","","0","99","99"},
        {"DA", "と","DB","を延長し、","直線AE","と","BF","を描く","[公準P-2]","","","","","","","","2","99","99"},
        {"DA", "と","DB","を延長し、","直線AE","と","BF","を描く","[公準P-2]","","","","","","","","4","99","99"},
        {"DA", "と","DB","を延長し、","直線AE","と","BF","を描く","[公準P-2]","","","","","","","","6","99","99"},
        {"DA", "と","DB","を延長し、","直線AE","と","BF","を描く","[公準P-2]","","","","","","","","99","99","99"},
        
        {"そして、", "B","を中心とし","BC","を半径とする","円CGH","を描き","[公準P-3]","","","","","","","","","1","99","99"},
        {"そして、", "B","を中心とし","BC","を半径とする","円CGH","を描き","[公準P-3]","","","","","","","","","3","99","99"},
        {"そして、", "B","を中心とし","BC","を半径とする","円CGH","を描き","[公準P-3]","","","","","","","","","5","99","99"},
        {"そして、", "B","を中心とし","BC","を半径とする","円CGH","を描き","[公準P-3]","","","","","","","","","99","99","99"},

        {"D", "を中心とし","DG","を半径とする","円GKL","を描く","[公準P-3]","","","","","","","","","","0","99","99"},
        {"D", "を中心とし","DG","を半径とする","円GKL","を描く","[公準P-3]","","","","","","","","","","2","99","99"},
        {"D", "を中心とし","DG","を半径とする","円GKL","を描く","[公準P-3]","","","","","","","","","","4","99","99"},
        {"D", "を中心とし","DG","を半径とする","円GKL","を描く","[公準P-3]","","","","","","","","","","99","99","99"},
        
        
        //{"", "","","","","","","","","","","99"},
        {"ここで、", "B","は","円CGH","の中心であるから、","BC","は","BG","と等しい","[定義DI-15]","","","","","","","1","99","99"},
        {"ここで、", "B","は","円CGH","の中心であるから、","BC","は","BG","と等しい","[定義DI-15]","","","","","","","3","99","99"},
        {"ここで、", "B","は","円CGH","の中心であるから、","BC","は","BG","と等しい","[定義DI-15]","","","","","","","5","99","99"},
        {"ここで、", "B","は","円CGH","の中心であるから、","BC","は","BG","と等しい","[定義DI-15]","","","","","","","7","99","99"},
        {"ここで、", "B","は","円CGH","の中心であるから、","BC","は","BG","と等しい","[定義DI-15]","","","","","","","99","99","99"},

        {"また、", "D","は","円GKL","の中心であるから、","DL","は","DG","と等しい","[定義DI-15]。","","","","","","","1","99","99"},
        {"また、", "D","は","円GKL","の中心であるから、","DL","は","DG","と等しい","[定義DI-15]。","","","","","","","3","99","99"},
        {"また、", "D","は","円GKL","の中心であるから、","DL","は","DG","と等しい","[定義DI-15]。","","","","","","","5","99","99"},
        {"また、", "D","は","円GKL","の中心であるから、","DL","は","DG","と等しい","[定義DI-15]。","","","","","","","7","99","99"},
        {"また、", "D","は","円GKL","の中心であるから、","DL","は","DG","と等しい","[定義DI-15]。","","","","","","","99","99","99"},

        {"これらの中にある", "DA","と","DB","は等しいから、","それらを引いた差のAL","は","BG","と等しい","[公理A-3]。","","","","","","","1","99","99"},
        {"これらの中にある", "DA","と","DB","は等しいから、","それらを引いた差のAL","は","BG","と等しい","[公理A-3]。","","","","","","","3","99","99"},
        {"これらの中にある", "DA","と","DB","は等しいから、","それらを引いた差のAL","は","BG","と等しい","[公理A-3]。","","","","","","","5","99","99"},
        {"これらの中にある", "DA","と","DB","は等しいから、","それらを引いた差のAL","は","BG","と等しい","[公理A-3]。","","","","","","","7","99","99"},
        {"これらの中にある", "DA","と","DB","は等しいから、","それらを引いた差のAL","は","BG","と等しい","[公理A-3]。","","","","","","","99","99","99"},

        {"BC", "と","BG","は等しいから、","同じものに等しいものは等しいことから","[公理A-1]","、","AL","は","BC","と等しい。","","","","","","0","99","99"},
        {"BC", "と","BG","は等しいから、","同じものに等しいものは等しいことから","[公理A-1]","、","AL","は","BC","と等しい。","","","","","","2","99","99"},
        {"BC", "と","BG","は等しいから、","同じものに等しいものは等しいことから","[公理A-1]","、","AL","は","BC","と等しい。","","","","","","7","99","99"},
        {"BC", "と","BG","は等しいから、","同じものに等しいものは等しいことから","[公理A-1]","、","AL","は","BC","と等しい。","","","","","","9","99","99"},
        {"BC", "と","BG","は等しいから、","同じものに等しいものは等しいことから","[公理A-1]","、","AL","は","BC","と等しい。","","","","","","99","99","99"},






        {"ゆえに、", "直線AL","は与えられた","直線BC","と等しく、","与えられた","点A","から引かれている。","","","","","","","","","1","99","99"},
        {"ゆえに、", "直線AL","は与えられた","直線BC","と等しく、","与えられた","点A","から引かれている。","","","","","","","","","3","99","99"},
        {"ゆえに、", "直線AL","は与えられた","直線BC","と等しく、","与えられた","点A","から引かれている。","","","","","","","","","6","99","99"},
        {"ゆえに、", "直線AL","は与えられた","直線BC","と等しく、","与えられた","点A","から引かれている。","","","","","","","","","99","99","99"},

        {"これが求められていた", "ことであった。","","","","","","","","","","","","","","","99","99","99"},
        //{"", "","","","","","","","","","","99"},

    };
    private string[,] m1_3 = new string[,]//m1_3w
    {
        {"命題I-3","","","","","","","","","","","","","","","","99","99","99"},
        {"長さが異なる", "二つの直線","が与えられたとき、","長い方","から","短い方","の長さを切り取ること。","","","","","","","","","","1","99","99"},
        {"長さが異なる", "二つの直線","が与えられたとき、","長い方","から","短い方","の長さを切り取ること。","","","","","","","","","","3","99","99"},
        {"長さが異なる", "二つの直線","が与えられたとき、","長い方","から","短い方","の長さを切り取ること。","","","","","","","","","","5","99","99"},
        {"長さが異なる", "二つの直線","が与えられたとき、","長い方","から","短い方","の長さを切り取ること。","","","","","","","","","","99","99","99"},
        //{"", "","","","","","","","","","","99"},
        {"AB", "と","C","を与えられた","長さが異なる二つの直線とし、","AB","の方が長いものとする。","","","","","","","","","","0","99","99"},
        {"AB", "と","C","を与えられた","長さが異なる二つの直線とし、","AB","の方が長いものとする。","","","","","","","","","","2","99","99"},
        {"AB", "と","C","を与えられた","長さが異なる二つの直線","とし、","AB","の方が長いものとする。","","","","","","","","","4","99","99"},
        {"AB", "と","C","を与えられた","長さが異なる二つの直線","とし、","AB","の方が長いものとする。","","","","","","","","","6","99","99"},
        {"AB", "と","C","を与えられた","長さが異なる二つの直線","とし、","AB","の方が長いものとする。","","","","","","","","","99","99","99"},

        //{"AB", "と","C","を与えられた","長さが異なる二つの直線とし、","AB","の方が長いものとする。","","","","","5","99","99"},
        //{"AB", "と","C","を与えられた","長さが異なる二つの直線とし、","AB","の方が長いものとする。","","","","","99","99","99"},

        {"このとき、", "AB","から","Cの長さ分","を切り取ることが求められている。","","","","","","","","","","","","1","99","99"},
        {"このとき、", "AB","から","Cの長さ分","を切り取ることが求められている。","","","","","","","","","","","","3","99","99"},
        {"このとき、", "AB","から","Cの長さ分","を切り取ることが求められている。","","","","","","","","","","","","99","99","99"},

        {"AD", "を","C","と同じ長さの","A","から引かれた直線とする","[命題I-2]。","","","","","","","","","","0","99","99"},
        {"AD", "を","C","と同じ長さの","A","から引かれた直線とする","[命題I-2]。","","","","","","","","","","2","99","99"},
        {"AD", "を","C","と同じ長さの","A","から引かれた直線とする","[命題I-2]。","","","","","","","","","","4","99","99"},
        {"AD", "を","C","と同じ長さの","A","から引かれた直線とする","[命題I-2]。","","","","","","","","","","99","99","99"},

        {"そして、", "A","を中心とし","半径AD","の","円DEF","を描く","[公準P-3]。","","","","","","","","","1","99","99"},
        {"そして、", "A","を中心とし","半径AD","の","円DEF","を描く","[公準P-3]。","","","","","","","","","3","99","99"},
        {"そして、", "A","を中心とし","半径AD","の","円DEF","を描く","[公準P-3]。","","","","","","","","","5","99","99"},
        {"そして、", "A","を中心とし","半径AD","の","円DEF","を描く","[公準P-3]。","","","","","","","","","99","99","99"},

        {"A", "は","円DEF","の中心であるから、","AE","は","AD","と等しい","[定義I-15]。","","","","","","","","0","99","99"},
        {"A", "は","円DEF","の中心であるから、","AE","は","AD","と等しい","[定義I-15]。","","","","","","","","2","99","99"},
        {"A", "は","円DEF","の中心であるから、","AE","は","AD","と等しい","[定義I-15]。","","","","","","","","4","99","99"},
        {"A", "は","円DEF","の中心であるから、","AE","は","AD","と等しい","[定義I-15]。","","","","","","","","6","99","99"},
        {"A", "は","円DEF","の中心であるから、","AE","は","AD","と等しい","[定義I-15]。","","","","","","","","99","99","99"},

        {"ここで", "C","は","AD","と等しいから、","AE","と","C","は共に","AD","と等しく、","","","","","","1","99","99"},
        {"ここで", "C","は","AD","と等しいから、","AE","と","C","は共に","AD","と等しく、","","","","","","3","99","99"},
        {"ここで", "C","は","AD","と等しいから、","AE","と","C","は共に","AD","と等しく、","","","","","","5","99","99"},
        {"ここで", "C","は","AD","と等しいから、","AE","と","C","は共に","AD","と等しく、","","","","","","7","99","99"},
        {"ここで", "C","は","AD","と等しいから、","AE","と","C","は共に","AD","と等しく、","","","","","","9","99","99"},
        {"ここで", "C","は","AD","と等しいから、","AE","と","C","は共に","AD","と等しく、","","","","","","99","99","99"},

        {"よって", "AE","は","C","と等しい","[公理A-1]。","","","","","","","","","","","1","99","99"},
        {"よって", "AE","は","C","と等しい","[公理A-1]。","","","","","","","","","","","3","99","99"},
        {"よって", "AE","は","C","と等しい","[公理A-1]。","","","","","","","","","","","99","99","99"},

        {"ゆえに、与えられた", "二つの直線","AB","と","C","について、","AE","は短い方の","直線C","と等しく、","","","","","","","2","99","99"},
        {"ゆえに、与えられた", "二つの直線","AB","と","C","について、","AE","は短い方の","直線C","と等しく、","","","","","","","4","99","99"},
        {"ゆえに、与えられた", "二つの直線","AB","と","C","について、","AE","は短い方の","直線C","と等しく、","","","","","","","6","99","99"},
        {"ゆえに、与えられた", "二つの直線","AB","と","C","について、","AE","は短い方の","直線C","と等しく、","","","","","","","8","99","99"},

        {"ゆえに、与えられた", "二つの直線","AB","と","C","について、","AE","は短い方の","直線C","と等しく、","","","","","","","99","99","99"},

        {"長い方の", "直線AB","を切り取る。","これが求められていたことであった。","","","","","","","","","","","","","1","99","99"},
        {"長い方の", "直線AB","を切り取る。","これが求められていたことであった。","","","","","","","","","","","","","99","99","99"},
    };
    private string[,] m1_4 = new string[,]//m1_4w
    {
        {"命題I-4","","","","","","","","","","","","","","","","99","99","99"},
        {"二つの三角形", "において、","二つの辺","がそれぞれ等しく、","","","","","","","","","","","","","0","99","99"},
        {"二つの三角形", "において、","二つの辺","がそれぞれ等しく、","","","","","","","","","","","","","2","99","99"},
        {"その二辺に挟まれる角", "も等しいならば、","","","","","","","","","","","","","","","0","99","99"},
        {"底辺", "も等しく、","二つの三角形","は等しい。","","","","","","","","","","","","","0","99","99"},
        {"底辺", "も等しく、","二つの三角形","は等しい。","","","","","","","","","","","","","2","99","99"},
        {"そして、", "等しい二辺","に対する","残りの角","もそれぞれ等しい。","","","","","","","","","","","","1","99","99"},
        {"そして、", "等しい二辺","に対する","残りの角","もそれぞれ等しい。","","","","","","","","","","","","3","99","99"},

        {"二つの三角形", "ABC","と","DEF","において、","","","","","","","","","","","","1","99","99"},
        {"二つの三角形", "ABC","と","DEF","において、","","","","","","","","","","","","3","99","99"},
        
        {"二辺", "AB","と","AC","が二辺","DE","と","DF","にそれぞれ等しい、","","","","","","","","1","99","99"},
        {"二辺", "AB","と","AC","が二辺","DE","と","DF","にそれぞれ等しい、","","","","","","","","3","99","99"},
        {"二辺", "AB","と","AC","が二辺","DE","と","DF","にそれぞれ等しい、","","","","","","","","5","99","99"},
        {"二辺", "AB","と","AC","が二辺","DE","と","DF","にそれぞれ等しい、","","","","","","","","7","99","99"},
        
        {"すなわち、", "AB","と","DE","、","AC","と","DF","が等しいとし、","","","","","","","","1","99","99"},
        {"すなわち、", "AB","と","DE","、","AC","と","DF","が等しいとし、","","","","","","","","3","99","99"},
        {"すなわち、", "AB","と","DE","、","AC","と","DF","が等しいとし、","","","","","","","","5","99","99"},
        {"すなわち、", "AB","と","DE","、","AC","と","DF","が等しいとし、","","","","","","","","7","99","99"},

        {"そして", "角BAC","と","角EDF","が等しいものとする。","","","","","","","","","","","","1","99","99"},
        {"そして", "角BAC","と","角EDF","が等しいものとする。","","","","","","","","","","","","3","99","99"},

        {"このとき、", "底辺BC","と","底辺EF","が等しく、","","","","","","","","","","","","1","99","99"},
        {"このとき、", "底辺BC","と","底辺EF","が等しく、","","","","","","","","","","","","3","99","99"},

        {"角ABC", "と","角DEF","、","角ACB","と","角DFE","が等しいと主張する。","","","","","","","","","0","99","99"},
        {"角ABC", "と","角DEF","、","角ACB","と","角DFE","が等しいと主張する。","","","","","","","","","2","99","99"},
        {"角ABC", "と","角DEF","、","角ACB","と","角DFE","が等しいと主張する。","","","","","","","","","4","99","99"},
        {"角ABC", "と","角DEF","、","角ACB","と","角DFE","が等しいと主張する。","","","","","","","","","6","99","99"},

        {"三角形ABC", "を","三角形DEF","に重ね合わせ、","","","","","","","","","","","","","0","99","99"},
        {"三角形ABC", "を","三角形DEF","に重ね合わせ、","","","","","","","","","","","","","2","99","99"},

        {"点A", "は","点D","に、","直線AB","は","直線DE","と一致するようにする。","","","","","","","","","0","99","99"},
        {"点A", "は","点D","に、","直線AB","は","直線DE","と一致するようにする。","","","","","","","","","2","99","99"},
        {"点A", "は","点D","に、","直線AB","は","直線DE","と一致するようにする。","","","","","","","","","4","99","99"},
        {"点A", "は","点D","に、","直線AB","は","直線DE","と一致するようにする。","","","","","","","","","6","99","99"},

        {"このとき", "AB","と","DE","の長さが等しいことから","点B","は","点E","に一致する。","","","","","","","","1","99","99"},
        {"このとき", "AB","と","DE","の長さが等しいことから","点B","は","点E","に一致する。","","","","","","","","3","99","99"},
        {"このとき", "AB","と","DE","の長さが等しいことから","点B","は","点E","に一致する。","","","","","","","","5","99","99"},
        {"このとき", "AB","と","DE","の長さが等しいことから","点B","は","点E","に一致する。","","","","","","","","7","99","99"},

        {"AB", "と","DE","が一致していることと","角BAC","が","EDF","に等しいことから、","","","","","","","","","0","99","99"},
        {"AB", "と","DE","が一致していることと","角BAC","が","EDF","に等しいことから、","","","","","","","","","2","99","99"},
        {"AB", "と","DE","が一致していることと","角BAC","が","EDF","に等しいことから、","","","","","","","","","4","99","99"},
        {"AB", "と","DE","が一致していることと","角BAC","が","EDF","に等しいことから、","","","","","","","","","6","99","99"},

        {"直線AC", "と","DF","も一致する。","","","","","","","","","","","","","0","99","99"},
        {"直線AC", "と","DF","も一致する。","","","","","","","","","","","","","2","99","99"},

        {"したがって、", "点C","と","点F","は一致する。","","","","","","","","","","","","1","99","99"},
        {"したがって、", "点C","と","点F","は一致する。","","","","","","","","","","","","3","99","99"},
      
        {"点B", "は","点E","と一致しているから","底辺BC","は","底辺EF","と一致する。","","","","","","","","","0","99","99"},
        {"点B", "は","点E","と一致しているから","底辺BC","は","底辺EF","と一致する。","","","","","","","","","2","99","99"},
        {"点B", "は","点E","と一致しているから","底辺BC","は","底辺EF","と一致する。","","","","","","","","","4","99","99"},
        {"点B", "は","点E","と一致しているから","底辺BC","は","底辺EF","と一致する。","","","","","","","","","6","99","99"},


        {"なぜならば、", "もし一致しないとすれば","同じ点を結ぶ直線は","唯一つであることに","反するからである","[公準P-1]任意の点から任意の点","へ直線を引くこと。","","","","","","","","","","99","99","99"},
        {"なぜならば、", "もし一致しないとすれば","同じ点を結ぶ直線は","唯一つであることに","反するからである","[公準P-1]任意の点から任意の点","へ直線を引くこと。","","","","","","","","","","5","6","99"},

        {"したがって、", "底辺BC","と","底辺EF","は一致し、互いに等しい","[公理A-4]互いに重なり合うもの","は互いに等しい。","","","","","","","","","","1","99","99"},
        {"したがって、", "底辺BC","と","底辺EF","は一致し、互いに等しい","[公理A-4]互いに重なり合うもの","は互いに等しい。","","","","","","","","","","3","99","99"},
        {"したがって、", "底辺BC","と","底辺EF","は一致し、互いに等しい","[公理A-4]互いに重なり合うもの","は互いに等しい。","","","","","","","","","","99","99","99"},

        {"したがって、", "底辺BC","と","底辺EF","は一致し、互いに等しい","[公理A-4]互いに重なり合うもの","は互いに等しい。","","","","","","","","","","5","6","99"},


        {"したがって、", "三角形ABC","は","三角形DEF","と完全に一致し、","互いに等しい","[公理A-4]互いに重なり合うもの","は互いに等しい。","","","","","","","","","1","99","99"},
        {"したがって、", "三角形ABC","は","三角形DEF","と完全に一致し、","互いに等しい","[公理A-4]互いに重なり合うもの","は互いに等しい。","","","","","","","","","3","99","99"},
        {"したがって、", "三角形ABC","は","三角形DEF","と完全に一致し、","互いに等しい","[公理A-4]互いに重なり合うもの","は互いに等しい。","","","","","","","","","99","99","99"},

        {"したがって、", "三角形ABC","は","三角形DEF","と完全に一致し、","互いに等しい","[公理A-4]互いに重なり合うもの","は互いに等しい。","","","","","","","","","6","7","99"},


        {"残りの角", "もそれぞれ一致し、","互いに等しい","[公理A-4]互いに重なり合うもの","は互いに等しい。","","","","","","","","","","","","0","99","99"},
        {"残りの角", "もそれぞれ一致し、","互いに等しい","[公理A-4]互いに重なり合うもの","は互いに等しい。","","","","","","","","","","","","99","99","99"},

        {"残りの角", "もそれぞれ一致し、","互いに等しい","[公理A-4]互いに重なり合うもの","は互いに等しい。","","","","","","","","","","","","3","4","99"},


        {"つまり、", "ABC","と","DEF","、","ACB","と","DFE","は等しい","[公理A-4]互いに重なり合うもの","は互いに等しい。","","","","","","1","99","99"},
        {"つまり、", "ABC","と","DEF","、","ACB","と","DFE","は等しい","[公理A-4]互いに重なり合うもの","は互いに等しい。","","","","","","3","99","99"},
        {"つまり、", "ABC","と","DEF","、","ACB","と","DFE","は等しい","[公理A-4]互いに重なり合うもの","は互いに等しい。","","","","","","5","99","99"},
        {"つまり、", "ABC","と","DEF","、","ACB","と","DFE","は等しい","[公理A-4]互いに重なり合うもの","は互いに等しい。","","","","","","7","99","99"},
        {"つまり、", "ABC","と","DEF","、","ACB","と","DFE","は等しい","[公理A-4]互いに重なり合うもの","は互いに等しい。","","","","","","99","99","99"},
        
        {"つまり、", "ABC","と","DEF","、","ACB","と","DFE","は等しい","[公理A-4]互いに重なり合うもの","は互いに等しい。","","","","","","9","10","99"},


        {"ゆえに、", "二つの三角形","において、","二つの辺","がそれぞれ等しく、","","","","","","","","","","","","1","99","99"},
        {"ゆえに、", "二つの三角形","において、","二つの辺","がそれぞれ等しく、","","","","","","","","","","","","3","99","99"},

        {"その", "二辺に挟まれる角","も等しいならば、","底辺","も等しく、","二つの三角形","は等しい。","","","","","","","","","","1","99","99"},
        {"その", "二辺に挟まれる角","も等しいならば、","底辺","も等しく、","二つの三角形","は等しい。","","","","","","","","","","3","99","99"},
        {"その", "二辺に挟まれる角","も等しいならば、","底辺","も等しく、","二つの三角形","は等しい。","","","","","","","","","","5","99","99"},

        {"そして、等しい二辺に対する", "残りの角","もそれぞれ等しい。","これが証明すべきことであった。","","","","","","","","","","","","","0","99","99"},
        {"そして、等しい二辺に対する", "残りの角","もそれぞれ等しい。","これが証明すべきことであった。","","","","","","","","","","","","","1","99","99"},
        {"そして、等しい二辺に対する", "残りの角","もそれぞれ等しい。","これが証明すべきことであった。","","","","","","","","","","","","","99","99","99"},
        {"", "","","","","","","","","","","","","","","","99","99","99"},
        {"", "","","","","","","","","","","","","","","","99","99","99"},

    };
    //m1_5w
    private string[,] m1_5 = new string[,]
    {
        {"命題I-5","","","","","","","","","","","","","","","","99","99","99"},
        {"二等辺三角形", "の","底辺上","の","二つの角","は互いに等しい","","","","","","","","","","","0","99","99"},
        {"二等辺三角形", "の","底辺上","の","二つの角","は互いに等しい","","","","","","","","","","","2","99","99"},
        {"二等辺三角形", "の","底辺上","の","二つの角","は互いに等しい","","","","","","","","","","","4","99","99"},
        {"二等辺三角形", "の","底辺上","の","二つの角","は互いに等しい","","","","","","","","","","","5","99","99"},


        {"そして、", "等辺","を延長してできる","底辺下の","二つの角","も互いに等しい。","","","","","","","","","","","1","99","99"},
        {"そして、", "等辺","を延長してできる","底辺下の","二つの角","も互いに等しい。","","","","","","","","","","","2","99","99"},
        {"そして、", "等辺","を延長してできる","底辺下の","二つの角","も互いに等しい。","","","","","","","","","","","3","99","99"},

        {"そして、", "等辺","を延長してできる","底辺下の","二つの角","も互いに等しい。","","","","","","","","","","","4","99","99"},
        {"そして、", "等辺","を延長してできる","底辺下の","二つの角","も互いに等しい。","","","","","","","","","","","5","99","99"},

        {"", "証明スタート","　　　　　　　","","","","","","","","","","","","","","1","99","99"},

        //{"　　　　　　   ", "証明","　　　　　　　","","","","","","","","","","","","","","1","99","99"},
        //shoumei
        {"ABC", "を","辺AB","と","辺AC","が等しい","二等辺三角形","とし、","","","","","","","","","0","99","99"},
        {"ABC", "を","辺AB","と","辺AC","が等しい","二等辺三角形","とし、","","","","","","","","","2","99","99"},
        {"ABC", "を","辺AB","と","辺AC","が等しい","二等辺三角形","とし、","","","","","","","","","4","99","99"},
        {"ABC", "を","辺AB","と","辺AC","が等しい","二等辺三角形","とし、","","","","","","","","","5","99","99"},

        {"ABC", "を","辺AB","と","辺AC","が等しい","二等辺三角形","とし、","","","","","","","","","6","99","99"},

        {"BD", "と","CE","を","AB","と",
            "AC","のそれぞれ","延長した","直線とする","           ","[公準P-2]","   　　　　　","任意の直線を連続して延ばすこと。","","","0","99","99"},
        {"BD", "と","CE","を","AB","と",
            "AC","のそれぞれ","延長した","直線とする","           ","[公準P-2]","   　　　　　","任意の直線を連続して延ばすこと。","","","2","99","99"},
        {"BD", "と","CE","を","AB","と",
            "AC","のそれぞれ","延長した","直線とする","           ","[公準P-2]","   　　　　　","任意の直線を連続して延ばすこと。","","","4","99","99"},
        {"BD", "と","CE","を","AB","と",
            "AC","のそれぞれ","延長した","直線とする","           ","[公準P-2]","   　　　　　","任意の直線を連続して延ばすこと。","","","6","99","99"},
        
        {"BD", "と","CE","を","AB","と",
            "AC","のそれぞれ","延長した","直線とする","           ","[公準P-2]","   　　　　　","任意の直線を連続して延ばすこと。","","","8","9","99"},
        {"BD", "と","CE","を","AB","と",
            "AC","のそれぞれ","延長した","直線とする","           ","[公準P-2]","   　　　　　","任意の直線を連続して延ばすこと。","","","11","13","99"},

        {"このとき、", "角ABC","と","ACB","が等しいと主張する。","さらに","角CBD","と","BCE","が等しいと主張する。","","","","","","","1","99","99"},
        {"このとき、", "角ABC","と","ACB","が等しいと主張する。","さらに","角CBD","と","BCE","が等しいと主張する。","","","","","","","3","99","99"},
        {"このとき、", "角ABC","と","ACB","が等しいと主張する。","さらに","角CBD","と","BCE","が等しいと主張する。","","","","","","","4","99","99"},
        {"このとき、", "角ABC","と","ACB","が等しいと主張する。","さらに","角CBD","と","BCE","が等しいと主張する。","","","","","","","6","99","99"},
        {"このとき、", "角ABC","と","ACB","が等しいと主張する。","さらに","角CBD","と","BCE","が等しいと主張する。","","","","","","","8","99","99"},
        {"このとき、", "角ABC","と","ACB","が等しいと主張する。","さらに","角CBD","と","BCE","が等しいと主張する。","","","","","","","9","99","99"},



        {"点F", "を","BD","上にとる","　　　　　　　",
            "AE","から","点A","を始点として",
            "AFの長さ","を切り取る","　　　　　",
            "[命題I-3]",
            "長さが異なる二つの直線の長い方",
            "から短い方を切り取ること。","","0","99","99"},
        {"点F", "を","BD","上にとる","　　　　　　　",
            "AE","から","点A","を始点として",
            "AFの長さ","を切り取る","　　　　　",
            "[命題I-3]",
            "長さが異なる二つの直線の長い方",
            "から短い方を切り取ること。","","2","99","99"},
        {"点F", "を","BD","上にとる","　　　　　　　",
            "AE","から","点A","を始点として",
            "AFの長さ","を切り取る","　　　　　",
            "[命題I-3]",
            "長さが異なる二つの直線の長い方",
            "から短い方を切り取ること。","","5","99","99"},
        {"点F", "を","BD","上にとる","　　　　　　　",
            "AE","から","点A","を始点として",
            "AFの長さ","を切り取る","　　　　　",
            "[命題I-3]",
            "長さが異なる二つの直線の長い方",
            "から短い方を切り取ること。","","7","99","99"},
        {"点F", "を","BD","上にとる","　　　　　　　",
            "AE","から","点A","を始点として",
            "AFの長さ","を切り取る","　　　　　",
            "[命題I-3]",
            "長さが異なる二つの直線の長い方",
            "から短い方を切り取ること。","","8","99","99"},
        {"点F", "を","BD","上にとる","　　　　　　　",
            "AE","から","点A","を始点として",
            "AFの長さ","を切り取る","　　　　　",
            "[命題I-3]",
            "長さが異なる二つの直線の長い方",
            "から短い方を切り取ること。","","9","99","99"},
        {"点F", "を","BD","上にとる","　　　　　　　",
            "AE","から","点A","を始点として",
            "AFの長さ","を切り取る","　　　　　",
            "[命題I-3]",
            "長さが異なる二つの直線の長い方",
            "から短い方を切り取ること。","","10","99","99"},
        {"点F", "を","BD","上にとる","　　　　　　　",
            "AE","から","点A","を始点として",
            "AFの長さ","を切り取る","　　　　　",
            "[命題I-3]",
            "長さが異なる二つの直線の長い方",
            "から短い方を切り取ること。","","12","13","14"},

        {"切り取った直線", "の","終点","を","G","とする","","","","","","","","","","","0","99","99"},
        {"切り取った直線", "の","終点","を","G","とする","","","","","","","","","","","2","99","99"},
        {"切り取った直線", "の","終点","を","G","とする","","","","","","","","","","","4","99","99"},


        {"そして、", "直線FC","を描く","さらに","直線GB","を描く",
            "                  ","[公準P-1]","         ","任意の点から任意の点へ","直線を引くこと。","","","","","","1","2","99"},
        {"そして、", "直線FC","を描く","さらに","直線GB","を描く",
            "                  ","[公準P-1]","         ","任意の点から任意の点へ","直線を引くこと。","","","","","","4","5","99"},

        {"そして、", "直線FC","を描く","さらに","直線GB","を描く",
            "                  ","[公準P-1]","         ","任意の点から任意の点へ","直線を引くこと。","","","","","","7","9","10"},
        
        
        {"三角形AFC", "と","三角形AGB","は","",
            "","","","","",
            "","","","","",
            "","0","99","99"},
        {"三角形AFC", "と","三角形AGB","は","",
            "","","","","",
            "","","","","",
            "","2","99","99"},
        
        {"AF", "と","AG","が","等しく","　　　　　　　",
            "AC","と","AB","が","等しく","　　　　　",
            "対応する2辺の間の角","が","ひとしい","",
            "0","99","99"},
        {"AF", "と","AG","が","等しく","　　　　　　　",
            "AC","と","AB","が","等しく","　　　　　",
            "対応する2辺の間の角","が","ひとしい","",
            "2","99","99"},
        {"AF", "と","AG","が","等しく","　　　　　　　",
            "AC","と","AB","が","等しく","　　　　　",
            "対応する2辺の間の角","が","ひとしい","",
            "4","99","99"},
        {"AF", "と","AG","が","等しく","　　　　　　　",
            "AC","と","AB","が","等しく","　　　　　",
            "対応する2辺の間の角","が","ひとしい","",
            "6","99","99"},
        {"AF", "と","AG","が","等しく","　　　　　　　",
            "AC","と","AB","が","等しく","　　　　　",
            "対応する2辺の間の角","が","ひとしい","",
            "8","99","99"},
        {"AF", "と","AG","が","等しく","　　　　　　　",
            "AC","と","AB","が","等しく","　　　　　",
            "対応する2辺の間の角","が","ひとしい","",
            "10","99","99"},
        {"AF", "と","AG","が","等しく","　　　　　　　",
            "AC","と","AB","が","等しく","　　　　　",
            "対応する2辺の間の角","が","ひとしい","",
            "12","99","99"},
        {"AF", "と","AG","が","等しく","　　　　　　　",
            "AC","と","AB","が","等しく","　　　　　",
            "対応する2辺の間の角","が","ひとしい","",
            "12","99","99"},
        {"AF", "と","AG","が","等しく","　　　　　　　",
            "AC","と","AB","が","等しく","　　　　　",
            "対応する2辺の間の角","が","ひとしい","",
            "14","99","99"},

        {"なので","三角形AFC", "と","三角形AGB","は",
            "対応する辺","と","対応する角","が","ひとしい",
            "","","","","",
            "","1","99","99"},
        {"なので","三角形AFC", "と","三角形AGB","は",
            "対応する辺","と","対応する角","が","ひとしい",
            "","","","","",
            "","3","99","99"},
        {"なので","三角形AFC", "と","三角形AGB","は",
            "対応する辺","と","対応する角","が","ひとしい",
            "","","","","",
            "","5","99","99"},
        {"なので","三角形AFC", "と","三角形AGB","は",
            "対応する辺","と","対応する角","が","ひとしい",
            "","","","","",
            "","5","99","99"},
        {"なので","三角形AFC", "と","三角形AGB","は",
            "対応する辺","と","対応する角","が","ひとしい",
            "","","","","",
            "","7","99","99"},
        {"なので","三角形AFC", "と","三角形AGB","は",
            "対応する辺","と","対応する角","が","ひとしい",
            "","","","","",
            "","7","99","99"},
        {"なので","三角形AFC", "と","三角形AGB","は",
            "対応する辺","と","対応する角","が","ひとしい",
            "","","","","",
            "","9","99","99"},
        {"なので","三角形AFC", "と","三角形AGB","は",
            "対応する辺","と","対応する角","が","ひとしい",
            "","","","","",
            "","9","99","99"},
        {"なので","三角形AFC", "と","三角形AGB","は",
            "対応する辺","と","対応する角","が","ひとしい",
            "","","","","",
            "","9","99","99"},
        {"なので","三角形AFC", "と","三角形AGB","は",
            "対応する辺","と","対応する角","が","ひとしい",
            "","","","","",
            "","9","99","99"},
        {"なので","三角形AFC", "と","三角形AGB","は",
            "対応する辺","と","対応する角","が","ひとしい",
            "","","","","",
            "","9","99","99"},
        
        



        {"命題I-4", "","","","",
            "二辺とその間の角が等しい三角形は","","","","",
            "残りの辺と角も互いに等しい。","","","","",
            "","0","5","10"},
        {"命題I-4", "","","","",
            "二辺とその間の角が等しい三角形は","","","","",
            "残りの辺と角も互いに等しい。","","","","",
            "","0","5","10"},

        {"AF", "と","AG","は等しいから、","","","","","","","","","","","","","0","99","99"},
        {"AF", "と","AG","は等しいから、","","","","","","","","","","","","","2","99","99"},
        {"AF", "と","AG","は等しいから、","","","","","","","","","","","","","3","99","99"},

        {"そこから相等しい", "AB","と","AC","を引いた差の","BF",
            "と","CG","は等しい","[公理A-3]","　　　　　　　　　　　","等しいものから等しいものを引いた","差は互いに等しい。","","","","1","99","99"},
        {"そこから相等しい", "AB","と","AC","を引いた差の","BF",
            "と","CG","は等しい","[公理A-3]","　　　　　　　　　　　","等しいものから等しいものを引いた","差は互いに等しい。","","","","3","99","99"},
        {"そこから相等しい", "AB","と","AC","を引いた差の","BF",
            "と","CG","は等しい","[公理A-3]","　　　　　　　　　　　","等しいものから等しいものを引いた","差は互いに等しい。","","","","4","99","99"},
        {"そこから相等しい", "AB","と","AC","を引いた差の","BF",
            "と","CG","は等しい","[公理A-3]","　　　　　　　　　　　","等しいものから等しいものを引いた","差は互いに等しい。","","","","5","99","99"},
        {"そこから相等しい", "AB","と","AC","を引いた差の","BF",
            "と","CG","は等しい","[公理A-3]","　　　　　　　　　　　","等しいものから等しいものを引いた","差は互いに等しい。","","","","7","99","99"},
        {"そこから相等しい", "AB","と","AC","を引いた差の","BF",
            "と","CG","は等しい","[公理A-3]","　　　　　　　　　　　","等しいものから等しいものを引いた","差は互いに等しい。","","","","8","99","99"},
        {"そこから相等しい", "AB","と","AC","を引いた差の","BF",
            "と","CG","は等しい","[公理A-3]","　　　　　　　　　　　","等しいものから等しいものを引いた","差は互いに等しい。","","","","9","11","12"},
        {"そこから相等しい", "AB","と","AC","を引いた差の","BF",
            "と","CG","は等しい","[公理A-3]","　　　　　　　　　　　","等しいものから等しいものを引いた","差は互いに等しい。","","","","9","11","12"},
        {"そこから相等しい", "AB","と","AC","を引いた差の","BF",
            "と","CG","は等しい","[公理A-3]","　　　　　　　　　　　","等しいものから等しいものを引いた","差は互いに等しい。","","","","9","11","12"},
        //kaizou
        //{"", "","","","",
        //    "","","","","",
        //    "","","","","",
        //    "","99","99","99"},
        {"FC", "と","GB","は等しいから、","","","","","","","","","","","","","0","99","99"},
        {"FC", "と","GB","は等しいから、","","","","","","","","","","","","","2","99","99"},
        {"FC", "と","GB","は等しいから、","","","","","","","","","","","","","3","99","99"},


        {"BF", "、","FC","と","CG","、","GB","がそれぞれ等しく、","","","","","","","","","0","99","99"},
        {"BF", "、","FC","と","CG","、","GB","がそれぞれ等しく、","","","","","","","","","2","99","99"},
        {"BF", "、","FC","と","CG","、","GB","がそれぞれ等しく、","","","","","","","","","4","99","99"},
        {"BF", "、","FC","と","CG","、","GB","がそれぞれ等しく、","","","","","","","","","6","99","99"},
        {"BF", "、","FC","と","CG","、","GB","がそれぞれ等しく、","","","","","","","","","7","99","99"},




        {"角BFC", "と","CGB","が等しく、","","","","","","","","","","","","","0","99","99"},
        {"角BFC", "と","CGB","が等しく、","","","","","","","","","","","","","2","99","99"},
        {"角BFC", "と","CGB","が等しく、","","","","","","","","","","","","","3","99","99"},


        {"底辺BC", "が共有されている。","したがって、","三角形BFC","と","三角形CGB","は等しく、","","","","","","","","","","0","99","99"},
        {"底辺BC", "が共有されている。","したがって、","三角形BFC","と","三角形CGB","は等しく、","","","","","","","","","","1","99","99"},

        {"底辺BC", "が共有されている。","したがって、","三角形BFC","と","三角形CGB","は等しく、","","","","","","","","","","3","99","99"},
        {"底辺BC", "が共有されている。","したがって、","三角形BFC","と","三角形CGB","は等しく、","","","","","","","","","","5","99","99"},
        {"底辺BC", "が共有されている。","したがって、","三角形BFC","と","三角形CGB","は等しく、","","","","","","","","","","6","99","99"},


        {"等しい二辺", "に対する","残りの角","もそれぞれ等しい","　　　　　　　","[命題I-4]",
            "　　　　　　　　　　","二辺とその間の角が等しい三角形は","、残りの辺と角も互いに等しい。","","","","","","","","0","99","99"},
        {"等しい二辺", "に対する","残りの角","もそれぞれ等しい","　　　　　　　","[命題I-4]",
            "　　　　　　　　　　","二辺とその間の角が等しい三角形は","、残りの辺と角も互いに等しい。","","","","","","","","2","99","99"},
        {"等しい二辺", "に対する","残りの角","もそれぞれ等しい","　　　　　　　","[命題I-4]",
            "　　　　　　　　　　","二辺とその間の角が等しい三角形は","、残りの辺と角も互いに等しい。","","","","","","","","3","99","99"},
        {"等しい二辺", "に対する","残りの角","もそれぞれ等しい","　　　　　　　","[命題I-4]",
            "　　　　　　　　　　","二辺とその間の角が等しい三角形は","、残りの辺と角も互いに等しい。","","","","","","","","5","7","8"},

        {"よって、", "FBC","と","GCB","、","BCF","と","CBG","は等しい。","","","","","","","","1","99","99"},
        {"よって、", "FBC","と","GCB","、","BCF","と","CBG","は等しい。","","","","","","","","3","99","99"},
        {"よって、", "FBC","と","GCB","、","BCF","と","CBG","は等しい。","","","","","","","","5","99","99"},
        {"よって、", "FBC","と","GCB","、","BCF","と","CBG","は等しい。","","","","","","","","7","99","99"},
        {"よって、", "FBC","と","GCB","、","BCF","と","CBG","は等しい。","","","","","","","","8","99","99"},


        {"角ABG", "と","角ACF","は等しいが、","","","","","","","","","","","","","0","99","99"},
        {"角ABG", "と","角ACF","は等しいが、","","","","","","","","","","","","","2","99","99"},
        {"角ABG", "と","角ACF","は等しいが、","","","","","","","","","","","","","3","99","99"},



        {"これから", "CBG","と","BCF","を引いた残りの","ABC",
            "と","ACB","は等しい","　　　　　　　　　　　","[公理A-3]","等しいものから等しいものを引いた","差は互いに等しい。","","","","1","99","99"},
        {"これから", "CBG","と","BCF","を引いた残りの","ABC",
            "と","ACB","は等しい","　　　　　　　　　　　","[公理A-3]","等しいものから等しいものを引いた","差は互いに等しい。","","","","3","99","99"},
        {"これから", "CBG","と","BCF","を引いた残りの","ABC",
            "と","ACB","は等しい","　　　　　　　　　　　","[公理A-3]","等しいものから等しいものを引いた","差は互いに等しい。","","","","4","99","99"},
        {"これから", "CBG","と","BCF","を引いた残りの","ABC",
            "と","ACB","は等しい","　　　　　　　　　　　","[公理A-3]","等しいものから等しいものを引いた","差は互いに等しい。","","","","5","99","99"},
        {"これから", "CBG","と","BCF","を引いた残りの","ABC",
            "と","ACB","は等しい","　　　　　　　　　　　","[公理A-3]","等しいものから等しいものを引いた","差は互いに等しい。","","","","7","99","99"},
        {"これから", "CBG","と","BCF","を引いた残りの","ABC",
            "と","ACB","は等しい","　　　　　　　　　　　","[公理A-3]","等しいものから等しいものを引いた","差は互いに等しい。","","","","8","99","99"},
        {"これから", "CBG","と","BCF","を引いた残りの","ABC",
            "と","ACB","は等しい","　　　　　　　　　　　","[公理A-3]","等しいものから等しいものを引いた","差は互いに等しい。","","","","10","11","12"},


        {"これらは", "三角形ABC","の","底辺上にある。","また","FBC","と","GCB","も等しく、これらは底辺下にある","","","","","","","","0","99","99"},
        {"これらは", "三角形ABC","の","底辺上にある。","また","FBC","と","GCB","も等しく、これらは底辺下にある","","","","","","","","1","99","99"},
        {"これらは", "三角形ABC","の","底辺上にある。","また","FBC","と","GCB","も等しく、これらは底辺下にある","","","","","","","","3","99","99"},
        {"これらは", "三角形ABC","の","底辺上にある。","また","FBC","と","GCB","も等しく、これらは底辺下にある","","","","","","","","5","99","99"},
        {"これらは", "三角形ABC","の","底辺上にある。","また","FBC","と","GCB","も等しく、これらは底辺下にある","","","","","","","","7","99","99"},
        {"これらは", "三角形ABC","の","底辺上にある。","また","FBC","と","GCB","も等しく、これらは底辺下にある","","","","","","","","8","99","99"},


        {"ゆえに、", "二等辺三角形","の","底辺上","の","二つの角","は互いに等しい、","","","","","","","","","","1","99","99"},
        {"ゆえに、", "二等辺三角形","の","底辺上","の","二つの角","は互いに等しい、","","","","","","","","","","3","99","99"},
        {"ゆえに、", "二等辺三角形","の","底辺上","の","二つの角","は互いに等しい、","","","","","","","","","","5","99","99"},
        {"ゆえに、", "二等辺三角形","の","底辺上","の","二つの角","は互いに等しい、","","","","","","","","","","6","99","99"},


        {"そして、", "等辺","を延長してできる","底辺下","の","二つの角","も互いに等しい。","","","","","","","","","","1","99","99"},
        {"そして、", "等辺","を延長してできる","底辺下","の","二つの角","も互いに等しい。","","","","","","","","","","2","99","99"},

        {"そして、", "等辺","を延長してできる","底辺下","の","二つの角","も互いに等しい。","","","","","","","","","","3","99","99"},
        {"そして、", "等辺","を延長してできる","底辺下","の","二つの角","も互いに等しい。","","","","","","","","","","5","99","99"},
        {"そして、", "等辺","を延長してできる","底辺下","の","二つの角","も互いに等しい。","","","","","","","","","","6","99","99"},


        {"これが証明すべきことであった。", "","","","","","","","","","","","","","","","99","99","99"},
        //{"", "","","","","","","","","","","99"},
    };
    private string[,] m1_6 = new string[,]//m1_6w
    {
        {"命題I-6","","","","","","","","","","","","","","","","99","99","99"},
        {"三角形", "の","二つの角","が等しいならば、","それらに対する","二つの辺","も互いに等しい。","","","","","","","","","","0","99","99"},
        {"三角形", "の","二つの角","が等しいならば、","それらに対する","二つの辺","も互いに等しい。","","","","","","","","","","2","99","99"},
        {"三角形", "の","二つの角","が等しいならば、","それらに対する","二つの辺","も互いに等しい。","","","","","","","","","","5","99","99"},
        {"三角形", "の","二つの角","が等しいならば、","それらに対する","二つの辺","も互いに等しい。","","","","","","","","","","99","99","99"},



        {"三角形ABC", "において","角ABC","と","角ACB","が等しいものとする。","","","","","","","","","","","0","99","99"},
        {"三角形ABC", "において","角ABC","と","角ACB","が等しいものとする。","","","","","","","","","","","2","99","99"},
        {"三角形ABC", "において","角ABC","と","角ACB","が等しいものとする。","","","","","","","","","","","4","99","99"},


        {"このとき、", "辺AB","が","辺AC","に等しいと主張する。","","","","","","","","","","","","1","99","99"},
        {"このとき、", "辺AB","が","辺AC","に等しいと主張する。","","","","","","","3","","","","","","99","99"},

        {"もし", "AB","が","AC","と等しくなければ","どちらかが","長いことになる。","","","","","","","","","","1","99","99"},
        {"もし", "AB","が","AC","と等しくなければ","どちらかが","長いことになる。","","","","","","","","","","3","99","99"},

        {"AB", "が","AC","より長いとすれば、","AC","と同じ長さの","直線DB","を切り取ることができる","[命題I-3]","","","","","","","","0","99","99"},
        {"AB", "が","AC","より長いとすれば、","AC","と同じ長さの","直線DB","を切り取ることができる","[命題I-3]","","","","","","","","2","99","99"},
        {"AB", "が","AC","より長いとすれば、","AC","と同じ長さの","直線DB","を切り取ることができる","[命題I-3]","","","","","","","","4","99","99"},
        {"AB", "が","AC","より長いとすれば、","AC","と同じ長さの","直線DB","を切り取ることができる","[命題I-3]","","","","","","","","6","99","99"},



        {"このとき、", "直線DC","を引く","[公準P-1]","","","","","","","","","","","","","1","99","99"},

        {"DB", "は","AC","と等しく、","BC","を共有しているから、","","","","","","","","","","","0","99","99"},
        {"DB", "は","AC","と等しく、","BC","を共有しているから、","","","","","","","","","","","2","99","99"},
        {"DB", "は","AC","と等しく、","BC","を共有しているから、","","","","","","","","","","","4","99","99"},


        {"DB", "、","BC","と","AC","、","CB","の","二辺","がそれぞれ等しく、","","","","","","","0","99","99"},
        {"DB", "、","BC","と","AC","、","CB","の","二辺","がそれぞれ等しく、","","","","","","","2","99","99"},
        {"DB", "、","BC","と","AC","、","CB","の","二辺","がそれぞれ等しく、","","","","","","","4","99","99"},
        {"DB", "、","BC","と","AC","、","CB","の","二辺","がそれぞれ等しく、","","","","","","","6","99","99"},
        {"DB", "、","BC","と","AC","、","CB","の","二辺","がそれぞれ等しく、","","8","","","","","","99","99"},



        {"角DBC", "と","角ACB","が等しい。","","","","","","","","","","","","","0","99","99"},
        {"角DBC", "と","角ACB","が等しい。","","","","","","","","","","","","","2","99","99"},

        {"よって、", "底辺DC","は","AB","と等しく、","三角形DBC","と","三角形ACB","は等しい","[命題I-4]","","","","","","","1","99","99"},
        {"よって、", "底辺DC","は","AB","と等しく、","三角形DBC","と","三角形ACB","は等しい","[命題I-4]","","","","","","","3","99","99"},
        {"よって、", "底辺DC","は","AB","と等しく、","三角形DBC","と","三角形ACB","は等しい","[命題I-4]","","","","","","","5","99","99"},
        {"よって、", "底辺DC","は","AB","と等しく、","三角形DBC","と","三角形ACB","は等しい","[命題I-4]","","","","","","","7","99","99"},

        {"これは", "小さいもの","と","大きいもの","が等しいことになり矛盾である","[公理A-5]","","","","","","","","","","","1","99","99"},
        {"これは", "小さいもの","と","大きいもの","が等しいことになり矛盾である","[公理A-5]","","","","","","","","","","","3","99","99"},

        {"したがって、", "AB","と","AC","は等しい。","","","","","","","","","","","","1","99","99"},
        {"したがって、", "AB","と","AC","は等しい。","","","","","","","","","","","","3","99","99"},

        {"ゆえに、", "三角形の","二つの角","が等しいならば、","それらに対する","二つの辺","も互いに等しい。","","","","","","","","","","2","99","99"},
        {"ゆえに、", "三角形の","二つの角","が等しいならば、","それらに対する","二つの辺","も互いに等しい。","","","","","","","","","","5","99","99"},

        {"これが証明すべきことであった。", "","","","","","","","","","","","","","","","99","99","99"},

        //{"", "","","","","","","","","","","99"},
    };

    //kouri---------------------------------------------------------------
    private string[,] ka1 = new string[,]//ka1w
    {
        {"公理a1","","","","","","","","","","","","","","","","99","99"},
        {"同じもの","に","等しいもの","は","互いに等しい。","","","","","","","","","","","","0","2"},
        {"同じもの","に","等しいもの","は","互いに等しい。","","","","","","","","","","","","2","99"},
        {"同じもの","に","等しいもの","は","互いに等しい。","","","","","","","","","","","","4","99"},
        {"同じもの","に","等しいもの","は","互いに等しい。","","","","","","","","","","","","99","99"},
    };
    private string[,] ka3 = new string[,]//ka3w
    {
        {"公理a3","","","","","","","","","","","","","","","","99","99"},
        {"等しいもの","から","等しいもの","を","引いた差","は","互いに等しい。","","","","","","","","","","0","2"},
        {"等しいもの","から","等しいもの","を","引いた差","は","互いに等しい。","","","","","","","","","","2","99"},
        {"等しいもの","から","等しいもの","を","引いた差","は","互いに等しい。","","","","","","","","","","4","99"},
        {"等しいもの","から","等しいもの","を","引いた差","は","互いに等しい。","","","","","","","","","","99","99"},

    };
    private string[,] ka4 = new string[,]//ka4w
    {
        {"公理a4","","","","","","","","","","","","","","","","99","99"},
        {"互いに重なり合うもの","は互いに等しい。","","","","","","","","","","","","","","","0","2"},
        {"互いに重なり合うもの","は互いに等しい。","","","","","","","","","","","","","","","99","99"},
    };
    private string[,] ka5 = new string[,]//ka5w
    {
        {"公理a5","","","","","","","","","","","","","","","","99","99"},
        {"全体","は","部分","より大きい。","","","","","","","","","","","","","0","2"},
        {"全体","は","部分","より大きい。","","","","","","","","","","","","","2","99"},
        {"全体","は","部分","より大きい。","","","","","","","","","","","","","99","99"},
    };
    //koujun------------------------------------------------------------------
    private string[,] kjp1 = new string[,]//kjp1w
    {
        {"公準p1","","","","","","","","","","","","","","","","99","99"},
        {"任意の点","から","任意の点","へ","直線","を引くこと。","","","","","","","","","","","0","2"},
        {"任意の点","から","任意の点","へ","直線","を引くこと。","","","","","","","","","","","2","99"},
        {"任意の点","から","任意の点","へ","直線","を引くこと。","","","","","","","","","","","4","99"},
        {"任意の点","から","任意の点","へ","直線","を引くこと。","","","","","","","","","","","99","99"},
    };
    private string[,] kjp2 = new string[,]//kjp2w
    {
        {"公準p2","","","","","","","","","","","","","","","","99","99"},
        {"任意の直線","を連続して延ばすこと。","","","","","","","","","","","","","","","0","2"},
        {"任意の直線","を連続して延ばすこと。","","","","","","","","","","","","","","","99","99"},
    };
    private string[,] kjp3 = new string[,]//kjp3w
    {
        {"公準p3","","","","","","","","","","","","","","","","99","99"},
        {"任意の中心","と","任意の半径","の","円","を描くこと。","","","","","","","","","","","0","2"},
        {"任意の中心","と","任意の半径","の","円","を描くこと。","","","","","","","","","","","2","99"},
        {"任意の中心","と","任意の半径","の","円","を描くこと。","","","","","","","","","","","4","99"},
        {"任意の中心","と","任意の半径","の","円","を描くこと。","","","","","","","","","","","99","99"},
    };
    //teigi 2tu
    private string[,] tdi1 = new string[,]//tdi1w
    {
        {"定義di1","","","","","","","","","","","","","","","","99","99"},
        {"点","は","部分","をもたないものである。","","","","","","","","","","","","","0","2"},
        {"点","は","部分","をもたないものである。","","","","","","","","","","","","","99","99"},
    };
    private string[,] tdi15 = new string[,]//tdi5w
   {
        {"定義di15","","","","","","","","","","","","","","","","99","99"},
        {"円","とは","周と呼ばれる一つの線","の境界で囲まれた平面図形であって、","","","","","","","","","","","","","0","2"},
        {"円","とは","周と呼ばれる一つの線","の境界で囲まれた平面図形であって、","","","","","","","","","","","","","2","99"},
        {"その中にある一つの点","から","円周上の点","に","引かれた直線","の長さがすべて等しいようなものである。","","","","","","","","","","","0","99"},
        {"その中にある一つの点","から","円周上の点","に","引かれた直線","の長さがすべて等しいようなものである。","","","","","","","","","","","2","99"},
        {"その中にある一つの点","から","円周上の点","に","引かれた直線","の長さがすべて等しいようなものである。","","","","","","","","","","","6","99"},
        {"その中にある一つの点","から","円周上の点","に","引かれた直線","の長さがすべて等しいようなものである。","","","","","","","","","","","99","99"},
   };


    //kyochouPanel(int count) ------------------------------------------------------------------------------
    void kyochouPanel(int count1,int count2,int count3) 
    {
       
        for (int i = 0; i < kodomoTextText.Count; i++) 
        {
            mojiPanel[i].GetComponent<Image>().enabled = false;
        }
        
        if (count1!=99) 
        {
            //k7_1_2:オブジェを見えるようにするよ。
            //共通変数の kyotuEla.tenmetuOnOffで点滅処理
            mojiPanel[count1].GetComponent<Image>().enabled = kyotuEla.tenmetuOnOff;///
        }
        if (count2 != 99) 
        {
            //k7_1_2:オブジェを見えるようにするよ。
            //共通変数の kyotuEla.tenmetuOnOffで点滅処理
            mojiPanel[count2].GetComponent<Image>().enabled = kyotuEla.tenmetuOnOff;///
        }
        if (count3 != 99) {
            //k7_1_2:オブジェを見えるようにするよ。
            //共通変数の kyotuEla.tenmetuOnOffで点滅処理
            mojiPanel[count3].GetComponent<Image>().enabled = kyotuEla.tenmetuOnOff;///
        }

    }
    //Uitextの中身----------------------------------------------------------------------------------------------------
    //3次元配列
   
}
