using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;


public class PlayerMove : MonoBehaviour
{

    public GameObject player;
    public FadeTest fadeTest;
    GameObject Fall;
    public static Vector3 playerMoves;
    float z;
    float x;
    string oldInput = null;
    bool FirstInput = false;
    public static bool Run = false;
    public static bool RightMove = false;
    public static bool LeftMove = false;
    public static int runCount = 0;
    public static int lateralCount = 0;

    public AudioClip JumpSound;
    AudioSource audioSource;

    float jumpValue;
    float jumpFowardPower;

    float runMinus = 0.02f;
    float lateralMinuns = 0.01f;

    bool Pause;
    public bool OnGround { get; set; }

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine("Stop");
        playerMoves.x = 0;
        playerMoves.y = 0;
        playerMoves.z = 0;
        z = 0.0f;
        x = 0.0f;
        jumpValue = 0f;
        OnGround = false;
        jumpFowardPower = 0;
        Fall = GameObject.Find("Fallen");
        audioSource = GetComponent<AudioSource>();

        Pause = false;
    }

    IEnumerator Stop()
    {
        yield return new WaitForSeconds(3.0f);
        z = 0.15f;
        x = 0.08f;
        jumpValue = 10f;
        OnGround = true;
        jumpFowardPower = 5;
    }
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
#if UNITY_EDITOR

            UnityEditor.EditorApplication.isPlaying = false;
#elif UNITY_STANDALONE

        UnityEngine.Application.Quit();

#endif
        }

        //ジャンプ
        if (!Input.GetButton("rightCenterButton") && !Input.GetButton("centerCenterButton") && OnGround && FirstInput)
        {
            GetComponent<Rigidbody>().velocity = new Vector3(0, jumpValue, jumpFowardPower);
            OnGround = false;
            audioSource.PlayOneShot(JumpSound);

            RightMove = false;
            LeftMove = false;
            runCount = 0;
            lateralCount = 0;
            playerMoves.x = 0;
            playerMoves.z = 0;
        }

        if (OnGround && !Pause)
        {
            //前進
            if ((Input.GetButtonDown("rightCenterButton") && oldInput == "centerCenterButton") || (!FirstInput && Input.GetButtonDown("rightCenterButton")))
            {
                playerMoves.z = z;
                oldInput = "rightCenterButton";
                FirstInput = true;
                Run = true;
            }

            else if ((Input.GetButtonDown("centerCenterButton") && oldInput == "rightCenterButton") || (!FirstInput && Input.GetButtonDown("centerCenterButton")))
            {
                playerMoves.z = z;
                oldInput = "centerCenterButton";
                FirstInput = true;
                Run = true;
            }

            if (Run)
            {
                runCount++;
                if (runCount % 20 == 0)
                {
                    playerMoves.z -= runMinus;
                }
                if (playerMoves.z <= 0)
                {
                    Run = false;
                    playerMoves.z = 0;
                }
            }
            transform.Translate(0, 0, playerMoves.z);
            //左右移動
            if (Input.GetButtonDown("leftBackButton"))
            {
                RightMove = false;
                LeftMove = true;
                playerMoves.x = -x;

            }

            if (Input.GetButtonDown("centerBackButton"))
            {
                LeftMove = false;
                RightMove = true;
                playerMoves.x = x;

            }

            if (RightMove)
            {
                lateralCount++;
                if (lateralCount % 10 == 0)
                {
                    playerMoves.x -= lateralMinuns;
                }
                if (playerMoves.x <= 0)
                {
                    RightMove = false;
                    lateralCount = 0;
                    playerMoves.x = 0;
                }
            }

            if (LeftMove)
            {
                lateralCount++;
                if (lateralCount % 10 == 0)
                {
                    playerMoves.x += lateralMinuns;
                }
                if (playerMoves.x >= 0)
                {
                    LeftMove = false;
                    lateralCount = 0;
                    playerMoves.x = 0;
                }
            }
            transform.Translate(playerMoves.x, 0, 0);
        }


        //落ちた
        if (this.transform.position.y < 1.85)
        {
            fadeTest.Fadeout();
            Fall.GetComponent<Fallen>().FallenPlayer();


        }


    }

    public void OnPause()
    {
        Pause = true;
    }
    public void OffPause()
    {
        Pause = false;
    }
}
