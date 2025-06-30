using UnityEngine;

public class PlayerPaddle : Paddle
{
    private Vector2 direction;

    // Update() is called every single frame
    private void Update()
    {
        // handle key input and update direction
        if (Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.UpArrow))
        {
            direction = Vector2.up;
        } else if (Input.GetKey(KeyCode.S) || Input.GetKey(KeyCode.DownArrow))
        {
            direction = Vector2.down;
        } else
        {
            direction = Vector2.zero;
        }
    }

    // FixedUpdate() is called at a consistent, fixed interval
    private void FixedUpdate()
    {
        if (direction.sqrMagnitude != 0)
        {
            rb.AddForce(direction * this.speed);
        }
    }
}
