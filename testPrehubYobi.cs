using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class testPrehubYobi : MonoBehaviour
{
    //k0014_1 :プレハブ（画面のobjでもOK）を使う objにはりつけ
    public GameObject preTextPanel;

    public GameObject canvas;
    // Start is called before the first frame update
    void Start()
    {
        //Debug.Log("eeeeeeeeeeeeeee"); 
        //k0014_1_1 :プレハブを使う
        GameObject ptp = Instantiate(preTextPanel) as GameObject;

        ptp.transform.SetParent(canvas.transform, false);

        //this.gameObject.transform.parent=preTextPanel.transform;
        //messageUI.transform.SetParent(canvas.transform, false);

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
