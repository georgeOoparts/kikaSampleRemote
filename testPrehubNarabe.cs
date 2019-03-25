using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class testPrehubNarabe : MonoBehaviour
{
    //k5_3_1_1:gameobject(メソッド、変数)を使いまわす
    //このスクリプトをアタッチしたオブジェクトにいちいちこのオブジェクトをアタッチ
    public H_99_01_kyoutuHensu kyotu;

    //k0014_2 :プレハブ（画面のobjでもOK）を使う objにはりつけ
    public GameObject premoji;

    //k0016_99_1_1：listの宣言
    //prehubとして呼び出したmojipanelに当てはめるオブジェ
    List<GameObject> mojiPanel = new List<GameObject>();

    //mojipanelの子オブジェtextに当てはめるオブジェ
    List<GameObject> kodomoTextObj = new List<GameObject>();

    //textオブジェのコンポTEXTに当てはめるText変数
    List<Text> kodomoTextText = new List<Text>();

    //uiTEXT７つをuiPANELの中で並び替え
    void Start()
    {
        //プレハブの呼び出しはtextPrehubYobiでやっている
        //そっちのプログラムを先に呼び込むように設定する。
        for (int i = 0; i < 7; i++) {
            //k0016_99_1_1_1：list新しい値を入れる
            mojiPanel.Add(GameObject.Find("mojiPanel"+i).gameObject);
            //premojiの子供オブジェであるtextをlistにする。
            kodomoTextObj.Add(mojiPanel[i].transform.GetChild(0).gameObject);
            ////premojiの子供オブジェであるtextのコンポートメントであるTextをlistにする。
            kodomoTextText.Add(kodomoTextObj[i].GetComponent<Text>());
        }
        Debug.Log("we areeee");        
    }

    void Update()
    {
        
    }
}
