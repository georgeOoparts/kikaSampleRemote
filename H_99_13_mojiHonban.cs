using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class H_99_13_mojiHonban : MonoBehaviour
{
    //uitext のプレハブ //canvasはプレハブ化せずにおく、publicにはしておく

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

    void Start() {
        //配列に解説文を割り当てる。
        setWord();
        for (int i = 0; i < 7; i++) 
        {
            //プレハブを使う
            //k0016_99_1_1_1：list新しい値を入れる
            mojiPanel.Add(Instantiate(premoji) as GameObject);
            //premojiの子供オブジェであるtextをlistにする。
            kodomoTextObj.Add(mojiPanel[i].transform.GetChild(0).gameObject);
            ////premojiの子供オブジェであるtextのコンポートメントであるTextをlistにする。
            kodomoTextText.Add(kodomoTextObj[i].GetComponent<Text>());

            //k0014_2_1_1 :プレハブをtextPanelの子供にする()
            mojiPanel[i].transform.SetParent(this.gameObject.transform, false);

            //k0014_2_1_1: オブジェの名前を変化させる
            mojiPanel[i].name = "mojiPanel" + i;
            kodomoTextObj[i].name = "text" + i;
        }
        //k6_aa:ストップウォッチスタート
        stopwatch.Start();
    }



    void Update() 
    {
        //k6_ac:何秒たったかを変数elapseに入れる
        elapse = (float)stopwatch.Elapsed.TotalSeconds;
        
        //UItextに2次元配列の値を入れていく
        for (int i = 0; i < kodomoTextText.Count; i++) 
        {
            //k0017_99_2_1:2次元配列　最初の要素の個数を得る
            if (kyotu.rrCount < intValues.GetLength(1))
                kodomoTextText[i].text = intValues[kyotu.MCount,kyotu.rrCount,i];
            else
                kodomoTextText[i].text = "";
        }
        //強調すべきパネルを強調するメソッド
        kyochouPanel(kyotu.rrCount);

        //kyotu.rrCountの数を増やす
        if (Input.GetMouseButtonDown(0))
            kyotu.rrCount++;
        //Debug.Log("rrCount" + kyotu.rrCount);
        else if (Input.GetMouseButtonDown(1))
            kyotu.MCount++;
        Debug.Log("MCount" + kyotu.MCount);

    }
    //点滅強調に使う。kyochoHantei()メソッド--------------------------------------------------------
    //void kyochouPanel(int count) の中で使う。
    //k6_a:ストップウォッチ関数を使う時のおまじない。
    private System.Diagnostics.Stopwatch stopwatch
        = new System.Diagnostics.Stopwatch();
    //このelapseはH_99_12_zukeiPPRRのほうで共通変数として利用される
    //それによって、点滅のタイミングを完全に合わせる
    public float elapse = 0;
    private bool tenmetuOnOff = true;
    public float interval = 0.35f;

    bool kyochoHantei() {
        if (tenmetuOnOff == true) {
            if (elapse >= interval) {
                tenmetuOnOff = false;

                //k6_ab:ストップウォッチの時間をリセット
                stopwatch.Reset();
                //k6_aa:ストップウォッチスタート
                stopwatch.Start();
                return (tenmetuOnOff);
            }
            return (true);
        } else if (elapse >= interval) {
            tenmetuOnOff = true;

            //k6_ab:ストップウォッチの時間をリセット
            stopwatch.Reset();
            //k6_aa:ストップウォッチスタート
            stopwatch.Start();
            return (tenmetuOnOff);
        }
        return (false);
    }

    //kyochouPanel(int count) ------------------------------------------------------------------------------
    void kyochouPanel(int count) {
        if (count == 0) {
            //mojiPanel[1]の点滅強調
            //k7_1_2:オブジェを見えるようにするよ。
            //k7_a:オブジェを存在するけど見えなくする。
            mojiPanel[1].GetComponent<Image>().enabled = kyochoHantei();

        } else if (count == 1) {
            for (int i = 0; i < kodomoTextText.Count; i++) {
                mojiPanel[i].GetComponent<Image>().enabled = false;
            }

            //k7_1_2:オブジェを見えるようにするよ。
            mojiPanel[1].GetComponent<Image>().enabled = kyochoHantei();


        } else if (count == 2) {
            for (int i = 0; i < kodomoTextText.Count; i++) {
                mojiPanel[i].GetComponent<Image>().enabled = false;
            }
            //k7_1_2:オブジェを見えるようにするよ。
            mojiPanel[3].GetComponent<Image>().enabled = kyochoHantei();
        } else if (count == 3) {
            for (int i = 0; i < kodomoTextText.Count; i++) {
                mojiPanel[i].GetComponent<Image>().enabled = false;
            }
            //k7_1_2:オブジェを見えるようにするよ。
            mojiPanel[5].GetComponent<Image>().enabled = kyochoHantei();
        } else if (count == 4) {
            for (int i = 0; i < kodomoTextText.Count; i++) {
                mojiPanel[i].GetComponent<Image>().enabled = false;
            }
            //k7_1_2:オブジェを見えるようにするよ。
            mojiPanel[1].GetComponent<Image>().enabled = kyochoHantei();
        } else if (count == 5) {
            for (int i = 0; i < kodomoTextText.Count; i++) {
                mojiPanel[i].GetComponent<Image>().enabled = false;
            }
            //k7_1_2:オブジェを見えるようにするよ。
            mojiPanel[3].GetComponent<Image>().enabled = kyochoHantei();
        } else if (count == 6) {
            for (int i = 0; i < kodomoTextText.Count; i++) {
                mojiPanel[i].GetComponent<Image>().enabled = false;
            }
            //k7_1_2:オブジェを見えるようにするよ。
            mojiPanel[5].GetComponent<Image>().enabled = kyochoHantei();
        }
    }
    //Uitextの中身----------------------------------------------------------------------------------------------------
    private string[,,] intValues;
    void setWord() 
    {
        //　配列の要素数の確保
        intValues = new string[,,]
        {
            {
                {"0000000000","001111111","002222222","0033333333","0044444444","00555555","0066666"},
                {"010000", "0111111","012222","013333","014444","015555","016666"},
                {"02000", "0211111","022222","023333","0244444","0255555","026666"},
                {"03000", "031111","032222","0333333","034444","035555","036666"},
                {"04000", "041111","042222","043333","04444","045555","046666"},
                {"050000", "051111","052222","053333","054444","055555","05666"},
                {"06000", "06111","06222","063333","064444","065555","0666666"}
            },
            {
                {"aaaaaaaaaaaa","bbbbbbbbbbbbbbbbbbbbbbbbbbb","ccc","ddddddddddddddddddddd","eee","fff","gggggggggggggggggggggggggg"},
                {"111", "222","333","444","555","666","777"},
                {"111", "222","333","444","555","666","777"},
                {"111", "222","333","444","555","666","777"},
                {"111", "222","333","444","555","666","777"},
                {"111", "222","333","444","555","666","777"},
                {"111", "222","333","444","555","666","777"}
            },
            {
                {"aaaaaaaaaaaa","bbbbbbbbbbbbbbbbbbbbbbbbbbb","ccc","ddddddddddddddddddddd","eee","fff","gggggggggggggggggggggggggg"},
                {"111", "222","333","444","555","666","777"},
                {"111", "222","333","444","555","666","777"},
                {"111", "222","333","444","555","666","777"},
                {"111", "222","333","444","555","666","777"},
                {"111", "222","333","444","555","666","777"},
                {"111", "222","333","444","555","666","777"}
            }
        };
    }
   
}
