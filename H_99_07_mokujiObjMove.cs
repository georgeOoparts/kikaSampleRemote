using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class H_99_07_mokujiObjMove : MonoBehaviour
{
    //k5_3_1_1:gameobject(メソッド、変数)を使いまわす
    //このスクリプトをアタッチしたオブジェクトにいちいちこのオブジェクトをアタッチ
    public H_99_01_kyoutuHensu kyotu;

    //k0013_1: 宣言
    Transform trMokuji;

    Transform trP1;
    Transform trP2;
    Transform trP3;
    Transform trP4;
    Transform trP5;
    Transform trP6;

    //start でpanel1～６の始まるｙ軸の値。
    float startPanel = 0;

    //panelの間の幅
    public float spacePanel = 0.5f;

    void Start()
    {
        //k0013_1_1;オブジェに当てはめる；
        //k5_3_1_1_1:gameobject(メソッド、変数)を使いまわす
        trMokuji = kyotu.mokuji.GetComponent<Transform>();

        trP1 = kyotu.p1_1.GetComponent<Transform>();
        trP2 = kyotu.p1_2.GetComponent<Transform>();
        trP3 = kyotu.p1_3.GetComponent<Transform>();
        trP4 = kyotu.p1_4.GetComponent<Transform>();
        trP5 = kyotu.p1_5.GetComponent<Transform>();
        trP6 = kyotu.p1_6.GetComponent<Transform>();

        //k0013_1_1_1 オブジェ移動；オブジェの座標;z軸そのまま：オブジェのポジションを得る
        //k0013_1_1_2 オブジェのx,y,z幅　取得　；変化させる；
        //page.localScale = new Vector3((float)-2.8, -5, page.position.z);
        //まずstartでパネルを一列に並べる
        trP1.position = new Vector3(trP1.position.x, startPanel, trP1.position.z);
        startPanel -=trP1.localScale.y/2+ trP2.localScale.y / 2+ spacePanel;

        trP2.position = new Vector3(trP1.position.x, startPanel, trP1.position.z);
        startPanel -= trP2.localScale.y / 2 + trP3.localScale.y / 2 + spacePanel;

        trP3.position = new Vector3(trP1.position.x, startPanel, trP1.position.z);
        startPanel -= trP3.localScale.y / 2 + trP4.localScale.y / 2 + spacePanel;

        trP4.position = new Vector3(trP1.position.x, startPanel, trP1.position.z);
        startPanel -= trP4.localScale.y / 2 + trP5.localScale.y / 2 + spacePanel;

        trP5.position = new Vector3(trP1.position.x, startPanel, trP1.position.z);
        startPanel -= trP5.localScale.y / 2 + trP6.localScale.y / 2 + spacePanel;

        trP6.position = new Vector3(trP1.position.x, startPanel, trP1.position.z);
    }
    void Update()
    {
        //k0013_1_1_1 オブジェ移動；オブジェの座標;z軸そのまま：オブジェのポジションを得る
        //updateで並んだパネルを一気に動かす
        trMokuji.position = new Vector3(trMokuji.position.x, trMokuji.position.y, 
                                        trMokuji.position.z);
    }
}
