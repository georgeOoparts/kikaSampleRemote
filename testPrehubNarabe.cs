﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class testPrehubNarabe : MonoBehaviour
{
    //uiTEXT７つをuiPANELの中で並び替え

    //k5_3_1_1:gameobject(メソッド、変数)を使いまわす
    //このスクリプトをアタッチしたオブジェクトにいちいちこのオブジェクトをアタッチ
    public H_99_01_kyoutuHensu kyotu;

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
        //textpanelのRectTransformを得る
        rtTextPanel = this.gameObject.GetComponent<RectTransform>();
    }
    //startWidth += rtMojiPanel[i].sizeDelta.x;の
    //startWidthが無限に増えないようにするため。
    //わかりにくいが、updateを2回、回さないといけない
    //update1回目ではmojipanelの幅がなぜか全て175になってしまう。
    //update2週目で初めてtext＋設定した余裕の幅になる。
    //turnCountはupdate2回目のみで処理を流すための変数
    private int turnCount=0;
    
    //mojipanelのスタート位置のための変数
    float startWidth = 0;
    
    //kaigyouのため
    //mojipanelの合計がtextpanelを超えるか判定する変数
    float hanteiWidth = 0;
    
    //debuglogの為の変数
    private int k = 0;

    private int pKaigyou = 0;
    
    //このオブジェtextpanelのコンポを入れる変数
    RectTransform rtTextPanel;

    void Update()
    {
        //turncountが０では駄目。2回updateを読み込む必要がある
        if (turnCount==1) 
        {
            //startwizeを０に初期化。
            startWidth = 0;
            //pKaigyouを初期化
            pKaigyou = 0;
            //hanteiWidthを初期化
            hanteiWidth = 0;
            for (int i = 0; i<rtMojiPanel.Count; i++) 
            {
                //パネルの位置調整
                //下方向は-なので、-rtMojiPanel[0].sizeDelta.y*pKaigyou
                //Debug.Log(rtMojiPanel[0].sizeDelta.y);
                rtMojiPanel[i].anchoredPosition = new Vector2(startWidth, -rtMojiPanel[0].sizeDelta.y*pKaigyou);
                //mojipanelのスタート位置を代入---
                startWidth += rtMojiPanel[i].sizeDelta.x;

                //kaigyouのため＞hanteiWidthにこれまでのmojipanelの幅と次のmojipanelの幅を入れる
                //最後のmojipanelの１つ前の段階で判定が終了するのでrtMojiPanel.Count-1までとなる
                if (i< rtMojiPanel.Count-1) hanteiWidth= startWidth+ rtMojiPanel[i+1].sizeDelta.x;

                //kaigyouのため判定
                if (rtTextPanel.sizeDelta.x < hanteiWidth) 
                {
                    pKaigyou = pKaigyou + 1;
                    startWidth = 0;
                }
            }
        }turnCount++;
        //ボタンクリックで再びmojipanel並びなおし
        if (Input.GetMouseButtonDown(0)) turnCount = 0;
        //debuglogのためのk++
        k++;
    }
}
