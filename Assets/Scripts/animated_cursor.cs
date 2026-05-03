using UnityEngine;
using UnityEngine.UI;

public class SoftwareCursor : MonoBehaviour
{
    [SerializeField] private Sprite[] cursorFrames;
    [SerializeField] private float frameRate = 0.1f;
    private Image cursorImage;
    private int currentFrame;
    private float timer;

    void Start()
    {
        cursorImage = GetComponent<Image>();
        // Para ocultar el cursor del sistema
        Cursor.visible = false;
        cursorImage.raycastTarget = false;
    }

    void Update()
    {
        // Seguimiento del mouse
        transform.position = Input.mousePosition;

        // Animación de los frames
        if (cursorFrames.Length > 0)
        {
            timer += Time.deltaTime;
            if (timer >= frameRate)
            {
                timer -= frameRate;
                currentFrame = (currentFrame + 1) % cursorFrames.Length;
                cursorImage.sprite = cursorFrames[currentFrame];
            }
        }
    }

    void OnDisable()
    {
        Cursor.visible = true;
    }
}