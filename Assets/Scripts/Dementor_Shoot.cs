using UnityEngine;

public class Dementor_Shoot : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public Rigidbody2D dementorPhysics;
    public Animator dementorAnimations;

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
            dementorPhysics.linearVelocity = UnityEngine.Vector2.zero;
            dementorPhysics.bodyType = RigidbodyType2D.Kinematic;

            if (TryGetComponent<Collider2D>(out Collider2D col)) {
                col.enabled = false;
            }
            dementorAnimations.SetTrigger("Kill");
            Destroy(gameObject,2f);
        }

        if (Input.GetMouseButtonDown(1))
        {
            dementorPhysics.linearVelocity = UnityEngine.Vector2.zero;
            dementorPhysics.bodyType = RigidbodyType2D.Kinematic;

            if (TryGetComponent<Collider2D>(out Collider2D col)) {
                col.enabled = false;
            }
            dementorAnimations.SetTrigger("Catch");
            Destroy(gameObject,2f);
        }
    }
}