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

    public H_99_01_kyoutuHensu kyotu;

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
    private Renderer rrlineAB;
    private Renderer rrlineSAB;

    private Renderer rrlineBC;
    private Renderer rrlineSBC;

    private Renderer rrlineCA;
    private Renderer rrlineSCA;

    private Renderer rrPointA;
    private Renderer rrTextA;
    private Renderer rrStrongTextCubeA;

    private Renderer rrPointB;
    private Renderer rrTextB;
    private Renderer rrStrongTextCubeB;

    private Renderer rrPointC;
    private Renderer rrTextC;
    private Renderer rrStrongTextCubeC;

    void Start()
    {
        rrlineAB = lineAB.GetComponent<Renderer>();
        rrlineSAB = lineSAB.GetComponent<Renderer>();

        rrlineBC = lineBC.GetComponent<Renderer>();
        rrlineSBC = lineSBC.GetComponent<Renderer>();

        rrlineCA = lineCA.GetComponent<Renderer>();
        rrlineSCA = lineSCA.GetComponent<Renderer>();

        rrPointA = pointA.GetComponent<Renderer>();
        rrTextA = textA.GetComponent<Renderer>();
        rrStrongTextCubeA = strongTextCubeA.GetComponent<Renderer>();

        rrPointB = pointB.GetComponent<Renderer>();
        rrTextB = textB.GetComponent<Renderer>();
        rrStrongTextCubeB = strongTextCubeB.GetComponent<Renderer>();

        rrPointC = pointC.GetComponent<Renderer>();
        rrTextC = textC.GetComponent<Renderer>();
        rrStrongTextCubeC = strongTextCubeC.GetComponent<Renderer>();
    }

    void Update()
    {
        //k7B_1_1:オブジェを存在するけど見えなくする。
        //this.gameObject.GetComponent<Renderer>().enabled = false; 

        //k7B_1_2:オブジェを見えるようにするよ。
        //this.gameObject.GetComponent<Renderer>().enabled = true;
        //k5_3_1_1_1:gameobject(メソッド、変数)を使いまわす
        rrlineAB.enabled = false;
        rrlineSAB.enabled = false;

        rrlineBC.enabled = false;
        rrlineSBC.enabled = false;

        rrlineCA.enabled = false;
        rrlineSCA.enabled = false;

        rrPointA.enabled = false;
        rrTextA.enabled = false;
        rrStrongTextCubeA.enabled = false;

        rrPointB.enabled = false;
        rrTextB.enabled = false;
        rrStrongTextCubeB.enabled = false;

        rrPointC.enabled = false;
        rrTextC.enabled = false;
        rrStrongTextCubeC.enabled = false;

        Debug.Log("wwwwwwwwwwwwwwww" + kyotu.rrCount);
    }
}
