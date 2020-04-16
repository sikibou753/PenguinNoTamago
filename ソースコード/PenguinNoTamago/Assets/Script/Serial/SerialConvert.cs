using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SerialConvert : MonoBehaviour
{
    public SerialHandler serialHandler;
    public Text text;

    private bool IsPut = false;

    // Use this for initialization
    void Start()
    {
        //信号を受信したときに、そのメッセージの処理を行う
        serialHandler.OnDataReceived += OnDataReceived;
    }

    // Update is called once per frame
    void Update()
    {

    }

    /*
	 * シリアルを受け取った時の処理
	 */
    void OnDataReceived(string message)
    {
        try
        {
            //text.text = message; // シリアルの値をテキストに表示
            if (message == "HIGH")
            {
                IsPut = true;
            }
            else if (message == "LOW")
            {
                IsPut = false;
            }

        }
        catch (System.Exception e)
        {
            Debug.LogWarning(e.Message);
        }
    }

    public bool isPut
    {
        get { return this.IsPut; }  //取得用
        private set { this.IsPut = value; } //値入力用
    }
}
