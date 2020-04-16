using System.Collections;
using System.Collections.Generic;
using UnityEngine;
// "NavMeshAgent"関連クラスを使用できるようにする
using UnityEngine.AI;

public class PenguinGroup : MonoBehaviour
{
    // 巡回地点オブジェクトを格納する配列
    public Transform[] points;
    // 巡回地点のオブジェクト数（初期値=0）
    private int destPoint = 0;
    // NavMesh Agent コンポーネントを格納する変数
    public NavMeshAgent agent;

    public float slowSpeed = 3f;

    public float highSpeed = 9f;

    public float nowSpeed = 9f;

    public Collider change1;
    public Collider change2;
    public Collider change3;


    // ゲームスタート時の処理
    void Start()
    {
        StartCoroutine("Stop");
    }
    IEnumerator Stop()
    {
        yield return new WaitForSeconds(3.0f);
        // 変数"agent"に NavMesh Agent コンポーネントを格納
        agent = GetComponent<NavMeshAgent>();
        // 次の巡回地点の処理を実行
        GotoNextPoint();
    }

    // 次の巡回地点を設定する処理
    void GotoNextPoint()
    {
        // 巡回地点が設定されていなければ
        if (points.Length == 0)
            // 処理を返します
            return;
        // 現在選択されている配列の座標を巡回地点の座標に代入
        agent.destination = points[destPoint].position;
    }

    // ゲーム実行中の繰り返し処理
    void Update()
    {
        // エージェントが現在の巡回地点に到達したら
        if (!agent.pathPending && agent.remainingDistance < 0.5f)
        {
            // 次の巡回地点を設定する処理を実行
            GotoNextPoint();
        }
        agent.speed = nowSpeed;

        if (destPoint == 1)
        {
            this.OnTriggerStay(change2);
        }
        else
        if (destPoint == 2)
        {
            this.OnTriggerStay(change3);
        }
        else
            this.OnTriggerStay(change1);
    }
    //判定から離れたら
    public void OnTriggerExit(Collider other)
    {
        //接触しているオブジェクトのタグが"Player"のとき
        if (other.CompareTag("Player"))
        {
            //遅くなる
            nowSpeed = slowSpeed;
        }
    }

    //近くの判定に触れている間
    public void OnTriggerStay(Collider other)
    {
        //接触しているオブジェクトのタグが"Player"のとき
        if (other.CompareTag("Player"))
        {
            //オブジェクトの速度をあげる
            nowSpeed = highSpeed;
        }

        if (other.gameObject.tag == "change")
        {
            if (Input.GetButtonDown("Start"))
            {
                if (destPoint == 1)
                {
                    destPoint = 2;
                }
                else
                if (destPoint == 2)
                {
                    destPoint = 3;
                }
                else
                    destPoint = 1;
            }
        }
    }
}