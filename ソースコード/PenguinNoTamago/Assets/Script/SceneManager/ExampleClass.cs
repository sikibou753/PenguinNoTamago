using System.Collections;
using System.Collections.Generic;
using UnityEngine;


 [RequireComponent(typeof(AudioSource))]
public class ExampleClass : MonoBehaviour
{

    // Start is called before the first frame update


    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        // 左クリックしたら、効果音を鳴らす
        if (Input.GetButtonDown("Start"))
        {
            GetComponent<AudioSource>().Play();  // 効果音を鳴らす
        }
    }

}
