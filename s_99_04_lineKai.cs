using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class s_99_04_lineKai : MonoBehaviour{
    //線を引くプログラム。空のオブジェにアタッチ
    //プレハブの空のオブジェを呼び出し線を引く
    //cube1からcube2に線を引く

    //k5_3_1: gameobject(メソッド、変数)を外部から呼び出す。
    //ヒエでアタッチ
    public tukaimawasi tuka;

    //k0014_1 :プレハブ（画面のobjでもOK）を使う objにはりつけ
    public GameObject line;
    public Material m;

    //public GameObject cube1;
    //public GameObject cube2;

    //k0013_1: 宣言 
    Transform cube1tr;
    Transform cube2tr;
    Transform cube3tr;
    Transform cube4tr;

    private LineRenderer lr1;
    private LineRenderer lr2;
    private LineRenderer lr3;

    private Renderer rn1;
    private Renderer rn2;
    private Renderer rn3;

    void Start(){
        //k0014_1_1 :プレハブを使う
        GameObject line1= Instantiate(line);
        GameObject line2 = Instantiate(line);
        GameObject line3 = Instantiate(line);
        //k0015_99_1 :線を引くline回り　オブジェにラインをくっつける
        lr1 = line1.GetComponent<LineRenderer>();
        lr2 = line2.GetComponent<LineRenderer>();
        lr3 = line3.GetComponent<LineRenderer>();
        //???
        rn1 = line1.GetComponent<Renderer>();
        rn2 = line2.GetComponent<Renderer>();
        rn3 = line3.GetComponent<Renderer>();

        //k0013_1_1;オブジェに当てはめる；
        //k5_3_1_1_1:gameobject(メソッド、変数)を使いまわす
        cube1tr = tuka.cube1.GetComponent<Transform>();
        cube2tr = tuka.cube2.GetComponent<Transform>();
        cube3tr = tuka.cube3.GetComponent<Transform>();
        cube4tr = tuka.cube4.GetComponent<Transform>();

        //線の端を決定
        lr1.positionCount = 2;
        lr2.positionCount = 2;
        lr3.positionCount = 2;
        //線の幅を決定
        lr1.startWidth = 0.05f;
        lr1.endWidth = 0.05f;
        lr2.startWidth = 0.05f;
        lr2.endWidth = 0.05f;
        lr3.startWidth = 0.05f;
        lr3.endWidth = 0.05f;

        //線の色を決定
        rn1.material = m;
        rn2.material = m;
        rn3.material = m;

        
    }
    void Update() {
        //k0013_1_1_1 オブジェ移動；オブジェの座標;z軸そのまま：オブジェのポジションを得る
        //k0013_1_1_2 オブジェのx,y,z幅　取得　；変化させる；
        lr1.SetPosition(0, new Vector3(cube1tr.position.x,
            cube1tr.position.y - cube1tr.localScale.y / 2, 0.0f));

        lr1.SetPosition(1, new Vector3(cube2tr.position.x,
            cube2tr.position.y + cube2tr.localScale.y / 2, 0.0f));

        lr2.SetPosition(0, new Vector3(cube2tr.position.x,
            cube2tr.position.y - cube2tr.localScale.y / 2, 0.0f));

        lr2.SetPosition(1, new Vector3(cube3tr.position.x,
            cube3tr.position.y + cube3tr.localScale.y / 2, 0.0f));

        lr3.SetPosition(0, new Vector3(cube3tr.position.x,
            cube3tr.position.y - cube3tr.localScale.y / 2, 0.0f));

        lr3.SetPosition(1, new Vector3(cube4tr.position.x,
            cube4tr.position.y + cube4tr.localScale.y / 2, 0.0f));
    }
}
