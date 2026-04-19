using UnityEngine;

public class D_book : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public Rigidbody2D bookPhysics;
    public UnityEngine.Vector3 speed;
    void Start()
    {
        Destroy(gameObject, 5f);
    }

    // Update is called once per frame
    void Update()
    {
        bookPhysics.AddForce(speed);
    }
}
