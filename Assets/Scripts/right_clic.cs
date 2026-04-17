using UnityEngine;

public class right_clic : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created

    public Rigidbody2D bookPhysics;
    //public Animator bookAnimation;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    void OnMouseDown()
    {
    bookPhysics.linearVelocity = Vector2.zero;
    bookPhysics.gravityScale = 1f;
    //bookAnimation.SetTrigger("Shoot");
    Destroy(gameObject,0f); //cambiar el 0f por un delay para la animacion
    }

}