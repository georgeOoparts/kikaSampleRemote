using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//PointerEventDataを使うため下が必要。
using UnityEngine.EventSystems;

public class H_99_10_camTuchMove : MonoBehaviour
{
    //u1 呼び込まれるプログラムの順番　１上側＞edit>projectseting>scriptexecutionOrder  
    //u1>数字が低いほうから読み込まれる。
    /// このプログラムは共通変数であるkyotu.bottomMoveをどのオブジェクトのプログラムより
    /// updateの最後にfalseにセットしたいため、camyokomoveのプログラムより、後に読み込まれ
    /// るように設定する。そうしないとボタン移動した後、勝手に←横スワイプが働いてしまう。
    
    //k5_3_1_1:gameobject(メソッド、変数)を使いまわす
    //このスクリプトをアタッチしたオブジェクトにいちいちこのオブジェクトをアタッチ
    public H_99_01_kyoutuHensu kyotu;
    //メインカメラにアタッチ
    void Start()
    {
        //Debug.Log("koltukaaaaaa");
    }
   
    void Update()
    {
        //k6_ac:何秒たったかを変数elapseに入れる:update内にいれる。>SF判定に使う。
        elapse = (float)stopwatch.Elapsed.TotalSeconds;

        upDownClickPosition();
        if (hanteiSorF() == true) {//なぜかif文内の&&使えない
            if (touchDistanceX() == true) {
                if (tuchObjName() == "panel1_1") {
                    //k5_3_1_1_1:gameobject(メソッド、変数)を使いまわす
                    kyotu.mainCameraPosi = 2;
                    kyotu.meidaiHensu = 1;
                    kyotu.bottomMove = true;
                    this.gameObject.transform.position = new Vector3(5.6f, 0, -10);
                    //Debug.Log(tuchObjName());
                } else if (tuchObjName() == "panel1_2") {
                    //k5_3_1_1_1:gameobject(メソッド、変数)を使いまわす
                    kyotu.mainCameraPosi = 2;
                    kyotu.meidaiHensu = 2;
                    kyotu.bottomMove = true;
                    this.gameObject.transform.position = new Vector3(5.6f, 0, -10);
                    //Debug.Log(tuchObjName());
                } else if (tuchObjName() == "panel1_3") {
                    //k5_3_1_1_1:gameobject(メソッド、変数)を使いまわす
                    kyotu.mainCameraPosi = 2;
                    kyotu.meidaiHensu = 3;
                    kyotu.bottomMove = true;
                    this.gameObject.transform.position = new Vector3(5.6f, 0, -10);
                    //Debug.Log(tuchObjName());
                } else if (tuchObjName() == "panel1_4") {
                    //k5_3_1_1_1:gameobject(メソッド、変数)を使いまわす
                    kyotu.mainCameraPosi = 2;
                    kyotu.meidaiHensu = 4;
                    kyotu.bottomMove = true;
                    this.gameObject.transform.position = new Vector3(5.6f, 0, -10);
                    //Debug.Log(tuchObjName());
                } else if (tuchObjName() == "panel1_5") {
                    //k5_3_1_1_1:gameobject(メソッド、変数)を使いまわす
                    kyotu.mainCameraPosi = 2;
                    kyotu.meidaiHensu = 5;
                    kyotu.bottomMove = true;
                    this.gameObject.transform.position = new Vector3(5.6f, 0, -10);
                    //Debug.Log(tuchObjName());
                } else if (tuchObjName() == "panel1_6") {
                    //k5_3_1_1_1:gameobject(メソッド、変数)を使いまわす
                    kyotu.mainCameraPosi = 2;
                    kyotu.meidaiHensu = 6;
                    kyotu.bottomMove = true;
                    this.gameObject.transform.position = new Vector3(5.6f, 0, -10);
                    //Debug.Log(tuchObjName());
                }
            }
        }
        kyotu.bottomMove = false;
        //Debug.Log("sai"+ saishoClick + "ato"+ atoClick);
    }
    //touchDistanceX():saishoClickとatoClickのx軸の距離を返す変数
    ///upDownClickPosition()の存在が必要
    bool touchDistanceX() {
        if (Input.GetMouseButtonUp(0)) {
            float distance = atoClick.x - saishoClick.x;

            //if (distance <= 0.1 || distance >= -0.1)
            if (distance ==0)
                return (true);
            else return (false);
        } else return (false);
    }
    //upDownClickPosition()：クリックボタンを押した位置とクリックボタンを離した位置を返すメソッド---
    Vector3 saishoClick = new Vector3(0, 0, 0);
    Vector3 atoClick = new Vector3(0, 0, 0);

    void upDownClickPosition(){
        if (Input.GetMouseButtonDown(0)) {
           //k0003_6:スクリーン座標＞ワールド座標
            saishoClick = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        } else if (Input.GetMouseButtonUp(0)) {
            //k0003_6:スクリーン座標＞ワールド座標
            atoClick = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        }
    }
    // hanteiSorF():　判定SorF S(スワイプ)ならfalse、F（フリック）ならtrueを返すメソッド-----------------------------
    //k6_a:ストップウォッチ関数を使う時のおまじない。
    private System.Diagnostics.Stopwatch stopwatch
        = new System.Diagnostics.Stopwatch();

    // 何秒たったかを変数elapseに入れる。ストップウォッチ
    private float elapse;

    //時間判定の何秒以内かを決める変数。hanteiSorF()で使うswipeなら0,flickなら１を返す
    public float hanteiSorFjikan = 0.2f;

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
    //タッチしたオブジェの名前を返すメソッド--------------------------------------------------------------------------------------------------
    //タッチした画面のオブジェの名前を得る、その時のオブジェを調べる奥行きの距離
    float distance = 10.0f;
    //タッチしたオブジェの名前を返すメソッド
    string tuchObjName() {
        string objectName = "nothing";
        if (Input.GetMouseButtonUp(0)) {
            // クリックしたスクリーン座標をrayに変換
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            // Rayの当たったオブジェクトの情報を格納する
            RaycastHit hit = new RaycastHit();
            // オブジェクトにrayが当たった時
            if (Physics.Raycast(ray, out hit, distance)) {
                
                // rayが当たったオブジェクトの名前を取得
                objectName = hit.collider.gameObject.name;
                return (objectName);
            }
            return (objectName);
        }
        return (objectName);
    }
    //--------------------------------------------------------------------------------------------------




}
//クリックした所にＵＩがあるかどうかを判定するメソッド
//private bool clickUiCheck() {
//    //マウスが対象ＵＩの上にあったらtrue,
//    //なかったらfalseを返す   
//    PointerEventData pointer
//            = new PointerEventData(EventSystem.current);
//    pointer.position = Input.mousePosition;
//    List<RaycastResult> result = new List<RaycastResult>();
//    EventSystem.current.RaycastAll(pointer, result);

//    foreach (RaycastResult raycastResult in result) {
//        // ここに名前を取得する処理を書く
//        // 複数ある場合は全て取得されるため注意
//        if (raycastResult.gameObject.name == "ruler") {
//            return (true);
//        }
//    }
//    return (false);
//}
