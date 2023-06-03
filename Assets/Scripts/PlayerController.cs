using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController: MonoBehaviour
{
    [SerializeField] private float gravityModifier = 0.0f;
    [SerializeField] private float jumpForce = 0.0f;
    [SerializeField] bool isOnGround;
    public bool gameOver = false; //何も書かなければprivateになる
    Rigidbody rb;
    Animator playerAnim;

    [SerializeField] ParticleSystem explosionParticle;
    [SerializeField] ParticleSystem DirtParticle;
    void Start()
    {
       rb = GetComponent<Rigidbody>();
        Physics.gravity *= gravityModifier;
        playerAnim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        //スペースキーが押されて、かつ、地面にいたら
        if (Input.GetKeyDown(KeyCode.Space) && isOnGround && !gameOver)
        {
            rb.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);
            isOnGround = false;
            playerAnim.SetTrigger("Jump_trig"); //ジャンプアニメ発動準備
        }
    }
    //衝突が起きたら実行
    private void OnCollisionEnter(Collision collision)
    {
        //ぶつかった相手(collision)のタグがgroundなら
        if (collision.gameObject.CompareTag("Ground"))
        {
            isOnGround = true;　　//地面についている状態に変更
        }
        else if (collision.gameObject.CompareTag("Obstacle"))//障害物にぶつかったら
        {
            explosionParticle.Play();//爆発
            DirtParticle.Stop();

            gameOver = true; 
            playerAnim.SetBool("Death_b", true);  //ここで死亡状態bにする（Death_bの名前は本来自分で定義できる）
            playerAnim.SetInteger("DeathType_int", 1);　　//integerは整数の意味。死亡のタイプ？を一番上にする的な

        }
    }
}
