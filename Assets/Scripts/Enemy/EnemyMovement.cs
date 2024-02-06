using UnityEngine;

public class EnemyMovement : MonoBehaviour
{
    [SerializeField] private Transform[] target;
    [SerializeField] private float moveSpeed;

    private SpriteRenderer sr;
    private int index;

    private void Start()
    {
        sr = GetComponent<SpriteRenderer>();
    }
    private void Update()
    {
        transform.position = Vector3.MoveTowards(transform.position, target[index].position, moveSpeed * Time.deltaTime);
        if (transform.position == target[index].position)
        {
            if (index < target.Length-1)
            {
                sr.flipX = true;
                index++;
            }
            else
            {
                sr.flipX = false;
                index = 0;
            }
        }
    }
}
