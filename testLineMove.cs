using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class testLineMove : MonoBehaviour
{
    public GameObject KA_4Line1;

    public GameObject KA_4Line2;

    //k0013_1: 宣言 
    private Transform trKA_4Line1B;

    private Transform trKA_4Line2B;

    //k0013_1_1_1 オブジェ移動；オブジェの座標;z軸そのまま：オブジェのポジションを得る
    //page.position = new Vector3((float)-2.8, -5, page.position.z);

    //k0013_1_1_2 オブジェのx,y,z幅　取得　；変化させる；
    //page.localScale = new Vector3((float)-2.8, -5, page.position.z);
    void Start()
    {
        //k0013_1_1;オブジェに当てはめる；
        trKA_4Line1B = KA_4Line1.gameObject.GetComponent<Transform>();

        trKA_4Line2B = KA_4Line2.gameObject.GetComponent<Transform>();

    }
    public float sitaV = 2f;
    // Update is called once per frame
    void Update()
    {
        //k0013_1_1_1 オブジェ移動；オブジェの座標;z軸そのまま：オブジェのポジションを得る
        //trKA_4Line1.position = new Vector3(13f, 0f, trKA_4Line1.position.z);
        if (trKA_4Line1B.localPosition.y > 1.5f) {
            trKA_4Line1B.position += new Vector3(0, -0.01f*sitaV, 0);
            trKA_4Line2B.position += new Vector3(0, 0.01f * sitaV, 0);
        } 
        else 
        {
            trKA_4Line1B.localPosition = new Vector3(0, 1.5f, 0);
            trKA_4Line2B.localPosition = new Vector3(0, 1.5f, 0);
        }
    }
}
