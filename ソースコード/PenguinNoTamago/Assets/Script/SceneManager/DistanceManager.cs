using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DistanceManager : MonoBehaviour
{
    // Start is called before the first frame update

    public GameObject objA;
    public GameObject objB;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 Apos = objA.transform.position;
        Vector3 Bpos = objB.transform.position;
        float dis = Vector3.Distance(Apos, Bpos);
        Debug.Log("Distance : " + dis);
    }
}
