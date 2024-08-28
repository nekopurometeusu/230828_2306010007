using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Unity.VisualScripting;
using UnityEngine.SceneManagement;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    //�d��
    Rigidbody2D rigidbody2D;
    //�W�����v����Ƃ��̗�
    float jumpForce = 680.0f;
    ////�A�j���[�V����
     Animator animator;
    //�������̗�
    float walkForce = 30.0f;
    float maxWalkSpeed = 2.0f;
    // Start is called before the first frame update
    void Start()
    {
        //�t���[���J�E���g
        Application.targetFrameRate = 60;
        //Rigdbody���R���|�[�l���g
        this.rigidbody2D = GetComponent<Rigidbody2D>();
        this.animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space)&&rigidbody2D.velocity.y==0)
        {
            this.rigidbody2D.AddForce(transform.up * this.jumpForce);
            this.animator.SetTrigger("jump");
        }
        //���E�Ɉړ�
        int key = 0;
        if (Input.GetKey/*Down*/(KeyCode.RightArrow))
        {
            key = 1;
        }
        if (Input.GetKey/*Down*/(KeyCode.LeftArrow))
        {
            key = -1;
        }

        //�v���C���[�̑��x
        float sppedx = Mathf.Abs(this.rigidbody2D.velocity.x);

        //�X�s�[�h����
        if (sppedx < this.maxWalkSpeed)
        {
            this.rigidbody2D.AddForce(transform.right * key * this.walkForce);
        }
        //���������Ŕ��]������
        if (key != 0)
        {
            transform.localScale = new Vector3(key, 1, 1);
        }

        if (this.transform.position.y == 0)
        {
            this.animator.speed = sppedx / 0.75f;
        }
        else
        {
            this.animator.speed = 1.0f;
        }
        if(transform.position.y<-10||transform.position.x<-4||transform.position.x>4)
        {
            SceneManager.LoadScene("OverDierctor");
        }
        //��ʏ�ɏo�Ȃ��悤�ɂ���
        else if(transform.position.y>17)
        {
            this.transform.position=new Vector3(transform.position.x,17,transform.position.z);
        }
        
    }
    
    //�S�[���ɓ���
    private void OnTriggerEnter2D(Collider2D other)
    {
        Debug.Log("Goal");
        if(other.tag=="Goal")
        {
            SceneManager.LoadScene("ClearDierctor");
        }
    }
  
}
