using UnityEngine;

public class Ball : MonoBehaviour
{
    public float speed;
    private Rigidbody2D rb;

    private void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    private void Start()
    {
        ResetPosition();
        AddStartingForce();
    }

    // function to reset the position of the ball to the center
    public void ResetPosition()
    {
        rb.position = Vector3.zero;
        rb.linearVelocity = Vector3.zero;
    }

    // function to add a random starting force to the ball
    public void AddStartingForce()
    {
        // randomly determine which direction ball starts moving in
        float x = Random.value < 0.5f ? -1.0f : 1.0f;
        float y = Random.value < 0.5f ? Random.Range(-1.0f, -0.5f) :
                                        Random.Range(0.5f, 1.0f);

        Vector2 direction = new Vector2(x, y);
        rb.AddForce(direction * this.speed);
    }

    // function to add force to ball from elsewhere
    public void AddForce(Vector2 force)
    {
        rb.AddForce(force);
    }
}
