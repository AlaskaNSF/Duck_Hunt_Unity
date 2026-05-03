using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;
using Unity.VisualScripting;

public class game_over_manager : MonoBehaviour
{
    [Header("UI Stats")]
    public TextMeshProUGUI finalBooksCaught;
    public TextMeshProUGUI finalDementorsCaught;
    public TextMeshProUGUI finalBooksDestroyed;
    public TextMeshProUGUI finalDementorsDestroyed;
    public TextMeshProUGUI finalScoreText;


    void Start()
    {
        // Recupero los datos de las variables estáticas del Level_Manager
        int booksCaught = Level_Manager.booksCaught;
        int dementorsCaught = Level_Manager.dementorsCaught;
        int booksDestroyed = Level_Manager.booksDestroyed;
        int dementorsDestroyed = Level_Manager.dementorsDestroyed;
        
        // Calculo del puntaje
        int finalScore = (booksCaught * 10) + (dementorsDestroyed * 10) - (dementorsCaught * 10) - (booksDestroyed * 10);

        // Mostramos los valores en pantalla
        if (finalBooksCaught != null) finalBooksCaught.text = booksCaught.ToString();
        if (finalBooksDestroyed != null) finalBooksDestroyed.text = booksDestroyed.ToString();
        if (finalDementorsCaught != null) finalDementorsCaught.text = dementorsCaught.ToString();
        if (finalDementorsDestroyed != null) finalDementorsDestroyed.text = dementorsDestroyed.ToString();
        if (finalScoreText != null) finalScoreText.text = finalScore.ToString();
    }
    
    public void Retry()
    {
        SceneManager.LoadScene("Game");
    }

    public void Menu()
    {
        SceneManager.LoadScene("Menu");
    }

    public void ExitGame()
    {
        Application.Quit();
    }
}