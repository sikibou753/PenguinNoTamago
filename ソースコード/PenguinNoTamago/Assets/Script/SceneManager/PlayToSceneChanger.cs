using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayToSceneChanger : MonoBehaviour
{
    // Start is called before the first frame update
    public LifeManager lifeManager;
    bool gameOver;

    private AudioSource gameoverSound;

    private AudioSource gameclearSound;

    void Start()
    {
        gameOver = false;
        GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        gameOver = lifeManager.gameover;

        if (gameOver)
        {
            SceneManager.LoadScene("GameOver");
            gameoverSound.PlayOneShot(gameoverSound.clip);
        }

        if (Input.GetKeyDown(KeyCode.Return))
        {
            SceneManager.LoadScene("GameClear");
            gameclearSound.PlayOneShot(gameclearSound.clip);
        }
    }
}
