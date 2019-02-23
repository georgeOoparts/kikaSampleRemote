using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class H_99_07_mokujiObjMove : MonoBehaviour
{
    //目次の動きを制御するプログラムmokujiにアタッチ
    //単純上下スワイプ追加
    //フリック追加中
    
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

    //目次ｐ１のスタート位置
    public float startP1 = 3.7f;

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

        //k0013_1_1_1 オブジェ移動；オブジェの座標;z軸そのまま：オブジェのポジションを得る
        //updateで並んだパネルを一気に動かす
        trMokuji.position = new Vector3(trMokuji.position.x, startP1,
                                        trMokuji.position.z);

        //k6_ac:何秒たったかを変数elapseに入れる
        elapse = (float)stopwatch.Elapsed.TotalSeconds;
    }
    void Update()
    {
        
        flickControl();
    }
    Vector3 objectPos;
    Vector3 FCfirstPos;

    private void flickControl() {
        //フリックをするメソッド
        //k3_a:Input.mousePosition.ToString()でマウスのスクリーンポイント表示
        //k3_zz2_a:スクリーン座標＞ワールド座標
        //マウスを押したら
        if (Input.GetMouseButtonDown(0)) {
            //最初のマウスの位置
            FCfirstPos = Camera.main.ScreenToWorldPoint(Input.mousePosition);

            //k6_aa:ストップウォッチスタート
            stopwatch.Start();
            
        }
        //マウスを押してる最中
        if (Input.GetMouseButton(0)) {
            //動かされるカメラの現在の位置
            objectPos = this.transform.position;
            //フリックの感覚にする。下にフリックすると上へ移動
            //初めのマウスの位置と今のマウスの位置の差異
            Vector3 diffSwipe =
                FCfirstPos - Camera.main.ScreenToWorldPoint(Input.mousePosition);

            //初めのマウスの位置と今のマウスの位置の差異が0じゃなければ
            if (diffSwipe != Vector3.zero) {
                //Camera.main.ScreenToWorldPoint(diff);
                diffSwipe.x = 0.0f;
                diffSwipe.z = 0.0f;
                //カメラの位置にマウスの位置の差異を足す。(スマホ対応引く)

                trMokuji.transform.position = objectPos - diffSwipe;

                //初めのマウスの位置を最新のマウスの位置に更新　
                FCfirstPos
                    = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            }
        }
    }
    //k6_a:ストップウォッチ関数を使う時のおまじない。
        private System.Diagnostics.Stopwatch stopwatch
            = new System.Diagnostics.Stopwatch();

    // 何秒たったかを変数elapseに入れる。ストップウォッチ
    private float elapse;
    //時間判定の何秒以内かを決める変数。hanteiSorScrollS()で使う
    public float hanteiSorSS = 0.45f;

}
