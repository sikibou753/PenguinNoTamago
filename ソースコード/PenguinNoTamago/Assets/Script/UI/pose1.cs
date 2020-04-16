using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class pose1 : MonoBehaviour
{
    //　ポーズした時に表示するUI
    [SerializeField]
    //　ポーズした時に表示するUIのプレハブ
    private GameObject pose;
    //　ポーズUIのインスタンス
    private GameObject koutaiUIInstance;

    GameObject Player;
    PlayerMove playerMove;
    void Start()
    {
        
    }
    // Update is called once per frame
    private void OnCollisionEnter(Collision collision)
    {

    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            Debug.Log("1");
            if (koutaiUIInstance == null)
            {
                Player = other.gameObject;
                playerMove = Player.GetComponent<PlayerMove>();
                playerMove.OnPause();
                koutaiUIInstance = GameObject.Instantiate(pose) as GameObject;
                Time.timeScale = 0f;
            }
        }
    }
    void Update()
    {
        if (Input.GetButtonDown("Start"))
        {
            Destroy(koutaiUIInstance);
            Time.timeScale = 1f;
            playerMove.OffPause();
        }
    }

   
}
