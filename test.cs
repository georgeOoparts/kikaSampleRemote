﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class test : MonoBehaviour{
    //線を引くプログラム。空のオブジェにアタッチ

    //k0014_1 :プレハブ（画面のobjでもOK）を使う objにはりつけ
    public GameObject line;
    public Material m;

    private LineRenderer lr;
    private Renderer rn;

    void Start(){
        //k0014_1_1 :プレハブを使う
        Instantiate(line);

        lr = line.GetComponent<LineRenderer>();
       
        lr.positionCount = 4;

        lr.startWidth = 0.05f;
        lr.endWidth = 0.05f;

        lr.SetPosition(0, new Vector3(0.0f, 0.0f, 0.0f));
        lr.SetPosition(1, new Vector3(3.0f, 3.0f, 0.0f));


        rn = line.GetComponent<Renderer>();

        rn.material = m;
    }
    void Update(){
        
       
    }
}
