using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;
using System;

public class PlayerHealth : MonoBehaviour, IDamageable
{
    [SerializeField] private GameObject virtualCamera;
    [SerializeField] private SceneLoader sceneLoader;

    public static event Action OnHealthBarUpdated;

    private Animator anim;

    private float health;
    public float Health
    {
        get { return health; }
        set { health = value; }
    }

    private void Start()
    {
        anim = GetComponent<Animator>();
    }

    public void ApplyDamage(float damageValue)
    {
        Health -= damageValue;
        OnHealthBarUpdated?.Invoke();
        StartCoroutine(CheckIsAlive());
    }

    private IEnumerator CheckIsAlive()
    {
        yield return new WaitForSeconds(0.001f);
        if (Health <= 0)
        {
            StartCoroutine(DeactivateCharacter());
        }
    }

    private IEnumerator DeactivateCharacter()
    {
        GetComponent<Rigidbody2D>().velocity = new Vector2(0, transform.position.y);
        GetComponent<PlayerMovement>().enabled = false;
        virtualCamera.SetActive(false);
        anim.SetTrigger("Death");
        yield return new WaitForSeconds(3);
        sceneLoader.LoadLevel(SceneManager.GetActiveScene().buildIndex);
    }

}
