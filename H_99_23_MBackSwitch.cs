using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class H_99_23_MBackSwitch : MonoBehaviour
{
    //M1_2Objectにアタッチ、countで変化させる

    //いちいちunityで当てはめなきゃ駄目　↓---------------

    //k5_3_1_1:gameobject(メソッド、変数)を使いまわす
    public H_99_01_kyoutuHensu kyotu;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void onMBackSwitch() {
        if (kyotu.MCount!=0)kyotu.MCount--;
        
        
        kyotu.rrCount = 0;
        
       
    }
}
