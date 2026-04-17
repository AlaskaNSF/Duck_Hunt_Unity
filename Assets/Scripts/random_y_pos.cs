using UnityEngine;

public class random_y_pos : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        transform.position = new Vector3(-6,Random.Range(1f,4f),0);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
