using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class count2 : MonoBehaviour
{
    public Image two;
    // Start is called before the first frame update
    void Start()
    {
        two.enabled = false;
        StartCoroutine("Stop");
    }

    IEnumerator Stop()
    {
        yield return new WaitForSeconds(1.0f);
        two.enabled = true;
        yield return new WaitForSeconds(1.0f);
        two.enabled = false;
    }
        // Update is called once per frame
        void Update()
    {
        
    }
}
