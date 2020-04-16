using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class count1 : MonoBehaviour
{
    public Image one;
    // Start is called before the first frame update
    void Start()
    {
        one.enabled = true;
        StartCoroutine("Stop");
    }

    IEnumerator Stop()
    {
        yield return new WaitForSeconds(1.0f);
        one.enabled = false;
    }
        // Update is called once per frame
        void Update()
    {
    }
}
