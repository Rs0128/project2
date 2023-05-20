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
        //�X�y�[�X�L�[��������āA���A�n�ʂɂ�����
        if (Input.GetKeyDown(KeyCode.Space) && isOnGround)
        {
            rb.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);
            isOnGround = false;
        }
    }
    //�Փ˂��N��������s
    private void OnCollisionEnter(Collision collision)
    {
        //�Ԃ���������(collision)�̃^�O��ground�Ȃ�
        if (collision.gameObject.CompareTag("Ground"))
        {
            isOnGround = true;�@�@//�n�ʂɂ��Ă����ԂɕύX
        }
    }
}
