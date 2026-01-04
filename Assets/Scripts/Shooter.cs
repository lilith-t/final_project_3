using UnityEditorInternal;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class Shooter : MonoBehaviour
{
    public static float score = 0;
    public float speed = 50f;
    public float lifetime = 5f;
    public TextMeshProUGUI scoreText;
    public AudioClip death;

    private Rigidbody rb;
    private AudioSource audioSource;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        rb.linearVelocity = transform.forward * speed;
        Destroy(gameObject, lifetime);
    }

    // Update is called once per frame
    private void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.tag == "Enemy")
        {
            Destroy(other.gameObject);
            Shooter.score += 1;

        }
    }
}