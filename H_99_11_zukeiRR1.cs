using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class H_99_11_zukeiRR1 : MonoBehaviour
{
    //k0014_1 :プレハブ（画面のobjでもOK）を使う objにはりつけ
    public GameObject line1;
    // Start is called before the first frame update
    void Start()
    {
        //k0014_1_1 :プレハブを使う
        Instantiate(line1);
        //Debug.Log("RRRRRRRRRRRRRrr");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
