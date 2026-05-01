using UnityEngine;

public class Book_Shoot : MonoBehaviour
{
    public Rigidbody2D bookPhysics;
    public Animator bookAnimations;

    [Header("Audio Config")]
    public AudioSource movementAudioSource;
    public AudioClip catchSound;
    public AudioClip killSound;

    void Start()
    {
        DontDestroyOnLoad(gameObject);
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
            Level_Manager.booksCaught++;
            Game_Manager.score++;
        }

        // Clic derecho (destruir/kill)
        if (Input.GetMouseButtonDown(1))
        {
            HandleInteraction("Kill", killSound);
            Level_Manager.booksDestroyed++;
            Game_Manager.score--;
        }
    }

    void HandleInteraction(string triggerName, AudioClip feedbackSound)
    {
        // 1 - Desactivo la física para que el target quede quieto en el lugar donde se encuentre
        bookPhysics.linearVelocity = UnityEngine.Vector2.zero;
        bookPhysics.bodyType = RigidbodyType2D.Kinematic;

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
            bookAnimations.SetTrigger(triggerName);
            Destroy(gameObject,2f);
    }
}