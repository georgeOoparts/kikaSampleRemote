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
    //線分を出したり消したりするときに使う 



    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log("MS::" + kyotu.mojiSwitch + "::MC::" + kyotu.MCount + "::RRC::" + kyotu.rrCount);

    }
}
