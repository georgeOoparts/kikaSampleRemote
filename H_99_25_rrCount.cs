using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class H_99_25_rrCount : MonoBehaviour
{
    //いちいちunityで当てはめなきゃ駄目　↓---------------

    //k5_3_1_1:gameobject(メソッド、変数)を使いまわす
    public H_99_01_kyoutuHensu kyotu;

    //k2_1:どこかに書かれている。Textというクラスを扱うための変数を作成
    Text text;
    
    void Start()
    {
        //k2_1_1:Textをこのオブジェクトで使うためのおまじない
        text = this.gameObject.GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        //k2_1_1_1:text.text = "・・・ "でTEXTのないよう変更。
        text.text = kyotu.rrCount.ToString();
        //Debug.Log("25rrCount::"+kyotu.rrCount);
    }
}
