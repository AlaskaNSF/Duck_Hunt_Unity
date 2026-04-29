using UnityEngine;

public class Level_Manager : MonoBehaviour
{
    public static int booksCatched;
    public static int booksDestroyed;
    public static int dementorsCatched;
    public static int dementorsDestroyed;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        booksCatched = 0;
        booksDestroyed = 0;
        dementorsCatched = 0;
        dementorsDestroyed = 0;
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log("Libros atrapados: " + booksCatched);
        Debug.Log("Libros destruidos: " + booksDestroyed);
        Debug.Log("Dementores atrapados: " + dementorsCatched);
        Debug.Log("Dementores destruidos: " + dementorsDestroyed);
    }
}
