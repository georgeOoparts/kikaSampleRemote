using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class testPrehubYobi2 : MonoBehaviour
{
    //uitext のプレハブ //canvasはプレハブ化せずにおく、publicにはしておく

    //k5_3_1_1:gameobject(メソッド、変数)を使いまわす
    //このスクリプトをアタッチしたオブジェクトにいちいちこのオブジェクトをアタッチ
    public H_99_01_kyoutuHensu kyotu;

    //k0014_2 :プレハブ（画面のobjでもOK）を使う objにはりつけ
    public GameObject premoji;

    //k0016_99_1_1：listの宣言
    //prehubとして呼び出したmojipanelに当てはめるオブジェ
    List<GameObject> mojiPanel= new List<GameObject>();

    //mojipanelの子オブジェtextに当てはめるオブジェ
    List<GameObject> kodomoTextObj = new List<GameObject>();

    //textオブジェのコンポTEXTに当てはめるText変数
    List<Text> kodomoTextText = new List<Text>();

    void Start()
    {

        for (int i = 0; i < 7; i++) 
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
            kodomoTextObj[i].name = "text"+i;

        }


    }
    //k7_1_1:オブジェを存在するけど見えなくする。
    //this.gameObject.GetComponent<Image>().enabled = false;

    //k7_1_2:オブジェを見えるようにするよ。
    //this.gameObject.GetComponent<Image>().enabled = true;
    void Update()
    {
        for (int i = 0; i < kodomoTextText.Count; i++) 
        {
            kodomoTextText[i].text = content(i, kyotu.rrCount);
            //k7_1_2:オブジェを見えるようにするよ。
            //mojiPanel[i].GetComponent<Image>().enabled = true;
        }
        //強調すべきパネルを強調するメソッド
        kyochouPanel(kyotu.rrCount);
        //kyotu.rrCountの数を増やす
        if (Input.GetMouseButtonDown(0)) kyotu.rrCount++;
    }
    void kyochouPanel(int count) 
    {
        if (count == 0) 
        {
            //k7_1_2:オブジェを見えるようにするよ。
            mojiPanel[1].GetComponent<Image>().enabled = true;
        }
        else if(count == 1)
        {
            for (int i=0;i<kodomoTextText.Count;i++) 
            {
                mojiPanel[i].GetComponent<Image>().enabled = false;
            }
            
            //k7_1_2:オブジェを見えるようにするよ。
            mojiPanel[1].GetComponent<Image>().enabled = true;


        } 
        else if (count == 2) 
        {
            for (int i = 0; i < kodomoTextText.Count; i++) 
            {
                mojiPanel[i].GetComponent<Image>().enabled = false;
            }
            //k7_1_2:オブジェを見えるようにするよ。
            mojiPanel[3].GetComponent<Image>().enabled = true;
        } 
        else if (count == 3) 
        {
            for (int i = 0; i < kodomoTextText.Count; i++) 
            {
                mojiPanel[i].GetComponent<Image>().enabled = false;
            }
            //k7_1_2:オブジェを見えるようにするよ。
            mojiPanel[5].GetComponent<Image>().enabled = true;
        } 
        else if (count == 4) 
        {
            for (int i = 0; i < kodomoTextText.Count; i++) 
            {
                mojiPanel[i].GetComponent<Image>().enabled = false;
            }
            //k7_1_2:オブジェを見えるようにするよ。
            mojiPanel[1].GetComponent<Image>().enabled = true;
        } 
        else if (count == 5) 
        {
            for (int i = 0; i < kodomoTextText.Count; i++) 
            {
                mojiPanel[i].GetComponent<Image>().enabled = false;
            }
            //k7_1_2:オブジェを見えるようにするよ。
            mojiPanel[3].GetComponent<Image>().enabled = true;
        } 
        else if (count == 6) 
        {
            for (int i = 0; i < kodomoTextText.Count; i++) 
            {
                mojiPanel[i].GetComponent<Image>().enabled = false;
            }
            //k7_1_2:オブジェを見えるようにするよ。
            mojiPanel[5].GetComponent<Image>().enabled = true;
        }
    }
    string content(int textNumber, int count) {
        string content = "";
        if (textNumber == 0) {
            if (count == 0) content = "三角形";
            else if (count == 1|| count == 2|| count == 3) content = "点";
            else content = "";
        } else if (textNumber == 1) {
            if (count == 0) content = "ABC";
            else if (count == 1|| count == 2|| count == 3) content = "A";
            else if (count == 4 || count == 5 || count == 6) content = "垂線";
            else content = "";
        } else if (textNumber == 2) {
            if (count == 0) content = "がある。";
            else if (count == 1 || count == 2 || count == 3) content = "から辺";
            else if (count == 4 || count == 5 || count == 6) content = "と辺";
            else content = "";
        } else if (textNumber == 3) {
            if (count == 0) content = "";
            else if (count == 1 || count == 2 || count == 3) content = "BC";
            else if (count == 4 || count == 5 || count == 6) content = "BC";
            else content = "";
        } else if (textNumber == 4) {
            if (count == 0) content = "";
            else if (count == 1 || count == 2 || count == 3) content = "に";
            else if (count == 4 || count == 5 || count == 6) content = "の交点を";
            else content = "";
        } else if (textNumber == 5) {
            if (count == 0) content = "";
            else if (count == 1 || count == 2 || count == 3) content = "垂線";
            else if (count == 4 || count == 5 || count == 6) content = "P";
            else content = "";
        } else if (textNumber == 6) {
            if (count == 0) content = "";
            else if (count == 1 || count == 2 || count == 3) content = "を引く";
            else if (count == 4 || count == 5 || count == 6) content = "と名づける";
            else content = "";
        }
        return (content);
    }


}
