using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RepeatBackGround : MonoBehaviour
{
    Vector3 startPos; //リピートの開始位置
    void Start()
    {
        startPos =transform.position; //ゲーム開始位置の場所を記憶
    }

    // Update is called once per frame
    void Update()
    {
        //何か条件が満たされたら
        if(startPos.x - transform.position.x > 10.0f)
        {

        }
    }
}
