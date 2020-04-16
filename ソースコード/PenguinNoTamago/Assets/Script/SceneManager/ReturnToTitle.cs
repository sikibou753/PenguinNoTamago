using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class ReturnToTitle : MonoBehaviour
{
    // Start is called before the first frame update

    public int timeCount;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // 任意に設定した時間の経過後、「GoTitle」メソッドを呼び出す（ポイント）
        Invoke("GoTitle", timeCount);
    }
    void GoTitle()
    {
        if (Input.GetButtonDown("Start"))
        {
            SceneManager.LoadScene("Title");
        }
        
    }
    
}
