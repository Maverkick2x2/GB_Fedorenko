using UnityEngine;

public class CollectMushrooms : MonoBehaviour
{
    [SerializeField] private ShowMuchrooms showMuchrooms;
    private void OnTriggerEnter2D(Collider2D target)
    {
        if (target.TryGetComponent(out PlayerMovement playerMovement))
        {
            showMuchrooms.CollectMushrooms();
            Destroy(gameObject);
        }   
    }
}
