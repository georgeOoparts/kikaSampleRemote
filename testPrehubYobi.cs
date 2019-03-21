using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class testPrehubYobi : MonoBehaviour
{
    //k0014_1 :プレハブ（画面のobjでもOK）を使う objにはりつけ
    public GameObject preTextPanel;

    public GameObject canvas;

    RectTransform rtPre;

    Text KT;

    public float px=0;
    public float py=0;

    public string coment="korejadamekaaaaaaaaa";
    // Start is called before the first frame update
    void Start()
    {
        //Debug.Log("eeeeeeeeeeeeeee"); 
        //k0014_1_1 :プレハブを使う
        GameObject ptp = Instantiate(preTextPanel) as GameObject;

        ptp.transform.SetParent(canvas.transform, false);

        rtPre = ptp.gameObject.GetComponent<RectTransform>();

        //k8_1:子(孫、ひ孫　無限にＯＫ)になっているＯＢＪを得る。
        //自分の直下の子供を得る。
        GameObject kodomeText = ptp.transform.GetChild(0).gameObject;

        KT =kodomeText.GetComponent<Text>();

        //this.gameObject.transform.parent=preTextPanel.transform;
        //messageUI.transform.SetParent(canvas.transform, false);
        Debug.Log("OKKK");

    }

    // Update is called once per frame
    void Update()
    {
        rtPre.anchoredPosition = new Vector3(px,py);

        KT.text = coment;
    }
}
