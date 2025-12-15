using UnityEngine;

public class PlayerShooty : MonoBehaviour
{
    public GameObject bullet;
    public Transform tm;

    public float fireRate = 5f;
    public float nextFireTime = 0f;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
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
    }
}

