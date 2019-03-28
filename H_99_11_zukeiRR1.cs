using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class H_99_11_zukeiRR1 : MonoBehaviour
{
    //k0014_1 :プレハブ（画面のobjでもOK）を使う objにはりつけ
    public GameObject line;

    //プレハブから呼び出したlineを実際に当てはめる変数
    List<GameObject> L = new List<GameObject>();

    //k0015_99_1 :線を引くline回り　オブジェにラインをくっつける
    List<LineRenderer> LR =new List<LineRenderer>();

    public float upDown = 1;
    //public float rightLeft = 0;

    void Start()
    {
        //k0014_1_1 :プレハブを使う
        L.Add(Instantiate(line)as GameObject);
        L.Add(Instantiate(line) as GameObject);
        L.Add(Instantiate(line) as GameObject);
       

        //k0015_99_1 :線を引くline回り　オブジェにラインをくっつける
        LR.Add(L[0].GetComponent<LineRenderer>());
        LR.Add(L[1].GetComponent<LineRenderer>());
        LR.Add(L[2].GetComponent<LineRenderer>());
       
        //k0015_99_1_2 :頂点の数（この場合２つ）
        LR[0].positionCount = 2;
        LR[1].positionCount = 2;
        LR[2].positionCount = 2;

            }

    // Update is called once per frame
    void Update()
    {
        //k0015_99_1_3 :頂点を設定（どこからどこまで線を伸ばすか）
        LR[0].SetPosition(0, new Vector3(9.2f, 0f+upDown, -3f));
        LR[0].SetPosition(1, new Vector3(13.2f, 0f + upDown, -3f));

        LR[1].SetPosition(0, new Vector3(13.2f, 0f + upDown, -3f));
        LR[1].SetPosition(1, new Vector3(11.2f, 3.46f + upDown, -3f));

        LR[2].SetPosition(0, new Vector3(11.2f, 3.46f + upDown, -3f));
        LR[2].SetPosition(1, new Vector3(9.2f, 0f + upDown, -3f));

    }
}
