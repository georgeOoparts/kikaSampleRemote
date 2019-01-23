﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;//UI使うときはこれなきゃ駄目

public class u0001_screenPointText : MonoBehaviour {
    //k2_1:どこかに書かれている。Textというクラスを扱うための変数を作成
    Text text;

    void Start() {
        //k2_1_1:Textをこのオブジェクトで使うためのおまじない
        text = this.gameObject.GetComponent<Text>();
    }

    void Update() {
        //k2_1_1_1:text.text = "・・・ "でTEXTのないよう変更。
        //k0003_2:Input.mousePosition.ToString()でマウスのスクリーンポイントを
        //string形式で代入
        ////?
        text.text = "screen:: " + Input.mousePosition.ToString();
    }
}