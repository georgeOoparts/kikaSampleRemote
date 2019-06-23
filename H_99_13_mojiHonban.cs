//using NUnit.Framework;
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

    //List<List<string>> listlist = new List<Text>();

    //listlist[x][y];
    //List<List<string>> momonew =new List<< List<string> > ();

    //List<List<string>> dictionary = new List<List<string>>();
    //List<List> dic = new List<List>();

    //List list1 = new List<string>();
    //List list2 = new List<string>();

    //4次元listを定義
    List<List<List<List<string>>>> dictionary = new List<List<List<List<string>>>>();
    //List<string> dictionary0 = new List<string>();
    void Start() 
    {
        //dic.Add(list1);
        //dic.Add(list2);
        //dictionary[0][0] ="wow";
        //dictionary[0][1] = "011111111111";
        //dictionary[1][0] = "100000000000";
        //dictionary = new List<List<string>>()
        //{
        //    // Listの中にListを追加
        //    new List<string>() { "apple", "action", "after" },  // 'a'で始まる単語のList
        //    new List<string>() { "big", "best", "bridge" },     // 'b'で始まる単語のList
        //    new List<string>() { "cheese", "cat", "connect" },  // 'c'で始まる単語のList
        //};
        
        //4元目に3元目を当てはめる
        //>dictionary[0]を作成
        dictionary.Add(new List<List<List<string>>>());
        //>dictionary[1]を作成
        dictionary.Add(new List<List<List<string>>>());
        //>dictionary[2]を作成
        dictionary.Add(new List<List<List<string>>>());

        //3元目に2元目を当てはめる
        //>dictionary[0][0]を作成
        dictionary[0].Add(new List<List<string>>());
        //>dictionary[0][1]を作成
        dictionary[0].Add(new List<List<string>>());

        //2元目に1元目を当てはめる
        //>dictionary[0][0][0]を作成
        dictionary[0][0].Add(new List<string>());
        //>dictionary[0][0][1]を作成
        dictionary[0][0].Add(new List<string>());
        //>dictionary[0][0][2]を作成
        dictionary[0][0].Add(new List<string>());

        //1元目にデータを当てはめる
        //dictionary[0][0][0][0]を作成
        dictionary[0][0][0].Add("4jigen");
        

        Debug.Log("やりなおし::"+dictionary[0][0][0][0]);
        //配列に解説文を割り当てる。
        //setWord();
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
        //stopwatch.Start();
    }


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



        //Debug.Log("やりなおし"+kyotu.mojiSwitch);
        //Debug.Log(kyotuEla.elapse+"OKKKKKKdesuka2222"+kyotuEla.tenmetuOnOff);
        
        //k6_ac:何秒たったかを変数elapseに入れる
        //elapse = (float)stopwatch.Elapsed.TotalSeconds;

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


        //UItextに2次元配列の値を入れていく＞＞ここだけいちいち変える必要が有る
        for (int i = 0; i < kodomoTextText.Count; i++) 
        {
            //mojiを並べる3次元配列なので要素をおVERするとすぐにエラーになる。
            //k0017_99_2_1:2次元配列　最初の要素の個数を得る
            //if (kyotu.rrCount < intValues.GetLength(1) && kyotu.MCount < intValues.GetLength(0)) 
            //{
                //kodomoTextText[i].text = intValues[kyotu.MCount, kyotu.rrCount, i];
            //}

            //クリックしていき最後の文字列にたどり着いたら、後は同じ表示をし続ける。
            //>meidai１、の場合　最後の文字列はrrcount４　最後の文字列を表示し続ける。
            //＞＞
            //if (kyotu.MCount==0 && kyotu.rrCount>=4) 
            //{
              //  kodomoTextText[i].text = intValues[kyotu.MCount,4, i];
            //}
            




        }
        

        //強調すべきパネルを強調するメソッド
        //kyochouPanel(kyouchouHenkanInt);///
        //Debug.Log("OKKKKKK");
        

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
            //共通変数の kyotuEla.tenmetuOnOffで点滅処理
            mojiPanel[count].GetComponent<Image>().enabled = kyotuEla.tenmetuOnOff;///
        }
            
    }
    //Uitextの中身----------------------------------------------------------------------------------------------------
    //3次元配列
   
}
