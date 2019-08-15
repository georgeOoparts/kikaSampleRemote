using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class H_99_22_BackSwitch : MonoBehaviour {
    //M1_2Objectにアタッチ、countで変化させる

    //いちいちunityで当てはめなきゃ駄目　↓---------------

    //k5_3_1_1:gameobject(メソッド、変数)を使いまわす
    public H_99_01_kyoutuHensu kyotu;
    // Start is called before the first frame update

    //public bool switchHantei=false;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        //Debug.Log("switch::" + kyotu.mojiSwitch + "::MC::" + kyotu.MCount + "::RRC::" + kyotu.rrCount);
        //Debug.Log("switch::" +switchHantei);

    }
    public void onClick() 
    {
        if(kyotu.rrCount!=0) kyotu.rrCount--;
        if (kyotu.rrCount != 0) kyotu.rrCount--;
    }
}
