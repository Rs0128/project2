using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController: MonoBehaviour
{
    Rigidbody rb;
    [SerializeField] float gravityModifier;
    [SerializeField] float jumpForce;
    [SerializeField] bool isOnGround;
    // Start is called before the first frame update
    void Start()
    {
       rb = GetComponent<Rigidbody>();
        Physics.gravity *= gravityModifier;
    }

    // Update is called once per frame
    void Update()
    {
        //スペースキーが押されて、かつ、地面にいたら
        if (Input.GetKeyDown(KeyCode.Space) && isOnGround)
        {
            rb.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);
            isOnGround = false;
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
    }
}
