using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class s_99_04_lineKai : MonoBehaviour{
    //線を引くプログラム。空のオブジェにアタッチ
    //プレハブの空のオブジェを呼び出し線を引く
    //cube1からcube2に線を引く

    //k0014_1 :プレハブ（画面のobjでもOK）を使う objにはりつけ
    public GameObject line;
    public Material m;

    public GameObject cube1;
    public GameObject cube2;

    //k0013_1: 宣言 
    Transform cube1tr;
    Transform cube2tr;
    
    private LineRenderer lr;
    private Renderer rn;

    void Start(){
        //k0014_1_1 :プレハブを使う
        GameObject line1= Instantiate(line);
        //k0015_99_1 :線を引くline回り　オブジェにラインをくっつける
        lr = line1.GetComponent<LineRenderer>();
        //???
        rn = line1.GetComponent<Renderer>();

        //k0013_1_1;オブジェに当てはめる；
        cube1tr = cube1.GetComponent<Transform>();
        cube2tr = cube2.GetComponent<Transform>();

        //線の端を決定
        lr.positionCount = 2;
        //線の幅を決定
        lr.startWidth = 0.05f;
        lr.endWidth = 0.05f;

        //線の色を決定
        rn.material = m;
    }
    void Update() {
        //k0013_1_1_1 オブジェ移動；オブジェの座標;z軸そのまま：オブジェのポジションを得る
        //k0013_1_1_2 オブジェのx,y,z幅　取得　；変化させる；
        lr.SetPosition(0, new Vector3(cube1tr.position.x, 
            cube1tr.position.y-cube1tr.localScale.y/2, 0.0f));
        lr.SetPosition(1, new Vector3(cube2tr.position.x, 
            cube2tr.position.y + cube2tr.localScale.y / 2, 0.0f));
       
    }
}
