using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class H_99_09_camYokoMove : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        //Debug.Log("weeeeee");
    }

    // Update is called once per frame
    void Update()
    {
        //k6_ac:何秒たったかを変数elapseに入れる:update内にいれる。>SF判定に使う。
        elapse = (float)stopwatch.Elapsed.TotalSeconds;
        //k6_ac:何秒たったかを変数elapseに入れる:update内にいれる。>flick()に使う。
        flickElapse = (float)Fstopwatch.Elapsed.TotalSeconds;

        upDownClickPosition();

        
        flick();
    }
    //flick()に関するメソッド----------------------------------------------------------------
    //k6_a:ストップウォッチ関数を使う時のおまじない。
    private System.Diagnostics.Stopwatch Fstopwatch
        = new System.Diagnostics.Stopwatch();
    //flick処理の時間を入れる変数ストップウォッチをつかう
    float flickElapse;
    bool flickFirst = true;
    public float fjikan = 1f;
    public float chousei = 4.0f;
    // タップ時間によるフリック判定のフラグ
    bool flickTupTimeHantei = false;
    //flick()に関するメソッド
    void flick() {
        //update対策flickFirstがtrue、マウスボタンを上げた時、フリック判定時間OKなら
        if (flickFirst == true && Input.GetMouseButtonUp(0) && hanteiSorF()) {
            //k6_aa:ストップウォッチスタート
            Fstopwatch.Start();
            flickFirst = false;
        }
        //flick中にタップがあったらflickを止める
        if (Input.GetMouseButtonDown(0)) {
            flickElapse = fjikan;
        }
        if (fjikan > flickElapse) {
            if (flickFirst == false) {

                //この中に時間内にしたい処理を書く。------
                //diffがプラスかマイナスかによって上下の方向が決まる
                float diff = saishoClick.x - atoClick.x;
                //ワールド座標の絶対値が１．５以上の時のみフリックをする。
                if (!(diff <= 1.5 && diff >= -1.5)) {
                    this.gameObject.transform.position += 
                        new Vector3(-chousei * diff * Time.deltaTime, 0,0);
                }

                //-----------------------------------------
            }
        } else {

            //k6_ab:ストップウォッチの時間をリセット
            Fstopwatch.Reset();
            flickFirst = true;
            flickTupTimeHantei = false;
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
