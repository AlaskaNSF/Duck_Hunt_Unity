using UnityEngine;

public class Dementor : MonoBehaviour
{
    public Rigidbody2D dementorPhysics;
    public Vector3 speed;

    // Límites de la pantalla
    private float topLimit = 4;
    private float leftLimit = -7f;
    private float rightLimit = 7f;

    void Start()
    {
        
    }

    void Update()
    {
        // Aplicar movimiento
        dementorPhysics.AddForce(speed);

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