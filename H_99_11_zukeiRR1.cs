using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class H_99_11_zukeiRR1 : MonoBehaviour
{
    //k0014_1 :プレハブ（画面のobjでもOK）を使う objにはりつけ--------
    //プレハブで線のオブジェを呼び出す
    public GameObject line;
    
    //プレハブで文字のオブジェを呼び出す
    public GameObject moji;

    //呼び出したmojiの親オブジェにするオブジェ。
    public GameObject zukei;

    //プレハブから呼び出したlineを実際に当てはめる変数----------------
    //線のオブジェを当てはめるlist
    List<GameObject> L = new List<GameObject>();

    //k0015_99_1 :線を引くline回り　オブジェにラインをくっつける
    List<LineRenderer> LR = new List<LineRenderer>();
    
    //文字オブジェ関係のlist-----------------------------------------
    //文字のオブジェを当てはめるlist
    List<GameObject> Moji = new List<GameObject>();
    
    //文字のオブジェのtextを当てはめるlist
    List<Text> textMoji=new List<Text>();
    
    //文字のオブジェのrecttransformを当てはめるlist
    List<RectTransform> rtMoji = new List<RectTransform>();
    //---------------------------------------------------------------

    //lineで作った三角形全体を上下に移動させる変数
    public float upDown = 1;

    void Start()
    {
        for (int i= 0;i< 3;i++) 
        {
            //k0014_1_1 :プレハブを使う
            L.Add(Instantiate(line) as GameObject);

            Moji.Add(Instantiate(moji)as GameObject);

            //k0014_2_1_1 :プレハブをキャンバスの子供にする()
            L[i].transform.SetParent(this.gameObject.transform, false);

            Moji[i].transform.SetParent(zukei.transform, false);

            //プレハブから呼び出したオブジェに名前をつける
            L[i].name = "line"+i;

            Moji[i].name = "moji" + i;

            //k0015_99_1 :線を引くline回り　オブジェにラインをくっつける
            LR.Add(L[i].GetComponent<LineRenderer>());
           
            //k0015_99_1_2 :頂点の数（この場合２つ）
            LR[i].positionCount = 2;
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

    }
}
