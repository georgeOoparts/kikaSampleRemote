using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class testPrehubYobi2 : MonoBehaviour
{
    //uitext のプレハブ //canvasはプレハブ化せずにおく、publicにはしておく
    //k0014_2 :プレハブ（画面のobjでもOK）を使う objにはりつけ
    public GameObject premoji;

    //prehubとして呼び出したmojipanelに当てはめるオブジェ
    //k0016_99_1_1：listの宣言
    List<GameObject> ptp= new List<GameObject>();

    //mojipanelの子であるtextオブジェに当てはめるオブジェ
    //k0016_99_1_1：listの宣言
    //List<GameObject> kodomoObj = new List<GameObject>();

    List<Text> kodomoText = new List<Text>();
    List<GameObject> kodomoObj = new List<GameObject>();



    void Start()
    {

        for (int i = 0; i < 7; i++) {
            //プレハブを使う
            //k0016_99_1_1_1：list新しい値を入れる
            ptp.Add(Instantiate(premoji) as GameObject);
            //premojiの子供オブジェであるtextをlistにする。
            kodomoObj.Add(ptp[i].transform.GetChild(0).gameObject);
            ////premojiの子供オブジェであるtextのコンポートメントであるTextをlistにする。
            kodomoText.Add(kodomoObj[i].GetComponent<Text>());
            
            //k0014_2_1_1 :プレハブをtextPanelの子供にする()
            ptp[i].transform.SetParent(this.gameObject.transform, false);

            //k0014_2_1_1: オブジェの名前を変化させる
            ptp[i].name = "ptp"+i;
            kodomoObj[i].name = "text"+i;

        }


        Debug.Log("OKKKKKK");   
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
