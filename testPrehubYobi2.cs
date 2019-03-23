using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class testPrehubYobi2 : MonoBehaviour
{
    //uitext のプレハブ //canvasはプレハブ化せずにおく、publicにはしておく
    //k0014_2 :プレハブ（画面のobjでもOK）を使う objにはりつけ
    public GameObject premoji;

    //prehubとして呼び出したmojipanelに当てはめるオブジェ
    //k0016_99_1_1：listの宣言
    List<GameObject> ptp= new List<GameObject>();

    


    void Start()
    {

        for (int i = 0; i < 7; i++) {
            //プレハブを使う
            //k0016_99_1_1_1：list新しい値を入れる
            ptp.Add(Instantiate(premoji) as GameObject);

            //k0014_2_1_1 :プレハブをtextPanelの子供にする()
            ptp[i].transform.SetParent(this.gameObject.transform, false);

            //k0014_2_1_1: オブジェの名前を変化させる
            ptp[i].name = "ptp"+i;
            ptp[i].transform.GetChild(0).name = "text"+i;
        }


        Debug.Log("OKKKKKK");   
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
