using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RepeatBackGround : MonoBehaviour
{
    Vector3 startPos; //���s�[�g�̊J�n�ʒu
    void Start()
    {
        startPos =transform.position; //�Q�[���J�n�ʒu�̏ꏊ���L��
    }

    // Update is called once per frame
    void Update()
    {
        //�����������������ꂽ��
        if(startPos.x - transform.position.x > 10.0f)
        {

        }
    }
}
