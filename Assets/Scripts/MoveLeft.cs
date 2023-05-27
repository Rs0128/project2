using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveLeft : MonoBehaviour
{
    [SerializeField] float speed = 30; //Ground����������
    PlayerController playerControllerScript;
    float leftBound = -15; //���̌��E�l

    // Start is called before the first frame update
    private void Start()
    {
        playerControllerScript = GameObject.Find("Player").GetComponent<PlayerController>();
    }

    void Update()
    {

        //�Q�[���I�[�o�[��ԂłȂ���΁Abackground�𓮂���
        if(playerControllerScript.gameOver == false)
        {
            transform.Translate(Vector3.left * Time.deltaTime * speed);
        }
        //���̌��E�l�������ɍs���Ă��܂�����A���A���ɍs���߂����̂���Q���̃^�O�Ȃ�
        if (transform.position.x < leftBound�@&& gameObject.CompareTag("Obstacle")) 
        {
            Destroy(gameObject);//��Q���͏����Ă��܂�
        }
    }
}
