using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Goal : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    //ゴールに触れたら終わる
    private void OnCollisionEnter(Collision collision)
    {
        SceneManager.LoadScene("GameClear");
    }
}
