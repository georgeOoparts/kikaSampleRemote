using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class H_99_15_wCircleTriangle : MonoBehaviour
{
    //オブジェsampleTriangleにアタッチ、
    //共通変数MCountによってオブジェsampleTriangleの位置を変更

    //k5_3_1_1:gameobject(メソッド、変数)を使いまわす
    public H_99_01_kyoutuHensu kyotu;

    Transform wCircleTriMove;

    void Start() 
    {
        wCircleTriMove = this.gameObject.GetComponent<Transform>();


        //k5_3_1_1_1:gameobject(メソッド、変数)を使いまわす
        //Debug.Log("wCircleTriangle"+kyotu.MCount);    
    }

    void Update() 
    {
        if (kyotu.MCount == 1) 
        {
            wCircleTriMove.position = new Vector2(10.25f, 2.7f);
        } 
        else 
        {
            wCircleTriMove.position = new Vector2(16.35f, -3.74f);
        }
    }
}
