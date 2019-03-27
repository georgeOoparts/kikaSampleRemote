using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class testPrehubNarabe : MonoBehaviour
{
    //uiTEXT７つをuiPANELの中で並び替え

    //k5_3_1_1:gameobject(メソッド、変数)を使いまわす
    //このスクリプトをアタッチしたオブジェクトにいちいちこのオブジェクトをアタッチ
    public H_99_01_kyoutuHensu kyotu;

    //k0014_2 :プレハブ（画面のobjでもOK）を使う objにはりつけ
    public GameObject premoji;

    //k0016_99_1_1：listの宣言
    //prehubとして呼び出したmojipanelに当てはめるオブジェ
    List<GameObject> mojiPanel = new List<GameObject>();

    //mojipanelの子オブジェtextに当てはめるオブジェ
    List<GameObject> kodomoTextObj = new List<GameObject>();

    //textオブジェのコンポTEXTに当てはめるText変数
    List<Text> kodomoTextText = new List<Text>();

    //mojipanelのrecttransformを入れる変数
    //k4_1:どこかに書いてあるRectTransformの変数を作る
    List<RectTransform> rtMojiPanel = new List<RectTransform>();

    //前のパネルの幅、を入れる変数。
    float textLineWidth = 0;

    //panel1～7の開始位置
    float p0Start = 0;
    float p1Start = 0;
    float p2Start = 0;
    float p3Start = 0;
    float p4Start = 0;
    float p5Start = 0;
    float p6Start = 0;

    //List<float> panelStrat = new List<float>();
    float startWidth = 0;

    void Start()
    {
        //プレハブの呼び出しはtextPrehubYobiでやっている
        //そっちのプログラムを先に呼び込むように設定する。
        for (int i = 0; i < 7; i++) {
            //k0016_99_1_1_1：list新しい値を入れる
            ///別プログラムで呼び出されたmojipanelオブジェを当てはめる
            mojiPanel.Add(GameObject.Find("mojiPanel" + i).gameObject);
            ///premojiの子供オブジェであるtextをlistにする。
            kodomoTextObj.Add(mojiPanel[i].transform.GetChild(0).gameObject);
            ///premojiの子供オブジェであるtextのコンポートメントであるTextをlistにする。
            kodomoTextText.Add(kodomoTextObj[i].GetComponent<Text>());
            ///mojipanelオブジェのRectTransformを当てはめる
            rtMojiPanel.Add(mojiPanel[i].GetComponent<RectTransform>());
        }
        


        //if (i == 0) 
        //{
        //    p1Start = 0;
        //    //startWidth += trMojiPanel[i].sizeDelta.x;
        //} 
        //else {
        //    startWidth += trMojiPanel[i - 1].sizeDelta.x;
        //    panelStrat[i] = startWidth;
        //}
        //------
        //mojipanelを実際に代入----
        //trMojiPanel[i].anchoredPosition = new Vector2(panelStrat[i], 0);
        //------------

        //Debug.Log("we::"+mojiPanel[0].name+"width::"+ rtMojiPanel[0].sizeDelta.x);        
    }
    private bool one = true;
    void Update()
    {
        //Debug.Log("we::" + mojiPanel[0].name + "width::" + rtMojiPanel[0].sizeDelta.x);
        //if (one == true) {
            //mojipanelのスタート位置を代入---
            p0Start = 0;
            rtMojiPanel[0].anchoredPosition = new Vector2(p0Start, 0);
            //startWidth = rtMojiPanel[0].sizeDelta.x;

            p1Start = rtMojiPanel[0].sizeDelta.x;
            rtMojiPanel[1].anchoredPosition = new Vector2(p1Start, 0);

            p2Start = rtMojiPanel[0].sizeDelta.x + rtMojiPanel[1].sizeDelta.x;
            rtMojiPanel[2].anchoredPosition = new Vector2(p2Start, 0);
        //}
        one = false;

        //for (int i = 0; i < 7; i++) {


        //}
        ////k4_aac1:uiをスクリーン値で移動（左上にアンカーセット、下方向は-の値)
        ////ＰＡＮＥＬ１をＴＥＸＴＰＮＥＬの左上へ置く。
        //mojiPanel[0].anchoredPosition = new Vector2(0, 0);

        ////パネル２の開始位置を決める。ｙ軸は下方向マイナスである事に注意 
        //rt2.anchoredPosition
        //    = new Vector2(p2Start, -p2Kaigyou * rt1.sizeDelta.y);

        //rt3.anchoredPosition
        //    = new Vector2(p3Start, -p3Kaigyou * rt1.sizeDelta.y);

        ////Debug.Log(p4Kaigyou);
        ////パネル4の開始位置を決める。ｙ軸は下方向マイナスである事に注意
        //rt4.anchoredPosition
        //    = new Vector2(p4Start, -p4Kaigyou * rt1.sizeDelta.y);

        ////Debug.Log(p5Kaigyou);
        ////パネル5の開始位置を決める。ｙ軸は下方向マイナスである事に注意
        //rt5.anchoredPosition
        //    = new Vector2(p5Start, -p5Kaigyou * rt1.sizeDelta.y);

        ////パネル6の開始位置を決める。ｙ軸は下方向マイナスである事に注意
        //rt6.anchoredPosition
        //    = new Vector2(p6Start, -p6Kaigyou * rt1.sizeDelta.y);

        ////パネル6の開始位置を決める。ｙ軸は下方向マイナスである事に注意
        //rt7.anchoredPosition
        //    = new Vector2(p7Start, -p7Kaigyou * rt1.sizeDelta.y);

    }
}
