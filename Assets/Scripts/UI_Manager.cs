using UnityEngine;
using UnityEngine.UI;

public class UI_Manager : MonoBehaviour
{
    public Text booksCatched;
    public Text booksDestroyed;
    public Text dementorsCatched;
    public Text dementorsDestroyed;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        booksCatched.text = "Libros atrapados:" + Level_Manager.booksCatched;
        booksDestroyed.text = "Libros destruidos:" + Level_Manager.booksDestroyed;
        dementorsCatched.text = "Dementores atrapados:" + Level_Manager.dementorsCatched;
        dementorsDestroyed.text = "Dementores destruidos:" + Level_Manager.dementorsDestroyed;
    }
}
