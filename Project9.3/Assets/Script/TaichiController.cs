using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TaichiController : MonoBehaviour
{
    //オブジェクトの速度
    public float speed = 0.05f;
    //オブジェクトの横移動の最大距離
    public float max_z = 1.0f;

    // Update is called once per frame
    void Update()
    {
        //フレーム毎speedの値分だけx軸方向に移動する
        this.gameObject.transform.Translate(0, 0, speed);

        //Transformのxの値が一定値を超えたときに向きを反対にする
        if (this.gameObject.transform.position.x > max_z || this.gameObject.transform.position.x < (-max_z))
        {
            speed *= 0;
        }

    }
}