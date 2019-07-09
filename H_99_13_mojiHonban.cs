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
    
    
    

    //{"命題I-1","","","","","","","","","","","99"},
    //                {"与えられた直線", "を","一辺","とする","正三角形","を作図する事。","","","","","","0"},
    //                {"与えられた直線", "を","一辺","とする","正三角形","を作図する事。","","","","","","2"},
    //                {"与えられた直線", "を","一辺","とする","正三角形","を作図する事。","","","","","","4"},
    //                {"与えられた直線", "を","一辺","とする","正三角形","を作図する事。","","","","","","99"},
    
    //k0016_99_1_1：listの宣言
    private List<string> M1 = new List<string>();

    void Start() 
    {
        //2次元配列にmojipanelに入れる文字をセットする。
        //setWord();

        for (int i = 0; i < m1_0.GetLength(0); i++) 
        {
            //k0016_99_2_1_1：2次元list [0][],[1][]をつくる
            kariList.Add(new List<string>());

            for (int j=0; j<m1_0.GetLength(1);j++) 
            {
                kariList[i].Add(m1_0[i,j]);
            }
        }
        //Debug.Log(intValues.GetLength(0)+"::"+ intValues.GetLength(1));


        

        //kariList.Add(meidaiSita);
        //for (int i=0;i<meidaiSita.Count;i++) 
        //{
          //  kariList[0].Add(meidaiSita[i]);
        //}


        //Debug.Log("OKK::"+ kariList[0][1]);
        //Debug.Log("OKK::");



        ////4元目に3元目を当てはめる
        ////>bunsho[0]を作成 定義　0
        //bunsho.Add(new List<List<List<string>>>());
        ////>bunsho[1]を作成　公準　1
        //bunsho.Add(new List<List<List<string>>>());
        ////>bunsho[2]を作成　公理　2
        //bunsho.Add(new List<List<List<string>>>());
        ////>bunsho[3]を作成　meidai　3
        //bunsho.Add(new List<List<List<string>>>());

        ////3元目に2元目を当てはめる
        ////>bunsho[0][0]を作成
        //bunsho[0].Add(new List<List<string>>());
        ////>bunsho[0][1]を作成
        //bunsho[0].Add(new List<List<string>>());

        //3元目に2元目を当てはめる
        //>bunsho[3][0]を作成 meidai 1～6までの6個のmeidaiに対応

        //for(int i=0; i<6;i++) 
        //{
        //    bunsho[3].Add(new List<List<string>>());
        //}
        ///k0016_99_1_1_6　：List 直接値をいれて定義する。
        //private List<float> meidaiSita = new List<float> { 8.05f, 15.2f,8.9f,4.9f,12.3f,10.0f };




        ////2元目に1元目を当てはめる
        ////>bunsho[0][0][0]を作成
        //bunsho[0][0].Add(new List<string>());
        ////>bunsho[0][0][1]を作成
        //bunsho[0][0].Add(new List<string>());
        ////>bunsho[0][0][2]を作成
        //bunsho[0][0].Add(new List<string>());

        //2元目に1元目を当てはめる　meidai１の文章数13
        //>bunsho[3][0][0]～[3][0][12]を作成 meidai1の文章 1～13に対応
        //for (int i = 0; i < 13; i++) 
        //{
        //    bunsho[3][0].Add(new List<string>());
        //}
        //bunsho[3][0]

        //bunsho[3][0] ={ { 0,1},{ 0,1} };

        //1元目にデータを当てはめる
        //bunsho[0][0][0][0]を作成
        //bunsho[0][0][0].Add("4jigen");


        //Debug.Log("やりなおし::"+ bunsho[0][0][0][0]);
        //配列に解説文を割り当てる。
        //setWord();
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
    ///k0016_99_1_1_6　：List 直接値をいれて定義する。
    //List<string> meidaiSita1_1 = new List<string>
    //{"命題I-1","","","","","","","","","","","99"};

    private int kyouchouHenkanInt;
    void Update() 
    {
        if (Input.GetKeyDown("0")) 
        {
            kyotu.mojiSwitch = 0;
        } 
        else if (Input.GetKeyDown("1")) 
        {
            kyotu.mojiSwitch = 1;
        } 
        else if (Input.GetKeyDown("2")) 
        {
            kyotu.mojiSwitch = 2;
        } 
        else if (Input.GetKeyDown("3")) 
        {
            kyotu.mojiSwitch = 3;
        }

        //kyotu.rrCountの数を増やす
        if (Input.GetMouseButtonDown(0))
            kyotu.rrCount++;

        else if (Input.GetMouseButtonDown(1)) 
        {
            kyotu.MCount++;
            kyotu.rrCount = 0;
        }

        //UItextに2次元配列の値を入れていく＞＞ここだけいちいち変える必要が有る
        for (int i = 0; i < kodomoTextText.Count; i++) 
        {

            if (kyotu.rrCount < m1_0.GetLength(0)) 
            {
                //mojipanelの各UItextに文字を代入していく
                kodomoTextText[i].text = kariList[kyotu.rrCount][i];
            } 
            else 
            {
                //最終行を出力し続ける:mojipanelの各UItextに文字を代入していく
                kodomoTextText[i].text = kariList[m1_0.GetLength(0) - 1][i];
            }
        }//Debug.Log(intValues[intValues.GetLength(0)-1, intValues.GetLength(1)-1]);

        //文字が入った配列の情報から、強調すべき文字の順番をintで得る
        //k10_2:strin>int変換
        if(kyotu.rrCount< m1_0.GetLength(0))
        kyouchouHenkanInt = int.Parse(m1_0[kyotu.rrCount, m1_0.GetLength(1) - 1]);
        //てきすとの強調kyochouPanel(kyouchouHenkanInt);でどこも強調しない数値99
        //kyouchouHenkanInt = 99;

        //強調すべきパネルを強調するメソッド
        kyochouPanel(kyouchouHenkanInt);///
        Debug.Log("okkkkkk");

    }
    //Uitextの中身----------------------------------------------------------------------------------------------------
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
        {"命題I-1","","","","","","","","","","","99"},
      {"与えられた直線", "を","一辺","とする","正三角形","を作図する事。","","","","","","0"},
        {"与えられた直線", "を","一辺","とする","正三角形","を作図する事。","","","","","","2"},
        {"与えられた直線", "を","一辺","とする","正三角形","を作図する事。","","","","","","4"},
        {"与えられた直線", "を","一辺","とする","正三角形","を作図する事。","","","","","","99"},
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
