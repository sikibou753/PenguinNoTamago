using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class count3 : MonoBehaviour
{
    public Image three;
    GameObject countDown;
    // Start is called before the first frame update
    void Start()
    {
        three.enabled = false;
        StartCoroutine("Stop");
    }

    IEnumerator Stop()
    {
        yield return new WaitForSeconds(2.0f);
        three.enabled = true;
        yield return new WaitForSeconds(1.0f);
        three.enabled = false;
        countDown = this.transform.parent.gameObject; 
        Destroy(countDown);

    }
        // Update is called once per frame
        void Update()
    {
        
    }
}
