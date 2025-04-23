using UnityEngine;

public class PlayerStateMachine : MonoBehaviour
{
    private enum State
    {
        Idle,
        Running,
        Jumping
    }

    private State currentState;
    private Rigidbody2D rb;

    public float moveSpeed = 5f;
    public float jumpForce = 7f;
    public LayerMask groundLayer;
    private bool isGrounded;

    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        currentState = State.Idle;
    }

    private void Update()
    {
        HandleInput();
        UpdateState();
    }

    private void HandleInput()
    {
        float moveInput = Input.GetAxisRaw("Horizontal");

        if (moveInput != 0)
        {
            rb.velocity = new Vector2(moveInput * moveSpeed, rb.velocity.y);
        }

        if (Input.GetKeyDown(KeyCode.Space) && isGrounded)
        {
            rb.velocity = new Vector2(rb.velocity.x, jumpForce);
        }
    }

    private void UpdateState()
    {
        isGrounded = Physics2D.Raycast(transform.position, Vector2.down, 1f, groundLayer);

        if (!isGrounded)
        {
            currentState = State.Jumping;
        }
        else if (Mathf.Abs(rb.velocity.x) > 0.1f)
        {
            currentState = State.Running;
        }
        else
        {
            currentState = State.Idle;
        }
    }
}
