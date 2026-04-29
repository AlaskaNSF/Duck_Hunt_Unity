using UnityEngine;

public class Spawner : MonoBehaviour
{
    [Header("Settings")]
    public GameObject[] targetBag;
    public float spawnDelay = 1.5f;
    public float startTimer = 10.0f; 

    private GameObject currentTarget; 
    private bool isWaitingToSpawn = false;
    private float gameTimer = 0f; // Usaremos un contador manual más fiable

    void Update()
    {
        // 1. Contador para el inicio del juego
        if (gameTimer < startTimer)
        {
            gameTimer += Time.deltaTime;
            return; // Mientras no pasen los 10s, el código de abajo no se ejecuta
        }

        // 2. Lógica de Spawn (solo después de los 10s)
        if (currentTarget == null && !isWaitingToSpawn)
        {
            isWaitingToSpawn = true;
            // Usamos un pequeño retraso para que no sea instantáneo
            Invoke("SpawnTarget", spawnDelay);
        }
    }

    void SpawnTarget()
    {
        if (targetBag.Length > 0)
        {
            int randomIndex = Random.Range(0, targetBag.Length);
            currentTarget = Instantiate(targetBag[randomIndex]);
        }
        
        isWaitingToSpawn = false;
    }
}