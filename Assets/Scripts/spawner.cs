using UnityEngine;

public class Spawner : MonoBehaviour
{
    [Header("Settings")]
    public GameObject[] targetBag;
    public float spawnDelay = 0.5f;

    private GameObject currentTarget; 
    private bool isWaitingToSpawn = false;
    
    // Referencia al manager para saber si el juego empezó
    private Level_Manager levelManager;


    void Update()
        {
            if (levelManager == null) {
                levelManager = Object.FindAnyObjectByType<Level_Manager>();
                return;
            }

            if (levelManager.IsGameActive() && currentTarget == null && !isWaitingToSpawn) {
                isWaitingToSpawn = true;
                Invoke("SpawnTarget", spawnDelay);
            }
        }

        void SpawnTarget()
        {
            if (levelManager != null && levelManager.IsGameActive() && targetBag.Length > 0) {
                int randomIndex = Random.Range(0, targetBag.Length);
                currentTarget = Instantiate(targetBag[randomIndex]);
            }
            isWaitingToSpawn = false;
        }
}
