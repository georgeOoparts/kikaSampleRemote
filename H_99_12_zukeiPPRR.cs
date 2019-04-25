using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class H_99_12_zukeiPPRR : MonoBehaviour
{
    //PPRRのzukei変化をコントロールするプルグラム
    //ターンは共通変数のrrCountで進む
    //rrcountはtestPrehubYobi2で進むようにしてある。

    //k5_3_1_1:gameobject(メソッド、変数)を使いまわす
    public H_99_01_kyoutuHensu kyotu;

    //k5_3_1_1_1:gameobject(メソッド、変数)を使いまわす
    //yosu.cube1で普通に使える
    void Start()
    {
        
    }

    void Update()
    {
        Debug.Log("zykei" + kyotu.rrCount);
    }
}
