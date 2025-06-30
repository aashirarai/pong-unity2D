using UnityEngine;

public class AIPaddle : Paddle
{
    // reference to ball
    public Rigidbody2D ball;

    private void FixedUpdate()
    {
       // if the ball is coming towards AI paddle
        if (this.ball.linearVelocity.x < 0.0f)
        {   
            // check which direction ball is moving
            if (this.ball.position.y > this.transform.position.y)
            {
                rb.AddForce(Vector2.up * this.speed);
            }
            else if (this.ball.position.y < this.transform.position.y)
            {
                rb.AddForce(Vector2.down * this.speed);
            }
        } else
        {
            // make paddle idle in the middle after deflecting the ball
            if (this.transform.position.y > 0.0f)
            {
                rb.AddForce(Vector2.down * this.speed);
            } else if (this.transform.position.y < 0.0f)
            {
                rb.AddForce(Vector2.up * this.speed);
            }
        }
    }
}
