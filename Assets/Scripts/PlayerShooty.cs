using UnityEngine;

public class PlayerShooty : MonoBehaviour
{
    //initialising all the required variables
    public GameObject bullet;
    public Transform tm;

    public float fireRate = 5f;
    public float nextFireTime = 0f;

    private AudioSource audioSource;
    public AudioClip gunshot;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //creating audiosource from component
        audioSource = GetComponent<AudioSource>();
    }

    //function to shoot
    public void Shoot()
    {
        //making sure the gun caps out at a certain fire rate
        if (Time.time < nextFireTime)
        {
            return;
        }
        nextFireTime = Time.time + (1f / fireRate);
        //creating the bullet instance

        Instantiate(bullet, tm.position, tm.rotation);
        //playing gunshot audio
        audioSource.PlayOneShot(gunshot, 0.25f);

    }
}

