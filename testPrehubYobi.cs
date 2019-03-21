using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class testPrehubYobi : MonoBehaviour
{
    //k0014_2 :プレハブ（画面のobjでもOK）を使う objにはりつけ
    public GameObject preTextPanel;

    public GameObject canvas;

    RectTransform rtPre;

    Text KT;

    public float px=0;
    public float py=0;

    public string coment="korejadamekaaaaaaaaa";

    GameObject kodomeText;
    // Start is called before the first frame update
    void Start()
    {
        //k0014_2_1 :プレハブを使う
        GameObject ptp1 = Instantiate(preTextPanel) as GameObject;

        GameObject ptp2 = Instantiate(preTextPanel) as GameObject;

        GameObject ptp3 = Instantiate(preTextPanel) as GameObject;
        //k0014_2_1_1 :プレハブをキャンバスの子供にする()
        ptp1.transform.SetParent(canvas.transform, false);
        ptp2.transform.SetParent(canvas.transform, false);
        ptp3.transform.SetParent(canvas.transform, false);

        rtPre = ptp1.gameObject.GetComponent<RectTransform>();

        //k8_1:子(孫、ひ孫　無限にＯＫ)になっているＯＢＪを得る。
        //自分の直下の子供を得る。
        kodomeText = ptp1.transform.GetChild(0).gameObject;

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
