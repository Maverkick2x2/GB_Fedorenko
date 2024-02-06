using UnityEngine;
public class DamageDealer : MonoBehaviour
{
    [SerializeField] private float damage;
    [SerializeField] private PlayerHealth playerHealth;
    [SerializeField] private HealthBar healthBar;
    private void OnTriggerEnter2D(Collider2D target)
    {
        if (target.TryGetComponent(out PlayerHealth hp))
        {
            TakeDamage(damage);
        }
    }
    private void TakeDamage(float damage)
    {
        playerHealth.Health -= damage;
        healthBar.UpdateHealthBar();
    }
}
