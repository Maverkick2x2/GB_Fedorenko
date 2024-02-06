using UnityEngine;
[RequireComponent(typeof(PlayerInput))]
public class PlayerMovement : MonoBehaviour
{
    [SerializeField] private PlayerInput playerInput;
    [SerializeField] private float moveSpeed;

    private Animator anim;
    private Rigidbody2D playerRb;
    private bool isFlipped = true;

    private void Start()
    {
        playerRb = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();
    }

    private void FixedUpdate()
    {
        playerRb.velocity = new Vector2(playerInput.GetMoveAxis() * moveSpeed, playerRb.velocity.y);
        anim.SetFloat("Run", Mathf.Abs(playerInput.GetMoveAxis()));

        if (playerInput.GetMoveAxis() > 0 && !isFlipped || playerInput.GetMoveAxis() < 0 && isFlipped)
        {
            Flip();
        }
    }

    private void Flip()
    {
        isFlipped = !isFlipped;

        Vector3 transformScale = transform.localScale;
        transformScale.x *= -1;
        transform.localScale = transformScale;
    }
}
