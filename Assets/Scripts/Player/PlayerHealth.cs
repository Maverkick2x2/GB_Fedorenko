using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;
public class PlayerHealth : MonoBehaviour
{
    [SerializeField] private PlayerMovement playerMovement;
    [SerializeField] private GameObject virtualCamera;
    [SerializeField] private SceneLoader sceneLoader;

    private Animator anim;

    public float Health;
    
    private void Start()
    {
        anim = GetComponent<Animator>();
    }

    private void Update()
    {
        if (Health <= 0)
        {
            StartCoroutine(DeactivateCharacter());
        }
    }

    private IEnumerator DeactivateCharacter()
    {
        playerMovement.enabled = false;
        virtualCamera.SetActive(false);
        anim.SetTrigger("Death");
        yield return new WaitForSeconds(3);
        sceneLoader.LoadLevel(SceneManager.GetActiveScene().buildIndex);
    }
}
