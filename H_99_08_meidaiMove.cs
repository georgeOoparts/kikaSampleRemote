﻿using System.Collections;
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

    private List<Transform> trMeidai1 = new List<Transform>();

    private List<Transform> trP1_1 = new List<Transform>();

    private List<Transform> trP1_2 = new List<Transform>();

    

    //meidai全部のｘ軸の値
    public float meidaiX = 5.6f;
    public float meidaiY = 0;

    //start でpanel1～6の始まるｙ軸の値。
    //float startPanel =0;

    //panelの間の幅
    public float spacePanel = 0.5f;

    //目次panel並べ替え時のそれぞれのスタート位置
    float startNarabekae =0 ;

    //mokujiP：目次全体を動かす変数 
    float mokujiP = 0;
    //現在ででなく、1つ前のmeidai変数を入れる変数。panelZenkaiResetメソッドに使う。
    int maeMeidaiHensu = 0; 

    void Start()
    {
        //meidai全てが入ったオブジェクトのtransformを取得-----------------------
        
        //k0013_1_1;オブジェに当てはめる；
        //k5_3_1_1_1:gameobject(メソッド、変数)を使いまわす

        trMeidai = kyotu.meidai.GetComponent<Transform>();
        
        //meidai1～6のオブジェのtransformを取得----------------------------------

        //k0016_99_1_1_1：list新しい値を入れる
        //trMeidai1.Add(kyotu.meidai1_1.GetComponent<Transform>());

        trMeidai1.Add(kyotu.meidai1_1.GetComponent<Transform>());
        trMeidai1.Add(kyotu.meidai1_2.GetComponent<Transform>());

        //meidai1_1のパネルのtransformを取得-----------------------------------------------------

        trP1_1.Add(kyotu.p1_1_1.GetComponent<Transform>());
        trP1_1.Add(kyotu.p1_1_2.GetComponent<Transform>());
        trP1_1.Add(kyotu.p1_1_3.GetComponent<Transform>());
        trP1_1.Add(kyotu.p1_1_4.GetComponent<Transform>());
        trP1_1.Add(kyotu.p1_1_5.GetComponent<Transform>());
        trP1_1.Add(kyotu.p1_1_6.GetComponent<Transform>());

        //------------------------------------------
        trP1_2.Add(kyotu.p1_2_1.GetComponent<Transform>());
        trP1_2.Add(kyotu.p1_2_2.GetComponent<Transform>());
        trP1_2.Add(kyotu.p1_2_3.GetComponent<Transform>());
        trP1_2.Add(kyotu.p1_2_4.GetComponent<Transform>());
        trP1_2.Add(kyotu.p1_2_5.GetComponent<Transform>());
        trP1_2.Add(kyotu.p1_2_6.GetComponent<Transform>());
        trP1_2.Add(kyotu.p1_2_7.GetComponent<Transform>());
        trP1_2.Add(kyotu.p1_2_8.GetComponent<Transform>());
        trP1_2.Add(kyotu.p1_2_9.GetComponent<Transform>());

        Debug.Log("move?");
    }
    
    void Update()
    {
        //現在ででなく、1つ前のmeidai変数を入れる変数。panelZenkaiResetメソッドに使う。
        //maeMeidaiHensu = kyotu.meidaiHensu;
        panelZenkaiReset(maeMeidaiHensu);
        panelNarabe(kyotu.meidaiHensu);
        if (kyotu.meidaiHensu == 1) {
            //最後にmeidai1_1全体ををリアルタイムで動かす。start位置調整---------------------------
            //page.localScale = new Vector3((float)-2.8, -5, page.position.z);

            //cameraTakasaY：カメラの真ん中から上半分のyジクの距離
            //upSpace：カメラの上から一番上のオブジェまでの距離
            //mokujiP：目次全体を動かす変数

            mokujiP = kyotu.cameraTakasaY - kyotu.upSpace - trP1_1[0].localScale.y / 2;

            //k0013_1_1_1 オブジェ移動；オブジェの座標;z軸そのまま：オブジェのポジションを得る
            //page.position = new Vector3((float)-2.8, -5, page.position.z);
            trMeidai1[0].position =
                new Vector3(trMeidai1[0].position.x, mokujiP, trMeidai1[0].position.z);

        } else if (kyotu.meidaiHensu == 2) {
            ////最後にmeidai1_1全体ををリアルタイムで動かす。start位置調整---------------------------
            ////page.localScale = new Vector3((float)-2.8, -5, page.position.z);

            ////cameraTakasaY：カメラの真ん中から上半分のyジクの距離
            ////upSpace：カメラの上から一番上のオブジェまでの距離
            ////mokujiP：目次全体を動かす変数

            mokujiP = kyotu.cameraTakasaY - kyotu.upSpace - trP1_2[0].localScale.y / 2;

            ////k0013_1_1_1 オブジェ移動；オブジェの座標;z軸そのまま：オブジェのポジションを得る
            //page.position = new Vector3((float)-2.8, -5, page.position.z);
            trMeidai1[1].position =
                new Vector3(trMeidai1[1].position.x, mokujiP, trMeidai1[1].position.z);
        }
    }
    //前回並べてあったパネルを元の場所に戻すメソッド
    void panelZenkaiReset(int MH) {
        if (MH == 1) {
            //選ばれなかった命題をまずリセット----------------------
            //k0013_1_1_1 オブジェ移動；オブジェの座標;z軸そのまま：オブジェのポジションを得る
            //page.position = new Vector3((float)-2.8, -5, page.position.z);
            trMeidai1[0].position =
                new Vector3(trMeidai.position.x, trMeidai.position.y, trMeidai.position.z);

            //選ばれなかったｐ１＿1＿１～ｐ１＿1＿6までパネルをリセット------------
            //k0013_1_1_2 オブジェのx,y,z幅　取得　；変化させる；
            trP1_1[0].position =
               new Vector3(trMeidai.position.x, trMeidai.position.y, trMeidai.position.z);

            trP1_1[1].position =
                new Vector3(trMeidai.position.x, trMeidai.position.y, trMeidai.position.z);

            trP1_1[2].position =
                new Vector3(trMeidai.position.x, trMeidai.position.y, trMeidai.position.z);

            trP1_1[3].position =
                new Vector3(trMeidai.position.x, trMeidai.position.y, trMeidai.position.z);

            trP1_1[4].position =
                new Vector3(trMeidai.position.x, trMeidai.position.y, trMeidai.position.z);

            trP1_1[5].position =
                new Vector3(trMeidai.position.x, trMeidai.position.y, trMeidai.position.z);

            
        } else if (MH == 2) {
            //選ばれなかった命題をまずリセット----------------------
            //k0013_1_1_1 オブジェ移動；オブジェの座標;z軸そのまま：オブジェのポジションを得る
            //page.position = new Vector3((float)-2.8, -5, page.position.z);
            trMeidai1[1].position =
                new Vector3(trMeidai.position.x, trMeidai.position.y, trMeidai.position.z);

            //選ばれなかったｐ１＿2＿１～ｐ１＿2＿9までパネルをリセット------------
            //ｐ１＿2＿１～ｐ１＿2＿9までパネルを並べる
            //k0013_1_1_2 オブジェのx,y,z幅　取得　；変化させる；
            trP1_2[0].position =
               new Vector3(trMeidai.position.x, trMeidai.position.y, trMeidai.position.z);

            trP1_2[1].position =
                new Vector3(trMeidai.position.x, trMeidai.position.y, trMeidai.position.z);

            trP1_2[2].position =
                new Vector3(trMeidai.position.x, trMeidai.position.y, trMeidai.position.z);

            trP1_2[3].position =
                new Vector3(trMeidai.position.x, trMeidai.position.y, trMeidai.position.z);

            trP1_2[4].position =
                new Vector3(trMeidai.position.x, trMeidai.position.y, trMeidai.position.z);

            trP1_2[5].position =
                new Vector3(trMeidai.position.x, trMeidai.position.y, trMeidai.position.z);

            trP1_2[6].position =
                new Vector3(trMeidai.position.x, trMeidai.position.y, trMeidai.position.z);

            trP1_2[7].position =
                new Vector3(trMeidai.position.x, trMeidai.position.y, trMeidai.position.z);

            trP1_2[8].position =
                new Vector3(trMeidai.position.x, trMeidai.position.y, trMeidai.position.z);
        }
    }
    //パネルをまず（meidaiX, meidaiY）から並べる変数
    void panelNarabe(int MH) {
        if (MH == 1) {
            //まずmeidai1_1をパネル２の場所（5.6、0）までもって行く------------------------
            trMeidai1[0].position = new Vector3(meidaiX, meidaiY, trMeidai1[0].position.z);

            //meidai1_1のｐ１＿１＿１～ｐ１＿１＿６までパネルを並べる----------------------
            //k0013_1_1_2 オブジェのx,y,z幅　取得　；変化させる；
            //startNarabekaeの値は最初０にリセットする
            startNarabekae = 0;
            trP1_1[0].position =
               new Vector3(trP1_1[0].position.x, startNarabekae, trP1_1[0].position.z);

            //startNarabekaeを次のオブジェの開始位置に合わせる、
            //前のオブジェのy軸幅の半分、次のオブジェのy軸幅の半分、オブジェ間のスペースを引く
            startNarabekae -= trP1_1[0].localScale.y / 2 + trP1_1[1].localScale.y / 2 + spacePanel;
            trP1_1[1].position =
                new Vector3(trP1_1[0].position.x, startNarabekae, trP1_1[0].position.z);

            startNarabekae -= trP1_1[1].localScale.y / 2 + trP1_1[2].localScale.y / 2 + spacePanel;
            trP1_1[2].position =
                new Vector3(trP1_1[0].position.x, startNarabekae, trP1_1[0].position.z);

            startNarabekae -= trP1_1[2].localScale.y / 2 + trP1_1[3].localScale.y / 2 + spacePanel;
            trP1_1[3].position =
                new Vector3(trP1_1[0].position.x, startNarabekae, trP1_1[0].position.z);

            startNarabekae -= trP1_1[3].localScale.y / 2 + trP1_1[4].localScale.y / 2 + spacePanel;
            trP1_1[4].position =
                new Vector3(trP1_1[0].position.x, startNarabekae, trP1_1[0].position.z);

            startNarabekae -= trP1_1[4].localScale.y / 2 + trP1_1[5].localScale.y / 2 + spacePanel;
            trP1_1[5].position =
                new Vector3(trP1_1[0].position.x, startNarabekae, trP1_1[0].position.z);

            //現在ででなく、1つ前のmeidai変数を入れる変数。panelZenkaiResetメソッドに使う。
            maeMeidaiHensu = kyotu.meidaiHensu;
        } else if (MH == 2) {
            //まずmeidai1_2を元の場所（5.6、0）までもって行く-----------------------------
            trMeidai1[1].position = new Vector3(meidaiX, meidaiY, trMeidai1[1].position.z);

            //ｐ１＿１＿１～ｐ１＿１＿６までパネルを並べる--------------------------------
            //k0013_1_1_2 オブジェのx,y,z幅　取得　；変化させる；
            //startNarabekaeの値は最初０にリセットする
            startNarabekae = 0;
            trP1_2[0].position =
               new Vector3(trP1_2[0].position.x, startNarabekae, trP1_2[0].position.z);

            startNarabekae -= trP1_2[0].localScale.y / 2 + trP1_2[1].localScale.y / 2 + spacePanel;
            trP1_2[1].position =
                new Vector3(trP1_2[0].position.x, startNarabekae, trP1_2[0].position.z);

            startNarabekae -= trP1_2[1].localScale.y / 2 + trP1_2[2].localScale.y / 2 + spacePanel;
            trP1_2[2].position =
                new Vector3(trP1_2[0].position.x, startNarabekae, trP1_2[0].position.z);

            startNarabekae -= trP1_2[2].localScale.y / 2 + trP1_2[3].localScale.y / 2 + spacePanel;
            trP1_2[3].position =
                new Vector3(trP1_2[0].position.x, startNarabekae, trP1_2[0].position.z);

            startNarabekae -= trP1_2[3].localScale.y / 2 + trP1_2[4].localScale.y / 2 + spacePanel;
            trP1_2[4].position =
                new Vector3(trP1_2[0].position.x, startNarabekae, trP1_2[0].position.z);

            startNarabekae -= trP1_2[4].localScale.y / 2 + trP1_2[5].localScale.y / 2 + spacePanel;
            trP1_2[5].position =
                new Vector3(trP1_2[0].position.x, startNarabekae, trP1_2[0].position.z);

            startNarabekae -= trP1_2[5].localScale.y / 2 + trP1_2[6].localScale.y / 2 + spacePanel;
            trP1_2[6].position =
                new Vector3(trP1_2[0].position.x, startNarabekae, trP1_2[0].position.z);

            startNarabekae -= trP1_2[6].localScale.y / 2 + trP1_2[7].localScale.y / 2 + spacePanel;
            trP1_2[7].position =
                new Vector3(trP1_2[0].position.x, startNarabekae, trP1_2[0].position.z);

            startNarabekae -= trP1_2[7].localScale.y / 2 + trP1_2[8].localScale.y / 2 + spacePanel;
            trP1_2[8].position =
                new Vector3(trP1_2[0].position.x, startNarabekae, trP1_2[0].position.z);

            //現在ででなく、1つ前のmeidai変数を入れる変数。panelZenkaiResetメソッドに使う。
            maeMeidaiHensu = kyotu.meidaiHensu;
        }
    }

}
