using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class H_99_11_zukeiRR1 : MonoBehaviour
{
    //k0014_1 :プレハブ（画面のobjでもOK）を使う objにはりつけ
    public GameObject line1;
    public GameObject line2;
    public GameObject line3;

    // Start is called before the first frame update
    void Start()
    {
        //k0015_99_1 :線を引くline回り　オブジェにラインをくっつける
        LineRenderer LR1 = line1.GetComponent<LineRenderer>();
        LineRenderer LR2 = line2.GetComponent<LineRenderer>();
        LineRenderer LR3 = line3.GetComponent<LineRenderer>();

        //k0015_99_1_2 :頂点の数（この場合２つ）
        LR1.positionCount = 2;
        LR2.positionCount = 2;
        LR3.positionCount = 2;

        //k0015_99_1_3 :頂点を設定（どこからどこまで線を伸ばすか）
        LR1.SetPosition(0, new Vector3(9.6f, 0f, 0f));
        LR1.SetPosition(1, new Vector3(13.6f, 0f, 0f));

        LR2.SetPosition(0, new Vector3(13.6f, 0f, 0f));
        LR2.SetPosition(1, new Vector3(13.6f, 3f, 0f));

        LR3.SetPosition(0, new Vector3(13.6f, 3f, 0f));
        LR3.SetPosition(1, new Vector3(9.6f, 0f, 0f));

        //k0014_1_1 :プレハブを使う
        Instantiate(line1);
        Instantiate(line2);
        Instantiate(line3);

        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
