using UnityEngine;

public class ParallaxEffect : MonoBehaviour
{
    // Usamos Renderer para acceder al material y su offset
    private Renderer layerRenderer;
    
    [Header("Settings")]
    public float scrollSpeed = 0.05f; // Velocidad de movimiento
    
    // Guardamos el valor actual del offset
    private float offset = 0f;

    void Start()
    {
        layerRenderer = GetComponent<Renderer>();
    }

    void Update()
    {
        // Incrementamos el offset según el tiempo y la velocidad
        offset += Time.deltaTime * scrollSpeed;
        
        // Aplicamos el movimiento solo en el eje X (horizontal)
        // El valor de offset debe resetearse al llegar a 1 para ser eficiente
        layerRenderer.material.mainTextureOffset = new Vector2(0, offset);
    }
}