using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fallen : MonoBehaviour
{
    GameObject group;
    GameObject PlayerObj;
    public FadeTest fadeTest;

    float lastMovingTime;
    bool Stop;
    // Start is called before the first frame update
    void Start()
    {
        group = GameObject.Find("group");
        PlayerObj = GameObject.Find("Player");
        Stop = false;
       
    }

    // Update is called once per frame
    void Update()
    {
        if (Stop)
        {
            if (Time.realtimeSinceStartup - lastMovingTime > 5f)
            {
                //ゲーム再開
                Pauser.Resume();

                group.GetComponent<PenguinGroup>().agent.Resume();

                //penguinGroup.enabled = true;

                Stop = false;
            }
        }
    }

    public void FallenPlayer()
    {
        LifeManager lifeManager = PlayerObj.GetComponent<LifeManager>();
        lifeManager.lifeDecrement();
        Vector3 pos = PlayerObj.transform.position;
        pos.y = 5;
        pos.z += 5;

        PlayerObj.transform.position = pos;

        PlayerMove.LeftMove = false;
        PlayerMove.runCount = 0;
        PlayerMove.lateralCount = 0;
        PlayerMove.playerMoves.x = 0;
        PlayerMove.playerMoves.z = 0;

        lastMovingTime = 0;
        Stop = true;
        lastMovingTime = Time.realtimeSinceStartup;
        group.GetComponent<PenguinGroup>().agent.Stop(true);
        Pauser.Pause();
    }
}
