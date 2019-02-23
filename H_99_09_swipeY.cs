using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class H_99_09_swipeY : MonoBehaviour
{
    //y軸を動かすSWIPE。メインカメラに貼り付ける。
    //メインカメラはy軸方向に動かず、動くのは

    //k5_3_1_1:gameobject(メソッド、変数)を使いまわす
    //このスクリプトをアタッチしたオブジェクトにいちいちこのオブジェクトをアタッチ
    public H_99_01_kyoutuHensu kyotu;


    Transform trMokuji;
    
    void Start()
    {
        trMokuji =kyotu.mokuji.GetComponent<Transform>();


        Debug.Log("toriaezu");
    }

    // Update is called once per frame
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
                //カメラの位置にマウスの位置の差異を足す。
                //this.transform.position = objectPos + diffSwipe;
                trMokuji.transform.position = objectPos + diffSwipe;
                //trMokuji.transform.position = //trMokuji.transform.position + diffSwipe;
                //    new Vector3(trMokuji.transform.position.x, 
                //    trMokuji.transform.position.y+ diffSwipe.y,
                //    trMokuji.transform.position.z);
                //初めのマウスの位置を最新のマウスの位置に更新　
                FCfirstPos
                    = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            }
        }
    }
}
