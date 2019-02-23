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

    //k0013_1: 宣言----------------------------------------------------------
    //Transformの宣言
    Transform trMeidai;

    //k0016_99_1_1：listの宣言
    //private List<Transform> trMeidai1 = new List<Transform>();

    private List<Transform> trMeidai1 = new List<Transform>();

    private List<Transform> trP1_1 = new List<Transform>();
    private List<Transform> trP1_2 = new List<Transform>();
    private List<Transform> trP1_3 = new List<Transform>();
    private List<Transform> trP1_4 = new List<Transform>();
    private List<Transform> trP1_5 = new List<Transform>();
    private List<Transform> trP1_6 = new List<Transform>();

    //meidai全部のｘ軸の値------------------------------
    public float meidaiX = 5.6f;
    public float meidaiY = 0;

   //panelの間の幅-----------------------------------------
    public float spacePanel = 0.5f;

    //目次panel並べ替え時のそれぞれのスタート位置-----------
    float startNarabekae =0 ;

    //mokujiP：目次全体を動かす変数 ---------------------------
    float mokujiP = 0;
    //現在ででなく、1つ前のmeidai変数を入れる変数。panelZenkaiResetメソッドに使う。---
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
        trMeidai1.Add(kyotu.meidai1_3.GetComponent<Transform>());
        trMeidai1.Add(kyotu.meidai1_4.GetComponent<Transform>());
        trMeidai1.Add(kyotu.meidai1_5.GetComponent<Transform>());
        trMeidai1.Add(kyotu.meidai1_6.GetComponent<Transform>());

        //meidai1_1のパネルのtransformを取得-----------------------------------------------------
        //k0016_99_1_1_1：list新しい値を入れる
        //trMeidai1.Add(kyotu.meidai1_1.GetComponent<Transform>());

        trP1_1.Add(kyotu.p1_1_1.GetComponent<Transform>());
        trP1_1.Add(kyotu.p1_1_2.GetComponent<Transform>());
        trP1_1.Add(kyotu.p1_1_3.GetComponent<Transform>());
        trP1_1.Add(kyotu.p1_1_4.GetComponent<Transform>());
        trP1_1.Add(kyotu.p1_1_5.GetComponent<Transform>());
        trP1_1.Add(kyotu.p1_1_6.GetComponent<Transform>());

        //meidai1_2のパネルのtransformを取得-----------------------------------------------------
        //k0016_99_1_1_1：list新しい値を入れる
        //trMeidai1.Add(kyotu.meidai1_1.GetComponent<Transform>());

        trP1_2.Add(kyotu.p1_2_1.GetComponent<Transform>());
        trP1_2.Add(kyotu.p1_2_2.GetComponent<Transform>());
        trP1_2.Add(kyotu.p1_2_3.GetComponent<Transform>());
        trP1_2.Add(kyotu.p1_2_4.GetComponent<Transform>());
        trP1_2.Add(kyotu.p1_2_5.GetComponent<Transform>());
        trP1_2.Add(kyotu.p1_2_6.GetComponent<Transform>());
        trP1_2.Add(kyotu.p1_2_7.GetComponent<Transform>());
        trP1_2.Add(kyotu.p1_2_8.GetComponent<Transform>());
        trP1_2.Add(kyotu.p1_2_9.GetComponent<Transform>());

        //meidai1_3のパネルのtransformを取得-----------------------------------------------------
        //k0016_99_1_1_1：list新しい値を入れる
        //trMeidai1.Add(kyotu.meidai1_1.GetComponent<Transform>());
        trP1_3.Add(kyotu.p1_3_1.GetComponent<Transform>());
        trP1_3.Add(kyotu.p1_3_2.GetComponent<Transform>());
        trP1_3.Add(kyotu.p1_3_3.GetComponent<Transform>());
        trP1_3.Add(kyotu.p1_3_4.GetComponent<Transform>());
        trP1_3.Add(kyotu.p1_3_5.GetComponent<Transform>());
        trP1_3.Add(kyotu.p1_3_6.GetComponent<Transform>());

        //meidai1_4のパネルのtransformを取得-----------------------------------------------------
        //k0016_99_1_1_1：list新しい値を入れる
        //trMeidai1.Add(kyotu.meidai1_1.GetComponent<Transform>());
        trP1_4.Add(kyotu.p1_4_1.GetComponent<Transform>());
        trP1_4.Add(kyotu.p1_4_2.GetComponent<Transform>());
        trP1_4.Add(kyotu.p1_4_3.GetComponent<Transform>());
        trP1_4.Add(kyotu.p1_4_4.GetComponent<Transform>());
        
        //meidai1_5のパネルのtransformを取得-----------------------------------------------------
        //k0016_99_1_1_1：list新しい値を入れる
        //trMeidai1.Add(kyotu.meidai1_1.GetComponent<Transform>());
        trP1_5.Add(kyotu.p1_5_1.GetComponent<Transform>());
        trP1_5.Add(kyotu.p1_5_2.GetComponent<Transform>());
        trP1_5.Add(kyotu.p1_5_3.GetComponent<Transform>());
        trP1_5.Add(kyotu.p1_5_4.GetComponent<Transform>());
        trP1_5.Add(kyotu.p1_5_5.GetComponent<Transform>());
        trP1_5.Add(kyotu.p1_5_6.GetComponent<Transform>());
        trP1_5.Add(kyotu.p1_5_7.GetComponent<Transform>());

        //meidai1_4のパネルのtransformを取得-----------------------------------------------------
        //k0016_99_1_1_1：list新しい値を入れる
        //trMeidai1.Add(kyotu.meidai1_1.GetComponent<Transform>());
        trP1_6.Add(kyotu.p1_6_1.GetComponent<Transform>());
        trP1_6.Add(kyotu.p1_6_2.GetComponent<Transform>());
        trP1_6.Add(kyotu.p1_6_3.GetComponent<Transform>());
        trP1_6.Add(kyotu.p1_6_4.GetComponent<Transform>());
        trP1_6.Add(kyotu.p1_6_5.GetComponent<Transform>());
        trP1_6.Add(kyotu.p1_6_6.GetComponent<Transform>());

        //Debug.Log("move?");
    }

    void Update() {
        //現在ででなく、1つ前のmeidai変数を入れる変数。panelZenkaiResetメソッドに使う。
        //maeMeidaiHensu = kyotu.meidaiHensu;
        panelZenkaiReset(maeMeidaiHensu);
        panelNarabe(kyotu.meidaiHensu);
        //最後にmeidai1全体ををリアルタイムで動かす。start位置調整---------------------------
        if (kyotu.meidaiHensu == 1) {
            //最後にmeidai1_1全体ををリアルタイムで動かす。start位置調整---------------------------
            //page.localScale = new Vector3((float)-2.8, -5, page.position.z);

            //cameraTakasaY：カメラの真ん中から上半分のyジクの距離
            //upSpace：カメラの上から一番上のオブジェまでの距離
            //mokujiP：目次全体を動かす変数y軸に入れる

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
            ////mokujiP：目次全体を動かす変数y軸に入れる

            mokujiP = kyotu.cameraTakasaY - kyotu.upSpace - trP1_2[0].localScale.y / 2;

            ////k0013_1_1_1 オブジェ移動；オブジェの座標;z軸そのまま：オブジェのポジションを得る
            //page.position = new Vector3((float)-2.8, -5, page.position.z);
            trMeidai1[1].position =
                new Vector3(trMeidai1[1].position.x, mokujiP, trMeidai1[1].position.z);
        } else if (kyotu.meidaiHensu == 3) {
            ////最後にmeidai1_1全体ををリアルタイムで動かす。start位置調整---------------------------
            ////page.localScale = new Vector3((float)-2.8, -5, page.position.z);

            ////cameraTakasaY：カメラの真ん中から上半分のyジクの距離
            ////upSpace：カメラの上から一番上のオブジェまでの距離
            ////mokujiP：目次全体を動かす変数y軸に入れる

            mokujiP = kyotu.cameraTakasaY - kyotu.upSpace - trP1_3[0].localScale.y / 2;

            ////k0013_1_1_1 オブジェ移動；オブジェの座標;z軸そのまま：オブジェのポジションを得る
            //page.position = new Vector3((float)-2.8, -5, page.position.z);
            trMeidai1[2].position =
                new Vector3(trMeidai1[2].position.x, mokujiP, trMeidai1[2].position.z);
        } else if (kyotu.meidaiHensu == 4) {
            ////最後にmeidai1_1全体ををリアルタイムで動かす。start位置調整---------------------------
            ////page.localScale = new Vector3((float)-2.8, -5, page.position.z);

            ////cameraTakasaY：カメラの真ん中から上半分のyジクの距離
            ////upSpace：カメラの上から一番上のオブジェまでの距離
            ////mokujiP：目次全体を動かす変数y軸に入れる

            mokujiP = kyotu.cameraTakasaY - kyotu.upSpace - trP1_4[0].localScale.y / 2;

            ////k0013_1_1_1 オブジェ移動；オブジェの座標;z軸そのまま：オブジェのポジションを得る
            //page.position = new Vector3((float)-2.8, -5, page.position.z);
            trMeidai1[3].position =
                new Vector3(trMeidai1[3].position.x, mokujiP, trMeidai1[3].position.z);
        } else if (kyotu.meidaiHensu == 5) {
            ////最後にmeidai1_1全体ををリアルタイムで動かす。start位置調整---------------------------
            ////page.localScale = new Vector3((float)-2.8, -5, page.position.z);

            ////cameraTakasaY：カメラの真ん中から上半分のyジクの距離
            ////upSpace：カメラの上から一番上のオブジェまでの距離
            ////mokujiP：目次全体を動かす変数y軸に入れる

            mokujiP = kyotu.cameraTakasaY - kyotu.upSpace - trP1_5[0].localScale.y / 2;

            ////k0013_1_1_1 オブジェ移動；オブジェの座標;z軸そのまま：オブジェのポジションを得る
            //page.position = new Vector3((float)-2.8, -5, page.position.z);
            trMeidai1[4].position =
                new Vector3(trMeidai1[4].position.x, mokujiP, trMeidai1[4].position.z);
        } else if (kyotu.meidaiHensu == 6) {
            ////最後にmeidai1_1全体ををリアルタイムで動かす。start位置調整---------------------------
            ////page.localScale = new Vector3((float)-2.8, -5, page.position.z);

            ////cameraTakasaY：カメラの真ん中から上半分のyジクの距離
            ////upSpace：カメラの上から一番上のオブジェまでの距離
            ////mokujiP：目次全体を動かす変数y軸に入れる

            mokujiP = kyotu.cameraTakasaY - kyotu.upSpace - trP1_6[0].localScale.y / 2;

            ////k0013_1_1_1 オブジェ移動；オブジェの座標;z軸そのまま：オブジェのポジションを得る
            //page.position = new Vector3((float)-2.8, -5, page.position.z);
            trMeidai1[5].position =
                new Vector3(trMeidai1[5].position.x, mokujiP, trMeidai1[5].position.z);
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

            foreach (Transform t in trP1_1) {
                t.position =
               new Vector3(trMeidai.position.x, trMeidai.position.y, trMeidai.position.z);
            }
        } else if (MH == 2) {
            //選ばれなかった命題をまずリセット----------------------
            //k0013_1_1_1 オブジェ移動；オブジェの座標;z軸そのまま：オブジェのポジションを得る
            //page.position = new Vector3((float)-2.8, -5, page.position.z);
            trMeidai1[1].position =
                new Vector3(trMeidai.position.x, trMeidai.position.y, trMeidai.position.z);

            //選ばれなかったｐ１＿2＿１～ｐ１＿2＿9までパネルをリセット------------
            //ｐ１＿2＿１～ｐ１＿2＿9までパネルを並べる
            //k0013_1_1_2 オブジェのx,y,z幅　取得　；変化させる；

            foreach (Transform t in trP1_2) {
                t.position =
               new Vector3(trMeidai.position.x, trMeidai.position.y, trMeidai.position.z);
            }
        } else if (MH == 3) {
            //選ばれなかった命題をまずリセット----------------------
            //k0013_1_1_1 オブジェ移動；オブジェの座標;z軸そのまま：オブジェのポジションを得る
            //page.position = new Vector3((float)-2.8, -5, page.position.z);
            trMeidai1[2].position =
                new Vector3(trMeidai.position.x, trMeidai.position.y, trMeidai.position.z);

            //選ばれなかったｐ１＿3＿１～ｐ１＿3＿6までパネルをリセット------------
            //ｐ１＿3＿１～ｐ１＿3＿6までパネルを並べる
            //k0013_1_1_2 オブジェのx,y,z幅　取得　；変化させる；

            foreach (Transform t in trP1_3) {
                t.position =
               new Vector3(trMeidai.position.x, trMeidai.position.y, trMeidai.position.z);
            }
        } else if (MH == 4) {
            //選ばれなかった命題をまずリセット----------------------
            //k0013_1_1_1 オブジェ移動；オブジェの座標;z軸そのまま：オブジェのポジションを得る
            //page.position = new Vector3((float)-2.8, -5, page.position.z);
            trMeidai1[3].position =
                new Vector3(trMeidai.position.x, trMeidai.position.y, trMeidai.position.z);

            //選ばれなかったｐ１＿3＿１～ｐ１＿3＿6までパネルをリセット------------
            //ｐ１＿3＿１～ｐ１＿3＿6までパネルを並べる
            //k0013_1_1_2 オブジェのx,y,z幅　取得　；変化させる；

            foreach (Transform t in trP1_4) {
                t.position =
               new Vector3(trMeidai.position.x, trMeidai.position.y, trMeidai.position.z);
            }
        } else if (MH == 5) {
            //選ばれなかった命題をまずリセット----------------------
            //k0013_1_1_1 オブジェ移動；オブジェの座標;z軸そのまま：オブジェのポジションを得る
            //page.position = new Vector3((float)-2.8, -5, page.position.z);
            trMeidai1[4].position =
                new Vector3(trMeidai.position.x, trMeidai.position.y, trMeidai.position.z);

            //選ばれなかったｐ１＿3＿１～ｐ１＿3＿6までパネルをリセット------------
            //ｐ１＿3＿１～ｐ１＿3＿6までパネルを並べる
            //k0013_1_1_2 オブジェのx,y,z幅　取得　；変化させる；

            foreach (Transform t in trP1_5) {
                t.position =
               new Vector3(trMeidai.position.x, trMeidai.position.y, trMeidai.position.z);
            }
        } else if (MH == 6) {
            //選ばれなかった命題をまずリセット----------------------
            //k0013_1_1_1 オブジェ移動；オブジェの座標;z軸そのまま：オブジェのポジションを得る
            //page.position = new Vector3((float)-2.8, -5, page.position.z);
            trMeidai1[5].position =
                new Vector3(trMeidai.position.x, trMeidai.position.y, trMeidai.position.z);

            //選ばれなかったｐ１＿3＿１～ｐ１＿3＿6までパネルをリセット------------
            //ｐ１＿3＿１～ｐ１＿3＿6までパネルを並べる
            //k0013_1_1_2 オブジェのx,y,z幅　取得　；変化させる；

            foreach (Transform t in trP1_6) {
                t.position =
               new Vector3(trMeidai.position.x, trMeidai.position.y, trMeidai.position.z);
            }
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

            for (int i=0;i<trP1_1.Count;i++) {
                if (i == 0) {
                    startNarabekae = 0;
                    trP1_1[i].position =
                       new Vector3(trP1_1[0].position.x, startNarabekae, trP1_1[0].position.z);
                } else {
                    //startNarabekaeを次のオブジェの開始位置に合わせる、
                    //前のオブジェのy軸幅の半分、次のオブジェのy軸幅の半分、
                    //オブジェ間のスペースを引く
                    startNarabekae -= 
                        trP1_1[i-1].localScale.y / 2 + trP1_1[i].localScale.y / 2 + spacePanel;
                    trP1_1[i].position =
                        new Vector3(trP1_1[0].position.x, startNarabekae, trP1_1[0].position.z);
                }
            }
            //現在ででなく、1つ前のmeidai変数を入れる変数。panelZenkaiResetメソッドに使う。
            maeMeidaiHensu = kyotu.meidaiHensu;
        } else if (MH == 2) {
            //まずmeidai1_2を元の場所（5.6、0）までもって行く-----------------------------
            trMeidai1[1].position = new Vector3(meidaiX, meidaiY, trMeidai1[1].position.z);

            //ｐ１＿１＿１～ｐ１＿１＿６までパネルを並べる--------------------------------
            //k0013_1_1_2 オブジェのx,y,z幅　取得　；変化させる；
            //startNarabekaeの値は最初０にリセットする

            for (int i = 0; i < trP1_2.Count; i++) {
                if (i == 0) {
                    startNarabekae = 0;
                    trP1_2[i].position =
                       new Vector3(trP1_2[0].position.x, startNarabekae, trP1_2[0].position.z);
                } else {
                    //startNarabekaeを次のオブジェの開始位置に合わせる、
                    //前のオブジェのy軸幅の半分、次のオブジェのy軸幅の半分、
                    //オブジェ間のスペースを引く
                    startNarabekae -=
                        trP1_2[i - 1].localScale.y / 2 + trP1_2[i].localScale.y / 2 + spacePanel;
                    trP1_2[i].position =
                        new Vector3(trP1_2[0].position.x, startNarabekae, trP1_2[0].position.z);
                }
            }
            //現在ででなく、1つ前のmeidai変数を入れる変数。panelZenkaiResetメソッドに使う。
            maeMeidaiHensu = kyotu.meidaiHensu;
        } else if (MH == 3) {
            //まずmeidai1_2を元の場所（5.6、0）までもって行く-----------------------------
            trMeidai1[2].position = new Vector3(meidaiX, meidaiY, trMeidai1[2].position.z);

            //ｐ１＿１＿１～ｐ１＿１＿６までパネルを並べる--------------------------------
            //k0013_1_1_2 オブジェのx,y,z幅　取得　；変化させる；
            //startNarabekaeの値は最初０にリセットする

            for (int i = 0; i < trP1_3.Count; i++) {
                if (i == 0) {
                    startNarabekae = 0;
                    trP1_3[i].position =
                       new Vector3(trP1_3[0].position.x, startNarabekae, trP1_3[0].position.z);
                } else {
                    //startNarabekaeを次のオブジェの開始位置に合わせる、
                    //前のオブジェのy軸幅の半分、次のオブジェのy軸幅の半分、
                    //オブジェ間のスペースを引く
                    startNarabekae -=
                        trP1_3[i - 1].localScale.y / 2 + trP1_3[i].localScale.y / 2 + spacePanel;
                    trP1_3[i].position =
                        new Vector3(trP1_3[0].position.x, startNarabekae, trP1_3[0].position.z);
                }
            }
            //現在ででなく、1つ前のmeidai変数を入れる変数。panelZenkaiResetメソッドに使う。
            maeMeidaiHensu = kyotu.meidaiHensu;
        } else if (MH == 4) {
            //まずmeidai1_2を元の場所（5.6、0）までもって行く-----------------------------
            trMeidai1[3].position = new Vector3(meidaiX, meidaiY, trMeidai1[3].position.z);

            //ｐ１＿１＿１～ｐ１＿１＿６までパネルを並べる--------------------------------
            //k0013_1_1_2 オブジェのx,y,z幅　取得　；変化させる；
            //startNarabekaeの値は最初０にリセットする

            for (int i = 0; i < trP1_4.Count; i++) {
                if (i == 0) {
                    startNarabekae = 0;
                    trP1_4[i].position =
                       new Vector3(trP1_4[0].position.x, startNarabekae, trP1_4[0].position.z);
                } else {
                    //startNarabekaeを次のオブジェの開始位置に合わせる、
                    //前のオブジェのy軸幅の半分、次のオブジェのy軸幅の半分、
                    //オブジェ間のスペースを引く
                    startNarabekae -=
                        trP1_4[i - 1].localScale.y / 2 + trP1_4[i].localScale.y / 2 + spacePanel;
                    trP1_4[i].position =
                        new Vector3(trP1_4[0].position.x, startNarabekae, trP1_4[0].position.z);
                }
            }
            //現在ででなく、1つ前のmeidai変数を入れる変数。panelZenkaiResetメソッドに使う。
            maeMeidaiHensu = kyotu.meidaiHensu;
        } else if (MH == 5) {
            //まずmeidai1_2を元の場所（5.6、0）までもって行く-----------------------------
            trMeidai1[4].position = new Vector3(meidaiX, meidaiY, trMeidai1[4].position.z);

            //ｐ１＿１＿１～ｐ１＿１＿６までパネルを並べる--------------------------------
            //k0013_1_1_2 オブジェのx,y,z幅　取得　；変化させる；
            //startNarabekaeの値は最初０にリセットする

            for (int i = 0; i < trP1_5.Count; i++) {
                if (i == 0) {
                    startNarabekae = 0;
                    trP1_5[i].position =
                       new Vector3(trP1_5[0].position.x, startNarabekae, trP1_5[0].position.z);
                } else {
                    //startNarabekaeを次のオブジェの開始位置に合わせる、
                    //前のオブジェのy軸幅の半分、次のオブジェのy軸幅の半分、
                    //オブジェ間のスペースを引く
                    startNarabekae -=
                        trP1_5[i - 1].localScale.y / 2 + trP1_5[i].localScale.y / 2 + spacePanel;
                    trP1_5[i].position =
                        new Vector3(trP1_5[0].position.x, startNarabekae, trP1_5[0].position.z);
                }
            }
            //現在ででなく、1つ前のmeidai変数を入れる変数。panelZenkaiResetメソッドに使う。
            maeMeidaiHensu = kyotu.meidaiHensu;
        } else if (MH == 6) {
            //まずmeidai1_2を元の場所（5.6、0）までもって行く-----------------------------
            trMeidai1[5].position = new Vector3(meidaiX, meidaiY, trMeidai1[5].position.z);

            //ｐ１＿１＿１～ｐ１＿１＿６までパネルを並べる--------------------------------
            //k0013_1_1_2 オブジェのx,y,z幅　取得　；変化させる；
            //startNarabekaeの値は最初０にリセットする

            for (int i = 0; i < trP1_6.Count; i++) {
                if (i == 0) {
                    startNarabekae = 0;
                    trP1_6[i].position =
                       new Vector3(trP1_6[0].position.x, startNarabekae, trP1_6[0].position.z);
                } else {
                    //startNarabekaeを次のオブジェの開始位置に合わせる、
                    //前のオブジェのy軸幅の半分、次のオブジェのy軸幅の半分、
                    //オブジェ間のスペースを引く
                    startNarabekae -=
                        trP1_6[i - 1].localScale.y / 2 + trP1_6[i].localScale.y / 2 + spacePanel;
                    trP1_6[i].position =
                        new Vector3(trP1_6[0].position.x, startNarabekae, trP1_6[0].position.z);
                }
            }
            //現在ででなく、1つ前のmeidai変数を入れる変数。panelZenkaiResetメソッドに使う。
            maeMeidaiHensu = kyotu.meidaiHensu;
        }
    }

}
