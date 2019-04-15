using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class H_99_11_zukeiRR1 : MonoBehaviour
{
    //オブジェRRの子供＞RR1にアタッチ
    //１　線で3角形を表示
    //２　１の三角形で使う記号の文字を表示

    //k0014_1 :プレハブ（画面のobjでもOK）を使う objにはりつけ--------
    //プレハブで線のオブジェを呼び出す
    public GameObject line;
    
    //プレハブで文字のオブジェを呼び出す
    public GameObject preMoji;

    //呼び出したmojiの親オブジェにするオブジェ。
    public GameObject zukei;

    //プレハブから呼び出したlineを実際に当てはめる変数----------------
    //線のオブジェを当てはめるlist
    List<GameObject> L = new List<GameObject>();

    //k0015_99_1 :線を引くline回り　オブジェにラインをくっつける
    List<LineRenderer> LR = new List<LineRenderer>();
    
    //文字オブジェ関係のlist-----------------------------------------
    //文字のオブジェを当てはめるlist
    List<GameObject> gPreMoji = new List<GameObject>();
    
    //文字のオブジェのtextを当てはめるlist
    List<Text> textMoji=new List<Text>();

    //文字のオブジェのrecttransformを当てはめるlist
    List<RectTransform> rtPreMoji = new List<RectTransform>();
    //---------------------------------------------------------------

    //lineで作った三角形全体を上下に移動させる変数
    public float upDown = 1;

    void Start()
    {
        for (int i= 0;i< 3;i++) 
        {
            //k0014_1_1 :プレハブを使う
            L.Add(Instantiate(line) as GameObject);

            gPreMoji.Add(Instantiate(preMoji)as GameObject);

            //k0014_2_1_1 :プレハブをキャンバスの子供にする()
            L[i].transform.SetParent(this.gameObject.transform, false);

            gPreMoji[i].transform.SetParent(zukei.transform, false);

            //プレハブから呼び出したオブジェに名前をつける
            L[i].name = "line"+i;

            gPreMoji[i].name = "moji" + i;

            //k0015_99_1 :線を引くline回り　オブジェにラインをくっつける
            LR.Add(L[i].GetComponent<LineRenderer>());
           
            //k0015_99_1_2 :頂点の数（この場合２つ）
            LR[i].positionCount = 2;

            //k2_1_1:Textをこのオブジェクトで使うためのおまじない
            //text = this.gameObject.GetComponent<Text>();
            //k0016_99_1_1_1：list新しい値を入れる
            textMoji.Add(gPreMoji[i].transform.GetChild(0).gameObject.GetComponent<Text>());

            //rtMoji.Add(gMoji[i].GetComponent<RectTransform>());

        }
    }

    void Update()
    {
        //k0015_99_1_3 :頂点を設定（どこからどこまで線を伸ばすか）
        LR[0].SetPosition(0, new Vector3(9.2f, 0f+upDown, -3f));
        LR[0].SetPosition(1, new Vector3(13.2f, 0f + upDown, -3f));

        LR[1].SetPosition(0, new Vector3(13.2f, 0f + upDown, -3f));
        LR[1].SetPosition(1, new Vector3(11.2f, 3.46f + upDown, -3f));

        LR[2].SetPosition(0, new Vector3(11.2f, 3.46f + upDown, -3f));
        LR[2].SetPosition(1, new Vector3(9.2f, 0f + upDown, -3f));

        //k2_1_1_1:text.text = "・・・ "でTEXTのないよう変更。
        //text.text = "k2_1_TextContentChange";
        textMoji[0].text = "A";
        textMoji[1].text = "B";
        textMoji[2].text = "C";

    }
}
