using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    [SerializeField] GameObject obstaclePrefub; //障害物プレハブ
    Vector3 spawnpos = new Vector3(25, 0, 0); //スポーンする場所
    float elapsedTime;
    PlayerController PlayerControllerScript;
   
    private void Start()
    {
        PlayerControllerScript = GameObject.Find("Player").GetComponent<PlayerController>();
        //プレイヤーからスクリプトを奪ってくるイメージ
    }

    // Update is called once per frame
    void Update()
    {
        elapsedTime += Time.deltaTime; //毎Fの時間を足していく
        //経過時間が二秒を超えて、かつ、ゲームオーバーではない
        if(elapsedTime > 2.0f　&& !PlayerControllerScript.gameOver)
        {
            Instantiate(obstaclePrefub, spawnpos, obstaclePrefub.transform.rotation);
            elapsedTime = 0.0f;
        }
        

    }
}
