using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class s_99_01_objPosiHenka : MonoBehaviour{
    //2つのcubeを並び替えるプログラム。
    //それぞれのcubeの位置を変化させる。

    public tukaimawasi tuka;

    //k0013_1: 宣言 
    Transform cube1tr;
    Transform cube2tr;
    //？？
    public float yoyuu = 0.5f;
    //k5_3_1_1:gameobject(メソッド、変数)を使いまわす
    //このスクリプトをアタッチしたオブジェクトにいちいちこのオブジェクトをアタッチ
    float tugiPosition = 0.0f;

   

    void Start(){
        //k0013_1_1;オブジェに当てはめる；
        //k5_3_1_1_1:gameobject(メソッド、変数)を使いまわす
        cube1tr = tuka.cube1.GetComponent<Transform>();
        cube2tr = tuka.cube2.GetComponent<Transform>();

        //cube1tr = tuka.c1.GetComponent<Transform>();
        //int tama2 = tuka.tama;
    }
    void Update(){
        //k0013_1_1_2 オブジェのx,y,z幅　取得　；変化させる；
        //変数に余裕と、オブジェ１の高さの半分、オブジェ２の高さの半分を全部足す。
        //オブジェ２のy軸の開始位置となる。
        tugiPosition = yoyuu + cube1tr.localScale.y / 2 + cube2tr.localScale.y / 2;
        //k0013_1_1_1 オブジェ移動；オブジェの座標;z軸そのまま：オブジェのポジションを得る
        cube1tr.position = new Vector3(0, 0, cube1tr.position.z);
        cube2tr.position = new Vector3(0, -tugiPosition, cube2tr.position.z);
    }
}
