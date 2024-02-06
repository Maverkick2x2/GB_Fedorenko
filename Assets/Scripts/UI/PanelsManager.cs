using UnityEngine;

public class PanelsManager : MonoBehaviour
{
    [SerializeField] private GameObject winPanel;
    [SerializeField] private GameObject gamePanel;
    [SerializeField] private ShowMuchrooms showMuchrooms;

    public void ShowWinPanel()
    {
        winPanel.SetActive(true);
        gamePanel.SetActive(false);
        showMuchrooms.ShowTotalMushrooms();
    }
    public void PauseGame()
    {
        Time.timeScale = 0;
    }
    public void ResumeGame()
    {
        Time.timeScale = 1;
    }
    public void ExitGame()
    {
        Application.Quit();
    }
}
