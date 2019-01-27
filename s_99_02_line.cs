using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class s_99_02_line : MonoBehaviour 
{ 
     //線を引くプログラム。空のオブジェにアタッチ

    //k0014_1 :プレハブ（画面のobjでもOK）を使う objにはりつけ
    private LineRenderer lr;
    private Renderer rn;

    public Material m;

    void Start() {
        lr = GetComponent<LineRenderer>();

        lr.positionCount = 4;

        lr.startWidth = 0.05f;
        lr.endWidth = 0.05f;


        lr.SetPosition(0, new Vector3(0.0f, 0.0f, 0.0f));
        lr.SetPosition(1, new Vector3(3.0f, 3.0f, 0.0f));


        rn = GetComponent<Renderer>();

        rn.material = m;
    }
    void Update() {
    }
}
