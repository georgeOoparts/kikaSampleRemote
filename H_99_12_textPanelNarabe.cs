using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class H_99_12_textPanelNarabe : MonoBehaviour
{
    //k0014_1 :プレハブ（画面のobjでもOK）を使う objにはりつけ
    public GameObject paneltext;
    // Start is called before the first frame update
    void Start()
    {
        GameObject panelText1 = Instantiate(paneltext);
        //Debug.Log("ssssssssssssss");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
