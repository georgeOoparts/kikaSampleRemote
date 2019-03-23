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
    List<GameObject> ptp= new List<GameObject>();

    //mojipanelの子オブジェtextに当てはめるオブジェ
    List<GameObject> kodomoObj = new List<GameObject>();

    //textオブジェのコンポTEXTに当てはめるText変数
    List<Text> kodomoText = new List<Text>();

    void Start()
    {

        for (int i = 0; i < 7; i++) {
            //プレハブを使う
            //k0016_99_1_1_1：list新しい値を入れる
            ptp.Add(Instantiate(premoji) as GameObject);
            //premojiの子供オブジェであるtextをlistにする。
            kodomoObj.Add(ptp[i].transform.GetChild(0).gameObject);
            ////premojiの子供オブジェであるtextのコンポートメントであるTextをlistにする。
            kodomoText.Add(kodomoObj[i].GetComponent<Text>());
            
            //k0014_2_1_1 :プレハブをtextPanelの子供にする()
            ptp[i].transform.SetParent(this.gameObject.transform, false);

            //k0014_2_1_1: オブジェの名前を変化させる
            ptp[i].name = "ptp"+i;
            kodomoObj[i].name = "text"+i;

        }


        //Debug.Log("OKKKKKK");   
    }

    // Update is called once per frame
    void Update()
    {
        for (int i = 0; i < 7; i++) {
            kodomoText[i].text = content(i, kyotu.rrCount);
        }

        if (Input.GetMouseButtonDown(0)) kyotu.rrCount++;
    }
    string content(int textNumber, int count) {
        string content = "";
        if (textNumber == 0) {
            if (count == 0) content = "三角形";
            else if (count == 1) content = "点";
            else content = "";
        } else if (textNumber == 1) {
            if (count == 0) content = "ABC";
            else if (count == 2) content = "A";
            else if (count == 3) content = "垂線";
            else content = "";
        } else if (textNumber == 2) {
            if (count == 0) content = "がある。";
            else if (count == 1) content = "から辺";
            else if (count == 2) content = "と辺";
            else content = "";
        } else if (textNumber == 3) {
            if (count == 0) content = "";
            else if (count == 1) content = "BC";
            else if (count == 2) content = "BC";
            else content = "";
        } else if (textNumber == 4) {
            if (count == 0) content = "";
            else if (count == 1) content = "に";
            else if (count == 2) content = "の交点を";
            else content = "";
        } else if (textNumber == 5) {
            if (count == 0) content = "";
            else if (count == 1) content = "垂線";
            else if (count == 2) content = "Ｐ";
            else content = "";
        } else if (textNumber == 6) {
            if (count == 0) content = "";
            else if (count == 1) content = "を引く";
            else if (count == 2) content = "と名づける";
            else content = "";
        }
        return (content);
    }


}
