using UnityEngine;
using TMPro;

public class HUD : MonoBehaviour
{
    public TextMeshProUGUI timerText;

    void Update()
    {
        // Buscamos el Level_Manager para obtener el tiempo
        Level_Manager lm = Object.FindAnyObjectByType<Level_Manager>();

        if (lm != null)
        {
            timerText.text = "Time: " + Mathf.FloorToInt(lm.timeRemaining).ToString();
        }
    }
}
