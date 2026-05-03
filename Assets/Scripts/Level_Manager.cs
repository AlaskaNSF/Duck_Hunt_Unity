using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Level_Manager : MonoBehaviour
{
    public static int booksCaught;
    public static int booksDestroyed;
    public static int dementorsCaught;
    public static int dementorsDestroyed;
    public static int score;

    [Header("Game timer config")]
    public float timeRemaining = 60f;
    private bool gameActive = false;
    // Start is called once before the first execution of Update after the MonoBehaviour is created

    [Header("UI Config")]
    public CanvasGroup hudCanvasGroup;
    void Start()
    {
        booksCaught = 0;
        booksDestroyed = 0;
        dementorsCaught = 0;
        dementorsDestroyed = 0;
        score = 0;
        gameActive = false;

        if (hudCanvasGroup != null) hudCanvasGroup.alpha = 0;
    }

    public void StartTimer()
    {
        gameActive = true;

        if (hudCanvasGroup != null) hudCanvasGroup.alpha = 1;
    }

    public bool IsGameActive()
    {
        return gameActive;
    }

    void Update()
    {
        if (gameActive)
        {
            if (timeRemaining > 0)
            {
                timeRemaining -= Time.deltaTime;

                // Si por la resta el tiempo quedó negativo, lo clavo en 0
                if (timeRemaining < 0) timeRemaining = 0;
            }

            else
            {
                EndLevel();
            }
        }
    }

    void EndLevel()
    {
        gameActive = false;
        timeRemaining = 0;
        CancelInvoke();
        SceneManager.LoadScene("Game_over");
    }
}
