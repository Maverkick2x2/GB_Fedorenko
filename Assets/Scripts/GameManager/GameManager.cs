using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    [Header("Player")]
    [SerializeField] private PlayerMovement playerMovement;
    [SerializeField] private PlayerInput playerInput;
    [SerializeField] private PlayerJump playerJump;
    [SerializeField] private PlayerHealth playerHealth;

    [Header("Enemy")]
    [SerializeField] private EnemyMovement[] enemyMovement;

    [Header("Collect")]
    [SerializeField] private CollectMushrooms[] collectMushrooms;

    [Header("Damage Dealer")]
    [SerializeField] private DamageDealer[] damageDealer;

    [Header("Finish Level")]
    [SerializeField] private FinishLevel finishLevel;

    [Header("Scene Manager")]
    [SerializeField] private SceneLoader sceneLoader;

    [Header("UI")]
    [SerializeField] private ButtonScaler[] buttonScaler;
    [SerializeField] private HealthBar healthBar;
    [SerializeField] private PanelsManager panelsManager;
    [SerializeField] private ShowMuchrooms showMuchrooms;
}
