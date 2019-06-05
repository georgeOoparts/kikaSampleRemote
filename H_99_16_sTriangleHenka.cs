using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class H_99_16_sTriangleHenka : MonoBehaviour
{
    //sampletriangeにアタッチ、zukeiの表示変化するプログラム
    //いっぱいインスペで当てはめるオブジェが有る。
    //zukei のポイントを表すApoint、Bpoint、Cpointは
    //アタッチするのはPPRRPointAであることに注意

    //k5_3_1_1:gameobject(メソッド、変数)を使いまわす
    //k5_3_1_1_1:gameobject(メソッド、変数)を使いまわす

    H_99_01_kyoutuHensu kyotu;

    public GameObject lineAB;
    public GameObject lineSAB;

    public GameObject lineBC;
    public GameObject lineSBC;

    public GameObject lineCA;
    public GameObject lineSCA;

    public GameObject lineAP;
    public GameObject lineSAP;

    //zukei のポイントを表すgameobject
    //アタッチするのはPPRRPointAであることに注意

    public GameObject pointA;
    public GameObject textA;
    public GameObject strongTextCubeA;

    public GameObject pointB;
    public GameObject textB;
    public GameObject strongTextCubeB;

    public GameObject pointC;
    public GameObject textC;
    public GameObject strongTextCubeC;

    //public GameObject pointP;
    //public GameObject textP;
    //public GameObject strongTextCubeP;

    void Start()
    {
        Debug.Log("wwwwwwwwwwwwwwww"+pointC.name);    
    }

    void Update()
    {
        
    }
}
