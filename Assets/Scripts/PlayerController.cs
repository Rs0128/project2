using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController: MonoBehaviour
{
    [SerializeField] private float gravityModifier = 0.0f;
    [SerializeField] private float jumpForce = 0.0f;
    [SerializeField] bool isOnGround;
    public bool gameOver = false; //���������Ȃ����private�ɂȂ�
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
        //�X�y�[�X�L�[��������āA���A�n�ʂɂ�����
        if (Input.GetKeyDown(KeyCode.Space) && isOnGround && !gameOver)
        {
            rb.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);
            isOnGround = false;
            playerAnim.SetTrigger("Jump_trig"); //�W�����v�A�j����������
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
        else if (collision.gameObject.CompareTag("Obstacle"))//��Q���ɂԂ�������
        {
            explosionParticle.Play();//����
            DirtParticle.Stop();

            gameOver = true; 
            playerAnim.SetBool("Death_b", true);  //�����Ŏ��S���b�ɂ���iDeath_b�̖��O�͖{�������Œ�`�ł���j
            playerAnim.SetInteger("DeathType_int", 1);�@�@//integer�͐����̈Ӗ��B���S�̃^�C�v�H����ԏ�ɂ���I��

        }
    }
}
