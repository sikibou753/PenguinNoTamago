using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class wareru1 : MonoBehaviour
{
    Animation anim;
    Animator animator;

    GameObject childObject;
    bool IsCollision= false;

    void OnCollisionEnter(Collision collision)
    {
        if (collision.transform.tag == "Player"&& !IsCollision)
        {
            
            switch (this.tag)
            {
                case "sakeme1":
                    animator.SetInteger("Num", 1);
                    animator.SetTrigger("Is_Running");
                    break;

                case "sakeme2":
                    animator.SetInteger("Num", 2);
                    animator.SetTrigger("Is_Running");
                    break;

                case "sakeme3":
                    animator.SetInteger("Num", 3);
                    animator.SetTrigger("Is_Running");
                    break;

                case "sakeme4":
                    animator.SetInteger("Num", 4);
                    animator.SetTrigger("Is_Running");
                    break;

            }

        }
        IsCollision = true;
        //var r = Random.Range(0f, 1f);
        //var g = Random.Range(0f, 1f);
        //var b = Random.Range(0f, 1f);
        //GetComponent<Renderer>().material.color = new Color(r, g, b);

    }
        // Start is called before the first frame update
        void Start()
    {
        childObject = transform.GetChild(1).gameObject;
        animator = childObject.GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        //animator.SetBool("Is_Running", true);
        //animator.SetInteger("Num", 2);
    }
}
