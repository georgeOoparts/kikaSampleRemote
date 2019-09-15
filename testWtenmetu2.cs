using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class testWtenmetu2 : MonoBehaviour
{
    //強調表現点滅に使う変数を共通変数として使う。
    public H_99_01B_kyotuElapse kyotuEla;

    public GameObject LineAC;

    private Renderer rrLineAC;
    void Start()
    {
        rrLineAC = LineAC.GetComponent<Renderer>();

    }

    // Update is called once per frame
    void Update()
    {
        rrLineAC.enabled = !(kyotuEla.tenmetuOnOff);

        //Debug.Log("CDDDDDD");
    }
}
