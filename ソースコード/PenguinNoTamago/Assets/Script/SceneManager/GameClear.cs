using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class GameClear : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void OnRetry()
    {
        // 「ButtonScene」を自分の読み込みたいscene名に変える
        SceneManager.LoadScene("GamePlay");
    }


}
