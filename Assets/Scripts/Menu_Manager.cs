using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu_Manager : MonoBehaviour
{

    public GameObject mainMenuPanel;
    public GameObject tutorialPanel;
    public void PlayGame()
    {
        SceneManager.LoadScene("Game");
    }

    public void OpenTutorial()
    {
        mainMenuPanel.SetActive(false); // Desactiva el menú principal
        tutorialPanel.SetActive(true); // Activa el tutorial
    }

    public void CloseTutorial()
    {
        mainMenuPanel.SetActive(true);
        tutorialPanel.SetActive(false);
    }

    public void ExitGame()
    {
        Application.Quit();
    }
}
