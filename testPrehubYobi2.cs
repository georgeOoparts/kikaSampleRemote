using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class testPrehubYobi2 : MonoBehaviour
{
    //uitext のプレハブ //canvasはプレハブ化せずにおく、publicにはしておく
    //k0014_2 :プレハブ（画面のobjでもOK）を使う objにはりつけ
    public GameObject premoji;

    GameObject ptp;

    //mojiPanelの親オブジェとなるtextPANELをセットする
    //public GameObject textPanel;

    // Start is called before the first frame update
    void Start()
    {
        //k0014_2_1 :プレハブを使う
        ptp = Instantiate(premoji) as GameObject;

        //k0014_2_1_1 :プレハブをtextPanelの子供にする()
        ptp.transform.SetParent(this.gameObject.transform, false);

        //k0014_2_1_1: オブジェの名前を変化させる
        ptp.name = "ptp0";
        Debug.Log("OKKKKKK");   
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
