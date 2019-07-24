using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class H_99_17_wCircleTriangleHenka : MonoBehaviour
{

    //いちいちunityで当てはめなきゃ駄目　↓---------------

    //k5_3_1_1:gameobject(メソッド、変数)を使いまわす
    public H_99_01_kyoutuHensu kyotu;

    //強調表現点滅に使う変数を共通変数として使う。
    public H_99_01B_kyotuElapse kyotuEla;

    public GameObject wcLineAB;
    public GameObject wcLineSAB;

    public GameObject wcLineBC;
    public GameObject wcLineSBC;

    public GameObject wcLineCA;
    public GameObject wcLineSCA;

    //public GameObject wcLineAP;
    //public GameObject wcLineSAP;

    //zukei のポイントを表すgameobject
    //アタッチするのはPPRRPointAであることに注意

    public GameObject wcPointA;
    public GameObject wcTextA;
    public GameObject wcStrongTextCubeA;

    public GameObject wcPointB;
    public GameObject wcTextB;
    public GameObject wcStrongTextCubeB;

    public GameObject wcPointC;
    public GameObject wcTextC;
    public GameObject wcStrongTextCubeC;

    public GameObject wcOyaCylinder1;
    public GameObject wcCylinder1;

    public GameObject wcOyaCylinder2;
    public GameObject wcCylinder2;

    //いちいちunityで当てはめなきゃ駄目　↑---------------
    //線分を出したり消したりするときに使う Rendererを当てはめる
    //線のrenderer
    private Renderer rrlineAB;
    private Renderer rrlineSAB;

    private Renderer rrlineBC;
    private Renderer rrlineSBC;

    private Renderer rrlineCA;
    private Renderer rrlineSCA;

    //点のrenderer
    private Renderer rrPointA;
    private Renderer rrTextA;
    private Renderer rrStrongTextCubeA;

    private Renderer rrPointB;
    private Renderer rrTextB;
    private Renderer rrStrongTextCubeB;

    private Renderer rrPointC;
    private Renderer rrTextC;
    private Renderer rrStrongTextCubeC;

    //後ろの２つの円のrenderer
    private Renderer rrOyaCylinder1;
    private Renderer rrCylinder1;

    private Renderer rrOyaCylinder2;
    private Renderer rrCylinder2;

    void Start()
    {
        //redererを当てはめていく
        rrlineAB = wcLineAB.GetComponent<Renderer>();
        rrlineSAB = wcLineSAB.GetComponent<Renderer>();

        rrlineBC = wcLineBC.GetComponent<Renderer>();
        rrlineSBC = wcLineSBC.GetComponent<Renderer>();

        rrlineCA = wcLineCA.GetComponent<Renderer>();
        rrlineSCA = wcLineSCA.GetComponent<Renderer>();

        rrPointA = wcPointA.GetComponent<Renderer>();
        rrTextA = wcTextA.GetComponent<Renderer>();
        rrStrongTextCubeA = wcStrongTextCubeA.GetComponent<Renderer>();

        rrPointB = wcPointB.GetComponent<Renderer>();
        rrTextB = wcTextB.GetComponent<Renderer>();
        rrStrongTextCubeB = wcStrongTextCubeB.GetComponent<Renderer>();

        rrPointC = wcPointC.GetComponent<Renderer>();
        rrTextC = wcTextC.GetComponent<Renderer>();
        rrStrongTextCubeC = wcStrongTextCubeC.GetComponent<Renderer>();

        // 後ろの２つの円のrenderer
        rrOyaCylinder1=wcOyaCylinder1.GetComponent<Renderer>();
        rrCylinder1= wcCylinder1.GetComponent<Renderer>();

        rrOyaCylinder2 = wcOyaCylinder2.GetComponent<Renderer>();
        rrCylinder2 = wcCylinder2.GetComponent<Renderer>();
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log("MS::" + kyotu.mojiSwitch + "::MC::" + kyotu.MCount + "::RRC::" + kyotu.rrCount);

    }
}
