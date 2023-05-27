using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RepeatBackGround : MonoBehaviour
{
    Vector3 startPos; //���s�[�g�̊J�n�ʒu
    float repeatWidth;//���s�[�g�̕�
    void Start()
    {
        startPos =transform.position; //�Q�[���J�n�ʒu�̏ꏊ���L��
        repeatWidth = GetComponent<BoxCollider>().size.x / 2;
    } //�w�i�̔��������s�[�g���ɂ���

    // Update is called once per frame
    void Update()
    {
        //�����������������ꂽ��
        if(transform.position.x < startPos.x - repeatWidth)
        {
            transform.position = startPos;
        }
  
    }
}
