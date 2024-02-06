using UnityEngine;

public class PlayerJump : MonoBehaviour
{
    [SerializeField, Range(0, 1)] private float jumpHeight;
    [SerializeField] private float jumpForce;
    [SerializeField] private float groundRadius;
    [SerializeField] private Transform groundPos;
    [SerializeField] private LayerMask groundMask;

    private Rigidbody2D playerRb;
    private Animator anim;
    private bool isGrounded;

    private void Start()
    {
        playerRb = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();
    }

    private void FixedUpdate()
    {
        Jump();
        AnimationJump();
    }

    private void Jump()
    {
        isGrounded = Physics2D.OverlapCircle(groundPos.position, groundRadius, groundMask);

        if (Input.GetKeyDown(KeyCode.Space) && isGrounded )
        {
            playerRb.velocity = new Vector2(playerRb.velocity.x, jumpForce);
        }
        if (Input.GetKeyUp(KeyCode.Space))
        {
            if (playerRb.velocity.y > 0)
            {
                playerRb.velocity = new Vector2(playerRb.velocity.x, playerRb.velocity.y * jumpHeight);
            }
        }
    }

    private void AnimationJump()
    {
        if (isGrounded == true)
        {
            anim.SetBool("Jump", false);
        }
        if (isGrounded == false)
        {
            anim.SetBool("Jump", true);
        }
    }
}
