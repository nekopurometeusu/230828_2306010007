using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class OverDierctor : MonoBehaviour
{

 

    // Update is called once per frame
    void Update()
    {
        //マウスがクリックされた時に画面を移動する（シーンが移動する）
        if (Input.GetMouseButtonDown(0))
        {
            SceneManager.LoadScene("SampleScene");
        }
    }
}
