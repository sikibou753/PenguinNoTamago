using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveIcon : MonoBehaviour
{
    GameObject Player;
    GameObject goalIcon;
    GameObject startIcon;
    GameObject penguinIcon;

    float panelStart;
    float panelGoal;

    float playerStart = -645;
    float playerGoal = 200;

    float ratio;
    float panelRange;
    float panelLocation;
    // Start is called before the first frame update
    void Start()
    {

        goalIcon = GameObject.Find("Goal");
        startIcon = GameObject.Find("Start");

        Vector3 pos = this.transform.position;
        pos.y = startIcon.transform.position.y;
        this.transform.position = pos;

        //panelStart = -186;
        //panelGoal = 161;

        panelStart = startIcon.transform.position.y ;
        panelGoal = goalIcon.transform.position.y;

        ratio = (playerGoal - playerStart) / (panelGoal - panelStart);
        Player = GameObject.Find("Player");

    }

    // Update is called once per frame
    void Update()
    {
        if (Player.transform.position.z <= 200)
        {
            panelRange = (playerGoal - Player.transform.position.z) / ratio;
            panelLocation = panelGoal - panelRange;

            Vector3 pos = this.transform.position;
            pos.y = panelLocation;

            this.transform.position = pos;
        }
    }
}
