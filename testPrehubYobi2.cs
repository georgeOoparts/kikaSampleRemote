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

    //k0016_99_1_1：listの宣言
    //private List<Transform> trMeidai1 = new List<Transform>();



    // Start is called before the first frame update
    void Start()
    {
        //プレハブを使う
        //k0016_99_1_1_1：list新しい値を入れる
        ptp.Add(Instantiate(premoji) as GameObject);

        //k0014_2_1_1 :プレハブをtextPanelの子供にする()
        ptp[0].transform.SetParent(this.gameObject.transform, false);

        //k0014_2_1_1: オブジェの名前を変化させる
        ptp[0].name = "ptp0";
        ptp[0].transform.GetChild(0).name = "text0";
        Debug.Log("OKKKKKK");   
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
