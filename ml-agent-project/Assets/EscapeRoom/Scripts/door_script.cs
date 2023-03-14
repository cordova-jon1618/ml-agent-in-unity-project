using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class door_script : MonoBehaviour
{
    GameObject winnerGameObject;
    public score_script score_logic;

    void Start()
    {
        score_logic = GameObject.FindGameObjectWithTag("score_logic").GetComponent<score_script>();
    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnTriggerEnter(Collider collision)
    {

        Debug.Log("Reached Goal!");

        //Teleports the agent back to the start.
        winnerGameObject = collision.gameObject;

        if (collision.gameObject.layer == 6)
        {
            score_logic.addScore_1(1);
            score_logic.restartPositions(winnerGameObject);
        }
        else if (collision.gameObject.layer == 7)
        {
            score_logic.addScore_2(1);
            score_logic.restartPositions(winnerGameObject);
        }
        else if (collision.gameObject.layer == 8)
        {
            score_logic.addScore_3(1);
            score_logic.restartPositions(winnerGameObject);
        }

    }

}//end door_script
