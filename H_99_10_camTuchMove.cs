using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//PointerEventDataを使うため下が必要。
using UnityEngine.EventSystems;

public class H_99_10_camTuchMove : MonoBehaviour
{
    //メインカメラにアタッチ
    void Start()
    {
        //Debug.Log("koltukaaaaaa");
    }
   
    void Update()
    {
        if (tuchObjName()=="panel1_1") {
            
            this.gameObject.transform.position = new Vector3(5.6f,0,-10);
            Debug.Log(tuchObjName());
        }
    }
    //タッチしたオブジェの名前を返すメソッド--------------------------------------------------------------------------------------------------
    //タッチした画面のオブジェの名前を得る、その時のオブジェを調べる奥行きの距離
    float distance = 10.0f;
    //タッチしたオブジェの名前を返すメソッド
    string tuchObjName() {
        string objectName = "nothing";
        if (Input.GetMouseButtonDown(0)) {
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
