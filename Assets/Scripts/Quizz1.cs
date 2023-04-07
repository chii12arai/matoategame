using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Quizz1 : MonoBehaviour
{
    // Update is called once per frame
    void Update()
    {
        // Input.GetKeyUpはキーが一度押された後、それが離された時にTrueを返す
        // KeyCode.Spaceはスペースキーを表す
        if (Input.GetKeyUp(KeyCode.Space))
        {
            // 力を加える向きは変数forceでVector3型で定義
            // Vector3 force = new Vector3(x軸への力,y軸への力,z軸への力)
            Vector3 force = new Vector3(0.0f, 6.5f, 5.0f);

            // SphereオブジェクトのRigidbodyコンポーネントへの参照を取得
            Rigidbody rb = gameObject.GetComponent<Rigidbody>();

            // 力を加えるメソッド
            // 力の加わり方はForceModeから選べる
            // ForceMode.Impulseは撃力
            rb.AddForce(force, ForceMode.Impulse);
        }

    }
}
