using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class H_99_32_M1_5RR : MonoBehaviour
{
    //M1_5RRにアタッチ。オブジェクト全体のいどうをするプログラム
    //いちいちunityで当てはめなきゃ駄目　↓---------------

    //k5_3_1_1:gameobject(メソッド、変数)を使いまわす
    public H_99_01_kyoutuHensu kyotu;

    private Transform M1_5RRMove;
    void Start()
    {
        M1_5RRMove = this.gameObject.GetComponent<Transform>();

    }

    // Update is called once per frame
    void Update()
    {
        //meidai  m1_5 count4以下
        if (kyotu.mojiSwitch == 3 && kyotu.MCount == 4) {
            M1_5RRMove.position = new Vector3(11.25f, 1.5f, -1);
        } else {
            M1_5RRMove.position = new Vector3(16.35f, -3.74f, 0);
        }
        //Debug.Log("M1_5RR::" + kyotu.mojiSwitch + "::MC::" + kyotu.MCount + "::RRC::" + kyotu.rrCount);
        //Debug.Log("M1_5RR");
    }
}
