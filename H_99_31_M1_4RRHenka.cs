using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class H_99_31_M1_4RRHenka : MonoBehaviour
{
    //M1_3preにアタッチ。オブジェクト全体のいどうをするプログラム
    //いちいちunityで当てはめなきゃ駄目　↓---------------

    //k5_3_1_1:gameobject(メソッド、変数)を使いまわす
    public H_99_01_kyoutuHensu kyotu;

    public GameObject M1_4LineAB;
    public GameObject M1_4LineBC;
    public GameObject M1_4LineCA;
    public GameObject M1_4LineDE;
    public GameObject M1_4LineEF;
    public GameObject M1_4LineFD;

    public GameObject M1_4LineStAB;
    public GameObject M1_4LineStBC;
    public GameObject M1_4LineStCA;
    public GameObject M1_4LineStDE;
    public GameObject M1_4LineStEF;
    public GameObject M1_4LineStFD;

    public GameObject M1_4PointA;
    public GameObject M1_4PointB;
    public GameObject M1_4PointC;
    public GameObject M1_4PointD;
    public GameObject M1_4PointE;
    public GameObject M1_4PointF;

    public GameObject M1_4PointStA;
    public GameObject M1_4PointStB;
    public GameObject M1_4PointStC;
    public GameObject M1_4PointStD;
    public GameObject M1_4PointStE;
    public GameObject M1_4PointStF;

    public GameObject M1_4TextA;
    public GameObject M1_4TextB;
    public GameObject M1_4TextC;
    public GameObject M1_4TextD;
    public GameObject M1_4TextE;
    public GameObject M1_4TextF;

    public GameObject M1_4kakuABC;
    public GameObject M1_4kakuStABC;
    public GameObject M1_4kakuDEF;
    public GameObject M1_4kakuStDEF;

    private Renderer rrM1_4LineAB;
    private Renderer rrM1_4LineBC;
    private Renderer rrM1_4LineCA;
    private Renderer rrM1_4LineDE;
    private Renderer rrM1_4LineEF;
    private Renderer rrM1_4LineFD;

    private Renderer rrM1_4LineStAB;
    private Renderer rrM1_4LineStBC;
    private Renderer rrM1_4LineStCA;
    private Renderer rrM1_4LineStDE;
    private Renderer rrM1_4LineStEF;
    private Renderer rrM1_4LineStFD;

    private Renderer rrM1_4PointA;
    private Renderer rrM1_4PointB;
    private Renderer rrM1_4PointC;
    private Renderer rrM1_4PointD;
    private Renderer rrM1_4PointE;
    private Renderer rrM1_4PointF;

    private Renderer rrM1_4PointStA;
    private Renderer rrM1_4PointStB;
    private Renderer rrM1_4PointStC;
    private Renderer rrM1_4PointStD;
    private Renderer rrM1_4PointStE;
    private Renderer rrM1_4PointStF;

    private Renderer rrM1_4TextA;
    private Renderer rrM1_4TextB;
    private Renderer rrM1_4TextC;
    private Renderer rrM1_4TextD;
    private Renderer rrM1_4TextE;
    private Renderer rrM1_4TextF;

    private Renderer rrM1_4kakuABC;
    private Renderer rrM1_4kakuStABC;
    private Renderer rrM1_4kakuDEF;
    private Renderer rrM1_4kakuStDEF;

    void Start()
    {
        rrM1_4LineAB=M1_4LineAB.GetComponent<Renderer>();
        rrM1_4LineBC = M1_4LineBC.GetComponent<Renderer>();
        rrM1_4LineCA = M1_4LineCA.GetComponent<Renderer>();
        rrM1_4LineDE = M1_4LineDE.GetComponent<Renderer>();
        rrM1_4LineEF = M1_4LineEF.GetComponent<Renderer>();
        rrM1_4LineFD = M1_4LineFD.GetComponent<Renderer>();

        rrM1_4LineStAB = M1_4LineStAB.GetComponent<Renderer>();
        rrM1_4LineStBC = M1_4LineStBC.GetComponent<Renderer>();
        rrM1_4LineStCA = M1_4LineStCA.GetComponent<Renderer>();
        rrM1_4LineStDE = M1_4LineStDE.GetComponent<Renderer>();
        rrM1_4LineStEF = M1_4LineStEF.GetComponent<Renderer>();
        rrM1_4LineStFD = M1_4LineStFD.GetComponent<Renderer>();

        rrM1_4PointA = rrM1_4PointA.GetComponent<Renderer>();
        rrM1_4PointB = rrM1_4PointB.GetComponent<Renderer>();
        rrM1_4PointC = rrM1_4PointC.GetComponent<Renderer>();
        rrM1_4PointD = rrM1_4PointD.GetComponent<Renderer>();
        rrM1_4PointE = rrM1_4PointE.GetComponent<Renderer>();
        rrM1_4PointF = rrM1_4PointF.GetComponent<Renderer>();

        rrM1_4PointStA = rrM1_4PointStA.GetComponent<Renderer>();
        rrM1_4PointStB = rrM1_4PointStB.GetComponent<Renderer>();
        rrM1_4PointStC = rrM1_4PointStC.GetComponent<Renderer>();
        rrM1_4PointStD = rrM1_4PointStD.GetComponent<Renderer>();
        rrM1_4PointStE = rrM1_4PointStE.GetComponent<Renderer>();
        rrM1_4PointStF = rrM1_4PointStF.GetComponent<Renderer>();

        rrM1_4TextA = rrM1_4TextA.GetComponent<Renderer>();
        rrM1_4TextB = rrM1_4TextB.GetComponent<Renderer>();
        rrM1_4TextC = rrM1_4TextC.GetComponent<Renderer>();
        rrM1_4TextD = rrM1_4TextD.GetComponent<Renderer>();
        rrM1_4TextE = rrM1_4TextE.GetComponent<Renderer>();
        rrM1_4TextF = rrM1_4TextF.GetComponent<Renderer>();

        rrM1_4kakuABC = rrM1_4kakuABC.GetComponent<Renderer>();
        rrM1_4kakuStABC = rrM1_4kakuStABC.GetComponent<Renderer>();
        rrM1_4kakuDEF = rrM1_4kakuDEF.GetComponent<Renderer>();
        rrM1_4kakuStDEF = rrM1_4kakuStDEF.GetComponent<Renderer>();

    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log("M1_4RRHenka::" + kyotu.mojiSwitch + "::MC::" + kyotu.MCount + "::RRC::" + kyotu.rrCount);

    }
}
