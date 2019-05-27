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


    private int kyouchouHenkanInt;
    void Update() 
    {
        //k6_ac:何秒たったかを変数elapseに入れる
        elapse = (float)stopwatch.Elapsed.TotalSeconds;

        //kyotu.rrCountの数を増やす
        if (Input.GetMouseButtonDown(0))
            kyotu.rrCount++;
        //Debug.Log("rrCount" + kyotu.rrCount);
        else if (Input.GetMouseButtonDown(1)) 
        {
            kyotu.MCount++;
            kyotu.rrCount = 0;
        }

        //Debug.Log("MCount" + kyotu.MCount);


        //UItextに2次元配列の値を入れていく
        for (int i = 0; i < kodomoTextText.Count; i++) 
        {
            //k0017_99_2_1:2次元配列　最初の要素の個数を得る
            if (kyotu.rrCount < intValues.GetLength(1) && kyotu.MCount < intValues.GetLength(0)) 
            {
                kodomoTextText[i].text = intValues[kyotu.MCount, kyotu.rrCount, i];

                //k10_2:strin>int変換
                kyouchouHenkanInt = int.Parse(intValues[kyotu.MCount, kyotu.rrCount, intValues.GetLength(2) - 1]);
                //Debug.Log("kyouchou:::" + kyouchouHenkan);
                

            } 
            else
                kodomoTextText[i].text = "";


        }
        //強調すべきパネルを強調するメソッド
        kyochouPanel(kyouchouHenkanInt);

        

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
    void kyochouPanel(int count) 
    { 
        for (int i = 0; i < kodomoTextText.Count; i++) 
        {
            mojiPanel[i].GetComponent<Image>().enabled = false;
        }
        //k7_1_2:オブジェを見えるようにするよ。
        mojiPanel[count].GetComponent<Image>().enabled = kyochoHantei();
    }
    //Uitextの中身----------------------------------------------------------------------------------------------------
    private string[,,] intValues;
    void setWord() 
    {
        //　配列の要素数の確保
        intValues = new string[,,]
        {
            {
                {"0000000000","001111111","002222222","0033333333","0044444444","00555555","0066666","0"},
                {"010000", "0111111","012222","013333","014444","015555","016666","0"},
                {"02000", "0211111","022222","023333","0244444","0255555","026666","0"},
                {"03000", "031111","032222","0333333","034444","035555","036666","0"},
                {"04000", "041111","042222","043333","04444","045555","046666","0"},
                {"050000", "051111","052222","053333","054444","055555","05666","0"},
                {"06000", "06111","06222","063333","064444","065555","0666666","0"}
            },
            {
                {"1000000000","101111111","102222222","1033333333","1044444444","10555555","1066666","1"},
                {"110000", "1111111","112222","113333","114444","115555","116666","1"},
                {"12000", "1211111","122222","123333","1244444","1255555","126666","1"},
                {"13000", "131111","132222","1333333","134444","135555","136666","1"},
                {"14000", "141111","142222","143333","14444","145555","146666","1"},
                {"150000", "151111","152222","153333","154444","155555","15666","1"},
                {"16000", "16111","16222","163333","164444","165555","1666666","1"}
            },
            {
                {"2000000000","201111111","202222222","2033333333","2044444444","20555555","2066666","2"},
                {"210000", "2111111","212222","213333","214444","215555","216666","2"},
                {"22000", "2211111","222222","223333","2244444","2255555","226666","2"},
                {"23000", "231111","232222","2333333","234444","235555","236666","2"},
                {"24000", "241111","242222","243333","24444","245555","246666","2"},
                {"250000", "251111","252222","253333","254444","255555","25666","2"},
                {"26000", "26111","26222","263333","264444","265555","2666666","2"}
            }
        };
    }
   
}
