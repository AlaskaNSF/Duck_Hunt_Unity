using UnityEngine;
using UnityEngine.UI;

public class UI_Manager : MonoBehaviour
{
    public Text booksCaught;
    public Text booksDestroyed;
    public Text dementorsCaught;
    public Text dementorsDestroyed;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        booksCaught.text = "Books caught:" + Level_Manager.booksCaught;
        booksDestroyed.text = "Books destroyed:" + Level_Manager.booksDestroyed;
        dementorsCaught.text = "Dementors caught:" + Level_Manager.dementorsCaught;
        dementorsDestroyed.text = "Dementors destroyed:" + Level_Manager.dementorsDestroyed;
    }
}
