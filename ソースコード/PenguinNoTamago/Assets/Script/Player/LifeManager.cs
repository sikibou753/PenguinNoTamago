using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class LifeManager : MonoBehaviour
{
    public int life = 3;
    public SerialConvert serialConvert;
    int putFrame;
    bool Used;
    int coolTime=10;
    bool FallEgg;
    bool gameOver;
    public bool debug=false;

    float coolStartTime;
    float coolEndTime;

    public GameObject[] playerIcons;
    public int destroyCount = 0;


    // Start is called before the first frame update
    void Start()
    {
        Used = false;
        FallEgg = false;
        gameOver = false;
        coolStartTime = 0;
        coolEndTime=0;

    }

    // Update is called once per frame
    void Update()
    {
        FallEgg = serialConvert.isPut;

        if (debug)
        {

            if (Input.GetKeyDown(KeyCode.T) && !FallEgg)
            {
                FallEgg = true;
            }
            else if (FallEgg)
            {
                FallEgg = false;
            }
        }

        EggLost();
        

        if (life < 0)
        {
            gameOver = true;
        }
    }

    void EggLost()
    {
        coolEndTime = Time.time;
        if (FallEgg && !Used)
        {

            lifeDecrement();

            coolStartTime= Time.time; 
            //putFrame++;
            Used = true;
        }
        
        //if (Used)
        //{
        //    coolTime++;
        //}
        if (coolEndTime-coolStartTime >= coolTime)
        {
            Used = false;
            
        }

       // Debug.Log(life);
    }

    public void lifeDecrement()
    {

        life--;

        destroyCount += 1;
        UpdatePlayerIcons();
    }

    void UpdatePlayerIcons()
    {
      
        for (int i = 0; i < playerIcons.Length; i++)
        {
            if (destroyCount <= i)
            {
                playerIcons[i].SetActive(true);
            }
            else
            {
                playerIcons[i].SetActive(false);
            }
        }
    }

    public bool gameover
    {
        get { return this.gameOver; }  //取得用
        private set { this.gameOver = value; } //値入力用
    }
}
