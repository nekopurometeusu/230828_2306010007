using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class OverDierctor : MonoBehaviour
{

 

    // Update is called once per frame
    void Update()
    {
        //�}�E�X���N���b�N���ꂽ���ɉ�ʂ��ړ�����i�V�[�����ړ�����j
        if (Input.GetMouseButtonDown(0))
        {
            SceneManager.LoadScene("SampleScene");
        }
    }
}
