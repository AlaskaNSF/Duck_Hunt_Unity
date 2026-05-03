using UnityEngine;

public class H_book : MonoBehaviour
{
    public Rigidbody2D bookPhysics;
    public Vector3 speed;

    // Límites de la pantalla
    private float topLimit = 4;
    private float leftLimit = -8f;
    private float rightLimit = 8f;

    void Start()
    {
        
    }

    void Update()
    {
        // Aplicar movimiento
        bookPhysics.AddForce(speed);

        // Control de límites para limpieza de objetos y sonidos
        CheckScreenLimits();
    }

    private void CheckScreenLimits()
    {
        // Verifico si el objeto salió por arriba, por la izquierda o por la derecha
        if (transform.position.y > topLimit || 
            transform.position.x < leftLimit || 
            transform.position.x > rightLimit)
        {
            // Destruyo el objeto, para que no siga reproduciendo el sonido de vuelo
            Destroy(gameObject);
        }
    }
}
