using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MyObject : MonoBehaviour
{


    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // 左に移動
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            this.transform.Translate(-1.0f, 0.0f, 0.0f);
        }
        // 右に移動
        if (Input.GetKey(KeyCode.RightArrow))
        {
            this.transform.Translate(1.0f, 0.0f, 0.0f);
        }
        // 前に移動
        if (Input.GetKey(KeyCode.UpArrow))
        {
            this.transform.Translate(0.0f, 0.0f, 1.0f);
        }
        // 後ろに移動
        if (Input.GetKey(KeyCode.DownArrow))
        {
            this.transform.Translate(0.0f, 0.0f, -1.0f);
        }


        //ポーズ画面遷移
        if (Input.GetKey(KeyCode.P))
        {
            SceneManager.LoadScene("PoseScreen");
        }

        //ゲームオーバー画面遷移
        if (Input.GetKey(KeyCode.LeftShift))
        {
            if (Input.GetKey(KeyCode.O))
            {
                SceneManager.LoadScene("GameOver");
            }
        }
        //ゲームクリア画面遷移
        if (Input.GetKey(KeyCode.LeftShift))
        {
            if (Input.GetKey(KeyCode.C))
            {
                SceneManager.LoadScene("GameClear");
            }
        }

        if (Input.GetKey(KeyCode.LeftShift))
        {
            if (Input.GetKey(KeyCode.P))
            {
                SceneManager.LoadScene("PoseScreen");
            }
                
        }




    }
}
