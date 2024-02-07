using UnityEngine;
using System.Collections;

public class EnemyMovement : MonoBehaviour
{
    [SerializeField] private Transform[] target;
    [SerializeField] private float moveSpeed;

    private SpriteRenderer sr;
    private int index;

    private void Start()
    {
        sr = GetComponent<SpriteRenderer>();
        StartCoroutine(EnemyMove());
    }

    private IEnumerator EnemyMove()
    {
        while (true)
        {
            yield return new WaitForSeconds(0.001f);
            transform.position = Vector3.MoveTowards(transform.position, target[index].position, moveSpeed * Time.deltaTime);
            if (transform.position == target[index].position)
            {
                if (index < target.Length - 1)
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
}
