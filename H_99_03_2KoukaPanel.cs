using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//k7_1:Imageコンポーネントを使う
using UnityEngine.UI;

public class H_99_03_2KoukaPanel : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //k7_1_1:オブジェを存在するけど見えなくする。
        this.gameObject.GetComponent<Image>().enabled = false;

        //k7_1_2:オブジェを見えるようにするよ。
        this.gameObject.GetComponent<Image>().enabled = true;
    }
}
