using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    [SerializeField] GameObject obstaclePrefub; //��Q���v���n�u
    Vector3 spawnpos = new Vector3(25, 0, 0); //�X�|�[������ꏊ
    float elapsedTime;
    PlayerController PlayerControllerScript;
   
    private void Start()
    {
        PlayerControllerScript = GameObject.Find("Player").GetComponent<PlayerController>();
        //�v���C���[����X�N���v�g��D���Ă���C���[�W
    }

    // Update is called once per frame
    void Update()
    {
        elapsedTime += Time.deltaTime; //��F�̎��Ԃ𑫂��Ă���
        //�o�ߎ��Ԃ���b�𒴂��āA���A�Q�[���I�[�o�[�ł͂Ȃ�
        if(elapsedTime > 2.0f�@&& !PlayerControllerScript.gameOver)
        {
            Instantiate(obstaclePrefub, spawnpos, obstaclePrefub.transform.rotation);
            elapsedTime = 0.0f;
        }
        

    }
}
