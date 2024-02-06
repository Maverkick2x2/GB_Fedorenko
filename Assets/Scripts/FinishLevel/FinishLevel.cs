using UnityEngine;
using System.Collections;

public class FinishLevel : MonoBehaviour
{
    [SerializeField] private PanelsManager panelsManager;
    [SerializeField] private PlayerMovement playerMovement;
    [SerializeField] private GameObject virtualCamera;

    private void OnTriggerEnter2D(Collider2D target)
    {
        if (target.TryGetComponent(out PlayerHealth playerHealth))
        {
            playerMovement.enabled = false;
            virtualCamera.SetActive(false);
            StartCoroutine(ShowWinPanel());
        }
    }
    private IEnumerator ShowWinPanel()
    {
        yield return new WaitForSeconds(3);
        panelsManager.ShowWinPanel();
        Time.timeScale = 0;
    }
}
