using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class H_99_08_meidaiMove : MonoBehaviour
{
    //k5_3_1_1:gameobject(メソッド、変数)を使いまわす
    //このスクリプトをアタッチしたオブジェクトにいちいちこのオブジェクトをアタッチ
    public H_99_01_kyoutuHensu kyotu;

    //k0013_1: 宣言
    Transform trMeidai1_1;

    Transform trP1_1_1;
    Transform trP1_1_2;
    Transform trP1_1_3;
    Transform trP1_1_4;
    Transform trP1_1_5;
    Transform trP1_1_6;

    //start でpanel1～6の始まるｙ軸の値。
    float startPanel = 0;

    //panelの間の幅
    public float spacePanel = 0.5f;

    //目次ｐ１のスタート位置
    public float startP1 = 3.7f;
    void Start()
    {
        //k0013_1_1;オブジェに当てはめる；
        //k5_3_1_1_1:gameobject(メソッド、変数)を使いまわす

        trMeidai1_1 = kyotu.meidai1_1.GetComponent<Transform>();

        trP1_1_1 = kyotu.p1_1_1.GetComponent<Transform>();
        trP1_1_2 = kyotu.p1_1_2.GetComponent<Transform>();
        trP1_1_3 = kyotu.p1_1_3.GetComponent<Transform>();
        trP1_1_4 = kyotu.p1_1_4.GetComponent<Transform>();
        trP1_1_5 = kyotu.p1_1_5.GetComponent<Transform>();
        trP1_1_6 = kyotu.p1_1_6.GetComponent<Transform>();

        //k0013_1_1_1 オブジェ移動；オブジェの座標;z軸そのまま：オブジェのポジションを得る
        //k0013_1_1_2 オブジェのx,y,z幅　取得　；変化させる；
        //page.localScale = new Vector3((float)-2.8, -5, page.position.z);
        //まずstartでパネルを一列に並べる

        //まずｐ１＿１＿１～ｐ１＿１＿６まで
        trP1_1_1.position = new Vector3(trP1_1_1.position.x, startPanel, trP1_1_1.position.z);

        startPanel -= trP1_1_1.localScale.y / 2 + trP1_1_2.localScale.y / 2 + spacePanel;
        trP1_1_2.position = new Vector3(trP1_1_1.position.x, startPanel, trP1_1_1.position.z);

        startPanel -= trP1_1_2.localScale.y / 2 + trP1_1_3.localScale.y / 2 + spacePanel;
        trP1_1_3.position = new Vector3(trP1_1_1.position.x, startPanel, trP1_1_1.position.z);

        startPanel -= trP1_1_3.localScale.y / 2 + trP1_1_4.localScale.y / 2 + spacePanel;
        trP1_1_4.position = new Vector3(trP1_1_1.position.x, startPanel, trP1_1_1.position.z);

        startPanel -= trP1_1_4.localScale.y / 2 + trP1_1_5.localScale.y / 2 + spacePanel;
        trP1_1_5.position = new Vector3(trP1_1_1.position.x, startPanel, trP1_1_1.position.z);

        startPanel -= trP1_1_5.localScale.y / 2 + trP1_1_6.localScale.y / 2 + spacePanel;
        trP1_1_6.position = new Vector3(trP1_1_1.position.x, startPanel, trP1_1_1.position.z);


        //Debug.Log("move?"+kyotu.p1_1_1.name);
    }

    void Update()
    {
        //k0013_1_1_1 オブジェ移動；オブジェの座標;z軸そのまま：オブジェのポジションを得る
        //updateで並んだパネルを一気に動かす
        trMeidai1_1.position = new Vector3(trMeidai1_1.position.x, startP1,
                                        trMeidai1_1.position.z);
    }
}
