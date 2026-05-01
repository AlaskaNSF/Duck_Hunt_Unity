using UnityEngine;

public class Dementor_Shoot : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public Rigidbody2D dementorPhysics;
    public Animator dementorAnimations;

    [Header("Audio Config")]
    public AudioSource movementAudioSource;
    public AudioClip catchSound;
    public AudioClip killSound;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnMouseOver()
    {
        // Clic izquierdo (atrapar/catch)
        if (Input.GetMouseButtonDown(0))
        {
            HandleInteraction("Catch", catchSound);
            Level_Manager.dementorsCaught++;
            Game_Manager.score--;
        }

        // Clic derecho (destruir/kill)
        if (Input.GetMouseButtonDown(1))
        {
            HandleInteraction("Kill", killSound);
            Level_Manager.dementorsDestroyed++;
            Game_Manager.score++;
        }
    }

    void HandleInteraction(string triggerName, AudioClip feedbackSound)
    {
        // 1 - Desactivo la física para que el target quede quieto en el lugar donde se encuentre
        dementorPhysics.linearVelocity = UnityEngine.Vector2.zero;
        dementorPhysics.bodyType = RigidbodyType2D.Kinematic;

        // 2 - Desactivo el collider para evitar múltiples clics
        if (TryGetComponent<Collider2D>(out Collider2D col))
        {
            col.enabled = false;
        }

        // 3 - Freno la música de movimiento para reproducir efecto de catch o kill
        if (movementAudioSource != null)
        {
            movementAudioSource.Stop();
            movementAudioSource.PlayOneShot(feedbackSound);
        }

        // 4 - Seteo la animación de catch o kill y elimino el objeto
            dementorAnimations.SetTrigger(triggerName);
            Destroy(gameObject,2.5f);
    }
}