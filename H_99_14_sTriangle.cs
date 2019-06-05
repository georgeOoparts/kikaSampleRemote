using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class H_99_14_sTriangle : MonoBehaviour
{
    //オブジェsampleTriangleにアタッチ、
    //共通変数MCountによってオブジェsampleTriangleの位置を変更

    //k5_3_1_1:gameobject(メソッド、変数)を使いまわす
    public H_99_01_kyoutuHensu kyotu;

    Transform samTriMove;

    void Start()
    {
        samTriMove = this.gameObject.GetComponent<Transform>();


        //k5_3_1_1_1:gameobject(メソッド、変数)を使いまわす
        //Debug.Log("samTriangle"+kyotu.MCount);    
    }

    void Update()
    {
        if (kyotu.MCount==0) 
        {
            samTriMove.position = new Vector2(9.17f, 1.11f);

        }
        else 
        {
            samTriMove.position = new Vector2(14.76f,-0.55f);
        }
    }
}
