using UnityEngine;

public class Paddle : MonoBehaviour
{
    public float speed;

    protected Rigidbody2D rb;

    // Awake() is a function that Unity calls automatically
    // initialise paddle
    private void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    public void ResetPosition()
    {
        rb.position = new Vector2(rb.position.x, 0.0f);
        rb.linearVelocity = Vector3.zero;
    }
}
