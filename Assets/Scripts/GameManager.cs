using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public Ball ball;

    private int playerScore;

    private int AIScore;

    public void PlayerScores()
    {
        playerScore++;
        Debug.Log(playerScore);
        this.ball.ResetPosition();
    }
    
    public void AIScores()
    {
        AIScore++;
        Debug.Log(AIScore);
        this.ball.ResetPosition();
    }

}
