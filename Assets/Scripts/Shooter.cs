using UnityEngine;
using TMPro;

public class Shooter : MonoBehaviour
{
    //initialising variables
    public static float score = 0;
    public float speed = 50f;
    public float lifetime = 5f;
    public TextMeshProUGUI scoreText;
    public AudioClip death;

    private Rigidbody rb;
    private AudioSource audioSource;
    void Awake()
    {
        //getting component of audio and rigid body
        audioSource = GetComponent<AudioSource>();
        rb = GetComponent<Rigidbody>();
        rb.linearVelocity = transform.forward * speed;
        //destroy the bullet after its lifetime expires
        Destroy(gameObject, lifetime);
    }

    private void OnCollisionEnter(Collision other)
    {
        //if bullet hits enemies destroys them increases score and plays enemy death sound
        if (other.gameObject.tag == "Enemy")
        {
            audioSource.PlayOneShot(death, 0.3f);
            Destroy(other.gameObject);
            Shooter.score += 1;
            scoreText.text = "Your Score: " + Shooter.score.ToString();

        }
    }
}