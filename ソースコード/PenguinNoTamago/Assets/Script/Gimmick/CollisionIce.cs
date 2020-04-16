using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

//[RequireComponent(typeof(NavMeshAgent))]
public class CollisionIce : MonoBehaviour
{
    public GameObject penguinGroup;
    //public FadeTest fadeTest;
    public LifeManager lifeManager;

    public AudioClip ColisionSe;
    AudioSource audioSource;

    private float lastMovingTime;

    bool Stop;

    GameObject Object;
    Animator animator;

    private void OnCollisionEnter(Collision collision)
    {

        if (collision.gameObject.tag == "Player")
        {
            //lastMovingTime = 0;
            Stop = true;

            //Debug.Log(childObject.name);

            animator.SetTrigger("Is_Running");　//アニメーションを呼ぶ


            //lastMovingTime = Time.realtimeSinceStartup;
            //penguinGroup.GetComponent<PenguinGroup>().m_navAgent.velocity = Vector3.zero;
            penguinGroup.GetComponent<PenguinGroup>().agent.Stop(true);
            //fadeTest.Fadeout();
            //Pauser.Pause();
            audioSource.PlayOneShot(ColisionSe);

        }
        Debug.Log("HIT");
    }

    private void Start()
    {
        audioSource = GetComponent<AudioSource>();
        Stop = false;

    }

    void Update()
    {
        Object = transform.gameObject;　　
        animator = Object.GetComponent<Animator>();　//アニメーション取得

        if (Stop)
        {

            if (Time.realtimeSinceStartup - lastMovingTime > 1.5f)
            {

                //ゲーム再開
                //Pauser.Resume();

                penguinGroup.GetComponent<PenguinGroup>().agent.Resume();

                //penguinGroup.enabled = true;

                Stop = false;

                lifeManager.lifeDecrement();
                GetComponent<BoxCollider>().enabled = false; //コライダーを消す
                //Destroy(gameObject);

            }
        }
    }
}
