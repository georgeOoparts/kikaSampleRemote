using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class H_99_07_mokujiObjMove : MonoBehaviour
{
    //k5_3_1_1:gameobject(メソッド、変数)を使いまわす
    //このスクリプトをアタッチしたオブジェクトにいちいちこのオブジェクトをアタッチ
    public H_99_01_kyoutuHensu kyotu;
    //k5_3_1_1_1:gameobject(メソッド、変数)を使いまわす
    //yosu.cube1で普通に使える
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log(kyotu.p1_1.name);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
