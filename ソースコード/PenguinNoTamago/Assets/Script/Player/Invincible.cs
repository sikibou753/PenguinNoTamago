using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Invincible : MonoBehaviour
{
    bool IsInvincible;
    bool Flashing;
    bool Elapsed;
    private float nextTime;
    float interval = 0.2f;  // 点滅周期

    float lastMovingTime;

    // Start is called before the first frame update
    void Start()
    {
        IsInvincible = false;
        Flashing = false;
        Elapsed = true;
        
    }

    // Update is called once per frame
    void Update()
    {
        if (!Elapsed)
        {
           
            if (IsInvincible)
            {

            }

            if (Flashing)
            {
                if (Time.time > nextTime)
                {
                    GetComponent<Renderer>().enabled = !GetComponent<Renderer>().enabled;

                    nextTime += interval;
                }
            }
            if (Time.realtimeSinceStartup - lastMovingTime > 3f)
            {
                Elapsed = true;
            }

        }
        
    }

    public void OnInvincible()
    {
        Debug.Log("C");
        IsInvincible = true;
        Flashing = true;
        lastMovingTime = Time.realtimeSinceStartup;
        Elapsed = false;
        nextTime = Time.time;
        
    }

    public void OffInvincible()
    {
        IsInvincible = false;
        Flashing = false;
    }

    public bool GetElapsed
    {
        get { return Elapsed; }
        private set { Elapsed = value; }
    }

}
