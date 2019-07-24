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
        henka(kyotu.rrCount);
        Debug.Log("MS::" + kyotu.mojiSwitch + "::MC::" + kyotu.MCount + "::RRC::" + kyotu.rrCount);

    }
    //rrCountでオブジェの表示、強調を変化させるメソッド---------------------------
    private void henka(int count) 
    {
        if (count == 5) 
        {
            reset();
            rrTextA.enabled = true;
            rrTextB.enabled = true;
            rrlineAB.enabled = true;
            rrlineSAB.enabled = kyotuEla.tenmetuOnOff;
        }
        else if(count == 6) 
        {
            reset();
            rrTextA.enabled = true;
            rrTextB.enabled = true;
            rrlineAB.enabled = true;
        } 
        else if (count == 7) 
        {
            reset();
            rrTextA.enabled = true;
            rrTextB.enabled = true;
            rrlineAB.enabled = true;
            rrlineSAB.enabled = kyotuEla.tenmetuOnOff;
        } 
        else if (count == 8) {
            reset();
            rrTextA.enabled = true;
            rrTextB.enabled = true;

            rrlineAB.enabled = true;
            rrlineSAB.enabled = kyotuEla.tenmetuOnOff;
            rrlineBC.enabled = true;
            rrlineSBC.enabled = kyotuEla.tenmetuOnOff;
            rrlineCA.enabled = true;
            rrlineSCA.enabled = kyotuEla.tenmetuOnOff;
        } 
        else if (count == 9) 
        {
            reset();
            rrTextA.enabled = true;
            rrTextB.enabled = true;

            rrlineAB.enabled = true;
            rrlineBC.enabled = true;
            rrlineCA.enabled = true;
        } 
        else if (count == 10) 
        {
            reset();

            rrTextA.enabled = true;

            rrTextB.enabled = true;

            rrlineAB.enabled = true;
            rrlineBC.enabled = true;
            rrlineCA.enabled = true;

            rrPointA.enabled= kyotuEla.tenmetuOnOff;

        } 
        else if (count == 11) 
        {
            reset();

            rrTextA.enabled = true;

            rrTextB.enabled = true;

            rrlineAB.enabled = true;
            rrlineBC.enabled = true;
            rrlineCA.enabled = true;

            rrlineSAB.enabled = kyotuEla.tenmetuOnOff;


        } 
        else if (count == 12) 
        {
            reset();
        } 
        else if (count == 13) 
        {
            reset();
        } 
        else if (count == 14) 
        {
            reset();
        } 
        else if (count == 15) 
        {
            reset();
        } 
        else if (count == 16) 
        {
            reset();
        } 
        else if (count == 17) 
        {
            reset();
        } 
        else if (count == 18) 
        {
            reset();
        } 
        else if (count == 19) 
        {
            reset();
        } 
        else if (count == 20) 
        {
            reset();
        }
    }
    //リセット表示を全部消すメソッド　kyotu.rrcount-----------------------------
    private void reset() 
    {
        //k7B_1_1:オブジェを存在するけど見えなくする。
        //this.gameObject.GetComponent<Renderer>().enabled = false; 

        //k7B_1_2:オブジェを見えるようにするよ。
        //this.gameObject.GetComponent<Renderer>().enabled = true;
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

        // 後ろの２つの円のrenderer
        rrOyaCylinder1.enabled = false;
        rrCylinder1.enabled = false;

        rrOyaCylinder2.enabled = false;
        rrCylinder2.enabled = false;
    }

}
