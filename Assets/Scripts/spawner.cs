using UnityEngine;

public class Spawner : MonoBehaviour
{
    //float timer

    [Header("Settings")]
    public GameObject[] targetBag;
    public float spawnDelay = 1.0f; // Cambiar a 1.5 como estaba antes o probar 0.5

    private GameObject currentTarget; 
    private bool isWaitingToSpawn = false;

    void Update()
    {
        if (currentTarget == null && !isWaitingToSpawn)
        {
            Invoke("SpawnTarget", spawnDelay);
            isWaitingToSpawn = true;
        }
    }

    void SpawnTarget()
    {
        int randomIndex = Random.Range(0, targetBag.Length);

        currentTarget = Instantiate(targetBag[randomIndex]);

        isWaitingToSpawn = false;
    }
}