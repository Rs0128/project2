using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveLeft : MonoBehaviour
{
    [SerializeField] float speed = 30; //Groundが動く速さ
    PlayerController playerControllerScript;
    float leftBound = -15; //左の限界値

    // Start is called before the first frame update
    private void Start()
    {
        playerControllerScript = GameObject.Find("Player").GetComponent<PlayerController>();
    }

    void Update()
    {

        //ゲームオーバー状態でなければ、backgroundを動かす
        if(playerControllerScript.gameOver == false)
        {
            transform.Translate(Vector3.left * Time.deltaTime * speed);
        }
        //左の限界値よりも左に行ってしまったら、かつ、左に行き過ぎたのが障害物のタグなら
        if (transform.position.x < leftBound　&& gameObject.CompareTag("Obstacle")) 
        {
            Destroy(gameObject);//障害物は消してしまう
        }
    }
}
