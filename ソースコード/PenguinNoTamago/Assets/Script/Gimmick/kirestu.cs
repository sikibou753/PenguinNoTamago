using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class kirestu : MonoBehaviour
{
    private Animator animator;
    Animation anim;

    // Use this for initialization
    void Start()
    {
        anim = this.gameObject.GetComponent<Animation>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.A))
        {
            //anim.Play();
        }
    }

    void OnTriggerEnter(Collider other)
    {

        //プレイヤーが当たった場合
        if (other.CompareTag("Player"))
        {
            anim.Play();
        }
    }
}
