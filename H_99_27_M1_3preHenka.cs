using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class H_99_27_M1_3preHenka : MonoBehaviour
{
    //M1_3Objectにアタッチ、countで変化させる

    //いちいちunityで当てはめなきゃ駄目　↓---------------

    //k5_3_1_1:gameobject(メソッド、変数)を使いまわす
    public H_99_01_kyoutuHensu kyotu;

    //強調表現点滅に使う変数を共通変数として使う。
    public H_99_01B_kyotuElapse kyotuEla;

    //lineを当てはめる
    public GameObject M1_3preLineS;
    public GameObject M1_3preLineStS;

    public GameObject M1_3preLineL;
    public GameObject M1_3preLineStL;

    public GameObject M1_3preLineS2;
    public GameObject M1_3preLineStS2;

    public GameObject M1_3preLineL_S;
    public GameObject M1_3preLineStL_S;

    //renderer当てはめ
    //＞linerederer当てはめ
    private Renderer rrM1_3preLineS;
    private Renderer rrM1_3preLineStS;

    private Renderer rrM1_3preLineL;
    private Renderer rrM1_3preLineStL;

    private Renderer rrM1_3preLineS2;
    private Renderer rrM1_3preLineStS2;

    private Renderer rrM1_3preLineL_S;
    private Renderer rrM1_3preLineStL_S;

    void Start()
    {
        //gameobjectをredererに当てはめていく
        //＞line：gameobjectをredererに当てはめていく
        rrM1_3preLineS = M1_3preLineS.GetComponent<Renderer>();
        rrM1_3preLineStS = M1_3preLineStS.GetComponent<Renderer>();

        rrM1_3preLineL = M1_3preLineL.GetComponent<Renderer>();
        rrM1_3preLineStL = M1_3preLineStL.GetComponent<Renderer>();

        rrM1_3preLineS2 = M1_3preLineS2.GetComponent<Renderer>();
        rrM1_3preLineStS2 = M1_3preLineStS2.GetComponent<Renderer>();

        rrM1_3preLineL_S = M1_3preLineL_S.GetComponent<Renderer>();
        rrM1_3preLineStL_S = M1_3preLineStL_S.GetComponent<Renderer>();


    }

    // Update is called once per frame
    void Update()
    {
        henka(kyotu.rrCount);
        Debug.Log("M1_3Henka::" + kyotu.mojiSwitch + "::MC::" + kyotu.MCount + "::RRC::" + kyotu.rrCount);

    }
    //リセット表示を全部消すメソッド　kyotu.rrcount-----------------------------
    private void reset() 
    {
        //k7B_1_1:オブジェを存在するけど見えなくする。
        //this.gameObject.GetComponent<Renderer>().enabled = false; 

        //k7B_1_2:オブジェを見えるようにするよ。
        //this.gameObject.GetComponent<Renderer>().enabled = true;

        //gameobjectを見えなくする
        //＞line：gameobjectを見えなくする
        rrM1_3preLineS.enabled = false;
        rrM1_3preLineStS.enabled = false;

        rrM1_3preLineL.enabled = false;
        rrM1_3preLineStL.enabled = false;

        rrM1_3preLineS2.enabled = false;
        rrM1_3preLineStS2.enabled = false;

        rrM1_3preLineL_S.enabled = false;
        rrM1_3preLineStL_S.enabled = false;

    }
    //rrCountでオブジェの表示、強調を変化させるメソッド---------------------------
    private void henka(int count) {
        //m1_2のときのみ実行
        if (kyotu.mojiSwitch == 3 & kyotu.MCount == 2) {
            if (count <= 4) {
                reset();
                //gameobjectを見えるようにする
                //＞point：gameobjectを見えるようにする
                //rrPointA.enabled = true;
                //rrStPointA.enabled = kyotuEla.tenmetuOnOff;

                ////＞text：gameobjectを見えるようにする
                //rrTextA.enabled = true;
            }
        }
    }
}
