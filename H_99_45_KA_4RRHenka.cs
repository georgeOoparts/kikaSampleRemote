using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class H_99_45_KA_4RRHenka : MonoBehaviour
{
    //M1_5RRにアタッチ。オブジェクト全体のいどうをするプログラム
    //いちいちunityで当てはめなきゃ駄目　↓---------------

    //k5_3_1_1:gameobject(メソッド、変数)を使いまわす
    public H_99_01_kyoutuHensu kyotu;

    //強調表現点滅に使う変数を共通変数として使う。
    public H_99_01B_kyotuElapse kyotuEla;

    //MColor0Blue_point;
    public Material MColor0;
    //MColor1Yellow_line;
    public Material MColor1;
    //MColor2Green_kaku;
    public Material MColor2;
    //MColor3Red_St1;
    public Material MColor3;
    //MColor4Orange_St2
    public Material MColor4;
    //MColor5Purple_same1;
    public Material MColor5;
    //MColor6Pink_same2
    public Material MColor6;
    //MColor7DarkPurple_same3
    public Material MColor7;
    //MColor8White_same4
    public Material MColor8;
    //MColor9Black_same5
    public Material MColor9;

    public GameObject KA_4Line1A;

    public GameObject KA_4Line1B;

    public GameObject KA_4Line2;

    public GameObject KA_4Line3A;

    public GameObject KA_4Line3B;

    public GameObject KA_4StLine1A;

    public GameObject KA_4StLine2;

    public GameObject KA_4StLine3A;

    private Renderer rrKA_4Line1A;

    private Renderer rrKA_4Line1B;

    private Renderer rrKA_4Line2;

    private Renderer rrKA_4Line3A;

    private Renderer rrKA_4Line3B;

    private Renderer rrKA_4StLine1A;

    private Renderer rrKA_4StLine2;

    private Renderer rrKA_4StLine3A;

    //k0013_1: 宣言 
    private Transform trKA_4Line1B;

    private Transform trKA_4Line3B;

    public float sitaV = 2f;

    void Start()
    {
        rrKA_4Line1A= KA_4Line1A.GetComponent<Renderer>();
        rrKA_4Line1B = KA_4Line1B.GetComponent<Renderer>();
        rrKA_4Line2 = KA_4Line2.GetComponent<Renderer>();
        rrKA_4Line3A = KA_4Line3A.GetComponent<Renderer>();
        rrKA_4Line3B = KA_4Line3B.GetComponent<Renderer>();
        rrKA_4StLine1A = KA_4StLine1A.GetComponent<Renderer>();
        rrKA_4StLine2 = KA_4StLine2.GetComponent<Renderer>();
        rrKA_4StLine3A = KA_4StLine3A.GetComponent<Renderer>();

        //k0013_1_1;オブジェに当てはめる；
        trKA_4Line1B = KA_4Line1B.gameObject.GetComponent<Transform>();

        trKA_4Line3B = KA_4Line3B.gameObject.GetComponent<Transform>();

    }
    //リセット表示を全部消すメソッド　kyotu.rrcount------resetW-----------------------
    private void reset() {
        //k7B_1_1:オブジェを存在するけど見えなくする。
        //this.gameObject.GetComponent<Renderer>().enabled = false; 

        //k7B_1_2:オブジェを見えるようにするよ。
        //this.gameObject.GetComponent<Renderer>().enabled = true;

        //gameobjectを見えなくする
        //＞line：gameobjectを見えなくする

        rrKA_4Line1A.enabled = false;
        rrKA_4Line1B.enabled = false;
        rrKA_4Line2.enabled = false;
        rrKA_4Line3A.enabled = false;
        rrKA_4Line3B.enabled = false;
        rrKA_4StLine1A.enabled = false;
        rrKA_4StLine2.enabled = false;
        rrKA_4StLine3A.enabled = false;
    }
    void Update()
    {
        henka(kyotu.rrCount);
        Debug.Log("KA_4RRHenka::" + kyotu.mojiSwitch + "::MC::" + kyotu.MCount + "::RRC::" + kyotu.rrCount);

    }
    //rrCountでオブジェの表示、強調を変化させるメソッド---------------------------
    private void henka(int count) {//henkaW
        //m1_3のときのみ実行
        if (kyotu.mojiSwitch == 0 & kyotu.MCount == 2) {
            if (count == 0) {
                reset();
            } else if (count == 1) {//henka1
                reset();
                

            }
        }
    }
}
