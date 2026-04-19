using UnityEngine;

public class Book_Shoot : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public Rigidbody2D bookPhysics;
    public Animator bookAnimations;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnMouseOver()
    {
        if (Input.GetMouseButtonDown(0))
        {
            bookPhysics.linearVelocity = UnityEngine.Vector2.zero;
            bookPhysics.bodyType = RigidbodyType2D.Kinematic;

            if (TryGetComponent<Collider2D>(out Collider2D col)) {
                col.enabled = false;
            }
            bookAnimations.SetTrigger("Kill");
            Destroy(gameObject,2f);
        }

        if (Input.GetMouseButtonDown(1))
        {
            bookPhysics.linearVelocity = UnityEngine.Vector2.zero;
            bookPhysics.bodyType = RigidbodyType2D.Kinematic;

            if (TryGetComponent<Collider2D>(out Collider2D col)) {
                col.enabled = false;
            }
            bookAnimations.SetTrigger("Catch");
            Destroy(gameObject,2f);
        }
    }
}
