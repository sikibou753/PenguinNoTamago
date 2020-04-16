using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameEndButton : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

 
    }
    public void EndButton()
    {
#if UNITY_EDITOR

        UnityEditor.EditorApplication.isPlaying = false;
#elif UNITY_STANDALONE

        UnityEngine.Application.Quit();

#endif
    }

}
