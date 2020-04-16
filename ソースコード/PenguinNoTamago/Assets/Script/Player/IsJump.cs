using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
public class IsJump : MonoBehaviour
{
    //接地した場合の処理
    public UnityEvent OnEnterGround;
    //地面から離れた場合の処理
    public UnityEvent OnExitGround;
    //接地数
    private int enterNum = 0;

    private void OnTriggerEnter(Collider collision)
    {
        if (collision.CompareTag("ground"))
        {
            //Debug.Log("OnGround!");
            enterNum++;
            OnEnterGround.Invoke();
        }
        else
        if (collision.CompareTag("sakeme2"))
        {
            enterNum++;
            OnEnterGround.Invoke();
        }
        else
        if (collision.CompareTag("sakeme4"))
        {
            enterNum++;
            OnEnterGround.Invoke();
        }
        else
        if (collision.CompareTag("sakeme1"))
        {
            enterNum++;
            OnEnterGround.Invoke();
        }

    }

    private void OnTriggerExit(Collider collision)
    {
        //Debug.Log("ExitGround!");
        if (collision.CompareTag("ground"))
        {
            enterNum--;
            if (enterNum <= 0)
            {
                enterNum = 0;
                OnExitGround.Invoke();
            }
        }
    }
}
