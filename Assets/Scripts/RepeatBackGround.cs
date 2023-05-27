using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RepeatBackGround : MonoBehaviour
{
    Vector3 startPos; //リピートの開始位置
    float repeatWidth;//リピートの幅
    void Start()
    {
        startPos =transform.position; //ゲーム開始位置の場所を記憶
        repeatWidth = GetComponent<BoxCollider>().size.x / 2;
    } //背景の半分をリピート幅にする

    // Update is called once per frame
    void Update()
    {
        //何か条件が満たされたら
        if(transform.position.x < startPos.x - repeatWidth)
        {
            transform.position = startPos;
        }
  
    }
}
