using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class testWtenmetu1 : MonoBehaviour
{
    //強調表現点滅に使う変数を共通変数として使う。
    public H_99_01B_kyotuElapse kyotuEla;

    public GameObject LineAB;

    private Renderer rrLineAB;

    void Start()
    {
        rrLineAB = LineAB.GetComponent<Renderer>();
    }

    // Update is called once per frame
    void Update()
    {
        rrLineAB.enabled = kyotuEla.tenmetuOnOff;
        //Debug.Log("ABBBBBB");
    }
}
