using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//PointerEventDataを使うため下が必要。
using UnityEngine.EventSystems;

public class H_99_10_camTuchMove : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("koltukaaaaaa");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    //クリックした所にＵＩがあるかどうかを判定するメソッド
    private bool clickUiCheck() {
        //マウスが対象ＵＩの上にあったらtrue,
        //なかったらfalseを返す   
        PointerEventData pointer
                = new PointerEventData(EventSystem.current);
        pointer.position = Input.mousePosition;
        List<RaycastResult> result = new List<RaycastResult>();
        EventSystem.current.RaycastAll(pointer, result);

        foreach (RaycastResult raycastResult in result) {
            // ここに名前を取得する処理を書く
            // 複数ある場合は全て取得されるため注意
            if (raycastResult.gameObject.name == "ruler") {
                return (true);
            }
        }
        return (false);
    }
}
