using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthBar : MonoBehaviour
{
    [SerializeField] private PlayerHealth playerHealth;

    public Image HealthBarImage;
    public float MaxHealth = 100f;

    private void Start()
    {
        playerHealth.Health = MaxHealth;
    }

    public void UpdateHealthBar()
    {
        float healthPercent = playerHealth.Health / MaxHealth;
        HealthBarImage.fillAmount = healthPercent;
    }
}
