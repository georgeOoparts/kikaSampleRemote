using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class H_99_19_M1_2preRRHenka : MonoBehaviour {
    //いちいちunityで当てはめなきゃ駄目　↓---------------

    //k5_3_1_1:gameobject(メソッド、変数)を使いまわす
    public H_99_01_kyoutuHensu kyotu;

    public GameObject M1_2preLine;
    public GameObject M1_2preSLine;

    public GameObject M1_2prePoint;

    //いちいちunityで当てはめなきゃ駄目　↑---------------
    //線分を出したり消したりするときに使う Rendererを当てはめる

    private Renderer rrM1_2preLine;
    private Renderer rrM1_2preSLine;

    //点のrenderer
    private Renderer rrM1_2prePoint;

    void Start() {
        //redererを当てはめていく

        rrM1_2preLine = M1_2preLine.GetComponent<Renderer>();
        rrM1_2preSLine = M1_2preSLine.GetComponent<Renderer>();

        rrM1_2prePoint = M1_2prePoint.GetComponent<Renderer>();
    }

    // Update is called once per frame
    void Update() {
        henka(kyotu.rrCount);
        Debug.Log("M1_2hon_MS::" + kyotu.mojiSwitch + "::MC::" + kyotu.MCount + "::RRC::" + kyotu.rrCount);
    }
    //rrCountでオブジェの表示、強調を変化させるメソッド---------------------------
    private void henka(int count) 
    {
        if (count == 0) {
            reset();
            //rrTextA.enabled = true;
            //rrTextB.enabled = true;
            //rrlineAB.enabled = true;
            //rrlineSAB.enabled = kyotuEla.tenmetuOnOff;
        } else if (count == 6) {
            reset();
            //rrTextA.enabled = true;
            //rrTextB.enabled = true;
            //rrlineAB.enabled = true;
        }
    }
    //リセット表示を全部消すメソッド　kyotu.rrcount-----------------------------
    private void reset() 
    {
        //k7B_1_1:オブジェを存在するけど見えなくする。
        //this.gameObject.GetComponent<Renderer>().enabled = false; 

        //k7B_1_2:オブジェを見えるようにするよ。
        //this.gameObject.GetComponent<Renderer>().enabled = true;
        rrM1_2preLine.enabled = false;
        rrM1_2preSLine.enabled = false;

        rrM1_2prePoint.enabled = false;

    }
}
