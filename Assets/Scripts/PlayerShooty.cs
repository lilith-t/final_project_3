using UnityEngine;

public class PlayerShooty : MonoBehaviour
{
    public GameObject bullet;
    public Transform tm;

    public float fireRate = 5f;
    public float nextFireTime = 0f;

    private AudioSource audioSource;
    public AudioClip gunshot;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void Shoot()
    {
        if (Time.time < nextFireTime)
        {
            return;
        }
        nextFireTime = Time.time + (1f / fireRate);
        Instantiate(bullet, tm.position, tm.rotation);
        audioSource.PlayOneShot(gunshot, 0.25f);

    }
}

