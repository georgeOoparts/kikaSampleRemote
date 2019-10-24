using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class H_99_50_M1_6RR : MonoBehaviour {
    //M1_6RRにアタッチ。オブジェクト全体のいどうをするプログラム
    //いちいちunityで当てはめなきゃ駄目　↓---------------

    //k5_3_1_1:gameobject(メソッド、変数)を使いまわす
    public H_99_01_kyoutuHensu kyotu;

    private Transform M1_6Move;

    void Start() {
        M1_6Move = this.gameObject.GetComponent<Transform>();
    }

    void Update() {
        //meidai  m1_5 count4以下
        if (kyotu.mojiSwitch == 3 && kyotu.MCount == 5) {
            M1_6Move.position = new Vector3(11.2f, 1f, -1);
        } else {
            M1_6Move.position = new Vector3(20.35f, -3.74f, 0);
        }
        Debug.Log("M1_6RR::" + kyotu.mojiSwitch + "::MC::" + kyotu.MCount + "::RRC::" + kyotu.rrCount);

    }
}