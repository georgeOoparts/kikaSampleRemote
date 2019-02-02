using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class s_99_05_oyaCubeMove : MonoBehaviour
{
    public GameObject oyaCube;
    //k0013_1: 宣言 
    Transform oyaCubeTr;

    public float oyaCubeMove = -5.0f;

    // Start is called before the first frame update
    void Start()
    {
        //k0013_1_1;オブジェに当てはめる；
        oyaCubeTr = oyaCube.GetComponent<Transform>();
        
    }

    // Update is called once per frame
    void Update()
    {
        //k0013_1_1_1 オブジェ移動；オブジェの座標;z軸そのまま：オブジェのポジションを得る
        oyaCubeTr.position = new Vector3(oyaCubeTr.position.x, oyaCubeMove, oyaCubeTr.position.z);
    }
}
