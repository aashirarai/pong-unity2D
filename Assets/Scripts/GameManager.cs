using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GameManager : MonoBehaviour
{
    public Ball ball;

    public Paddle playerPaddle;
    public Paddle AIPaddle;

    public TextMeshProUGUI playerScoreText;
    public TextMeshProUGUI AIScoreText;

    private int playerScore;
    private int AIScore;

    public void PlayerScores()
    {
        playerScore++;

        this.playerScoreText.text = playerScore.ToString();
        ResetRound();
    }
    
    public void AIScores()
    {
        AIScore++;

        this.AIScoreText.text = AIScore.ToString();
        ResetRound();
    }

    private void ResetRound()
    {
        this.playerPaddle.ResetPosition();
        this.AIPaddle.ResetPosition();
        this.ball.ResetPosition();
        this.ball.AddStartingForce();
    }
}
