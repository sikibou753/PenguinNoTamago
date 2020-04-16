using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;
public class PauseScript : MonoBehaviour
{

    //　ポーズした時に表示するUI
    [SerializeField]
    //　ポーズした時に表示するUIのプレハブ
    private GameObject pauseUIPrefab;
    //　ポーズUIのインスタンス
    private GameObject pauseUIInstance;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Select"))
        {
            if (pauseUIInstance == null)
            {
                pauseUIInstance = GameObject.Instantiate(pauseUIPrefab) as GameObject;
                Time.timeScale = 0f;
            }
            else
            {
                Destroy(pauseUIInstance);
                Time.timeScale = 1f;
            }
        }
    }
}