using UnityEngine;

public class BouncySurface : MonoBehaviour
{
    public float bounceStrength;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        // check for collision with ball
        Ball ball = collision.gameObject.GetComponent<Ball>();

        // if there is collision
        if (ball != null)
        {
            // get normal of the first point of collision
            Vector2 normal = collision.GetContact(0).normal;
            ball.AddForce(-normal * this.bounceStrength);
        }
    }

}
