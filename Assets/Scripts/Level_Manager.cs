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
    public float timeRemaining = 30f;
    private bool gameActive = false;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        booksCaught = 0;
        booksDestroyed = 0;
        dementorsCaught = 0;
        dementorsDestroyed = 0;
        score = 0;
        gameActive = false;
    }

    public void StartTimer()
    {
        gameActive = true;
    }
    // Update is called once per frame
    void Update()
    {
        Debug.Log("Libros atrapados: " + booksCaught);
        Debug.Log("Libros destruidos: " + booksDestroyed);
        Debug.Log("Dementores atrapados: " + dementorsCaught);
        Debug.Log("Dementores destruidos: " + dementorsDestroyed);

        if (gameActive)
        {
            if (timeRemaining > 0)
            {
                timeRemaining -= Time.deltaTime;
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
        SceneManager.LoadScene("Game_over");
    }
}
