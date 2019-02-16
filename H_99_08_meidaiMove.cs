using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class H_99_08_meidaiMove : MonoBehaviour
{
    //命題を並べるプログラム
    //meidai全てを含む親オブジェのy軸の値は０。子オブジェ全ての座標は（０，０，０）

    //k5_3_1_1:gameobject(メソッド、変数)を使いまわす
    //このスクリプトをアタッチしたオブジェクトにいちいちこのオブジェクトをアタッチ
    public H_99_01_kyoutuHensu kyotu;

    //k0013_1: 宣言
    Transform trMeidai;

    Transform trMeidai1_1;
    Transform trMeidai1_2;
    Transform trMeidai1_3;
    Transform trMeidai1_4;
    Transform trMeidai1_5;
    Transform trMeidai1_6;

    Transform trP1_1_1;
    Transform trP1_1_2;
    Transform trP1_1_3;
    Transform trP1_1_4;
    Transform trP1_1_5;
    Transform trP1_1_6;

    //Transform trP1_2_1;
    //Transform trP1_2_2;
    //Transform trP1_2_3;
    //Transform trP1_2_4;
    //Transform trP1_2_5;
    //Transform trP1_2_6;
    //Transform trP1_2_7;
    //Transform trP1_2_8;
    //Transform trP1_2_9;

    //meidai全部のｘ軸の値
    public float meidaiX = 5.6f;

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

        trMeidai = kyotu.meidai.GetComponent<Transform>();

        trMeidai1_1 =kyotu.meidai1_1.GetComponent<Transform>();
        trMeidai1_2 = kyotu.meidai1_2.GetComponent<Transform>();
        trMeidai1_3 = kyotu.meidai1_3.GetComponent<Transform>();
        trMeidai1_4 = kyotu.meidai1_4.GetComponent<Transform>();
        trMeidai1_5 = kyotu.meidai1_5.GetComponent<Transform>();
        trMeidai1_6 = kyotu.meidai1_6.GetComponent<Transform>();

        trP1_1_1 = kyotu.p1_1_1.GetComponent<Transform>();
        trP1_1_2 = kyotu.p1_1_2.GetComponent<Transform>();
        trP1_1_3 = kyotu.p1_1_3.GetComponent<Transform>();
        trP1_1_4 = kyotu.p1_1_4.GetComponent<Transform>();
        trP1_1_5 = kyotu.p1_1_5.GetComponent<Transform>();
        trP1_1_6 = kyotu.p1_1_6.GetComponent<Transform>();

        //trP1_2_1 = kyotu.p1_2_1.GetComponent<Transform>();
        //trP1_2_2 = kyotu.p1_2_2.GetComponent<Transform>();
        //trP1_2_3 = kyotu.p1_2_3.GetComponent<Transform>();
        //trP1_2_4 = kyotu.p1_2_4.GetComponent<Transform>();
        //trP1_2_5 = kyotu.p1_2_5.GetComponent<Transform>();
        //trP1_2_6 = kyotu.p1_2_6.GetComponent<Transform>();
        //trP1_2_7 = kyotu.p1_2_7.GetComponent<Transform>();
        //trP1_2_8 = kyotu.p1_2_8.GetComponent<Transform>();
        //trP1_2_9 = kyotu.p1_2_9.GetComponent<Transform>();

        //k0013_1_1_1 オブジェ移動；オブジェの座標;z軸そのまま：オブジェのポジションを得る
        //k0013_1_1_2 オブジェのx,y,z幅　取得　；変化させる；
        //page.localScale = new Vector3((float)-2.8, -5, page.position.z);
        //まずstartでパネルを一列に並べる

        //共通のmeidaiHensuのあたいによってパネル２に並べられる変数を決める。
        if (kyotu.meidaiHensu==1) {
            //まずmeidai1_1をパネル２の場所（5.6、0）までもって行く
            trMeidai1_1.position = new Vector3(meidaiX, startPanel, trMeidai1_1.position.z);
        }else if (kyotu.meidaiHensu == 2) {
            trMeidai1_2.position = new Vector3(meidaiX, startPanel, trMeidai1_2.position.z);
        } else if (kyotu.meidaiHensu == 3) {
            trMeidai1_3.position = new Vector3(meidaiX, startPanel, trMeidai1_3.position.z);
        } else if (kyotu.meidaiHensu == 4) {
            trMeidai1_4.position = new Vector3(meidaiX, startPanel, trMeidai1_4.position.z);
        } else if (kyotu.meidaiHensu == 5) {
            trMeidai1_5.position = new Vector3(meidaiX, startPanel, trMeidai1_5.position.z);
        } else if (kyotu.meidaiHensu == 6) {
            trMeidai1_6.position = new Vector3(meidaiX, startPanel, trMeidai1_6.position.z);
        }

        //まずｐ１＿１＿１～ｐ１＿１＿６まで
        //trP1_1_1.position = new Vector3(meidaiX, startPanel, trP1_1_1.position.z);

        //startPanel -= trP1_1_1.localScale.y / 2 + trP1_1_2.localScale.y / 2 + spacePanel;
        //trP1_1_2.position = new Vector3(trP1_1_1.position.x, startPanel, trP1_1_1.position.z);

        //startPanel -= trP1_1_2.localScale.y / 2 + trP1_1_3.localScale.y / 2 + spacePanel;
        //trP1_1_3.position = new Vector3(trP1_1_1.position.x, startPanel, trP1_1_1.position.z);

        //startPanel -= trP1_1_3.localScale.y / 2 + trP1_1_4.localScale.y / 2 + spacePanel;
        //trP1_1_4.position = new Vector3(trP1_1_1.position.x, startPanel, trP1_1_1.position.z);

        //startPanel -= trP1_1_4.localScale.y / 2 + trP1_1_5.localScale.y / 2 + spacePanel;
        //trP1_1_5.position = new Vector3(trP1_1_1.position.x, startPanel, trP1_1_1.position.z);

        //startPanel -= trP1_1_5.localScale.y / 2 + trP1_1_6.localScale.y / 2 + spacePanel;
        //trP1_1_6.position = new Vector3(trP1_1_1.position.x, startPanel, trP1_1_1.position.z);

        ////まずｐ１＿2＿１～ｐ１＿2＿9まで
        //startPanel -= trP1_1_6.localScale.y / 2 + trP1_2_1.localScale.y / 2 + spacePanel;
        //trP1_2_1.position = new Vector3(trP1_1_1.position.x, startPanel, trP1_1_1.position.z);

        //startPanel -= trP1_2_1.localScale.y / 2 + trP1_2_2.localScale.y / 2 + spacePanel;
        //trP1_2_2.position = new Vector3(trP1_1_1.position.x, startPanel, trP1_1_1.position.z);

        //startPanel -= trP1_2_2.localScale.y / 2 + trP1_2_3.localScale.y / 2 + spacePanel;
        //trP1_2_3.position = new Vector3(trP1_1_1.position.x, startPanel, trP1_1_1.position.z);

        //startPanel -= trP1_2_3.localScale.y / 2 + trP1_2_4.localScale.y / 2 + spacePanel;
        //trP1_2_4.position = new Vector3(trP1_1_1.position.x, startPanel, trP1_1_1.position.z);

        //startPanel -= trP1_2_4.localScale.y / 2 + trP1_2_5.localScale.y / 2 + spacePanel;
        //trP1_2_5.position = new Vector3(trP1_1_1.position.x, startPanel, trP1_1_1.position.z);

        //startPanel -= trP1_2_5.localScale.y / 2 + trP1_2_6.localScale.y / 2 + spacePanel;
        //trP1_2_6.position = new Vector3(trP1_1_1.position.x, startPanel, trP1_1_1.position.z);


        Debug.Log("move?");
    }

    void Update()
    {
        //k0013_1_1_1 オブジェ移動；オブジェの座標;z軸そのまま：オブジェのポジションを得る
        //updateで並んだパネルを一気に動かす
        //trMeidai.position = new Vector3(trMeidai.position.x, startP1,
        //                                trMeidai.position.z);
    }
}
