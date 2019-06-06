using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class H_99_01B_kyotuElapse : MonoBehaviour
{
    //k6_a:ストップウォッチ関数を使う時のおまじない。
    //updateでelapse = (float)stopwatch.Elapsed.TotalSeconds;忘れずに 
    private System.Diagnostics.Stopwatch stopwatch
        = new System.Diagnostics.Stopwatch();
    //このelapseは点滅表現で使うプログラムの共通変数として利用される
    //それによって、点滅のタイミングを完全に合わせる
    //強調表現点滅につかう時間を扱う変数
    public float elapse = 0;
    void Start() {
        //k6_aa:ストップウォッチスタート
        stopwatch.Start();
    }

    // Update is called once per frame
    void Update() {
        //k6_ac:何秒たったかを変数elapseに入れる
        elapse = (float)stopwatch.Elapsed.TotalSeconds;
        Debug.Log(elapse);
    }
}
