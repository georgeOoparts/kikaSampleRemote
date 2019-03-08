using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class H_99_09_camYokoMove : MonoBehaviour
{
    //パネル1,2,3を横移動


    //k5_3_1_1:gameobject(メソッド、変数)を使いまわす
    //このスクリプトをアタッチしたオブジェクトにいちいちこのオブジェクトをアタッチ
    public H_99_01_kyoutuHensu kyotu;

    //k5_3_1_1_1:gameobject(メソッド、変数)を使いまわす
    //yosu.cube1で普通に使える

    void Update()
    {
        //k6_ac:何秒たったかを変数elapseに入れる:update内にいれる。>SF判定に使う。
        elapse = (float)stopwatch.Elapsed.TotalSeconds;
        //k6_ac:何秒たったかを変数elapseに入れる:update内にいれる。>flick()に使う。
        flickElapse = (float)Fstopwatch.Elapsed.TotalSeconds;
        
        //flick()の中で使う。マウスボタンの押した位置、離した位置を得るメソッド
        upDownClickPosition();

        flick();
    }
    //flick()に関するメソッド----------------------------------------------------------------
    //k6_a:ストップウォッチ関数を使う時のおまじない。
    private System.Diagnostics.Stopwatch Fstopwatch
        = new System.Diagnostics.Stopwatch();
    //flick処理の時間を入れる変数ストップウォッチをつかう
    float flickElapse;
    bool flickMove = true;
    public float fjikan = 1f;
    public float chousei = 4.0f;
   
    int i = 0;
    //flick()に関するメソッド
    void flick() {
        //フリック判定時間OKなら
        //注意：if (hanteiSorF() == true)は何故か別のifで囲まないと働かない
        if (hanteiSorF() == true) {
            //flickMoveがtrue、マウスボタンを上げた時、
            //共通変数のbuttonmoveがfalseならば（←これないと、ボタン移動の時バグる）
            if ((flickMove == false) && (Input.GetMouseButtonUp(0) && (kyotu.bottomMove == false))) {
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
                float diff = atoClick.x - saishoClick.x;
                //ワールド座標の絶対値が１．５以上の時のみフリックをする。
                if (!(diff <= 1.5 && diff >= -1.5)) {
                    //mainCameraPosi=1つまり目次なら
                    if (kyotu.mainCameraPosi == 1) {
                        //diffがマイナスなら、つまり→移動判定のみ
                        if (diff <= 0) {
                            //mainCameraのｘ位置が５．６以下ならば
                            if (this.gameObject.transform.position.x <= 5.6) {
                                this.gameObject.transform.position +=
                                new Vector3(-chousei * diff * Time.deltaTime, 0, 0);
                            } else {
                                //最終的に行く位置
                                this.gameObject.transform.position =
                                    new Vector3(5.6f,
                                        this.gameObject.transform.position.y,
                                        this.gameObject.transform.position.z
                                        );
                                kyotu.mainCameraPosi = 2;
                                //スワイプ終了処理
                                // k6_ab:ストップウォッチの時間をリセット
                                Fstopwatch.Reset();
                                flickMove = false;

                            }
                        }
                    } else if (kyotu.mainCameraPosi == 2) {
                        //ポジ２からポジ1への横移動
                        //diffがプラスなら、つまり左移動判定のみ
                        if (diff >= 0) {
                            //mainCameraのｘ位置が５．６以下ならば
                            if (this.gameObject.transform.position.x >= 0) {
                                this.gameObject.transform.position +=
                                new Vector3(-chousei * diff * Time.deltaTime, 0, 0);
                            } else {
                                //最終的に行く位置
                                this.gameObject.transform.position =
                                    new Vector3(0,
                                        this.gameObject.transform.position.y,
                                        this.gameObject.transform.position.z
                                        );
                                kyotu.mainCameraPosi = 1;
                                //スワイプ終了処理
                                // k6_ab:ストップウォッチの時間をリセット
                                Fstopwatch.Reset();
                                flickMove = false;

                            }
                        }
                        //ポジ２からポジ３への横移動
                        //diffがマイナスなら、つまり右移動判定のみ
                        else if (diff < 0) {
                            //mainCameraのｘ位置が５．６以下ならば
                            if (this.gameObject.transform.position.x <= 11.2f) {
                                this.gameObject.transform.position +=
                                new Vector3(-chousei * diff * Time.deltaTime, 0, 0);
                            } else {
                                //最終的に行く位置
                                this.gameObject.transform.position =
                                    new Vector3(11.2f,
                                        this.gameObject.transform.position.y,
                                        this.gameObject.transform.position.z
                                        );
                                kyotu.mainCameraPosi = 3;
                                //スワイプ終了処理
                                // k6_ab:ストップウォッチの時間をリセット
                                Fstopwatch.Reset();
                                flickMove = false;

                            }
                        }
                    } else if (kyotu.mainCameraPosi == 3) {
                        //ポジ3からポジ2への横移動
                        //diffがプラスなら、つまり左移動判定のみ
                        if (diff >= 0) {
                            //mainCameraのｘ位置が５．６以下ならば
                            if (this.gameObject.transform.position.x >= 5.6) {
                                this.gameObject.transform.position +=
                                new Vector3(-chousei * diff * Time.deltaTime, 0, 0);
                            } else {
                                //最終的に行く位置
                                this.gameObject.transform.position =
                                new Vector3(5.6f,
                                this.gameObject.transform.position.y,
                                this.gameObject.transform.position.z
                                );
                                kyotu.mainCameraPosi = 2;
                                //スワイプ終了処理
                                // k6_ab:ストップウォッチの時間をリセット
                                Fstopwatch.Reset();
                                flickMove = false;
                            }
                        }
                    }
                } else {
                    //スワイプ終了処理
                    //k6_ab:ストップウォッチの時間をリセット
                    Fstopwatch.Reset();
                    flickMove = false;
                }
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
        } else if (Input.GetMouseButtonUp(0)) {
            //経過時間elapseが判定時間 hanteiSorFjikan以下ならば
            if (elapse <= hanteiSorFjikan) {
                stopwatch.Reset();
                return (true);
            } else {
                stopwatch.Reset();
                return (false);
            }
        } else return (false);
    }
    //upDownClickPosition()：クリックボタンを押した位置とクリックボタンを離した位置を返すメソッド---
    Vector3 saishoClick = new Vector3(0, 0, 0);
    Vector3 atoClick = new Vector3(0, 0, 0);

    void upDownClickPosition() {
        if (Input.GetMouseButtonDown(0)) {
            //k0003_6:スクリーン座標＞ワールド座標
            saishoClick = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        } else if (Input.GetMouseButtonUp(0)) {
            //k0003_6:スクリーン座標＞ワールド座標
            atoClick = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        }
    }
}
