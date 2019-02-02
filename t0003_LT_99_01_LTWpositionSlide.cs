using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class t0003_LT_99_01_LTWpositionSlide : MonoBehaviour{
    //マウスのスクリーンとワールド座標を表示するUIテキストの位置を決定するプログラム
    //空のオブジェを作りそれにアタッチ。そしてその空のオブジェを左上アンカーシフト固定
    //この空のオブジェに、ワールドとスクリーンのTEXTをいれるべし
    //インスペから2つのオブジェを指定する。

    //文字の長さとの縮尺調整は別のプログラムをそれぞれのオブジェに貼り付ける必要あり
    //スクリーンワールド座標を得るには別のプログラムをそれぞれに貼り付ける必要あり

    //k0014_1 :プレハブを使う objにはりつけ
    public GameObject textScreenObj;
    //textScreenObjの下に張るtextWorldObj
    public GameObject textWorldObj;

    //k4_a:どこかに書いてあるRectTransformの変数を作る
    RectTransform TextScreenRt;
    RectTransform TextWorldRt;

    //k2_a:どこかに書かれている。Textというクラスを扱うための変数を作成
    Text textScreenTx;

    void Start(){
        //k4_aa:このオブジェクトにＵＩ専門であるRectTransformをアタッチ
        TextScreenRt = textScreenObj.GetComponent<RectTransform>();
        TextWorldRt= textWorldObj.GetComponent<RectTransform>();

        //k2_aa:Textをこのオブジェクトで使うためのおまじない
        textScreenTx = textScreenObj.GetComponent<Text>();
    }

   void Update(){
        //k4_aac1:uiをスクリーン値で移動（左上にアンカーセット、下方向は-の値)
        TextScreenRt.anchoredPosition = new Vector2(0, 0);

        //一番左上のltTextの高さだけ下にポジショニング
        //k2_aab2:スクリーン座標のテキスト高さ text.preferredHeight 
        //k4_aac1:uiをスクリーン値で移動（左上にアンカーセット、下方向は-の値)
        TextWorldRt.anchoredPosition = new Vector2(0, -textScreenTx.preferredHeight);
    }
}
