using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class score_script : MonoBehaviour
{
    public int agent_1_Score = 0;
    public int agent_2_Score = 0;
    public int agent_3_Score = 0;

    public Text scoreText_1;
    public Text scoreText_2;
    public Text scoreText_3;

    //public GameObject gameOverScreen;

    [ContextMenu("Increase Score 1.")]
    public void addScore_1(int scoreToAdd)
    {
        agent_1_Score = agent_1_Score + scoreToAdd;
        scoreText_1.text = agent_1_Score.ToString();

    }
    [ContextMenu("Increase Score 2.")]
    public void addScore_2(int scoreToAdd)
    {
        agent_2_Score = agent_2_Score + scoreToAdd;
        scoreText_2.text = agent_2_Score.ToString();

    }
    [ContextMenu("Increase Score 3.")]
    public void addScore_3(int scoreToAdd)
    {
        agent_3_Score = agent_3_Score + scoreToAdd;
        scoreText_3.text = agent_3_Score.ToString();

    }

    public void restartPositions(GameObject winnerGameObject)
    {
        winnerGameObject.transform.position = new Vector3(0, 2, -10);
        winnerGameObject.transform.rotation = Quaternion.identity;

    }
}//end score_script
