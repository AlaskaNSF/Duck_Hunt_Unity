using UnityEngine;

public class book : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created

    public Rigidbody2D bookPhysics;
    public Vector3 speed;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        bookPhysics.AddForce(speed);
    }
}
