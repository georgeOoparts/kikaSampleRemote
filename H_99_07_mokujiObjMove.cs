using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class H_99_07_mokujiObjMove : MonoBehaviour
{
    //目次の動きを制御するプログラムmokujiにアタッチ
    //単純上下スワイプ追加
    //スワイプ　フリック判定　追加
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

    //目次ｐ１のスタート位置 mokujiの一番下のｙ座標
    public float startP1 = 3.7f;
    //mokujiの一番上のｙ座標
    public float mokujiUe = 9.7f;

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

        
    }
    
    void Update(){
        //k6_ac:何秒たったかを変数elapseに入れる:update内にいれる。>SF判定に使う。
        elapse = (float)stopwatch.Elapsed.TotalSeconds;
        //k6_ac:何秒たったかを変数elapseに入れる:update内にいれる。>flick()に使う。
        flickElapse= (float)Fstopwatch.Elapsed.TotalSeconds; 

        //クリックボタンを押した位置とクリックボタンを離した位置を返すメソッド
        upDownClickPosition();

        //メインカメラが目次の時にのみ
        if (kyotu.mainCameraPosi==1) {
            flick();

            swipeControl();
        }

        

        //目次がある値以上の場所へ行かない処理
        if (trMokuji.position.y <= startP1) {
            trMokuji.position = new Vector3(trMokuji.position.x, startP1, trMokuji.position.z);
        } else if (trMokuji.position.y >= mokujiUe) {
            trMokuji.position = new Vector3(trMokuji.position.x, mokujiUe, trMokuji.position.z);
        }


    }
    //upDownClickPosition()：クリックボタンを押した位置とクリックボタンを離した位置を返すメソッド---
    Vector3 saishoClick = new Vector3(0,0,0);
    Vector3 atoClick = new Vector3(0, 0, 0);

    void upDownClickPosition() {
        if (Input.GetMouseButtonDown(0)) {
            saishoClick = Input.mousePosition;
            //k0003_6:スクリーン座標＞ワールド座標
            saishoClick = Camera.main.ScreenToWorldPoint(saishoClick);
        } 
        else if(Input.GetMouseButtonUp(0)) {
            atoClick= Input.mousePosition;
            //k0003_6:スクリーン座標＞ワールド座標
            atoClick = Camera.main.ScreenToWorldPoint(atoClick);
        }
    }
    //flick()に関するメソッド----------------------------------------------------------------
    //k6_a:ストップウォッチ関数を使う時のおまじない。
    private System.Diagnostics.Stopwatch Fstopwatch
        = new System.Diagnostics.Stopwatch();
    //flick処理の時間を入れる変数ストップウォッチをつかう
    float flickElapse;
    bool flickMove = false;
    public float fjikan = 1f;
    public float chousei = 4.0f;
    //float tateRitu = 0.0f;


    //flick()に関するメソッド
    void flick() {
        //フリック判定時間OKなら
        //注意：if (hanteiSorF() == true)は何故か別のifで囲まないと働かない
        if (hanteiSorF() == true) {
            //update対策flickFirstがtrue、マウスボタンを上げた時、フリック判定時間OKなら
            if (flickMove == false && Input.GetMouseButtonUp(0)) {
                //k6_aa:ストップウォッチスタート
                Fstopwatch.Start();
                flickMove = true;
            }
        }
        //flickMoveがtrueなら
        if (flickMove == true) {
            //flick中にタップがあったらflickを止める
            if (Input.GetMouseButtonDown(0)) {
                flickElapse = fjikan;
            }
            if (fjikan > flickElapse) {
                //この中に時間内にしたい処理を書く。------
                //diffがプラスかマイナスかによって上下の方向が決まる
                float diff = saishoClick.y - atoClick.y;
                //ワールド座標の絶対値が１．５以上の時のみフリックをする。
                if (!(diff <= 1.5 && diff >= -1.5)) {
                    trMokuji.position += new Vector3(0, -chousei * diff * Time.deltaTime, 0);
                }
                //-----------------------------------------
            } else {
                //k6_ab:ストップウォッチの時間をリセット
                Fstopwatch.Reset();
                flickMove = false;
            }
        }
    }
    // hanteiSorF():　判定SorF S(スワイプ)ならfalse、F（フリック）ならtrueを返すメソッド-----------------------------
    //k6_a:ストップウォッチ関数を使う時のおまじない。
    private System.Diagnostics.Stopwatch stopwatch
        = new System.Diagnostics.Stopwatch();

    // 何秒たったかを変数elapseに入れる。ストップウォッチ
    private float elapse;

    //時間判定の何秒以内かを決める変数。hanteiSorF()で使うswipeなら0,flickなら１を返す
    public float hanteiSorFjikan = 0.45f;
    
    //判定SorF S(スワイプ)ならfalse、F（フリック）ならtrueを返す。
    bool hanteiSorF() {
        if (Input.GetMouseButtonDown(0)) {
            stopwatch.Start();
            return (false);
        }
        else if (Input.GetMouseButtonUp(0)) {
            //経過時間elapseが判定時間 hanteiSorFjikan以下ならば
            if (elapse <= hanteiSorFjikan) {
                stopwatch.Reset();
                return (true);
            } else {
                stopwatch.Reset();
                return (false);
            } 
        }else return (false);
    }
    //スワイプをするメソッド：swipeControl()------------------------------------------------------
    //スワイプコントロールだけのための変数
    Vector3 objectPos;
    Vector3 FCfirstPos;
    //ｙ成分がｘ成分の2倍以上たったらtrue、他はfalse
    bool tateRitu = false;

    private void swipeControl() {
        //スワイプをするメソッド
        //k3_a:Input.mousePosition.ToString()でマウスのスクリーンポイント表示
        //k3_zz2_a:スクリーン座標＞ワールド座標
        //マウスを押したら
        if (Input.GetMouseButtonDown(0)) {
            //最初のマウスの位置
            FCfirstPos = Camera.main.ScreenToWorldPoint(Input.mousePosition);

            //k6_aa:ストップウォッチスタート
            //stopwatch.Start();
        }
        //マウスを押してる最中
        if (Input.GetMouseButton(0)) {
            //動かされるカメラの現在の位置
            objectPos = this.transform.position;
            //フリックの感覚にする。下にフリックすると上へ移動
            //初めのマウスの位置と今のマウスの位置の差異
            Vector3 diffSwipe =
                FCfirstPos - Camera.main.ScreenToWorldPoint(Input.mousePosition);

            if ((diffSwipe.y / diffSwipe.x) >= 2 || (diffSwipe.y / diffSwipe.x) <= -2) {
                tateRitu = true;
                //初めのマウスの位置と今のマウスの位置の差異が0じゃなければ
                if (diffSwipe != Vector3.zero) {
                    //diffSwipe.xが0じゃなければ
                    if (diffSwipe.x != 0) {
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
            } else tateRitu = false;
        }
    }
}
