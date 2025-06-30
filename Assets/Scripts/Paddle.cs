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
}
