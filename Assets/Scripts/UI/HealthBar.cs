using UnityEngine;
using UnityEngine.UI;

public class HealthBar : MonoBehaviour
{
    [SerializeField] private PlayerHealth playerHealth;
    [SerializeField] private float maxHealth = 100f;
    [SerializeField] private Image healthBarImage;

    private void Start()
    {
        playerHealth.Health = maxHealth;
        PlayerHealth.OnHealthBarUpdated += UpdateHealthBar;
    }

    private void OnDestroy()
    {
        PlayerHealth.OnHealthBarUpdated -= UpdateHealthBar;
    }

    public void UpdateHealthBar()
    {
        float healthPercent = playerHealth.Health / maxHealth;
        healthBarImage.fillAmount = healthPercent;
    }
}
